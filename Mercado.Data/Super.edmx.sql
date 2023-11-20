
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/12/2023 16:06:11
-- Generated from EDMX file: C:\Users\Usuario\source\repos\Mercado.Data\Mercado.Data\Super.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Supermercado];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Empresas'
CREATE TABLE [dbo].[Empresas] (
    [IdEmpresa] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Cuit] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'Locales'
CREATE TABLE [dbo].[Locales] (
    [IdLocal] int IDENTITY(1,1) NOT NULL,
    [IdEmpresa] int  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'Sectores'
CREATE TABLE [dbo].[Sectores] (
    [IdSector] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Articulos'
CREATE TABLE [dbo].[Articulos] (
    [IdArticulo] int IDENTITY(1,1) NOT NULL,
    [IdEmpresa] int  NOT NULL,
    [IdLocal] int  NOT NULL,
    [IdSector] int  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Perecedero] bit  NOT NULL,
    [Activo] bit  NOT NULL,
    [Precio] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'Ventas'
CREATE TABLE [dbo].[Ventas] (
    [IdArticulo] int  NOT NULL,
    [IdEmpresa] int  NOT NULL,
    [IdLocal] int  NOT NULL,
    [Importe] decimal(18,0)  NOT NULL,
    [Cantidad] int  NOT NULL,
    [FechaVta] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdEmpresa] in table 'Empresas'
ALTER TABLE [dbo].[Empresas]
ADD CONSTRAINT [PK_Empresas]
    PRIMARY KEY CLUSTERED ([IdEmpresa] ASC);
GO

-- Creating primary key on [IdLocal], [IdEmpresa] in table 'Locales'
ALTER TABLE [dbo].[Locales]
ADD CONSTRAINT [PK_Locales]
    PRIMARY KEY CLUSTERED ([IdLocal], [IdEmpresa] ASC);
GO

-- Creating primary key on [IdSector] in table 'Sectores'
ALTER TABLE [dbo].[Sectores]
ADD CONSTRAINT [PK_Sectores]
    PRIMARY KEY CLUSTERED ([IdSector] ASC);
GO

-- Creating primary key on [IdArticulo], [IdEmpresa], [IdLocal], [IdSector] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [PK_Articulos]
    PRIMARY KEY CLUSTERED ([IdArticulo], [IdEmpresa], [IdLocal], [IdSector] ASC);
GO

-- Creating primary key on [IdArticulo], [IdEmpresa] in table 'Ventas'
ALTER TABLE [dbo].[Ventas]
ADD CONSTRAINT [PK_Ventas]
    PRIMARY KEY CLUSTERED ([IdArticulo], [IdEmpresa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------