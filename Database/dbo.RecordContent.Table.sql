USE [UniLib]
GO
/****** Object:  Table [dbo].[RecordContent]    Script Date: 11/05/2012 23:56:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RecordContent](
	[Id] [int] IDENTITY(1,1) NOT NULL,
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
ALTER TABLE [dbo].[RecordContent]  WITH CHECK ADD  CONSTRAINT [FK_RecordContent_Records] FOREIGN KEY([RecordId])
REFERENCES [dbo].[Records] ([Id])
GO
ALTER TABLE [dbo].[RecordContent] CHECK CONSTRAINT [FK_RecordContent_Records]
GO
