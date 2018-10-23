

-- -----------------------------------------------------

drop database bdd;
CREATE SCHEMA IF NOT EXISTS bdd DEFAULT CHARACTER SET utf8 ;



USE bdd ;

use bdd;


CREATE TABLE IF NOT EXISTS venda (
  `idmaquina_1`  INT(11) PRIMARY KEY  NOT NULL  ,
  `validação_troco` INT NOT NULL);














select * from venda;

CREATE TABLE IF NOT EXISTS Ticket (
  `idTicket` INT NOT NULL,
  `nome_da_linha` VARCHAR(45) NOT NULL,
  `data` DATETIME NOT NULL,
  `valor_ticket` DECIMAL(4,2) NOT NULL,
  `data_uso`DATETIME NOT NULL);

select * from Ticket ;

CREATE TABLE IF NOT EXISTS troco (
  `idtroco` INT UNSIGNED PRIMARY KEY  NOT NULL ,
  `qtd_nota2` INT(2)UNSIGNED NOT NULL ,
  `qtd_nota5` INT(2) UNSIGNED NOT NULL,
  `qtd_nota10` INT(2) UNSIGNED NOT NULL,
  `qtd_nota20` INT(2) UNSIGNED NOT NULL,
  `qtd_moeda5` INT(2) UNSIGNED NOT NULL,
  `qtd_moeda10` INT(2) UNSIGNED NOT NULL,
  `qtd_moeda25` INT(2) UNSIGNED NOT NULL,
  `qtd_moeda50` INT(2) UNSIGNED NOT NULL,
  `qtd_moeda1` INT (2)UNSIGNED NOT NULL);

INSERT INTO `Ticket` VALUES ('2147483647','\"Praiamar\"','1994-09-04 14:34:44',3.80,'1976-08-20 17:08:41'),
('2147483641','\"Caraguatatuba/ Ubatuba \"','2005-11-07 18:40:18',8.90,'1997-12-10 11:16:21'),
('2147483642','\"Caraguatatuba/ Ubatuba \"','2013-07-18 11:09:08',8.90,'1997-10-22 20:38:09'),
('2147483643','\"Caraguatatuba/ Ubatuba \"','2010-06-12 20:06:01',8.90,'1991-11-27 18:41:37'),
('2147483644','\"Caraguatatuba/São sebastião\"','1974-07-16 01:31:00',5.15,'2001-11-05 08:03:48'),
('2147483645','\"Caraguatatuba/ Ubatuba \"','2012-10-24 19:41:23', 8.90,'1977-09-28 19:08:25'),
('2147483646','\"Caraguatatuba/ Ubatuba \"','2015-01-08 23:09:40',8.90,'1999-12-02 00:07:16'),
('2147443648','\"Caraguatatuba(Lagoinha)/Caraguatatuba(Tabati','2008-06-27 18:57:28',4.95,'1973-04-16 04:46:41'),
('2147483649','\"Caraguatatuba/São sebastião\"','2002-12-19 06:36:49',5.15,'1974-10-20 17:28:17'),
('2147483627','\"Caraguatatuba/São sebastião\"','1980-12-16 02:27:22',5.15,'1994-01-24 13:37:15'),
('2147483637','\"Ubatuba(Rodoviária)/Caraguatatuba(Tabatinga)','1999-01-14 19:34:24',5.15,'2009-12-12 20:33:21'),
('2147483657','\"Caraguatatuba(Lagoinha)/Caraguatatuba(Tabati','1975-03-10 03:44:37',4.95,'2015-11-14 19:21:34'),
('2147483697','\"Ubatuba(Rodoviária)/Caraguatatuba(Tabatinga)','1989-06-25 23:20:40',5.15,'1980-11-09 11:36:07'),
('2147483687','\"Caraguatatuba/São sebastião\"','1975-03-22 17:20:14',5.15,'2015-11-14 19:21:34'),
('2147483547','\"Caraguatatuba(Lagoinha)/Caraguatatuba(Tabati','1977-03-09 10:23:18',4.95,'1980-11-09 11:36:07'),
('2147483747','\"Praiamar\"','1988-03-13 23:10:03',3.80,'1980-11-09 11:36:07'),
('2147483947','\"Caraguatatuba/ Ubatuba \"','1986-02-05 14:47:44',8.90,'1974-08-08 17:26:21'); 


select * from Ticket ;

UPDATE `Ticket`
SET `valor_ticket `= 3.80
WHERE `nome_da_linha` = '\"Praiamar\"';


INSERT INTO `troco` VALUES ('1','72','56','91','54','96','85','93','59','72'),
('2','99','52','87','75','70','96','98','83','95'),
('3','99','96','79','73','75','71','56','68','80'),
('4','99','50','55','98','72','56','54','99','100'),
('5','66','96','92','62','91','92','61','75','86'),
('6','72','57','97','52','98','71','74','96','89'),
('7','62','63','51','91','50','85','95','84','82'),
('8','94','98','69','50','52','51','98','65','62'),
('9','51','54','97','72','66','53','65','52','84'); 



select * from troco ;

USE `onibus` ;

#---------------------------------------------------------















