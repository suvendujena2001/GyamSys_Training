USE [master]
GO
/****** Object:  Database [AutoRepair]    Script Date: 27-03-2024 13:46:38 ******/
CREATE DATABASE [AutoRepair]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AutoRepair', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AutoRepair.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AutoRepair_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AutoRepair_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [AutoRepair] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AutoRepair].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AutoRepair] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AutoRepair] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AutoRepair] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AutoRepair] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AutoRepair] SET ARITHABORT OFF 
GO
ALTER DATABASE [AutoRepair] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AutoRepair] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AutoRepair] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AutoRepair] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AutoRepair] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AutoRepair] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AutoRepair] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AutoRepair] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AutoRepair] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AutoRepair] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AutoRepair] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AutoRepair] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AutoRepair] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AutoRepair] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AutoRepair] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AutoRepair] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AutoRepair] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AutoRepair] SET RECOVERY FULL 
GO
ALTER DATABASE [AutoRepair] SET  MULTI_USER 
GO
ALTER DATABASE [AutoRepair] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AutoRepair] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AutoRepair] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AutoRepair] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AutoRepair] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AutoRepair] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AutoRepair', N'ON'
GO
ALTER DATABASE [AutoRepair] SET QUERY_STORE = ON
GO
ALTER DATABASE [AutoRepair] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [AutoRepair]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 27-03-2024 13:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[Id] [numeric](18, 0) NOT NULL,
	[AppointmentId] [int] NOT NULL,
	[CustomerId] [int] NULL,
	[MechanicId] [int] NULL,
	[Date] [date] NULL,
	[VehicleId] [int] NULL,
	[Created_Date] [date] NULL,
	[Created_By] [int] NULL,
	[Modified_Date] [date] NULL,
	[Modified_By] [int] NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[AppointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 27-03-2024 13:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] NOT NULL,
	[Name] [int] NULL,
	[PhoneNumber] [int] NULL,
	[Email] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Created_Date] [datetime] NULL,
	[Created_By] [int] NULL,
	[Modified_Date] [datetime] NULL,
	[Modified_By] [int] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 27-03-2024 13:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[ProductName] [nchar](10) NULL,
	[Id] [nchar](10) NOT NULL,
	[Quantity] [nchar](10) NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mechanic]    Script Date: 27-03-2024 13:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mechanic](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[PhoneNumber] [int] NULL,
	[Modified_Date] [datetime] NULL,
	[Created_Date] [datetime] NULL,
	[Created_By] [int] NULL,
	[Modified_By] [int] NULL,
 CONSTRAINT [PK_Mechanic] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Report]    Script Date: 27-03-2024 13:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report](
	[Id] [int] NOT NULL,
	[TimeStarted] [datetime] NULL,
	[TimeFinished] [datetime] NULL,
	[VehicleId] [int] NULL,
	[JobsCompleted] [varchar](50) NULL,
	[MechanicId] [int] NOT NULL,
	[AppointmentId] [int] NULL,
	[CustomerId] [int] NULL,
	[GeneralComments] [varchar](max) NULL,
	[Created_Date] [datetime] NULL,
	[Created_By] [int] NULL,
	[Modified_Date] [datetime] NULL,
	[Modified_By] [int] NULL,
 CONSTRAINT [PK_Report] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 27-03-2024 13:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Active] [bit] NULL,
	[Id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 27-03-2024 13:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[Id] [int] NOT NULL,
	[Model] [varchar](50) NULL,
	[Colour] [varchar](50) NULL,
	[NumberPlate] [varchar](50) NULL,
	[FuelType] [varchar](50) NULL,
	[TransmissionType] [varchar](50) NULL,
	[Cylinders] [varchar](50) NULL,
	[Created_Date] [datetime] NULL,
	[Created_By] [int] NULL,
	[Modified_Date] [datetime] NULL,
	[Modified_By] [int] NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_Customer]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Mechanic] FOREIGN KEY([MechanicId])
REFERENCES [dbo].[Mechanic] ([Id])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_Mechanic]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Vehicle] FOREIGN KEY([VehicleId])
REFERENCES [dbo].[Vehicle] ([Id])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_Vehicle]
GO
ALTER TABLE [dbo].[Report]  WITH CHECK ADD  CONSTRAINT [FK_Report_Appointments] FOREIGN KEY([AppointmentId])
REFERENCES [dbo].[Appointments] ([AppointmentId])
GO
ALTER TABLE [dbo].[Report] CHECK CONSTRAINT [FK_Report_Appointments]
GO
ALTER TABLE [dbo].[Report]  WITH CHECK ADD  CONSTRAINT [FK_Report_Mechanic] FOREIGN KEY([MechanicId])
REFERENCES [dbo].[Mechanic] ([Id])
GO
ALTER TABLE [dbo].[Report] CHECK CONSTRAINT [FK_Report_Mechanic]
GO
ALTER TABLE [dbo].[Report]  WITH CHECK ADD  CONSTRAINT [FK_Report_Vehicle] FOREIGN KEY([VehicleId])
REFERENCES [dbo].[Vehicle] ([Id])
GO
ALTER TABLE [dbo].[Report] CHECK CONSTRAINT [FK_Report_Vehicle]
GO
USE [master]
GO
ALTER DATABASE [AutoRepair] SET  READ_WRITE 
GO
