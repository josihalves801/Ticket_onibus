

-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS bdd DEFAULT CHARACTER SET utf8 ;

drop database if exists bdd;

CREATE SCHEMA IF NOT EXISTS bdd DEFAULT CHARACTER SET utf8 COLLATE utf8_bin ;
USE bdd ;

use bdd;

CREATE TABLE IF NOT EXISTS maquina_2 (
  `idmaquina_2` INT NOT NULL,
  `verifica_cod` INT NOT NULL,
  `linha` VARCHAR(45) NOT NULL,
  `numero_onibus` INT NOT NULL);


select * from maquina_2;


CREATE TABLE IF NOT EXISTS maquina_1 (
  `idmaquina_1` INT(11) NOT NULL,
  `validação_troco` INT NOT NULL);


select * from maquina_1;

CREATE TABLE IF NOT EXISTS Ticket (
  `idTicket` INT NOT NULL auto_increment primary key,
  `nome_da_linha` VARCHAR(45) NOT NULL,
  `data` DATETIME NULL,
  `valor_ticket` DECIMAL(4,2) NOT NULL,
  `data_uso`datetime null);

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

INSERT INTO `Ticket` VALUES 
('2147483647','\"Praiamar\"',null ,3.80),
('2147483648','\"Caraguatatuba/ Ubatuba \"',null ,8.90),
('2147483649','\"Caraguatatuba/ Ubatuba \"',null ,8.90),
('2147483650','\"Caraguatatuba/ Ubatuba \"','2010-06-12 20:06:01',8.90),
('2147483651','\"Caraguatatuba/São sebastião\"','1974-07-16 01:31:00',5.15),
('2147483652','\"Caraguatatuba/ Ubatuba \"','2012-10-24 19:41:23', 8.90),
('2147483653','\"Caraguatatuba/ Ubatuba \"',null,8.90),
('2147483654','\"Caraguatatuba(Lagoinha)/Caraguatatuba(Tabati',null ,4.95),
('2147483655','\"Caraguatatuba/São sebastião\"',null ,5.15),
('2147483656','\"Caraguatatuba/São sebastião\"', null,5.15),
('2147483657','\"Ubatuba(Rodoviária)/Caraguatatuba(Tabatinga)',null ,5.15),
('2147483658','\"Caraguatatuba(Lagoinha)/Caraguatatuba(Tabati',null ,4.95),
('2147483647','\"Ubatuba(Rodoviária)/Caraguatatuba(Tabatinga)',null ,5.15),
('2147483647','\"Caraguatatuba/São sebastião\"',null ,5.15),
('2147483647','\"Caraguatatuba(Lagoinha)/Caraguatatuba(Tabati',null ,4.95),
('2147483647','\"Praiamar\"',null ,3.80),
('2147483647','\"Caraguatatuba/ Ubatuba \"',null ,8.90); 


select * from Ticket ;

# update do valor da passagem 

UPDATE Ticket
SET valor_ticket = 3.80
WHERE nome_da_linha = '\"Praiamar\"';


select * from troco ;

USE `onibus` ;

#---------------------------------------------------------















