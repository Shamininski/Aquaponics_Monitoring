USE [master]
GO
/****** Object:  Database [AquaponicsPhysioTest]    Script Date: 2018/11/19 7:02:55 PM ******/
CREATE DATABASE [AquaponicsPhysioTest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AquaponicsPhysioTest', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\AquaponicsPhysioTest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AquaponicsPhysioTest_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\AquaponicsPhysioTest_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AquaponicsPhysioTest] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AquaponicsPhysioTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AquaponicsPhysioTest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET ARITHABORT OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET RECOVERY FULL 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET  MULTI_USER 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AquaponicsPhysioTest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AquaponicsPhysioTest] SET QUERY_STORE = OFF
GO
USE [AquaponicsPhysioTest]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [AquaponicsPhysioTest]
GO
/****** Object:  Table [dbo].[tblContact]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblContact](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[SensorID] [int] NULL,
	[Email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNotification]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNotification](
	[NotifyID] [int] IDENTITY(1,1) NOT NULL,
	[SensorID] [int] NULL,
	[BottomValue] [decimal](18, 1) NOT NULL,
	[TopValue] [decimal](18, 1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NotifyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblSensor]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSensor](
	[SensorID] [int] IDENTITY(1,1) NOT NULL,
	[SensorName] [varchar](50) NOT NULL,
	[SensorLocation] [varchar](100) NOT NULL,
	[SensorType] [varchar](12) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SensorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTank_A_pH_17]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTank_A_pH_17](
	[ReadingID] [int] IDENTITY(1,1) NOT NULL,
	[ReadingDateTime] [datetime] NOT NULL,
	[ReadingVal] [decimal](18, 1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReadingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTank_A_Temperature_16]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTank_A_Temperature_16](
	[ReadingID] [int] IDENTITY(1,1) NOT NULL,
	[ReadingDateTime] [datetime] NOT NULL,
	[ReadingVal] [decimal](18, 1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReadingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUpdateFrequency]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUpdateFrequency](
	[FreqID] [int] IDENTITY(1,1) NOT NULL,
	[FreqSetDate] [datetime] NOT NULL,
	[Frequency] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FreqID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUsers]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsers](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[user_Password] [varchar](50) NOT NULL,
	[user_Email] [varchar](50) NOT NULL,
	[user_secQ] [varchar](200) NOT NULL,
	[user_secA] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tblContact]  WITH CHECK ADD FOREIGN KEY([SensorID])
REFERENCES [dbo].[tblSensor] ([SensorID])
GO
ALTER TABLE [dbo].[tblNotification]  WITH CHECK ADD FOREIGN KEY([SensorID])
REFERENCES [dbo].[tblSensor] ([SensorID])
GO
/****** Object:  StoredProcedure [dbo].[insertFrequency]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertFrequency]
(@date DATETIME,@freq INT)
AS
	BEGIN
		INSERT INTO tblUpdateFrequency(FreqSetDate,Frequency)
		VALUES (@date,@freq)
	END;


GO
/****** Object:  StoredProcedure [dbo].[insertUser]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertUser]
(@username VARCHAR(50),@password VARCHAR(50),@email VARCHAR(50),@question VARCHAR(200),@answer VARCHAR(100))
AS
	BEGIN
		INSERT INTO tblUsers(Username,user_Password,user_Email,user_secQ,user_secA)
		VALUES (@username,@password,@email,@question,@answer);
	END;


GO
/****** Object:  StoredProcedure [dbo].[newContact]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[newContact]
(@sensorID INT,@email VARCHAR(50))
AS
	BEGIN
		INSERT INTO tblContact(SensorID,Email)
		VALUES (@sensorID,@email);
	END;


GO
/****** Object:  StoredProcedure [dbo].[newNotification]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[newNotification]
(@sensorID INT,@bottomVal DECIMAL(18,1),@topVal DECIMAL(18,1))
AS
	BEGIN
		INSERT INTO tblNotification(SensorID,BottomValue,TopValue)
		VALUES (@sensorID,@bottomVal,@topVal);
	END;


GO
/****** Object:  StoredProcedure [dbo].[newSensor]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[newSensor]
(@name VARCHAR(50),@location VARCHAR(100),@type VARCHAR(12))
AS
	BEGIN
		INSERT INTO tblSensor(SensorName,SensorLocation,SensorType)
		VALUES (@name,@location,@type);
		
	END;


GO
/****** Object:  StoredProcedure [dbo].[removeContact]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[removeContact]
(@sensorId INT,@email VARCHAR(50))
AS
	BEGIN
		DELETE FROM tblContact 
		WHERE SensorID = @sensorId AND Email = @email;
	END;


GO
/****** Object:  StoredProcedure [dbo].[removeSensor]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[removeSensor]
(@sensorId INT)
AS
	BEGIN
		DELETE FROM tblNotification WHERE SensorID = @sensorId;
		DELETE FROM tblSensor WHERE SensorID = @sensorId;
	END;


GO
/****** Object:  StoredProcedure [dbo].[removeUser]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[removeUser]
(@userID INT, @username VARCHAR(50), @password VARCHAR(50), @email VARCHAR(50))
AS
	BEGIN
		DELETE FROM tblUsers 
		WHERE UserID = @userId AND user_Password = @password AND user_Email = @email ;
	END;
GO
/****** Object:  StoredProcedure [dbo].[updateContact]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateContact]
(@sensorId INT,@priorEmail VARCHAR(50),@newEmail VARCHAR(50))
AS
	BEGIN
		UPDATE tblContact SET Email = @newEmail
		WHERE SensorID = @sensorId AND Email = @priorEmail;
	END;


GO
/****** Object:  StoredProcedure [dbo].[updateNotification]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateNotification]
(@sensorID INT,@bottomVal DECIMAL(18,1),@topVal DECIMAL(18,1))
AS
	BEGIN
		UPDATE tblNotification SET BottomValue = @bottomVal,TopValue = @topVal
		WHERE SensorID = @sensorID;
	END;


GO
/****** Object:  StoredProcedure [dbo].[updateUser]    Script Date: 2018/11/19 7:02:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateUser]
(@id INT,@username VARCHAR(50),@password VARCHAR(50),@email VARCHAR(50),@question VARCHAR(200),@answer VARCHAR(100))
AS
	BEGIN
		UPDATE tblUsers SET Username = @username,user_Password = @password,user_Email = @email,user_secQ=@question,user_secA=@answer
		WHERE UserID = @id;
	END;
GO
USE [master]
GO
ALTER DATABASE [AquaponicsPhysioTest] SET  READ_WRITE 
GO
