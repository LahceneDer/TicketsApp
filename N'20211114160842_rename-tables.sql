IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Attachment] DROP CONSTRAINT [FK_Attachment_Tickets_TicketId];
GO

ALTER TABLE [Customer] DROP CONSTRAINT [FK_Customer_Civilite_CiviliteId];
GO

ALTER TABLE [Note] DROP CONSTRAINT [FK_Note_Tickets_TicketId];
GO

ALTER TABLE [Note] DROP CONSTRAINT [FK_Note_User_UserId];
GO

ALTER TABLE [Permission] DROP CONSTRAINT [FK_Permission_Role_RoleId];
GO

ALTER TABLE [Tickets] DROP CONSTRAINT [FK_Tickets_Customer_CustomerId];
GO

ALTER TABLE [Tickets] DROP CONSTRAINT [FK_Tickets_TicketType_TicketTypeId];
GO

ALTER TABLE [Tickets] DROP CONSTRAINT [FK_Tickets_User_UserId];
GO

ALTER TABLE [User] DROP CONSTRAINT [PK_User];
GO

ALTER TABLE [TicketType] DROP CONSTRAINT [PK_TicketType];
GO

ALTER TABLE [Role] DROP CONSTRAINT [PK_Role];
GO

ALTER TABLE [Permission] DROP CONSTRAINT [PK_Permission];
GO

ALTER TABLE [Note] DROP CONSTRAINT [PK_Note];
GO

ALTER TABLE [Customer] DROP CONSTRAINT [PK_Customer];
GO

ALTER TABLE [Civilite] DROP CONSTRAINT [PK_Civilite];
GO

ALTER TABLE [Attachment] DROP CONSTRAINT [PK_Attachment];
GO

EXEC sp_rename N'[User]', N'Users';
GO

EXEC sp_rename N'[TicketType]', N'TicketTypes';
GO

EXEC sp_rename N'[Role]', N'Roles';
GO

EXEC sp_rename N'[Permission]', N'Permissions';
GO

EXEC sp_rename N'[Note]', N'Notes';
GO

EXEC sp_rename N'[Customer]', N'Customers';
GO

EXEC sp_rename N'[Civilite]', N'Civilites';
GO

EXEC sp_rename N'[Attachment]', N'Attachments';
GO

EXEC sp_rename N'[Permissions].[IX_Permission_RoleId]', N'IX_Permissions_RoleId', N'INDEX';
GO

EXEC sp_rename N'[Notes].[IX_Note_UserId]', N'IX_Notes_UserId', N'INDEX';
GO

EXEC sp_rename N'[Notes].[IX_Note_TicketId]', N'IX_Notes_TicketId', N'INDEX';
GO

EXEC sp_rename N'[Customers].[IX_Customer_CiviliteId]', N'IX_Customers_CiviliteId', N'INDEX';
GO

EXEC sp_rename N'[Attachments].[IX_Attachment_TicketId]', N'IX_Attachments_TicketId', N'INDEX';
GO

ALTER TABLE [Users] ADD CONSTRAINT [PK_Users] PRIMARY KEY ([UserId]);
GO

ALTER TABLE [TicketTypes] ADD CONSTRAINT [PK_TicketTypes] PRIMARY KEY ([TicketTypeId]);
GO

ALTER TABLE [Roles] ADD CONSTRAINT [PK_Roles] PRIMARY KEY ([RoleId]);
GO

ALTER TABLE [Permissions] ADD CONSTRAINT [PK_Permissions] PRIMARY KEY ([PermissionId]);
GO

ALTER TABLE [Notes] ADD CONSTRAINT [PK_Notes] PRIMARY KEY ([NoteId]);
GO

ALTER TABLE [Customers] ADD CONSTRAINT [PK_Customers] PRIMARY KEY ([CustomerId]);
GO

ALTER TABLE [Civilites] ADD CONSTRAINT [PK_Civilites] PRIMARY KEY ([CiviliteId]);
GO

ALTER TABLE [Attachments] ADD CONSTRAINT [PK_Attachments] PRIMARY KEY ([AttachmentId]);
GO

ALTER TABLE [Attachments] ADD CONSTRAINT [FK_Attachments_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Tickets] ([TicketId]) ON DELETE NO ACTION;
GO

ALTER TABLE [Customers] ADD CONSTRAINT [FK_Customers_Civilites_CiviliteId] FOREIGN KEY ([CiviliteId]) REFERENCES [Civilites] ([CiviliteId]) ON DELETE CASCADE;
GO

ALTER TABLE [Notes] ADD CONSTRAINT [FK_Notes_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Tickets] ([TicketId]) ON DELETE CASCADE;
GO

ALTER TABLE [Notes] ADD CONSTRAINT [FK_Notes_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([UserId]) ON DELETE CASCADE;
GO

ALTER TABLE [Permissions] ADD CONSTRAINT [FK_Permissions_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Roles] ([RoleId]) ON DELETE CASCADE;
GO

ALTER TABLE [Tickets] ADD CONSTRAINT [FK_Tickets_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([CustomerId]) ON DELETE CASCADE;
GO

ALTER TABLE [Tickets] ADD CONSTRAINT [FK_Tickets_TicketTypes_TicketTypeId] FOREIGN KEY ([TicketTypeId]) REFERENCES [TicketTypes] ([TicketTypeId]) ON DELETE CASCADE;
GO

ALTER TABLE [Tickets] ADD CONSTRAINT [FK_Tickets_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([UserId]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211114160842_rename-tables', N'5.0.9');
GO

COMMIT;
GO

