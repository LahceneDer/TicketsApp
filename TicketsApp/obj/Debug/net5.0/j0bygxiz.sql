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

CREATE TABLE [Tickets] (
    [Id] int NOT NULL IDENTITY,
    [Priorite] int NOT NULL,
    [State] int NOT NULL,
    [Date] datetime2 NOT NULL,
    [DateDeResoudre] datetime2 NOT NULL,
    [Duree] datetime2 NOT NULL,
    [Type] int NOT NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_Tickets] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211114100805_InitialCreate', N'5.0.9');
GO

COMMIT;
GO

