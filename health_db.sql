USE [health_db]
GO
/****** Object:  Table [dbo].[Citizen]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citizen](
	[SSN] [int] NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Address] [nchar](50) NOT NULL,
	[Phone] [nchar](20) NOT NULL,
	[Govenment_Insurance_ID] [int] NULL,
 CONSTRAINT [PK_Citizen] PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citizen_Clinic]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citizen_Clinic](
	[Doctor_SSN] [int] NOT NULL,
	[Address] [nchar](50) NOT NULL,
	[Citizen_SSN] [int] NOT NULL,
	[Rate] [int] NOT NULL,
 CONSTRAINT [PK_Citizen_Clinic] PRIMARY KEY CLUSTERED 
(
	[Doctor_SSN] ASC,
	[Address] ASC,
	[Citizen_SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citizen_Hospitals]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citizen_Hospitals](
	[Citizen_SSN] [int] NOT NULL,
	[Hospita_ID] [int] NOT NULL,
	[DSSN] [int] NULL,
	[Rate] [int] NOT NULL,
 CONSTRAINT [PK_Citizen_Hospitals] PRIMARY KEY CLUSTERED 
(
	[Citizen_SSN] ASC,
	[Hospita_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citizen_Medicine]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citizen_Medicine](
	[Citizen_SSN] [int] NOT NULL,
	[Medicine_ID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[date_end] [date] NULL,
 CONSTRAINT [PK_Citizen_Medicine] PRIMARY KEY CLUSTERED 
(
	[Citizen_SSN] ASC,
	[Medicine_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citizen_Pharmacy]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citizen_Pharmacy](
	[Citize_SSN] [int] NOT NULL,
	[Pharmacy_ID] [int] NOT NULL,
	[Doctor_SSN] [int] NULL,
	[Rate] [int] NULL,
 CONSTRAINT [PK_Citizen_Pharmacy] PRIMARY KEY CLUSTERED 
(
	[Citize_SSN] ASC,
	[Pharmacy_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citizen_Treatment]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citizen_Treatment](
	[Citizen_SSN] [int] NOT NULL,
	[DSSN] [int] NULL,
	[Rate] [int] NOT NULL,
 CONSTRAINT [PK_Citizen_Treatment] PRIMARY KEY CLUSTERED 
(
	[Citizen_SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clinic]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clinic](
	[Doctor_SSN] [int] NOT NULL,
	[Address] [nchar](50) NOT NULL,
	[Phone] [nchar](20) NOT NULL,
	[Specialization] [nchar](50) NULL,
 CONSTRAINT [PK_Clinic] PRIMARY KEY CLUSTERED 
(
	[Doctor_SSN] ASC,
	[Address] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conflict_Medicine]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conflict_Medicine](
	[Medicine_ID] [int] NOT NULL,
	[Confluct_ID] [int] NOT NULL,
 CONSTRAINT [PK_Conflict_Medicine] PRIMARY KEY CLUSTERED 
(
	[Medicine_ID] ASC,
	[Confluct_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Disease]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disease](
	[Name] [nchar](50) NOT NULL,
	[Citizen_SSN] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NULL,
 CONSTRAINT [PK_Disease] PRIMARY KEY CLUSTERED 
(
	[Name] ASC,
	[Citizen_SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[SSN] [int] NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Address] [nchar](50) NOT NULL,
	[Phone] [nchar](20) NOT NULL,
	[Specialization] [nchar](50) NULL,
	[Government_ID] [int] NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Governmen_Hospitals]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Governmen_Hospitals](
	[Hospital_ID] [int] NOT NULL,
	[Government_ID] [int] NOT NULL,
 CONSTRAINT [PK_Governmen_Hospitals_1] PRIMARY KEY CLUSTERED 
(
	[Hospital_ID] ASC,
	[Government_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Government_Insurance]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Government_Insurance](
	[ID] [int] NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[Phone] [nchar](20) NOT NULL,
	[Address] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Government_Insurance] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Government_Medicine]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Government_Medicine](
	[Medicine_ID] [int] NOT NULL,
	[Governmnet_ID] [int] NOT NULL,
 CONSTRAINT [PK_Government_Medicine] PRIMARY KEY CLUSTERED 
(
	[Medicine_ID] ASC,
	[Governmnet_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hospita_Employee]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospita_Employee](
	[Doctor_SSN] [int] NOT NULL,
	[Hospital_ID] [int] NOT NULL,
	[Rate] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hospital]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital](
	[ID] [int] NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[Phone] [nchar](20) NOT NULL,
	[Manager] [nchar](50) NOT NULL,
	[Address] [nchar](50) NOT NULL,
	[Specialization] [nchar](50) NULL,
 CONSTRAINT [PK_Hospital] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicines]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicines](
	[ID] [int] NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[Active_Ingredient] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Medicines] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pharmacist]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pharmacist](
	[SSN] [int] NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Phone] [nchar](20) NOT NULL,
	[Address] [nchar](50) NOT NULL,
	[Specialization] [nchar](50) NULL,
 CONSTRAINT [PK_Pharmacist] PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pharmacy]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pharmacy](
	[ID] [int] NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[Phone] [nchar](20) NOT NULL,
	[Owner_SSN] [int] NOT NULL,
 CONSTRAINT [PK_Pharmacy] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pharmacy_Address]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pharmacy_Address](
	[Pharmacy_ID] [int] NULL,
	[Address] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pharmacy_Medicine]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pharmacy_Medicine](
	[Pharmacy_ID] [int] NOT NULL,
	[Medicine_ID] [int] NOT NULL,
 CONSTRAINT [PK_Pharmacy_Medicine] PRIMARY KEY CLUSTERED 
(
	[Pharmacy_ID] ASC,
	[Medicine_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[priv_lvl_name]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[priv_lvl_name](
	[priv_lvl] [int] NOT NULL,
	[role_name] [nvarchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Username] [varchar](50) NOT NULL,
	[pass_hash] [varchar](256) NOT NULL,
	[Priv] [int] NOT NULL,
	[SSN] [int] NULL,
	[email] [varchar](256) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[admins_info]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[admins_info] AS
SELECT SSN, Username, role_name, email
FROM Users
INNER JOIN priv_lvl_name ON Users.Priv = priv_lvl_name.priv_lvl;
GO
/****** Object:  View [dbo].[citizens_info]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[citizens_info] AS
SELECT SSN, Citizen.Name, BirthDate, Citizen.Address, Citizen.Phone, Government_Insurance.Address AS [GOV INSU ADDRESS], Government_Insurance.Name AS [GOV INSU NAME]
FROM Citizen
LEFT OUTER JOIN Government_Insurance
ON Citizen.Govenment_Insurance_ID = Government_Insurance.ID;
GO
/****** Object:  View [dbo].[clinics_info]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[clinics_info] AS
SELECT Doctor.Name AS [DOCTOR NAME], Clinic.Address, Clinic.Phone, Clinic.Specialization
FROM Clinic
INNER JOIN Doctor ON Clinic.Doctor_SSN = Doctor.SSN;
GO
/****** Object:  View [dbo].[doctors_info]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[doctors_info] AS
SELECT SSN, Doctor.Name, BirthDate, Doctor.Address, Doctor.Phone, Specialization, Government_Insurance.Address AS [GOV INSU ADDRESS], Government_Insurance.Name AS [GOV INSU NAME]
FROM Doctor
LEFT OUTER JOIN Government_Insurance on Doctor.Government_ID = Government_Insurance.ID;
GO
/****** Object:  View [dbo].[gov_insu_info]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[gov_insu_info] AS
SELECT * FROM Government_Insurance WHERE NOT ID = -1;
GO
/****** Object:  View [dbo].[hospitals_info]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[hospitals_info] AS
SELECT Hospital.*, Government_Insurance.Address AS [GOV INSU ADDRESS], Government_Insurance.Name AS [GOV INSU NAME]
FROM Hospital
LEFT OUTER JOIN Governmen_Hospitals
ON Hospital.ID = Governmen_Hospitals.Hospital_ID
LEFT OUTER JOIN Government_Insurance
ON Governmen_Hospitals.Government_ID = Government_Insurance.ID;
GO
/****** Object:  View [dbo].[pharmacies_info]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[pharmacies_info] AS
SELECT Pharmacy.ID, Pharmacy.Name, Pharmacy.Phone, Pharmacist.Name AS [OWNER NAME], Pharmacist.Phone AS [OWNER PHONE]
FROM Pharmacy
INNER JOIN Pharmacist
ON Pharmacy.Owner_SSN = Pharmacist.SSN;
GO
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (123, N'test                                              ', CAST(N'2011-11-11' AS Date), N'123test123                                        ', N'12315               ', 123465)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1111, N'salah sameh                                       ', CAST(N'2005-05-17' AS Date), N'dasdasda                                          ', N'131231344           ', 123465)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1212, N'sameh sala                                        ', CAST(N'2010-05-17' AS Date), N'saasda                                            ', N'3123123188          ', -1)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (3141, N'mohamed ehab                                      ', CAST(N'1932-05-17' AS Date), N'dasdasd                                           ', N'41241241            ', 123465)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1231214, N'aya gamal                                         ', CAST(N'1998-01-01' AS Date), N'Alexandria                                        ', N'01325151111         ', NULL)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1235343, N'mena ehab                                         ', CAST(N'1999-12-12' AS Date), N'tor-Sina                                          ', N'01413532132         ', NULL)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1321352, N'samah ahmed                                       ', CAST(N'1999-02-13' AS Date), N'8 bahr.st beheria                                 ', N'01452263245         ', NULL)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1324155, N'alaa ahmed                                        ', CAST(N'1998-01-02' AS Date), N'Ebrahimia-Alexandria                              ', N'01289902352         ', NULL)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1325111, N'ahmed sameh                                       ', CAST(N'1988-09-19' AS Date), N'hadayek el ahram -gize                            ', N'01053153213         ', NULL)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1351212, N'eman elsheikh                                     ', CAST(N'1981-05-12' AS Date), N'edku-el behira                                    ', N'01198321351         ', NULL)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1353111, N'Qasem Ahmed                                       ', CAST(N'1999-09-09' AS Date), N'san stefano-Alexandria                            ', N'01111123111         ', NULL)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1353666, N'sayed salah                                       ', CAST(N'1981-11-11' AS Date), N'Damanhour-Elbehira                                ', N'01135364822         ', NULL)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1398538, N'mohamed sayed                                     ', CAST(N'1983-07-11' AS Date), N'hosary-gize                                       ', N'01788942745         ', NULL)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1527548, N'kerols Mena                                       ', CAST(N'1976-12-09' AS Date), N'99 Elharam.st Elharam Giza                        ', N'01005569771         ', NULL)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1627848, N'Mohamed Mohy                                      ', CAST(N'1986-05-05' AS Date), N'30 meky Tanta Gharbia                             ', N'01003569871         ', NULL)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1628548, N'Kaled  sobhy                                      ', CAST(N'1966-06-06' AS Date), N'55 Saidelbadawy Tanta Gharbia                     ', N'01106566771         ', NULL)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1629548, N'zenab khalil                                      ', CAST(N'2000-02-07' AS Date), N'30 khlil.st SedyBishr Alexandria                  ', N'01075866771         ', NULL)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1637548, N'masoud  mohamedy                                  ', CAST(N'2002-02-11' AS Date), N'5 saeidmak.st Mansoura Dakahlia                   ', N'01005586771         ', NULL)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (1667548, N'Fatma mahmoud                                     ', CAST(N'1996-01-12' AS Date), N'7 meky.st Tanta Gharbia                           ', N'01005586971         ', 123654)
INSERT [dbo].[Citizen] ([SSN], [Name], [BirthDate], [Address], [Phone], [Govenment_Insurance_ID]) VALUES (3125433, N'ahmed mohamed                                     ', CAST(N'1980-02-12' AS Date), N'8 port-said                                       ', N'01027813512         ', NULL)
INSERT [dbo].[Citizen_Clinic] ([Doctor_SSN], [Address], [Citizen_SSN], [Rate]) VALUES (11123, N'behira                                            ', 1637548, 10)
INSERT [dbo].[Citizen_Clinic] ([Doctor_SSN], [Address], [Citizen_SSN], [Rate]) VALUES (14336, N'block 12-6th october giza                         ', 1325111, 2)
INSERT [dbo].[Citizen_Clinic] ([Doctor_SSN], [Address], [Citizen_SSN], [Rate]) VALUES (14556, N'25-tanta gharbia                                  ', 1627848, 8)
INSERT [dbo].[Citizen_Clinic] ([Doctor_SSN], [Address], [Citizen_SSN], [Rate]) VALUES (14646, N'15-houria st.mansoura dakahlia                    ', 1628548, 8)
INSERT [dbo].[Citizen_Clinic] ([Doctor_SSN], [Address], [Citizen_SSN], [Rate]) VALUES (14646, N'mansoura dakahlia                                 ', 1231214, 9)
INSERT [dbo].[Citizen_Clinic] ([Doctor_SSN], [Address], [Citizen_SSN], [Rate]) VALUES (14946, N'zifta gharbia                                     ', 1353666, 10)
INSERT [dbo].[Citizen_Clinic] ([Doctor_SSN], [Address], [Citizen_SSN], [Rate]) VALUES (14946, N'zifta gharbia                                     ', 1628548, 9)
INSERT [dbo].[Citizen_Clinic] ([Doctor_SSN], [Address], [Citizen_SSN], [Rate]) VALUES (15493, N'25 block -Eh bahr st.Qanater                      ', 1351212, 7)
INSERT [dbo].[Citizen_Clinic] ([Doctor_SSN], [Address], [Citizen_SSN], [Rate]) VALUES (32155, N'8 san stefano-Alexandria                          ', 1324155, 9)
INSERT [dbo].[Citizen_Hospitals] ([Citizen_SSN], [Hospita_ID], [DSSN], [Rate]) VALUES (1627848, 236978, 14526, 9)
INSERT [dbo].[Citizen_Medicine] ([Citizen_SSN], [Medicine_ID], [Date], [date_end]) VALUES (1627848, 899252, CAST(N'2020-12-04' AS Date), NULL)
INSERT [dbo].[Citizen_Medicine] ([Citizen_SSN], [Medicine_ID], [Date], [date_end]) VALUES (1627848, 899474, CAST(N'2020-07-03' AS Date), NULL)
INSERT [dbo].[Citizen_Medicine] ([Citizen_SSN], [Medicine_ID], [Date], [date_end]) VALUES (1627848, 899742, CAST(N'2020-02-02' AS Date), NULL)
INSERT [dbo].[Citizen_Medicine] ([Citizen_SSN], [Medicine_ID], [Date], [date_end]) VALUES (1627848, 899832, CAST(N'2020-01-05' AS Date), NULL)
INSERT [dbo].[Citizen_Pharmacy] ([Citize_SSN], [Pharmacy_ID], [Doctor_SSN], [Rate]) VALUES (1627848, 569695, NULL, NULL)
INSERT [dbo].[Citizen_Treatment] ([Citizen_SSN], [DSSN], [Rate]) VALUES (1627848, 14526, 8)
INSERT [dbo].[Clinic] ([Doctor_SSN], [Address], [Phone], [Specialization]) VALUES (11123, N'behira                                            ', N'01341522521         ', N'Obstetrics
                                      ')
INSERT [dbo].[Clinic] ([Doctor_SSN], [Address], [Phone], [Specialization]) VALUES (12321, N'12 haram-giza                                     ', N'01321453111         ', N'Children                                          ')
INSERT [dbo].[Clinic] ([Doctor_SSN], [Address], [Phone], [Specialization]) VALUES (14336, N'block 12-6th october giza                         ', N'01289903428         ', N'Pediatrician                                      ')
INSERT [dbo].[Clinic] ([Doctor_SSN], [Address], [Phone], [Specialization]) VALUES (14556, N'25-tanta gharbia                                  ', N'01289903437         ', N'Heart Surgon                                      ')
INSERT [dbo].[Clinic] ([Doctor_SSN], [Address], [Phone], [Specialization]) VALUES (14646, N'15-houria st.mansoura dakahlia                    ', N'01189903437         ', N'general physition                                 ')
INSERT [dbo].[Clinic] ([Doctor_SSN], [Address], [Phone], [Specialization]) VALUES (14646, N'mansoura dakahlia                                 ', N'01009778556         ', NULL)
INSERT [dbo].[Clinic] ([Doctor_SSN], [Address], [Phone], [Specialization]) VALUES (14816, N'12-sedi bishr Alexandria                          ', N'01282303437         ', N'Cardiologist                                      ')
INSERT [dbo].[Clinic] ([Doctor_SSN], [Address], [Phone], [Specialization]) VALUES (14946, N'zifta gharbia                                     ', N'0105698745          ', N'Ophthalmology                                     ')
INSERT [dbo].[Clinic] ([Doctor_SSN], [Address], [Phone], [Specialization]) VALUES (15493, N'25 block -Eh bahr st.Qanater                      ', N'01235121111         ', N'Family medicine                                   ')
INSERT [dbo].[Clinic] ([Doctor_SSN], [Address], [Phone], [Specialization]) VALUES (32155, N'8 san stefano-Alexandria                          ', N'01553132112         ', NULL)
INSERT [dbo].[Conflict_Medicine] ([Medicine_ID], [Confluct_ID]) VALUES (3131, 899252)
INSERT [dbo].[Conflict_Medicine] ([Medicine_ID], [Confluct_ID]) VALUES (899474, 899321)
INSERT [dbo].[Conflict_Medicine] ([Medicine_ID], [Confluct_ID]) VALUES (899692, 899252)
INSERT [dbo].[Conflict_Medicine] ([Medicine_ID], [Confluct_ID]) VALUES (899692, 899692)
INSERT [dbo].[Conflict_Medicine] ([Medicine_ID], [Confluct_ID]) VALUES (899692, 899742)
INSERT [dbo].[Conflict_Medicine] ([Medicine_ID], [Confluct_ID]) VALUES (899742, 899321)
INSERT [dbo].[Conflict_Medicine] ([Medicine_ID], [Confluct_ID]) VALUES (899832, 899742)
INSERT [dbo].[Disease] ([Name], [Citizen_SSN], [StartDate], [EndDate]) VALUES (N'Hepatitis B                                       ', 1231214, CAST(N'2010-08-01' AS Date), NULL)
INSERT [dbo].[Disease] ([Name], [Citizen_SSN], [StartDate], [EndDate]) VALUES (N'Hepatitis B                                       ', 1235343, CAST(N'2005-03-02' AS Date), NULL)
INSERT [dbo].[Disease] ([Name], [Citizen_SSN], [StartDate], [EndDate]) VALUES (N'Hepatitis B                                       ', 1353666, CAST(N'1999-01-01' AS Date), NULL)
INSERT [dbo].[Disease] ([Name], [Citizen_SSN], [StartDate], [EndDate]) VALUES (N'Hepatitis C                                       ', 1231214, CAST(N'2000-01-04' AS Date), NULL)
INSERT [dbo].[Disease] ([Name], [Citizen_SSN], [StartDate], [EndDate]) VALUES (N'Hepatitis C                                       ', 1325111, CAST(N'1989-09-19' AS Date), NULL)
INSERT [dbo].[Disease] ([Name], [Citizen_SSN], [StartDate], [EndDate]) VALUES (N'Hepatitis C                                       ', 1527548, CAST(N'1990-02-02' AS Date), NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (1234, N'test_doctor_name                                  ', CAST(N'2020-05-17' AS Date), N'test_doctor_address                               ', N'2312313             ', N'test_doctor_spec                                  ', 123654)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (3111, N'salah saad                                        ', CAST(N'1992-12-03' AS Date), N'behira                                            ', N'01013141411         ', N'Children                                          ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (11123, N'samah anwar                                       ', CAST(N'1982-11-12' AS Date), N'behira                                            ', N'01341522521         ', N'Obstetrics
                                      ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (12311, N'Fatma Elsafy                                      ', CAST(N'1990-05-06' AS Date), N'Sharkeya                                          ', N'01235123114         ', N'Internal medicine
                               ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (12321, N'ragab ahmed                                       ', CAST(N'1988-11-11' AS Date), N'giza                                              ', N'01321453111         ', N'Children                                          ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (13115, N'Ahmed Elsafy                                      ', CAST(N'1992-12-13' AS Date), N'Alexandria                                        ', N'01235151211         ', N'Family medicine                                   ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (13155, N'Aya Salah                                         ', CAST(N'1977-01-02' AS Date), N'Mahala Elkoubra                                   ', N'01231542221         ', N'Emergency medicine
                              ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (13211, N'Khaled Ahmed                                      ', CAST(N'1991-11-12' AS Date), N'Mansoura                                          ', N'01031131311         ', N'Internal medicine
                               ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (13251, N'Ahmed mahoud                                      ', CAST(N'1963-11-16' AS Date), N'giza                                              ', N'01211223131         ', N'Family medicine                                   ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (13415, N'Mohamed Alla                                      ', CAST(N'1996-11-14' AS Date), N'behira                                            ', N'01321515113         ', N'Family medicine                                   ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (14336, N'shimaa sharfelden                                 ', CAST(N'1984-09-08' AS Date), N'6th october giza                                  ', N'01289903428         ', N'Pediatrician                                      ', 123465)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (14526, N'khalid moustafa                                   ', CAST(N'1953-10-09' AS Date), N'asyout                                            ', N'01289902427         ', N'Obstetrician                                      ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (14556, N'Ahmed gomaa                                       ', CAST(N'1966-12-06' AS Date), N'tanta gharbia                                     ', N'01289903437         ', N'Heart Surgon                                      ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (14646, N'fatma ali                                         ', CAST(N'1996-01-07' AS Date), N'mansoura dakahlia                                 ', N'01189903437         ', N'general physition                                 ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (14676, N'mena saied                                        ', CAST(N'1991-02-09' AS Date), N'sayeda zinab cairo                                ', N'01257903437         ', N'Dermatologist                                     ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (14816, N'sobhy mahrous                                     ', CAST(N'1973-11-09' AS Date), N'sedi bishr Alexandria                             ', N'01282303437         ', N'Cardiologist                                      ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (14946, N'moustafa mohamed                                  ', CAST(N'1977-02-05' AS Date), N'zifta gharbia                                     ', N'01289923131         ', N'Ophthalmologist                                   ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (15493, N'Salah Ahmed                                       ', CAST(N'1988-01-01' AS Date), N'Qanater                                           ', N'01235121111         ', N'Family medicine                                   ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (32155, N'Ehab Mohamed                                      ', CAST(N'1991-12-12' AS Date), N'Alexandria                                        ', N'01023151311         ', N'Heart Surgon                                      ', NULL)
INSERT [dbo].[Doctor] ([SSN], [Name], [BirthDate], [Address], [Phone], [Specialization], [Government_ID]) VALUES (65212, N'Qassem Ibrahim                                    ', CAST(N'1982-03-12' AS Date), N'Qafer El sheik                                    ', N'01065111232         ', N'Obstetrics
                                      ', NULL)
INSERT [dbo].[Governmen_Hospitals] ([Hospital_ID], [Government_ID]) VALUES (1212, 123654)
INSERT [dbo].[Governmen_Hospitals] ([Hospital_ID], [Government_ID]) VALUES (216988, 123465)
INSERT [dbo].[Governmen_Hospitals] ([Hospital_ID], [Government_ID]) VALUES (236978, 123654)
INSERT [dbo].[Government_Insurance] ([ID], [Name], [Phone], [Address]) VALUES (-1, N'NONE                                              ', N'NONE                ', N'NONE                                              ')
INSERT [dbo].[Government_Insurance] ([ID], [Name], [Phone], [Address]) VALUES (1122, N'test_inus_name                                    ', N'1241414288          ', N'test_insu_address                                 ')
INSERT [dbo].[Government_Insurance] ([ID], [Name], [Phone], [Address]) VALUES (123465, N'Elharam office                                    ', N'35840693            ', N'elmatbaa st Fesal Giza                            ')
INSERT [dbo].[Government_Insurance] ([ID], [Name], [Phone], [Address]) VALUES (123654, N'General Authority For Health Insurance            ', N'25772853            ', N'33 Elglaa.st elAzbakya Cairo                      ')
INSERT [dbo].[Government_Insurance] ([ID], [Name], [Phone], [Address]) VALUES (311514, N'Kafr El sheikh insurance                          ', N'4864113             ', N'Kafr El sheikh                                    ')
INSERT [dbo].[Government_Insurance] ([ID], [Name], [Phone], [Address]) VALUES (312111, N'Giza insurance                                    ', N'7846251             ', N'Giza                                              ')
INSERT [dbo].[Government_Insurance] ([ID], [Name], [Phone], [Address]) VALUES (312511, N'Edku insurance                                    ', N'3125121             ', N'Edku                                              ')
INSERT [dbo].[Government_Insurance] ([ID], [Name], [Phone], [Address]) VALUES (317541, N'Tanta insurance                                   ', N'29876751            ', N'Tanta                                             ')
INSERT [dbo].[Government_Insurance] ([ID], [Name], [Phone], [Address]) VALUES (318961, N'Damanhour insurance                               ', N'31861454            ', N'Damanhour                                         ')
INSERT [dbo].[Government_Insurance] ([ID], [Name], [Phone], [Address]) VALUES (878166, N'Edfu insurance                                    ', N'3166156             ', N'Edfu                                              ')
INSERT [dbo].[Government_Medicine] ([Medicine_ID], [Governmnet_ID]) VALUES (1122, 123465)
INSERT [dbo].[Government_Medicine] ([Medicine_ID], [Governmnet_ID]) VALUES (3131, 123465)
INSERT [dbo].[Government_Medicine] ([Medicine_ID], [Governmnet_ID]) VALUES (899474, 1122)
INSERT [dbo].[Government_Medicine] ([Medicine_ID], [Governmnet_ID]) VALUES (899692, 1122)
INSERT [dbo].[Government_Medicine] ([Medicine_ID], [Governmnet_ID]) VALUES (899692, 123654)
INSERT [dbo].[Hospita_Employee] ([Doctor_SSN], [Hospital_ID], [Rate]) VALUES (14556, 236978, 4)
INSERT [dbo].[Hospita_Employee] ([Doctor_SSN], [Hospital_ID], [Rate]) VALUES (14556, 236978, 4)
INSERT [dbo].[Hospital] ([ID], [Name], [Phone], [Manager], [Address], [Specialization]) VALUES (1212, N'test_hos_name                                     ', N'3414188             ', N'test_hos_manager                                  ', N'test_hos_address                                  ', N'test_hos_spec                                     ')
INSERT [dbo].[Hospital] ([ID], [Name], [Phone], [Manager], [Address], [Specialization]) VALUES (216988, N'Al Haram                                          ', N'33860236            ', N'Mansour Khalil                                    ', N'Al Haram, Oula Al Haram, El Omraniya, Giza        ', NULL)
INSERT [dbo].[Hospital] ([ID], [Name], [Phone], [Manager], [Address], [Specialization]) VALUES (226265, N'International Eye Hospital                        ', N'33362636            ', N'Mohamed Arafat                                    ', N'17 Adel Hussein Rostom, Ad Doqi A, Dokki, Giza    ', N'Eye care                                          ')
INSERT [dbo].[Hospital] ([ID], [Name], [Phone], [Manager], [Address], [Specialization]) VALUES (231511, N'Alex Sidney Kiel
                                ', N'035460130           ', N'rahma ahmed                                       ', N'12 Roushdy St. Alexandria                         ', N'General Hospital
                                ')
INSERT [dbo].[Hospital] ([ID], [Name], [Phone], [Manager], [Address], [Specialization]) VALUES (236978, N'El Demerdash Hospital                             ', N'24346001            ', N'aymen saleh                                       ', N'56, Ramsis St., El Abbasia Cairo                  ', NULL)
INSERT [dbo].[Hospital] ([ID], [Name], [Phone], [Manager], [Address], [Specialization]) VALUES (256978, N'57357                                             ', N'25351500            ', N'Mohamed Arafat                                    ', N'zynhom Elsayeda-zynab Cairo                       ', N'child cancer                                      ')
INSERT [dbo].[Hospital] ([ID], [Name], [Phone], [Manager], [Address], [Specialization]) VALUES (298921, N'Magdi Yacoub Heart Foundation                     ', N' 27365166           ', N'Magdi Yacoub                                      ', N'7 Aziz Abaza St. off 26 July St. Zamalek Cairo    ', N'Hart issues                                       ')
INSERT [dbo].[Hospital] ([ID], [Name], [Phone], [Manager], [Address], [Specialization]) VALUES (312311, N'Dar Ismail                                        ', N'043251231           ', N'Ahmed Salah                                       ', N'23-Roushdy St.Alex                                ', N'Obstetrics                                        ')
INSERT [dbo].[Hospital] ([ID], [Name], [Phone], [Manager], [Address], [Specialization]) VALUES (3125111, N'As Salam International Hospital                   ', N' 25240066           ', N'Ahmed Mahoud                                      ', N'Corniche El Nile, Maadi                           ', N'Bone diseases                                     ')
INSERT [dbo].[Hospital] ([ID], [Name], [Phone], [Manager], [Address], [Specialization]) VALUES (3151151, N'Helal Hospital                                    ', N'25750160            ', N'Assam Salah                                       ', N'، Al Fawalah, Abdeen, Cairo Governorate           ', N'Specializing in bone surgery                      ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (1122, N'test_med_name                                     ', N'dasda                                             ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (3131, N'test_med_name                                     ', N'dasda                                             ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (31251, N'Mylanta                                           ', N'Aluminum hydroxide                                ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (31411, N'Chlorothiazide                                    ', N'Diuril                                            ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (31511, N'naproxen                                          ', N'Asprin                                            ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (31513, N'Lansoprazole                                      ', N'Prevacid                                          ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (31519, N'Bumetanide                                        ', N'Bumex                                             ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (43262, N'Omeprazole                                        ', N'Prilosec                                          ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (321511, N'acetaminophen                                     ', N'Asprin                                            ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (534612, N'ibuprofen                                         ', N'Asprin                                            ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (899252, N'Bayer                                             ', N'Asprin                                            ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (899321, N'Basiliximab                                       ', N'Simulect                                          ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (899474, N'becaplemin                                        ', N'Regranex                                          ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (899692, N'Rapamune                                          ', N'sirolimus                                         ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (899742, N'Dacomitnib                                        ', N'Vizimpro                                          ')
INSERT [dbo].[Medicines] ([ID], [Name], [Active_Ingredient]) VALUES (899832, N'Dynarcirc                                         ', N'isradipine                                        ')
INSERT [dbo].[Pharmacist] ([SSN], [Name], [BirthDate], [Phone], [Address], [Specialization]) VALUES (12222, N'Ahmed Mohamed                                     ', CAST(N'1952-12-01' AS Date), N'01288413788         ', N'Alexandria -sidi bishr                            ', N'clinical pharmacy                                 ')
INSERT [dbo].[Pharmacist] ([SSN], [Name], [BirthDate], [Phone], [Address], [Specialization]) VALUES (12341, N'’Mohamed Ahmed                                    ', CAST(N'1982-11-01' AS Date), N'01013784236         ', N'Haram st.Giza                                     ', N'clinical pharmacy                                 ')
INSERT [dbo].[Pharmacist] ([SSN], [Name], [BirthDate], [Phone], [Address], [Specialization]) VALUES (31888, N'Ahmed Mahmoud                                     ', CAST(N'1976-01-23' AS Date), N'01577675252         ', N'Algami-Alexandria                                 ', N'clinical pharmacy                                 ')
INSERT [dbo].[Pharmacist] ([SSN], [Name], [BirthDate], [Phone], [Address], [Specialization]) VALUES (33151, N'Essam Mosrafa                                     ', CAST(N'1966-02-05' AS Date), N'01232318517         ', N'Edku-Behera                                       ', N'Electronics Project                               ')
INSERT [dbo].[Pharmacist] ([SSN], [Name], [BirthDate], [Phone], [Address], [Specialization]) VALUES (84211, N'Kamal Ahmed                                       ', CAST(N'1992-06-06' AS Date), N'01142435353         ', N'Kafr Elsheik                                      ', N'ambulatory care pharmacy                          ')
INSERT [dbo].[Pharmacist] ([SSN], [Name], [BirthDate], [Phone], [Address], [Specialization]) VALUES (162218, N'Aisha mokhtar                                     ', CAST(N'1968-05-10' AS Date), N'01210121111         ', N'2 Elharam.st Elharam Giza                         ', N'clinical pharmacy                                 ')
INSERT [dbo].[Pharmacist] ([SSN], [Name], [BirthDate], [Phone], [Address], [Specialization]) VALUES (162543, N'mohamed fahim                                     ', CAST(N'1988-01-02' AS Date), N'01010101010         ', N'122 Elzohor.st Elmaady Cairo                      ', N'clinical pharmacy                                 ')
INSERT [dbo].[Pharmacist] ([SSN], [Name], [BirthDate], [Phone], [Address], [Specialization]) VALUES (162694, N'soaad mohy                                        ', CAST(N'1974-08-08' AS Date), N'01010101111         ', N'13 6th avenue Elhosasry Giza                      ', N'industrial pharmacy                               ')
INSERT [dbo].[Pharmacist] ([SSN], [Name], [BirthDate], [Phone], [Address], [Specialization]) VALUES (162865, N'Abd ElElah mena                                   ', CAST(N'1998-01-11' AS Date), N'01010151311         ', N'17 Elgaesh.st mansoura Dakahlia                   ', N'ambulatory care pharmacy                          ')
INSERT [dbo].[Pharmacist] ([SSN], [Name], [BirthDate], [Phone], [Address], [Specialization]) VALUES (162972, N'mohamed khalid                                    ', CAST(N'1994-03-05' AS Date), N'01010121112         ', N'12 Elbahr.st tanta Gharbia                        ', N'compounding pharmacy                              ')
INSERT [dbo].[Pharmacy] ([ID], [Name], [Phone], [Owner_SSN]) VALUES (569445, N'Elhelal                                           ', N'19786               ', 162972)
INSERT [dbo].[Pharmacy] ([ID], [Name], [Phone], [Owner_SSN]) VALUES (569495, N'Teba                                              ', N'19776               ', 162865)
INSERT [dbo].[Pharmacy] ([ID], [Name], [Phone], [Owner_SSN]) VALUES (569555, N'Amgad                                             ', N'19989               ', 162694)
INSERT [dbo].[Pharmacy] ([ID], [Name], [Phone], [Owner_SSN]) VALUES (569695, N'ElEzzaby                                          ', N'19686               ', 162218)
INSERT [dbo].[Pharmacy] ([ID], [Name], [Phone], [Owner_SSN]) VALUES (569876, N'Tabark                                            ', N'19556               ', 162543)
INSERT [dbo].[Pharmacy_Address] ([Pharmacy_ID], [Address]) VALUES (569876, N'122 Elzohor.st Elmaady Cairo                      ')
INSERT [dbo].[Pharmacy_Address] ([Pharmacy_ID], [Address]) VALUES (569445, N'19 Elbahr.st tanta Gharbia                        ')
INSERT [dbo].[Pharmacy_Address] ([Pharmacy_ID], [Address]) VALUES (569495, N'9 saad zaghlol.st fesal Giza                      ')
INSERT [dbo].[Pharmacy_Address] ([Pharmacy_ID], [Address]) VALUES (569555, N'12 Elgaesh.st mansoura Dakahlia                   ')
INSERT [dbo].[Pharmacy_Address] ([Pharmacy_ID], [Address]) VALUES (569695, N'17 Elharam.st Elharam Giza                        ')
INSERT [dbo].[priv_lvl_name] ([priv_lvl], [role_name]) VALUES (0, N'Super Admin')
INSERT [dbo].[priv_lvl_name] ([priv_lvl], [role_name]) VALUES (1, N'Health Admin')
INSERT [dbo].[priv_lvl_name] ([priv_lvl], [role_name]) VALUES (2, N'Public Admin')
INSERT [dbo].[priv_lvl_name] ([priv_lvl], [role_name]) VALUES (3, N'Doctor')
INSERT [dbo].[priv_lvl_name] ([priv_lvl], [role_name]) VALUES (4, N'Pharmacist')
INSERT [dbo].[priv_lvl_name] ([priv_lvl], [role_name]) VALUES (5, N'Citizen')
INSERT [dbo].[Users] ([Username], [pass_hash], [Priv], [SSN], [email]) VALUES (N'asdas                                             ', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1, 123, N'dasdas')
INSERT [dbo].[Users] ([Username], [pass_hash], [Priv], [SSN], [email]) VALUES (N'super_user', N'e74c5916ac2603ee06dd3e2463af018ac45c96b51ceaa44a30bb46f96bc2a572', 0, NULL, N'super@super.super')
INSERT [dbo].[Users] ([Username], [pass_hash], [Priv], [SSN], [email]) VALUES (N'test_hdm', N'aafb361b97b452892e61f71c71b6bf38937c60ca54d461a7ef7e996e86eabfb6', 1, NULL, N'hdm@hdm.hdm')
INSERT [dbo].[Users] ([Username], [pass_hash], [Priv], [SSN], [email]) VALUES (N'test_pub_mob', N'309f48596fa426a87710c82a4596de49565665214375f4d29157574b0ed89117', 2, NULL, N'pub@pub.pub')
ALTER TABLE [dbo].[Citizen]  WITH CHECK ADD  CONSTRAINT [FK_Citizen_Government_Insurance] FOREIGN KEY([Govenment_Insurance_ID])
REFERENCES [dbo].[Government_Insurance] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Citizen] CHECK CONSTRAINT [FK_Citizen_Government_Insurance]
GO
ALTER TABLE [dbo].[Citizen_Clinic]  WITH CHECK ADD  CONSTRAINT [FK_Citizen_Clinic_Citizen] FOREIGN KEY([Citizen_SSN])
REFERENCES [dbo].[Citizen] ([SSN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Citizen_Clinic] CHECK CONSTRAINT [FK_Citizen_Clinic_Citizen]
GO
ALTER TABLE [dbo].[Citizen_Clinic]  WITH CHECK ADD  CONSTRAINT [FK_Citizen_Clinic_Clinic] FOREIGN KEY([Doctor_SSN], [Address])
REFERENCES [dbo].[Clinic] ([Doctor_SSN], [Address])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Citizen_Clinic] CHECK CONSTRAINT [FK_Citizen_Clinic_Clinic]
GO
ALTER TABLE [dbo].[Citizen_Hospitals]  WITH CHECK ADD  CONSTRAINT [FK_Citizen_Hospitals_Citizen] FOREIGN KEY([Citizen_SSN])
REFERENCES [dbo].[Citizen] ([SSN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Citizen_Hospitals] CHECK CONSTRAINT [FK_Citizen_Hospitals_Citizen]
GO
ALTER TABLE [dbo].[Citizen_Hospitals]  WITH CHECK ADD  CONSTRAINT [FK_Citizen_Hospitals_Doctor] FOREIGN KEY([DSSN])
REFERENCES [dbo].[Doctor] ([SSN])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Citizen_Hospitals] CHECK CONSTRAINT [FK_Citizen_Hospitals_Doctor]
GO
ALTER TABLE [dbo].[Citizen_Hospitals]  WITH CHECK ADD  CONSTRAINT [FK_Citizen_Hospitals_Hospital] FOREIGN KEY([Hospita_ID])
REFERENCES [dbo].[Hospital] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Citizen_Hospitals] CHECK CONSTRAINT [FK_Citizen_Hospitals_Hospital]
GO
ALTER TABLE [dbo].[Citizen_Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Citizen_Medicine_Citizen] FOREIGN KEY([Citizen_SSN])
REFERENCES [dbo].[Citizen] ([SSN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Citizen_Medicine] CHECK CONSTRAINT [FK_Citizen_Medicine_Citizen]
GO
ALTER TABLE [dbo].[Citizen_Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Citizen_Medicine_Medicines] FOREIGN KEY([Medicine_ID])
REFERENCES [dbo].[Medicines] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Citizen_Medicine] CHECK CONSTRAINT [FK_Citizen_Medicine_Medicines]
GO
ALTER TABLE [dbo].[Citizen_Pharmacy]  WITH CHECK ADD  CONSTRAINT [FK_Citizen_Pharmacy_Citizen] FOREIGN KEY([Citize_SSN])
REFERENCES [dbo].[Citizen] ([SSN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Citizen_Pharmacy] CHECK CONSTRAINT [FK_Citizen_Pharmacy_Citizen]
GO
ALTER TABLE [dbo].[Citizen_Pharmacy]  WITH CHECK ADD  CONSTRAINT [FK_Citizen_Pharmacy_Doctor] FOREIGN KEY([Doctor_SSN])
REFERENCES [dbo].[Doctor] ([SSN])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Citizen_Pharmacy] CHECK CONSTRAINT [FK_Citizen_Pharmacy_Doctor]
GO
ALTER TABLE [dbo].[Citizen_Pharmacy]  WITH CHECK ADD  CONSTRAINT [FK_Citizen_Pharmacy_Pharmacy] FOREIGN KEY([Pharmacy_ID])
REFERENCES [dbo].[Pharmacy] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Citizen_Pharmacy] CHECK CONSTRAINT [FK_Citizen_Pharmacy_Pharmacy]
GO
ALTER TABLE [dbo].[Citizen_Treatment]  WITH CHECK ADD  CONSTRAINT [FK_Citizen_Treatment_Citizen] FOREIGN KEY([Citizen_SSN])
REFERENCES [dbo].[Citizen] ([SSN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Citizen_Treatment] CHECK CONSTRAINT [FK_Citizen_Treatment_Citizen]
GO
ALTER TABLE [dbo].[Citizen_Treatment]  WITH CHECK ADD  CONSTRAINT [FK_Citizen_Treatment_Doctor] FOREIGN KEY([DSSN])
REFERENCES [dbo].[Doctor] ([SSN])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Citizen_Treatment] CHECK CONSTRAINT [FK_Citizen_Treatment_Doctor]
GO
ALTER TABLE [dbo].[Clinic]  WITH CHECK ADD  CONSTRAINT [FK_Clinic_Doctor] FOREIGN KEY([Doctor_SSN])
REFERENCES [dbo].[Doctor] ([SSN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Clinic] CHECK CONSTRAINT [FK_Clinic_Doctor]
GO
ALTER TABLE [dbo].[Conflict_Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Conflict_Medicine_Medicines] FOREIGN KEY([Medicine_ID])
REFERENCES [dbo].[Medicines] ([ID])
GO
ALTER TABLE [dbo].[Conflict_Medicine] CHECK CONSTRAINT [FK_Conflict_Medicine_Medicines]
GO
ALTER TABLE [dbo].[Conflict_Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Conflict_Medicine_Medicines1] FOREIGN KEY([Medicine_ID])
REFERENCES [dbo].[Medicines] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Conflict_Medicine] CHECK CONSTRAINT [FK_Conflict_Medicine_Medicines1]
GO
ALTER TABLE [dbo].[Disease]  WITH CHECK ADD  CONSTRAINT [FK_Disease_Citizen] FOREIGN KEY([Citizen_SSN])
REFERENCES [dbo].[Citizen] ([SSN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Disease] CHECK CONSTRAINT [FK_Disease_Citizen]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Government_Insurance] FOREIGN KEY([Government_ID])
REFERENCES [dbo].[Government_Insurance] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Government_Insurance]
GO
ALTER TABLE [dbo].[Governmen_Hospitals]  WITH CHECK ADD  CONSTRAINT [FK_Governmen_Hospitals_Government_Insurance] FOREIGN KEY([Government_ID])
REFERENCES [dbo].[Government_Insurance] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Governmen_Hospitals] CHECK CONSTRAINT [FK_Governmen_Hospitals_Government_Insurance]
GO
ALTER TABLE [dbo].[Governmen_Hospitals]  WITH CHECK ADD  CONSTRAINT [FK_Governmen_Hospitals_Hospital] FOREIGN KEY([Hospital_ID])
REFERENCES [dbo].[Hospital] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Governmen_Hospitals] CHECK CONSTRAINT [FK_Governmen_Hospitals_Hospital]
GO
ALTER TABLE [dbo].[Government_Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Government_Medicine_Medicines] FOREIGN KEY([Medicine_ID])
REFERENCES [dbo].[Medicines] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Government_Medicine] CHECK CONSTRAINT [FK_Government_Medicine_Medicines]
GO
ALTER TABLE [dbo].[Hospita_Employee]  WITH CHECK ADD  CONSTRAINT [FK_Hospita_Employee_Doctor] FOREIGN KEY([Doctor_SSN])
REFERENCES [dbo].[Doctor] ([SSN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Hospita_Employee] CHECK CONSTRAINT [FK_Hospita_Employee_Doctor]
GO
ALTER TABLE [dbo].[Hospita_Employee]  WITH CHECK ADD  CONSTRAINT [FK_Hospita_Employee_Hospital] FOREIGN KEY([Hospital_ID])
REFERENCES [dbo].[Hospital] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Hospita_Employee] CHECK CONSTRAINT [FK_Hospita_Employee_Hospital]
GO
ALTER TABLE [dbo].[Pharmacy]  WITH CHECK ADD  CONSTRAINT [FK_Pharmacy_Pharmacist] FOREIGN KEY([Owner_SSN])
REFERENCES [dbo].[Pharmacist] ([SSN])
GO
ALTER TABLE [dbo].[Pharmacy] CHECK CONSTRAINT [FK_Pharmacy_Pharmacist]
GO
ALTER TABLE [dbo].[Pharmacy_Address]  WITH CHECK ADD  CONSTRAINT [FK_Pharmacy_Address_Pharmacy] FOREIGN KEY([Pharmacy_ID])
REFERENCES [dbo].[Pharmacy] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pharmacy_Address] CHECK CONSTRAINT [FK_Pharmacy_Address_Pharmacy]
GO
ALTER TABLE [dbo].[Pharmacy_Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Pharmacy_Medicine_Medicines] FOREIGN KEY([Medicine_ID])
REFERENCES [dbo].[Medicines] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pharmacy_Medicine] CHECK CONSTRAINT [FK_Pharmacy_Medicine_Medicines]
GO
ALTER TABLE [dbo].[Pharmacy_Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Pharmacy_Medicine_Pharmacy] FOREIGN KEY([Pharmacy_ID])
REFERENCES [dbo].[Pharmacy] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pharmacy_Medicine] CHECK CONSTRAINT [FK_Pharmacy_Medicine_Pharmacy]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Citizen] FOREIGN KEY([SSN])
REFERENCES [dbo].[Citizen] ([SSN])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Citizen]
GO
/****** Object:  StoredProcedure [dbo].[add_citizen]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_citizen]
@ssn INT,
@name NCHAR(50),
@dob DATE,
@address NCHAR(50),
@phone NCHAR(20),
@gov_insu_id INT
AS
INSERT INTO Citizen
VALUES(@ssn, @name, @dob, @address, @phone, @gov_insu_id)
GO
/****** Object:  StoredProcedure [dbo].[add_clinic]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_clinic]
@dssn INT,
@address NCHAR(50),
@phone NCHAR(20),
@spec NCHAR(20)
AS
INSERT INTO Clinic
VALUES(@dssn, @address, @phone, @spec)
GO
/****** Object:  StoredProcedure [dbo].[add_dis_cit_rel]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_dis_cit_rel]
@dis_name NCHAR(50),
@cit_id INT,
@ds DATE,
@de DATE
AS
INSERT INTO Disease VALUES(@dis_name, @cit_id, @ds, @de)
GO
/****** Object:  StoredProcedure [dbo].[add_doctor]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_doctor]
@ssn INT,
@name NCHAR(50),
@dob DATE,
@address NCHAR(50),
@phone NCHAR(20),
@spec NCHAR(20),
@gov_insu_id INT
AS
INSERT INTO Doctor
VALUES(@ssn, @name, @dob, @address, @phone, @spec, @gov_insu_id)
GO
/****** Object:  StoredProcedure [dbo].[add_gov_insu]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_gov_insu]
@id INT,
@name NCHAR(50),
@phone NCHAR(20),
@address NCHAR(50)
AS
INSERT INTO Government_Insurance
VALUES(@id, @name, @phone, @address)
GO
/****** Object:  StoredProcedure [dbo].[add_hospital]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_hospital]
@id INT,
@name NCHAR(50),
@phone NCHAR(20),
@manager NCHAR(50),
@address NCHAR(50),
@spec NCHAR(50)
AS
INSERT INTO Hospital
VALUES(@id, @name, @phone, @manager, @address, @spec)
GO
/****** Object:  StoredProcedure [dbo].[add_hospital_inus]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_hospital_inus]
@hos_id INT,
@gov_id INT
AS
INSERT INTO Governmen_Hospitals
VALUES(@hos_id, @gov_id)
GO
/****** Object:  StoredProcedure [dbo].[add_med_cit_rel]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_med_cit_rel]
@cit_id INT,
@med_id INT,
@ds DATE,
@de DATE
AS
INSERT INTO Citizen_Medicine VALUES(@cit_id, @med_id, @ds, @de)
GO
/****** Object:  StoredProcedure [dbo].[add_med_conf]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_med_conf]
@med_id INT,
@conf_id INT
AS
INSERT INTO Conflict_Medicine
VALUES(@med_id, @conf_id)
GO
/****** Object:  StoredProcedure [dbo].[add_med_insu]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_med_insu]
@med_id INT,
@insu_id INT
AS
INSERT INTO Government_Medicine
VALUES(@med_id, @insu_id)
GO
/****** Object:  StoredProcedure [dbo].[add_medicine]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_medicine]
@id INT,
@name NCHAR(50),
@ai NCHAR(50)
AS
INSERT INTO Medicines
VALUES(@id, @name, @ai)
GO
/****** Object:  StoredProcedure [dbo].[add_pharmacist]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_pharmacist]
@ssn INT,
@name NCHAR(50),
@dob DATE,
@phone NCHAR(50),
@address NCHAR(50),
@spec NCHAR(50)
AS
INSERT INTO Pharmacist
VALUES(@ssn, @name, @dob, @phone, @address, @spec)
GO
/****** Object:  StoredProcedure [dbo].[add_pharmacy]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_pharmacy]
@id INT,
@name NCHAR(50),
@phone NCHAR(50),
@owner_ssn INT
AS
INSERT INTO Pharmacy
VALUES(@id, @name, @phone, @owner_ssn)
GO
/****** Object:  StoredProcedure [dbo].[add_phr_med_rel]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_phr_med_rel]
@med_id INT,
@phr_id INT
AS
INSERT INTO Pharmacy_Medicine
VALUES(@phr_id, @med_id)

GO
/****** Object:  StoredProcedure [dbo].[add_user]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_user]
@user_name NCHAR(50),
@pass_hash VARCHAR(256),
@priv INT,
@ssn INT,
@email VARCHAR(256)
AS
INSERT INTO Users VALUES(@user_name, @pass_hash, @priv, @ssn, @email)
GO
/****** Object:  StoredProcedure [dbo].[rem_hospital_inus]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[rem_hospital_inus]
@hos_id INT,
@gov_id INT
AS
DELETE FROM Governmen_Hospitals WHERE Governmen_Hospitals.Hospital_ID = @hos_id AND Governmen_Hospitals.Government_ID = @gov_id
GO
/****** Object:  StoredProcedure [dbo].[rem_med_conf]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[rem_med_conf]
@med_id INT,
@conf_id INT
AS
DELETE FROM Conflict_Medicine
WHERE Conflict_Medicine.Medicine_ID = @med_id AND Conflict_Medicine.Confluct_ID = @conf_id
GO
/****** Object:  StoredProcedure [dbo].[rem_med_insu]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[rem_med_insu]
@med_id INT,
@insu_id INT
AS
DELETE FROM Government_Medicine
WHERE Government_Medicine.Medicine_ID = @med_id AND Government_Medicine.Governmnet_ID = @insu_id
GO
/****** Object:  StoredProcedure [dbo].[rem_phr_med_rel]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[rem_phr_med_rel]
@med_id INT,
@phr_id INT
AS
DELETE FROM Pharmacy_Medicine
WHERE Pharmacy_Medicine.Medicine_ID = @med_id AND Pharmacy_Medicine.Pharmacy_ID = @phr_id

GO
/****** Object:  StoredProcedure [dbo].[update_citizen]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_citizen]
@ssn INT,
@name NCHAR(50),
@dob DATE,
@address NCHAR(50),
@phone NCHAR(20),
@gov_insu_id INT
AS
UPDATE Citizen
SET
Citizen.Name = @name,
Citizen.BirthDate = @dob,
Citizen.Address = @address,
Citizen.Phone = @phone,
Citizen.Govenment_Insurance_ID = @gov_insu_id
WHERE Citizen.SSN = @ssn;
GO
/****** Object:  StoredProcedure [dbo].[update_clinic]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_clinic]
@dssn INT,
@address NCHAR(50),
@phone NCHAR(20),
@spec NCHAR(20)
AS
UPDATE Clinic
SET
Clinic.Address = @address,
Clinic.Phone = @phone,
Clinic.Specialization = @spec
WHERE Clinic.Doctor_SSN = @dssn
GO
/****** Object:  StoredProcedure [dbo].[update_doctor]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_doctor]
@ssn INT,
@name NCHAR(50),
@dob DATE,
@address NCHAR(50),
@phone NCHAR(20),
@spec NCHAR(20),
@gov_insu_id INT
AS
UPDATE Doctor
SET
Doctor.Name = @name,
Doctor.BirthDate = @dob,
Doctor.Address = @address,
Doctor.Phone = @phone,
Doctor.Specialization = @spec,
Doctor.Government_ID = @gov_insu_id
WHERE Doctor.SSN = @ssn
GO
/****** Object:  StoredProcedure [dbo].[update_gov_insu]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_gov_insu]
@id INT,
@name NCHAR(50),
@phone NCHAR(20),
@address NCHAR(50)
AS
UPDATE Government_Insurance
SET
Government_Insurance.Name = @name,
Government_Insurance.Phone = @phone,
Government_Insurance.Address = @address
WHERE Government_Insurance.ID = @id
GO
/****** Object:  StoredProcedure [dbo].[update_hospital]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_hospital]
@id INT,
@name NCHAR(50),
@phone NCHAR(20),
@manager NCHAR(50),
@address NCHAR(50),
@spec NCHAR(50)
AS
UPDATE Hospital
SET
Hospital.Name = @name,
Hospital.Phone = @phone,
Hospital.Manager = @manager,
Hospital.Address = @address,
Hospital.Specialization = @spec
WHERE Hospital.ID = @id
GO
/****** Object:  StoredProcedure [dbo].[update_medicine]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_medicine]
@id INT,
@name NCHAR(50),
@ai NCHAR(50)
AS
UPDATE Medicines
SET
Medicines.Name = @name,
Medicines.Active_Ingredient = @ai
WHERE Medicines.ID = @id
GO
/****** Object:  StoredProcedure [dbo].[update_pharmacist]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_pharmacist]
@ssn INT,
@name NCHAR(50),
@dob DATE,
@phone NCHAR(50),
@address NCHAR(50),
@spec NCHAR(50)
AS
UPDATE Pharmacist
SET
Pharmacist.Name = @name,
Pharmacist.BirthDate = @dob,
Pharmacist.Phone = @phone,
Pharmacist.Address = @address,
Pharmacist.Specialization = @spec
WHERE Pharmacist.SSN = @ssn
GO
/****** Object:  StoredProcedure [dbo].[update_pharmacy]    Script Date: 5/20/2020 11:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_pharmacy]
@id INT,
@name NCHAR(50),
@phone NCHAR(50),
@owner_ssn INT
AS
UPDATE Pharmacy
SET
Pharmacy.Name = @name,
Pharmacy.Phone = @phone,
Pharmacy.Owner_SSN = @owner_ssn
WHERE Pharmacy.ID = @id
GO
