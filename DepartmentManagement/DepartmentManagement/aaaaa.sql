USE [master]
GO
/****** Object:  Database [DepartmentManagement]    Script Date: 3/9/2017 6:38:37 PM ******/
CREATE DATABASE [DepartmentManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DepartmentManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.LONG_NGUYEN\MSSQL\DATA\DepartmentManagement.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DepartmentManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.LONG_NGUYEN\MSSQL\DATA\DepartmentManagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DepartmentManagement] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DepartmentManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DepartmentManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DepartmentManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DepartmentManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DepartmentManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DepartmentManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [DepartmentManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DepartmentManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DepartmentManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DepartmentManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DepartmentManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DepartmentManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DepartmentManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DepartmentManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DepartmentManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DepartmentManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DepartmentManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DepartmentManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DepartmentManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DepartmentManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DepartmentManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DepartmentManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DepartmentManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DepartmentManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [DepartmentManagement] SET  MULTI_USER 
GO
ALTER DATABASE [DepartmentManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DepartmentManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DepartmentManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DepartmentManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DepartmentManagement] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DepartmentManagement]
GO
/****** Object:  Table [dbo].[tblDepartment]    Script Date: 3/9/2017 6:38:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDepartment](
	[id] [varchar](50) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDepartment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblDepartment] ([id], [name]) VALUES (N'SE1069', N'Công nghệ thông tin')
INSERT [dbo].[tblDepartment] ([id], [name]) VALUES (N'SE1234', N'Bim bim')
INSERT [dbo].[tblDepartment] ([id], [name]) VALUES (N'SE1982', N'An toàn thông tin')
INSERT [dbo].[tblDepartment] ([id], [name]) VALUES (N'SE2195', N'Long Bim')
INSERT [dbo].[tblDepartment] ([id], [name]) VALUES (N'SE3219', N'Thanh Long')
USE [master]
GO
ALTER DATABASE [DepartmentManagement] SET  READ_WRITE 
GO
