create database ConversorDB;
GO

USE ConversorDB;
GO

CREATE TABLE Conversiones
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NumeroEntrada NVARCHAR(255) NOT NULL,
    BaseOrigen NVARCHAR(50) NOT NULL,
    BaseDestino NVARCHAR(50) NOT NULL,
    Resultado NVARCHAR(255) NOT NULL,
    Fecha DATETIME NOT NULL DEFAULT GETDATE()
);
go

CREATE PROCEDURE sp_GuardarConversion
    @NumeroEntrada NVARCHAR(255),
    @BaseOrigen NVARCHAR(50),
    @BaseDestino NVARCHAR(50),
    @Resultado NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Conversiones (NumeroEntrada, BaseOrigen, BaseDestino, Resultado, Fecha)
    VALUES (@NumeroEntrada, @BaseOrigen, @BaseDestino, @Resultado, GETDATE());
END
go