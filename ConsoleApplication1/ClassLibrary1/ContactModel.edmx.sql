
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 09/30/2013 17:02:55
-- Generated from EDMX file: C:\Users\Peter\Documents\GitHub\CPS593.NET\ConsoleApplication1\ClassLibrary1\ContactModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CSharp];
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

-- Creating table 'Contacts1'
CREATE TABLE [dbo].[Contacts1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Keyword_Id] int  NOT NULL
);
GO

-- Creating table 'Keywords1'
CREATE TABLE [dbo].[Keywords1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Parent_Id] int  NOT NULL
);
GO

-- Creating table 'ContactMethods1'
CREATE TABLE [dbo].[ContactMethods1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Contacts_Id] int  NOT NULL,
    [Keywords_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Contacts1'
ALTER TABLE [dbo].[Contacts1]
ADD CONSTRAINT [PK_Contacts1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Keywords1'
ALTER TABLE [dbo].[Keywords1]
ADD CONSTRAINT [PK_Keywords1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ContactMethods1'
ALTER TABLE [dbo].[ContactMethods1]
ADD CONSTRAINT [PK_ContactMethods1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Parent_Id] in table 'Keywords1'
ALTER TABLE [dbo].[Keywords1]
ADD CONSTRAINT [FK_KeywordsKeywords]
    FOREIGN KEY ([Parent_Id])
    REFERENCES [dbo].[Keywords1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_KeywordsKeywords'
CREATE INDEX [IX_FK_KeywordsKeywords]
ON [dbo].[Keywords1]
    ([Parent_Id]);
GO

-- Creating foreign key on [Keyword_Id] in table 'Contacts1'
ALTER TABLE [dbo].[Contacts1]
ADD CONSTRAINT [FK_KeywordsContacts]
    FOREIGN KEY ([Keyword_Id])
    REFERENCES [dbo].[Keywords1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_KeywordsContacts'
CREATE INDEX [IX_FK_KeywordsContacts]
ON [dbo].[Contacts1]
    ([Keyword_Id]);
GO

-- Creating foreign key on [Contacts_Id] in table 'ContactMethods1'
ALTER TABLE [dbo].[ContactMethods1]
ADD CONSTRAINT [FK_ContactMethodsContacts]
    FOREIGN KEY ([Contacts_Id])
    REFERENCES [dbo].[Contacts1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContactMethodsContacts'
CREATE INDEX [IX_FK_ContactMethodsContacts]
ON [dbo].[ContactMethods1]
    ([Contacts_Id]);
GO

-- Creating foreign key on [Keywords_Id] in table 'ContactMethods1'
ALTER TABLE [dbo].[ContactMethods1]
ADD CONSTRAINT [FK_ContactMethodsKeywords]
    FOREIGN KEY ([Keywords_Id])
    REFERENCES [dbo].[Keywords1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContactMethodsKeywords'
CREATE INDEX [IX_FK_ContactMethodsKeywords]
ON [dbo].[ContactMethods1]
    ([Keywords_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------