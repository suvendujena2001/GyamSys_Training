USE [Blog_Platform_db]
GO
/****** Object:  Table [dbo].[Blogs]    Script Date: 28-03-2024 10:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blogs](
	[Post_id] [int] NOT NULL,
	[User_id] [int] NOT NULL,
	[Category_id] [int] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Contents] [varchar](max) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Created_date] [datetime] NOT NULL,
	[Created_by] [int] NOT NULL,
	[Updated_date] [datetime] NOT NULL,
	[Updated_by] [int] NOT NULL,
 CONSTRAINT [PK_Blogs] PRIMARY KEY CLUSTERED 
(
	[Post_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Blogs]  WITH CHECK ADD  CONSTRAINT [FK_Blogs_Categories] FOREIGN KEY([Category_id])
REFERENCES [dbo].[Categories] ([Category_id])
GO
ALTER TABLE [dbo].[Blogs] CHECK CONSTRAINT [FK_Blogs_Categories]
GO
ALTER TABLE [dbo].[Blogs]  WITH CHECK ADD  CONSTRAINT [FK_Blogs_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[Blogs] CHECK CONSTRAINT [FK_Blogs_Users]
GO
