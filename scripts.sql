USE [master]
GO
/****** Object:  Database [BasketApp]    Script Date: 14.01.2020 21:51:17 ******/
CREATE DATABASE [BasketApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BasketApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BasketApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BasketApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BasketApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BasketApp] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BasketApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BasketApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BasketApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BasketApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BasketApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BasketApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [BasketApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BasketApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BasketApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BasketApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BasketApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BasketApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BasketApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BasketApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BasketApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BasketApp] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BasketApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BasketApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BasketApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BasketApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BasketApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BasketApp] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [BasketApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BasketApp] SET RECOVERY FULL 
GO
ALTER DATABASE [BasketApp] SET  MULTI_USER 
GO
ALTER DATABASE [BasketApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BasketApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BasketApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BasketApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BasketApp] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BasketApp', N'ON'
GO
ALTER DATABASE [BasketApp] SET QUERY_STORE = OFF
GO
USE [BasketApp]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 14.01.2020 21:51:17 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Players]    Script Date: 14.01.2020 21:51:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Players](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImgUrl] [nvarchar](max) NULL,
	[StatsUrl] [nvarchar](max) NULL,
	[TeamId] [int] NOT NULL,
	[PositionId] [int] NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[YearOfBorn] [int] NOT NULL,
 CONSTRAINT [PK_Players] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Positions]    Script Date: 14.01.2020 21:51:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teams]    Script Date: 14.01.2020 21:51:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Location] [nvarchar](max) NOT NULL,
	[LogoUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Teams] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200113194556_InitialModel', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200113194700_RemovePeople', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200113194955_PlayerChanges', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200113211145_AddIds', N'3.1.0')
SET IDENTITY_INSERT [dbo].[Players] ON 

INSERT [dbo].[Players] ([Id], [ImgUrl], [StatsUrl], [TeamId], [PositionId], [FirstName], [LastName], [YearOfBorn]) VALUES (1, N'https://d2cwpp38twqe55.cloudfront.net/req/202001062/images/players/jamesle01.jpg', N'https://www.basketball-reference.com/players/j/jamesle01.html', 4, 3, N'LeBron', N'James', 1984)
INSERT [dbo].[Players] ([Id], [ImgUrl], [StatsUrl], [TeamId], [PositionId], [FirstName], [LastName], [YearOfBorn]) VALUES (3, N'https://d2cwpp38twqe55.cloudfront.net/req/202001062/images/players/davisan02.jpg', N'https://www.basketball-reference.com/players/d/davisan02.html', 4, 4, N'Anthony', N'Davis', 1993)
INSERT [dbo].[Players] ([Id], [ImgUrl], [StatsUrl], [TeamId], [PositionId], [FirstName], [LastName], [YearOfBorn]) VALUES (4, N'https://d2cwpp38twqe55.cloudfront.net/req/202001062/images/players/curryst01.jpg', N'https://www.basketball-reference.com/players/c/curryst01.html', 8, 1, N'Stephen', N'Curry', 1988)
INSERT [dbo].[Players] ([Id], [ImgUrl], [StatsUrl], [TeamId], [PositionId], [FirstName], [LastName], [YearOfBorn]) VALUES (7, N'https://d2cwpp38twqe55.cloudfront.net/req/202001062/images/players/walkeke02.jpg', N'https://www.basketball-reference.com/players/w/walkeke02.html', 5, 1, N'Kemba', N'Walker', 1990)
INSERT [dbo].[Players] ([Id], [ImgUrl], [StatsUrl], [TeamId], [PositionId], [FirstName], [LastName], [YearOfBorn]) VALUES (8, N'https://d2cwpp38twqe55.cloudfront.net/req/202001062/images/players/thompkl01.jpg', N'https://www.basketball-reference.com/players/t/thompkl01.html', 8, 2, N'Klay', N'Thompson', 1990)
INSERT [dbo].[Players] ([Id], [ImgUrl], [StatsUrl], [TeamId], [PositionId], [FirstName], [LastName], [YearOfBorn]) VALUES (13, N'https://d2cwpp38twqe55.cloudfront.net/req/202001062/images/players/russeda01.jpg', N'https://www.basketball-reference.com/players/r/russeda01.html', 8, 1, N'D’Angelo', N'Russell', 1996)
INSERT [dbo].[Players] ([Id], [ImgUrl], [StatsUrl], [TeamId], [PositionId], [FirstName], [LastName], [YearOfBorn]) VALUES (17, N'https://d2cwpp38twqe55.cloudfront.net/req/202001062/images/players/caldwke01.jpg', N'https://www.basketball-reference.com/players/c/caldwke01.html', 4, 2, N'Kentavious', N'Caldwell-Pope', 1993)
INSERT [dbo].[Players] ([Id], [ImgUrl], [StatsUrl], [TeamId], [PositionId], [FirstName], [LastName], [YearOfBorn]) VALUES (18, N'https://d2cwpp38twqe55.cloudfront.net/req/202001062/images/players/howardw01.jpg', N'https://www.basketball-reference.com/players/h/howardw01.html', 4, 5, N'Dwight ', N'Howard', 1985)
INSERT [dbo].[Players] ([Id], [ImgUrl], [StatsUrl], [TeamId], [PositionId], [FirstName], [LastName], [YearOfBorn]) VALUES (19, N'https://d2cwpp38twqe55.cloudfront.net/req/202001062/images/players/mcgeeja01.jpg', N'https://www.basketball-reference.com/players/m/mcgeeja01.html', 4, 5, N'JaVale ', N'McGee', 1988)
INSERT [dbo].[Players] ([Id], [ImgUrl], [StatsUrl], [TeamId], [PositionId], [FirstName], [LastName], [YearOfBorn]) VALUES (20, N'https://d2cwpp38twqe55.cloudfront.net/req/202001062/images/players/greenda02.jpg', N'https://www.basketball-reference.com/players/g/greenda02.html', 4, 2, N'Danny ', N'Green', 1987)
INSERT [dbo].[Players] ([Id], [ImgUrl], [StatsUrl], [TeamId], [PositionId], [FirstName], [LastName], [YearOfBorn]) VALUES (23, N'https://d2cwpp38twqe55.cloudfront.net/req/202001062/images/players/carusal01.jpg', N'https://www.basketball-reference.com/players/c/carusal01.html', 4, 1, N'Alex', N'Caruso', 1994)
INSERT [dbo].[Players] ([Id], [ImgUrl], [StatsUrl], [TeamId], [PositionId], [FirstName], [LastName], [YearOfBorn]) VALUES (25, N'https://d2cwpp38twqe55.cloudfront.net/req/202001062/images/players/rondora01.jpg', N'https://www.basketball-reference.com/players/r/rondora01.html', 4, 1, N'Rajon', N'Rondo', 1986)
INSERT [dbo].[Players] ([Id], [ImgUrl], [StatsUrl], [TeamId], [PositionId], [FirstName], [LastName], [YearOfBorn]) VALUES (26, N'https://d2cwpp38twqe55.cloudfront.net/req/202001062/images/players/bradlav01.jpg', N'https://www.basketball-reference.com/players/b/bradlav01.html', 4, 1, N'Avery', N'Bradley', 1990)
SET IDENTITY_INSERT [dbo].[Players] OFF
SET IDENTITY_INSERT [dbo].[Positions] ON 

