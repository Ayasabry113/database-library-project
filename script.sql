USE [master]
GO
/****** Object:  Database [University_Library]    Script Date: 5/17/2024 7:01:54 PM ******/
CREATE DATABASE [University_Library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'University_Library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.FERO\MSSQL\DATA\University_Library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'University_Library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.FERO\MSSQL\DATA\University_Library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [University_Library] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [University_Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [University_Library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [University_Library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [University_Library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [University_Library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [University_Library] SET ARITHABORT OFF 
GO
ALTER DATABASE [University_Library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [University_Library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [University_Library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [University_Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [University_Library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [University_Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [University_Library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [University_Library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [University_Library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [University_Library] SET  DISABLE_BROKER 
GO
ALTER DATABASE [University_Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [University_Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [University_Library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [University_Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [University_Library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [University_Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [University_Library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [University_Library] SET RECOVERY FULL 
GO
ALTER DATABASE [University_Library] SET  MULTI_USER 
GO
ALTER DATABASE [University_Library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [University_Library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [University_Library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [University_Library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [University_Library] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [University_Library] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'University_Library', N'ON'
GO
ALTER DATABASE [University_Library] SET QUERY_STORE = ON
GO
ALTER DATABASE [University_Library] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [University_Library]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 5/17/2024 7:01:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[A_ID] [int] NOT NULL,
	[Salary] [float] NOT NULL,
	[Job_Title] [varchar](50) NOT NULL,
	[Supervise_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[A_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 5/17/2024 7:01:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[AID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Biography] [text] NOT NULL,
	[Nationality] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 5/17/2024 7:01:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[ISBN] [varchar](13) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Publishing_Year] [date] NOT NULL,
	[Added_byID] [int] NULL,
	[A_ID] [int] NULL,
	[P_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book_Category]    Script Date: 5/17/2024 7:01:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book_Category](
	[ISBN] [varchar](13) NOT NULL,
	[Category] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Category] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[No_Copies]    Script Date: 5/17/2024 7:01:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[No_Copies](
	[CID] [int] NOT NULL,
	[ID] [int] NOT NULL,
	[ISBN] [varchar](13) NOT NULL,
	[Statue] [varchar](12) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CID] ASC,
	[ID] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 5/17/2024 7:01:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publisher](
	[P_ID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Country] [varchar](50) NOT NULL,
	[CIty] [varchar](50) NOT NULL,
	[Street] [varchar](50) NOT NULL,
	[No_Building] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publisher_Ph_Number]    Script Date: 5/17/2024 7:01:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publisher_Ph_Number](
	[ID] [int] NOT NULL,
	[Ph_Number] [varchar](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Ph_Number] ASC,
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/17/2024 7:01:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[S_ID] [int] NOT NULL,
	[City] [varchar](50) NOT NULL,
	[No_Building] [int] NOT NULL,
	[Country] [varchar](50) NOT NULL,
	[Street] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[S_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_Ph_Number]    Script Date: 5/17/2024 7:01:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Ph_Number](
	[ID] [int] NOT NULL,
	[Ph_Number] [varchar](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Ph_Number] ASC,
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 5/17/2024 7:01:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[U_ID] [int] NOT NULL,
	[First_Name] [varchar](50) NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[E_mail] [varchar](255) NOT NULL,
	[Gender] [varchar](6) NOT NULL,
	[Password] [varchar](255) NOT NULL,
	[Age] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[U_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[E_mail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Write]    Script Date: 5/17/2024 7:01:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Write](
	[ID] [int] NOT NULL,
	[ISBN] [varchar](13) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD FOREIGN KEY([A_ID])
REFERENCES [dbo].[User] ([U_ID])
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD FOREIGN KEY([Supervise_ID])
REFERENCES [dbo].[Admin] ([A_ID])
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD FOREIGN KEY([A_ID])
REFERENCES [dbo].[Admin] ([A_ID])
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD FOREIGN KEY([Added_byID])
REFERENCES [dbo].[Admin] ([A_ID])
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD FOREIGN KEY([P_ID])
REFERENCES [dbo].[Publisher] ([P_ID])
GO
ALTER TABLE [dbo].[Book_Category]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[Book] ([ISBN])
GO
ALTER TABLE [dbo].[No_Copies]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[Student] ([S_ID])
GO
ALTER TABLE [dbo].[No_Copies]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[Book] ([ISBN])
GO
ALTER TABLE [dbo].[Publisher_Ph_Number]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[Publisher] ([P_ID])
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([S_ID])
REFERENCES [dbo].[User] ([U_ID])
GO
ALTER TABLE [dbo].[Student_Ph_Number]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[Student] ([S_ID])
GO
ALTER TABLE [dbo].[Write]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[Author] ([AID])
GO
ALTER TABLE [dbo].[Write]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[Book] ([ISBN])
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD CHECK  (([Price]>(0)))
GO
ALTER TABLE [dbo].[No_Copies]  WITH CHECK ADD CHECK  (([Statue]='Notavailable' OR [Statue]='Available'))
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD CHECK  (([Gender]='female' OR [Gender]='male'))
GO
USE [master]
GO
ALTER DATABASE [University_Library] SET  READ_WRITE 
GO
