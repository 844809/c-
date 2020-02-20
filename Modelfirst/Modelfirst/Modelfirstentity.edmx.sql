
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2020 13:25:56
-- Generated from EDMX file: D:\project\c#\Modelfirst\Modelfirst\Modelfirstentity.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EmployeDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_categoryProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_categoryProduct];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[categories];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Products'
ALTER TABLE [dbo].[Products] (
    [pid] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(max)  NOT NULL,
    [price] decimal(18,0)  NOT NULL,
    [category_cid] int  NOT NULL
);
GO

-- Creating table 'categories'
CREATE TABLE [dbo].[categories] (
    [cid] int IDENTITY(1,1) NOT NULL,
    [cname] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [pid] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([pid] ASC);
GO

-- Creating primary key on [cid] in table 'categories'
ALTER TABLE [dbo].[categories]
ADD CONSTRAINT [PK_categories]
    PRIMARY KEY CLUSTERED ([cid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [category_cid] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_categoryProduct]
    FOREIGN KEY ([category_cid])
    REFERENCES [dbo].[categories]
        ([cid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_categoryProduct'
CREATE INDEX [IX_FK_categoryProduct]
ON [dbo].[Products]
    ([category_cid]);
GO
ALTER TABLE [dbo].[Products] add
    
    [category_cid] int  NOT NULL
	
-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------