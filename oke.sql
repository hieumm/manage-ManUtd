USE [master]
GO
/****** Object:  Database [Football]    Script Date: 11/9/2020 9:31:33 PM ******/
CREATE DATABASE [Football]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Football', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Football.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Football_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Football_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Football] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Football].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Football] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Football] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Football] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Football] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Football] SET ARITHABORT OFF 
GO
ALTER DATABASE [Football] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Football] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Football] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Football] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Football] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Football] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Football] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Football] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Football] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Football] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Football] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Football] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Football] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Football] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Football] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Football] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Football] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Football] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Football] SET  MULTI_USER 
GO
ALTER DATABASE [Football] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Football] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Football] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Football] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Football] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Football] SET QUERY_STORE = OFF
GO
USE [Football]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/9/2020 9:31:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NULL,
	[ID_player] [int] NULL,
	[Type] [nvarchar](50) NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BXH league]    Script Date: 11/9/2020 9:31:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BXH league](
	[Club name] [nvarchar](50) NULL,
	[Total number match] [int] NULL,
	[ghi ban] [int] NULL,
	[thung luoi] [nchar](10) NULL,
	[mark] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Coach]    Script Date: 11/9/2020 9:31:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coach](
	[Coach_ID] [int] IDENTITY(1,1) NOT NULL,
	[Coach_Name] [nvarchar](50) NULL,
	[Position] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[Start_join] [date] NULL,
	[End_join] [date] NULL,
	[Salary] [int] NULL,
 CONSTRAINT [PK_Coach] PRIMARY KEY CLUSTERED 
(
	[Coach_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Finance]    Script Date: 11/9/2020 9:31:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Finance](
	[Season] [nvarchar](50) NULL,
	[totalspending] [int] NULL,
	[player'stotalsalary] [int] NULL,
	[hlv total salary] [int] NULL,
	[sell players] [int] NULL,
	[buy players] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Match]    Script Date: 11/9/2020 9:31:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Match](
	[Date] [date] NOT NULL,
	[VS] [nvarchar](50) NULL,
	[Stadium] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Message]    Script Date: 11/9/2020 9:31:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Message](
	[Content] [nvarchar](max) NULL,
	[Time] [date] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Player]    Script Date: 11/9/2020 9:31:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Player](
	[ID_player] [int] IDENTITY(1,1) NOT NULL,
	[Name_player] [nvarchar](50) NULL,
	[Birthday] [date] NULL,
	[Country] [nvarchar](50) NULL,
	[Position] [nvarchar](50) NULL,
	[Clothers_number] [int] NULL,
	[Salary] [float] NULL,
	[Start_join] [date] NULL,
	[End_join] [date] NULL,
	[Img] [nvarchar](max) NULL,
 CONSTRAINT [PK_Player] PRIMARY KEY CLUSTERED 
(
	[ID_player] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Account] ([ID], [Pass], [ID_player], [Type]) VALUES (N'admin', N'admin', NULL, N'admin')
INSERT [dbo].[Account] ([ID], [Pass], [ID_player], [Type]) VALUES (N'bailly', N'123', 4, N'user')
INSERT [dbo].[Account] ([ID], [Pass], [ID_player], [Type]) VALUES (N'De Gea', N'123', 1, N'user')
INSERT [dbo].[Account] ([ID], [Pass], [ID_player], [Type]) VALUES (N'Maguire', N'1234', 8, N'user')
GO
SET IDENTITY_INSERT [dbo].[Coach] ON 

INSERT [dbo].[Coach] ([Coach_ID], [Coach_Name], [Position], [Country], [Start_join], [End_join], [Salary]) VALUES (1, N'Ole Gunnar Solskjær', N'HLV', N'Na Uy', CAST(N'2019-01-21' AS Date), CAST(N'2022-01-21' AS Date), 1000)
INSERT [dbo].[Coach] ([Coach_ID], [Coach_Name], [Position], [Country], [Start_join], [End_join], [Salary]) VALUES (3, N'Ryan Giggs', N'Support HLV', N'England', CAST(N'2019-01-21' AS Date), CAST(N'2022-01-21' AS Date), 1000)
INSERT [dbo].[Coach] ([Coach_ID], [Coach_Name], [Position], [Country], [Start_join], [End_join], [Salary]) VALUES (4, N'hieu', N'HLV', N'Viet Nam', CAST(N'2020-07-26' AS Date), CAST(N'2020-07-26' AS Date), 21312)
INSERT [dbo].[Coach] ([Coach_ID], [Coach_Name], [Position], [Country], [Start_join], [End_join], [Salary]) VALUES (5, N'Alex Ferguson1', N'HLV', N'England', CAST(N'2019-01-21' AS Date), CAST(N'2022-01-21' AS Date), 5000)
INSERT [dbo].[Coach] ([Coach_ID], [Coach_Name], [Position], [Country], [Start_join], [End_join], [Salary]) VALUES (6, N'hieumm', N'hlv', N'viet nám', CAST(N'2020-07-07' AS Date), CAST(N'2020-07-14' AS Date), 666)
INSERT [dbo].[Coach] ([Coach_ID], [Coach_Name], [Position], [Country], [Start_join], [End_join], [Salary]) VALUES (7, N'ádads', N'áddsa', N'ádasd', CAST(N'2020-07-21' AS Date), CAST(N'2020-07-22' AS Date), 324)
INSERT [dbo].[Coach] ([Coach_ID], [Coach_Name], [Position], [Country], [Start_join], [End_join], [Salary]) VALUES (9, N'fhg', N'fgh', N'dfg', CAST(N'2020-07-07' AS Date), CAST(N'2020-07-01' AS Date), 55454)
SET IDENTITY_INSERT [dbo].[Coach] OFF
GO
INSERT [dbo].[Finance] ([Season], [totalspending], [player'stotalsalary], [hlv total salary], [sell players], [buy players]) VALUES (N'1990-1991', 100, 50, 20, 11, 17)
INSERT [dbo].[Finance] ([Season], [totalspending], [player'stotalsalary], [hlv total salary], [sell players], [buy players]) VALUES (N'1991-1992', 120, 40, 20, 10, 20)
INSERT [dbo].[Finance] ([Season], [totalspending], [player'stotalsalary], [hlv total salary], [sell players], [buy players]) VALUES (N'1992-1993', 150, 60, 40, 40, 25)
INSERT [dbo].[Finance] ([Season], [totalspending], [player'stotalsalary], [hlv total salary], [sell players], [buy players]) VALUES (N'1993-1994', 200, 50, 50, 70, 70)
INSERT [dbo].[Finance] ([Season], [totalspending], [player'stotalsalary], [hlv total salary], [sell players], [buy players]) VALUES (N'1994-1995', 300, 68, 68, 68, 8)
INSERT [dbo].[Finance] ([Season], [totalspending], [player'stotalsalary], [hlv total salary], [sell players], [buy players]) VALUES (N'1994-1995', 600, 80, 80, 80, 80)
INSERT [dbo].[Finance] ([Season], [totalspending], [player'stotalsalary], [hlv total salary], [sell players], [buy players]) VALUES (N'1995-1996', 600, 80, 80, 80, 80)
INSERT [dbo].[Finance] ([Season], [totalspending], [player'stotalsalary], [hlv total salary], [sell players], [buy players]) VALUES (N'1996-1997', 500, 60, 60, 60, 60)
GO
INSERT [dbo].[Match] ([Date], [VS], [Stadium]) VALUES (CAST(N'2020-07-23' AS Date), N'West Ham', N'Olympic')
INSERT [dbo].[Match] ([Date], [VS], [Stadium]) VALUES (CAST(N'2020-10-05' AS Date), N'Newcastle', N'Old trafford')
INSERT [dbo].[Match] ([Date], [VS], [Stadium]) VALUES (CAST(N'2020-10-06' AS Date), N'Leicester', N'King power')
INSERT [dbo].[Match] ([Date], [VS], [Stadium]) VALUES (CAST(N'2020-10-06' AS Date), N'Tottenham', N'Old traford')
INSERT [dbo].[Match] ([Date], [VS], [Stadium]) VALUES (CAST(N'2020-11-08' AS Date), N'Chelse', N'Stamford Bridge')
INSERT [dbo].[Match] ([Date], [VS], [Stadium]) VALUES (CAST(N'2020-11-23' AS Date), N'Southamton', N'‎St Mary''s Stadium')
INSERT [dbo].[Match] ([Date], [VS], [Stadium]) VALUES (CAST(N'2020-12-12' AS Date), N'Man City', N'Etihad Stadium')
INSERT [dbo].[Match] ([Date], [VS], [Stadium]) VALUES (CAST(N'2020-12-18' AS Date), N'Arsenal', N'Emirates')
INSERT [dbo].[Match] ([Date], [VS], [Stadium]) VALUES (CAST(N'2020-12-27' AS Date), N'Arsenal', N'Emirates')
INSERT [dbo].[Match] ([Date], [VS], [Stadium]) VALUES (CAST(N'2020-07-28' AS Date), N'HieuCLub', N'HieuCLub')
GO
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'ahihihihasidhiashdias', CAST(N'2020-12-12' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'ádas', CAST(N'2020-07-27' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'hôm nay dá r?t hay nhé', CAST(N'2020-07-27' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'ahihihihasidhiashdias', CAST(N'2020-09-09' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'ahihihihasidhiashdias', CAST(N'2020-08-08' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'ahihihihasidhiashdias', CAST(N'2020-08-11' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'ahihihihasidhiashdias', CAST(N'2020-08-30' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'Chie^`u nay (27/7), Chu? ti?ch LÐBÐ Ðo^ng Nam A´ (AFF) Khiev Sameth dã ch? trì cu?c h?p tr?c tuy?n v?i Ban xu?? ly´ ca´c ti`nh huo^´ng kha^?n ca^´p cu?a AFF d? th?o lu?n các no?^i dung quan tro?ng lie^n quan de^´n ke^´ hoa?ch to^? chu?´c AFF Suzuki Cup 2020.

Pho´ chu? ti?ch thu?o?`ng tru??c LÐBÐVN Tra^`n Quo^´c Tua^´n da~ tham du?? va` do´ng go´p y´ kie^´n ta?i cuo?^c ho?p. Ðánh gia´ ti`nh hi`nh di?ch Covid-19 ta?i ca´c quo^´c gia Ðo^ng Nam A´, ca´c tha`nh vie^n Ban xu?? ly´ ca´c ti`nh huo^´ng kha^?n ca^´p cu?a AFF da~ co´ nhu?~ng tha?o lua?^n va` xa´c di?nh di?ch Covid-19 se~ tie^´p tu?c co´ nhu?~ng die^~n bie^´n phu?´c ta?p tu?` nay cho de^´n cuo^´i na?m. ', CAST(N'2020-07-27' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'Chua bi?t ? n? l?c s?p t?i, M.U s?n sàng tr? bao nhiêu d? d?i l?y s? ph?c v? c?a Sancho, nhung d?i di?n nu?c Ð?c dã nói rõ h? ch? ch?p nh?n d? c?u th? ch?y cánh 20 tu?i ngu?i Anh ra di n?u thu v? du?c 109 tri?u b?ng. Trong b?t k? tru?ng h?p nào, l?i d? ngh? m?i c?a M.U cung ph?i cao hon m?c giá 89 tri?u b?ng h? dua ra ban d?u.

Nhu v?y cung có nghia, n?u chua t? b? m?c tiêu mang tên Sancho thì d?i ch? sân Old Trafford ph?i ch?p nh?n b? ra s? ti?n cao hon nh?ng gì h? t?ng dùng d? chiêu m? ti?n v? Paul Pogba t? Juventus (89 tri?u b?ng). N?u thuong v? hoàn t?t, Sancho s? vu?t qua Pogba d? tr? thành c?u th? d?t giá nh?t t?ng d?u quân cho M.U.

Sancho chuy?n t? d?i tr? Man City t?i Dortmund vào nam 2017 v?i giá 8 tri?u b?ng. Dù còn r?t tr?, mùa v?a r?i c?u th? này dã gây ?n tu?ng m?nh khi ghi 20 bàn và dóng góp 20 du?ng ki?n t?o trong 44 tr?n dá cho Dortmund ? m?i sân choi. Phong phong d? tuy?t v?i nhu v?y, không ng?c nhiên khi Sancho nh?n du?c s? quan tâm c?a nhi?u d?i bóng l?n, trong dó có M.U.

Ti?n v? m?i h?t h?p d?ng v?i M.U là Angel Gomes dang có co h?i du?c sang Pháp choi bóng. Lý do là b?i BLÐ CLB Lille m?i dây dã bày t? mong mu?n du?c h?p tác v?i c?u th? 19 tu?i ngu?i Anh ch? cao v?n v?n 1m61 này. Ngoài Lille, trong danh sách các CLB dang theo du?i Gomes còn có c? Almeria cùng m?t s? d?i bóng Anh. Ðáng chú ý, n?u d?i bóng Anh nào mu?n ký h?p d?ng v?i Gomes thì h? s? ph?i tr? cho M.U m?t kho?n ti?n g?i là phí dào t?o.', CAST(N'2020-07-27' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'há', CAST(N'2020-08-30' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'chiều nay đá rất hay lẳm', CAST(N'2020-08-30' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'dsadasd', CAST(N'2020-07-28' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'dssdsdsd', CAST(N'2020-07-28' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'123', CAST(N'2020-07-28' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'123ádsad', CAST(N'2020-07-28' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'ahii hahahah', CAST(N'2020-07-29' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'ahihi goofaosshf', CAST(N'2020-07-30' AS Date))
INSERT [dbo].[Message] ([Content], [Time]) VALUES (N'Sau khi “triệu hồi” Fagan trở về trước thời hạn hợp đồng cho mượn ở Than.QN, Hải Phòng có trong tay tất cả 4 tiền đạo ngoại bồm: Mpande, Diego, Claudecir và Fagan. Do dư thừa một người nên đội bóng đất Cảng quyết định cho Than.QN mượn lại tiền đạo Claudecir, người mới chỉ có 1 bàn thắng sau 11 vòng đấu ở V.League 2020.

Claudecir từng là công thần trong chức vô địch V.League 2017 của Quảng Nam. Chân sút người Brazil được bình chọn là cầu thủ ngoại hay nhất mùa bóng năm đó. Tuy nhiên, sau khi gặp những chấn thương liên miên, Claudecir đánh mất phong độ, chỉ chơi 14 trận và ghi 4 bàn ở 2 mùa giải sau.

Đầu mùa giải 2020, Claudecir được Hải Phòng chiêu mộ nhưng màn trình diễn của anh sau 11 vòng đấu cũng không thực sự ấn tượng. Tiền đạo người Brazil thể hiện phong độ nghèo nàn với chỉ 1 bàn thắng từ đầu giải. ', CAST(N'2020-07-27' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Player] ON 

INSERT [dbo].[Player] ([ID_player], [Name_player], [Birthday], [Country], [Position], [Clothers_number], [Salary], [Start_join], [End_join], [Img]) VALUES (1, N'David de Gea', CAST(N'1990-07-11' AS Date), N'Spain     ', N'GK', 1, 2000, CAST(N'2010-01-01' AS Date), CAST(N'2020-01-01' AS Date), N'H:\Project Football Manager\image\0_de_gea_YBKT.jpg')
INSERT [dbo].[Player] ([ID_player], [Name_player], [Birthday], [Country], [Position], [Clothers_number], [Salary], [Start_join], [End_join], [Img]) VALUES (2, N'Harry Maguire', CAST(N'1993-05-03' AS Date), N'England   ', N'CB', 5, 1500, CAST(N'2015-02-20' AS Date), CAST(N'2020-02-20' AS Date), N'H:\Project Football Manager\image\5_maguire_GRAU.jpg')
INSERT [dbo].[Player] ([ID_player], [Name_player], [Birthday], [Country], [Position], [Clothers_number], [Salary], [Start_join], [End_join], [Img]) VALUES (4, N'Eric Bailly', CAST(N'1994-04-12' AS Date), N'BBN       ', N'CB', 3, 1500, CAST(N'2018-02-03' AS Date), CAST(N'2023-02-03' AS Date), N'H:\Project Football Manager\image\3_bailly_JSKV.jpg')
INSERT [dbo].[Player] ([ID_player], [Name_player], [Birthday], [Country], [Position], [Clothers_number], [Salary], [Start_join], [End_join], [Img]) VALUES (8, N'Maguire', CAST(N'2020-07-10' AS Date), N'EL', N'CB', 2, 324, CAST(N'2020-07-09' AS Date), CAST(N'2020-07-09' AS Date), N'H:\Project Football Manager\image\7_alexis_LYPZ.jpg')
INSERT [dbo].[Player] ([ID_player], [Name_player], [Birthday], [Country], [Position], [Clothers_number], [Salary], [Start_join], [End_join], [Img]) VALUES (9, N'Pogba', CAST(N'2020-07-15' AS Date), N'Spain', N'WB/RWB/LWB', 8, 324, CAST(N'2020-07-24' AS Date), CAST(N'2020-07-24' AS Date), N'H:\Project Football Manager\image\6_pogba_ELGR.jpg')
INSERT [dbo].[Player] ([ID_player], [Name_player], [Birthday], [Country], [Position], [Clothers_number], [Salary], [Start_join], [End_join], [Img]) VALUES (10, N'Mata', CAST(N'2020-07-14' AS Date), N'VN', N'LM/RM', 33, 324, CAST(N'2020-07-16' AS Date), CAST(N'2020-07-16' AS Date), N'H:\Project Football Manager\image\8_mata_QVXT.jpg')
INSERT [dbo].[Player] ([ID_player], [Name_player], [Birthday], [Country], [Position], [Clothers_number], [Salary], [Start_join], [End_join], [Img]) VALUES (11, N'Rashford', CAST(N'2020-07-14' AS Date), N'VN', N'AM', 31, 324, CAST(N'2020-07-16' AS Date), CAST(N'2020-07-16' AS Date), N'H:\Project Football Manager\image\10_rashford_YRVN.jpg')
INSERT [dbo].[Player] ([ID_player], [Name_player], [Birthday], [Country], [Position], [Clothers_number], [Salary], [Start_join], [End_join], [Img]) VALUES (12, N'Lingrad', CAST(N'2020-07-16' AS Date), N'VN', N'AM', 30, 324, CAST(N'2020-07-16' AS Date), CAST(N'2020-07-16' AS Date), N'H:\Project Football Manager\image\14_lingard_EKKB.jpg')
INSERT [dbo].[Player] ([ID_player], [Name_player], [Birthday], [Country], [Position], [Clothers_number], [Salary], [Start_join], [End_join], [Img]) VALUES (13, N'Rojo', CAST(N'2020-07-14' AS Date), N'VN', N'AM', 90, 324, CAST(N'2020-07-16' AS Date), CAST(N'2020-07-16' AS Date), N'H:\Project Football Manager\image\16_rojo_SHWP.jpg')
SET IDENTITY_INSERT [dbo].[Player] OFF
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Member_Player] FOREIGN KEY([ID_player])
REFERENCES [dbo].[Player] ([ID_player])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Member_Player]
GO
USE [master]
GO
ALTER DATABASE [Football] SET  READ_WRITE 
GO
