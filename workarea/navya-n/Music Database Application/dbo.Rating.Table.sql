USE [MusicDb]
GO

/****** Object:  Table [dbo].[Rating]    Script Date: 28-03-2024 18:32:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rating](
	[RatingId] [int] IDENTITY(1,1) NOT NULL,
	[TrackId] [int] NULL,
	[AlbumId] [int] NULL,
	[UserId] [int] NULL,
	[TrackRating] [int] NULL,
	[AlbumRating] [int] NULL,
	[Reviews] [text] NULL,
	[Created_Date] [datetime] NULL,
	[Created_By] [nvarchar](100) NULL,
	[Modified_Date] [datetime] NULL,
	[Modified_By] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[RatingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_AlbId] FOREIGN KEY([AlbumId])
REFERENCES [dbo].[Album] ([AlbumId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_AlbId]
GO

ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_TrackId] FOREIGN KEY([TrackId])
REFERENCES [dbo].[Track] ([TrackId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_TrackId]
GO

ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_UserId]
GO


