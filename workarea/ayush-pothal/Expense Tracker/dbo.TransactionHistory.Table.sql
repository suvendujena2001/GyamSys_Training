USE [ExpenseDb]
GO
/****** Object:  Table [dbo].[TransactionHistory]    Script Date: 27-03-2024 18:34:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionHistory](
	[TransactionId] [int] NOT NULL,
	[UserId] [int] NULL,
	[ExpenseId] [int] NULL,
	[TransactionDate] [date] NOT NULL,
	[TransactionType] [varchar](50) NOT NULL,
	[TransactionDetails] [varchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[TransactionHistory]  WITH CHECK ADD FOREIGN KEY([ExpenseId])
REFERENCES [dbo].[Expenses] ([ExpenseId])
GO
ALTER TABLE [dbo].[TransactionHistory]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
