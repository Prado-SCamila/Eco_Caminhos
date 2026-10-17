CREATE DATABASE EcoCaminhos;
Go

USE EcoCaminhos;
Go

CREATE TABLE Casa
(
idCasa INT PRIMARY KEY IDENTITY,
nomeCasa VARCHAR(100)NOT NULL,
num_quartos INT NOT NULL,
);
Go

CREATE TABLE Quarto
(
idQuarto INT PRIMARY KEY IDENTITY,
idCasa INT FOREIGN KEY REFERENCES Casa (idCasa),
capacidade INT NOT NULL,
);
Go

CREATE TABLE Situacao
(
idSituacaoFinanceira INT PRIMARY KEY IDENTITY,
nomeSituacao VARCHAR(50) NOT NULL,
);
Go

CREATE TABLE TipoPrograma
(
idTipoPrograma INT PRIMARY KEY IDENTITY,
nomePrograma VARCHAR(100) NOT NULL,
);
Go

CREATE TABLE Voluntarios
(
idVoluntario INT PRIMARY KEY IDENTITY,
nome VARCHAR(100)NOT NULL,
dataNascimento DATETIME NOT NULL,
email VARCHAR(100) NOT NULL,
nacionalidade VARCHAR(100) NOT NULL,
valorAdevolver DECIMAL(10, 2),
idCasa INT FOREIGN KEY REFERENCES Casa (idCasa),
idQuarto INT FOREIGN KEY REFERENCES Quarto (idQuarto),
idSituacaoFinanceira INT FOREIGN KEY REFERENCES Situacao (idSituacaoFinanceira),
dataEntrada DATETIME NOT NULL,
dataSaida DATETIME NOT NULL,
idTipoPrograma VARCHAR(50)NOT NULL,
);
Go


