<?PHP
MySQL::Invoke();

class MySQL
{
	static private
	$Connection;
   
	static public function Invoke()
	{
	    if(self::$Connection = mysql_pconnect(DB_SERVER, DB_USER, DB_PASS))
	    {
			if(!mysql_select_db(DB_NAME, self::$Connection))
			{ return; }
		}
   	}
   
	function query($query)
	{
		return @mysql_query($query, self::$Connection);
	}
   
	function fquery($query)
	{
		$result = @mysql_query($query, self::$Connection);
		return @mysql_fetch_array($result);
	}
}
?>