USE [CarRental]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 28-03-2024 11:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[payment_id] [int] NOT NULL,
	[reservation_id] [int] NULL,
	[payment_date] [datetime] NULL,
	[amount] [decimal](10, 2) NULL,
	[payment_method] [varchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[payment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD FOREIGN KEY([reservation_id])
REFERENCES [dbo].[Reservations] ([reservation_id])
GO
