USE [TransportationDatabase]
GO
/****** Object:  User [userN]    Script Date: 09/23/2023 22:56:05 ******/
CREATE USER [user1] FOR LOGIN [user1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[TRANSPORTTYPE]    Script Date: 09/23/2023 22:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANSPORTTYPE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TYPE] [nvarchar](200) NULL,
 CONSTRAINT [PK_TRANSPORTTYPE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TRANSPORTTYPE] ON
INSERT [dbo].[TRANSPORTTYPE] ([ID], [TYPE]) VALUES (1, N'EVDEN EVE TAŞIMA')
INSERT [dbo].[TRANSPORTTYPE] ([ID], [TYPE]) VALUES (2, N'OFİS TAŞIMA')
INSERT [dbo].[TRANSPORTTYPE] ([ID], [TYPE]) VALUES (3, N'BÜYÜK HACİM VE AĞIRLIKTA EŞYA TAŞIMA')
SET IDENTITY_INSERT [dbo].[TRANSPORTTYPE] OFF
/****** Object:  Table [dbo].[ROLE]    Script Date: 09/23/2023 22:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ROLENAME] [nvarchar](100) NULL,
 CONSTRAINT [PK_ROLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ROLE] ON
INSERT [dbo].[ROLE] ([ID], [ROLENAME]) VALUES (1, N'KULLANICI')
INSERT [dbo].[ROLE] ([ID], [ROLENAME]) VALUES (2, N'ŞİRKET')
INSERT [dbo].[ROLE] ([ID], [ROLENAME]) VALUES (3, N'ADMIN - YÖNETİCİ')
SET IDENTITY_INSERT [dbo].[ROLE] OFF
/****** Object:  Table [dbo].[EMPLOYEETYPE]    Script Date: 09/23/2023 22:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEETYPE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TYPE] [nvarchar](100) NULL,
 CONSTRAINT [PK_EMPLOYEETYPE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EMPLOYEETYPE] ON
INSERT [dbo].[EMPLOYEETYPE] ([ID], [TYPE]) VALUES (1, N'YÖNETİM')
INSERT [dbo].[EMPLOYEETYPE] ([ID], [TYPE]) VALUES (2, N'SÜRÜCÜ')
INSERT [dbo].[EMPLOYEETYPE] ([ID], [TYPE]) VALUES (3, N'TAŞIMA EKİBİ PERSONELİ')
SET IDENTITY_INSERT [dbo].[EMPLOYEETYPE] OFF
/****** Object:  Table [dbo].[CITY]    Script Date: 09/23/2023 22:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CITY](
	[ID] [int] NOT NULL,
	[NAME] [nvarchar](100) NULL,
 CONSTRAINT [PK_CITY] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (1, N'Adana')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (2, N'Adıyaman')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (3, N'Afyonkarahisar')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (4, N'Ağrı')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (5, N'Amasya')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (6, N'Ankara')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (7, N'Antalya')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (8, N'Artvin')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (9, N'Aydın')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (10, N'Balıkesir')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (11, N'Bilecik')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (12, N'Bingöl')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (13, N'Bitlis')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (14, N'Bolu')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (15, N'Burdur')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (16, N'Bursa')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (17, N'Çanakkale')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (18, N'Çankırı')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (19, N'Çorum')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (20, N'Denizli')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (21, N'Diyarbakır')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (22, N'Edirne')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (23, N'Elazığ')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (24, N'Erzincan')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (25, N'Erzurum')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (26, N'Eskişehir')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (27, N'Gaziantep')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (28, N'Giresun')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (29, N'Gümüşhane')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (30, N'Hakkari')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (31, N'Hatay')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (32, N'Isparta')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (33, N'Mersin')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (34, N'İstanbul')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (35, N'İzmir')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (36, N'Kars')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (37, N'Kastamonu')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (38, N'Kayseri')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (39, N'Kırklareli')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (40, N'Kirşehir')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (41, N'Kocaeli')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (42, N'Konya')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (43, N'Kütahya')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (44, N'Malatya')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (45, N'Manisa')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (46, N'Kahramanmaraş')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (47, N'Mardin')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (48, N'Muğla')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (49, N'Muş')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (50, N'Nevşehir')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (51, N'Niğde')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (52, N'Ordu')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (53, N'Rize')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (54, N'Sakarya')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (55, N'Samsun')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (56, N'Siirt')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (57, N'Sinop')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (58, N'Sivas')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (59, N'Tekirdağ')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (60, N'Tokat')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (61, N'Trabzon')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (62, N'Tunceli')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (63, N'Şanlıurfa')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (64, N'Uşak')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (65, N'Van')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (66, N'Yozgat')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (67, N'Zonguldak')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (68, N'Aksaray')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (69, N'Bayburt')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (70, N'Karaman')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (71, N'Kırıkkale')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (72, N'Batman')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (73, N'Şırnak')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (74, N'Bartın')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (75, N'Ardahan')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (76, N'Iğdır')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (77, N'Yalova')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (78, N'Karabük')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (79, N'Kilis')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (80, N'Osmaniye')
INSERT [dbo].[CITY] ([ID], [NAME]) VALUES (81, N'Düzce')
/****** Object:  Table [dbo].[DISTRICT]    Script Date: 09/23/2023 22:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DISTRICT](
	[ID] [int] NOT NULL,
	[NAME] [nvarchar](100) NULL,
	[CITYID] [int] NULL,
 CONSTRAINT [PK_DISTRICT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VEHICLETYPE]    Script Date: 09/23/2023 22:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VEHICLETYPE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TYPE] [nvarchar](100) NULL,
 CONSTRAINT [PK_VEHICLETYPE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[VEHICLETYPE] ON
INSERT [dbo].[VEHICLETYPE] ([ID], [TYPE]) VALUES (1, N'TIR')
INSERT [dbo].[VEHICLETYPE] ([ID], [TYPE]) VALUES (2, N'KAMYON')
INSERT [dbo].[VEHICLETYPE] ([ID], [TYPE]) VALUES (3, N'KAMYONET')
SET IDENTITY_INSERT [dbo].[VEHICLETYPE] OFF
/****** Object:  Table [dbo].[USER]    Script Date: 09/23/2023 22:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nvarchar](100) NULL,
	[SURNAME] [nvarchar](100) NULL,
	[IDENTITYNUMBER] [nchar](11) NULL,
	[USERNAME] [nvarchar](100) NULL,
	[PASSWORD] [nvarchar](300) NULL,
	[ROLEID] [int] NULL,
	[EMAIL] [nvarchar](100) NULL,
	[TELEPHONE] [nvarchar](100) NULL,
	[GENDER] [char](1) NULL,
	[BIRTHDATE] [date] NULL,
	[ADDRESSID] [int] NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[USER] ON
INSERT [dbo].[USER] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [USERNAME], [PASSWORD], [ROLEID], [EMAIL], [TELEPHONE], [GENDER], [BIRTHDATE], [ADDRESSID]) VALUES (1, N'Neslihan', N'ATALAY', N'30814041494', N'neslihan.atalay', N'QXBwUGFzczEyMw==', 1, N'atalay.neslihan@hotmail.com', N'05320000000', N'K', CAST(0x7B160B00 AS Date), 16)
INSERT [dbo].[USER] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [USERNAME], [PASSWORD], [ROLEID], [EMAIL], [TELEPHONE], [GENDER], [BIRTHDATE], [ADDRESSID]) VALUES (2, N'A1', N'B1', N'11111111111', N'Kullanıcı1', N'MTIzdHJhbnNwb3J0NTAq', 1, N'a1.b1@gmail.com', N'05320041111', N'E', CAST(0x8A1D0B00 AS Date), 18)
INSERT [dbo].[USER] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [USERNAME], [PASSWORD], [ROLEID], [EMAIL], [TELEPHONE], [GENDER], [BIRTHDATE], [ADDRESSID]) VALUES (3, N'A2', N'B2', N'22222222222', N'Kullanıcı2', N'MzIxdHJhbnNwb3J0MDAh', 1, N'a2.b2@gmail.com', N'05320041122', N'K', CAST(0x39220B00 AS Date), 19)
SET IDENTITY_INSERT [dbo].[USER] OFF
/****** Object:  Table [dbo].[ADDRESS]    Script Date: 09/23/2023 22:56:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADDRESS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CITYID] [int] NULL,
	[TOWN] [nvarchar](100) NULL,
	[DISTRICTID] [int] NULL,
	[NEIGHBOURHOOD] [nvarchar](100) NULL,
	[STREET] [nvarchar](100) NULL,
	[HOMESTREET] [nvarchar](100) NULL,
	[BUILDINGNO] [int] NULL,
	[INNERDOORNO] [int] NULL,
 CONSTRAINT [PK_ADDRESS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMPANY]    Script Date: 09/23/2023 22:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMPANY](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nvarchar](300) NULL,
	[COMPANYUSERNAME] [nvarchar](100) NULL,
	[COMPANYPASSWORD] [nvarchar](300) NULL,
	[ROLEID] [int] NULL,
	[OWNER] [nvarchar](200) NULL,
	[TELEPHONE] [nvarchar](100) NULL,
	[FAX] [nvarchar](100) NULL,
	[EMAIL] [nvarchar](100) NULL,
	[ADDRESSID] [int] NULL,
	[ESTABLISHMENTDATE] [date] NULL,
 CONSTRAINT [PK_COMPANY] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[COMPANY] ON
INSERT [dbo].[COMPANY] ([ID], [NAME], [COMPANYUSERNAME], [COMPANYPASSWORD], [ROLEID], [OWNER], [TELEPHONE], [FAX], [EMAIL], [ADDRESSID], [ESTABLISHMENTDATE]) VALUES (1, N'LojistikX Nakliyat A.Ş.', N'firma1', N'MTIzdHJhbnNwb3J0NTAq', 2, N'Ece Ece', N'04662123003', N'03122123002', N'info@lojistikx.com', 1, CAST(0x21440B00 AS Date))
INSERT [dbo].[COMPANY] ([ID], [NAME], [COMPANYUSERNAME], [COMPANYPASSWORD], [ROLEID], [OWNER], [TELEPHONE], [FAX], [EMAIL], [ADDRESSID], [ESTABLISHMENTDATE]) VALUES (2, N'A Nakliyat Ltd Şti.', N'firma2', N'MzIxdHJhbnNwb3J0MDAh', 2, N'Xyz Vyz', N'03122120220', N'03122120221', N'info@anakliyat.com', 9, CAST(0xCE430B00 AS Date))
SET IDENTITY_INSERT [dbo].[COMPANY] OFF
/****** Object:  Table [dbo].[EMPLOYEE]    Script Date: 09/23/2023 22:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EMPLOYEE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nvarchar](100) NULL,
	[SURNAME] [nvarchar](100) NULL,
	[IDENTITYNUMBER] [nchar](11) NULL,
	[TELEPHONE] [nvarchar](100) NULL,
	[EMAIL] [nvarchar](100) NULL,
	[GENDER] [char](1) NULL,
	[BIRTHDATE] [date] NULL,
	[ADDRESSID] [int] NULL,
	[COMPANYID] [int] NULL,
	[EMPLOYEETYPEID] [int] NULL,
	[DRIVERLICENSEGROUP] [nvarchar](50) NULL,
	[DRIVERLICENSENUMBER] [nvarchar](100) NULL,
 CONSTRAINT [PK_EMPLOYEE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[EMPLOYEE] ON
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [TELEPHONE], [EMAIL], [GENDER], [BIRTHDATE], [ADDRESSID], [COMPANYID], [EMPLOYEETYPEID], [DRIVERLICENSEGROUP], [DRIVERLICENSENUMBER]) VALUES (1, N'AAA1', N'BBB1', N'12312312312', N'05372123001', N'aaa1.bbb1@lojistikx.com', N'E', CAST(0xE1040B00 AS Date), 2, 1, 2, N'E', N'1231234')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [TELEPHONE], [EMAIL], [GENDER], [BIRTHDATE], [ADDRESSID], [COMPANYID], [EMPLOYEETYPEID], [DRIVERLICENSEGROUP], [DRIVERLICENSENUMBER]) VALUES (2, N'AAA2', N'BBB2', N'12312312311', N'05372123002', N'aaa2.bbb2@lojistikx.com', N'K', CAST(0x5F0F0B00 AS Date), 3, 1, 2, N'D', N'1234123')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [TELEPHONE], [EMAIL], [GENDER], [BIRTHDATE], [ADDRESSID], [COMPANYID], [EMPLOYEETYPEID], [DRIVERLICENSEGROUP], [DRIVERLICENSENUMBER]) VALUES (3, N'AAA3', N'BBB3', N'12312312313', N'05372123003', N'aaa3.bbb3@lojistikx.com', N'E', CAST(0xB8190B00 AS Date), 4, 1, 3, N'', N'')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [TELEPHONE], [EMAIL], [GENDER], [BIRTHDATE], [ADDRESSID], [COMPANYID], [EMPLOYEETYPEID], [DRIVERLICENSEGROUP], [DRIVERLICENSENUMBER]) VALUES (4, N'AAA4', N'BBB4', N'12312312314', N'05372123004', N'aaa4.bbb4@lojistikx.com', N'E', CAST(0x1E130B00 AS Date), 5, 1, 3, N'', N'')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [TELEPHONE], [EMAIL], [GENDER], [BIRTHDATE], [ADDRESSID], [COMPANYID], [EMPLOYEETYPEID], [DRIVERLICENSEGROUP], [DRIVERLICENSENUMBER]) VALUES (5, N'AAA5', N'BBB5', N'12312312315', N'05372123005', N'aaa5.bbb5@lojistikx.com', N'E', CAST(0xB5150B00 AS Date), 4, 1, 3, N'', N'')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [TELEPHONE], [EMAIL], [GENDER], [BIRTHDATE], [ADDRESSID], [COMPANYID], [EMPLOYEETYPEID], [DRIVERLICENSEGROUP], [DRIVERLICENSENUMBER]) VALUES (6, N'AAA6', N'BBB6', N'12312312316', N'05372123006', N'aaa6.bbb6@lojistikx.com', N'E', CAST(0x61FD0A00 AS Date), 6, 1, 2, N'E', N'1234234')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [TELEPHONE], [EMAIL], [GENDER], [BIRTHDATE], [ADDRESSID], [COMPANYID], [EMPLOYEETYPEID], [DRIVERLICENSEGROUP], [DRIVERLICENSENUMBER]) VALUES (7, N'AAA7', N'BBB7', N'12312312317', N'05372123007', N'aaa7.bbb7@lojistikx.com', N'E', CAST(0x36020B00 AS Date), 7, 1, 2, N'E', N'1231235')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [TELEPHONE], [EMAIL], [GENDER], [BIRTHDATE], [ADDRESSID], [COMPANYID], [EMPLOYEETYPEID], [DRIVERLICENSEGROUP], [DRIVERLICENSENUMBER]) VALUES (8, N'AAA8', N'BBB8', N'12312312318', N'05372123008', N'aaa8.bbb8@lojistikx.com', N'E', CAST(0x10120B00 AS Date), 8, 1, 3, N'', N'')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [TELEPHONE], [EMAIL], [GENDER], [BIRTHDATE], [ADDRESSID], [COMPANYID], [EMPLOYEETYPEID], [DRIVERLICENSEGROUP], [DRIVERLICENSENUMBER]) VALUES (9, N'Ece', N'Ece', N'12312312310', N'05372123000', N'ece.ece@lojistikx.com', N'K', CAST(0x45030B00 AS Date), 10, 1, 1, N'', N'')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [TELEPHONE], [EMAIL], [GENDER], [BIRTHDATE], [ADDRESSID], [COMPANYID], [EMPLOYEETYPEID], [DRIVERLICENSEGROUP], [DRIVERLICENSENUMBER]) VALUES (10, N'Xyz', N'Vyz', N'13312312310', N'05372002000', N'xyz.vyz@anakliyat.com', N'E', CAST(0xAF000B00 AS Date), 11, 2, 1, N'', N'')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [TELEPHONE], [EMAIL], [GENDER], [BIRTHDATE], [ADDRESSID], [COMPANYID], [EMPLOYEETYPEID], [DRIVERLICENSEGROUP], [DRIVERLICENSENUMBER]) VALUES (11, N'AAA9', N'BBB9', N'12312312319', N'05372123009', N'aaa9.bbb9@lojistikx.com', N'E', CAST(0xF9080B00 AS Date), 12, 1, 3, N'', N'')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [TELEPHONE], [EMAIL], [GENDER], [BIRTHDATE], [ADDRESSID], [COMPANYID], [EMPLOYEETYPEID], [DRIVERLICENSEGROUP], [DRIVERLICENSENUMBER]) VALUES (12, N'Aaa10', N'Bbb10', N'12312312320', N'05372123011', N'aaa10.bbb10@lojistikx.com', N'E', CAST(0x76120B00 AS Date), 13, 1, 3, N'', N'')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [TELEPHONE], [EMAIL], [GENDER], [BIRTHDATE], [ADDRESSID], [COMPANYID], [EMPLOYEETYPEID], [DRIVERLICENSEGROUP], [DRIVERLICENSENUMBER]) VALUES (13, N'Aaa11', N'Bbb11', N'12312312321', N'05372123010', N'aaa11.bbb11@lojistikx.com', N'E', CAST(0xC4150B00 AS Date), 14, 1, 3, N'', N'')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [SURNAME], [IDENTITYNUMBER], [TELEPHONE], [EMAIL], [GENDER], [BIRTHDATE], [ADDRESSID], [COMPANYID], [EMPLOYEETYPEID], [DRIVERLICENSEGROUP], [DRIVERLICENSENUMBER]) VALUES (14, N'Aaa12', N'Bbb12', N'12312312322', N'05372123012', N'aaa12.bbb12@lojistikx.com', N'E', CAST(0xF1100B00 AS Date), 15, 1, 3, N'', N'')
SET IDENTITY_INSERT [dbo].[EMPLOYEE] OFF
/****** Object:  Table [dbo].[APPLICATION]    Script Date: 09/23/2023 22:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[APPLICATION](
	[ID] [int] NOT NULL,
	[USERID] [int] NULL,
	[TRANSPORTTYPEID] [int] NULL,
	[TRANSPORTDATE] [date] NULL,
	[DEPARTUREID] [int] NULL,
	[DESTINATIONID] [int] NULL,
	[WEIGHT] [decimal](18, 0) NULL,
	[DISTANCE] [decimal](18, 0) NULL,
	[PRICE] [decimal](18, 0) NULL,
 CONSTRAINT [PK_APPLICATION] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[APPLICATION] ([ID], [USERID], [TRANSPORTTYPEID], [TRANSPORTDATE], [DEPARTUREID], [DESTINATIONID], [WEIGHT], [DISTANCE], [PRICE]) VALUES (2, 1, 1, CAST(0xE9450B00 AS Date), 16, 17, CAST(6000 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[APPLICATION] ([ID], [USERID], [TRANSPORTTYPEID], [TRANSPORTDATE], [DEPARTUREID], [DESTINATIONID], [WEIGHT], [DISTANCE], [PRICE]) VALUES (3, 2, 2, CAST(0x85460B00 AS Date), 18, 20, CAST(12000 AS Decimal(18, 0)), CAST(1430 AS Decimal(18, 0)), NULL)
/****** Object:  Table [dbo].[VEHICLE]    Script Date: 09/23/2023 22:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VEHICLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PLATENUMBER] [nvarchar](100) NULL,
	[TRANSPORTTYPEID] [int] NULL,
	[VEHICLETYPEID] [int] NULL,
	[COMPANYID] [int] NULL,
	[WEIGHTCAPACITY] [decimal](18, 0) NULL,
	[UNITPRICE] [decimal](18, 0) NULL,
 CONSTRAINT [PK_VEHICLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[VEHICLE] ON
INSERT [dbo].[VEHICLE] ([ID], [PLATENUMBER], [TRANSPORTTYPEID], [VEHICLETYPEID], [COMPANYID], [WEIGHTCAPACITY], [UNITPRICE]) VALUES (1, N'08 AA 2223', 3, 1, 1, CAST(25 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)))
INSERT [dbo].[VEHICLE] ([ID], [PLATENUMBER], [TRANSPORTTYPEID], [VEHICLETYPEID], [COMPANYID], [WEIGHTCAPACITY], [UNITPRICE]) VALUES (2, N'08 AA 2123', 1, 2, 1, CAST(22 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)))
INSERT [dbo].[VEHICLE] ([ID], [PLATENUMBER], [TRANSPORTTYPEID], [VEHICLETYPEID], [COMPANYID], [WEIGHTCAPACITY], [UNITPRICE]) VALUES (3, N'08 AA 2323', 1, 3, 1, CAST(16 AS Decimal(18, 0)), CAST(8 AS Decimal(18, 0)))
INSERT [dbo].[VEHICLE] ([ID], [PLATENUMBER], [TRANSPORTTYPEID], [VEHICLETYPEID], [COMPANYID], [WEIGHTCAPACITY], [UNITPRICE]) VALUES (4, N'08 AA 2023', 2, 3, 1, CAST(14 AS Decimal(18, 0)), CAST(8 AS Decimal(18, 0)))
INSERT [dbo].[VEHICLE] ([ID], [PLATENUMBER], [TRANSPORTTYPEID], [VEHICLETYPEID], [COMPANYID], [WEIGHTCAPACITY], [UNITPRICE]) VALUES (5, N'06 AA 2023', 3, 1, 2, CAST(27 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)))
INSERT [dbo].[VEHICLE] ([ID], [PLATENUMBER], [TRANSPORTTYPEID], [VEHICLETYPEID], [COMPANYID], [WEIGHTCAPACITY], [UNITPRICE]) VALUES (6, N'06 AA 2123', 2, 2, 2, CAST(20 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)))
INSERT [dbo].[VEHICLE] ([ID], [PLATENUMBER], [TRANSPORTTYPEID], [VEHICLETYPEID], [COMPANYID], [WEIGHTCAPACITY], [UNITPRICE]) VALUES (7, N'06 AA 2223', 1, 2, 2, CAST(18 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)))
INSERT [dbo].[VEHICLE] ([ID], [PLATENUMBER], [TRANSPORTTYPEID], [VEHICLETYPEID], [COMPANYID], [WEIGHTCAPACITY], [UNITPRICE]) VALUES (8, N'06 AA 2323', 1, 3, 2, CAST(17 AS Decimal(18, 0)), CAST(9 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[VEHICLE] OFF
/****** Object:  Table [dbo].[VEHICLE_EMPLOYEE]    Script Date: 09/23/2023 22:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VEHICLE_EMPLOYEE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VEHICLEID] [int] NULL,
	[EMPLOYEEID] [int] NULL,
 CONSTRAINT [PK_VEHICLE_EMPLOYEE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[VEHICLE_EMPLOYEE] ON
INSERT [dbo].[VEHICLE_EMPLOYEE] ([ID], [VEHICLEID], [EMPLOYEEID]) VALUES (1, 1, 1)
INSERT [dbo].[VEHICLE_EMPLOYEE] ([ID], [VEHICLEID], [EMPLOYEEID]) VALUES (2, 1, 3)
INSERT [dbo].[VEHICLE_EMPLOYEE] ([ID], [VEHICLEID], [EMPLOYEEID]) VALUES (3, 1, 4)
INSERT [dbo].[VEHICLE_EMPLOYEE] ([ID], [VEHICLEID], [EMPLOYEEID]) VALUES (4, 2, 2)
INSERT [dbo].[VEHICLE_EMPLOYEE] ([ID], [VEHICLEID], [EMPLOYEEID]) VALUES (5, 2, 5)
INSERT [dbo].[VEHICLE_EMPLOYEE] ([ID], [VEHICLEID], [EMPLOYEEID]) VALUES (6, 2, 8)
INSERT [dbo].[VEHICLE_EMPLOYEE] ([ID], [VEHICLEID], [EMPLOYEEID]) VALUES (7, 3, 6)
INSERT [dbo].[VEHICLE_EMPLOYEE] ([ID], [VEHICLEID], [EMPLOYEEID]) VALUES (8, 3, 11)
INSERT [dbo].[VEHICLE_EMPLOYEE] ([ID], [VEHICLEID], [EMPLOYEEID]) VALUES (9, 3, 12)
INSERT [dbo].[VEHICLE_EMPLOYEE] ([ID], [VEHICLEID], [EMPLOYEEID]) VALUES (10, 4, 7)
INSERT [dbo].[VEHICLE_EMPLOYEE] ([ID], [VEHICLEID], [EMPLOYEEID]) VALUES (11, 4, 13)
INSERT [dbo].[VEHICLE_EMPLOYEE] ([ID], [VEHICLEID], [EMPLOYEEID]) VALUES (12, 4, 14)
SET IDENTITY_INSERT [dbo].[VEHICLE_EMPLOYEE] OFF
/****** Object:  Table [dbo].[COMMENT]    Script Date: 09/23/2023 22:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMMENT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USERID] [int] NULL,
	[APPLICATIONID] [int] NULL,
	[USERCOMMENT] [nvarchar](max) NULL,
 CONSTRAINT [PK_COMMENT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[APPLICATION_VEHICLE]    Script Date: 09/23/2023 22:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[APPLICATION_VEHICLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[APPLICATIONID] [int] NULL,
	[VEHICLEID] [int] NULL,
	[DRIVERID] [int] NULL,
 CONSTRAINT [PK_APPLICATION_VEHICLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[APPLICATION_VEHICLE] ON
INSERT [dbo].[APPLICATION_VEHICLE] ([ID], [APPLICATIONID], [VEHICLEID], [DRIVERID]) VALUES (1, 2, 3, 6)
INSERT [dbo].[APPLICATION_VEHICLE] ([ID], [APPLICATIONID], [VEHICLEID], [DRIVERID]) VALUES (2, 2, 4, 7)
INSERT [dbo].[APPLICATION_VEHICLE] ([ID], [APPLICATIONID], [VEHICLEID], [DRIVERID]) VALUES (3, 3, 1, 1)
INSERT [dbo].[APPLICATION_VEHICLE] ([ID], [APPLICATIONID], [VEHICLEID], [DRIVERID]) VALUES (4, 3, 2, 2)
SET IDENTITY_INSERT [dbo].[APPLICATION_VEHICLE] OFF
/****** Object:  ForeignKey [FK_ADDRESS_CITY]    Script Date: 09/23/2023 22:56:05 ******/
ALTER TABLE [dbo].[ADDRESS]  WITH CHECK ADD  CONSTRAINT [FK_ADDRESS_CITY] FOREIGN KEY([CITYID])
REFERENCES [dbo].[CITY] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ADDRESS] CHECK CONSTRAINT [FK_ADDRESS_CITY]
GO
/****** Object:  ForeignKey [FK_ADDRESS_DISTRICT]    Script Date: 09/23/2023 22:56:05 ******/
ALTER TABLE [dbo].[ADDRESS]  WITH CHECK ADD  CONSTRAINT [FK_ADDRESS_DISTRICT] FOREIGN KEY([DISTRICTID])
REFERENCES [dbo].[DISTRICT] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ADDRESS] CHECK CONSTRAINT [FK_ADDRESS_DISTRICT]
GO
/****** Object:  ForeignKey [FK_APPLICATION_TRANSPORTTYPE]    Script Date: 09/23/2023 22:56:05 ******/
ALTER TABLE [dbo].[APPLICATION]  WITH CHECK ADD  CONSTRAINT [FK_APPLICATION_TRANSPORTTYPE] FOREIGN KEY([TRANSPORTTYPEID])
REFERENCES [dbo].[TRANSPORTTYPE] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[APPLICATION] CHECK CONSTRAINT [FK_APPLICATION_TRANSPORTTYPE]
GO
/****** Object:  ForeignKey [FK_APPLICATION_USER]    Script Date: 09/23/2023 22:56:05 ******/
ALTER TABLE [dbo].[APPLICATION]  WITH CHECK ADD  CONSTRAINT [FK_APPLICATION_USER] FOREIGN KEY([USERID])
REFERENCES [dbo].[USER] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[APPLICATION] CHECK CONSTRAINT [FK_APPLICATION_USER]
GO
/****** Object:  ForeignKey [FK_APPLICATION_VEHICLE_APPLICATION]    Script Date: 09/23/2023 22:56:05 ******/
ALTER TABLE [dbo].[APPLICATION_VEHICLE]  WITH CHECK ADD  CONSTRAINT [FK_APPLICATION_VEHICLE_APPLICATION] FOREIGN KEY([APPLICATIONID])
REFERENCES [dbo].[APPLICATION] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[APPLICATION_VEHICLE] CHECK CONSTRAINT [FK_APPLICATION_VEHICLE_APPLICATION]
GO
/****** Object:  ForeignKey [FK_COMMENT_APPLICATION]    Script Date: 09/23/2023 22:56:05 ******/
ALTER TABLE [dbo].[COMMENT]  WITH CHECK ADD  CONSTRAINT [FK_COMMENT_APPLICATION] FOREIGN KEY([APPLICATIONID])
REFERENCES [dbo].[APPLICATION] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[COMMENT] CHECK CONSTRAINT [FK_COMMENT_APPLICATION]
GO
/****** Object:  ForeignKey [FK_COMPANY_ROLE]    Script Date: 09/23/2023 22:56:05 ******/
ALTER TABLE [dbo].[COMPANY]  WITH CHECK ADD  CONSTRAINT [FK_COMPANY_ROLE] FOREIGN KEY([ROLEID])
REFERENCES [dbo].[ROLE] ([ID])
GO
ALTER TABLE [dbo].[COMPANY] CHECK CONSTRAINT [FK_COMPANY_ROLE]
GO
/****** Object:  ForeignKey [FK_EMPLOYEE_COMPANY]    Script Date: 09/23/2023 22:56:05 ******/
ALTER TABLE [dbo].[EMPLOYEE]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYEE_COMPANY] FOREIGN KEY([COMPANYID])
REFERENCES [dbo].[COMPANY] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EMPLOYEE] CHECK CONSTRAINT [FK_EMPLOYEE_COMPANY]
GO
/****** Object:  ForeignKey [FK_EMPLOYEE_EMPLOYEETYPE]    Script Date: 09/23/2023 22:56:05 ******/
ALTER TABLE [dbo].[EMPLOYEE]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYEE_EMPLOYEETYPE] FOREIGN KEY([EMPLOYEETYPEID])
REFERENCES [dbo].[EMPLOYEETYPE] ([ID])
GO
ALTER TABLE [dbo].[EMPLOYEE] CHECK CONSTRAINT [FK_EMPLOYEE_EMPLOYEETYPE]
GO
/****** Object:  ForeignKey [FK_USER_ROLE]    Script Date: 09/23/2023 22:56:05 ******/
ALTER TABLE [dbo].[USER]  WITH CHECK ADD  CONSTRAINT [FK_USER_ROLE] FOREIGN KEY([ROLEID])
REFERENCES [dbo].[ROLE] ([ID])
GO
ALTER TABLE [dbo].[USER] CHECK CONSTRAINT [FK_USER_ROLE]
GO
/****** Object:  ForeignKey [FK_VEHICLE_COMPANY]    Script Date: 09/23/2023 22:56:05 ******/
ALTER TABLE [dbo].[VEHICLE]  WITH CHECK ADD  CONSTRAINT [FK_VEHICLE_COMPANY] FOREIGN KEY([COMPANYID])
REFERENCES [dbo].[COMPANY] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VEHICLE] CHECK CONSTRAINT [FK_VEHICLE_COMPANY]
GO
/****** Object:  ForeignKey [FK_VEHICLE_TRANSPORTTYPE]    Script Date: 09/23/2023 22:56:05 ******/
ALTER TABLE [dbo].[VEHICLE]  WITH CHECK ADD  CONSTRAINT [FK_VEHICLE_TRANSPORTTYPE] FOREIGN KEY([TRANSPORTTYPEID])
REFERENCES [dbo].[TRANSPORTTYPE] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VEHICLE] CHECK CONSTRAINT [FK_VEHICLE_TRANSPORTTYPE]
GO
/****** Object:  ForeignKey [FK_VEHICLE_VEHICLETYPE]    Script Date: 09/23/2023 22:56:05 ******/
ALTER TABLE [dbo].[VEHICLE]  WITH CHECK ADD  CONSTRAINT [FK_VEHICLE_VEHICLETYPE] FOREIGN KEY([VEHICLETYPEID])
REFERENCES [dbo].[VEHICLETYPE] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VEHICLE] CHECK CONSTRAINT [FK_VEHICLE_VEHICLETYPE]
GO
/****** Object:  ForeignKey [FK_VEHICLE_EMPLOYEE_EMPLOYEE]    Script Date: 09/23/2023 22:56:05 ******/
ALTER TABLE [dbo].[VEHICLE_EMPLOYEE]  WITH CHECK ADD  CONSTRAINT [FK_VEHICLE_EMPLOYEE_EMPLOYEE] FOREIGN KEY([EMPLOYEEID])
REFERENCES [dbo].[EMPLOYEE] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VEHICLE_EMPLOYEE] CHECK CONSTRAINT [FK_VEHICLE_EMPLOYEE_EMPLOYEE]
GO
