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

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Civilite]') AND [c].[name] = N'CiviliteAbreviation');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Civilite] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Civilite] DROP COLUMN [CiviliteAbreviation];
GO

CREATE TABLE [Role] (
    [RoleId] bigint NOT NULL IDENTITY,
    CONSTRAINT [PK_Role] PRIMARY KEY ([RoleId])
);
GO

CREATE TABLE [Permission] (
    [PermissionId] bigint NOT NULL IDENTITY,
    [RoleId] bigint NOT NULL,
    CONSTRAINT [PK_Permission] PRIMARY KEY ([PermissionId]),
    CONSTRAINT [FK_Permission_Role_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Role] ([RoleId]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Permission_RoleId] ON [Permission] ([RoleId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211114160238_secondMigration', N'5.0.9');
GO

COMMIT;
GO

