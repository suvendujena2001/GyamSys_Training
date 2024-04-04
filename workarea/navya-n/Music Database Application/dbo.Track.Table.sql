USE [MusicDb]
GO

/****** Object:  Table [dbo].[Track]    Script Date: 28-03-2024 18:32:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Track](
	[TrackId] [int] IDENTITY(1,1) NOT NULL,
	[AlbumId] [int] NULL,
	[ArtistId] [int] NULL,
	[RatingId] [int] NULL,
	[TrackName] [nvarchar](255) NOT NULL,
	[AlbumLength] [nvarchar](100) NULL,
	[RecordLabel] [nvarchar](100) NULL,
	[Producer] [nvarchar](100) NULL,
	[Created_Date] [datetime] NULL,
	[Created_By] [nvarchar](100) NULL,
	[Modified_Date] [datetime] NULL,
	[Modified_By] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[TrackId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Track]  WITH CHECK ADD  CONSTRAINT [FK_AlbumId] FOREIGN KEY([AlbumId])
REFERENCES [dbo].[Album] ([AlbumId])
GO

ALTER TABLE [dbo].[Track] CHECK CONSTRAINT [FK_AlbumId]
GO

ALTER TABLE [dbo].[Track]  WITH CHECK ADD  CONSTRAINT [FK_ArtistId] FOREIGN KEY([ArtistId])
REFERENCES [dbo].[Artist] ([ArtistId])
GO

ALTER TABLE [dbo].[Track] CHECK CONSTRAINT [FK_ArtistId]
GO

ALTER TABLE [dbo].[Track]  WITH CHECK ADD  CONSTRAINT [FK_RatingId] FOREIGN KEY([RatingId])
REFERENCES [dbo].[Rating] ([RatingId])
GO

ALTER TABLE [dbo].[Track] CHECK CONSTRAINT [FK_RatingId]
GO


