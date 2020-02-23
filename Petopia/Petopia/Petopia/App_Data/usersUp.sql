﻿CREATE TABLE [dbo].[PetopiaUsers] (
	
	[UserID] NVARCHAR(120) NOT NULL, 
	[UserName] NVARCHAR(120) NOT NULL,
	[Password] NVARCHAR(50) NOT NULL,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[MainPhone] NVARCHAR(50) NOT NULL,
	[AltPhone] NVARCHAR(50),
	[ResAddress01] NVARCHAR(50) NOT NULL,
	[ResAddress02] NVARCHAR(50),
	[ResCity] NVARCHAR(50) NOT NULL,
	[ResState] NVARCHAR(50) NOT NULL,
	[ResZipcode] NVARCHAR(24) NOT NULL,
	[ProfilePhoto] VARBINARY(MAX)

);