<?php

include_once "CONFIG.php";
include_once "MySQL.php";

IPN::Invoke();

class IPN
{
	static private
	$LogFile,
	$LogEnabled,
	$Request,
	$Header,
	$PayPal,
	$Result,
	$TransData,
	$RawPost,
	$Testing;

	public static function Invoke()
	{        
		self::Initialize();
		self::ParsePostData();
		
		if(!isset(self::$TransData['credit_total']) || empty(self::$TransData['credit_total']))
			self::WriteToFile("\n***Credit Total not set: Possible 'hack' attempt?***\n"); 
		else
			self::ValidateTransaction(); 
		
		self::Finalize();
	}
	
	static public function Initialize()
	{
		if(!defined("LOGS_DIR"))
			self::$LogEnabled = false; 
		else
		{
			self::$LogEnabled = true;
			
			$filePath = LOGS_DIR . "/Transactions_" . date("m-d-y") . ".log";
			
			@chmod(LOGS_DIR, 0751);

			self::$LogFile = @fopen($filePath,"a+");
			self::WriteToFile("\n\n----------[NEW TRANSACTION]----------\n\n");
		}
		
		if(stripos(PAYPAL_SERVER, "sandbox") !== false)
			self::$Testing = true;
	}
	
	static private function ParsePostData()
	{  
		$raw_post_data = file_get_contents('php://input');
		$raw_post_array = explode('&', $raw_post_data);
		self::$RawPost = array();
		
		foreach ($raw_post_array as $keyval)
		{
			$keyval = explode ('=', $keyval);
			
			if (count($keyval) == 2)
				self::$RawPost[$keyval[0]] = urldecode($keyval[1]);
		}
		
		self::$Request = 'cmd=_notify-validate';
		
		if(function_exists('get_magic_quotes_gpc'))		
			$get_magic_quotes_exits = true;
		
		foreach (self::$RawPost as $key => $value)
		{
			self::WriteToFile("[" . $key . "] == [" . $value . "]\n");
			
			switch($key)
			{
				case 'payment_status': { self::$TransData['payment_status'] = $value; } break;
				case 'mc_currency': { self::$TransData['payment_currency'] = $value; } break;
				case 'txn_id': { self::$TransData['txn_id'] = $value; } break;
				case 'receiver_email': { self::$TransData['receiver_email'] = $value; } break;
				case 'payer_email': { self::$TransData['payer_email'] = $value; } break;
				case 'custom': { self::$TransData['payer_account'] = $value; } break;
				case 'note': { self::$TransData['payer_note'] = $value; } break;
				case 'custom': { self::$TransData['extra_info'] = $value; } break;
				case 'pending_reason': { self::$TransData['pending_reason'] = $value; } break;
			}
			
			if($get_magic_quotes_exits == true && get_magic_quotes_gpc() == 1)
				$value = urlencode(stripslashes($value));		
			else			
				$value = urlencode($value);
			
			self::$Request .= "&$key=$value";
		}
		
		self::$TransData['extra_info'] = "";
		
		if(!isset(self::$TransData['payer_account']) || empty(self::$TransData['payer_account']))
		{	
			self::$TransData['payer_account'] = DEFAULT_ACCT;
			self::$TransData['extra_info'] .= "[account not supplied]";
		}
		
		$cTotal = 0;
		$cGross = 0.0;
		
		$idx = 0;
			
		while(self::ParseItemInfo($idx++, $cTotal, $cGross))
			self::WriteToFile("[" . ($idx- 1) . "] == [" . ITEM_NUMBER . "]\n");
		
		if($cGross > 0 && $cTotal > 0)
		{
			self::$TransData['credit_total'] = $cTotal;	
			self::$TransData['credit_gross'] = $cGross;
		}
		
		if(isset(self::$RawPost['test_ipn']) && !empty(self::$RawPost['test_ipn']))
			self::$Testing = true; 
	}
	
	static private function ParseItemInfo($idx, &$total, &$gross)
	{
		$index = ($idx <= 0) ? '' : (string)$idx;
		
		$num = isset(self::$RawPost['item_number' . $index]) ? (string)self::$RawPost['item_number' . $index] : '';
			
		if(empty($num))
		{
			return false;
		}
			
		if(strcmp($num, ITEM_NUMBER) == 0)
		{
			$total += (int)self::$RawPost['quantity' . $index];
			$gross += (double)self::$RawPost['mc_gross' . $index];
		}
		
		return true;
	}
	
