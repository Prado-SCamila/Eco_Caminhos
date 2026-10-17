USE EcoCaminhos;
Go

SELECT * FROM Voluntarios
GO

SELECT * FROM Casa
GO

SELECT * FROM Quarto
GO

SELECT * FROM Situacao
GO

SELECT * FROM TipoPrograma
GO

------------TABELA ALOCAÇÃO-----------

--SELECT Usuarios.nome AS Nome_do_Paciente,Usuarios.nome AS Médicos, Consultas.dataConsulta AS Data_da_Consulta ,Consultas.situacao AS Situação FROM Usuarios
SELECT Casa.nomeCasa, Casa.num_quartos FROM Casa
INNER JOIN Voluntarios
ON Voluntarios.idCasa = Casa.idCasa
INNER JOIN	Quarto
ON	Quarto.idQuarto = Voluntarios.idQuarto
SELECT Voluntarios.nome, Voluntarios.idCasa, Voluntarios.idQuarto,Voluntarios.dataEntrada,Voluntarios.dataSaida FROM Voluntarios
Go



SELECT
    Casa.nomeCasa,
    Quarto.nomeQuarto,
    Quarto.capacidade,
    COUNT(Voluntarios.idVoluntario) AS totalVoluntarios
FROM Quarto
INNER JOIN Casa
    ON Casa.idCasa = Quarto.idCasa
LEFT JOIN Voluntarios
    ON Voluntarios.idQuarto = Quarto.idQuarto
GROUP BY Casa.nomeCasa, Quarto.idQuarto, Quarto.nomeQuarto, Quarto.capacidade
ORDER BY Casa.nomeCasa, Quarto.idQuarto;
GO