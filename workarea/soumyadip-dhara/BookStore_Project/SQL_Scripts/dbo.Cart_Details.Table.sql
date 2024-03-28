USE [BookStore]
GO
/****** Object:  Table [dbo].[Cart_Details]    Script Date: 27-03-2024 14:10:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart_Details](
	[cart_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[SBIN] [nvarchar](13) NOT NULL,
	[Updated_Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Cart_Details] PRIMARY KEY CLUSTERED 
(
	[cart_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cart_Details]  WITH CHECK ADD  CONSTRAINT [FK_Cart_Details_Books] FOREIGN KEY([SBIN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[Cart_Details] CHECK CONSTRAINT [FK_Cart_Details_Books]
GO
ALTER TABLE [dbo].[Cart_Details]  WITH CHECK ADD  CONSTRAINT [FK_Cart_Details_User] FOREIGN KEY([user_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[Cart_Details] CHECK CONSTRAINT [FK_Cart_Details_User]
GO
