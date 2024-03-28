USE [ExpenseDb]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 27-03-2024 18:34:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[ExpenseId] [int] NOT NULL,
	[UserId] [int] NULL,
	[CategoryName] [varchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[Description] [varchar](255) NULL,
	[PaymentMethod] [varchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ExpenseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Expenses]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
