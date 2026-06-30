-- Verificar se a base de dados existe, se não existir, criar
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Unreal_StoreBD')
BEGIN
    CREATE DATABASE Unreal_StoreBD;
END
GO

-- Usar a base de dados
USE Unreal_StoreBD;
GO

-- Criar tabela de utilizadores
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Utilizadores]') AND type in (N'U'))
BEGIN
    CREATE TABLE Utilizadores (
        UserID INT IDENTITY(1,1) PRIMARY KEY,
        Username NVARCHAR(50) NOT NULL UNIQUE,
        Password NVARCHAR(100) NOT NULL,
        Balance DECIMAL(10,2) NOT NULL DEFAULT 0,
        CreatedDate DATETIME NOT NULL DEFAULT GETDATE()
    );
END
GO

-- Criar tabela de jogos
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Jogos]') AND type in (N'U'))
BEGIN
    CREATE TABLE Jogos (
        GameID INT IDENTITY(1,1) PRIMARY KEY,
        GameCode NVARCHAR(20) NOT NULL UNIQUE,
        Title NVARCHAR(100) NOT NULL,
        Price DECIMAL(10,2) NOT NULL,
        Description NVARCHAR(500) NULL,
        ImagePath NVARCHAR(200) NULL,
        IsActive BIT NOT NULL DEFAULT 1
    );
END
GO

-- Criar tabela de jogos comprados
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JogosComprados]') AND type in (N'U'))
BEGIN
    CREATE TABLE JogosComprados (
        PurchaseID INT IDENTITY(1,1) PRIMARY KEY,
        UserID INT NOT NULL,
        GameID INT NOT NULL,
        PurchaseDate DATETIME NOT NULL DEFAULT GETDATE(),
        AmountPaid DECIMAL(10,2) NOT NULL,
        FOREIGN KEY (UserID) REFERENCES Utilizadores(UserID) ON DELETE CASCADE,
        FOREIGN KEY (GameID) REFERENCES Jogos(GameID) ON DELETE CASCADE,
        CONSTRAINT UQ_UserGame UNIQUE (UserID, GameID)
    );
END
GO

-- Inserir jogos na tabela (apenas se não existirem)
IF NOT EXISTS (SELECT * FROM Jogos WHERE GameCode = 'ACAO')
BEGIN
    INSERT INTO Jogos (GameCode, Title, Price, Description) VALUES
    ('ACAO', 'Jogo de Ação', 19.99, 'Jogo de ação emocionante com gráficos incríveis!'),
    ('EXPLORACAO', 'Jogo de Exploração', 9.99, 'Explore mundos vastos e descubra segredos!'),
    ('POINTCLICK', 'Point-and-Click 2D', 3.99, 'Aventura clássica point-and-click em 2D!'),
    ('MULTI', 'Multi-jogador', 0.00, 'Jogo multiplayer gratuito para jogar com amigos!');
END
GO

-- Verificar se a base de dados foi criada corretamente
SELECT 'Base de dados criada com sucesso!' AS Status;
SELECT * FROM Utilizadores;
SELECT * FROM Jogos;
GO