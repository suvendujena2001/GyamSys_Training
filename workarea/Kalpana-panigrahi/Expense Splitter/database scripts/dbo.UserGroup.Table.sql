USE [ExpenseSplitter]
GO
/****** Object:  Table [dbo].[UserGroup]    Script Date: 28-03-2024 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroup](
	[GroupID] [int] NOT NULL,
	[GroupName] [varchar](200) NOT NULL,
	[Created_Date] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Updated_Date] [datetime] NULL,
	[Updated_By] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
