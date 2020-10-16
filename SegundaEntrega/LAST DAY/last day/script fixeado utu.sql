CREATE DATABASE  IF NOT EXISTS `mkarszensztejn` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `mkarszensztejn`;
-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: 10.0.29.9    Database: mkarszensztejn
-- ------------------------------------------------------
-- Server version	5.5.65-MariaDB

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
-- Dumping data for table `acude`
--

LOCK TABLES `acude` WRITE;
/*!40000 ALTER TABLE `acude` DISABLE KEYS */;
/*!40000 ALTER TABLE `acude` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `camioneta`
--

LOCK TABLES `camioneta` WRITE;
/*!40000 ALTER TABLE `camioneta` DISABLE KEYS */;
/*!40000 ALTER TABLE `camioneta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `cobra`
--

LOCK TABLES `cobra` WRITE;
/*!40000 ALTER TABLE `cobra` DISABLE KEYS */;
/*!40000 ALTER TABLE `cobra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `confirmarecepcion`
--

LOCK TABLES `confirmarecepcion` WRITE;
/*!40000 ALTER TABLE `confirmarecepcion` DISABLE KEYS */;
/*!40000 ALTER TABLE `confirmarecepcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `confirmasalida`
--

LOCK TABLES `confirmasalida` WRITE;
/*!40000 ALTER TABLE `confirmasalida` DISABLE KEYS */;
/*!40000 ALTER TABLE `confirmasalida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `conpago`
--

LOCK TABLES `conpago` WRITE;
/*!40000 ALTER TABLE `conpago` DISABLE KEYS */;
/*!40000 ALTER TABLE `conpago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `controla`
--

LOCK TABLES `controla` WRITE;
/*!40000 ALTER TABLE `controla` DISABLE KEYS */;
/*!40000 ALTER TABLE `controla` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `cuesta`
--

LOCK TABLES `cuesta` WRITE;
/*!40000 ALTER TABLE `cuesta` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuesta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES (11111111,'pepe','pepe','pepe','22022022','Oficinista'),(52222222,'juan','juansito','juansito','22012121','Oficinista'),(52233221,'pedro iglesias','pedritodiosito','pedritodiosito','22086969','Oficinista');
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `foto`
--

LOCK TABLES `foto` WRITE;
/*!40000 ALTER TABLE `foto` DISABLE KEYS */;
/*!40000 ALTER TABLE `foto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `habitacion`
--

LOCK TABLES `habitacion` WRITE;
/*!40000 ALTER TABLE `habitacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `habitacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `horariohotel`
--

LOCK TABLES `horariohotel` WRITE;
/*!40000 ALTER TABLE `horariohotel` DISABLE KEYS */;
/*!40000 ALTER TABLE `horariohotel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `hospeda`
--

LOCK TABLES `hospeda` WRITE;
/*!40000 ALTER TABLE `hospeda` DISABLE KEYS */;
/*!40000 ALTER TABLE `hospeda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `mascota`
--

LOCK TABLES `mascota` WRITE;
/*!40000 ALTER TABLE `mascota` DISABLE KEYS */;
/*!40000 ALTER TABLE `mascota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `pertenece`
--

LOCK TABLES `pertenece` WRITE;
/*!40000 ALTER TABLE `pertenece` DISABLE KEYS */;
/*!40000 ALTER TABLE `pertenece` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `posee`
--

LOCK TABLES `posee` WRITE;
/*!40000 ALTER TABLE `posee` DISABLE KEYS */;
/*!40000 ALTER TABLE `posee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `precio`
--

LOCK TABLES `precio` WRITE;
/*!40000 ALTER TABLE `precio` DISABLE KEYS */;
/*!40000 ALTER TABLE `precio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `recibe`
--

LOCK TABLES `recibe` WRITE;
/*!40000 ALTER TABLE `recibe` DISABLE KEYS */;
/*!40000 ALTER TABLE `recibe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `regula`
--

LOCK TABLES `regula` WRITE;
/*!40000 ALTER TABLE `regula` DISABLE KEYS */;
/*!40000 ALTER TABLE `regula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tipohabitacion`
--

LOCK TABLES `tipohabitacion` WRITE;
/*!40000 ALTER TABLE `tipohabitacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipohabitacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `transporta`
--

LOCK TABLES `transporta` WRITE;
/*!40000 ALTER TABLE `transporta` DISABLE KEYS */;
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

-- Dump completed on 2020-10-08 10:48:16
