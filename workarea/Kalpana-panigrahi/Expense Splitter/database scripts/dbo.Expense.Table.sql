USE [ExpenseSplitter]
GO
/****** Object:  Table [dbo].[Expense]    Script Date: 28-03-2024 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expense](
	[ExpenseID] [int] NOT NULL,
	[GroupID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[Category] [varchar](50) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[PaymentID] [int] NOT NULL,
	[DateofExpense] [date] NOT NULL,
	[Created_Date] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Updated_Date] [datetime] NULL,
	[Updated_By] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Expense]  WITH CHECK ADD FOREIGN KEY([GroupID])
REFERENCES [dbo].[UserGroup] ([GroupID])
GO
ALTER TABLE [dbo].[Expense]  WITH CHECK ADD FOREIGN KEY([PaymentID])
REFERENCES [dbo].[Payment] ([PaymentID])
GO
ALTER TABLE [dbo].[Expense]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
