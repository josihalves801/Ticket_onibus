

-- -----------------------------------------------------

drop database bdd;
CREATE SCHEMA IF NOT EXISTS bdd DEFAULT CHARACTER SET utf8 ;



USE bdd ;



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

INSERT INTO `Ticket` VALUES 
('2147483647','Praiamar',null,3.80,null),
('2147483641','Centro de Ubatuba',null,8.90,null),
('2147483642','Centro de Ubatuba',null,8.90,null),
('2147483643','Centro de Ubatuba',null,8.90,null),
('2147483644','São sebastião',null,5.15,null),
('2147483645','Centro de Ubatuba',null, 8.90,null),
('2147483646','Centro de Ubatuba',null,8.90,null),
('2147443648','Ubatuba(Lagoinha)',null,4.95,null),
('2147483649','São sebastião',null,5.15,null),
('2147483627','São sebastião',null,5.15,null),
('2147483637','Centro de Ubatuba',null,5.15,null),
('2147483657','Ubatuba(Lagoinha)',null,4.95,null),
('2147483697','Ubatuba(Lagoinha)',null,5.15,null),
('2147483687','São sebastião',null,5.15,null),
('2147483547','Ubatuba(Lagoinha)',null,4.95,null),
('2147483747','Praiamar',null,3.80,null),
('2147483947','Centro de Ubatuba',null,8.90,null); 


select * from Ticket ;


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

#---------------------------------------------------------















