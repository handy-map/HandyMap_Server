
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/28/2019 10:28:09
-- Generated from EDMX file: C:\Users\Molefi.Matla\Documents\Visual Studio 2017\Projects\HandyService\HandyService\App_Code\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [handyman];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClientJob]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Jobs] DROP CONSTRAINT [FK_ClientJob];
GO
IF OBJECT_ID(N'[dbo].[FK_JobWorker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Jobs] DROP CONSTRAINT [FK_JobWorker];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO
IF OBJECT_ID(N'[dbo].[Jobs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Jobs];
GO
IF OBJECT_ID(N'[dbo].[Workers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Workers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserId] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Users_Client'
CREATE TABLE [dbo].[Users_Client] (
    [clientId] int  NOT NULL,
    [email] nchar(100)  NOT NULL,
    [Name] nchar(50)  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Jobs'
CREATE TABLE [dbo].[Jobs] (
    [workerId] int  NOT NULL,
    [clientId] int  NOT NULL,
    [task] nchar(100)  NULL,
    [Client_clientId] int  NOT NULL,
    [Worker_workerId] int  NOT NULL
);
GO

-- Creating table 'Users_Worker'
CREATE TABLE [dbo].[Users_Worker] (
    [workerId] int  NOT NULL,
    [Name] nchar(50)  NOT NULL,
    [Surname] nchar(50)  NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Certificates'
CREATE TABLE [dbo].[Certificates] (
    [certificateId] int IDENTITY(1,1) NOT NULL,
    [WorkerUserId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [UserId] in table 'Users_Client'
ALTER TABLE [dbo].[Users_Client]
ADD CONSTRAINT [PK_Users_Client]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [workerId], [clientId] in table 'Jobs'
ALTER TABLE [dbo].[Jobs]
ADD CONSTRAINT [PK_Jobs]
    PRIMARY KEY CLUSTERED ([workerId], [clientId] ASC);
GO

-- Creating primary key on [UserId] in table 'Users_Worker'
ALTER TABLE [dbo].[Users_Worker]
ADD CONSTRAINT [PK_Users_Worker]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [certificateId] in table 'Certificates'
ALTER TABLE [dbo].[Certificates]
ADD CONSTRAINT [PK_Certificates]
    PRIMARY KEY CLUSTERED ([certificateId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Client_clientId] in table 'Jobs'
ALTER TABLE [dbo].[Jobs]
ADD CONSTRAINT [FK_ClientJob]
    FOREIGN KEY ([Client_clientId])
    REFERENCES [dbo].[Users_Client]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientJob'
CREATE INDEX [IX_FK_ClientJob]
ON [dbo].[Jobs]
    ([Client_clientId]);
GO

-- Creating foreign key on [Worker_workerId] in table 'Jobs'
ALTER TABLE [dbo].[Jobs]
ADD CONSTRAINT [FK_JobWorker]
    FOREIGN KEY ([Worker_workerId])
    REFERENCES [dbo].[Users_Worker]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JobWorker'
CREATE INDEX [IX_FK_JobWorker]
ON [dbo].[Jobs]
    ([Worker_workerId]);
GO

-- Creating foreign key on [WorkerUserId] in table 'Certificates'
ALTER TABLE [dbo].[Certificates]
ADD CONSTRAINT [FK_WorkerCertificate]
    FOREIGN KEY ([WorkerUserId])
    REFERENCES [dbo].[Users_Worker]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkerCertificate'
CREATE INDEX [IX_FK_WorkerCertificate]
ON [dbo].[Certificates]
    ([WorkerUserId]);
GO

-- Creating foreign key on [UserId] in table 'Users_Client'
ALTER TABLE [dbo].[Users_Client]
ADD CONSTRAINT [FK_Client_inherits_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [UserId] in table 'Users_Worker'
ALTER TABLE [dbo].[Users_Worker]
ADD CONSTRAINT [FK_Worker_inherits_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------