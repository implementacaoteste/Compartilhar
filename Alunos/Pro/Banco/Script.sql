USE [master]
GO
/****** Object:  Database [SAEP2023]    Script Date: 20/06/2023 19:40:33 ******/
IF(EXISTS(SELECT 1 FROM SYS.DATABASES WHERE NAME = 'SAEP2023'))
BEGIN
	ALTER DATABASE SAEP2023 SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
	DROP DATABASE SAEP2023
END
GO
CREATE DATABASE SAEP2023
GO
USE SAEP2023
GO
ALTER DATABASE [SAEP2023] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SAEP2023].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SAEP2023] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SAEP2023] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SAEP2023] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SAEP2023] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SAEP2023] SET ARITHABORT OFF 
GO
ALTER DATABASE [SAEP2023] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SAEP2023] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SAEP2023] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SAEP2023] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SAEP2023] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SAEP2023] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SAEP2023] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SAEP2023] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SAEP2023] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SAEP2023] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SAEP2023] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SAEP2023] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SAEP2023] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SAEP2023] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SAEP2023] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SAEP2023] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SAEP2023] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SAEP2023] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SAEP2023] SET  MULTI_USER 
GO
ALTER DATABASE [SAEP2023] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SAEP2023] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SAEP2023] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SAEP2023] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SAEP2023] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SAEP2023] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SAEP2023] SET QUERY_STORE = OFF
GO
USE [SAEP2023]
GO
/****** Object:  Table [dbo].[alocacao]    Script Date: 20/06/2023 19:40:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alocacao](
	[id] [int] NOT NULL,
	[area] [int] NOT NULL,
	[automovel] [int] NOT NULL,
	[concessionaria] [int] NOT NULL,
	[quantidade] [int] NOT NULL,
 CONSTRAINT [PK_alocacao] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[automoveis]    Script Date: 20/06/2023 19:40:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[automoveis](
	[id] [int] NOT NULL,
	[modelo] [varchar](150) NOT NULL,
	[preco] [float] NOT NULL,
 CONSTRAINT [PK_automoveis] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 20/06/2023 19:40:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[Id] [int] NOT NULL,
	[Nome] [varchar](150) NOT NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[concessionarias]    Script Date: 20/06/2023 19:40:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[concessionarias](
	[id] [int] NOT NULL,
	[concessionaria] [varchar](150) NOT NULL,
 CONSTRAINT [PK_concessionarias] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venda]    Script Date: 20/06/2023 19:40:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venda](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[automovel] [int] NULL,
	[cliente] [int] NULL,
	[concessionaria] [int] NULL,
	[area] [int] NULL,
	[alocacao] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[alocacao]  WITH CHECK ADD  CONSTRAINT [FK_alocacao_automoveis] FOREIGN KEY([automovel])
REFERENCES [dbo].[automoveis] ([id])
GO
ALTER TABLE [dbo].[alocacao] CHECK CONSTRAINT [FK_alocacao_automoveis]
GO
ALTER TABLE [dbo].[alocacao]  WITH CHECK ADD  CONSTRAINT [FK_alocacao_concessionarias] FOREIGN KEY([concessionaria])
REFERENCES [dbo].[concessionarias] ([id])
GO
ALTER TABLE [dbo].[alocacao] CHECK CONSTRAINT [FK_alocacao_concessionarias]
GO
USE [master]
GO
ALTER DATABASE [SAEP2023] SET  READ_WRITE 
GO
USE SAEP2023

GO
INSERT INTO automoveis(id, modelo, preco)VALUES(1, 'Fiat Strada', 43115)
INSERT INTO automoveis(id, modelo, preco)VALUES(2, 'Fiat Argo', 47660)
INSERT INTO automoveis(id, modelo, preco)VALUES(3, 'Fiat Mobi', 32102)
INSERT INTO automoveis(id, modelo, preco)VALUES(4, 'Jeep Compass', 34950)
INSERT INTO automoveis(id, modelo, preco)VALUES(5, 'Hyundai HB20', 49302)
INSERT INTO automoveis(id, modelo, preco)VALUES(6, 'Jeep Renegade', 36661)
INSERT INTO automoveis(id, modelo, preco)VALUES(7, 'Volkswagen T-Cross', 38182)
INSERT INTO automoveis(id, modelo, preco)VALUES(8, 'Fiat Toro', 57733)
INSERT INTO automoveis(id, modelo, preco)VALUES(9, 'Hyundai Creta', 55998)
INSERT INTO automoveis(id, modelo, preco)VALUES(10, 'Chevrolet S10', 51035)
INSERT INTO automoveis(id, modelo, preco)VALUES(11, 'Toyota Corolla Cross', 34544)
INSERT INTO automoveis(id, modelo, preco)VALUES(12, 'Toyota Hilux', 53937)
INSERT INTO automoveis(id, modelo, preco)VALUES(13, 'Toyota Corolla', 55022)
INSERT INTO automoveis(id, modelo, preco)VALUES(14, 'Volkswagen Gol', 48253)
INSERT INTO automoveis(id, modelo, preco)VALUES(15, 'Honda HR-V', 53438)
INSERT INTO automoveis(id, modelo, preco)VALUES(16, 'Renault Kwid', 31810)
INSERT INTO automoveis(id, modelo, preco)VALUES(17, 'Volkswagen Nivus', 35104)
INSERT INTO automoveis(id, modelo, preco)VALUES(18, 'Hyundai HB20S', 31855)
INSERT INTO automoveis(id, modelo, preco)VALUES(19, 'Ford Ranger', 48927)
INSERT INTO automoveis(id, modelo, preco)VALUES(20, 'Fiat Uno', 38111)
INSERT INTO automoveis(id, modelo, preco)VALUES(21, 'Fiat Cronos', 36515)
INSERT INTO automoveis(id, modelo, preco)VALUES(22, 'Citroën C4 Cactus', 53654)
INSERT INTO automoveis(id, modelo, preco)VALUES(23, 'Toyota Yaris Hatchback', 55869)
INSERT INTO automoveis(id, modelo, preco)VALUES(24, 'Volkswagen Voyage', 30954)
INSERT INTO automoveis(id, modelo, preco)VALUES(25, 'Honda Civic', 30871)
INSERT INTO automoveis(id, modelo, preco)VALUES(26, 'Volkswagen Saveiro', 32306)
INSERT INTO automoveis(id, modelo, preco)VALUES(27, 'Caoa Chery Tiggo 5x', 30069)
INSERT INTO automoveis(id, modelo, preco)VALUES(28, 'Volkswagen Virtus', 40689)
INSERT INTO automoveis(id, modelo, preco)VALUES(29, 'Fiat Grand Siena', 33469)
INSERT INTO automoveis(id, modelo, preco)VALUES(30, 'Caoa Chery Tiggo 8', 48481)
INSERT INTO automoveis(id, modelo, preco)VALUES(31, 'Chevrolet Tracker', 30648)
INSERT INTO automoveis(id, modelo, preco)VALUES(32, 'Peugeot 208', 46934)
INSERT INTO automoveis(id, modelo, preco)VALUES(33, 'Toyota SW4', 54252)
INSERT INTO automoveis(id, modelo, preco)VALUES(34, 'Nissan Frontier', 32596)
INSERT INTO automoveis(id, modelo, preco)VALUES(35, 'Honda WR-V', 35139)
INSERT INTO automoveis(id, modelo, preco)VALUES(36, 'Volkswagen Taos', 47546)
INSERT INTO automoveis(id, modelo, preco)VALUES(37, 'Mitsubishi L200', 57049)
INSERT INTO automoveis(id, modelo, preco)VALUES(38, 'Renault Oroch', 48756)
INSERT INTO automoveis(id, modelo, preco)VALUES(39, 'Toyota Yaris Sedan', 43077)
INSERT INTO automoveis(id, modelo, preco)VALUES(40, 'Renault Duster', 52641)

GO

INSERT INTO clientes(id, nome)VALUES(1, 'Adalberto Martins da Silva')
INSERT INTO clientes(id, nome)VALUES(2, 'Adan Roger Guimarães Dias')
INSERT INTO clientes(id, nome)VALUES(3, 'Adão Walter Gomes de Sousa')
INSERT INTO clientes(id, nome)VALUES(4, 'Adelson Fernandes Sena')
INSERT INTO clientes(id, nome)VALUES(5, 'Ademir Augusto Simões')
INSERT INTO clientes(id, nome)VALUES(6, 'Ademir Borges dos Santos')
INSERT INTO clientes(id, nome)VALUES(7, 'Adilio José da Silva Santos')
INSERT INTO clientes(id, nome)VALUES(8, 'Adriana Ferreira de Lima Teodoro')
INSERT INTO clientes(id, nome)VALUES(9, 'Adriano Bezerra Apolinario')
INSERT INTO clientes(id, nome)VALUES(10, 'Adriano Heleno Basso')
INSERT INTO clientes(id, nome)VALUES(11, 'Adriano Lourenço do Rego')
INSERT INTO clientes(id, nome)VALUES(12, 'Adriano Matos Santos')
INSERT INTO clientes(id, nome)VALUES(13, 'Adriano Pires Caetano')
INSERT INTO clientes(id, nome)VALUES(14, 'Adriano Prada de Campos')
INSERT INTO clientes(id, nome)VALUES(15, 'Adriel Alberto dos Santos')
INSERT INTO clientes(id, nome)VALUES(16, 'Agner Vinicius Marques de Camargo')
INSERT INTO clientes(id, nome)VALUES(17, 'Agrinaldo Ferreira Soares')
INSERT INTO clientes(id, nome)VALUES(18, 'Alan Jhonnes Banlian da Silva e Sá')
INSERT INTO clientes(id, nome)VALUES(19, 'Alberto Ramos Rodrigues')
INSERT INTO clientes(id, nome)VALUES(20, 'Alcides José Ramos')
INSERT INTO clientes(id, nome)VALUES(21, 'Aldemir SantAna dos Santos')
INSERT INTO clientes(id, nome)VALUES(22, 'Aleksandro Marcelo da Silva')
INSERT INTO clientes(id, nome)VALUES(23, 'Alessandro Martins Silva')
INSERT INTO clientes(id, nome)VALUES(24, 'Alessandro Sanches')
INSERT INTO clientes(id, nome)VALUES(25, 'Alex dos Reis de Jesus')
INSERT INTO clientes(id, nome)VALUES(26, 'Alex Ferreira Soares')
INSERT INTO clientes(id, nome)VALUES(27, 'Alex Sandro Oliveira')
INSERT INTO clientes(id, nome)VALUES(28, 'Alex Souza Farias')
INSERT INTO clientes(id, nome)VALUES(29, 'Alexandra de Lima Silva')
INSERT INTO clientes(id, nome)VALUES(30, 'Alexandre Clemente da Costa')

GO
INSERT INTO concessionarias(id, concessionaria)VALUES(1, 'Atena concessionária')
INSERT INTO concessionarias(id, concessionaria)VALUES(2, 'Demétir concessionária')
INSERT INTO concessionarias(id, concessionaria)VALUES(3, 'Hera concessionária')
INSERT INTO concessionarias(id, concessionaria)VALUES(4, 'Estia concessionária')
INSERT INTO concessionarias(id, concessionaria)VALUES(5, 'Perséfone concessionária')

GO
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(1,1,1,1,8)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(2,2,2,2,1)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(3,4,3,3,4)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(4,7,4,4,6)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(5,8,5,5,4)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(6,9,6,1,4)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(7,10,7,2,1)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(8,1,8,2,7)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(9,2,9,3,2)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(10,4,10,4,6)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(11,7,11,5,3)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(12,8,12,1,9)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(13,9,13,2,9)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(14,10,14,3,6)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(15,1,15,3,4)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(16,2,16,4,1)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(17,4,17,5,8)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(18,7,18,1,4)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(19,8,19,2,10)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(20,9,20,3,10)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(21,10,21,4,7)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(22,1,22,4,3)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(23,2,23,5,5)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(24,4,24,1,4)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(25,7,25,2,3)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(26,8,26,3,3)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(27,9,27,4,10)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(28,10,28,5,4)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(29,1,29,1,2)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(30,2,30,2,3)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(31,4,31,3,4)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(32,7,32,4,2)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(33,8,33,5,3)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(34,9,34,1,4)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(35,10,35,2,3)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(36,1,36,3,2)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(37,2,37,4,3)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(38,4,38,5,3)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(39,7,39,1,2)
INSERT INTO alocacao(id, area, automovel, concessionaria, quantidade)VALUES(40,8,40,2,1)
