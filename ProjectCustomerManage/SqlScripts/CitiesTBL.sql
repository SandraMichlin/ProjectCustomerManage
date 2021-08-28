USE [Customers]
GO

/****** Object: Table [dbo].[CitiesTBL] Script Date: 28/08/2021 16:35:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CitiesTBL] (
    [IDCity]   INT           NOT NULL,
    [NameCity] NVARCHAR (50) NOT NULL
);
