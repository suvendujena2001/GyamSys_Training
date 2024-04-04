USE [ContactDB]
GO
/****** Object:  Table [dbo].[UserContacts]    Script Date: 28-03-2024 11:16:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserContacts](
	[Id] [int] NOT NULL,
	[UserID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UserContacts]  WITH CHECK ADD  CONSTRAINT [FK_UserContacts_Contacts] FOREIGN KEY([Id])
REFERENCES [dbo].[Contacts] ([Id])
GO
ALTER TABLE [dbo].[UserContacts] CHECK CONSTRAINT [FK_UserContacts_Contacts]
GO
ALTER TABLE [dbo].[UserContacts]  WITH CHECK ADD  CONSTRAINT [FK_UserContacts_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[UserContacts] CHECK CONSTRAINT [FK_UserContacts_User]
GO
