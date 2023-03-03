USE [proiect]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GamePublishers](
	[game_id] [int] NOT NULL,
	[publisher_id] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[GamePublishers]  WITH CHECK ADD  CONSTRAINT [FK_GamePublishers_Games] FOREIGN KEY([game_id])
REFERENCES [dbo].[Games] ([game_id])
GO

ALTER TABLE [dbo].[GamePublishers] CHECK CONSTRAINT [FK_GamePublishers_Games]
GO

ALTER TABLE [dbo].[GamePublishers]  WITH CHECK ADD  CONSTRAINT [FK_GamePublishers_Publishers] FOREIGN KEY([publisher_id])
REFERENCES [dbo].[Publishers] ([publisher_id])
GO

ALTER TABLE [dbo].[GamePublishers] CHECK CONSTRAINT [FK_GamePublishers_Publishers]
GO

