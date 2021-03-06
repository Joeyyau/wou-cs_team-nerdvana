﻿
CREATE TABLE [dbo].[PetopiaUsers] (
	
	[UserID] INT IDENTITY (1,1) NOT NULL, 
	[UserName] NVARCHAR(120),
	[Password] NVARCHAR(50),
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[ASPNetIdentityID] NVARCHAR (128),
	[IsOwner] BIT NOT NULL,
	[IsProvider] BIT NOT NULL,
	[MainPhone] NVARCHAR(50) NOT NULL,
	[AltPhone] NVARCHAR(50),
	[ResAddress01] NVARCHAR(50) NOT NULL,
	[ResAddress02] NVARCHAR(50),
	[ResCity] NVARCHAR(50) NOT NULL,
	[ResState] NVARCHAR(50) NOT NULL,
	[ResZipcode] NVARCHAR(24) NOT NULL,
	[ProfilePhoto] VARBINARY(MAX),
	CONSTRAINT[PK_dbo.PetopiaUsers] PRIMARY KEY CLUSTERED([UserID] ASC)

);

CREATE TABLE [dbo].[PetOwner] (
	[PetOwnerID] INT IDENTITY (1,1) NOT NULL,
	[AverageRating] NVARCHAR(120),
	[NeedsDetails] NVARCHAR(MAX) NOT NULL,
	[AccessInstructions] NVARCHAR(MAX) NOT NULL,
	[UserID] INT,
	CONSTRAINT[PK_dbo.PetOwner] PRIMARY KEY CLUSTERED([PetOwnerID] ASC),
	CONSTRAINT[FK_dbo.PetopiaUsersOwner] FOREIGN KEY([UserID]) REFERENCES [dbo].[PetopiaUsers]([UserID])
);

CREATE TABLE [dbo].[Pet] (
	[PetID] INT IDENTITY (1,1) NOT NULL,
	[PetName] NVARCHAR(24) NOT NULL, 
	[Species] NVARCHAR(24) NOT NULL,
	[Breed] NVARCHAR(24),
	[Gender] NVARCHAR(8) NOT NULL,
	[Altered] NVARCHAR(8),
	[Birthdate] DATE,
	[Weight] DATE,
	[HealthConcerns] NVARCHAR(MAX),
	[BehaviorConcerns] NVARCHAR(MAX),
	[PetAccess] NVARCHAR(MAX),
	[EmergencyContactName] NVARCHAR(45),
	[EmergencyContactPhone] NVARCHAR(12),
	[NeedsDetails] NVARCHAR(MAX),
	[AccessInstructions] NVARCHAR(MAX),
	[PetOwnerID] INT,
	CONSTRAINT[PK_dbo.Pet] PRIMARY KEY CLUSTERED([PetID] ASC),
	CONSTRAINT[FK_dbo.PetOwner] FOREIGN KEY([PetOwnerID]) REFERENCES [dbo].[PetOwner]([PetOwnerID])
);

CREATE TABLE [dbo].[CareProvider] (
	[CareProviderID] INT IDENTITY (1,1) NOT NULL,
	[AverageRating] NVARCHAR(120),
	[ExperienceDetails] NVARCHAR(MAX) NOT NULL,
	[UserID] INT,
	CONSTRAINT[PK_dbo.CareProvider] PRIMARY KEY CLUSTERED([CareProviderID] ASC),
	CONSTRAINT[FK_dbo.PetopiaUsersProvider] FOREIGN KEY([UserID]) REFERENCES [dbo].[PetopiaUsers]
);













/*
CREATE TABLE [dbo].[Owner] (
	[OwnerID] NVARCHAR(120) NOT NULL,
	[Username] NVARCHAR(120),
	[FirstName] NVARCHAR(120) NOT NULL,
	[LastName] NVARCHAR(120) NOT NULL,
	CONSTRAINT[PK_dbo.Owner] PRIMARY KEY CLUSTERED([OwnerID] ASC)

);

CREATE TABLE [dbo].[Provider](
	[ProviderID] NVARCHAR(120) NOT NULL,
	[Username] NVARCHAR(120),
	[FirstName] NVARCHAR(120) NOT NULL,
	[LastName] NVARCHAR(120) NOT NULL,
	CONSTRAINT[PK_dbo.Provider] PRIMARY KEY CLUSTERED([ProviderID] ASC)

);
*/