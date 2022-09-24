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

CREATE TABLE [Generos] (
    [Id] int NOT NULL IDENTITY,
    [Descripcion] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Generos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Personas] (
    [Id] int NOT NULL IDENTITY,
    [Identificacion] int NOT NULL,
    [FkTipoDocumento] int NOT NULL,
    [Nombre] nvarchar(max) NOT NULL,
    [Apellido] nvarchar(max) NOT NULL,
    [Telefono] nvarchar(max) NOT NULL,
    [Correo] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Personas] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Revisiones] (
    [Id] int NOT NULL IDENTITY,
    [FKVehiculo] int NOT NULL,
    [FKMecanico] int NOT NULL,
    [NivelAceite] nvarchar(max) NOT NULL,
    [FechaNivelAceite]  NOT NULL,
    [NivelFrenos] nvarchar(max) NOT NULL,
    [FechaNivelFrenos]  NOT NULL,
    [NivelRefrigerante] nvarchar(max) NOT NULL,
    [FechaNivelRefrigerante]  NOT NULL,
    [NivelDireccion] nvarchar(max) NOT NULL,
    [FechaNivelDireccion]  NOT NULL,
    [Observacion] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Revisiones] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Roles] (
    [Id] int NOT NULL IDENTITY,
    [Descripcion] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Seguros] (
    [Id] int NOT NULL IDENTITY,
    [FkVehiculo] int NOT NULL,
    [FkTipoSeguro] int NOT NULL,
    [FechaCompra] datetime2 NOT NULL,
    [FechaVencimiento] datetime2 NOT NULL,
    CONSTRAINT [PK_Seguros] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [TipoIdentificaciones] (
    [Id] int NOT NULL IDENTITY,
    [Descripcion] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_TipoIdentificaciones] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [TipoSeguros] (
    [Id] int NOT NULL IDENTITY,
    [Descripcion] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_TipoSeguros] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [TipoVehiculos] (
    [Id] int NOT NULL IDENTITY,
    [Descripcion] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_TipoVehiculos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Vehiculos] (
    [Id] int NOT NULL IDENTITY,
    [FkPersona] int NOT NULL,
    [FkTipoVehiculo] int NOT NULL,
    [Placa] nvarchar(max) NOT NULL,
    [Modelo] nvarchar(max) NOT NULL,
    [Color] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Vehiculos] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220831044200_Initial', N'6.0.8');
GO

COMMIT;
GO

<<<<<<< HEAD
BEGIN TRANSACTION;
GO

ALTER TABLE [Vehiculos] DROP CONSTRAINT [PK_Vehiculos];
GO

ALTER TABLE [TipoVehiculos] DROP CONSTRAINT [PK_TipoVehiculos];
GO

ALTER TABLE [TipoSeguros] DROP CONSTRAINT [PK_TipoSeguros];
GO

ALTER TABLE [TipoIdentificaciones] DROP CONSTRAINT [PK_TipoIdentificaciones];
GO

ALTER TABLE [Seguros] DROP CONSTRAINT [PK_Seguros];
GO

ALTER TABLE [Roles] DROP CONSTRAINT [PK_Roles];
GO

ALTER TABLE [Revisiones] DROP CONSTRAINT [PK_Revisiones];
GO

ALTER TABLE [Personas] DROP CONSTRAINT [PK_Personas];
GO

ALTER TABLE [Generos] DROP CONSTRAINT [PK_Generos];
GO

EXEC sp_rename N'[Vehiculos]', N'Vehiculo';
GO

EXEC sp_rename N'[TipoVehiculos]', N'TipoVehiculo';
GO

EXEC sp_rename N'[TipoSeguros]', N'TipoSeguro';
GO

EXEC sp_rename N'[TipoIdentificaciones]', N'TipoIdentificacion';
GO

EXEC sp_rename N'[Seguros]', N'Seguro';
GO

EXEC sp_rename N'[Roles]', N'Rol';
GO

EXEC sp_rename N'[Revisiones]', N'Revision';
GO

EXEC sp_rename N'[Personas]', N'Persona';
GO

EXEC sp_rename N'[Generos]', N'Genero';
GO

EXEC sp_rename N'[Revision].[FKVehiculo]', N'FkVehiculo', N'COLUMN';
GO

EXEC sp_rename N'[Revision].[FKMecanico]', N'FkMecanico', N'COLUMN';
GO

ALTER TABLE [Vehiculo] ADD [CapacidadPasajeros] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [Vehiculo] ADD [CilindrajeMotor] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [Vehiculo] ADD [Marca] nvarchar(max) NOT NULL DEFAULT N'';
GO

ALTER TABLE [Vehiculo] ADD [Pais] nvarchar(max) NOT NULL DEFAULT N'';
GO

ALTER TABLE [Persona] ADD [Direccion] nvarchar(max) NOT NULL DEFAULT N'';
GO

ALTER TABLE [Persona] ADD [FechaNacimiento] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [Persona] ADD [FkGenero] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [Persona] ADD [FkNivelEstudios] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [Persona] ADD [FkRol] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [Vehiculo] ADD CONSTRAINT [PK_Vehiculo] PRIMARY KEY ([Id]);
GO

ALTER TABLE [TipoVehiculo] ADD CONSTRAINT [PK_TipoVehiculo] PRIMARY KEY ([Id]);
GO

ALTER TABLE [TipoSeguro] ADD CONSTRAINT [PK_TipoSeguro] PRIMARY KEY ([Id]);
GO

ALTER TABLE [TipoIdentificacion] ADD CONSTRAINT [PK_TipoIdentificacion] PRIMARY KEY ([Id]);
GO

ALTER TABLE [Seguro] ADD CONSTRAINT [PK_Seguro] PRIMARY KEY ([Id]);
GO

ALTER TABLE [Rol] ADD CONSTRAINT [PK_Rol] PRIMARY KEY ([Id]);
GO

ALTER TABLE [Revision] ADD CONSTRAINT [PK_Revision] PRIMARY KEY ([Id]);
GO

ALTER TABLE [Persona] ADD CONSTRAINT [PK_Persona] PRIMARY KEY ([Id]);
GO

ALTER TABLE [Genero] ADD CONSTRAINT [PK_Genero] PRIMARY KEY ([Id]);
GO

CREATE TABLE [NivelEstudio] (
    [Id] int NOT NULL IDENTITY,
    [Descripcion] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_NivelEstudio] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220906042250_Inicial', N'6.0.8');
GO

COMMIT;
GO

=======
>>>>>>> f0b14f14f7f027f842b18b3a8ea3e21dc960aa8f
