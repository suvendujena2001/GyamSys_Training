USE [Blog_Platform_db]
GO
/****** Object:  Table [dbo].[MediaLinks]    Script Date: 28-03-2024 10:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MediaLinks](
	[Media_URL] [varchar](50) NOT NULL,
	[Post_id] [int] NOT NULL,
	[Created_date] [datetime] NOT NULL,
	[Created_by] [int] NOT NULL,
	[Updated_date] [datetime] NOT NULL,
	[Updated_by] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MediaLinks]  WITH CHECK ADD  CONSTRAINT [FK_MediaLinks_Blogs] FOREIGN KEY([Post_id])
REFERENCES [dbo].[Blogs] ([Post_id])
GO
ALTER TABLE [dbo].[MediaLinks] CHECK CONSTRAINT [FK_MediaLinks_Blogs]
GO
