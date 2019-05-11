-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.3.10-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for ultima
DROP DATABASE IF EXISTS `ultima`;
CREATE DATABASE IF NOT EXISTS `ultima` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `ultima`;

-- Dumping structure for table ultima.myrunuo_characters
DROP TABLE IF EXISTS `myrunuo_characters`;
CREATE TABLE IF NOT EXISTS `myrunuo_characters` (
  `char_id` int(12) unsigned DEFAULT NULL,
  `char_name` varchar(150) DEFAULT NULL,
  `char_title` varchar(150) DEFAULT NULL,
  `char_race` varchar(150) DEFAULT NULL,
  `char_body` varchar(10) NOT NULL,
  `char_str` int(3) unsigned DEFAULT NULL,
  `char_dex` int(3) unsigned DEFAULT NULL,
  `char_int` int(3) unsigned DEFAULT NULL,
  `char_female` int(2) unsigned DEFAULT NULL,
  `char_counts` int(3) unsigned DEFAULT NULL,
  `char_guild` varchar(4) DEFAULT NULL,
  `char_guildtitle` varchar(150) DEFAULT NULL,
  `char_nototitle` varchar(150) DEFAULT NULL,
  `char_bodyhue` int(3) unsigned DEFAULT NULL,
  `char_karma` int(6) DEFAULT NULL,
  `char_fame` int(6) DEFAULT NULL,
  `char_public` int(1) unsigned DEFAULT 1,
  UNIQUE KEY `char_id_2` (`char_id`),
  KEY `char_id` (`char_id`),
  KEY `char_guild` (`char_guild`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Dumping data for table ultima.myrunuo_characters: 10 rows
DELETE FROM `myrunuo_characters`;
/*!40000 ALTER TABLE `myrunuo_characters` DISABLE KEYS */;
INSERT INTO `myrunuo_characters` (`char_id`, `char_name`, `char_title`, `char_race`, `char_body`, `char_str`, `char_dex`, `char_int`, `char_female`, `char_counts`, `char_guild`, `char_guildtitle`, `char_nototitle`, `char_bodyhue`, `char_karma`, `char_fame`, `char_public`) VALUES
	(359, 'Zycron', '', 'Human', '400', 100, 25, 100, 0, 0, '1', 'NULL', 'Zycron', 33770, 0, 0, 1),
	(339, 'Fortify', '', 'Human', '400', 34, 25, 31, 0, 0, 'NULL', 'NULL', 'Fortify', 33770, 0, 0, 1),
	(376, 'a panther', '', 'Human', '400', 45, 35, 10, 0, 0, 'NULL', 'NULL', 'a panther', 33770, 0, 0, 1),
	(382, 'a dex troll', '', 'Human', '400', 45, 35, 10, 0, 0, 'NULL', 'NULL', 'a dex troll', 33770, 0, 0, 1),
	(440, 'Im so Hood', '', 'Human', '401', 45, 35, 10, 1, 0, 'NULL', 'NULL', 'Im so Hood', 33770, 0, 0, 1),
	(757, 'Warlorn', '', 'Human', '400', 25, 20, 45, 0, 0, '2', 'NULL', 'Warlorn', 33770, 0, 0, 1),
	(1337, 'Rage', '', 'Human', '401', 25, 20, 45, 1, 0, 'NULL', 'NULL', 'Rage', 33770, 0, 0, 0),
	(1420, 'Spare Change', '', 'Human', '400', 25, 20, 45, 0, 0, 'NULL', 'NULL', 'Spare Change', 33770, 0, 0, 0),
	(600, 'a mage troll', '', 'Human', '400', 25, 20, 45, 0, 0, 'NULL', 'NULL', 'a mage troll', 33770, 0, 0, 0),
	(626, 'Get Shat Apon', '', 'Human', '400', 45, 35, 10, 0, 0, 'NULL', 'NULL', 'Get Shat Apon', 33770, 0, 0, 0);
/*!40000 ALTER TABLE `myrunuo_characters` ENABLE KEYS */;

-- Dumping structure for table ultima.myrunuo_characters_layers
DROP TABLE IF EXISTS `myrunuo_characters_layers`;
CREATE TABLE IF NOT EXISTS `myrunuo_characters_layers` (
  `char_id` int(12) unsigned DEFAULT NULL,
  `layer_id` int(3) unsigned DEFAULT NULL,
  `item_id` int(12) unsigned DEFAULT NULL,
  `item_hue` int(3) unsigned DEFAULT NULL,
  KEY `charid` (`char_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Dumping data for table ultima.myrunuo_characters_layers: 55 rows
DELETE FROM `myrunuo_characters_layers`;
/*!40000 ALTER TABLE `myrunuo_characters_layers` DISABLE KEYS */;
INSERT INTO `myrunuo_characters_layers` (`char_id`, `layer_id`, `item_id`, `item_hue`) VALUES
	(359, 0, 8251, 1102),
	(339, 0, 7939, 2301),
	(339, 1, 8251, 1102),
	(376, 0, 5397, 1109),
	(376, 1, 5422, 246),
	(376, 2, 5903, 1728),
	(376, 3, 8059, 837),
	(376, 4, 7939, 1328),
	(376, 5, 5912, 0),
	(382, 0, 5397, 1109),
	(382, 1, 7933, 244),
	(382, 2, 5433, 133),
	(382, 3, 5903, 1730),
	(382, 4, 7939, 1251),
	(382, 5, 5119, 0),
	(382, 6, 8251, 1102),
	(440, 0, 5399, 887),
	(440, 1, 5903, 1706),
	(440, 2, 5398, 269),
	(440, 3, 5062, 0),
	(440, 4, 5912, 0),
	(757, 0, 5399, 130),
	(757, 1, 5433, 262),
	(757, 2, 5903, 1721),
	(757, 3, 5062, 0),
	(757, 4, 7939, 1337),
	(757, 5, 5912, 0),
	(1337, 0, 7933, 184),
	(1337, 1, 5903, 1719),
	(1337, 2, 5431, 830),
	(1337, 3, 5062, 0),
	(1337, 4, 7939, 1312),
	(1337, 5, 3834, 0),
	(1337, 6, 5912, 0),
	(1420, 0, 7933, 416),
	(1420, 1, 5422, 414),
	(1420, 2, 5903, 1737),
	(1420, 3, 5062, 0),
	(1420, 4, 7939, 1328),
	(1420, 5, 3834, 0),
	(1420, 6, 5912, 0),
	(600, 0, 5399, 204),
	(600, 1, 5433, 452),
	(600, 2, 5903, 1705),
	(600, 3, 5062, 0),
	(600, 4, 7939, 1339),
	(600, 5, 3834, 0),
	(600, 6, 5912, 0),
	(626, 0, 5433, 301),
	(626, 1, 5903, 1728),
	(626, 2, 5068, 0),
	(626, 3, 8059, 123),
	(626, 4, 7939, 1708),
	(626, 5, 5119, 0),
	(626, 6, 8251, 1102);
/*!40000 ALTER TABLE `myrunuo_characters_layers` ENABLE KEYS */;

-- Dumping structure for table ultima.myrunuo_characters_skills
DROP TABLE IF EXISTS `myrunuo_characters_skills`;
CREATE TABLE IF NOT EXISTS `myrunuo_characters_skills` (
  `char_id` int(12) unsigned DEFAULT NULL,
  `skill_id` int(3) unsigned DEFAULT NULL,
  `skill_value` int(3) unsigned DEFAULT NULL,
  KEY `charid` (`char_id`),
  KEY `skillid` (`skill_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Dumping data for table ultima.myrunuo_characters_skills: 49 rows
DELETE FROM `myrunuo_characters_skills`;
/*!40000 ALTER TABLE `myrunuo_characters_skills` DISABLE KEYS */;
INSERT INTO `myrunuo_characters_skills` (`char_id`, `skill_id`, `skill_value`) VALUES
	(359, 0, 1000),
	(359, 16, 1000),
	(359, 23, 1000),
	(359, 25, 1000),
	(359, 26, 1000),
	(359, 30, 1000),
	(359, 46, 1000),
	(339, 0, 1000),
	(339, 2, 1000),
	(339, 16, 1000),
	(339, 25, 1000),
	(339, 26, 1000),
	(339, 35, 1000),
	(339, 46, 1000),
	(376, 21, 300),
	(376, 25, 300),
	(376, 33, 300),
	(376, 46, 300),
	(382, 0, 300),
	(382, 21, 300),
	(382, 26, 300),
	(382, 27, 300),
	(382, 46, 6),
	(440, 0, 300),
	(440, 25, 300),
	(440, 26, 300),
	(440, 43, 300),
	(440, 46, 4),
	(757, 16, 301),
	(757, 25, 503),
	(757, 43, 300),
	(757, 46, 500),
	(1337, 16, 300),
	(1337, 25, 500),
	(1337, 43, 300),
	(1337, 46, 500),
	(1420, 16, 300),
	(1420, 25, 500),
	(1420, 43, 300),
	(1420, 46, 500),
	(600, 16, 303),
	(600, 25, 500),
	(600, 43, 300),
	(600, 46, 520),
	(626, 1, 300),
	(626, 17, 450),
	(626, 27, 500),
	(626, 40, 350),
	(626, 46, 5);
/*!40000 ALTER TABLE `myrunuo_characters_skills` ENABLE KEYS */;

-- Dumping structure for table ultima.myrunuo_guilds
DROP TABLE IF EXISTS `myrunuo_guilds`;
CREATE TABLE IF NOT EXISTS `myrunuo_guilds` (
  `guild_id` varchar(4) DEFAULT NULL,
  `guild_name` varchar(150) DEFAULT NULL,
  `guild_abbreviation` varchar(4) DEFAULT NULL,
  `guild_website` varchar(150) DEFAULT NULL,
  `guild_charter` varchar(250) DEFAULT NULL,
  `guild_type` varchar(8) DEFAULT NULL,
  `guild_wars` int(3) unsigned DEFAULT NULL,
  `guild_members` int(3) unsigned DEFAULT NULL,
  `guild_master` int(12) unsigned DEFAULT NULL,
  KEY `guild_id` (`guild_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Dumping data for table ultima.myrunuo_guilds: 2 rows
DELETE FROM `myrunuo_guilds`;
/*!40000 ALTER TABLE `myrunuo_guilds` DISABLE KEYS */;
INSERT INTO `myrunuo_guilds` (`guild_id`, `guild_name`, `guild_abbreviation`, `guild_website`, `guild_charter`, `guild_type`, `guild_wars`, `guild_members`, `guild_master`) VALUES
	('1', 'Epic Kills', 'EPiC', NULL, NULL, 'Standard', 0, 1, 359),
	('2', 'EPiC Kills', 'EPC', NULL, NULL, 'Standard', 0, 1, 757);
/*!40000 ALTER TABLE `myrunuo_guilds` ENABLE KEYS */;

-- Dumping structure for table ultima.myrunuo_guilds_wars
DROP TABLE IF EXISTS `myrunuo_guilds_wars`;
CREATE TABLE IF NOT EXISTS `myrunuo_guilds_wars` (
  `guild_1` varchar(4) DEFAULT NULL,
  `guild_2` varchar(4) DEFAULT NULL,
  KEY `guild1` (`guild_1`),
  KEY `guild2` (`guild_2`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Dumping data for table ultima.myrunuo_guilds_wars: 0 rows
DELETE FROM `myrunuo_guilds_wars`;
/*!40000 ALTER TABLE `myrunuo_guilds_wars` DISABLE KEYS */;
/*!40000 ALTER TABLE `myrunuo_guilds_wars` ENABLE KEYS */;

-- Dumping structure for table ultima.myrunuo_skills
DROP TABLE IF EXISTS `myrunuo_skills`;
CREATE TABLE IF NOT EXISTS `myrunuo_skills` (
  `id` int(3) NOT NULL,
  `short_name` varchar(25) NOT NULL,
  `long_name` varchar(50) NOT NULL,
  `uo_guide_name` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Dumping data for table ultima.myrunuo_skills: 58 rows
DELETE FROM `myrunuo_skills`;
/*!40000 ALTER TABLE `myrunuo_skills` DISABLE KEYS */;
INSERT INTO `myrunuo_skills` (`id`, `short_name`, `long_name`, `uo_guide_name`) VALUES
	(0, 'Alchemy', 'Alchemy', 'Alchemy'),
	(1, 'Anatomy', 'Anatomy', 'Anatomy'),
	(2, 'AnimalLore', 'Animal Lore', 'Animal_Lore'),
	(3, 'ItemID', 'Item Identification', 'Item_Identification'),
	(4, 'ArmsLore', 'Arms Lore', 'Arms_Lore'),
	(5, 'Parry', 'Parry', 'Parry'),
	(6, 'Begging', 'Begging', 'Begging'),
	(7, 'Blacksmith', 'Blacksmithy', 'Blacksmithy'),
	(8, 'Fletching', 'Bowcraft & Fletching', 'Bowcraft_%26_Fletching'),
	(9, 'Peacemaking', 'Peacemaking', 'Peacemaking'),
	(10, 'Camping', 'Camping', 'Camping'),
	(11, 'Carpentry', 'Carpentry', 'Carpentry'),
	(12, 'Cartography', 'Cartography', 'Cartography'),
	(13, 'Cooking', 'Cooking', 'Cooking'),
	(14, 'DetectHidden', 'Detecting Hidden', 'Detecting_Hidden'),
	(15, 'Discordance', 'Discordance', 'Discordance'),
	(16, 'EvalInt', 'Evaluating Intelligence', 'Evaluating_Intelligence'),
	(17, 'Healing', 'Healing', 'Healing'),
	(18, 'Fishing', 'Fishing', 'Fishing'),
	(19, 'Forensics', 'Forensic Evalutation', 'Forensic_Evalutation'),
	(20, 'Herding', 'Herding', 'Herding'),
	(21, 'Hiding', 'Hiding', 'Hiding'),
	(22, 'Provocation', 'Provocation', 'Provocation'),
	(23, 'Inscribe', 'Inscription', 'Inscription'),
	(24, 'Lockpicking', 'Lockpicking', 'Lockpicking'),
	(25, 'Magery', 'Magery', 'Magery'),
	(26, 'MagicResist', 'Resisting Spells', 'Resisting_Spells'),
	(27, 'Tactics', 'Tactics', 'Tactics'),
	(28, 'Snooping', 'Snooping', 'Snooping'),
	(29, 'Musicianship', 'Musicianship', 'Musicianship'),
	(30, 'Poisoning', 'Poisoning', 'Poisoning'),
	(31, 'Archery', 'Archery', 'Archery'),
	(32, 'SpiritSpeak', 'Spirit Speak', 'Spirit_Speak'),
	(33, 'Stealing', 'Stealing', 'Stealing'),
	(34, 'Tailoring', 'Tailoring', 'Tailoring'),
	(35, 'AnimalTaming', 'Animal Taming', 'Animal_Taming'),
	(36, 'TasteID', 'Taste Identification', 'Taste_Identification'),
	(37, 'Tinkering', 'Tinkering', 'Tinkering'),
	(38, 'Tracking', 'Tracking', 'Tracking'),
	(39, 'Veterinary', 'Veterinary', 'Veterinary'),
	(40, 'Swords', 'Swordsmanship', 'Swordsmanship'),
	(41, 'Macing', 'Macing', 'Macing'),
	(42, 'Fencing', 'Fencing', 'Fencing'),
	(43, 'Wrestling', 'Wrestling', 'Wrestling'),
	(44, 'Lumberjacking', 'Lumberjacking', 'Lumberjacking'),
	(45, 'Mining', 'Mining', 'Mining'),
	(46, 'Meditation', 'Meditation', 'Meditation'),
	(47, 'Stealth', 'Stealth', 'Stealth'),
	(48, 'RemoveTrap', 'Remove Trap', 'Remove_Trap'),
	(49, 'Necromancy', 'Necromancy', 'Necromancy'),
	(50, 'Focus', 'Focus', 'Focus'),
	(51, 'Chivalry', 'Chivalry', 'Chivalry'),
	(52, 'Bushido', 'Bushido', 'Bushido'),
	(53, 'Ninjitsu', 'Ninjitsu', 'Ninjitsu'),
	(54, 'Spellweaving', 'Spellweaving', 'Spellweaving'),
	(55, 'Mysticism', 'Mysticism', 'Mysticism'),
	(56, 'Imbuing', 'Imbuing', 'Imbuing'),
	(57, 'Throwing', 'Throwing', 'Throwing');
/*!40000 ALTER TABLE `myrunuo_skills` ENABLE KEYS */;

-- Dumping structure for table ultima.myrunuo_status
DROP TABLE IF EXISTS `myrunuo_status`;
CREATE TABLE IF NOT EXISTS `myrunuo_status` (
  `char_id` int(12) unsigned DEFAULT NULL,
  `char_location` varchar(14) DEFAULT NULL,
  `char_map` varchar(8) DEFAULT NULL,
  `char_karma` int(6) DEFAULT NULL,
  `char_fame` int(6) DEFAULT NULL,
  KEY `charid` (`char_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Dumping data for table ultima.myrunuo_status: 1 rows
DELETE FROM `myrunuo_status`;
/*!40000 ALTER TABLE `myrunuo_status` DISABLE KEYS */;
INSERT INTO `myrunuo_status` (`char_id`, `char_location`, `char_map`, `char_karma`, `char_fame`) VALUES
	(338, NULL, NULL, NULL, NULL);
/*!40000 ALTER TABLE `myrunuo_status` ENABLE KEYS */;

-- Dumping structure for table ultima.myrunuo_timestamps
DROP TABLE IF EXISTS `myrunuo_timestamps`;
CREATE TABLE IF NOT EXISTS `myrunuo_timestamps` (
  `time_datetime` varchar(22) DEFAULT NULL,
  `time_type` varchar(6) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Dumping data for table ultima.myrunuo_timestamps: 0 rows
DELETE FROM `myrunuo_timestamps`;
/*!40000 ALTER TABLE `myrunuo_timestamps` DISABLE KEYS */;
/*!40000 ALTER TABLE `myrunuo_timestamps` ENABLE KEYS */;

-- Dumping structure for table ultima.myrunuo_updates
DROP TABLE IF EXISTS `myrunuo_updates`;
CREATE TABLE IF NOT EXISTS `myrunuo_updates` (
  `last_update` varchar(255) NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- Dumping data for table ultima.myrunuo_updates: 3 rows
DELETE FROM `myrunuo_updates`;
/*!40000 ALTER TABLE `myrunuo_updates` DISABLE KEYS */;
INSERT INTO `myrunuo_updates` (`last_update`, `timestamp`) VALUES
	('0.000099058940069341', '2019-02-10 11:13:27'),
	('0.000099058940069341', '2019-02-10 11:20:48'),
	('0.000099058940069341', '2019-02-10 11:52:47');
/*!40000 ALTER TABLE `myrunuo_updates` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
