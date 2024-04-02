USE [MusicDb]
GO

/****** Object:  Table [dbo].[Playlist_tracks]    Script Date: 28-03-2024 18:32:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Playlist_tracks](
	[PlaylistId] [int] NULL,
	[TrackId] [int] NULL,
	[Created_Date] [datetime] NULL,
	[Created_By] [nvarchar](100) NULL,
	[Modified_Date] [datetime] NULL,
	[Modified_By] [nvarchar](100) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Playlist_tracks]  WITH CHECK ADD  CONSTRAINT [FK_PlaylistId] FOREIGN KEY([PlaylistId])
REFERENCES [dbo].[Playlist] ([PlaylistId])
GO

ALTER TABLE [dbo].[Playlist_tracks] CHECK CONSTRAINT [FK_PlaylistId]
GO

ALTER TABLE [dbo].[Playlist_tracks]  WITH CHECK ADD  CONSTRAINT [FK_Track] FOREIGN KEY([TrackId])
REFERENCES [dbo].[Track] ([TrackId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Playlist_tracks] CHECK CONSTRAINT [FK_Track]
GO


