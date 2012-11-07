USE [UniLib]
GO

/****** Object:  Table [dbo].[Record]    Script Date: 11/05/2012 23:38:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Records](
	[Id] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[SortTitle] [nvarchar](max) NOT NULL,
	[FullTitle] [nvarchar](max) NOT NULL,
	[OtherTitle] [nvarchar](max) NULL,
	[TitleDescription] [nvarchar](max) NULL,
	[Responsibility] [nvarchar](max) NOT NULL,
	[ChapterName] [nvarchar](max) NULL,
	[Publication] [nvarchar](max) NOT NULL,
	[PublicationInfo] [nvarchar](max) NULL,
	[PublicationYear] [int] NOT NULL,
 CONSTRAINT [PK_Records] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Record] ADD  CONSTRAINT [DF_Record_Id]  DEFAULT (newid()) FOR [Id]
GO


