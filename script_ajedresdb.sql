USE [master]
GO
/****** Object:  Database [db_Ajedrez]    Script Date: 18/10/2019 01:23:16 ******/
CREATE DATABASE [db_Ajedrez]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_Ajedrez', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_Ajedrez.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_Ajedrez_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_Ajedrez_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_Ajedrez] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_Ajedrez].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_Ajedrez] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_Ajedrez] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_Ajedrez] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_Ajedrez] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_Ajedrez] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_Ajedrez] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_Ajedrez] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_Ajedrez] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_Ajedrez] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_Ajedrez] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_Ajedrez] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_Ajedrez] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_Ajedrez] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_Ajedrez] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_Ajedrez] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_Ajedrez] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_Ajedrez] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_Ajedrez] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_Ajedrez] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_Ajedrez] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_Ajedrez] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_Ajedrez] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_Ajedrez] SET RECOVERY FULL 
GO
ALTER DATABASE [db_Ajedrez] SET  MULTI_USER 
GO
ALTER DATABASE [db_Ajedrez] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_Ajedrez] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_Ajedrez] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_Ajedrez] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_Ajedrez] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_Ajedrez', N'ON'
GO
ALTER DATABASE [db_Ajedrez] SET QUERY_STORE = OFF
GO
USE [db_Ajedrez]
GO
/****** Object:  Table [dbo].[Juego]    Script Date: 18/10/2019 01:23:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Juego](
	[desdeX] [int] NULL,
	[dessdeY] [int] NULL,
	[hastaX] [int] NULL,
	[hastaY] [int] NULL,
	[turno] [char](1) NULL,
	[IdJuego] [int] NOT NULL,
	[fkLobby] [varchar](5) NULL,
 CONSTRAINT [PK_Juego] PRIMARY KEY CLUSTERED 
(
	[IdJuego] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lobby]    Script Date: 18/10/2019 01:23:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lobby](
	[IdLobby] [varchar](5) NOT NULL,
	[Jugador1_color] [varchar](1) NULL,
	[Jugador2_color] [varchar](1) NULL,
 CONSTRAINT [PK_Lobby] PRIMARY KEY CLUSTERED 
(
	[IdLobby] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Lobby] ([IdLobby], [Jugador1_color], [Jugador2_color]) VALUES (N'0ROW8', N'b', N'n')
INSERT [dbo].[Lobby] ([IdLobby], [Jugador1_color], [Jugador2_color]) VALUES (N'ZFN3N', N'n', N'b')
/****** Object:  StoredProcedure [dbo].[SP_CrearLobby]    Script Date: 18/10/2019 01:23:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Marcos >
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_CrearLobby]
@pIdLobby varchar(5),
@pJug1Color  varchar(1),
@pJug2Color  varchar(1)
AS
BEGIN
INSERT INTO [dbo].[Lobby]
           ([IdLobby]
           ,[Jugador1_color]
           ,[Jugador2_color])
     VALUES
           (@pIdLobby,@pJug1Color,@pJug2Color)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_UnirseALobby]    Script Date: 18/10/2019 01:23:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,Marcos,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_UnirseALobby]
	@pCodigo varchar(5)
AS
BEGIN
select Lobby.IdLobby as Codigo , Lobby.Jugador1_color as Color1, Lobby.Jugador2_color as Color2
from Lobby
where Lobby.IdLobby = @pCodigo
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ValidarCodigo]    Script Date: 18/10/2019 01:23:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ValidarCodigo]
@pCodigo varchar(5)
AS
BEGIN
SELECT [IdLobby] as Codigo
  FROM [dbo].[Lobby]
  where IdLobby != @pCodigo
end

GO
USE [master]
GO
ALTER DATABASE [db_Ajedrez] SET  READ_WRITE 
GO
