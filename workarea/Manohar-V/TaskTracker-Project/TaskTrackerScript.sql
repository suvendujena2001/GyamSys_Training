USE [TaskTracker]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 28-03-2024 14:45:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 28-03-2024 14:45:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[TaskId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[DueData] [datetime2](7) NOT NULL,
	[Priority] [nvarchar](max) NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[AssigneId] [int] NULL,
	[Progress] [int] NOT NULL,
	[Comments] [nvarchar](max) NOT NULL,
	[Created_By] [int] NOT NULL,
	[Created_Date] [datetime2](7) NOT NULL,
	[Updated_By] [int] NOT NULL,
	[Updated_Date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[TaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 28-03-2024 14:45:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[isActive] [bit] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Created_Date] [datetime2](7) NOT NULL,
	[Updated_By] [int] NOT NULL,
	[Updated_Date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tasks] ADD  DEFAULT ((0)) FOR [Created_By]
GO
ALTER TABLE [dbo].[Tasks] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Created_Date]
GO
ALTER TABLE [dbo].[Tasks] ADD  DEFAULT ((0)) FOR [Updated_By]
GO
ALTER TABLE [dbo].[Tasks] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Updated_Date]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (CONVERT([bit],(0))) FOR [isActive]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [Created_By]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Created_Date]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [Updated_By]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Updated_Date]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD FOREIGN KEY([AssigneId])
REFERENCES [dbo].[Users] ([UserId])
GO
