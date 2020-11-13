CREATE DATABASE  IF NOT EXISTS `mkarszensztejn` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mkarszensztejn`;
-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mkarszensztejn
-- ------------------------------------------------------
-- Server version	8.0.17

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
-- Table structure for table `confirma e-s`
--

DROP TABLE IF EXISTS `confirma e-s`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `confirma e-s` (
  `num_mascota` int(11) NOT NULL,
  `momento_creado_transporte` datetime NOT NULL,
  `matricula_camioneta` varchar(20) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `tipo_movimiento_e-s` enum('Entrada','Salida') CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `num_periodo` int(11) NOT NULL,
  `ci_recepcionista` int(11) DEFAULT NULL,
  `momento_e-s` datetime NOT NULL,
  `ci_gerente` int(11) DEFAULT NULL,
  PRIMARY KEY (`num_mascota`,`momento_creado_transporte`,`matricula_camioneta`,`tipo_movimiento_e-s`),
  KEY `momento_creado_transporte_idx` (`momento_creado_transporte`),
  KEY `numero_periodo_fk_e-s_idx` (`num_periodo`),
  KEY `ci_recepcionista_fk_e-s_idx` (`ci_recepcionista`),
  KEY `momento_creado_transporte_idxx` (`momento_creado_transporte`),
  KEY `numero_periodo_fk_e-s_idxx` (`num_periodo`),
  KEY `ci_recepcionista_fk_e-s_idxx` (`ci_recepcionista`),
  KEY `matricula_camioneta_fk_es` (`matricula_camioneta`),
  KEY `ci_gerente_confirmaes_idx` (`ci_gerente`),
  CONSTRAINT `ci_gerente_confirmaes` FOREIGN KEY (`ci_gerente`) REFERENCES `gerente` (`ci_gerente`),
  CONSTRAINT `cii_recepcionista_fk_e-s` FOREIGN KEY (`ci_recepcionista`) REFERENCES `rec_garaje` (`ci_rec_garaje`),
  CONSTRAINT `matricula_camioneta_fk_es` FOREIGN KEY (`matricula_camioneta`) REFERENCES `camioneta` (`matricula_camioneta`),
  CONSTRAINT `momentoo_creado_transporte` FOREIGN KEY (`momento_creado_transporte`) REFERENCES `transporta` (`momento_creado_transporte`),
  CONSTRAINT `num_mascota_fkk_e-s` FOREIGN KEY (`num_mascota`) REFERENCES `mascota` (`num_mascota`),
  CONSTRAINT `numeroo_periodo_fk_e-s` FOREIGN KEY (`num_periodo`) REFERENCES `horario_hotel` (`num_periodo`),
  CONSTRAINT `checkConfirmador` CHECK (((`ci_recepcionista` <> NULL) or (`ci_gerente` <> NULL))),
  CONSTRAINT `checkConfirmadorEmp` CHECK (((`ci_recepcionista` is not null) or (`ci_gerente` is not null)))
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `confirma e-s`
--

LOCK TABLES `confirma e-s` WRITE;
/*!40000 ALTER TABLE `confirma e-s` DISABLE KEYS */;
INSERT INTO `confirma e-s` VALUES (2,'2020-11-11 12:13:00','sbc 1445','Entrada',1,53331112,'2020-11-12 11:13:00',NULL),(2,'2020-11-11 12:13:00','sbc 1445','Salida',1,NULL,'2020-11-12 11:59:00',44444441),(3,'2020-11-11 12:00:00','saa 1244','Salida',1,53331112,'2020-11-12 11:16:00',NULL),(4,'2020-11-11 04:56:00','scc 6780','Entrada',1,53331112,'2020-12-22 11:19:00',NULL);
/*!40000 ALTER TABLE `confirma e-s` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-11-12 22:15:35
