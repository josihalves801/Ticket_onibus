

-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS bdd DEFAULT CHARACTER SET utf8 ;


CREATE SCHEMA IF NOT EXISTS bdd DEFAULT CHARACTER SET utf8 COLLATE utf8_bin ;
USE bdd ;


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
  `idTicket` INT NOT NULL,
  `nome_da_linha` VARCHAR(45) NOT NULL,
  `data` DATETIME NOT NULL,
  `horario` TIME ,
  `valor_ticket` DECIMAL NOT NULL);

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

select * from troco ;

USE `onibus` ;

