USE [master]
GO
/****** Object:  Database [Transport.Data]    Script Date: 23/09/2022 6:28:54 p. m. ******/
CREATE DATABASE [Transport.Data]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Transport.Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Transport.Data.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Transport.Data_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Transport.Data_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Transport.Data] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Transport.Data].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Transport.Data] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Transport.Data] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Transport.Data] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Transport.Data] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Transport.Data] SET ARITHABORT OFF 
GO
ALTER DATABASE [Transport.Data] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Transport.Data] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Transport.Data] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Transport.Data] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Transport.Data] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Transport.Data] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Transport.Data] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Transport.Data] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Transport.Data] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Transport.Data] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Transport.Data] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Transport.Data] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Transport.Data] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Transport.Data] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Transport.Data] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Transport.Data] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Transport.Data] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Transport.Data] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Transport.Data] SET  MULTI_USER 
GO
ALTER DATABASE [Transport.Data] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Transport.Data] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Transport.Data] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Transport.Data] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Transport.Data] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Transport.Data] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Transport.Data] SET QUERY_STORE = OFF
GO
USE [Transport.Data]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 23/09/2022 6:28:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genero]    Script Date: 23/09/2022 6:28:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genero](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Genero] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NivelEstudio]    Script Date: 23/09/2022 6:28:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NivelEstudio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_NivelEstudio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 23/09/2022 6:28:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FkTipoDocumento] [int] NOT NULL,
	[Identificacion] [int] NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Apellido] [nvarchar](max) NOT NULL,
	[FkGenero] [int] NOT NULL,
	[FkRol] [int] NOT NULL,
	[FkNivelEstudios] [int] NOT NULL,
	[FechaNacimiento] [datetime2](7) NOT NULL,
	[Telefono] [nvarchar](max) NULL,
	[Correo] [nvarchar](max) NULL,
	[Direccion] [nvarchar](max) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Revision]    Script Date: 23/09/2022 6:28:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Revision](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FkVehiculo] [int] NOT NULL,
	[FkMecanico] [int] NOT NULL,
	[NivelAceite] [nvarchar](max) NOT NULL,
	[FechaNivelAceite] [datetime2](7) NOT NULL,
	[NivelFrenos] [nvarchar](max) NOT NULL,
	[FechaNivelFrenos] [datetime2](7) NOT NULL,
	[NivelRefrigerante] [nvarchar](max) NOT NULL,
	[FechaNivelRefrigerante] [datetime2](7) NOT NULL,
	[NivelDireccion] [nvarchar](max) NOT NULL,
	[FechaNivelDireccion] [datetime2](7) NOT NULL,
	[Observacion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Revision] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 23/09/2022 6:28:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seguro]    Script Date: 23/09/2022 6:28:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seguro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FkVehiculo] [int] NOT NULL,
	[FkTipoSeguro] [int] NOT NULL,
	[FechaCompra] [datetime2](7) NOT NULL,
	[FechaVencimiento] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Seguro] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoIdentificacion]    Script Date: 23/09/2022 6:28:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoIdentificacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TipoIdentificacion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoSeguro]    Script Date: 23/09/2022 6:28:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoSeguro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TipoSeguro] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoVehiculo]    Script Date: 23/09/2022 6:28:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoVehiculo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TipoVehiculo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 23/09/2022 6:28:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FkPersona] [int] NOT NULL,
	[FkTipoVehiculo] [int] NOT NULL,
	[Placa] [nvarchar](max) NOT NULL,
	[Modelo] [nvarchar](max) NOT NULL,
	[Marca] [nvarchar](max) NOT NULL,
	[CapacidadPasajeros] [int] NOT NULL,
	[CilindrajeMotor] [nvarchar](max) NOT NULL,
	[Color] [nvarchar](max) NOT NULL,
	[Pais] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220913041433_Inicial', N'6.0.8')
GO
SET IDENTITY_INSERT [dbo].[Genero] ON 

INSERT [dbo].[Genero] ([Id], [Descripcion]) VALUES (1, N'Hombre')
INSERT [dbo].[Genero] ([Id], [Descripcion]) VALUES (2, N'Mujer')
INSERT [dbo].[Genero] ([Id], [Descripcion]) VALUES (3, N'Otro')
SET IDENTITY_INSERT [dbo].[Genero] OFF
GO
SET IDENTITY_INSERT [dbo].[NivelEstudio] ON 

