USE [master]
GO
/****** Object:  Database [C:\RENTALSYSTEM\RENTALDB.MDF]    Script Date: 10/30/2018 17:25:27 ******/
CREATE DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'rentaldb', FILENAME = N'C:\RentalSystem\rentaldb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'rentaldb_log', FILENAME = N'C:\RentalSystem\rentaldb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [C:\RENTALSYSTEM\RENTALDB.MDF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET ARITHABORT OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET  ENABLE_BROKER 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET  MULTI_USER 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET DB_CHAINING OFF 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET QUERY_STORE = OFF
GO
USE [C:\RENTALSYSTEM\RENTALDB.MDF]
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
USE [C:\RENTALSYSTEM\RENTALDB.MDF]
GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 10/30/2018 17:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[CustomerID] [int] IDENTITY(10001,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMovie]    Script Date: 10/30/2018 17:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMovie](
	[MovieID] [int] IDENTITY(1001,1) NOT NULL,
	[Title] [nvarchar](255) NULL,
	[Year] [nvarchar](255) NULL,
	[Cost] [money] NULL,
	[Copies] [nvarchar](50) NULL,
	[Plot] [ntext] NULL,
	[Genre] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRentedMovies]    Script Date: 10/30/2018 17:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRentedMovies](
	[RMID] [int] IDENTITY(101,1) NOT NULL,
	[MovieIDFK] [int] NULL,
	[CustIDFK] [int] NULL,
	[DateOfRental] [datetime] NULL,
	[DateOfReturn] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[RMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblRentedMovies]  WITH CHECK ADD FOREIGN KEY([CustIDFK])
REFERENCES [dbo].[tblCustomer] ([CustomerID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblRentedMovies]  WITH CHECK ADD FOREIGN KEY([MovieIDFK])
REFERENCES [dbo].[tblMovie] ([MovieID])
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [C:\RENTALSYSTEM\RENTALDB.MDF] SET  READ_WRITE 
GO