	static private function ValidateTransaction()
	{    
		self::$Header = array();
		self::$Header[] = "POST /cgi-bin/webscr HTTP/1.1";
		self::$Header[] = "Content-Type: application/x-www-form-urlencoded";
		self::$Header[] = "Host: " . PAYPAL_SERVER;
		self::$Header[] = "Connection: close";
		
		self::$PayPal = curl_init();
		curl_setopt(self::$PayPal, CURLOPT_URL, 'https://' . PAYPAL_SERVER . '/cgi-bin/webscr');
		curl_setopt(self::$PayPal, CURLOPT_POST, 1);
		curl_setopt(self::$PayPal, CURLOPT_RETURNTRANSFER,1);
		curl_setopt(self::$PayPal, CURLOPT_POSTFIELDS, self::$Request);
		curl_setopt(self::$PayPal, CURLOPT_SSL_VERIFYPEER, 1);
		curl_setopt(self::$PayPal, CURLOPT_SSL_VERIFYHOST, 2);
		curl_setopt(self::$PayPal, CURLOPT_HTTPHEADER, self::$Header);
		self::$Result = curl_exec(self::$PayPal);
		curl_close(self::$PayPal);
		
		if (!self::$Result)
			self::WriteToFile("\nERROR:\nThere was a problem connecting to the IPN server (". PAYPAL_SERVER .")");
		else
		{				
			if (strcmp(self::$Result, "INVALID") == 0)
			{
				$Q="REPLACE INTO ". DB_TABLE ." (id,state,account,email,total,credit,time,version,notes,extra) VALUES ('".self::$TransData['txn_id']."', 'VOIDED', '".self::$TransData['payer_account']."', '".self::$TransData['payer_email']."', '".self::$TransData['credit_gross']."', '".self::$TransData['credit_total']."', '".(time())."', '0', '".self::$TransData['payer_note']."', 'VOIDED - Payment was confirmed INVALID by PayPal. Treat as suspicious. ".self::$TransData['extra_info']."')";
				
				if(!self::$Testing)
					MySQL::Query($Q); 
				
				self::WriteToFile("[Invalid] = [".$Q."]\n");
			}
			else if (strcmp(self::$Result, "VERIFIED") == 0)
			{
				if(strtoupper(self::$TransData['payment_status']) == "PENDING")					
					self::WriteToFile("[Pending Payment] = [" . self::$TransData['pending_reason'] . "]\n");					
				else if(strtoupper(self::$TransData['payment_status']) == "COMPLETED")
				{
					if (self::$TransData['receiver_email'] != PAYPAL_EMAIL)
					{
						$Q="REPLACE INTO ". DB_TABLE ." (id,state,account,email,total,credit,time,version,notes,extra) VALUES ('".self::$TransData['txn_id']."', 'VOIDED', '".self::$TransData['payer_account']."', '".self::$TransData['payer_email']."', '".self::$TransData['credit_gross']."','".self::$TransData['credit_total']."', '".(time())."', '0', '".self::$TransData['payer_note']."', 'VOIDED - Payment receiver was edited before processing. Treat as suspicious. ".self::$TransData['extra_info']."')";
						
						if(!self::$Testing)
							MySQL::Query($Q); 
						
						self::WriteToFile("[Email Changed] = [".$Q."]\n");
					}
					else if(self::$TransData['credit_gross'] != (self::$TransData['credit_total'] * ITEM_PRICE))
					{
						$Q="REPLACE INTO ". DB_TABLE ." (id,state,account,email,total,credit,time,version,notes,extra) VALUES ('".self::$TransData['txn_id']."', 'VOIDED', '".self::$TransData['payer_account']."', '".self::$TransData['payer_email']."', '".self::$TransData['credit_gross']."', '".self::$TransData['credit_total']."', '".(time())."', '0', '".self::$TransData['payer_note']."', 'VOIDED - Payment amount was edited before processing. Treat as suspicious. ".self::$TransData['extra_info']."')";
						
						if(!self::$Testing)
							MySQL::Query($Q); 
						
						self::WriteToFile("[Amount Changed] = [".$Q."]\n");
					}
					else
					{						
						$Q="REPLACE INTO ". DB_TABLE ." (id,state,account,email,total,credit,time,version,notes,extra) VALUES ('".self::$TransData['txn_id']."', 'PENDING', '".self::$TransData['payer_account']."', '".self::$TransData['payer_email']."', '".self::$TransData['credit_gross']."', '".self::$TransData['credit_total']."', '".(time())."', '0', '".self::$TransData['payer_note']."', 'COMPLETE - Payment was successfully verified. ".self::$TransData['extra_info']."')";
						
						if(!self::$Testing)
							MySQL::Query($Q); 
						
						self::WriteToFile("[Completed] = [".$Q."]\n");
					}
				}
				else
				{					
					$Q="REPLACE INTO ". DB_TABLE ." (id,state,account,email,total,credit,time,version,notes,extra) VALUES ('".self::$TransData['txn_id']."', 'VOIDED', '".self::$TransData['payer_account']."', '".self::$TransData['payer_email']."', '".self::$TransData['credit_gross']."', '".self::$TransData['credit_total']."', '".(time())."', '0', '".self::$TransData['payer_note']."', 'VOIDED - Payment was not confirmed by PayPal. Treat as suspicious. ".self::$TransData['extra_info']."')";
					
					if(!self::$Testing)
						MySQL::Query($Q); 
					
					self::WriteToFile("[Email Changed] = [".$Q."]\n");
				}
			}
		}
	}
	
	static private function Finalize()
	{    
		self::WriteToFile("\n\n----------[END OF TRANSACTION]----------\n\n");
		
		if(self::$LogEnabled)
			@fclose(self::$LogFile); 
	}
	
	static private function WriteToFile($text)
	{ 
		if(self::$LogEnabled)
			@fwrite(self::$LogFile, $text); 
	}	
}

?>