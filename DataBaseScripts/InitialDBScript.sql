USE [FreedomMobileShop]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 13-01-2021 15:15:08 ******/
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
/****** Object:  Table [dbo].[Customer]    Script Date: 13-01-2021 15:15:08 ******/
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
/****** Object:  Table [dbo].[Mobile]    Script Date: 13-01-2021 15:15:08 ******/
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
/****** Object:  Table [dbo].[Payment]    Script Date: 13-01-2021 15:15:08 ******/
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
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sell]    Script Date: 13-01-2021 15:15:08 ******/
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
/****** Object:  Table [dbo].[Stock]    Script Date: 13-01-2021 15:15:08 ******/
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
