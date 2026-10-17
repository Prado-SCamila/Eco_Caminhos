USE EcoCaminhos;
Go


INSERT INTO Casa (nomeCasa,num_quartos)
VALUES ('Ecolodge',3),
	('Ecolibirum',7),
	('Casa3',3);
	Go


INSERT INTO TipoPrograma(nomePrograma)
VALUES ('Ecoturismo'),
	('Voluntariado gratuito'),
	('Voluntariado pago');
	Go

	INSERT INTO Quarto (idCasa,capacidade)
VALUES (3,2),
       (3,2),
	   (3,1),
	   (2,2),
	   (2,2),
	   (2,2),
	   (2,2),
	   (2,2),
	   (2,2),
	   (2,2),
	   (1,2),
	   (1,2),
	   (1,2);
	   Go

	INSERT INTO Situacao (nomeSituacao)
VALUES ('Pago'),
       ('Pendente');
	Go

INSERT INTO Voluntarios
(nome, dataNascimento, nacionalidade, email, valorAdevolver,
 idCasa, idQuarto, idSituacaoFinanceira, dataEntrada, dataSaida,
 idTipoPrograma)

VALUES
('Amarante Amor', '19900101', 'Brasileiro',
 'amarante123@email.com', 300, 2, 4, 1,
 '20261014', '20261114', 1),

('Benigna Bem', '19800402', 'Americano',
 'benibenibeni@email.com', 300, 2, 5, 2,
 '20261019', '20271019', 2),

('Ilumina Alma', '20000503', 'Uruguaio',
 'iluiluilu@email.com', 200, 2, 6, 1,
 '20261102', '20271101', 2),

('Café da Silva', '20010910', 'Chileno',
 'cafecafe@gmail.com', 100, 3, 3, 2,
 '20261017', '20261027', 3),

('Armario Pereira', '19960109', 'Português',
 'armario@email.com', 30, 2, 4, 1,
 '20261019', '20261203', 1);
GO
  
  ALTER TABLE Quarto
ADD nomeQuarto VARCHAR(50) NULL;
GO

UPDATE Quarto SET nomeQuarto = 'FIGUEIRA'   WHERE idQuarto = 1;
UPDATE Quarto SET nomeQuarto = 'PINHEIRO'   WHERE idQuarto = 2;
UPDATE Quarto SET nomeQuarto = 'BROMELIA'   WHERE idQuarto = 3;
UPDATE Quarto SET nomeQuarto = 'CARVALHO'   WHERE idQuarto = 4;
UPDATE Quarto SET nomeQuarto = 'LAVANDA'    WHERE idQuarto = 5;
UPDATE Quarto SET nomeQuarto = 'MARGARIDA'  WHERE idQuarto = 6;
UPDATE Quarto SET nomeQuarto = 'LIRIO'      WHERE idQuarto = 7;
UPDATE Quarto SET nomeQuarto = 'ROSA'       WHERE idQuarto = 8;
UPDATE Quarto SET nomeQuarto = 'SEQUOIA'    WHERE idQuarto = 9;
UPDATE Quarto SET nomeQuarto = 'JEQUITIBA'  WHERE idQuarto = 10;
UPDATE Quarto SET nomeQuarto = 'MOGNO'      WHERE idQuarto = 11;
UPDATE Quarto SET nomeQuarto = 'AÇAI'       WHERE idQuarto = 12;
UPDATE Quarto SET nomeQuarto = 'ESPATODIA'  WHERE idQuarto = 13;
GO

ALTER TABLE Voluntarios
ALTER COLUMN idTipoPrograma INT NOT NULL;
GO


ALTER TABLE Voluntarios
ADD CONSTRAINT FK_Voluntarios_TipoPrograma
FOREIGN KEY (idTipoPrograma)
REFERENCES TipoPrograma (idTipoPrograma);
GO