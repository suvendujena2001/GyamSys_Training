USE [InventoryManagement]
GO
/****** Object:  Table [dbo].[InventoryTransaction]    Script Date: 27-03-2024 14:22:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventoryTransaction](
	[TransactionId] [int] NOT NULL,
	[ItemId] [int] NULL,
	[TransactionDate] [datetime] NULL,
	[Quantity] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[InventoryTransaction]  WITH CHECK ADD FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([ItemId])
GO
