USE [proiect]
GO
INSERT [dbo].[Developers] ([developer_id], [name], [contact], [country]) VALUES (1, N'Valve', N'https://www.valvesoftware.com/en/contact', N'USA')
INSERT [dbo].[Developers] ([developer_id], [name], [contact], [country]) VALUES (2, N'Fatshark', N'https://www.fatshark.se/contact', N'Sweden')
INSERT [dbo].[Developers] ([developer_id], [name], [contact], [country]) VALUES (3, N' Santa Monica Studio', N'https://sms.playstation.com/', N'USA')
INSERT [dbo].[Developers] ([developer_id], [name], [contact], [country]) VALUES (4, N'Edmund McMillen', N'https://twitter.com/edmundmcmillen/', N'USA')
GO
INSERT [dbo].[Games] ([game_id], [game_name], [release_date], [developer_id], [publisher_id], [price], [rating], [store_page]) VALUES (1, N'Counter-Strike: Global Offensive', CAST(N'2012-08-21' AS Date), 1, 1, 0.0000, N'89%', N'https://store.steampowered.com/app/730/CounterStrike_Global_Offensive/')
INSERT [dbo].[Games] ([game_id], [game_name], [release_date], [developer_id], [publisher_id], [price], [rating], [store_page]) VALUES (2, N'Half-Life', CAST(N'1998-11-08' AS Date), 1, 1, 8.1900, N'96%', N'https://store.steampowered.com/app/70/HalfLife/')
INSERT [dbo].[Games] ([game_id], [game_name], [release_date], [developer_id], [publisher_id], [price], [rating], [store_page]) VALUES (3, N'Warhammer: Vermintide 2', CAST(N'2018-03-08' AS Date), 2, 2, 27.9900, N'90%', N'https://store.steampowered.com/app/552500/Warhammer_Vermintide_2/')
INSERT [dbo].[Games] ([game_id], [game_name], [release_date], [developer_id], [publisher_id], [price], [rating], [store_page]) VALUES (4, N'God of War', CAST(N'2022-01-14' AS Date), 3, 3, 49.9900, N'96%', N'https://store.steampowered.com/app/1593500/God_of_War/')
INSERT [dbo].[Games] ([game_id], [game_name], [release_date], [developer_id], [publisher_id], [price], [rating], [store_page]) VALUES (5, N'The Binding of Isaac', CAST(N'2011-09-28' AS Date), 4, 4, 4.9900, N'95%', N'https://store.steampowered.com/app/113200/The_Binding_of_Isaac/')
GO
INSERT [dbo].[Publishers] ([publisher_id], [name], [contact], [country]) VALUES (1, N'Valve', N'https://www.valvesoftware.com/en/contact', N'USA')
INSERT [dbo].[Publishers] ([publisher_id], [name], [contact], [country]) VALUES (2, N'Fatshark', N'https://www.fatshark.se/contact', N'Sweden')
INSERT [dbo].[Publishers] ([publisher_id], [name], [contact], [country]) VALUES (3, N' PlayStation PC LLC', N'https://www.playstation.com/ro-ro/', N'Japan')
INSERT [dbo].[Publishers] ([publisher_id], [name], [contact], [country]) VALUES (4, N'Edmund McMillen', N'https://twitter.com/edmundmcmillen/', N'USA')
GO
