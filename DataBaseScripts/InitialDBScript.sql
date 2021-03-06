USE [master]
GO
/****** Object:  Database [FreedomMobileShop]    Script Date: 17-01-2021 07:57:35 ******/
CREATE DATABASE [FreedomMobileShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FreedomMobileShop', FILENAME = N'C:\Users\bimalkumar.das\FreedomMobileShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FreedomMobileShop_log', FILENAME = N'C:\Users\bimalkumar.das\FreedomMobileShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FreedomMobileShop] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FreedomMobileShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FreedomMobileShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FreedomMobileShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FreedomMobileShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FreedomMobileShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FreedomMobileShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FreedomMobileShop] SET  MULTI_USER 
GO
ALTER DATABASE [FreedomMobileShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FreedomMobileShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FreedomMobileShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FreedomMobileShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FreedomMobileShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FreedomMobileShop] SET QUERY_STORE = OFF
GO
USE [FreedomMobileShop]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [FreedomMobileShop]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 17-01-2021 07:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[BrandId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Company] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[BrandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 17-01-2021 07:57:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[MobileNumber] [nchar](10) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[AddressLine1] [nvarchar](50) NOT NULL,
	[AddressLine2] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mobile]    Script Date: 17-01-2021 07:57:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mobile](
	[MobileId] [int] NOT NULL,
	[MobileCompanyId] [nvarchar](50) NOT NULL,
	[MobileModelId] [nvarchar](50) NOT NULL,
	[IMEINumber] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Description] [nchar](10) NULL,
 CONSTRAINT [PK_Mobile] PRIMARY KEY CLUSTERED 
(
	[MobileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 17-01-2021 07:57:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[PaymentId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[MobileId] [int] NOT NULL,
	[PaymentDate] [datetime] NOT NULL,
	[Amount] [float] NOT NULL,
	[Description] [nvarchar](50) NULL,
	[BrandId] [int] NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sell]    Script Date: 17-01-2021 07:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sell](
	[SellId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sell] PRIMARY KEY CLUSTERED 
(
	[SellId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 17-01-2021 07:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[StockId] [int] NOT NULL,
	[Items] [nvarchar](50) NOT NULL,
	[Number] [bigint] NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[StockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brand] ([BrandId])
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD FOREIGN KEY([MobileId])
REFERENCES [dbo].[Mobile] ([MobileId])
GO
ALTER TABLE [dbo].[Payment]  WITH NOCHECK ADD  CONSTRAINT [FK_Payment_Payment] FOREIGN KEY([PaymentId])
REFERENCES [dbo].[Payment] ([PaymentId])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Payment]
GO
USE [master]
GO
ALTER DATABASE [FreedomMobileShop] SET  READ_WRITE 
GO
