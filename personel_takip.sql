CREATE DATABASE  IF NOT EXISTS `personel_takip` /*!40100 DEFAULT CHARACTER SET ascii */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `personel_takip`;
-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: personel_takip
-- ------------------------------------------------------
-- Server version	8.0.33

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `izin_tablosu`
--

DROP TABLE IF EXISTS `izin_tablosu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `izin_tablosu` (
  `Personel ID` double NOT NULL,
  `İzin Türü` varchar(45) DEFAULT NULL,
  `Personel Adı` varchar(45) DEFAULT NULL,
  `İzin Başlangıç` date DEFAULT NULL,
  `İzin Bitiş` date DEFAULT NULL,
  `İşlem Tarihi` datetime DEFAULT NULL,
  `Açıklama` varchar(850) DEFAULT NULL,
  `durum` varchar(90) DEFAULT 'HAYIR',
  PRIMARY KEY (`Personel ID`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `izin_tablosu`
--

LOCK TABLES `izin_tablosu` WRITE;
/*!40000 ALTER TABLE `izin_tablosu` DISABLE KEYS */;
/*!40000 ALTER TABLE `izin_tablosu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kullanici`
--

DROP TABLE IF EXISTS `kullanici`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kullanici` (
  `id` double NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `surname` varchar(45) DEFAULT NULL,
  `hourly_pay` decimal(5,2) DEFAULT NULL,
  `hire_date` date DEFAULT NULL,
  `phone_number` double DEFAULT NULL,
  `gender` varchar(45) DEFAULT NULL,
  `user_type` varchar(45) DEFAULT NULL,
  `address` varchar(70) DEFAULT NULL,
  `mail` varchar(70) DEFAULT NULL,
  `parola` varchar(45) DEFAULT NULL,
  `yuzverisi` varbinary(1000) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kullanici`
--

LOCK TABLES `kullanici` WRITE;
/*!40000 ALTER TABLE `kullanici` DISABLE KEYS */;
INSERT INTO `kullanici` VALUES (12345678901,'Oguzhan','Eres',500.00,'2023-06-01',5537725056,'Erkek','calisan','Duzce',NULL,'12345',NULL),(12345678902,'Basak Su','Gedik',450.00,'2023-06-02',5555555555,'Kadin','calisan','Ankara','basak@gmail.com','12345',NULL),(12345678903,'Dilay Ece','Maral',600.00,'2023-06-03',5355555555,'Kadin','calisan','Izmir',NULL,'12345',NULL);
/*!40000 ALTER TABLE `kullanici` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `yonetici`
--

DROP TABLE IF EXISTS `yonetici`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `yonetici` (
  `idYonetici` double NOT NULL,
  `isim` varchar(90) DEFAULT NULL,
  `sifre` varchar(90) DEFAULT NULL,
  PRIMARY KEY (`idYonetici`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `yonetici`
--

LOCK TABLES `yonetici` WRITE;
/*!40000 ALTER TABLE `yonetici` DISABLE KEYS */;
INSERT INTO `yonetici` VALUES (12345678901,'Oguzhan','12345'),(12345678902,'Basak','12345');
/*!40000 ALTER TABLE `yonetici` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'personel_takip'
--

--
-- Dumping routines for database 'personel_takip'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-01 22:34:08
