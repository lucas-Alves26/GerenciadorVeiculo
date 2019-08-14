use master;

drop database gerenciadoVeiculo



create database gerenciadoVeiculo

use gerenciadoVeiculo

create table logins (
LOG_INT_ID INT NOT NULL identity(1,1),
LOG_STR_LOGIN VARCHAR(20) NOT NULL,
LOG_STR_SENHA VARCHAR(20) NOT NULL,
);

 
alter table logins 
add constraint PK_LOGINS_ID
PRIMARY KEY (LOG_INT_ID);

INSERT INTO logins (LOG_STR_LOGIN, LOG_STR_SENHA) VALUES ('admin123','admin123');
INSERT INTO logins (LOG_STR_LOGIN, LOG_STR_SENHA) VALUES ('lucas123','lucas123');


SELECT * FROM LOGINS;

