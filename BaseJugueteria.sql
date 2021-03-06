USE [master]
GO
/****** Object:  Database [Jugueteria]    Script Date: 21/02/2022 02:12:29 a. m. ******/
CREATE DATABASE [Jugueteria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Jugueteria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Jugueteria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Jugueteria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Jugueteria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Jugueteria] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Jugueteria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Jugueteria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Jugueteria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Jugueteria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Jugueteria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Jugueteria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Jugueteria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Jugueteria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Jugueteria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Jugueteria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Jugueteria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Jugueteria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Jugueteria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Jugueteria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Jugueteria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Jugueteria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Jugueteria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Jugueteria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Jugueteria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Jugueteria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Jugueteria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Jugueteria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Jugueteria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Jugueteria] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Jugueteria] SET  MULTI_USER 
GO
ALTER DATABASE [Jugueteria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Jugueteria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Jugueteria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Jugueteria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Jugueteria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Jugueteria] SET QUERY_STORE = OFF
GO
USE [Jugueteria]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 21/02/2022 02:12:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[RestriccionEdad] [int] NULL,
	[Compañia] [varchar](10) NOT NULL,
	[Precio] [decimal](10, 2) NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [RestriccionEdad], [Compañia], [Precio]) VALUES (16, N'Pop IT', N'Juguete Silicona', 65, N'Mattel', CAST(15.50 AS Decimal(10, 2)))
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [RestriccionEdad], [Compañia], [Precio]) VALUES (17, N'Cocinita', N'Cocina  de plastico', 50, N'Mattel', CAST(40.00 AS Decimal(10, 2)))
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [RestriccionEdad], [Compañia], [Precio]) VALUES (18, N'Muñeca', N'Muñeca Barbie', 10, N'Mattel', CAST(45.00 AS Decimal(10, 2)))
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [RestriccionEdad], [Compañia], [Precio]) VALUES (19, N'Batman', N'Juguete Super Heroe', 40, N'DC', CAST(85.00 AS Decimal(10, 2)))
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [RestriccionEdad], [Compañia], [Precio]) VALUES (20, N'Casa', N'casa de muñecas', 25, N'Mattel', CAST(52.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Productos] OFF
USE [master]
GO
ALTER DATABASE [Jugueteria] SET  READ_WRITE 
GO
