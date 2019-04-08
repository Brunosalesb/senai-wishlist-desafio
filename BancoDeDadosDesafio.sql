CREATE DATABASE SENAI_WISHLIST 

USE SENAI_WISHLIST

CREATE TABLE USUARIOS(
	ID INT IDENTITY PRIMARY KEY,
	EMAIL VARCHAR(150) NOT NULL UNIQUE,
	SENHA VARCHAR(150) NOT NULL,
);

CREATE TABLE DESEJOS(
	ID INT IDENTITY PRIMARY KEY,
	DESCRICAO VARCHAR (150) NOT NULL,
	DATADESEJO DATE NOT NULL,
	ID_USUARIOS INT FOREIGN KEY REFERENCES USUARIOS (ID) NOT NULL
	);

INSERT INTO USUARIOS (EMAIL,SENHA)
VALUES('viniberrios@gmail.com','123456')

INSERT INTO DESEJOS(DESCRICAO, DATADESEJO, ID_USUARIOS)
VALUES('Vamo terminar isso suas bixas','10/01/2019',1 )

SELECT * FROM USUARIOS

SELECT * FROM DESEJOS