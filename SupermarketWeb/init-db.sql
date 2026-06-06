-- Supermarket Database Initialization Script
-- Run this after SQL Server starts via Docker

USE [master]
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'smarket')
BEGIN
    CREATE DATABASE [smarket]
END
GO

USE [smarket]
GO

-- Admins table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Admins')
BEGIN
    CREATE TABLE [dbo].[Admins] (
        [Id]           INT          IDENTITY(1,1) NOT NULL,
        [UserName]     NVARCHAR(200) NOT NULL,
        [Password]     NVARCHAR(200) NOT NULL,
        [Active]       BIT          NOT NULL DEFAULT 1,
        [isSuperAdmin] BIT          NULL,
        CONSTRAINT [PKA_Admins] PRIMARY KEY CLUSTERED ([Id] ASC)
    )
END
GO

-- CategoryTbl
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'CategoryTbl')
BEGIN
    CREATE TABLE [dbo].[CategoryTbl] (
        [CatId]   INT           IDENTITY(1,1) NOT NULL,
        [CatName] NVARCHAR(200) NOT NULL,
        [CatDesc] NVARCHAR(500) NOT NULL DEFAULT '',
        [Date]    DATETIME      NULL,
        CONSTRAINT [PKA_CategoryTbl] PRIMARY KEY CLUSTERED ([CatId] ASC)
    )
END
GO

-- ProductTbl
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ProductTbl')
BEGIN
    CREATE TABLE [dbo].[ProductTbl] (
        [ProdId]    INT           IDENTITY(1,1) NOT NULL,
        [ProdName]  NVARCHAR(200) NOT NULL,
        [ProdQty]   INT           NOT NULL DEFAULT 0,
        [ProdPrice] DECIMAL(10,2) NOT NULL DEFAULT 0,
        [ProdCatID] INT           NULL,
        [ProdCat]   NVARCHAR(200) NOT NULL DEFAULT '',
        [Date]      DATETIME      NULL,
        CONSTRAINT [PKA_ProductTbl] PRIMARY KEY CLUSTERED ([ProdId] ASC),
        CONSTRAINT [FK_ProductTbl_CategoryTbl] FOREIGN KEY ([ProdCatID]) REFERENCES [CategoryTbl] ([CatId])
    )
END
GO

-- SellersTbl
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SellersTbl')
BEGIN
    CREATE TABLE [dbo].[SellersTbl] (
        [SellerId]       INT            IDENTITY(1,1) NOT NULL,
        [SellerUserName] NVARCHAR(200)  NOT NULL,
        [SellerPass]     NVARCHAR(200)  NOT NULL,
        [SellerName]     NVARCHAR(200)  NOT NULL,
        [SellerAge]      INT            NOT NULL DEFAULT 0,
        [SellerPhone]    BIGINT         NOT NULL DEFAULT 0,
        [Date]           DATETIME       NOT NULL,
        [Address]        NVARCHAR(500)  NOT NULL DEFAULT '',
        [Active]         BIT            NOT NULL DEFAULT 1,
        [Image]          VARBINARY(MAX) NULL,
        CONSTRAINT [PKA_SellersTbl] PRIMARY KEY CLUSTERED ([SellerId] ASC)
    )
END
GO

-- BillTbl
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'BillTbl')
BEGIN
    CREATE TABLE [dbo].[BillTbl] (
        [BillId]      INT            IDENTITY(1,1) NOT NULL,
        [Comments]    NVARCHAR(500)  NULL DEFAULT '',
        [SellerName]  NVARCHAR(200)  NOT NULL,
        [Date]        DATETIME       NOT NULL,
        [TotAmt]      DECIMAL(10,2)  NOT NULL DEFAULT 0,
        [ProductIDs]  NVARCHAR(1000) NULL DEFAULT '',
        [CategoryIDs] NVARCHAR(1000) NULL DEFAULT '',
        CONSTRAINT [PKA_BillTbl] PRIMARY KEY CLUSTERED ([BillId] ASC)
    )
END
GO

