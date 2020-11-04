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
-- Table structure for table `camioneta`
--

DROP TABLE IF EXISTS `camioneta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `camioneta` (
  `matricula_camioneta` varchar(20) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `marca_camioneta` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `modelo_camioneta` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `capacidad_camioneta` int(11) NOT NULL,
  PRIMARY KEY (`matricula_camioneta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `camioneta`
--

LOCK TABLES `camioneta` WRITE;
/*!40000 ALTER TABLE `camioneta` DISABLE KEYS */;
INSERT INTO `camioneta` VALUES ('saa 1244','honda','civic',4),('sbc 1445','chevrolet','celta',3),('sbh 9984','toyota','corolla',2),('scb 4455','chevrolet','corsa',2),('scc 6780','mercedes benz','sprinter',4);
/*!40000 ALTER TABLE `camioneta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `ci_cliente` int(11) NOT NULL,
  `nombre_cliente` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `telefono_cliente` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `celular_cliente` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `direccion_cliente` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `email_cliente` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`ci_cliente`),
  UNIQUE KEY `email_cliente_UNIQUE` (`email_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (13334567,'federico curbelo','45678763','094055666','avenida brasil 5990','curbelolaser@yahoo.com'),(14447776,'julian duarte','22054477','094112254','constituyente 6633','juliand@live.es'),(27689990,'emilia andre','22075566','091556173','jose enrique rodo 5990','emiliaandre@hotmail.com'),(41112223,'pedro llama','22065555','099222333','ejido 1222','pedrin@gmail.com'),(54442272,'manuela pollera','27653388','091099094','21 de setiembre 5578','manup@yahoo.com');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

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
  `num_periodo` int(11) NOT NULL,
  `ci_recepcionista` int(11) NOT NULL,
  `momento_e-s` datetime NOT NULL,
  `tipo_movimiento_e-s` enum('Entrada','Salida') CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`num_mascota`,`momento_creado_transporte`,`matricula_camioneta`),
  KEY `momento_creado_transporte_idx` (`momento_creado_transporte`),
  KEY `numero_periodo_fk_e-s_idx` (`num_periodo`),
  KEY `ci_recepcionista_fk_e-s_idx` (`ci_recepcionista`),
  KEY `momento_creado_transporte_idxx` (`momento_creado_transporte`),
  KEY `numero_periodo_fk_e-s_idxx` (`num_periodo`),
  KEY `ci_recepcionista_fk_e-s_idxx` (`ci_recepcionista`),
  KEY `matricula_camioneta_fk_es` (`matricula_camioneta`),
  CONSTRAINT `cii_recepcionista_fk_e-s` FOREIGN KEY (`ci_recepcionista`) REFERENCES `rec_garaje` (`ci_rec_garaje`),
  CONSTRAINT `matricula_camioneta_fk_es` FOREIGN KEY (`matricula_camioneta`) REFERENCES `camioneta` (`matricula_camioneta`),
  CONSTRAINT `momentoo_creado_transporte` FOREIGN KEY (`momento_creado_transporte`) REFERENCES `transporta` (`momento_creado_transporte`),
  CONSTRAINT `num_mascota_fkk_e-s` FOREIGN KEY (`num_mascota`) REFERENCES `mascota` (`num_mascota`),
  CONSTRAINT `numeroo_periodo_fk_e-s` FOREIGN KEY (`num_periodo`) REFERENCES `horario_hotel` (`num_periodo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `confirma e-s`
--

LOCK TABLES `confirma e-s` WRITE;
/*!40000 ALTER TABLE `confirma e-s` DISABLE KEYS */;
INSERT INTO `confirma e-s` VALUES (4,'2020-10-17 15:15:00','scb 4455',1,53331112,'2020-10-25 12:03:00','Entrada'),(4,'2020-10-17 15:15:00','scc 6780',1,53331112,'2020-10-20 11:49:00','Entrada');
/*!40000 ALTER TABLE `confirma e-s` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consume`
--

DROP TABLE IF EXISTS `consume`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `consume` (
  `num_medicacion` int(11) NOT NULL,
  `num_mascota` int(11) NOT NULL,
  PRIMARY KEY (`num_medicacion`,`num_mascota`),
  KEY `num_mascota_fk_cons_idx` (`num_mascota`),
  CONSTRAINT `num_mascota_fk_cons` FOREIGN KEY (`num_mascota`) REFERENCES `mascota` (`num_mascota`),
  CONSTRAINT `num_medicacion_fk_cons` FOREIGN KEY (`num_medicacion`) REFERENCES `medicacion` (`num_medicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consume`
--

LOCK TABLES `consume` WRITE;
/*!40000 ALTER TABLE `consume` DISABLE KEYS */;
INSERT INTO `consume` VALUES (1,3),(2,3),(3,6);
/*!40000 ALTER TABLE `consume` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `controla`
--

DROP TABLE IF EXISTS `controla`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `controla` (
  `num_periodo` int(11) NOT NULL,
  `momento_control` datetime NOT NULL,
  `ci_gerente` int(11) NOT NULL,
  PRIMARY KEY (`num_periodo`,`momento_control`),
  KEY `ci_gerente_fk_control_idx` (`ci_gerente`),
  CONSTRAINT `ci_gerente_fk_control` FOREIGN KEY (`ci_gerente`) REFERENCES `gerente` (`ci_gerente`),
  CONSTRAINT `num_periodo_fk` FOREIGN KEY (`num_periodo`) REFERENCES `horario_hotel` (`num_periodo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controla`
--

LOCK TABLES `controla` WRITE;
/*!40000 ALTER TABLE `controla` DISABLE KEYS */;
INSERT INTO `controla` VALUES (2,'2020-10-07 15:00:00',44444441);
/*!40000 ALTER TABLE `controla` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuesta`
--

DROP TABLE IF EXISTS `cuesta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuesta` (
  `num_precio` int(11) NOT NULL,
  `nombre_tipo_habitacion` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`num_precio`,`nombre_tipo_habitacion`),
  KEY `nombre_habitacion_de_tipo_fk` (`nombre_tipo_habitacion`),
  CONSTRAINT `nombre_habitacion_de_tipo_fk` FOREIGN KEY (`nombre_tipo_habitacion`) REFERENCES `tipo_habitacion` (`nombre_tipo_habitacion`),
  CONSTRAINT `num_precio_fk` FOREIGN KEY (`num_precio`) REFERENCES `precio` (`num_precio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuesta`
--

LOCK TABLES `cuesta` WRITE;
/*!40000 ALTER TABLE `cuesta` DISABLE KEYS */;
INSERT INTO `cuesta` VALUES (5,'Estandar'),(3,'Junior Suite'),(4,'Mini Suite'),(2,'Suite');
/*!40000 ALTER TABLE `cuesta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `foto`
--

DROP TABLE IF EXISTS `foto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `foto` (
  `num_foto` int(11) NOT NULL AUTO_INCREMENT,
  `foto` mediumblob NOT NULL,
  PRIMARY KEY (`num_foto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `foto`
--

LOCK TABLES `foto` WRITE;
/*!40000 ALTER TABLE `foto` DISABLE KEYS */;
/*!40000 ALTER TABLE `foto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gerente`
--

DROP TABLE IF EXISTS `gerente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gerente` (
  `ci_gerente` int(11) NOT NULL,
  `contrasena_gerente` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `nombre_gerente` varchar(128) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `telefono_gerente` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `direccion_gerente` varchar(128) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`ci_gerente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gerente`
--

LOCK TABLES `gerente` WRITE;
/*!40000 ALTER TABLE `gerente` DISABLE KEYS */;
INSERT INTO `gerente` VALUES (33333333,'password','martina estrella','099555444','21 de Setiembre 1221'),(44444441,'pedrito','pedro cuevas','22085555','Ejido 1411');
/*!40000 ALTER TABLE `gerente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `habitacion`
--

DROP TABLE IF EXISTS `habitacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `habitacion` (
  `nombre_tipo_habitacion` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `num_hab` int(11) NOT NULL,
  PRIMARY KEY (`nombre_tipo_habitacion`,`num_hab`),
  KEY `indice` (`num_hab`),
  CONSTRAINT `nom_tipo_hab` FOREIGN KEY (`nombre_tipo_habitacion`) REFERENCES `tipo_habitacion` (`nombre_tipo_habitacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `habitacion`
--

LOCK TABLES `habitacion` WRITE;
/*!40000 ALTER TABLE `habitacion` DISABLE KEYS */;
INSERT INTO `habitacion` VALUES ('Estandar',1),('Junior Suite',1),('Mini Suite',1),('Suite',1),('Estandar',2),('Junior Suite',2),('Mini Suite',2),('Suite',2),('Estandar',3),('Junior Suite',3),('Mini Suite',3),('Suite',3),('Estandar',4),('Junior Suite',4),('Mini Suite',4),('Suite',4),('Estandar',5),('Junior Suite',5),('Mini Suite',5),('Suite',5),('Estandar',6),('Junior Suite',6),('Mini Suite',6),('Suite',6),('Estandar',7),('Junior Suite',7),('Mini Suite',7),('Suite',7),('Estandar',8),('Junior Suite',8),('Mini Suite',8),('Suite',8),('Estandar',9),('Junior Suite',9),('Mini Suite',9),('Suite',9),('Estandar',10),('Junior Suite',10),('Mini Suite',10),('Suite',10),('Estandar',11),('Junior Suite',11),('Mini Suite',11),('Suite',11),('Estandar',12),('Junior Suite',12),('Mini Suite',12),('Suite',12),('Estandar',13),('Junior Suite',13),('Mini Suite',13),('Suite',13),('Estandar',14),('Junior Suite',14),('Mini Suite',14),('Suite',14),('Estandar',15),('Junior Suite',15),('Mini Suite',15),('Suite',15),('Estandar',16),('Junior Suite',16),('Mini Suite',16),('Suite',16),('Estandar',17),('Junior Suite',17),('Mini Suite',17),('Suite',17),('Estandar',18),('Junior Suite',18),('Mini Suite',18),('Suite',18),('Estandar',19),('Mini Suite',19),('Estandar',20),('Mini Suite',20),('Estandar',21),('Mini Suite',21),('Estandar',22),('Mini Suite',22),('Estandar',23),('Mini Suite',23),('Estandar',24),('Mini Suite',24);
/*!40000 ALTER TABLE `habitacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horario_hotel`
--

DROP TABLE IF EXISTS `horario_hotel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `horario_hotel` (
  `num_periodo` int(11) NOT NULL AUTO_INCREMENT,
  `hora_inicio_horario` time NOT NULL,
  `hora_fin_horario` time NOT NULL,
  PRIMARY KEY (`num_periodo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horario_hotel`
--

LOCK TABLES `horario_hotel` WRITE;
/*!40000 ALTER TABLE `horario_hotel` DISABLE KEYS */;
INSERT INTO `horario_hotel` VALUES (1,'11:00:00','13:00:00'),(2,'14:00:00','16:30:00'),(3,'17:00:00','19:00:00');
/*!40000 ALTER TABLE `horario_hotel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hospeda`
--

DROP TABLE IF EXISTS `hospeda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hospeda` (
  `nombre_tipo_habitacion` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `num_hab` int(11) NOT NULL,
  `num_mascota` int(11) NOT NULL,
  `momento_partida_reserva` datetime NOT NULL,
  `num_reserva` int(11) NOT NULL,
  `momento_arribo_reserva` datetime NOT NULL,
  `ci_oficinista` int(11) NOT NULL,
  `momento_reserva` datetime NOT NULL,
  `estado_reserva` enum('En Pie','Paga','Vencida','Cancelada','Finalizada') CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `extras_reserva` int(2) DEFAULT NULL,
  `modalidad_pago_reserva` tinyint(1) DEFAULT NULL,
  `precio_reserva` int(11) NOT NULL,
  PRIMARY KEY (`nombre_tipo_habitacion`,`num_hab`,`num_mascota`),
  UNIQUE KEY `num_reserva_UNIQUE` (`num_reserva`),
  KEY `num_habitacion_idx` (`num_hab`),
  KEY `num_mascotta_idx` (`num_mascota`),
  KEY `ci_oficinista_idx` (`ci_oficinista`),
  KEY `nombre_tipo_habitacionidx` (`nombre_tipo_habitacion`),
  CONSTRAINT `ci_oficinista` FOREIGN KEY (`ci_oficinista`) REFERENCES `oficinista` (`ci_oficinista`),
  CONSTRAINT `nombre_tipo_habitacionfk` FOREIGN KEY (`nombre_tipo_habitacion`) REFERENCES `tipo_habitacion` (`nombre_tipo_habitacion`),
  CONSTRAINT `num_habitacion` FOREIGN KEY (`num_hab`) REFERENCES `habitacion` (`num_hab`),
  CONSTRAINT `num_mascotta` FOREIGN KEY (`num_mascota`) REFERENCES `mascota` (`num_mascota`),
  CONSTRAINT `wwww` CHECK ((`extras_reserva` < 4))
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hospeda`
--

LOCK TABLES `hospeda` WRITE;
/*!40000 ALTER TABLE `hospeda` DISABLE KEYS */;
INSERT INTO `hospeda` VALUES ('Estandar',18,4,'2020-10-25 12:00:00',4,'2020-10-20 12:00:00',11111112,'2020-10-17 15:15:00','Finalizada',0,1,140),('Estandar',18,6,'2020-11-30 14:00:00',2,'2020-11-25 14:00:00',11111111,'2020-11-03 12:00:00','En Pie',0,0,140),('Suite',2,2,'2020-12-15 13:00:00',3,'2020-12-05 14:00:00',11111111,'2020-11-03 12:05:00','En Pie',0,1,340),('Suite',4,5,'2020-12-01 13:00:00',1,'2020-11-20 12:00:00',11111111,'2020-11-02 22:10:00','En Pie',3,0,440);
/*!40000 ALTER TABLE `hospeda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mascota`
--

DROP TABLE IF EXISTS `mascota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mascota` (
  `num_mascota` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_mascota` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `raza_mascota` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `sexo_mascota` enum('F','M') CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `peso_mascota` int(11) NOT NULL,
  `fnac_mascota` date DEFAULT NULL,
  `vacunas_mascota` varchar(128) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `complementos_mascota` varchar(128) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`num_mascota`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mascota`
--

LOCK TABLES `mascota` WRITE;
/*!40000 ALTER TABLE `mascota` DISABLE KEYS */;
INSERT INTO `mascota` VALUES (2,'popi','pekines','M',5,'2009-10-10','Todas','No'),(3,'loli','dalmata','F',14,'2015-12-12','Todas','No'),(4,'rex','pastor belga','M',30,'2019-01-14','Falta Rabia','Pedigree'),(5,'luna','yorkshire','F',6,'2016-04-05','Todas','No'),(6,'rulo','cruza','M',14,'2012-06-08','Ninguna','Asado de tira');
/*!40000 ALTER TABLE `mascota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicacion`
--

DROP TABLE IF EXISTS `medicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medicacion` (
  `num_medicacion` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_medicacion` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `dosis_medicacion` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `horario_medicacion` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`num_medicacion`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicacion`
--

LOCK TABLES `medicacion` WRITE;
/*!40000 ALTER TABLE `medicacion` DISABLE KEYS */;
INSERT INTO `medicacion` VALUES (1,'Paracetamol','500mg','Cada 8 horas'),(2,'Ibuprofeno','400mg','Cada 12 horas'),(3,'Paracetamol','150mg','Cada 16 horas');
/*!40000 ALTER TABLE `medicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `oficinista`
--

DROP TABLE IF EXISTS `oficinista`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `oficinista` (
  `ci_oficinista` int(11) NOT NULL,
  `contrasena_oficinista` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `nombre_oficinista` varchar(128) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `telefono_oficinista` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `direccion_oficinista` varchar(128) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`ci_oficinista`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `oficinista`
--

LOCK TABLES `oficinista` WRITE;
/*!40000 ALTER TABLE `oficinista` DISABLE KEYS */;
INSERT INTO `oficinista` VALUES (11111111,'pepepepe','Juan Carlos Grillo','22096666','Yi 1221'),(11111112,'password','emilia perez','22093333','San José 3333'),(11441111,'papopopa','Jose Carlos Gomez','44096666','Ejido 1221');
/*!40000 ALTER TABLE `oficinista` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pertenece`
--

DROP TABLE IF EXISTS `pertenece`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pertenece` (
  `num_mascota` int(11) NOT NULL,
  `ci_cliente` int(11) NOT NULL,
  PRIMARY KEY (`num_mascota`),
  KEY `ced_clientefk_idx` (`ci_cliente`),
  CONSTRAINT `ced_clientefk` FOREIGN KEY (`ci_cliente`) REFERENCES `cliente` (`ci_cliente`),
  CONSTRAINT `numero_mascotafk` FOREIGN KEY (`num_mascota`) REFERENCES `mascota` (`num_mascota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pertenece`
--

LOCK TABLES `pertenece` WRITE;
/*!40000 ALTER TABLE `pertenece` DISABLE KEYS */;
INSERT INTO `pertenece` VALUES (3,13334567),(2,14447776),(5,27689990),(6,41112223),(4,54442272);
/*!40000 ALTER TABLE `pertenece` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `posee`
--

DROP TABLE IF EXISTS `posee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `posee` (
  `num_foto` int(11) NOT NULL,
  `nombre_tipo_habitacion` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`num_foto`),
  KEY `nombre_habitacion_tipo_fk` (`nombre_tipo_habitacion`),
  CONSTRAINT `nombre_habitacion_tipo_fk` FOREIGN KEY (`nombre_tipo_habitacion`) REFERENCES `tipo_habitacion` (`nombre_tipo_habitacion`),
  CONSTRAINT `num_foto_fk` FOREIGN KEY (`num_foto`) REFERENCES `foto` (`num_foto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posee`
--

LOCK TABLES `posee` WRITE;
/*!40000 ALTER TABLE `posee` DISABLE KEYS */;
/*!40000 ALTER TABLE `posee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `precio`
--

DROP TABLE IF EXISTS `precio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `precio` (
  `num_precio` int(11) NOT NULL AUTO_INCREMENT,
  `precio_1m` decimal(6,2) NOT NULL,
  `precio_2m` decimal(6,2) DEFAULT NULL,
  `precio_3m` decimal(6,2) DEFAULT NULL,
  PRIMARY KEY (`num_precio`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `precio`
--

LOCK TABLES `precio` WRITE;
/*!40000 ALTER TABLE `precio` DISABLE KEYS */;
INSERT INTO `precio` VALUES (2,32.00,51.00,68.00),(3,31.00,46.50,62.00),(4,31.00,46.50,62.00),(5,28.00,40.00,56.00);
/*!40000 ALTER TABLE `precio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rec_garaje`
--

DROP TABLE IF EXISTS `rec_garaje`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rec_garaje` (
  `ci_rec_garaje` int(11) NOT NULL,
  `contrasena_rec_garaje` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `nombre_rec_garaje` varchar(128) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `telefono_rec_garaje` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `direccion_rec_garaje` varchar(128) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`ci_rec_garaje`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rec_garaje`
--

LOCK TABLES `rec_garaje` WRITE;
/*!40000 ALTER TABLE `rec_garaje` DISABLE KEYS */;
INSERT INTO `rec_garaje` VALUES (27788996,'qwertyuiop','jose pedro varela','27045533','obligado 2389'),(34466556,'p4ssw0rd','julio arevalo rios','29075555','bulevar españa 4354'),(53331112,'contrapassword','jessica holmes','098555321','jose belloni 7821');
/*!40000 ALTER TABLE `rec_garaje` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recibe`
--

DROP TABLE IF EXISTS `recibe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `recibe` (
  `num_mascota` int(11) NOT NULL,
  `momento_checkin` datetime NOT NULL,
  `ci_oficinista` int(11) NOT NULL,
  PRIMARY KEY (`num_mascota`,`momento_checkin`,`ci_oficinista`),
  KEY `ci_ofi_fk_idx` (`ci_oficinista`),
  CONSTRAINT `ci_ofi_fk` FOREIGN KEY (`ci_oficinista`) REFERENCES `oficinista` (`ci_oficinista`),
  CONSTRAINT `num_mascota_fkk` FOREIGN KEY (`num_mascota`) REFERENCES `mascota` (`num_mascota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recibe`
--

LOCK TABLES `recibe` WRITE;
/*!40000 ALTER TABLE `recibe` DISABLE KEYS */;
/*!40000 ALTER TABLE `recibe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `regula`
--

DROP TABLE IF EXISTS `regula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `regula` (
  `num_precio` int(11) NOT NULL,
  `momento_regulado` datetime NOT NULL,
  `ci_gerente` int(11) NOT NULL,
  PRIMARY KEY (`num_precio`,`momento_regulado`),
  KEY `ci_gerente_fk_reg_idx` (`ci_gerente`),
  CONSTRAINT `ci_gerente_fk_reg` FOREIGN KEY (`ci_gerente`) REFERENCES `gerente` (`ci_gerente`),
  CONSTRAINT `num_precio_fk_reg` FOREIGN KEY (`num_precio`) REFERENCES `precio` (`num_precio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `regula`
--

LOCK TABLES `regula` WRITE;
/*!40000 ALTER TABLE `regula` DISABLE KEYS */;
INSERT INTO `regula` VALUES (4,'2020-09-25 16:30:00',44444441),(4,'2020-11-01 14:25:00',44444441);
/*!40000 ALTER TABLE `regula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_habitacion`
--

DROP TABLE IF EXISTS `tipo_habitacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_habitacion` (
  `nombre_tipo_habitacion` varchar(64) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `cant_habitacion` int(11) NOT NULL,
  `metraje_ext_habitacion` int(11) DEFAULT NULL,
  `metraje_int_habitacion` int(11) DEFAULT NULL,
  `calefaccion_hab` tinyint(1) DEFAULT NULL,
  `sonda_hab` tinyint(1) DEFAULT NULL,
  `ac_hab` tinyint(1) DEFAULT NULL,
  `musica_hab` tinyint(1) DEFAULT NULL,
  `webcam_hab` tinyint(1) DEFAULT NULL,
  `dogtv_hab` tinyint(1) DEFAULT NULL,
  `zonacomun_hab` tinyint(1) DEFAULT NULL,
  `limite_peso_hab` int(11) DEFAULT NULL,
  PRIMARY KEY (`nombre_tipo_habitacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_habitacion`
--

LOCK TABLES `tipo_habitacion` WRITE;
/*!40000 ALTER TABLE `tipo_habitacion` DISABLE KEYS */;
INSERT INTO `tipo_habitacion` VALUES ('Estandar',24,10,8,1,1,1,0,0,0,1,NULL),('Junior Suite',18,15,8,1,1,1,1,0,0,1,NULL),('Mini Suite',24,10,6,1,1,1,1,0,0,1,12),('Suite',18,20,10,1,1,1,1,1,1,1,NULL);
/*!40000 ALTER TABLE `tipo_habitacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transporta`
--

DROP TABLE IF EXISTS `transporta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transporta` (
  `num_mascota` int(11) NOT NULL,
  `momento_creado_transporte` datetime NOT NULL,
  `matricula_camioneta` varchar(20) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`num_mascota`,`momento_creado_transporte`,`matricula_camioneta`),
  KEY `matricula_cam_fk` (`matricula_camioneta`),
  KEY `momento_indice` (`momento_creado_transporte`),
  CONSTRAINT `matricula_cam_fk` FOREIGN KEY (`matricula_camioneta`) REFERENCES `camioneta` (`matricula_camioneta`),
  CONSTRAINT `nume_mascotafk` FOREIGN KEY (`num_mascota`) REFERENCES `mascota` (`num_mascota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transporta`
--

LOCK TABLES `transporta` WRITE;
/*!40000 ALTER TABLE `transporta` DISABLE KEYS */;
INSERT INTO `transporta` VALUES (4,'2020-10-17 15:15:00','scb 4455'),(4,'2020-10-17 15:15:00','scc 6780'),(2,'2020-11-02 12:00:00','scb 4455'),(5,'2020-11-02 12:05:00','scb 4455'),(6,'2020-11-02 12:10:00','scc 6780');
/*!40000 ALTER TABLE `transporta` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-11-03  0:24:54
