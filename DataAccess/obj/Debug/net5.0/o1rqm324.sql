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

CREATE TABLE [Civilite] (
    [CiviliteId] bigint NOT NULL IDENTITY,
    [CiviliteName] nvarchar(max) NULL,
    [CiviliteAbreviation] nvarchar(max) NULL,
    CONSTRAINT [PK_Civilite] PRIMARY KEY ([CiviliteId])
);
GO

CREATE TABLE [TicketType] (
    [TicketTypeId] bigint NOT NULL IDENTITY,
    [TicketTypeName] nvarchar(max) NULL,
    CONSTRAINT [PK_TicketType] PRIMARY KEY ([TicketTypeId])
);
GO

CREATE TABLE [User] (
    [UserId] bigint NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([UserId])
);
GO

CREATE TABLE [Customer] (
    [CustomerId] bigint NOT NULL IDENTITY,
    [CustomerName] nvarchar(max) NULL,
    [ReferenceInterne] int NOT NULL,
    [Telephone] nvarchar(max) NULL,
    [Courriel] nvarchar(max) NULL,
    [SiteWeb] nvarchar(max) NULL,
    [Mobile] nvarchar(max) NULL,
    [PosteOccupe] nvarchar(max) NULL,
    [TVA] nvarchar(max) NULL,
    [CiviliteId] bigint NOT NULL,
    [CustomerType] int NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY ([CustomerId]),
    CONSTRAINT [FK_Customer_Civilite_CiviliteId] FOREIGN KEY ([CiviliteId]) REFERENCES [Civilite] ([CiviliteId]) ON DELETE CASCADE
);
GO

CREATE TABLE [Tickets] (
    [TicketId] bigint NOT NULL IDENTITY,
    [UserId] bigint NOT NULL,
    [TicketTypeId] bigint NOT NULL,
    [CustomerId] bigint NOT NULL,
    [Priorite] int NOT NULL,
    [State] int NOT NULL,
    [Date] datetime2 NOT NULL,
    [DateDeResoudre] datetime2 NOT NULL,
    [Duree] datetime2 NOT NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_Tickets] PRIMARY KEY ([TicketId]),
    CONSTRAINT [FK_Tickets_Customer_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([CustomerId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Tickets_TicketType_TicketTypeId] FOREIGN KEY ([TicketTypeId]) REFERENCES [TicketType] ([TicketTypeId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Tickets_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [User] ([UserId]) ON DELETE CASCADE
);
GO

CREATE TABLE [Attachment] (
    [AttachmentId] bigint NOT NULL IDENTITY,
    [AttachmentPath] nvarchar(max) NULL,
    [TicketId] bigint NULL,
    CONSTRAINT [PK_Attachment] PRIMARY KEY ([AttachmentId]),
    CONSTRAINT [FK_Attachment_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Tickets] ([TicketId]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Note] (
    [NoteId] bigint NOT NULL IDENTITY,
    [UserId] bigint NOT NULL,
    [TicketId] bigint NOT NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_Note] PRIMARY KEY ([NoteId]),
    CONSTRAINT [FK_Note_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Tickets] ([TicketId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Note_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [User] ([UserId]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Attachment_TicketId] ON [Attachment] ([TicketId]);
GO

CREATE INDEX [IX_Customer_CiviliteId] ON [Customer] ([CiviliteId]);
GO

CREATE INDEX [IX_Note_TicketId] ON [Note] ([TicketId]);
GO

CREATE INDEX [IX_Note_UserId] ON [Note] ([UserId]);
GO

CREATE INDEX [IX_Tickets_CustomerId] ON [Tickets] ([CustomerId]);
GO

CREATE INDEX [IX_Tickets_TicketTypeId] ON [Tickets] ([TicketTypeId]);
GO

CREATE INDEX [IX_Tickets_UserId] ON [Tickets] ([UserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211114154717_InitMigration', N'5.0.9');
GO

COMMIT;
GO

