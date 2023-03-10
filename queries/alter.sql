USE [proiect]
GO
/****** Object:  StoredProcedure [dbo].[GetGamesByPublisher]    Script Date: 24-Jan-22 17:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[GetGamesByPublisher]
	-- Add the parameters for the stored procedure here
	@Publisher int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [game_id]
      ,[game_name]
      ,[release_date]
      ,[developer_id]
      ,[publisher_id]
      ,[price]
      ,[rating]
      ,[store_page]
  FROM [dbo].[Games]
  WHERE [publisher_id] = @Publisher
END
