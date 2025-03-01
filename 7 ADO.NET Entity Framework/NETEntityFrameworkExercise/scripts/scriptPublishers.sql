/****** Object:  Table [dbo].[Stores] ******/
CREATE TABLE Stores (
	[StoreID] [nvarchar](4) NOT NULL,
	[StoreName] [nvarchar](40) NULL,
	[StoreAddress] [nvarchar](40) NULL,
	[City] [nvarchar](20) NULL,
	[State] [nvarchar](2) NULL,
	[Zip] [nvarchar](5) NULL,
 CONSTRAINT [PK_Stores] PRIMARY KEY CLUSTERED 
(
	[StoreID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT Stores ([StoreID], [StoreName], [StoreAddress], [City], [State], [Zip]) VALUES (N'6380', N'Eric the Read Books', N'788 Catamaugus Ave.', N'Seattle', N'WA', N'98056')
INSERT Stores ([StoreID], [StoreName], [StoreAddress], [City], [State], [Zip]) VALUES (N'7066', N'Barnum''s', N'567 Pasadena Ave.', N'Tustin', N'CA', N'92789')
INSERT Stores ([StoreID], [StoreName], [StoreAddress], [City], [State], [Zip]) VALUES (N'7067', N'News & Brews', N'577 First St.', N'Los Gatos', N'CA', N'96745')
INSERT Stores ([StoreID], [StoreName], [StoreAddress], [City], [State], [Zip]) VALUES (N'7131', N'Doc-U-Mat: Quality Laundry and Books', N'24-A Avogadro Way', N'Remulade', N'WA', N'98014')
INSERT Stores ([StoreID], [StoreName], [StoreAddress], [City], [State], [Zip]) VALUES (N'7896', N'Fricative Bookshop', N'89 Madison St.', N'Fremont', N'CA', N'90019')
INSERT Stores ([StoreID], [StoreName], [StoreAddress], [City], [State], [Zip]) VALUES (N'8042', N'Bookbeat', N'679 Carson St.', N'Portland', N'OR', N'89076')

/****** Object:  Table [dbo].[Discounts] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Discounts (
	[DiscountType] [nvarchar](40) NOT NULL,
	[StoreID] [nvarchar](4) NULL,
	[LowQuantity] [smallint] NULL,
	[HighQuantity] [smallint] NULL,
	[DiscountRate] [decimal](4, 2) NOT NULL,
 CONSTRAINT [PK_Discounts] PRIMARY KEY CLUSTERED 
(
	[DiscountType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT Discounts ([DiscountType], [StoreID], [LowQuantity], [HighQuantity], [DiscountRate]) VALUES (N'Customer Discount', N'8042', NULL, NULL, CAST(5.00 AS Decimal(4, 2)))
INSERT Discounts ([DiscountType], [StoreID], [LowQuantity], [HighQuantity], [DiscountRate]) VALUES (N'Initial Customer', NULL, NULL, NULL, CAST(10.50 AS Decimal(4, 2)))
INSERT Discounts ([DiscountType], [StoreID], [LowQuantity], [HighQuantity], [DiscountRate]) VALUES (N'Volume Discount', NULL, 100, 1000, CAST(6.70 AS Decimal(4, 2)))

/****** Object:  Table [dbo].[Authors] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Authors (
	[AuthorID] [nvarchar](11) NOT NULL,
	[LastName] [nvarchar](40) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[Phone] [nvarchar](12) NOT NULL,
	[Address] [nvarchar](40) NULL,
	[City] [nvarchar](20) NULL,
	[State] [nvarchar](2) NULL,
	[Zip] [nvarchar](5) NULL,
	[Contract] [bit] NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'172-32-1176', N'White', N'Johnson', N'408 496-7223', N'10932 Bigge Rd.', N'Menlo Park', N'CA', N'94025', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'213-46-8915', N'Green', N'Marjorie', N'415 986-7020', N'309 63rd St. #411', N'Oakland', N'CA', N'94618', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'238-95-7766', N'Carson', N'Cheryl', N'415 548-7723', N'589 Darwin Ln.', N'Berkeley', N'CA', N'94705', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'267-41-2394', N'O''Leary', N'Michael', N'408 286-2428', N'22 Cleveland Av. #14', N'San Jose', N'CA', N'95128', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'274-80-9391', N'Straight', N'Dean', N'415 834-2919', N'5420 College Av.', N'Oakland', N'CA', N'94609', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'341-22-1782', N'Smith', N'Meander', N'913 843-0462', N'10 Mississippi Dr.', N'Lawrence', N'KS', N'66044', 0)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'409-56-7008', N'Bennet', N'Abraham', N'415 658-9932', N'6223 Bateman St.', N'Berkeley', N'CA', N'94705', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'427-17-2319', N'Dull', N'Ann', N'415 836-7128', N'3410 Blonde St.', N'Palo Alto', N'CA', N'94301', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'472-27-2349', N'Gringlesby', N'Burt', N'707 938-6445', N'PO Box 792', N'Covelo', N'CA', N'95428', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'486-29-1786', N'Locksley', N'Charlene', N'415 585-4620', N'18 Broadway Av.', N'San Francisco', N'CA', N'94130', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'527-72-3246', N'Greene', N'Morningstar', N'615 297-2723', N'22 Graybar House Rd.', N'Nashville', N'TN', N'37215', 0)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'648-92-1872', N'Blotchet-Halls', N'Reginald', N'503 745-6402', N'55 Hillsdale Bl.', N'Corvallis', N'OR', N'97330', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'672-71-3249', N'Yokomoto', N'Akiko', N'415 935-4228', N'3 Silver Ct.', N'Walnut Creek', N'CA', N'94595', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'712-45-1867', N'del Castillo', N'Innes', N'615 996-8275', N'2286 Cram Pl. #86', N'Ann Arbor', N'MI', N'48105', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'722-51-5454', N'DeFrance', N'Michel', N'219 547-9982', N'3 Balding Pl.', N'Gary', N'IN', N'46403', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'724-08-9931', N'Stringer', N'Dirk', N'415 843-2991', N'5420 Telegraph Av.', N'Oakland', N'CA', N'94609', 0)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'724-80-9391', N'MacFeather', N'Stearns', N'415 354-7128', N'44 Upland Hts.', N'Oakland', N'CA', N'94612', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'756-30-7391', N'Karsen', N'Livia', N'415 534-9219', N'5720 McAuley St.', N'Oakland', N'CA', N'94609', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'807-91-6654', N'Panteley', N'Sylvia', N'301 946-8853', N'1956 Arlington Pl.', N'Rockville', N'MD', N'20853', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'846-92-7186', N'Hunter', N'Sheryl', N'415 836-7128', N'3410 Blonde St.', N'Palo Alto', N'CA', N'94301', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'893-72-1158', N'McBadden', N'Heather', N'707 448-4982', N'301 Putnam', N'Vacaville', N'CA', N'95688', 0)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'899-46-2035', N'Ringer', N'Anne', N'801 826-0752', N'67 Seventh Av.', N'Salt Lake City', N'UT', N'84152', 1)
INSERT Authors ([AuthorID], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [Contract]) VALUES (N'998-72-3567', N'Ringer', N'Albert', N'801 826-0752', N'67 Seventh Av.', N'Salt Lake City', N'UT', N'84152', 1)

/****** Object:  Table [dbo].[Jobs] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Jobs (
	[JobID] [smallint] NOT NULL,
	[JobDescription] [nvarchar](50) NOT NULL,
	[MinimumLevel] [tinyint] NOT NULL,
	[MaximumLevel] [tinyint] NOT NULL,
 CONSTRAINT [PK_Jobs] PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT Jobs ([JobID], [JobDescription], [MinimumLevel], [MaximumLevel]) VALUES (1, N'New Hire - Job not specified', 10, 10)
INSERT Jobs ([JobID], [JobDescription], [MinimumLevel], [MaximumLevel]) VALUES (2, N'Chief Executive Officer', 200, 250)
INSERT Jobs ([JobID], [JobDescription], [MinimumLevel], [MaximumLevel]) VALUES (3, N'Business Operations Manager', 175, 225)
INSERT Jobs ([JobID], [JobDescription], [MinimumLevel], [MaximumLevel]) VALUES (4, N'Chief Financial Officier', 175, 250)
INSERT Jobs ([JobID], [JobDescription], [MinimumLevel], [MaximumLevel]) VALUES (5, N'Publisher', 150, 250)
INSERT Jobs ([JobID], [JobDescription], [MinimumLevel], [MaximumLevel]) VALUES (6, N'Managing Editor', 140, 225)
INSERT Jobs ([JobID], [JobDescription], [MinimumLevel], [MaximumLevel]) VALUES (7, N'Marketing Manager', 120, 200)
INSERT Jobs ([JobID], [JobDescription], [MinimumLevel], [MaximumLevel]) VALUES (8, N'Public Relations Manager', 100, 175)
INSERT Jobs ([JobID], [JobDescription], [MinimumLevel], [MaximumLevel]) VALUES (9, N'Acquisitions Manager', 75, 175)
INSERT Jobs ([JobID], [JobDescription], [MinimumLevel], [MaximumLevel]) VALUES (10, N'Productions Manager', 75, 165)
INSERT Jobs ([JobID], [JobDescription], [MinimumLevel], [MaximumLevel]) VALUES (11, N'Operations Manager', 75, 150)
INSERT Jobs ([JobID], [JobDescription], [MinimumLevel], [MaximumLevel]) VALUES (12, N'Editor', 25, 100)
INSERT Jobs ([JobID], [JobDescription], [MinimumLevel], [MaximumLevel]) VALUES (13, N'Sales Representative', 25, 100)
INSERT Jobs ([JobID], [JobDescription], [MinimumLevel], [MaximumLevel]) VALUES (14, N'Designer', 25, 100)

/****** Object:  Table [dbo].[Publishers] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Publishers (
	[PublisherID] [nvarchar](4) NOT NULL,
	[Name] [nvarchar](40) NULL,
	[City] [nvarchar](20) NULL,
	[State] [nvarchar](2) NULL,
	[Country] [nvarchar](30) NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[PublisherID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT Publishers ([PublisherID], [Name], [City], [State], [Country]) VALUES (N'0736', N'New Moon Books', N'Boston', N'MA', N'USA')
INSERT Publishers ([PublisherID], [Name], [City], [State], [Country]) VALUES (N'0877', N'Binnet & Hardley', N'Washington', N'DC', N'USA')
INSERT Publishers ([PublisherID], [Name], [City], [State], [Country]) VALUES (N'1389', N'Algodata Infosystems', N'Berkeley', N'CA', N'USA')
INSERT Publishers ([PublisherID], [Name], [City], [State], [Country]) VALUES (N'1622', N'Five Lakes Publishing', N'Chicago', N'IL', N'USA')
INSERT Publishers ([PublisherID], [Name], [City], [State], [Country]) VALUES (N'1756', N'Ramona Publishers', N'Dallas', N'TX', N'USA')
INSERT Publishers ([PublisherID], [Name], [City], [State], [Country]) VALUES (N'9901', N'GGG&G', N'München', NULL, N'Germany')
INSERT Publishers ([PublisherID], [Name], [City], [State], [Country]) VALUES (N'9952', N'Scootney Books', N'New York', N'NY', N'USA')
INSERT Publishers ([PublisherID], [Name], [City], [State], [Country]) VALUES (N'9999', N'Lucerne Publishing', N'Paris', NULL, N'France')

/****** Object:  Table [dbo].[Employees] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Employees (
	[EmployeeID] [nvarchar](9) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[MiddleInitial] [nvarchar](1) NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[JobID] [smallint] NOT NULL,
	[JobLevel] [tinyint] NULL,
	[PublisherID] [nvarchar](4) NOT NULL,
	[HireDate] [datetime] NOT NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'A-C71970F', N'Aria', N' ', N'Cruz', 10, 87, N'1389', CAST(0x000082FF00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'AMD15433F', N'Ann', N'M', N'Devon', 3, 200, N'9952', CAST(0x0000829900000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'A-R89858F', N'Annette', N' ', N'Roulet', 6, 152, N'9999', CAST(0x0000809B00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'ARD36773F', N'Anabela', N'R', N'Domingues', 8, 100, N'0877', CAST(0x000084CA00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'CFH28514M', N'Carlos', N'F', N'Hernadez', 5, 211, N'9999', CAST(0x00007F6900000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'CGS88322F', N'Carine', N'G', N'Schmitt', 13, 64, N'1389', CAST(0x000083FE00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'DBT39435M', N'Daniel', N'B', N'Tonini', 11, 75, N'0877', CAST(0x0000806800000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'DWR65030M', N'Diego', N'W', N'Roel', 6, 192, N'1389', CAST(0x0000833200000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'ENL44273F', N'Elizabeth', N'N', N'Lincoln', 14, 35, N'0877', CAST(0x0000813400000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'F-C16315M', N'Francisco', N' ', N'Chang', 4, 227, N'9952', CAST(0x0000819A00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'GHT50241M', N'Gary', N'H', N'Thomas', 9, 170, N'0736', CAST(0x00007E6A00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'HAN90777M', N'Helvetius', N'A', N'Nagy', 7, 120, N'9999', CAST(0x000084FD00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'HAS54740M', N'Howard', N'A', N'Snyder', 12, 100, N'0736', CAST(0x00007ED000000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'H-B39728F', N'Helen', N' ', N'Bennett', 12, 35, N'0877', CAST(0x0000800200000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'JYL26161F', N'Janine', N'Y', N'Labrune', 5, 172, N'9901', CAST(0x0000826600000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'KFJ64308F', N'Karin', N'F', N'Josephs', 14, 100, N'0736', CAST(0x0000846400000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'KJJ92907F', N'Karla', N'J', N'Jablonski', 9, 170, N'9999', CAST(0x0000866200000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'LAL21447M', N'Laurence', N'A', N'Lebihan', 5, 175, N'0736', CAST(0x0000810100000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'L-B31947F', N'Lesley', N' ', N'Brown', 7, 120, N'0877', CAST(0x0000820000000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'MAP77183M', N'Miguel', N'A', N'Paolino', 11, 112, N'1389', CAST(0x0000849700000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'MAS70474F', N'Margaret', N'A', N'Smith', 9, 78, N'1389', CAST(0x00007E9D00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'MFS52347M', N'Martin', N'F', N'Sommer', 10, 165, N'0736', CAST(0x000080CE00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'MGK44605M', N'Matti', N'G', N'Karttunen', 6, 220, N'0736', CAST(0x0000869500000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'MJP25939M', N'Maria', N'J', N'Pontes', 5, 246, N'1756', CAST(0x00007F3600000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'M-L67958F', N'Maria', N' ', N'Larsson', 7, 135, N'1389', CAST(0x0000839800000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'MMS49649F', N'Mary', N'M', N'Saveley', 8, 175, N'0736', CAST(0x0000856300000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'M-P91209M', N'Manuel', N' ', N'Pereira', 8, 101, N'9999', CAST(0x00007F0300000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'M-R38834F', N'Martine', N' ', N'Rance', 9, 75, N'0877', CAST(0x0000836500000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'PCM98509F', N'Patricia', N'C', N'McKenna', 11, 150, N'9999', CAST(0x00007FCF00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'PDI47470M', N'Palle', N'D', N'Ibsen', 7, 195, N'0736', CAST(0x0000853000000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'PHF38899M', N'Peter', N'H', N'Franken', 10, 75, N'0877', CAST(0x000083CB00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'PMA42628M', N'Paolo', N'M', N'Accorti', 13, 35, N'0877', CAST(0x0000843100000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'POK93028M', N'Pirkko', N'O', N'Koskitalo', 10, 80, N'9999', CAST(0x000085FC00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'PSA89086M', N'Pedro', N'S', N'Afonso', 14, 89, N'1389', CAST(0x000081CD00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'PSP68661F', N'Paula', N'S', N'Parente', 8, 125, N'1389', CAST(0x0000862F00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'PTC11962M', N'Philip', N'T', N'Cramer', 2, 215, N'9952', CAST(0x0000803500000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'PXH22250M', N'Paul', N'X', N'Henriot', 5, 159, N'0877', CAST(0x0000859600000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'RBM23061F', N'Rita', N'B', N'Muller', 5, 198, N'1622', CAST(0x000085C900000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'R-M53550M', N'Roland', N' ', N'Mendel', 11, 150, N'0736', CAST(0x000082CC00000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'SKO22412M', N'Sven', N'K', N'Ottlieb', 5, 150, N'1389', CAST(0x0000823300000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'TPO55093M', N'Timothy', N'P', N'O''Rourke', 13, 100, N'0736', CAST(0x00007E3700000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'VPA30890F', N'Victoria', N'P', N'Ashworth', 6, 140, N'0877', CAST(0x0000816700000000 AS DateTime))
INSERT Employees ([EmployeeID], [FirstName], [MiddleInitial], [LastName], [JobID], [JobLevel], [PublisherID], [HireDate]) VALUES (N'Y-L77953M', N'Yoshi', N' ', N'Latimer', 12, 32, N'1389', CAST(0x00007F9C00000000 AS DateTime))

/****** Object:  Table [dbo].[Titles] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Titles (
	[TitleID] [nvarchar](6) NOT NULL,
	[Name] [nvarchar](80) NOT NULL,
	[Type] [nvarchar](12) NOT NULL,
	[PublisherID] [nvarchar](4) NULL,
	[Price] [money] NULL,
	[Advance] [money] NULL,
	[Royalty] [int] NULL,
	[YearToDateSales] [int] NULL,
	[Notes] [nvarchar](200) NULL,
	[PublicationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[TitleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'BU1032', N'The Busy Executive''s Database Guide', N'business    ', N'1389', 19.9900, 5000.0000, 10, 4095, N'An overview of available database systems with emphasis on common business applications. Illustrated.', CAST(0x0000827700000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'BU1111', N'Cooking with Computers: Surreptitious Balance Sheets', N'business    ', N'1389', 11.9500, 5000.0000, 10, 3876, N'Helpful hints on how to use your electronic resources to the best advantage.', CAST(0x0000827400000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'BU2075', N'You Can Combat Computer Stress!', N'business    ', N'0736', 2.9900, 10125.0000, 24, 18722, N'The latest medical and psychological techniques for living with the electronic office. Easy-to-understand explanations.', CAST(0x0000828900000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'BU7832', N'Straight Talk About Computers', N'business    ', N'1389', 19.9900, 5000.0000, 10, 4095, N'Annotated analysis of what computers can do for you: a no-hype guide for the critical user.', CAST(0x0000828100000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'MC2222', N'Silicon Valley Gastronomic Treats', N'mod_cook    ', N'0877', 19.9900, 0.0000, 12, 2032, N'Favorite recipes for quick, easy, and elegant meals.', CAST(0x0000827400000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'MC3021', N'The Gourmet Microwave', N'mod_cook    ', N'0877', 2.9900, 15000.0000, 24, 22246, N'Traditional French gourmet recipes adapted for modern microwave cooking.', CAST(0x0000827D00000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'MC3026', N'The Psychology of Computer Cooking', N'UNDECIDED   ', N'0877', NULL, NULL, NULL, NULL, NULL, CAST(0x00008F860019CA58 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'PC1035', N'But Is It User Friendly?', N'popular_comp', N'1389', 22.9500, 7000.0000, 16, 8780, N'A survey of software for the naive user, focusing on the ''friendliness'' of each.', CAST(0x0000828900000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'PC8888', N'Secrets of Silicon Valley', N'popular_comp', N'1389', 20.0000, 8000.0000, 10, 4095, N'Muckraking reporting on the world''s largest computer hardware and software manufacturers.', CAST(0x000086BF00000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'PC9999', N'Net Etiquette', N'popular_comp', N'1389', NULL, NULL, NULL, NULL, N'A must-read for computer conferencing.', CAST(0x00008F860019CA58 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'PS1372', N'Computer Phobic AND Non-Phobic Individuals: Behavior Variations', N'psychology  ', N'0877', 21.5900, 7000.0000, 10, 375, N'A must for the specialist, this book examines the difference between those who hate and fear computers and those who don''t.', CAST(0x000082FA00000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'PS2091', N'Is Anger the Enemy?', N'psychology  ', N'0736', 10.9500, 2275.0000, 12, 2045, N'Carefully researched study of the effects of strong emotions on the body. Metabolic charts included.', CAST(0x0000827A00000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'PS2106', N'Life Without Fear', N'psychology  ', N'0736', 7.0000, 6000.0000, 10, 111, N'New exercise, meditation, and nutritional techniques that can reduce the shock of daily interactions. Popular audience. Sample menus included, exercise video available separately.', CAST(0x000082EA00000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'PS3333', N'Prolonged Data Deprivation: Four Case Studies', N'psychology  ', N'0736', 19.9900, 2000.0000, 10, 4072, N'What happens when the data runs dry?  Searching evaluations of information-shortage effects.', CAST(0x0000827700000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'PS7777', N'Emotional Security: A New Algorithm', N'psychology  ', N'0736', 7.9900, 4000.0000, 10, 3336, N'Protecting yourself and your loved ones from undue emotional stress in the modern world. Use of computer and nutritional aids emphasized.', CAST(0x0000827700000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'TC3218', N'Onions, Leeks, and Garlic: Cooking Secrets of the Mediterranean', N'trad_cook   ', N'0877', 20.9500, 7000.0000, 10, 375, N'Profusely illustrated in color, this makes a wonderful gift book for a cuisine-oriented friend.', CAST(0x000082FA00000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'TC4203', N'Fifty Years in Buckingham Palace Kitchens', N'trad_cook   ', N'0877', 11.9500, 4000.0000, 14, 15096, N'More anecdotes from the Queen''s favorite cook describing life among English Royalty. Recipes, techniques, tender vignettes.', CAST(0x0000827700000000 AS DateTime))
INSERT Titles ([TitleID], [Name], [Type], [PublisherID], [Price], [Advance], [Royalty], [YearToDateSales], [Notes], [PublicationDate]) VALUES (N'TC7777', N'Sushi, Anyone?', N'trad_cook   ', N'0877', 14.9900, 8000.0000, 10, 4095, N'Detailed instructions on how to make authentic Japanese sushi in your spare time.', CAST(0x0000827700000000 AS DateTime))

/****** Object:  Table [dbo].[TitlesAuthors] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE TitlesAuthors (
	[AuthorID] [nvarchar](11) NOT NULL,
	[TitleID] [nvarchar](6) NOT NULL,
	[AuthorOrder] [tinyint] NULL,
	[Royaltyper] [int] NULL,
 CONSTRAINT [PK_TitleAuthor] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC,
	[TitleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'172-32-1176', N'PS3333', 1, 100)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'213-46-8915', N'BU1032', 2, 40)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'213-46-8915', N'BU2075', 1, 100)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'238-95-7766', N'PC1035', 1, 100)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'267-41-2394', N'BU1111', 2, 40)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'267-41-2394', N'TC7777', 2, 30)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'274-80-9391', N'BU7832', 1, 100)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'409-56-7008', N'BU1032', 1, 60)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'427-17-2319', N'PC8888', 1, 50)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'472-27-2349', N'TC7777', 3, 30)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'486-29-1786', N'PC9999', 1, 100)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'486-29-1786', N'PS7777', 1, 100)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'648-92-1872', N'TC4203', 1, 100)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'672-71-3249', N'TC7777', 1, 40)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'712-45-1867', N'MC2222', 1, 100)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'722-51-5454', N'MC3021', 1, 75)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'724-80-9391', N'BU1111', 1, 60)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'724-80-9391', N'PS1372', 2, 25)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'756-30-7391', N'PS1372', 1, 75)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'807-91-6654', N'TC3218', 1, 100)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'846-92-7186', N'PC8888', 2, 50)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'899-46-2035', N'MC3021', 2, 25)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'899-46-2035', N'PS2091', 2, 50)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'998-72-3567', N'PS2091', 1, 50)
INSERT TitlesAuthors ([AuthorID], [TitleID], [AuthorOrder], [Royaltyper]) VALUES (N'998-72-3567', N'PS2106', 1, 100)

/****** Object:  Table [dbo].[Sales] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Sales (
	[StoreID] [nvarchar](4) NOT NULL,
	[OrderID] [nvarchar](20) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[Quantity] [smallint] NOT NULL,
	[Payterms] [nvarchar](12) NULL,
	[TitleID] [nvarchar](6) NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[StoreID] ASC,
	[OrderID] ASC,
	[TitleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'6380', N'6871', CAST(0x0000871D00000000 AS DateTime), 5, N'Net 60', N'BU1032')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'6380', N'722a', CAST(0x0000871C00000000 AS DateTime), 3, N'Net 60', N'PS2091')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7066', N'123', CAST(0x0000947300000000 AS DateTime), 2, NULL, N'PC1035')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7066', N'4', CAST(0x0000947300000000 AS DateTime), 3, NULL, N'PC1035')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7066', N'A2976', CAST(0x0000853F00000000 AS DateTime), 50, N'Net 30', N'PC8888')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7066', N'QA7442.3', CAST(0x0000871C00000000 AS DateTime), 75, N'ON invoice', N'PS2091')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7067', N'D4482', CAST(0x0000871D00000000 AS DateTime), 10, N'Net 60', N'PS2091')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7067', N'P2121', CAST(0x000083E800000000 AS DateTime), 40, N'Net 30', N'TC3218')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7067', N'P2121', CAST(0x000083E800000000 AS DateTime), 20, N'Net 30', N'TC4203')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7067', N'P2121', CAST(0x000083E800000000 AS DateTime), 20, N'Net 30', N'TC7777')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7131', N'N914008', CAST(0x0000871D00000000 AS DateTime), 20, N'Net 30', N'PS2091')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7131', N'N914014', CAST(0x0000871D00000000 AS DateTime), 25, N'Net 30', N'MC3021')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7131', N'P3087a', CAST(0x0000854400000000 AS DateTime), 20, N'Net 60', N'PS1372')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7131', N'P3087a', CAST(0x0000854400000000 AS DateTime), 25, N'Net 60', N'PS2106')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7131', N'P3087a', CAST(0x0000854400000000 AS DateTime), 15, N'Net 60', N'PS3333')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7131', N'P3087a', CAST(0x0000854400000000 AS DateTime), 25, N'Net 60', N'PS7777')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7896', N'QQ2299', CAST(0x000085DC00000000 AS DateTime), 15, N'Net 60', N'BU7832')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7896', N'TQ456', CAST(0x0000860900000000 AS DateTime), 10, N'Net 60', N'MC2222')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'7896', N'X999', CAST(0x000084E300000000 AS DateTime), 35, N'ON invoice', N'BU2075')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'8042', N'423LL922', CAST(0x0000871D00000000 AS DateTime), 15, N'ON invoice', N'MC3021')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'8042', N'423LL930', CAST(0x0000871D00000000 AS DateTime), 10, N'ON invoice', N'BU1032')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'8042', N'P723', CAST(0x000084F500000000 AS DateTime), 25, N'Net 30', N'BU1111')
INSERT Sales ([StoreID], [OrderID], [OrderDate], [Quantity], [Payterms], [TitleID]) VALUES (N'8042', N'QA879.1', CAST(0x0000853D00000000 AS DateTime), 30, N'Net 30', N'PC1035')

/****** Object:  ForeignKey [FK_pub_info_publishers] ******/

/****** Object:  ForeignKey [FK_Employee_Jobs] ******/
ALTER TABLE Employees  WITH CHECK ADD  CONSTRAINT [FK_Employee_Jobs] FOREIGN KEY([JobID])
REFERENCES Jobs ([JobID])
GO
ALTER TABLE Employees CHECK CONSTRAINT [FK_Employee_Jobs]
GO

/****** Object:  ForeignKey [FK_Employee_Publishers] ******/
ALTER TABLE Employees  WITH CHECK ADD  CONSTRAINT [FK_Employee_Publishers] FOREIGN KEY([PublisherID])
REFERENCES Publishers ([PublisherID])
GO
ALTER TABLE Employees CHECK CONSTRAINT [FK_Employee_Publishers]
GO

/****** Object:  ForeignKey [FK_Titles_Publishers] ******/
ALTER TABLE Titles  WITH CHECK ADD  CONSTRAINT [FK_Titles_Publishers] FOREIGN KEY([PublisherID])
REFERENCES Publishers ([PublisherID])
GO
ALTER TABLE Titles CHECK CONSTRAINT [FK_Titles_Publishers]
GO

/****** Object:  ForeignKey [FK_TitleAuthor_Authors] ******/
ALTER TABLE TitlesAuthors  WITH CHECK ADD  CONSTRAINT [FK_TitleAuthor_Authors] FOREIGN KEY([AuthorID])
REFERENCES Authors ([AuthorID])
GO
ALTER TABLE TitlesAuthors CHECK CONSTRAINT [FK_TitleAuthor_Authors]
GO

/****** Object:  ForeignKey [FK_TitlesAuthors_titles] ******/
ALTER TABLE TitlesAuthors  WITH CHECK ADD  CONSTRAINT [FK_TitlesAuthors_titles] FOREIGN KEY([TitleID])
REFERENCES Titles ([TitleID])
GO
ALTER TABLE TitlesAuthors CHECK CONSTRAINT [FK_TitlesAuthors_titles]
GO

/****** Object:  ForeignKey [FK_Sales_Stores] ******/
ALTER TABLE Sales  WITH CHECK ADD  CONSTRAINT [FK_Sales_Stores] FOREIGN KEY([StoreID])
REFERENCES Stores ([StoreID])
GO
ALTER TABLE Sales CHECK CONSTRAINT [FK_Sales_Stores]
GO

/****** Object:  ForeignKey [FK_Sales_Titles] ******/
ALTER TABLE Sales  WITH CHECK ADD  CONSTRAINT [FK_Sales_Titles] FOREIGN KEY([TitleID])
REFERENCES Titles ([TitleID])
GO
ALTER TABLE Sales CHECK CONSTRAINT [FK_Sales_Titles]
GO