INSERT [dbo].[NivelEstudio] ([Id], [Descripcion]) VALUES (2, N'Tecnico')
INSERT [dbo].[NivelEstudio] ([Id], [Descripcion]) VALUES (3, N'Tecnologo')
INSERT [dbo].[NivelEstudio] ([Id], [Descripcion]) VALUES (4, N'Profesional')
INSERT [dbo].[NivelEstudio] ([Id], [Descripcion]) VALUES (5, N'Especializacion')
INSERT [dbo].[NivelEstudio] ([Id], [Descripcion]) VALUES (6, N'Doctorado')
INSERT [dbo].[NivelEstudio] ([Id], [Descripcion]) VALUES (7, N'Bachiller')
SET IDENTITY_INSERT [dbo].[NivelEstudio] OFF
GO
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([Id], [FkTipoDocumento], [Identificacion], [Nombre], [Apellido], [FkGenero], [FkRol], [FkNivelEstudios], [FechaNacimiento], [Telefono], [Correo], [Direccion]) VALUES (1, 1, 123456789, N'Jorge', N'Bermudez B', 1, 2, 2, CAST(N'1990-08-08T00:00:00.0000000' AS DateTime2), N'65656565', N'jorge@gmail.com', N'Cartagena Cra 89')
INSERT [dbo].[Persona] ([Id], [FkTipoDocumento], [Identificacion], [Nombre], [Apellido], [FkGenero], [FkRol], [FkNivelEstudios], [FechaNacimiento], [Telefono], [Correo], [Direccion]) VALUES (2, 2, 45457878, N'Jenny', N'Atuesta', 2, 3, 3, CAST(N'1989-08-09T00:00:00.0000000' AS DateTime2), N'36363636', N'jenny@gmail.com', N'Cartagena Avenida Olaya Herrera')
INSERT [dbo].[Persona] ([Id], [FkTipoDocumento], [Identificacion], [Nombre], [Apellido], [FkGenero], [FkRol], [FkNivelEstudios], [FechaNacimiento], [Telefono], [Correo], [Direccion]) VALUES (5, 3, 12121212, N'Martha', N'Rodriguez', 2, 2, 3, CAST(N'1988-08-08T00:00:00.0000000' AS DateTime2), N'454545', N'marhtas@hotmail.com', N'Bogota')
INSERT [dbo].[Persona] ([Id], [FkTipoDocumento], [Identificacion], [Nombre], [Apellido], [FkGenero], [FkRol], [FkNivelEstudios], [FechaNacimiento], [Telefono], [Correo], [Direccion]) VALUES (7, 5, 78788956, N'Juancho', N'Santos', 1, 4, 4, CAST(N'1960-08-08T00:00:00.0000000' AS DateTime2), N'235689', N'juanchogmail.com', N'Valledupar')
INSERT [dbo].[Persona] ([Id], [FkTipoDocumento], [Identificacion], [Nombre], [Apellido], [FkGenero], [FkRol], [FkNivelEstudios], [FechaNacimiento], [Telefono], [Correo], [Direccion]) VALUES (9, 1, 123456, N'Benito Andres', N'Payares Ortega', 1, 1, 2, CAST(N'2012-12-12T00:00:00.0000000' AS DateTime2), N'656565', N'ben190@gmail.com', N'Santander')
INSERT [dbo].[Persona] ([Id], [FkTipoDocumento], [Identificacion], [Nombre], [Apellido], [FkGenero], [FkRol], [FkNivelEstudios], [FechaNacimiento], [Telefono], [Correo], [Direccion]) VALUES (10, 1, 45786598, N'Luis Manuel', N'Abel Leal', 3, 4, 6, CAST(N'1996-05-06T00:00:00.0000000' AS DateTime2), N'3014578962', N'luis@gmail.com', N'Santa Marta cra 4ta No. 123')
INSERT [dbo].[Persona] ([Id], [FkTipoDocumento], [Identificacion], [Nombre], [Apellido], [FkGenero], [FkRol], [FkNivelEstudios], [FechaNacimiento], [Telefono], [Correo], [Direccion]) VALUES (11, 1, 12121212, N'Gustavo', N'Petro Urrego', 1, 2, 7, CAST(N'1998-08-08T00:00:00.0000000' AS DateTime2), N'3698252', N'petro_cachon@gmail.com', N'Bogota cll boca perro')
INSERT [dbo].[Persona] ([Id], [FkTipoDocumento], [Identificacion], [Nombre], [Apellido], [FkGenero], [FkRol], [FkNivelEstudios], [FechaNacimiento], [Telefono], [Correo], [Direccion]) VALUES (12, 1, 784596, N'Alvaro', N'Uribe', 1, 2, 7, CAST(N'1996-05-05T00:00:00.0000000' AS DateTime2), N'666985', N'narco@gmail.com', N'Bogota barrio urb castilla')
INSERT [dbo].[Persona] ([Id], [FkTipoDocumento], [Identificacion], [Nombre], [Apellido], [FkGenero], [FkRol], [FkNivelEstudios], [FechaNacimiento], [Telefono], [Correo], [Direccion]) VALUES (13, 1, 123456, N'Joe Agu', N'Biden W', 1, 1, 2, CAST(N'1985-12-12T00:00:00.0000000' AS DateTime2), N'6565', N'joebiden@gmail.com', N'EEUU De Americas cll lobo')
SET IDENTITY_INSERT [dbo].[Persona] OFF
GO
SET IDENTITY_INSERT [dbo].[Revision] ON 

