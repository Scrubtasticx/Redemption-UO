Vita-Nex: Core - Automated Donations Module

Website: http://core.vita-nex.com
Skype: VorspireLG
Email: admin@vita-nex.com


REQUIREMENTS:

* Vita-Nex: Core 2.1.0.0 or later.
* PHP enabled web host service, with cURL permissions.
* Local or remote access to a MySQL database server.
* MySQL database user with read/write/create permissions.
* MySQL ODBC database driver (installed on the same machine as RunUO)


INSTALL:

1.
Drop the AutoDonate directory in to your /Scripts directory, as long
as it's in there, the module will compile.

2.
Boot your shard and use the [DonateConfig command to begin choosing
your options.

3.
Install the PHP files (found in the 'Internal' directory) to your
web host, make a note of the fully qualified URL used to access them.
The PHP files are CONFIG.php, MYSQL.php and IPN.php

4.
Edit CONFIG.php, adjust the settings to match the ones you used on
your shard in step 2.

5.
Copy the code from button.html and use it wherever you want players
to see a donation button.

6.
Make sure your button code variables match those of your config
settings from step 2 and 4, where applicable.

7.
Run some tests! If everything is successful, RunUO will connect to
your MySQL database and process any transactions that it finds.


COMMANDS:

[Donateconfig - The main command for administration of the RunUO module.

[CheckDonate - The command used by players to check their transactions
and claim their rewards.


NOTES:

If any of the configuration options do not match up, the module will not
function correctly and will treat transactions as suspicious as part of
it's security procedures.
The module can detect fraudulent transactions and prevent the delivery
of rewards automatically.
All transactions retain important information and notes, where applicable.