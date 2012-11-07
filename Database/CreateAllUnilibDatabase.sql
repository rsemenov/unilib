USE [master]
GO
/****** Object:  Database [UniLib]    Script Date: 11/05/2012 23:56:02 ******/
CREATE DATABASE [UniLib] ON  PRIMARY 
( NAME = N'UniLib', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS2008\MSSQL\DATA\UniLib.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'UniLib_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS2008\MSSQL\DATA\UniLib_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [UniLib] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UniLib].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UniLib] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [UniLib] SET ANSI_NULLS OFF
GO
ALTER DATABASE [UniLib] SET ANSI_PADDING OFF
GO
ALTER DATABASE [UniLib] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [UniLib] SET ARITHABORT OFF
GO
ALTER DATABASE [UniLib] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [UniLib] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [UniLib] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [UniLib] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [UniLib] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [UniLib] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [UniLib] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [UniLib] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [UniLib] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [UniLib] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [UniLib] SET  DISABLE_BROKER
GO
ALTER DATABASE [UniLib] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [UniLib] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [UniLib] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [UniLib] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [UniLib] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [UniLib] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [UniLib] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [UniLib] SET  READ_WRITE
GO
ALTER DATABASE [UniLib] SET RECOVERY SIMPLE
GO
ALTER DATABASE [UniLib] SET  MULTI_USER
GO
ALTER DATABASE [UniLib] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [UniLib] SET DB_CHAINING OFF
GO
USE [UniLib]
GO
/****** Object:  Table [dbo].[ThemeClassification]    Script Date: 11/05/2012 23:56:03 ******/
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
 CONSTRAINT [PK_ThemeClasification] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Records]    Script Date: 11/05/2012 23:56:03 ******/
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
 CONSTRAINT [PK_Record] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 11/05/2012 23:56:03 ******/
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
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthorRecord]    Script Date: 11/05/2012 23:56:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorRecord](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AuthorId] [uniqueidentifier] NOT NULL,
	[RecordId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_AuthorRecord] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecordContent]    Script Date: 11/05/2012 23:56:03 ******/
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
/****** Object:  Table [dbo].[RecordClassification]    Script Date: 11/05/2012 23:56:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecordClassification](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecordId] [uniqueidentifier] NOT NULL,
	[ISBN] [nvarchar](20) NULL,
	[ISSN] [nvarchar](10) NULL,
	[NationalNumber] [nvarchar](100) NULL,
	[OtherIdentifier] [nvarchar](100) NULL,
	[DocumentNumber] [nvarchar](100) NULL,
	[ThemeClassificationId] [int] NULL,
 CONSTRAINT [PK_RecordClassification] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_ThemeClasification_IsLeaf]    Script Date: 11/05/2012 23:56:03 ******/
ALTER TABLE [dbo].[ThemeClassification] ADD  CONSTRAINT [DF_ThemeClasification_IsLeaf]  DEFAULT ((0)) FOR [IsLeaf]
GO
/****** Object:  Default [DF_Record_Id]    Script Date: 11/05/2012 23:56:03 ******/
ALTER TABLE [dbo].[Records] ADD  CONSTRAINT [DF_Record_Id]  DEFAULT (newid()) FOR [Id]
GO
/****** Object:  ForeignKey [FK_AuthorRecord_Authors]    Script Date: 11/05/2012 23:56:03 ******/
ALTER TABLE [dbo].[AuthorRecord]  WITH CHECK ADD  CONSTRAINT [FK_AuthorRecord_Authors] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([Id])
GO
ALTER TABLE [dbo].[AuthorRecord] CHECK CONSTRAINT [FK_AuthorRecord_Authors]
GO
/****** Object:  ForeignKey [FK_AuthorRecord_Records]    Script Date: 11/05/2012 23:56:03 ******/
ALTER TABLE [dbo].[AuthorRecord]  WITH CHECK ADD  CONSTRAINT [FK_AuthorRecord_Records] FOREIGN KEY([RecordId])
REFERENCES [dbo].[Records] ([Id])
GO
ALTER TABLE [dbo].[AuthorRecord] CHECK CONSTRAINT [FK_AuthorRecord_Records]
GO
/****** Object:  ForeignKey [FK_RecordContent_Records]    Script Date: 11/05/2012 23:56:03 ******/
ALTER TABLE [dbo].[RecordContent]  WITH CHECK ADD  CONSTRAINT [FK_RecordContent_Records] FOREIGN KEY([RecordId])
REFERENCES [dbo].[Records] ([Id])
GO
ALTER TABLE [dbo].[RecordContent] CHECK CONSTRAINT [FK_RecordContent_Records]
GO
/****** Object:  ForeignKey [FK_RecordClassification_Records]    Script Date: 11/05/2012 23:56:03 ******/
ALTER TABLE [dbo].[RecordClassification]  WITH CHECK ADD  CONSTRAINT [FK_RecordClassification_Records] FOREIGN KEY([RecordId])
REFERENCES [dbo].[Records] ([Id])
GO
ALTER TABLE [dbo].[RecordClassification] CHECK CONSTRAINT [FK_RecordClassification_Records]
GO
/****** Object:  ForeignKey [FK_RecordClassification_ThemeClassification]    Script Date: 11/05/2012 23:56:03 ******/
ALTER TABLE [dbo].[RecordClassification]  WITH CHECK ADD  CONSTRAINT [FK_RecordClassification_ThemeClassification] FOREIGN KEY([ThemeClassificationId])
REFERENCES [dbo].[ThemeClassification] ([Id])
GO
ALTER TABLE [dbo].[RecordClassification] CHECK CONSTRAINT [FK_RecordClassification_ThemeClassification]
GO
