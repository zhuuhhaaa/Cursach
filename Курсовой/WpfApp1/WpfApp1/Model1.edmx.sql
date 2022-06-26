
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/22/2022 18:36:02
-- Generated from EDMX file: C:\Новая папка\WpfApp1\WpfApp1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [1];
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

-- Creating table 'Table'
CREATE TABLE [dbo].[Table] (
    [id] int  NOT NULL,
    [Brand] varchar(255)  NULL,
    [Model] varchar(255)  NULL,
    [YearOfIssue] varchar(255)  NULL,
    [TypeOfEngine] varchar(255)  NULL,
    [PowerOfEngine] varchar(255)  NULL,
    [SizeOfEngine] varchar(255)  NULL,
    [Cost] varchar(255)  NULL,
    [Count] varchar(255)  NULL,
    [Color] varchar(255)  NULL,
    [Condition] varchar(255)  NULL,
    [Image] varchar(255)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Table'
ALTER TABLE [dbo].[Table]
ADD CONSTRAINT [PK_Table]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------