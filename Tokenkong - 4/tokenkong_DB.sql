-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: local
-- ------------------------------------------------------
-- Server version	5.7.26

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
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NAME` varchar(100) CHARACTER SET latin1 NOT NULL,
  `EMAIL` varchar(100) CHARACTER SET latin1 DEFAULT NULL,
  `PHONE` varchar(15) CHARACTER SET latin1 NOT NULL,
  `CPF` varchar(14) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Fulano Teste','fulano@testel.com','(19) 99999-9999','123-456-789-10'),(2,'Ciclano Teste','ciclano@teste.com','(19) 99999-9999','123.456.789.10'),(3,'Beutrano Teste','beutrano@teste.com','(19) 99999-9999','123.456.789.10');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `expense`
--

DROP TABLE IF EXISTS `expense`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `expense` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `DESCRIPTION` varchar(200) CHARACTER SET latin1 DEFAULT NULL,
  `DATE` datetime NOT NULL,
  `PROVIDER_ID` int(11) NOT NULL,
  `AMOUNT` float(5,2) NOT NULL,
  `PAID` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID`),
  KEY `PROVIDER_ID` (`PROVIDER_ID`),
  CONSTRAINT `expense_ibfk_1` FOREIGN KEY (`PROVIDER_ID`) REFERENCES `provider` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `expense`
--

LOCK TABLES `expense` WRITE;
/*!40000 ALTER TABLE `expense` DISABLE KEYS */;
/*!40000 ALTER TABLE `expense` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `income`
--

DROP TABLE IF EXISTS `income`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `income` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `DESCRIPTION` varchar(200) CHARACTER SET latin1 DEFAULT NULL,
  `USER_ID` int(11) NOT NULL,
  `CLIENT_ID` int(11) NOT NULL,
  `DATE` datetime NOT NULL,
  `AMOUNT` float(8,2) NOT NULL,
  `PAID` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID`),
  KEY `USER_ID` (`USER_ID`),
  KEY `CLIENT_ID` (`CLIENT_ID`),
  CONSTRAINT `income_ibfk_1` FOREIGN KEY (`USER_ID`) REFERENCES `user` (`ID`),
  CONSTRAINT `income_ibfk_2` FOREIGN KEY (`CLIENT_ID`) REFERENCES `client` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `income`
--

LOCK TABLES `income` WRITE;
/*!40000 ALTER TABLE `income` DISABLE KEYS */;
/*!40000 ALTER TABLE `income` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NAME` varchar(100) CHARACTER SET latin1 NOT NULL,
  `QUANTITY` int(11) NOT NULL DEFAULT '0',
  `PRICE` double(5,2) NOT NULL,
  `COST` double(5,2) NOT NULL,
  `DISCOUNT_PERCENTAGE` double NOT NULL DEFAULT '0',
  `DESCRIPTION` varchar(200) CHARACTER SET latin1 NOT NULL,
  `PROVIDER_ID` int(11) NOT NULL,
  `IMAGE` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (1,'Ração 12Kg Frango',30,32.00,19.90,0,'Descrição do produto.',1,'racao_premier_a_md_12kg_frango_chia_quinoa.png'),(2,'Biscoitos Caninos 420g',45,14.99,5.99,0,'Descrição do produto.',2,'golden_cookie_f_420g.png'),(3,'Ração 12Kg Frango com Batata Doce',29,32.00,18.99,0,'Descrição do produto.',1,'racao_premier_a_md_12kg_frango_batata_doce.png'),(4,'Ração 10,1 Kg',80,29.00,15.00,0,'Descrição do produto.',4,'racao_premier_a_sm_10kg100g_frango_chia_quinoa.png'),(5,'Shampoo Para Cães',71,8.00,18.00,0,'Descrição do produto.',3,'shampoo_beeps_caes_f_500ml.png'),(6,'Shampoo Para Gatos',30,8.00,18.00,0,'Descrição do produto.',1,'shampoo_beeps_gatos_500ml.png');
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product_income`
--

DROP TABLE IF EXISTS `product_income`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product_income` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `PRODUCT_ID` int(11) NOT NULL,
  `INCOME_ID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `PRODUCT_ID` (`PRODUCT_ID`),
  KEY `product_income_ibfk_2` (`INCOME_ID`),
  CONSTRAINT `product_income_ibfk_1` FOREIGN KEY (`PRODUCT_ID`) REFERENCES `product` (`ID`),
  CONSTRAINT `product_income_ibfk_2` FOREIGN KEY (`INCOME_ID`) REFERENCES `income` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_income`
--

LOCK TABLES `product_income` WRITE;
/*!40000 ALTER TABLE `product_income` DISABLE KEYS */;
/*!40000 ALTER TABLE `product_income` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `provider`
--

DROP TABLE IF EXISTS `provider`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `provider` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NAME` varchar(100) CHARACTER SET latin1 NOT NULL,
  `EMAIL` varchar(100) CHARACTER SET latin1 DEFAULT NULL,
  `PHONE` varchar(15) CHARACTER SET latin1 NOT NULL,
  `CNPJ` varchar(18) CHARACTER SET latin1 NOT NULL,
  `ENDEREÇO` varchar(100) CHARACTER SET latin1 DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `provider`
--

LOCK TABLES `provider` WRITE;
/*!40000 ALTER TABLE `provider` DISABLE KEYS */;
INSERT INTO `provider` VALUES (1,'Fornecedor 1','fornecedor1@fornecedor1.com','(00) 90000-0001','12.345.678/0001-01','Jd. Vila dos bobos, nº 0'),(2,'Fornecedor 2','fornecedor2@fornecedor2.com','(00) 90000-0002','12.345.678/0001-02','Jd. Vila dos bobos, nº 1'),(3,'Fornecedor 3','fornecedor3@fornecedor3.com','(00) 90000-0003','12.345.678/0001-03','Jd. Vila dos bobos, nº 2'),(4,'Fornecedor 4','fornecedor4@fornecedor4.com','(00) 90000-0004','12.345.678/0001-04','Jd. Vila dos bobos, nº 3');
/*!40000 ALTER TABLE `provider` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NAME` varchar(100) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'atendente'),(2,'gerente'),(3,'proprietario');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NAME` varchar(100) CHARACTER SET latin1 NOT NULL,
  `EMAIL` varchar(100) CHARACTER SET latin1 DEFAULT NULL,
  `PHONE` varchar(15) CHARACTER SET latin1 NOT NULL,
  `CPF` varchar(14) CHARACTER SET latin1 NOT NULL,
  `ROLE_ID` int(11) NOT NULL,
  `PASSWORD` varchar(20) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `ROLE_ID` (`ROLE_ID`),
  CONSTRAINT `user_ibfk_1` FOREIGN KEY (`ROLE_ID`) REFERENCES `role` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Usuário qualquer','teste@teste.com','(19) 99999-9999','000.000.000.00',1,'12345678');
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

-- Dump completed on 2019-12-02 22:16:42
