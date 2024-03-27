USE [BookStore]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 27-03-2024 14:10:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN] [nvarchar](13) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[author_id] [int] NOT NULL,
	[genre_id] [int] NOT NULL,
	[Category_id] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[Pages] [int] NOT NULL,
	[Publication_Date] [datetime2](7) NOT NULL,
	[Availability] [nvarchar](50) NOT NULL,
	[Popularity] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Cover_image] [nvarchar](50) NOT NULL,
	[Created_By] [int] NOT NULL,
	[Created_Date] [datetime] NOT NULL,
	[Updated_By] [int] NOT NULL,
	[Updated_Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Author] FOREIGN KEY([author_id])
REFERENCES [dbo].[Author] ([Author_Id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Author]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Category] FOREIGN KEY([Category_id])
REFERENCES [dbo].[Category] ([Category_Id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Category]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Genre] FOREIGN KEY([genre_id])
REFERENCES [dbo].[Genre] ([genre_id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Genre]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_User] FOREIGN KEY([Created_By])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_User]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_User1] FOREIGN KEY([Updated_By])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_User1]
GO
