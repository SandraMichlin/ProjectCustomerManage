USE [Customers]
GO

/****** Object: Table [dbo].[CustomersTBL] Script Date: 28/08/2021 16:39:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CustomersTBL] (
    [IDCusomer]     INT           NOT NULL,
    [HebrewName]    NVARCHAR (50) NULL,
    [EnglishName]   NVARCHAR (50) NULL,
    [BirthDate]     DATE          NULL,
    [IDCity]        INT           NOT NULL,
    [Bank]          NVARCHAR (50) NULL,
    [Branch]        NVARCHAR (50) NULL,
    [AccountNumber] INT           NULL
);
