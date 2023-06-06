USE [master]
GO
/****** Object:  Database [UNAN]    Script Date: 6/6/2023 15:12:45 ******/
CREATE DATABASE [UNAN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UNAN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.FELIXL\MSSQL\DATA\UNAN.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'UNAN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.FELIXL\MSSQL\DATA\UNAN_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [UNAN] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UNAN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UNAN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UNAN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UNAN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UNAN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UNAN] SET ARITHABORT OFF 
GO
ALTER DATABASE [UNAN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UNAN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UNAN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UNAN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UNAN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UNAN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UNAN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UNAN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UNAN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UNAN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UNAN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UNAN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UNAN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UNAN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UNAN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UNAN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UNAN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UNAN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UNAN] SET  MULTI_USER 
GO
ALTER DATABASE [UNAN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UNAN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UNAN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UNAN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UNAN] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'UNAN', N'ON'
GO
USE [UNAN]
GO
/****** Object:  User [Fermin]    Script Date: 6/6/2023 15:12:45 ******/
CREATE USER [Fermin] FOR LOGIN [Fermin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [FELIXL]    Script Date: 6/6/2023 15:12:45 ******/
CREATE USER [FELIXL] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Asignatura]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Asignatura](
	[IdAsignaturas] [int] IDENTITY(1,1) NOT NULL,
	[NombreA] [varchar](255) NULL,
	[CodigoA] [varchar](255) NULL,
	[IdCarreras] [int] NULL,
	[IdSemestre] [int] NULL,
	[IdTema] [int] NULL,
 CONSTRAINT [PK_Asignatura] PRIMARY KEY CLUSTERED 
(
	[IdAsignaturas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Asistencia]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Asistencia](
	[IdAsistencia] [int] IDENTITY(1,1) NOT NULL,
	[F_Entrada] [datetime] NULL,
	[F_Salida] [datetime] NULL,
	[Estado] [varchar](50) NULL,
	[Hora] [time](7) NULL,
	[Observaciones] [varchar](255) NULL,
	[IdProfesores] [int] NULL,
	[IdPlan] [int] NULL,
 CONSTRAINT [PK_Asistencia] PRIMARY KEY CLUSTERED 
(
	[IdAsistencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Carreras]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Carreras](
	[IdCarreras] [int] IDENTITY(1,1) NOT NULL,
	[NombreC] [varchar](255) NOT NULL,
	[CodigoC] [varchar](255) NULL,
	[IdModalidad] [int] NULL,
 CONSTRAINT [PK_Carreras] PRIMARY KEY CLUSTERED 
(
	[IdCarreras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Modalidad]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Modalidad](
	[IdModalidad] [int] IDENTITY(1,1) NOT NULL,
	[Modalidad] [varchar](255) NULL,
 CONSTRAINT [PK_Modalidad] PRIMARY KEY CLUSTERED 
(
	[IdModalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Modulos]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Modulos](
	[IdModulo] [int] IDENTITY(1,1) NOT NULL,
	[Modulo] [varchar](255) NULL,
 CONSTRAINT [PK_Modulos] PRIMARY KEY CLUSTERED 
(
	[IdModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[IdPermiso] [int] IDENTITY(1,1) NOT NULL,
	[IdModulo] [int] NULL,
	[IdUsuario] [int] NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[IdPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PlanDidactico]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PlanDidactico](
	[IdPlan] [int] IDENTITY(1,1) NOT NULL,
	[IdAsignatura] [int] NOT NULL,
	[AnioAcademico] [date] NOT NULL,
	[IDProfesor] [int] NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NOT NULL,
	[Objetivos] [varchar](max) NULL,
	[EstrategiaAprendizaje] [varchar](max) NULL,
	[FormaEvaluacion] [varchar](max) NULL,
	[EstrategiaEvaluacion] [varchar](max) NULL,
	[PorcentajeEvaluacion] [varchar](50) NULL,
 CONSTRAINT [PK_PlanDidactico] PRIMARY KEY CLUSTERED 
(
	[IdPlan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Profesores]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Profesores](
	[IdProfesores] [int] IDENTITY(1,1) NOT NULL,
	[NombreApellido] [varchar](255) NOT NULL,
	[CorreoP] [varchar](255) NOT NULL,
	[CelularP] [int] NOT NULL,
	[CarnetP] [varchar](50) NOT NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Profesores] PRIMARY KEY CLUSTERED 
(
	[IdProfesores] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Semestre]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Semestre](
	[IdSemestre] [int] IDENTITY(1,1) NOT NULL,
	[Semestre] [varchar](50) NULL,
 CONSTRAINT [PK_Semestre] PRIMARY KEY CLUSTERED 
(
	[IdSemestre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Temas]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Temas](
	[IdTema] [int] IDENTITY(1,1) NOT NULL,
	[Tema] [varchar](max) NULL,
	[Estado] [varchar](255) NULL,
 CONSTRAINT [PK_Temas] PRIMARY KEY CLUSTERED 
(
	[IdTema] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombresApellidos] [varchar](255) NULL,
	[Login] [varchar](255) NULL,
	[Password] [varchar](255) NULL,
	[Icono] [image] NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Asignatura]  WITH CHECK ADD  CONSTRAINT [FK_Asignatura_Carreras] FOREIGN KEY([IdCarreras])
REFERENCES [dbo].[Carreras] ([IdCarreras])
GO
ALTER TABLE [dbo].[Asignatura] CHECK CONSTRAINT [FK_Asignatura_Carreras]
GO
ALTER TABLE [dbo].[Asignatura]  WITH CHECK ADD  CONSTRAINT [FK_Asignatura_Semestre] FOREIGN KEY([IdSemestre])
REFERENCES [dbo].[Semestre] ([IdSemestre])
GO
ALTER TABLE [dbo].[Asignatura] CHECK CONSTRAINT [FK_Asignatura_Semestre]
GO
ALTER TABLE [dbo].[Asignatura]  WITH CHECK ADD  CONSTRAINT [FK_Asignatura_Temas] FOREIGN KEY([IdTema])
REFERENCES [dbo].[Temas] ([IdTema])
GO
ALTER TABLE [dbo].[Asignatura] CHECK CONSTRAINT [FK_Asignatura_Temas]
GO
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_Asistencia_PlanDidactico] FOREIGN KEY([IdPlan])
REFERENCES [dbo].[PlanDidactico] ([IdPlan])
GO
ALTER TABLE [dbo].[Asistencia] CHECK CONSTRAINT [FK_Asistencia_PlanDidactico]
GO
ALTER TABLE [dbo].[Carreras]  WITH CHECK ADD  CONSTRAINT [FK_Carreras_Modalidad] FOREIGN KEY([IdModalidad])
REFERENCES [dbo].[Modalidad] ([IdModalidad])
GO
ALTER TABLE [dbo].[Carreras] CHECK CONSTRAINT [FK_Carreras_Modalidad]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Modulos] FOREIGN KEY([IdModulo])
REFERENCES [dbo].[Modulos] ([IdModulo])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Modulos]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Usuarios]
GO
ALTER TABLE [dbo].[PlanDidactico]  WITH CHECK ADD  CONSTRAINT [FK_PlanDidactico_Asignatura] FOREIGN KEY([IdAsignatura])
REFERENCES [dbo].[Asignatura] ([IdAsignaturas])
GO
ALTER TABLE [dbo].[PlanDidactico] CHECK CONSTRAINT [FK_PlanDidactico_Asignatura]
GO
ALTER TABLE [dbo].[PlanDidactico]  WITH CHECK ADD  CONSTRAINT [FK_PlanDidactico_Profesores] FOREIGN KEY([IDProfesor])
REFERENCES [dbo].[Profesores] ([IdProfesores])
GO
ALTER TABLE [dbo].[PlanDidactico] CHECK CONSTRAINT [FK_PlanDidactico_Profesores]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarModalidad]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarModalidad]
@id INT,
@Modalidad VARCHAR(50)
AS 
UPDATE Modalidad SET  
       [Modalidad] = @Modalidad
       WHERE IdModalidad= @id

GO
/****** Object:  StoredProcedure [dbo].[BuscarModalidad]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarModalidad]
@id INT
AS 
SELECT * FROM Modalidad WHERE IdModalidad = @id

GO
/****** Object:  StoredProcedure [dbo].[EditarProfesores]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditarProfesores]
@IdProfesor int,
@NombreApellido varchar (255),
@CorreoP varchar(255),
@CelularP int,
@CarnetP varchar(50) as
update Profesores set
NombreApellido=@NombreApellido,
CorreoP=@CorreoP,
CelularP=@CelularP,
CarnetP=@CarnetP
where IdProfesores=@IdProfesor
GO
/****** Object:  StoredProcedure [dbo].[EliminarModalidad]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarModalidad]
@id INT
AS 
DELETE FROM Modalidad WHERE IdModalidad = @id

GO
/****** Object:  StoredProcedure [dbo].[EliminarProfesores]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarProfesores]
@IdProfesor int
as 
update Profesores set Estado='ELIMINADO'
where IdProfesores=@IdProfesor
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Carrera]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insertar_Carrera]
    @NombreC varchar(max),
    @CodigoC varchar(max),
    @IdModalidad int
AS
BEGIN
    -- Validar la longitud de los campos
    IF LEN(@NombreC) > 100 -- Por ejemplo, asumiendo una longitud máxima de 100 caracteres
    BEGIN
        RAISERROR('El campo NombreC excede la longitud máxima permitida.', 16, 1)
        RETURN
    END

    IF LEN(@CodigoC) > 50 -- Por ejemplo, asumiendo una longitud máxima de 50 caracteres
    BEGIN
        RAISERROR('El campo CodigoC excede la longitud máxima permitida.', 16, 1)
        RETURN
    END

    -- Validar la existencia del código
    IF EXISTS (SELECT CodigoC FROM Carreras WHERE CodigoC = @CodigoC)
    BEGIN
        RAISERROR('Ya existe un registro con este código.', 16, 1)
        RETURN
    END

    -- Validar la existencia de la modalidad
    IF NOT EXISTS (SELECT IdModalidad FROM Modalidad WHERE IdModalidad = @IdModalidad)
    BEGIN
        RAISERROR('La modalidad especificada no existe.', 16, 1)
        RETURN
    END

    -- Insertar el registro en la tabla Carreras
    INSERT INTO Carreras (NombreC, CodigoC, IdModalidad)
    VALUES (@NombreC, @CodigoC, @IdModalidad)
    
    -- Éxito
    SELECT 'Registro insertado correctamente.' AS Resultado
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarModalidad]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarModalidad] 
@Modalidad varchar(256)
as 
insert into Modalidad (Modalidad) values (@Modalidad)

GO
/****** Object:  StoredProcedure [dbo].[InsertarProfesores]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarProfesores]
@NombreApellidos varchar (255),
@CorreoP varchar(255),
@CelularP int,
@CarnetP Varchar(50)
as 
declare @Estado varchar(50)
set @Estado='ACTIVO' 
if Exists (select CarnetP from Profesores where 
CarnetP=@CarnetP)
raiserror ('Ya existe un registro con este numero de carnet',16,1)
else
insert into Profesores
values (@NombreApellidos,@CorreoP,@CelularP
,@CarnetP,@Estado)
GO
/****** Object:  StoredProcedure [dbo].[MostrarCarrera]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarCarrera]
as
Select * from Carreras
GO
/****** Object:  StoredProcedure [dbo].[MostrarCodigoC]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarCodigoC]
@Cod varchar(max)
as
select CodigoC from Carreras 
where NombreC=@Cod
GO
/****** Object:  StoredProcedure [dbo].[MostrarModalidad]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MostrarModalidad] 
AS
BEGIN
	SELECT * FROM Modalidad
END
GO
/****** Object:  StoredProcedure [dbo].[MostrarProfesores]    Script Date: 6/6/2023 15:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MostrarProfesores]
@Desde int,
@Hasta int
as
set nocount on;
select IdProfesores,NombreApellido,CorreoP,CelularP,CarnetP
from (select IdProfesores, NombreApellido, CorreoP,CelularP,CarnetP,
ROW_NUMBER() over(order by IdProfesores) 'Numero_de_fila'
from Profesores) as Paginado
where (Paginado.Numero_de_fila >=@Desde and (Paginado.Numero_de_fila <=@Hasta))
GO
USE [master]
GO
ALTER DATABASE [UNAN] SET  READ_WRITE 
GO
