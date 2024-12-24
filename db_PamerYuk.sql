-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: db_pameryuk
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `kisahhidup`
--

DROP TABLE IF EXISTS `kisahhidup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kisahhidup` (
  `Organisasi_id` int(11) NOT NULL,
  `username` varchar(40) NOT NULL,
  `thawal` varchar(4) DEFAULT NULL,
  `thakhir` varchar(4) DEFAULT NULL,
  `deskripsi` text DEFAULT NULL,
  PRIMARY KEY (`Organisasi_id`,`username`),
  KEY `fk_Organisasi_username_username1_idx` (`username`),
  KEY `fk_Organisasi_username_Organisasi1_idx` (`Organisasi_id`),
  CONSTRAINT `fk_Organisasi_username_Organisasi1` FOREIGN KEY (`Organisasi_id`) REFERENCES `organisasi` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Organisasi_username_username1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kisahhidup`
--

LOCK TABLES `kisahhidup` WRITE;
/*!40000 ALTER TABLE `kisahhidup` DISABLE KEYS */;
/*!40000 ALTER TABLE `kisahhidup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `komen`
--

DROP TABLE IF EXISTS `komen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `komen` (
  `id` int(11) NOT NULL,
  `Komentar` text DEFAULT NULL,
  `tgl` datetime DEFAULT NULL,
  `username` varchar(40) NOT NULL,
  `Konten_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Komen_User1_idx` (`username`),
  KEY `fk_Komen_Konten1_idx` (`Konten_id`),
  CONSTRAINT `fk_Komen_Konten1` FOREIGN KEY (`Konten_id`) REFERENCES `konten` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Komen_User1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `komen`
--

LOCK TABLES `komen` WRITE;
/*!40000 ALTER TABLE `komen` DISABLE KEYS */;
/*!40000 ALTER TABLE `komen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `konten`
--

DROP TABLE IF EXISTS `konten`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `konten` (
  `id` int(11) NOT NULL,
  `caption` text DEFAULT NULL,
  `foto` varchar(45) DEFAULT NULL,
  `video` varchar(45) DEFAULT NULL,
  `tglUpload` datetime DEFAULT NULL,
  `username` varchar(40) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Konten_User1_idx` (`username`),
  CONSTRAINT `fk_Konten_User1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `konten`
--

LOCK TABLES `konten` WRITE;
/*!40000 ALTER TABLE `konten` DISABLE KEYS */;
/*!40000 ALTER TABLE `konten` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kota`
--

DROP TABLE IF EXISTS `kota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kota` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kota`
--

LOCK TABLES `kota` WRITE;
/*!40000 ALTER TABLE `kota` DISABLE KEYS */;
INSERT INTO `kota` VALUES (1,'Surabaya'),(2,'Jakarta'),(3,'Kalimantan');
/*!40000 ALTER TABLE `kota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `organisasi`
--

DROP TABLE IF EXISTS `organisasi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `organisasi` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `Kota_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Organisasi_Kota_idx` (`Kota_id`),
  CONSTRAINT `fk_Organisasi_Kota` FOREIGN KEY (`Kota_id`) REFERENCES `kota` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `organisasi`
--

LOCK TABLES `organisasi` WRITE;
/*!40000 ALTER TABLE `organisasi` DISABLE KEYS */;
/*!40000 ALTER TABLE `organisasi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tag`
--

DROP TABLE IF EXISTS `tag`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tag` (
  `Konten_id` int(11) NOT NULL,
  `username` varchar(40) NOT NULL,
  PRIMARY KEY (`Konten_id`,`username`),
  KEY `fk_Konten_User_User1_idx` (`username`),
  KEY `fk_Konten_User_Konten1_idx` (`Konten_id`),
  CONSTRAINT `fk_Konten_User_Konten1` FOREIGN KEY (`Konten_id`) REFERENCES `konten` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Konten_User_User1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tag`
--

LOCK TABLES `tag` WRITE;
/*!40000 ALTER TABLE `tag` DISABLE KEYS */;
/*!40000 ALTER TABLE `tag` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teman`
--

DROP TABLE IF EXISTS `teman`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `teman` (
  `username1` varchar(40) NOT NULL,
  `username2` varchar(40) NOT NULL,
  `tglBerteman` date DEFAULT NULL,
  PRIMARY KEY (`username1`,`username2`),
  KEY `fk_User_User_User2_idx` (`username2`),
  KEY `fk_User_User_User1_idx` (`username1`),
  CONSTRAINT `fk_User_User_User1` FOREIGN KEY (`username1`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_User_User_User2` FOREIGN KEY (`username2`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teman`
--

LOCK TABLES `teman` WRITE;
/*!40000 ALTER TABLE `teman` DISABLE KEYS */;
/*!40000 ALTER TABLE `teman` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `username` varchar(40) NOT NULL,
  `password` varchar(128) DEFAULT NULL,
  `tglLahir` date DEFAULT NULL,
  `noKTP` varchar(16) DEFAULT NULL,
  `foto` varchar(45) DEFAULT NULL,
  `Kota_id` int(11) NOT NULL,
  PRIMARY KEY (`username`),
  KEY `fk_User_Kota1_idx` (`Kota_id`),
  CONSTRAINT `fk_User_Kota1` FOREIGN KEY (`Kota_id`) REFERENCES `kota` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-24 22:56:48
