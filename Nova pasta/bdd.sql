

-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS bdd DEFAULT CHARACTER SET utf8 ;


CREATE SCHEMA IF NOT EXISTS bdd DEFAULT CHARACTER SET utf8 COLLATE utf8_bin ;
USE bdd ;



CREATE TABLE IF NOT EXISTS venda (
  `idmaquina_1` INT(11) NOT NULL,
  `validação_troco` INT NOT NULL);


select * from venda;

CREATE TABLE IF NOT EXISTS Ticket (
  `idTicket` INT NOT NULL AUTO_INCREMENT,
  `nome_da_linha` VARCHAR(45) NOT NULL,
  `data` DATETIME NOT NULL,
  `valor_ticket` DECIMAL(4,2) NOT NULL,
  `data_uso`DATETIME NOT NULL);

select * from Ticket ;

CREATE TABLE IF NOT EXISTS troco (
  `idtroco` INT UNSIGNED NOT NULL,
  `qtd_nota2` INT UNSIGNED NOT NULL,
  `qtd_nota5` INT UNSIGNED NOT NULL,
  `qtd_nota10` INT UNSIGNED NOT NULL,
  `qtd_nota20` INT UNSIGNED NOT NULL,
  `qtd_moeda5` INT UNSIGNED NOT NULL,
  `qtd_moeda10` INT UNSIGNED NOT NULL,
  `qtd_moeda25` INT UNSIGNED NOT NULL,
  `qtd_moeda50` INT UNSIGNED NOT NULL,
  `qtd_moeda1` INT UNSIGNED NOT NULL);

INSERT INTO `Ticket` VALUES ('2147483647','\"Praiamar\"','1994-09-04 14:34:44',3.80),
('2147483647','\"Caraguatatuba/ Ubatuba \"','2005-11-07 18:40:18',8.90),
('2147483647','\"Caraguatatuba/ Ubatuba \"','2013-07-18 11:09:08',8.90),
('2147483647','\"Caraguatatuba/ Ubatuba \"','2010-06-12 20:06:01',8.90),
('2147483647','\"Caraguatatuba/São sebastião\"','1974-07-16 01:31:00',5.15),
('2147483647','\"Caraguatatuba/ Ubatuba \"','2012-10-24 19:41:23', 8.90),
('2147483647','\"Caraguatatuba/ Ubatuba \"','2015-01-08 23:09:40',8.90),
('2147483647','\"Caraguatatuba(Lagoinha)/Caraguatatuba(Tabati','2008-06-27 18:57:28',4.95),
('2147483647','\"Caraguatatuba/São sebastião\"','2002-12-19 06:36:49',5.15),
('2147483647','\"Caraguatatuba/São sebastião\"','1980-12-16 02:27:22',5.15),
('2147483647','\"Ubatuba(Rodoviária)/Caraguatatuba(Tabatinga)','1999-01-14 19:34:24',5.15),
('2147483647','\"Caraguatatuba(Lagoinha)/Caraguatatuba(Tabati','1975-03-10 03:44:37',4.95),
('2147483647','\"Ubatuba(Rodoviária)/Caraguatatuba(Tabatinga)','1989-06-25 23:20:40',5.15),
('2147483647','\"Caraguatatuba/São sebastião\"','1975-03-22 17:20:14',5.15),
('2147483647','\"Caraguatatuba(Lagoinha)/Caraguatatuba(Tabati','1977-03-09 10:23:18',4.95),
('2147483647','\"Praiamar\"','1988-03-13 23:10:03',3.80),
('2147483647','\"Caraguatatuba/ Ubatuba \"','1986-02-05 14:47:44',8.90); 


select * from Ticket ;



select * from troco ;

USE `onibus` ;

#---------------------------------------------------------















