use Desenvolvimento

INSERT INTO Veiculo SELECT 'Astra 2.0' AS Modelo, 'Prata' AS Cor,
GETDATE() AS AnoFabricacao, 100 AS Hodomedro

SELECT * from Veiculo

INSERT INTO Condutor SELECT 'Gustavo' AS Nome, 'Jordão' AS SobreNome, 
'2001-03-10' AS DataNascimento, 1 AS VeiculoId

SELECT * From Condutor