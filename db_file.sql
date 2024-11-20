CREATE DATABASE gestao_facil_db;
USE gestao_facil_db;

CREATE TABLE servidor(
id_ser INT NOT NULL AUTO_INCREMENT,
nome_ser VARCHAR (255) NOT NULL,
cpf_ser VARCHAR (14) NOT NULL,
siape_ser INT NOT NULL,
PRIMARY KEY(id_ser)
);

INSERT INTO servidor VALUES (null, "Maju", "123.456.789-10", "98765");
INSERT INTO servidor VALUES (null, "Leyukezer", "455.456.789-10", "14320");
INSERT INTO servidor VALUES (null, "Amanda", "872.456.789-10", "92301");
INSERT INTO servidor VALUES (null, "Adrian", "872.321.789-10", "15329");

SELECT * FROM servidor;