CREATE DATABASE HerramientasII
GO

USE HerramientasII
GO

CREATE SCHEMA libreria 
GO

CREATE TABLE libreria.usuarios(
    nombre varchar(40) primary key,
    password  varchar(20) not null
)
GO

DROP TABLE libreria.libro
GO

CREATE TABLE libreria.libro(
    codigo int primary key,
    titulo varchar(40) not null,
    autor varchar(20) not null
)
GO

CREATE TABLE libreria.suscriptores(
 documento char(8) primary key,
 nombre varchar(30),
 direccion varchar(30)
)
GO

CREATE TABLE libreria.prestamos(
 docsuscriptor char(8) not null,
 codigolibro int,
 fechaprestamo date not null,
 fechadevolucion date,
 primary key (codigolibro,fechaprestamo)
)
GO