USE [master]
GO

/****** Object:  Database [Book]    Script Date: 6/6/2019 6:18:21 PM ******/
CREATE DATABASE [Book]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Book', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Book.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Book_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Book_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [Book] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Book].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Book] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Book] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Book] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Book] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Book] SET ARITHABORT OFF 
GO

ALTER DATABASE [Book] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Book] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Book] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Book] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Book] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Book] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Book] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Book] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Book] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Book] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Book] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Book] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Book] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Book] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Book] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Book] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Book] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Book] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Book] SET  MULTI_USER 
GO

ALTER DATABASE [Book] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Book] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Book] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Book] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Book] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Book] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Book] SET  READ_WRITE 
GO
