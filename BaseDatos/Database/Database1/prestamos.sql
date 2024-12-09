CREATE TABLE [libreria].[prestamos]
(
 docsuscriptor char(8) not null,
 codigolibro int,
 fechaprestamo date not null,
 fechadevolucion date,
 primary key (codigolibro,fechaprestamo)
)
