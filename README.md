FavUO Git Repository

FavUO is a Ultima Online editor based off of RunUO 2.6 and is based to be the closest thing to Hybrid and Zenvera servers. Max server client is 7.0.51.0

FavUO's files include a massive amount of custom packages including poker, full pvp system and player info tabs, and more!

Typical Windows Build

Compile with Visual Studio Community

Typical Linux Build (MONO)

~/favuo$ dmcs -optimize+ -unsafe -t:exe -out:FavUO.exe -win32icon:Server/favuo.ico -nowarn:219,414 -d:MONO -recurse:Server/*.cs

FavUO supports Intel's hardware random number generator (Secure Key, Bull Mountain, rdrand, etc). If rdrand32.dll/rdrand64.dll are present in the base directory and the hardware supports that functionality, it will be used automatically. You can find those libraries here: https://github.com/msturgill/rdrand/releases/latest

Latest Razor builds can be found at https://github.com/FavUO/Razor

IRC: chat.freenode.net #favuo.