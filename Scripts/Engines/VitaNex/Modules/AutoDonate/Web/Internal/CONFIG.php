<?PHP

//All settings in this config file must match those you have chosen on your shard.
//
//This config file pertains only to the IPN processor, when adding the HTML buttons
//to your site, the button's code variables should match these options where applicable.
//
//For support, or assistance in setting-up, contact Vorspire:
//Skype: VorspireLG
//Email: admin@vita-nex.com

//Database Options (Same as AutoDonate System Options in RunUO)
define("DB_SERVER", "255.255.255.255");
define("DB_PORT", "3306");
define("DB_USER", "**********");
define("DB_PASS", "**********");
define("DB_NAME", "donate_db");
define("DB_TABLE", "donate_trans");

//This is the logs directory; If you want to keep a log of all transactions, uncomment this option.
//If you uncomment this option, make sure the path is valid and the directory exists.
//define("LOGS_DIR", "Logs"); 

//The default RunUO account to use when the target account is not set.
//This should be an account with Owner access.
define("DEFAULT_ACCT", "**********");

//The PayPal server to use, usually www.paypal.com
//Use www.sandbox.paypal.com when testing.
define("PAYPAL_SERVER", "www.paypal.com");

//Your PayPal email address.
define("PAYPAL_EMAIL", "user@domain.com");

//An Item Number to identify and process valid transactions.
//This must be a valid Type name on your shard.
define("ITEM_NUMBER", "Gold");

//The amount of currency PER UNIT of Credits. (Exchange rate)
//EG 1, $1.00 == 1 Gold Coin
//EG 2, $0.01 == 1 Gold Coin ($1.00 == 100 Gold Coins)
define("ITEM_PRICE", 1.00);

?>