USE [Unilib]
GO

/****** Object:  Table [dbo].[AuthorInfo_b7]    Script Date: 01/04/2013 09:03:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AuthorInfo_b7](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecordId] [uniqueidentifier] NOT NULL,
	[NameFirstPart] [nvarchar](50) NOT NULL,
	[NameNextPart_f700_b] [nvarchar](max) NOT NULL,
	[NameExtensions_f700_c] [nvarchar](max) NULL,
	[RomeDigits_f700_d] [nvarchar](max) NULL,
	[Dates_f700_d] [nvarchar](max) NULL,
	[FullFirstMidleName_f700_g] [nvarchar](max) NULL,
	[ISNI_f700_o] [nvarchar](max) NULL,
	[NameAddressOrganization_f700_p] [nvarchar](max) NULL,
	[NormativeNumber_f700_3] [nvarchar](max) NULL,
	[RelationCode_f700_4] [nvarchar](max) NULL,
	[AdditionalRelationField_f700_9] [nvarchar](max) NULL,
	[AuthorType] [int] NULL,
 CONSTRAINT [PK_AuthorInfo_b7] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[CatalogizationRecord_b6]    Script Date: 01/04/2013 09:03:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatalogizationRecord_b6](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecordId] [uniqueidentifier] NOT NULL,
	[UDCIndex_f675_a] [nvarchar](50) NULL,
	[UDCPublication_f675_v] [nvarchar](50) NULL,
	[UDCPublicationLanguage_f675_z] [nvarchar](50) NULL,
	[NormativeNumber_f675_3] [nvarchar](50) NULL,
 CONSTRAINT [PK_CatalogizationRecord_b6] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


/****** Object:  Table [dbo].[RecordDescribeInfo_b2_f200]    Script Date: 01/04/2013 09:03:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RecordDescribeInfo_b2_f200](
	[Id] [int] NOT NULL,
	[RecordId] [uniqueidentifier] NOT NULL,
	[MainTitle_a] [nvarchar](max) NOT NULL,
	[GeneralSign_b] [nvarchar](max) NULL,
	[ParallelTitle_d] [nvarchar](max) NULL,
	[TitleInfo_e] [nvarchar](max) NULL,
	[FirstResponseInfo_f] [nvarchar](max) NULL,
	[NextResponseInfo_g] [nvarchar](max) NULL,
	[PartNumber_h] [nvarchar](max) NULL,
	[PartTitle_i] [nvarchar](max) NULL,
	[BoundDates_j] [nvarchar](50) NULL,
	[MainDates_k] [nvarchar](50) NULL,
	[TitlePageInfo_r] [nvarchar](max) NULL,
	[TomeMarking_v] [nvarchar](max) NULL,
	[ParallelTitleLanguage_z] [nvarchar](50) NULL,
 CONSTRAINT [PK_RecordDescribeInfo_b2_f200] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


/****** Object:  Table [dbo].[RecordIdentification_b0]    Script Date: 01/04/2013 09:04:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RecordIdentification_b0](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecordId] [uniqueidentifier] NOT NULL,
	[VersionIdentifier_F005] [nvarchar](50) NULL,
	[ISMN_F013] [nvarchar](50) NULL,
	[ArticleIdentifier_F014] [nvarchar](50) NULL,
	[ISRN_F015] [nvarchar](50) NULL,
	[ISRC_F016] [nvarchar](50) NULL,
	[StateNumber_F021] [nvarchar](50) NULL,
	[OtherSystemId_F033] [nvarchar](50) NULL,
	[EAN_F073] [nvarchar](50) NULL,
 CONSTRAINT [PK_RecordIdentification_B0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


/****** Object:  Table [dbo].[RecordNotes_b3]    Script Date: 01/04/2013 09:04:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RecordNotes_b3](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecordId] [uniqueidentifier] NOT NULL,
	[GeneralNotes_f300] [nvarchar](max) NULL,
	[ElectronicRecordsNotes_f304] [nvarchar](max) NULL,
	[BibliographyNotes_f320_a] [nvarchar](max) NULL,
	[URI_f320_u] [nvarchar](500) NULL,
 CONSTRAINT [PK_RecordNotes_b3] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[RecordPhysicalInfo_b2_f215]    Script Date: 01/04/2013 09:04:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RecordPhysicalInfo_b2_f215](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecordId] [uniqueidentifier] NOT NULL,
	[MaterialValume_a] [nvarchar](max) NULL,
	[OtherData_c] [nvarchar](max) NULL,
	[Sizes_d] [nvarchar](max) NULL,
	[AdditionalInfo_e] [nvarchar](max) NULL,
 CONSTRAINT [PK_RecordPhysicalInfo_b2_f215] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


/****** Object:  Table [dbo].[RecordPublicationInfo_b2_f205]    Script Date: 01/04/2013 09:04:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RecordPublicationInfo_b2_f205](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecordId] [uniqueidentifier] NOT NULL,
	[PublicationInfo_a] [nvarchar](max) NULL,
	[AdditionalPublicationInfo_b] [nvarchar](max) NULL,
	[ParallelPublicationInfo_d] [nvarchar](max) NULL,
	[PublicationResponseInfo_f] [nvarchar](max) NULL,
	[NextPublicationInfo_g] [nvarchar](max) NULL,
 CONSTRAINT [PK_RecordPublicationInfo_b2_f205] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[RecordTitles_b5]    Script Date: 01/04/2013 09:04:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RecordTitles_b5](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecordId] [uniqueidentifier] NOT NULL,
	[TitleVariant_f517_a] [nvarchar](max) NULL,
	[TitleNotes_f517_e] [nvarchar](max) NULL,
	[TitleLanguage_f517_z] [nvarchar](max) NULL,
 CONSTRAINT [PK_RecordTitles_b5] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


