-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.5.20 - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL version:             7.0.0.4160
-- Date/time:                    2012-10-25 17:11:51
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping database structure for sharejoy
CREATE DATABASE IF NOT EXISTS `sharejoy` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `sharejoy`;


-- Dumping structure for table sharejoy.share
CREATE TABLE IF NOT EXISTS `share` (
  `id` int(10) NOT NULL,
  `category` int(10) NOT NULL,
  `category_title` varchar(50) NOT NULL,
  `content` varchar(500) NOT NULL,
  `resource` varchar(50) NOT NULL,
  `update_date` datetime DEFAULT NULL,
  `create_date` datetime NOT NULL,
  `update_user` varchar(50) DEFAULT NULL,
  `create_user` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table sharejoy.share: ~0 rows (approximately)
/*!40000 ALTER TABLE `share` DISABLE KEYS */;
INSERT INTO `share` (`id`, `category`, `category_title`, `content`, `resource`, `update_date`, `create_date`, `update_user`, `create_user`) VALUES
	(1, 1, '笑话', '袁芳你怎么看', '1223', '2012-10-25 14:15:15', '2012-10-25 14:15:17', 'admin', 'admin'),
	(0, 0, 'werwer', 'werwer', '', NULL, '2012-10-25 17:03:11', NULL, 'admin'),
	(0, 0, 'werwer', 'werwer', 'ghj', NULL, '2012-10-25 17:03:14', NULL, 'admin');
/*!40000 ALTER TABLE `share` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
