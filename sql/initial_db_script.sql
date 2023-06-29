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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230629014822_initial')
BEGIN
    CREATE TABLE [Customers] (
        [Id] int NOT NULL IDENTITY,
        [FullName] varchar(150) NOT NULL,
        [Document] varchar(18) NOT NULL,
        [IsLegalPerson] bit NOT NULL DEFAULT CAST(0 AS bit),
        [CreatedAt] datetime2 NOT NULL,
        [ModifiedAt] datetime2 NULL,
        CONSTRAINT [PK_Customers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230629014822_initial')
BEGIN
    CREATE TABLE [Products] (
        [Id] int NOT NULL IDENTITY,
        [Name] varchar(1000) NOT NULL,
        [Description] varchar(1000) NULL,
        [Price] decimal(10,2) NOT NULL,
        [Quantity] int NOT NULL,
        [CustomerId] int NULL,
        [CreatedAt] datetime2 NOT NULL,
        [ModifiedAt] datetime2 NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Products_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE SET NULL
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230629014822_initial')
BEGIN
    CREATE TABLE [Sales] (
        [Id] int NOT NULL IDENTITY,
        [SaleNumber] char(14) NOT NULL,
        [ProductPriceAtMoment] decimal(10,2) NOT NULL,
        [ProductQuantity] int NOT NULL,
        [Total] decimal(10,2) NOT NULL,
        [SaleCancelled] bit NOT NULL DEFAULT CAST(0 AS bit),
        [CustomerId] int NULL,
        [ProductId] int NULL,
        [CreatedAt] datetime2 NOT NULL,
        [ModifiedAt] datetime2 NULL,
        CONSTRAINT [PK_Sales] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Sales_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE SET NULL,
        CONSTRAINT [FK_Sales_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id]) ON DELETE SET NULL
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230629014822_initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'Document', N'FullName', N'ModifiedAt') AND [object_id] = OBJECT_ID(N'[Customers]'))
        SET IDENTITY_INSERT [Customers] ON;
    EXEC(N'INSERT INTO [Customers] ([Id], [CreatedAt], [Document], [FullName], [ModifiedAt])
    VALUES (1, ''2023-06-28T22:48:22.2425430-03:00'', ''382.152.203-80'', ''Isabela Saraiva'', NULL),
    (2, ''2023-06-28T22:48:22.2426894-03:00'', ''852.628.770-28'', ''Matheus Oliveira'', NULL),
    (3, ''2023-06-28T22:48:22.2427618-03:00'', ''942.456.367-18'', ''Félix Albuquerque'', NULL),
    (4, ''2023-06-28T22:48:22.2428305-03:00'', ''070.495.427-33'', ''Víctor Pereira'', NULL),
    (5, ''2023-06-28T22:48:22.2428918-03:00'', ''883.604.630-42'', ''Hélio Macedo'', NULL),
    (6, ''2023-06-28T22:48:22.2429526-03:00'', ''031.553.809-00'', ''Margarida Melo'', NULL),
    (7, ''2023-06-28T22:48:22.2430128-03:00'', ''697.970.771-01'', ''João Miguel Braga'', NULL),
    (8, ''2023-06-28T22:48:22.2430757-03:00'', ''213.674.466-60'', ''Yago Santos'', NULL),
    (9, ''2023-06-28T22:48:22.2431369-03:00'', ''992.035.824-01'', ''Marli Franco'', NULL),
    (10, ''2023-06-28T22:48:22.2431944-03:00'', ''430.282.699-10'', ''Célia Moreira'', NULL)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'Document', N'FullName', N'ModifiedAt') AND [object_id] = OBJECT_ID(N'[Customers]'))
        SET IDENTITY_INSERT [Customers] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230629014822_initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'CustomerId', N'Description', N'ModifiedAt', N'Name', N'Price', N'Quantity') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] ON;
    EXEC(N'INSERT INTO [Products] ([Id], [CreatedAt], [CustomerId], [Description], [ModifiedAt], [Name], [Price], [Quantity])
    VALUES (1, ''2023-06-28T22:48:22.2444954-03:00'', NULL, ''The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design'', NULL, ''Genérico Borracha Toalhas'', 11.365512587310034, 45),
    (2, ''2023-06-28T22:48:22.2445258-03:00'', NULL, ''New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart'', NULL, ''Sem marca Aço Calças'', 44.227627758033895, 91),
    (3, ''2023-06-28T22:48:22.2445293-03:00'', NULL, ''Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support'', NULL, ''Licenciado Plástico Bola'', 32.776356910107304, 82),
    (4, ''2023-06-28T22:48:22.2445317-03:00'', NULL, ''The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design'', NULL, ''Rústico Fresco Pizza'', 70.388869774976092, 55),
    (5, ''2023-06-28T22:48:22.2445342-03:00'', NULL, ''The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive'', NULL, ''Feito à mão Fresco Toalhas'', 50.146406511197644, 97),
    (6, ''2023-06-28T22:48:22.2445391-03:00'', NULL, ''The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients'', NULL, ''Lustroso Aço Calças'', 42.049319724685558, 31),
    (7, ''2023-06-28T22:48:22.2445412-03:00'', NULL, ''The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients'', NULL, ''Feito à mão Fresco Bicicleta'', 71.075760385589695, 69),
    (8, ''2023-06-28T22:48:22.2445429-03:00'', NULL, ''The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality'', NULL, ''Rústico Macio Camiseta'', 87.223846591226476, 30),
    (9, ''2023-06-28T22:48:22.2445448-03:00'', NULL, ''The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality'', NULL, ''Prático Macio Mouse'', 89.196131279344429, 36),
    (10, ''2023-06-28T22:48:22.2445465-03:00'', NULL, ''The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality'', NULL, ''Impressionante Madeira Salgadinhos'', 76.021604075099836, 29)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'CustomerId', N'Description', N'ModifiedAt', N'Name', N'Price', N'Quantity') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230629014822_initial')
BEGIN
    CREATE UNIQUE INDEX [IX_Customers_Document] ON [Customers] ([Document]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230629014822_initial')
BEGIN
    CREATE INDEX [IX_Products_CustomerId] ON [Products] ([CustomerId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230629014822_initial')
BEGIN
    CREATE INDEX [IX_Sales_CustomerId] ON [Sales] ([CustomerId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230629014822_initial')
BEGIN
    CREATE INDEX [IX_Sales_ProductId] ON [Sales] ([ProductId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230629014822_initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230629014822_initial', N'6.0.19');
END;
GO

COMMIT;
GO

