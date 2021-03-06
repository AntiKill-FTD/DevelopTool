USE [master]
GO

/****** Object:  Database [DeveloperTool]    Script Date: 2022/1/11 19:21:49 ******/
CREATE DATABASE DeveloperTool
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DeveloperTool', FILENAME = N'E:\Datas\sqlserver\DeveloperTool\DeveloperTool.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DeveloperTool_Log', FILENAME = N'E:\Datas\sqlserver\DeveloperTool\DeveloperTool.ldf' , SIZE = 8192KB , MAXSIZE = 10485760KB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE DeveloperTool SET COMPATIBILITY_LEVEL = 130
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DeveloperTool].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE DeveloperTool SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE DeveloperTool SET ANSI_NULLS OFF 
GO

ALTER DATABASE DeveloperTool SET ANSI_PADDING OFF 
GO

ALTER DATABASE DeveloperTool SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE DeveloperTool SET ARITHABORT OFF 
GO

ALTER DATABASE DeveloperTool SET AUTO_CLOSE OFF 
GO

ALTER DATABASE DeveloperTool SET AUTO_SHRINK OFF 
GO

ALTER DATABASE DeveloperTool SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE DeveloperTool SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE DeveloperTool SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE DeveloperTool SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE DeveloperTool SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE DeveloperTool SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE DeveloperTool SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE DeveloperTool SET  ENABLE_BROKER 
GO

ALTER DATABASE DeveloperTool SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE DeveloperTool SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE DeveloperTool SET TRUSTWORTHY OFF 
GO

ALTER DATABASE DeveloperTool SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE DeveloperTool SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE DeveloperTool SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE DeveloperTool SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE DeveloperTool SET RECOVERY FULL 
GO

ALTER DATABASE DeveloperTool SET  MULTI_USER 
GO

ALTER DATABASE DeveloperTool SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE DeveloperTool SET DB_CHAINING OFF 
GO

ALTER DATABASE DeveloperTool SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE DeveloperTool SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE DeveloperTool SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE DeveloperTool SET QUERY_STORE = OFF
GO

USE DeveloperTool
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE DeveloperTool SET  READ_WRITE 
GO

----????????
USE [DeveloperTool]
GO

