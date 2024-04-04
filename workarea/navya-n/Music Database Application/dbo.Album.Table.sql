USE [MusicDb]
GO

/****** Object:  Table [dbo].[Album]    Script Date: 28-03-2024 18:28:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Album](
	[AlbumId] [int] IDENTITY(1,1) NOT NULL,
	[AlbumName] [nvarchar](255) NOT NULL,
	[ArtistId] [int] NOT NULL,
	[Release_Date] [date] NULL,
	[Genre] [nvarchar](100) NULL,
	[Cover] [varbinary](max) NULL,
	[Created_Date] [datetime] NULL,
	[Created_By] [nvarchar](100) NULL,
	[Modified_Date] [datetime] NULL,
	[Modified_By] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[AlbumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Album]  WITH CHECK ADD  CONSTRAINT [FK_Artist] FOREIGN KEY([ArtistId])
REFERENCES [dbo].[Artist] ([ArtistId])
GO

ALTER TABLE [dbo].[Album] CHECK CONSTRAINT [FK_Artist]
GO