INSERT [dbo].[Revision] ([Id], [FkVehiculo], [FkMecanico], [NivelAceite], [FechaNivelAceite], [NivelFrenos], [FechaNivelFrenos], [NivelRefrigerante], [FechaNivelRefrigerante], [NivelDireccion], [FechaNivelDireccion], [Observacion]) VALUES (1, 1, 9, N'15', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'15', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'15', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'15', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'se cambio x repuesto')
SET IDENTITY_INSERT [dbo].[Revision] OFF
GO
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([Id], [Descripcion]) VALUES (1, N'Mecanico')
INSERT [dbo].[Rol] ([Id], [Descripcion]) VALUES (2, N'Dueño')
INSERT [dbo].[Rol] ([Id], [Descripcion]) VALUES (3, N'Jefe de Operaciones')
INSERT [dbo].[Rol] ([Id], [Descripcion]) VALUES (4, N'Conductor')
INSERT [dbo].[Rol] ([Id], [Descripcion]) VALUES (5, N'Auxiliar')
INSERT [dbo].[Rol] ([Id], [Descripcion]) VALUES (7, N'Contador Publico')
SET IDENTITY_INSERT [dbo].[Rol] OFF
GO
SET IDENTITY_INSERT [dbo].[Seguro] ON 

INSERT [dbo].[Seguro] ([Id], [FkVehiculo], [FkTipoSeguro], [FechaCompra], [FechaVencimiento]) VALUES (1, 1, 1, CAST(N'2022-02-03T00:00:00.0000000' AS DateTime2), CAST(N'2023-02-03T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Seguro] ([Id], [FkVehiculo], [FkTipoSeguro], [FechaCompra], [FechaVencimiento]) VALUES (2, 2, 2, CAST(N'2022-01-09T00:00:00.0000000' AS DateTime2), CAST(N'2023-01-09T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Seguro] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoIdentificacion] ON 

INSERT [dbo].[TipoIdentificacion] ([Id], [Descripcion]) VALUES (1, N'Cedula')
INSERT [dbo].[TipoIdentificacion] ([Id], [Descripcion]) VALUES (2, N'Tarjeta Identidad')
INSERT [dbo].[TipoIdentificacion] ([Id], [Descripcion]) VALUES (3, N'Cedula Extranjeria')
INSERT [dbo].[TipoIdentificacion] ([Id], [Descripcion]) VALUES (4, N'Numero de Identificacion Tributario')
INSERT [dbo].[TipoIdentificacion] ([Id], [Descripcion]) VALUES (5, N'Pasaporte')
INSERT [dbo].[TipoIdentificacion] ([Id], [Descripcion]) VALUES (8, N'Registro Civil')
INSERT [dbo].[TipoIdentificacion] ([Id], [Descripcion]) VALUES (9, N'NUIP')
SET IDENTITY_INSERT [dbo].[TipoIdentificacion] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoSeguro] ON 

INSERT [dbo].[TipoSeguro] ([Id], [Descripcion]) VALUES (1, N'SOAT')
INSERT [dbo].[TipoSeguro] ([Id], [Descripcion]) VALUES (2, N'CONTRACTUAL')
INSERT [dbo].[TipoSeguro] ([Id], [Descripcion]) VALUES (3, N'EXTRACONTRACTUAL')
SET IDENTITY_INSERT [dbo].[TipoSeguro] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoVehiculo] ON 

INSERT [dbo].[TipoVehiculo] ([Id], [Descripcion]) VALUES (1, N'Bus')
INSERT [dbo].[TipoVehiculo] ([Id], [Descripcion]) VALUES (2, N'Microbus')
INSERT [dbo].[TipoVehiculo] ([Id], [Descripcion]) VALUES (3, N'Automovil')
INSERT [dbo].[TipoVehiculo] ([Id], [Descripcion]) VALUES (4, N'Tractomula')
SET IDENTITY_INSERT [dbo].[TipoVehiculo] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehiculo] ON 

INSERT [dbo].[Vehiculo] ([Id], [FkPersona], [FkTipoVehiculo], [Placa], [Modelo], [Marca], [CapacidadPasajeros], [CilindrajeMotor], [Color], [Pais]) VALUES (1, 1, 1, N'QWE123', N'2020', N'MAZDA', 10, N'1500', N'GRIS', N'COLOMBIA')
INSERT [dbo].[Vehiculo] ([Id], [FkPersona], [FkTipoVehiculo], [Placa], [Modelo], [Marca], [CapacidadPasajeros], [CilindrajeMotor], [Color], [Pais]) VALUES (2, 11, 3, N'ASD456', N'2020', N'KENWORTH', 6, N'5000', N'ROJA', N'USA')
INSERT [dbo].[Vehiculo] ([Id], [FkPersona], [FkTipoVehiculo], [Placa], [Modelo], [Marca], [CapacidadPasajeros], [CilindrajeMotor], [Color], [Pais]) VALUES (3, 12, 1, N'YUI598', N'2020', N'FOTON', 5, N'15000', N'AMARILLA', N'VENEZUELA')
SET IDENTITY_INSERT [dbo].[Vehiculo] OFF
GO
USE [master]
GO
ALTER DATABASE [Transport.Data] SET  READ_WRITE 
GO
