CREATE DATABASE  IF NOT EXISTS `majime` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `majime`;
-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: majime
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
-- Table structure for table `acude`
--

DROP TABLE IF EXISTS `acude`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `acude` (
  `nombre_tipo_habitacion` varchar(128) COLLATE utf8_spanish_ci NOT NULL,
  `num_hab` int(11) NOT NULL,
  `momento_inicio_transporte` datetime NOT NULL,
  `momento_fin_transporte` datetime NOT NULL,
  `matricula_camioneta` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `num_periodo` int(11) NOT NULL,
  PRIMARY KEY (`nombre_tipo_habitacion`,`num_hab`,`momento_inicio_transporte`,`momento_fin_transporte`,`matricula_camioneta`),
  KEY `num_periodo_fk_acude_idx` (`num_periodo`),
  KEY `num_hab_fk_acude_idx` (`num_hab`),
  KEY `nombre_tipo_habitacion_fk_idx_2` (`nombre_tipo_habitacion`),
  KEY `matricula_camioneta_fk_idx_2` (`matricula_camioneta`),
  CONSTRAINT `matricula_camioneta_acude_fk` FOREIGN KEY (`matricula_camioneta`) REFERENCES `camioneta` (`matricula_camioneta`),
  CONSTRAINT `nombre_tipo_habitacion_acude_fk` FOREIGN KEY (`nombre_tipo_habitacion`) REFERENCES `tipohabitacion` (`nombre_tipo_habitacion`),
  CONSTRAINT `num_hab_fk_acude` FOREIGN KEY (`num_hab`) REFERENCES `habitacion` (`num_hab`),
  CONSTRAINT `num_periodo_fk_acude` FOREIGN KEY (`num_periodo`) REFERENCES `horariohotel` (`num_periodo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `camioneta`
--

DROP TABLE IF EXISTS `camioneta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `camioneta` (
  `matricula_camioneta` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `marca_camioneta` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `modelo_camioneta` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `capacidad_camioneta` int(10) unsigned NOT NULL,
  PRIMARY KEY (`matricula_camioneta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `ci_cliente` int(11) unsigned NOT NULL,
  `nombre_cliente` varchar(128) COLLATE utf8_spanish_ci NOT NULL,
  `telefono_cliente` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `celular_cliente` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `direccion_cliente` varchar(256) COLLATE utf8_spanish_ci NOT NULL,
  `email_cliente` varchar(128) COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`ci_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cobra`
--

DROP TABLE IF EXISTS `cobra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cobra` (
  `ci_cliente` int(10) unsigned NOT NULL,
  `ci_empleado` int(10) unsigned NOT NULL,
  PRIMARY KEY (`ci_cliente`,`ci_empleado`),
  KEY `ci_empleado_cobrafk_idx` (`ci_empleado`),
  CONSTRAINT `ci_cliente_cobrafk` FOREIGN KEY (`ci_cliente`) REFERENCES `cliente` (`ci_cliente`),
  CONSTRAINT `ci_empleado_cobrafk` FOREIGN KEY (`ci_empleado`) REFERENCES `empleado` (`ci_empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `confirmarecepcion`
--

DROP TABLE IF EXISTS `confirmarecepcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `confirmarecepcion` (
  `num_mascota` int(10) NOT NULL,
  `momento_creado_transporte` datetime NOT NULL,
  `num_periodo` int(10) NOT NULL,
  `ci_confirmador_recepcion` int(11) unsigned NOT NULL,
  `momento_recepcion_transporte` datetime NOT NULL,
  PRIMARY KEY (`num_mascota`,`momento_creado_transporte`),
  KEY `momento_creado_trans_fk_confrep_idx` (`momento_creado_transporte`),
  KEY `mom_creado_transp_confrec_idx` (`momento_recepcion_transporte`),
  KEY `num_periodo_fk_confrec_idx` (`num_periodo`),
  KEY `ci_confirmador_rec_fk_confrec_idx` (`ci_confirmador_recepcion`),
  CONSTRAINT `ci_confirmador_rec_fk_confrec` FOREIGN KEY (`ci_confirmador_recepcion`) REFERENCES `empleado` (`ci_empleado`),
  CONSTRAINT `mom_creado_transp_confrec` FOREIGN KEY (`momento_recepcion_transporte`) REFERENCES `transporta` (`momento_creado_transporte`),
  CONSTRAINT `num_mascota_fk_confrep` FOREIGN KEY (`num_mascota`) REFERENCES `mascota` (`num_mascota`),
  CONSTRAINT `num_periodo_fk_confrec` FOREIGN KEY (`num_periodo`) REFERENCES `horariohotel` (`num_periodo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `confirmasalida`
--

DROP TABLE IF EXISTS `confirmasalida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `confirmasalida` (
  `num_mascota` int(10) NOT NULL,
  `momento_creado_transporte` datetime NOT NULL,
  `num_periodo` int(10) NOT NULL,
  `ci_confirmador_salida` int(11) unsigned NOT NULL,
  `momento_salida_transporta` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`num_mascota`,`momento_creado_transporte`),
  KEY `mom_creado_transp_fk_confs_idx` (`momento_creado_transporte`),
  KEY `num_periodo_fk_confs_idx` (`num_periodo`),
  KEY `ci_confirmador_salida_idx` (`ci_confirmador_salida`),
  CONSTRAINT `ci_confirmador_salida` FOREIGN KEY (`ci_confirmador_salida`) REFERENCES `empleado` (`ci_empleado`),
  CONSTRAINT `mom_creado_transp_fk_confs` FOREIGN KEY (`momento_creado_transporte`) REFERENCES `transporta` (`momento_creado_transporte`),
  CONSTRAINT `num_mascota` FOREIGN KEY (`num_mascota`) REFERENCES `mascota` (`num_mascota`),
  CONSTRAINT `num_periodo_fk_confs` FOREIGN KEY (`num_periodo`) REFERENCES `horariohotel` (`num_periodo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `conpago`
--

DROP TABLE IF EXISTS `conpago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `conpago` (
  `num_reserva` int(10) NOT NULL,
  `nombre_tipo_habitacion` varchar(128) COLLATE utf8_spanish_ci NOT NULL,
  `num_hab` int(11) NOT NULL,
  `num_mascota` int(11) NOT NULL,
  `ci_empleado` int(10) unsigned NOT NULL,
  PRIMARY KEY (`num_reserva`,`nombre_tipo_habitacion`,`num_hab`,`num_mascota`),
  KEY `empleado_fk_conpago_idx` (`ci_empleado`),
  KEY `nombre_tipo_habitacion_idx` (`nombre_tipo_habitacion`),
  KEY `num_mascota_fk_conpago_idx` (`num_mascota`),
  KEY `num_hab_fk_conpago_idx` (`num_hab`),
  CONSTRAINT `empleado_fk_conpago` FOREIGN KEY (`ci_empleado`) REFERENCES `empleado` (`ci_empleado`),
  CONSTRAINT `nombre_tipo_habitacion_fk` FOREIGN KEY (`nombre_tipo_habitacion`) REFERENCES `tipohabitacion` (`nombre_tipo_habitacion`),
  CONSTRAINT `num_hab_fk_conpago` FOREIGN KEY (`num_hab`) REFERENCES `habitacion` (`num_hab`),
  CONSTRAINT `num_mascota_fk_conpago` FOREIGN KEY (`num_mascota`) REFERENCES `mascota` (`num_mascota`),
  CONSTRAINT `numn_reserva_fk_conpago` FOREIGN KEY (`num_reserva`) REFERENCES `hospeda` (`num_reserva`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `controla`
--

DROP TABLE IF EXISTS `controla`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `controla` (
  `num_periodo` int(10) NOT NULL,
  `momento_control` datetime NOT NULL,
  `ci_empleado` int(11) unsigned NOT NULL,
  PRIMARY KEY (`num_periodo`,`momento_control`),
  KEY `ci_empleado_fk_controla_idx` (`ci_empleado`),
  CONSTRAINT `ci_empleado_fk_controla` FOREIGN KEY (`ci_empleado`) REFERENCES `empleado` (`ci_empleado`),
  CONSTRAINT `num_periodo_fk_controla` FOREIGN KEY (`num_periodo`) REFERENCES `horariohotel` (`num_periodo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cuesta`
--

DROP TABLE IF EXISTS `cuesta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuesta` (
  `num_precio` int(11) NOT NULL,
  `nombre_tipo_habitacion` varchar(128) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`num_precio`,`nombre_tipo_habitacion`),
  KEY `nombre_tipo_habitacion_fk_idx` (`nombre_tipo_habitacion`),
  CONSTRAINT `nombre_tipo_habitacion_fk_2` FOREIGN KEY (`nombre_tipo_habitacion`) REFERENCES `tipohabitacion` (`nombre_tipo_habitacion`),
  CONSTRAINT `num_precio_cuesta_fk` FOREIGN KEY (`num_precio`) REFERENCES `precio` (`num_precio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `ci_empleado` int(11) unsigned NOT NULL,
  `nombre_empleado` varchar(128) COLLATE utf8_spanish_ci NOT NULL,
  `usuario_empleado` varchar(128) COLLATE utf8_spanish_ci NOT NULL,
  `password_empleado` varchar(128) COLLATE utf8_spanish_ci NOT NULL,
  `telefono_empleado` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `rango_empleado` varchar(128) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`ci_empleado`),
  UNIQUE KEY `usuario_UNIQUE` (`usuario_empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `foto`
--

DROP TABLE IF EXISTS `foto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `foto` (
  `num_foto` int(11) NOT NULL AUTO_INCREMENT,
  `archivo_foto` mediumblob NOT NULL,
  PRIMARY KEY (`num_foto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `habitacion`
--

DROP TABLE IF EXISTS `habitacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `habitacion` (
  `num_hab` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_tipo_habitacion` varchar(128) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`num_hab`,`nombre_tipo_habitacion`),
  KEY `nombre_tipo_habitacion_fk_hab` (`nombre_tipo_habitacion`),
  CONSTRAINT `nombre_tipo_habitacion_fk_hab` FOREIGN KEY (`nombre_tipo_habitacion`) REFERENCES `tipohabitacion` (`nombre_tipo_habitacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `horariohotel`
--

DROP TABLE IF EXISTS `horariohotel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `horariohotel` (
  `num_periodo` int(10) NOT NULL AUTO_INCREMENT,
  `horainicio` time NOT NULL,
  `horafin` time NOT NULL,
  PRIMARY KEY (`num_periodo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `hospeda`
--

DROP TABLE IF EXISTS `hospeda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hospeda` (
  `num_reserva` int(10) NOT NULL AUTO_INCREMENT,
  `nombre_tipo_habitacion` varchar(128) COLLATE utf8_spanish_ci NOT NULL,
  `num_hab` int(11) NOT NULL,
  `num_mascota` int(10) NOT NULL,
  `momento_partida_reserva` datetime NOT NULL,
  `momento_arribo_reserva` datetime NOT NULL,
  `ci_empleado` int(10) unsigned NOT NULL,
  `momento_realizada_reserva` datetime NOT NULL,
  `estado_reserva` varchar(128) COLLATE utf8_spanish_ci NOT NULL,
  `extras_reserva` varchar(128) COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`num_reserva`,`nombre_tipo_habitacion`,`num_hab`,`num_mascota`),
  KEY `ci_empleado_idx` (`ci_empleado`),
  KEY `nombre_tipo_habitacion_hospeda_fk` (`nombre_tipo_habitacion`),
  KEY `num_reserva_hospeda_idx` (`num_reserva`),
  KEY `num_hab_hopseda_fk_idx` (`num_hab`),
  KEY `num_mascota_hospeda_fk_idx` (`num_mascota`),
  CONSTRAINT `ci_empleado` FOREIGN KEY (`ci_empleado`) REFERENCES `empleado` (`ci_empleado`),
  CONSTRAINT `nombre_tipo_habitacion` FOREIGN KEY (`nombre_tipo_habitacion`) REFERENCES `tipohabitacion` (`nombre_tipo_habitacion`),
  CONSTRAINT `num_hab_hopseda_fk` FOREIGN KEY (`num_hab`) REFERENCES `habitacion` (`num_hab`),
  CONSTRAINT `num_mascota_hospeda_fk` FOREIGN KEY (`num_mascota`) REFERENCES `mascota` (`num_mascota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `mascota`
--

DROP TABLE IF EXISTS `mascota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mascota` (
  `num_mascota` int(10) NOT NULL AUTO_INCREMENT,
  `nombre_mascota` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `raza_mascota` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `sexo_mascota` char(1) COLLATE utf8_spanish_ci DEFAULT NULL,
  `peso_mascota` int(11) NOT NULL,
  `fecha_nac_mascota` date DEFAULT NULL,
  `vacunas_mascota` varchar(128) COLLATE utf8_spanish_ci DEFAULT NULL,
  `toma_medicacion_mascota` tinyint(1) NOT NULL,
  `medicacion_mascota` varchar(128) COLLATE utf8_spanish_ci DEFAULT NULL,
  `dosis_medicacion_mascota` varchar(128) COLLATE utf8_spanish_ci DEFAULT NULL,
  `horario_medicacion_mascota` varchar(128) COLLATE utf8_spanish_ci DEFAULT NULL,
  `complementos_mascota` varchar(128) COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`num_mascota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `pertenece`
--

DROP TABLE IF EXISTS `pertenece`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pertenece` (
  `num_mascota` int(10) NOT NULL,
  `ci_cliente` int(10) unsigned NOT NULL,
  PRIMARY KEY (`num_mascota`,`ci_cliente`),
  KEY `ci_cliente_fk_pertenece_idx` (`ci_cliente`),
  KEY `num_mascota_fk_idx` (`num_mascota`),
  CONSTRAINT `ci_cliente_fk_pertenece` FOREIGN KEY (`ci_cliente`) REFERENCES `cliente` (`ci_cliente`),
  CONSTRAINT `num_mascota_fk` FOREIGN KEY (`num_mascota`) REFERENCES `mascota` (`num_mascota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `posee`
--

DROP TABLE IF EXISTS `posee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `posee` (
  `num_foto` int(11) NOT NULL,
  `nombre_tipo_habitacion` varchar(128) COLLATE utf8_spanish_ci NOT NULL,
  `num_hab` int(11) NOT NULL,
  PRIMARY KEY (`num_foto`),
  KEY `nombre_tipo_habitacion_fk_idx` (`num_hab`),
  KEY `nombre_tipo_habitacion_fkw` (`nombre_tipo_habitacion`),
  CONSTRAINT `nombre_tipo_habitacion_fkw` FOREIGN KEY (`nombre_tipo_habitacion`) REFERENCES `tipohabitacion` (`nombre_tipo_habitacion`),
  CONSTRAINT `num_hab` FOREIGN KEY (`num_hab`) REFERENCES `habitacion` (`num_hab`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `precio`
--

DROP TABLE IF EXISTS `precio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `precio` (
  `num_precio` int(11) NOT NULL AUTO_INCREMENT,
  `precio_1_mascota` decimal(10,2) NOT NULL,
  `precio_2_mascota` decimal(10,2) NOT NULL,
  `precio_3_mascota` decimal(10,2) NOT NULL,
  PRIMARY KEY (`num_precio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `recibe`
--

DROP TABLE IF EXISTS `recibe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `recibe` (
  `num_mascota` int(10) NOT NULL,
  `momento_checkin` datetime NOT NULL,
  `ci_empleado` int(10) unsigned NOT NULL,
  PRIMARY KEY (`num_mascota`,`momento_checkin`),
  KEY `ci_empleado_fk_recibe_idx` (`ci_empleado`),
  CONSTRAINT `ci_empleado_fk_recibe` FOREIGN KEY (`ci_empleado`) REFERENCES `empleado` (`ci_empleado`),
  CONSTRAINT `num_mascota_fk_recibe` FOREIGN KEY (`num_mascota`) REFERENCES `mascota` (`num_mascota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `regula`
--

DROP TABLE IF EXISTS `regula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `regula` (
  `num_precio` int(11) unsigned NOT NULL,
  `momento_regulacion` datetime NOT NULL,
  `ci_empleado` int(11) unsigned NOT NULL,
  PRIMARY KEY (`num_precio`,`momento_regulacion`),
  KEY `presioindex` (`num_precio`),
  KEY `ci_empleado_fk_regula_idx` (`ci_empleado`),
  CONSTRAINT `ci_empleado_fk_regula` FOREIGN KEY (`ci_empleado`) REFERENCES `empleado` (`ci_empleado`),
  CONSTRAINT `num_precio_fk_regula` FOREIGN KEY (`num_precio`) REFERENCES `regula` (`num_precio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tipohabitacion`
--

DROP TABLE IF EXISTS `tipohabitacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipohabitacion` (
  `nombre_tipo_habitacion` varchar(128) COLLATE utf8_spanish_ci NOT NULL,
  `cant_tip_hab` int(10) unsigned NOT NULL,
  `metraje_interior_tipo_hab` int(10) unsigned DEFAULT NULL,
  `metraje_exterior_tipo_hab` int(10) unsigned DEFAULT NULL,
  `calefaccion_habitacion` tinyint(1) DEFAULT NULL,
  `sonda_tipo_hab` tinyint(1) DEFAULT NULL,
  `ac_tipo_hab` tinyint(1) DEFAULT NULL,
  `musica_tipo_hab` tinyint(1) DEFAULT NULL,
  `webcam_tipo_hab` tinyint(1) DEFAULT NULL,
  `dogtv_tipo_hab` tinyint(1) DEFAULT NULL,
  `zonacomun_tipo_hab` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`nombre_tipo_habitacion`),
  KEY `index_tipo_hab` (`nombre_tipo_habitacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `transporta`
--

DROP TABLE IF EXISTS `transporta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transporta` (
  `matricula_camioneta` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `num_mascota` int(10) NOT NULL,
  `momento_creado_transporte` datetime NOT NULL,
  PRIMARY KEY (`matricula_camioneta`,`num_mascota`,`momento_creado_transporte`),
  KEY `matricula_camioneta_idx` (`matricula_camioneta`),
  KEY `num_mascota_fk_transporta_idx` (`num_mascota`),
  KEY `transportatime` (`momento_creado_transporte`),
  CONSTRAINT `matricula_camioneta` FOREIGN KEY (`matricula_camioneta`) REFERENCES `camioneta` (`matricula_camioneta`),
  CONSTRAINT `num_mascota_fk_transporta` FOREIGN KEY (`num_mascota`) REFERENCES `mascota` (`num_mascota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-09-07 23:09:41
