USE [CarRental]
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 28-03-2024 11:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[vehicle_id] [int] NOT NULL,
	[make] [varchar](50) NULL,
	[model] [varchar](50) NULL,
	[year] [int] NULL,
	[color] [varchar](50) NULL,
	[mileage] [decimal](10, 2) NULL,
	[rental_rate_per_hour] [decimal](10, 2) NULL,
	[rental_rate_per_day] [decimal](10, 2) NULL,
	[rental_rate_per_week] [decimal](10, 2) NULL,
	[availability_status] [varchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[vehicle_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
