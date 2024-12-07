CREATE DATABASE HerramientasII
GO

USE HerramientasII
GO

CREATE SCHEMA reservas 
GO

CREATE TABLE reservas.reserva(
    id INT PRIMARY KEY IDENTITY(1,1),
    estado BIT NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    fecha DATETIME NOT NULL
)
GO

