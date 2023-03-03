USE [proiect]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Games](
	[game_id] [int] NOT NULL,
	[game_name] [varchar](50) NOT NULL,
	[release_date] [date] NOT NULL,
	[developer_id] [int] NOT NULL,
	[publisher_id] [int] NOT NULL,
	[price] [int] NOT NULL,
	[rating] [int] NULL,
 CONSTRAINT [PK_Games] PRIMARY KEY CLUSTERED 
(
	[game_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

