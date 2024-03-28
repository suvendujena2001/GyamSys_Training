USE [Blog_Platform_db]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 28-03-2024 10:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[User_id] [int] NOT NULL,
	[Username] [uniqueidentifier] NOT NULL,
	[Email] [uniqueidentifier] NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Created_date] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[User_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
