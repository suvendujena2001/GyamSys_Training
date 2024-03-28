USE [Blog_Platform_db]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 28-03-2024 10:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[Comment_id] [int] NOT NULL,
	[Post_id] [int] NOT NULL,
	[User_id] [int] NOT NULL,
	[Comment_text] [text] NOT NULL,
	[Created_date] [datetime] NOT NULL,
	[Created_by] [int] NOT NULL,
	[Updated_date] [datetime] NOT NULL,
	[Updated_by] [int] NOT NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[Comment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Blogs] FOREIGN KEY([Post_id])
REFERENCES [dbo].[Blogs] ([Post_id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Blogs]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Users]
GO
