
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2020 10:24:09
-- Generated from EDMX file: D:\project\c#\Examdata\Examdata\datamodexam.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [exam];
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

-- Creating table 'Schools'
CREATE TABLE [dbo].[Schools] (
    [ScId] int IDENTITY(1,1) NOT NULL,
    [Sname] nvarchar(max)  NOT NULL,
    [Slocation] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Exams'
CREATE TABLE [dbo].[Exams] (
    [Eid] int IDENTITY(1,1) NOT NULL,
    [SchoolScId] int  NOT NULL
);
GO

-- Creating table 'Invigilators'
CREATE TABLE [dbo].[Invigilators] (
    [Iid] int IDENTITY(1,1) NOT NULL,
    [Iname] nvarchar(max)  NOT NULL,
    [SchoolScId] int  NOT NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [cid] int IDENTITY(1,1) NOT NULL,
    [cname] nvarchar(max)  NOT NULL,
    [SchoolScId] int  NOT NULL
);
GO

-- Creating table 'Subjects'
CREATE TABLE [dbo].[Subjects] (
    [suid] int IDENTITY(1,1) NOT NULL,
    [sname] nvarchar(max)  NOT NULL,
    [Course_cid] int  NOT NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [stid] int IDENTITY(1,1) NOT NULL,
    [sname] nvarchar(max)  NOT NULL,
    [Course_cid] int  NOT NULL,
    [SchoolScId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ScId] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [PK_Schools]
    PRIMARY KEY CLUSTERED ([ScId] ASC);
GO

-- Creating primary key on [Eid] in table 'Exams'
ALTER TABLE [dbo].[Exams]
ADD CONSTRAINT [PK_Exams]
    PRIMARY KEY CLUSTERED ([Eid] ASC);
GO

-- Creating primary key on [Iid] in table 'Invigilators'
ALTER TABLE [dbo].[Invigilators]
ADD CONSTRAINT [PK_Invigilators]
    PRIMARY KEY CLUSTERED ([Iid] ASC);
GO

-- Creating primary key on [cid] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([cid] ASC);
GO

-- Creating primary key on [suid] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [PK_Subjects]
    PRIMARY KEY CLUSTERED ([suid] ASC);
GO

-- Creating primary key on [stid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([stid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SchoolScId] in table 'Exams'
ALTER TABLE [dbo].[Exams]
ADD CONSTRAINT [FK_SchoolExam]
    FOREIGN KEY ([SchoolScId])
    REFERENCES [dbo].[Schools]
        ([ScId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolExam'
CREATE INDEX [IX_FK_SchoolExam]
ON [dbo].[Exams]
    ([SchoolScId]);
GO

-- Creating foreign key on [SchoolScId] in table 'Invigilators'
ALTER TABLE [dbo].[Invigilators]
ADD CONSTRAINT [FK_SchoolInvigilator]
    FOREIGN KEY ([SchoolScId])
    REFERENCES [dbo].[Schools]
        ([ScId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolInvigilator'
CREATE INDEX [IX_FK_SchoolInvigilator]
ON [dbo].[Invigilators]
    ([SchoolScId]);
GO

-- Creating foreign key on [SchoolScId] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK_SchoolCourse]
    FOREIGN KEY ([SchoolScId])
    REFERENCES [dbo].[Schools]
        ([ScId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolCourse'
CREATE INDEX [IX_FK_SchoolCourse]
ON [dbo].[Courses]
    ([SchoolScId]);
GO

-- Creating foreign key on [Course_cid] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [FK_CourseSubject]
    FOREIGN KEY ([Course_cid])
    REFERENCES [dbo].[Courses]
        ([cid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseSubject'
CREATE INDEX [IX_FK_CourseSubject]
ON [dbo].[Subjects]
    ([Course_cid]);
GO

-- Creating foreign key on [Course_cid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_CourseStudent]
    FOREIGN KEY ([Course_cid])
    REFERENCES [dbo].[Courses]
        ([cid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseStudent'
CREATE INDEX [IX_FK_CourseStudent]
ON [dbo].[Students]
    ([Course_cid]);
GO

-- Creating foreign key on [SchoolScId] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_SchoolStudent]
    FOREIGN KEY ([SchoolScId])
    REFERENCES [dbo].[Schools]
        ([ScId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolStudent'
CREATE INDEX [IX_FK_SchoolStudent]
ON [dbo].[Students]
    ([SchoolScId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------