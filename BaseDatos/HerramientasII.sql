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

CREATE SCHEMA empleado
GO

DROP SCHEMA empleado
GO

DROP TABLE empleado.empleado

CREATE TABLE empleado.empleado(
    idempleado INT PRIMARY KEY,
    apellido VARCHAR(50) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    direccion VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL
)
GO

INSERT INTO empleado.empleado VALUES
(111, 'Vélez', 'Jaime','Cra 1 #1-1','vj@gmail.com'),
(222, 'Roldan', 'Eliecer','Cra 2 #1-1','re@gmail.com'),
(333, 'Perez', 'Diego','Cra 3 #1-1','pd@gmail.com'),
(444, 'Ochoa', 'Leo','Cra 5 #1-1','ol@gmail.com'),
(555, 'Roa', 'Ana','Cra 6 #1-1','ra@gmail.com');
GO