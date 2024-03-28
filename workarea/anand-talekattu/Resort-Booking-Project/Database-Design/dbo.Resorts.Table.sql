USE [Project]
GO
/****** Object:  Table [dbo].[Resorts]    Script Date: 28-03-2024 11:03:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resorts](
	[ResortId] [int] NOT NULL,
	[ResortName] [varchar](100) NOT NULL,
	[City] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
	[PackageId] [int] NULL,
	[PricePerNight] [decimal](10, 2) NULL,
	[CancellationPolicy] [varchar](max) NULL,
	[Created_By] [int] NULL,
	[Created_Date] [datetime] NULL,
	[Updated_By] [int] NULL,
	[Updated_Date] [datetime] NULL,
	[AverageRating] [decimal](2, 1) NULL,
PRIMARY KEY CLUSTERED 
(
	[ResortId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Resorts] ADD  DEFAULT (getdate()) FOR [Created_Date]
GO
ALTER TABLE [dbo].[Resorts] ADD  DEFAULT (getdate()) FOR [Updated_Date]
GO
ALTER TABLE [dbo].[Resorts]  WITH CHECK ADD FOREIGN KEY([PackageId])
REFERENCES [dbo].[Packages] ([PackageID])
GO
