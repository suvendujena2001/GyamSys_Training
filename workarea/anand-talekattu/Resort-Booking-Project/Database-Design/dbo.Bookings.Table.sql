USE [Project]
GO
/****** Object:  Table [dbo].[Bookings]    Script Date: 28-03-2024 11:03:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bookings](
	[BookingID] [int] NOT NULL,
	[UserID] [int] NULL,
	[ResortID] [int] NULL,
	[BookingDate] [date] NULL,
	[CheckInDate] [date] NULL,
	[CheckOutDate] [date] NULL,
	[TotalPrice] [decimal](10, 2) NULL,
	[Status] [varchar](20) NULL,
	[Created_By] [int] NULL,
	[Created_Date] [datetime] NULL,
	[Updated_By] [int] NULL,
	[Updated_Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bookings] ADD  DEFAULT (getdate()) FOR [Created_Date]
GO
ALTER TABLE [dbo].[Bookings] ADD  DEFAULT (getdate()) FOR [Updated_Date]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD FOREIGN KEY([ResortID])
REFERENCES [dbo].[Resorts] ([ResortId])
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserId])
GO
