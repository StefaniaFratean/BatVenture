USE [master]
GO
/****** Object:  Database [batventure]    Script Date: 02/06/2020 10:08:41 ******/
CREATE DATABASE [batventure]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'batventure', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS02\MSSQL\DATA\batventure.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'batventure_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS02\MSSQL\DATA\batventure_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [batventure] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [batventure].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [batventure] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [batventure] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [batventure] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [batventure] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [batventure] SET ARITHABORT OFF 
GO
ALTER DATABASE [batventure] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [batventure] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [batventure] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [batventure] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [batventure] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [batventure] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [batventure] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [batventure] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [batventure] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [batventure] SET  DISABLE_BROKER 
GO
ALTER DATABASE [batventure] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [batventure] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [batventure] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [batventure] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [batventure] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [batventure] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [batventure] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [batventure] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [batventure] SET  MULTI_USER 
GO
ALTER DATABASE [batventure] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [batventure] SET DB_CHAINING OFF 
GO
ALTER DATABASE [batventure] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [batventure] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [batventure] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [batventure] SET QUERY_STORE = OFF
GO
USE [batventure]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 02/06/2020 10:08:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[HighScore] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'Adela', N'adela', CAST(12 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'blaaa', N'blaaa', CAST(10 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'cami', N'tm11spt', CAST(12 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'car', N'abc123', CAST(10 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'Demo', N'12', CAST(4 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'Demo1', N'0000', CAST(0 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'Diana', N'777', CAST(8 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'Skype', N'123', CAST(10 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'Stefi', N'0000', CAST(23 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'Tavi', N'1234', CAST(6 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'Test', N'000', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'user', N'21', CAST(0 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'user1', N'123', CAST(23 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'user2', N'234', CAST(33 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'user3', N'1234', CAST(8 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([UserName], [Password], [HighScore]) VALUES (N'user4', N'1234', CAST(0 AS Numeric(18, 0)))
GO
USE [master]
GO
ALTER DATABASE [batventure] SET  READ_WRITE 
GO
