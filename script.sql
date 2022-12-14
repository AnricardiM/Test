/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [test]    Script Date: 28/07/2022 02:32:28 ******/
CREATE DATABASE [test]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'test', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\test.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'test_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\test_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [test] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [test].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [test] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [test] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [test] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [test] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [test] SET ARITHABORT OFF 
GO
ALTER DATABASE [test] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [test] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [test] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [test] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [test] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [test] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [test] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [test] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [test] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [test] SET  DISABLE_BROKER 
GO
ALTER DATABASE [test] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [test] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [test] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [test] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [test] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [test] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [test] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [test] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [test] SET  MULTI_USER 
GO
ALTER DATABASE [test] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [test] SET DB_CHAINING OFF 
GO
ALTER DATABASE [test] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [test] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [test] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [test] SET QUERY_STORE = OFF
GO
USE [test]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [test]
GO
/****** Object:  Table [dbo].[testAuto]    Script Date: 28/07/2022 02:32:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[testAuto](
	[idAuto] [int] IDENTITY(1,1) NOT NULL,
	[descripcionAuto] [varchar](50) NULL,
	[costoAuto] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[testCentro]    Script Date: 28/07/2022 02:32:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[testCentro](
	[idCentro] [int] IDENTITY(1,1) NOT NULL,
	[descripcionCentro] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[testVenta]    Script Date: 28/07/2022 02:32:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[testVenta](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[idAuto] [int] NULL,
	[idCentro] [int] NULL,
	[descripcionVenta] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[testAuto] ON 

INSERT [dbo].[testAuto] ([idAuto], [descripcionAuto], [costoAuto]) VALUES (1, N'SEDAN', CAST(8000.00 AS Decimal(18, 2)))
INSERT [dbo].[testAuto] ([idAuto], [descripcionAuto], [costoAuto]) VALUES (2, N'SUV', CAST(9500.00 AS Decimal(18, 2)))
INSERT [dbo].[testAuto] ([idAuto], [descripcionAuto], [costoAuto]) VALUES (3, N'OFFROAD', CAST(12500.00 AS Decimal(18, 2)))
INSERT [dbo].[testAuto] ([idAuto], [descripcionAuto], [costoAuto]) VALUES (4, N'SPORT', CAST(18200.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[testAuto] OFF
SET IDENTITY_INSERT [dbo].[testCentro] ON 

INSERT [dbo].[testCentro] ([idCentro], [descripcionCentro]) VALUES (1, N'CENTRO N1')
INSERT [dbo].[testCentro] ([idCentro], [descripcionCentro]) VALUES (2, N'CENTRO N2')
INSERT [dbo].[testCentro] ([idCentro], [descripcionCentro]) VALUES (3, N'CENTRO N3')
INSERT [dbo].[testCentro] ([idCentro], [descripcionCentro]) VALUES (4, N'CENTRO N4')
SET IDENTITY_INSERT [dbo].[testCentro] OFF
SET IDENTITY_INSERT [dbo].[testVenta] ON 

INSERT [dbo].[testVenta] ([idVenta], [idAuto], [idCentro], [descripcionVenta]) VALUES (1, 1, 1, N'sample string 2')
INSERT [dbo].[testVenta] ([idVenta], [idAuto], [idCentro], [descripcionVenta]) VALUES (2, 1, 1, N'sample 50')
INSERT [dbo].[testVenta] ([idVenta], [idAuto], [idCentro], [descripcionVenta]) VALUES (3, 2, 3, N'oooooo')
SET IDENTITY_INSERT [dbo].[testVenta] OFF
USE [master]
GO
ALTER DATABASE [test] SET  READ_WRITE 
GO