/****** Object:  Table [dbo].[P_Menu]    Script Date: 2022/1/11 19:24:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[P_Menu](
	[Id] [INT] IDENTITY(1,1) NOT NULL,
	[MenuCode] [VARCHAR](100) NULL,
	[MenuName] [VARCHAR](100) NULL,
	[ParentCode] [VARCHAR](100) NULL,
	[Assembly] [VARCHAR](200) NULL,
	[NameSpace] [VARCHAR](200) NULL,
	[EntityName] [VARCHAR](200) NULL,
	[Level] [INT] NULL,
	[IfEnd] [INT] NULL
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Menu', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Menu', @level2type=N'COLUMN',@level2name=N'MenuCode'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Menu', @level2type=N'COLUMN',@level2name=N'MenuName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Menu', @level2type=N'COLUMN',@level2name=N'ParentCode'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Menu', @level2type=N'COLUMN',@level2name=N'Assembly'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Menu', @level2type=N'COLUMN',@level2name=N'NameSpace'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Menu', @level2type=N'COLUMN',@level2name=N'EntityName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Menu', @level2type=N'COLUMN',@level2name=N'Level'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Menu', @level2type=N'COLUMN',@level2name=N'IfEnd'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Menu'
GO

--????????
USE [DeveloperTool]
GO

INSERT INTO P_Menu ( MenuCode, MenuName, ParentCode, Assembly, NameSpace, EntityName, Level, IfEnd) VALUES ( N'00', N'????????', N'', N'', N'', N'', 1, 0);
INSERT INTO P_Menu ( MenuCode, MenuName, ParentCode, Assembly, NameSpace, EntityName, Level, IfEnd) VALUES ( N'00.01', N'????????', N'00', N'Tool.Main', N'Tool.Main.Forms.SysConfig', N'SysConfig', 2, 1);
INSERT INTO P_Menu ( MenuCode, MenuName, ParentCode, Assembly, NameSpace, EntityName, Level, IfEnd) VALUES ( N'01', N'????????', N'', N'', N'', N'', 1, 0);
INSERT INTO P_Menu ( MenuCode, MenuName, ParentCode, Assembly, NameSpace, EntityName, Level, IfEnd) VALUES ( N'01.01', N'????????', N'01', N'Tool.Main', N'Tool.Main.Forms.DevForms', N'SqlHelper', 2, 1);
INSERT INTO P_Menu ( MenuCode, MenuName, ParentCode, Assembly, NameSpace, EntityName, Level, IfEnd) VALUES ( N'01.02', N'????????', N'01', N'Tool.Main', N'Tool.Main.Forms.DevForms', N'EntityHelper', 2, 1);
INSERT INTO P_Menu ( MenuCode, MenuName, ParentCode, Assembly, NameSpace, EntityName, Level, IfEnd) VALUES ( N'02', N'????????', N'', N'', N'', N'', 1, 0);
INSERT INTO P_Menu ( MenuCode, MenuName, ParentCode, Assembly, NameSpace, EntityName, Level, IfEnd) VALUES ( N'02.01', N'??????????', N'02', N'Tool.Main', N'Tool.Main.Forms.BusForms', N'CryptData', 2, 1);
INSERT INTO P_Menu ( MenuCode, MenuName, ParentCode, Assembly, NameSpace, EntityName, Level, IfEnd) VALUES ( N'02.02', N'PDU????????', N'02', N'Tool.Main', N'Tool.Main.Forms.BusForms', N'PduImport', 2, 1);
INSERT INTO P_Menu ( MenuCode, MenuName, ParentCode, Assembly, NameSpace, EntityName, Level, IfEnd) VALUES ( N'03', N'????????', N'', N'', N'', N'', 1, 0);
INSERT INTO P_Menu ( MenuCode, MenuName, ParentCode, Assembly, NameSpace, EntityName, Level, IfEnd) VALUES ( N'03.01', N'??????????', N'03', N'Tool.Main', N'Tool.Main.Forms.ComForms', N'StringHelper', 2, 1);

BEGIN TRANSACTION
GO
CREATE TABLE dbo.P_Config
        (
        Id int NOT NULL IDENTITY (1, 1) ,
        ConfigTypeCode1 nvarchar(200) NOT NULL  ,
        ConfigTypeName1 nvarchar(200) NOT NULL  ,
        ConfigTypeCode2 nvarchar(200)   ,
        ConfigTypeName2 nvarchar(200)   ,
        ConfigTypeCode3 nvarchar(200)   ,
        ConfigTypeName3 nvarchar(200)   ,
        ConfigTypeCode4 nvarchar(200)   ,
        ConfigTypeName4 varchar(200)   ,
        ConfigTypeCode5 nvarchar(500)   ,
        ConfigTypeName5 nvarchar(100)   ,
        ConfigValue nvarchar(MAX) NOT NULL  ,
        Remark nvarchar(MAX)   
        )
GO
ALTER TABLE dbo.P_Config ADD CONSTRAINT
        PK_P_Config PRIMARY KEY CLUSTERED
         (
Id
         ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
COMMIT

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Config'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Config', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????1??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Config', @level2type=N'COLUMN',@level2name=N'ConfigTypeCode1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????1??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Config', @level2type=N'COLUMN',@level2name=N'ConfigTypeName1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????2??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Config', @level2type=N'COLUMN',@level2name=N'ConfigTypeCode2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????2??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Config', @level2type=N'COLUMN',@level2name=N'ConfigTypeName2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????3??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Config', @level2type=N'COLUMN',@level2name=N'ConfigTypeCode3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????3??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Config', @level2type=N'COLUMN',@level2name=N'ConfigTypeName3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????4??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Config', @level2type=N'COLUMN',@level2name=N'ConfigTypeCode4'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????4??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Config', @level2type=N'COLUMN',@level2name=N'ConfigTypeName4'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????5??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Config', @level2type=N'COLUMN',@level2name=N'ConfigTypeCode5'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????5??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Config', @level2type=N'COLUMN',@level2name=N'ConfigTypeName5'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Config', @level2type=N'COLUMN',@level2name=N'ConfigValue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'P_Config', @level2type=N'COLUMN',@level2name=N'Remark'
GO