CREATE DATABASE Parciales1Db
GO
USE Parciales1Db
GO
CREATE TABLE PArciales

(
 GrupoId int primary key identity (1,1),
 Fecha date,
 Descripcion varchar(max),
 Cantidad int,
 Grupos int,
 Integrantes varchar(max)
);