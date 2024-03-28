USE [Project]
GO
/****** Object:  Table [dbo].[ResortRatings]    Script Date: 28-03-2024 11:03:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResortRatings](
	[RatingID] [int] NOT NULL,
	[ResortID] [int] NULL,
	[UserID] [int] NULL,
	[Rating] [decimal](2, 1) NULL,
	[Comment] [text] NULL,
	[RatedDate] [date] NULL,
	[Created_By] [int] NULL,
	[Created_Date] [datetime] NULL,
	[Updated_By] [int] NULL,
	[Updated_Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[RatingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ResortRatings] ADD  DEFAULT (getdate()) FOR [Created_Date]
GO
ALTER TABLE [dbo].[ResortRatings] ADD  DEFAULT (getdate()) FOR [Updated_Date]
GO
ALTER TABLE [dbo].[ResortRatings]  WITH CHECK ADD FOREIGN KEY([ResortID])
REFERENCES [dbo].[Resorts] ([ResortId])
GO
ALTER TABLE [dbo].[ResortRatings]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserId])
GO
