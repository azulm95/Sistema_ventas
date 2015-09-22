CREATE DATABASE  IF NOT EXISTS `post` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `post`;
-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: localhost    Database: post
-- ------------------------------------------------------
-- Server version	5.6.25-log

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
-- Table structure for table `tbl_compras`
--

DROP TABLE IF EXISTS `tbl_compras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_compras` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_proveedor` varchar(50) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_producto` varchar(50) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `costo` decimal(10,5) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_proveedor1_idx` (`id_proveedor`),
  KEY `fk_usuario_idx` (`id_usuario`),
  KEY `fk_producto1_idx` (`id_producto`),
  CONSTRAINT `fk_producto1` FOREIGN KEY (`id_producto`) REFERENCES `tbl_producto` (`codigo`),
  CONSTRAINT `fk_proveedor1` FOREIGN KEY (`id_proveedor`) REFERENCES `tbl_proveedor` (`id_proveedor`),
  CONSTRAINT `fk_usuario1` FOREIGN KEY (`id_usuario`) REFERENCES `tbl_usuarios` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_compras`
--

LOCK TABLES `tbl_compras` WRITE;
/*!40000 ALTER TABLE `tbl_compras` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_compras` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-09-08  2:02:32
