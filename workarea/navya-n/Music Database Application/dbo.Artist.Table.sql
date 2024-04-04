USE [MusicDb]
GO

/****** Object:  Table [dbo].[Artist]    Script Date: 28-03-2024 18:29:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Artist](
	[ArtistId] [int] IDENTITY(1,1) NOT NULL,
	[ArtistName] [nvarchar](255) NOT NULL,
	[ArtistBio] [text] NULL,
	[ActiveYear] [int] NULL,
	[Created_Date] [datetime] NULL,
	[Created_By] [nvarchar](100) NULL,
	[Modified_Date] [datetime] NULL,
	[Modified_By] [nvarchar](100) NULL,
	[AlbumId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ArtistId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Artist]  WITH CHECK ADD  CONSTRAINT [FK_Album] FOREIGN KEY([AlbumId])
REFERENCES [dbo].[Album] ([AlbumId])
GO

ALTER TABLE [dbo].[Artist] CHECK CONSTRAINT [FK_Album]
GO


