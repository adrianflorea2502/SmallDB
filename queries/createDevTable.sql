USE [proiect]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Developers](
	[developer_id] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[contact] [varchar](50) NULL,
	[country] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Developers] PRIMARY KEY CLUSTERED 
(
	[developer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

