USE [proiect]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GameDevelopers](
	[game_id] [int] NOT NULL,
	[developer_id] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[GameDevelopers]  WITH CHECK ADD  CONSTRAINT [FK_GameDevelopers_Developers] FOREIGN KEY([developer_id])
REFERENCES [dbo].[Developers] ([developer_id])
GO

ALTER TABLE [dbo].[GameDevelopers] CHECK CONSTRAINT [FK_GameDevelopers_Developers]
GO

ALTER TABLE [dbo].[GameDevelopers]  WITH CHECK ADD  CONSTRAINT [FK_GameDevelopers_Games] FOREIGN KEY([game_id])
REFERENCES [dbo].[Games] ([game_id])
GO

ALTER TABLE [dbo].[GameDevelopers] CHECK CONSTRAINT [FK_GameDevelopers_Games]
GO

