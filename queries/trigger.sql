-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Florea Adrian>
-- Description:	<ProiectBD2>
-- =============================================
CREATE TRIGGER GamesTrigger
   ON  [dbo].[Games]
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here
	INSERT INTO [dbo].[GameDevelopers] (game_id)
	SELECT game_id
		   FROM [dbo].[Games]
		   WHERE game_id IS NOT NULL

	INSERT INTO [dbo].[GameDevelopers] (developer_id)
	SELECT developer_id
		   FROM [dbo].[Developers]
		   WHERE developer_id IS NOT NULL

	INSERT INTO [dbo].[GamePublishers] (game_id)
	SELECT game_id
		   FROM [dbo].[Games]
		   WHERE game_id IS NOT NULL

	INSERT INTO [dbo].[GamePublishers] (publisher_id)
	SELECT publisher_id
		   FROM [dbo].[Publishers]
		   WHERE publisher_id IS NOT NULL
END
GO
