
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/17/2021 22:32:17
-- Generated from EDMX file: D:\ProyectoEdsaAcademy\Agenda\Agenda.Entity\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AgendaEdsa];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ContactoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContactoSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ContactoSet'
CREATE TABLE [dbo].[ContactoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ApellidoYNombre] nvarchar(max)  NOT NULL,
    [Genero] nvarchar(max)  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL,
    [Localidad] nvarchar(max)  NOT NULL,
    [Activo] nvarchar(max)  NOT NULL,
    [FechaIngresoDesde] datetime  NOT NULL,
    [FechaIngresoHasta] datetime  NOT NULL,
    [ContactoInterno] nvarchar(max)  NOT NULL,
    [TelFijoInterno] nvarchar(max)  NOT NULL,
    [TelCelular] nvarchar(max)  NOT NULL,
    [CuentaSkype] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Organizacion] nvarchar(max)  NOT NULL,
    [Area] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ContactoSet'
ALTER TABLE [dbo].[ContactoSet]
ADD CONSTRAINT [PK_ContactoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------