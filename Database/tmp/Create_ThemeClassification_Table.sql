USE [UniLib]
GO

/****** Object:  Table [dbo].[ThemeClasification]    Script Date: 11/05/2012 23:40:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ThemeClassification](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ParentId] [int] NOT NULL,
	[Title] [nvarchar](1000) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[IsLeaf] [bit] NOT NULL,
 CONSTRAINT [PK_ThemeClassification] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ThemeClassification] ADD  CONSTRAINT [DF_ThemeClassification_IsLeaf]  DEFAULT ((0)) FOR [IsLeaf]
GO