-- SP_CleanDatabaseTables
IF OBJECT_ID('dbo.SP_CleanDatabaseTables', 'P') IS NOT NULL
    DROP PROCEDURE dbo.SP_CleanDatabaseTables
GO
CREATE PROCEDURE [dbo].[SP_CleanDatabaseTables]
AS
BEGIN
    DELETE FROM [BillTbl]
    DELETE FROM [ProductTbl]
    DELETE FROM [CategoryTbl]
    DELETE FROM [SellersTbl]
    DBCC CHECKIDENT ('BillTbl', RESEED, 0)
    DBCC CHECKIDENT ('ProductTbl', RESEED, 0)
    DBCC CHECKIDENT ('CategoryTbl', RESEED, 0)
    DBCC CHECKIDENT ('SellersTbl', RESEED, 0)
END
GO

-- ── Seed data ──────────────────────────────────────────────────────────────

-- Default SuperAdmin: admin / admin123
IF NOT EXISTS (SELECT 1 FROM [Admins] WHERE UserName = 'admin')
BEGIN
    INSERT INTO [Admins] ([UserName], [Password], [Active], [isSuperAdmin])
    VALUES ('admin', '$2a$12$LQv3c1yqBWVHxkd0LHAkCOYz6TtxMQJqhN8/LewYpfQN.3q0V5zOa', 1, 1)
    -- Password: admin123
END
GO

-- Sample categories
IF NOT EXISTS (SELECT 1 FROM [CategoryTbl])
BEGIN
    INSERT INTO [CategoryTbl] ([CatName], [CatDesc], [Date]) VALUES
        (N'Φρούτα & Λαχανικά', N'Φρέσκα φρούτα και λαχανικά', GETDATE()),
        (N'Γαλακτοκομικά', N'Γάλα, τυρί, βούτυρο, γιαούρτι', GETDATE()),
        (N'Αρτοποιία', N'Ψωμί, αρτοσκευάσματα', GETDATE()),
        (N'Κρεοπωλείο', N'Κρέας, πουλερικά, αλλαντικά', GETDATE()),
        (N'Ποτά', N'Νερό, αναψυκτικά, χυμοί', GETDATE()),
        (N'Κατεψυγμένα', N'Κατεψυγμένα τρόφιμα', GETDATE())
END
GO

-- Sample products
IF NOT EXISTS (SELECT 1 FROM [ProductTbl])
BEGIN
    INSERT INTO [ProductTbl] ([ProdName], [ProdQty], [ProdPrice], [ProdCatID], [ProdCat], [Date]) VALUES
        (N'Μήλα Φούτζι', 50, 1.99, 1, N'Φρούτα & Λαχανικά', GETDATE()),
        (N'Μπανάνες', 80, 1.49, 1, N'Φρούτα & Λαχανικά', GETDATE()),
        (N'Ντομάτες', 40, 2.20, 1, N'Φρούτα & Λαχανικά', GETDATE()),
        (N'Γάλα ΔΕΛΤΑ 1L', 100, 1.35, 2, N'Γαλακτοκομικά', GETDATE()),
        (N'Φέτα ΠΟΠ 400g', 30, 4.50, 2, N'Γαλακτοκομικά', GETDATE()),
        (N'Γιαούρτι ΔΕΠΑ 200g', 60, 0.89, 2, N'Γαλακτοκομικά', GETDATE()),
        (N'Ψωμί τοστ', 25, 1.15, 3, N'Αρτοποιία', GETDATE()),
        (N'Μπαγκέτα', 20, 0.99, 3, N'Αρτοποιία', GETDATE()),
        (N'Κοτόπουλο 1kg', 15, 5.99, 4, N'Κρεοπωλείο', GETDATE()),
        (N'Νερό 1.5L', 200, 0.49, 5, N'Ποτά', GETDATE()),
        (N'Coca-Cola 2L', 50, 2.29, 5, N'Ποτά', GETDATE()),
        (N'Χυμός Πορτοκάλι 1L', 40, 1.99, 5, N'Ποτά', GETDATE())
END
GO

PRINT 'Database initialized successfully!'
GO
