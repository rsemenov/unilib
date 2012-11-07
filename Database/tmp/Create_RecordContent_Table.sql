USE [UniLib]
GO

/****** Object:  Table [dbo].[RecordContent]    Script Date: 11/05/2012 23:42:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[RecordContent](
	[Id] [int] Identity(1,1) NOT NULL,
	[RecordId] [uniqueidentifier] NOT NULL,
	[DataType] [int] NOT NULL,
	[FileContent] [varbinary](max) NOT NULL,
	[DescriptionContent] [varbinary](max) NULL,
 CONSTRAINT [PK_RecordContent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


