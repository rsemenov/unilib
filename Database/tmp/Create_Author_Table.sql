USE [UniLib]
GO

/****** Object:  Table [dbo].[Author]    Script Date: 11/05/2012 23:37:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Authors](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[FullName] [nvarchar](max) NOT NULL,
	[FirstPart] [nvarchar](max) NOT NULL,
	[SufixPart] [nvarchar](max) NOT NULL,
	[OtherNames] [nvarchar](max) NULL,
	[NameAddition] [nvarchar](max) NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


