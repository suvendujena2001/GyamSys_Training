USE [BookStore]
GO
/****** Object:  Table [dbo].[User]    Script Date: 27-03-2024 14:10:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[user_id] [int] NOT NULL,
	[fName] [nvarchar](50) NOT NULL,
	[lName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