INSERT [dbo].[Positions] ([Id], [Name]) VALUES (1, N'Point Guard')
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (2, N'Shooting Guard')
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (3, N'Small Forward')
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (4, N'Power Forward')
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (5, N'Center')
SET IDENTITY_INSERT [dbo].[Positions] OFF
SET IDENTITY_INSERT [dbo].[Teams] ON 

INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (4, N'Los Angeles Lakers', N'Los Angeles', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/LAL.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (5, N'Boston Celtics
', N'Boston', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/BOS.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (6, N'Brooklyn Nets
', N'New York', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/NJN.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (7, N'Chicago Bulls
', N'Chicago
', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/CHI.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (8, N'Golden State Warriors
', N'Oakland', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/GSW.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (9, N'Atlanta Hawks', N'Atlanta', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/ATL.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (10, N'Charlotte Hornets', N'Charlotte', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/CHA.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (11, N'Cleveland Cavaliers', N'Cleveland', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/CLE.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (12, N'Dallas Mavericks', N'Dallas', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/DAL.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (13, N'Denver Nuggets', N'Denver', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/DEN.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (14, N'Detroit Pistons', N'Detroit', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/DET.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (15, N'Houston Rockets', N'Texas', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/HOU.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (16, N'Indiana Pacers', N'Indiana', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/IND.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (17, N'Los Angeles Clippers', N'Los Angeles', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/LAC.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (18, N'Miami Heat', N'Miami', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/MIA.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (19, N'Milwaukee Bucks', N'Milwaukee', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/MIL.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (20, N'Minnesota Timberwolves', N'Minnesota', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/MIN.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (21, N'New Orleans Pelicans', N'New Orleans', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/NOH.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (22, N'Memphis Grizzlies', N'Memphis', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/MEM.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (23, N'New York Knicks', N'New York', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/NYK.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (24, N'Oklahoma City Thunder', N'Oklahoma', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/OKC.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (25, N'Orlando Magic', N'Orlando', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/ORL.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (26, N'Philadelphia 76ers', N'Philadelphia', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/PHI.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (27, N'Phoenix Suns', N'Phoenix', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/PHO.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (28, N'Portland Trail Blazers', N'Portland', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/POR.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (29, N'Sacramento Kings', N'Sacramento', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/SAC.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (30, N'San Antonio Spurs', N'San Antonio', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/SAS.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (31, N'Toronto Raptors', N'Toronto', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/TOR.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (32, N'Utah Jazz', N'Salt Lake City', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/UTA.png')
INSERT [dbo].[Teams] ([Id], [Name], [Location], [LogoUrl]) VALUES (33, N'Washington Wizards', N'Washington', N'https://d2p3bygnnzw9w3.cloudfront.net/req/202001101/tlogo/bbr/WAS.png')
SET IDENTITY_INSERT [dbo].[Teams] OFF
/****** Object:  Index [IX_Players_PositionId]    Script Date: 14.01.2020 21:51:17 ******/
CREATE NONCLUSTERED INDEX [IX_Players_PositionId] ON [dbo].[Players]
(
	[PositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Players_TeamId]    Script Date: 14.01.2020 21:51:17 ******/
CREATE NONCLUSTERED INDEX [IX_Players_TeamId] ON [dbo].[Players]
(
	[TeamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Players]  WITH CHECK ADD  CONSTRAINT [FK_Players_Positions_PositionId] FOREIGN KEY([PositionId])
REFERENCES [dbo].[Positions] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Players] CHECK CONSTRAINT [FK_Players_Positions_PositionId]
GO
ALTER TABLE [dbo].[Players]  WITH CHECK ADD  CONSTRAINT [FK_Players_Teams_TeamId] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Teams] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Players] CHECK CONSTRAINT [FK_Players_Teams_TeamId]
GO
USE [master]
GO
ALTER DATABASE [BasketApp] SET  READ_WRITE 
GO
