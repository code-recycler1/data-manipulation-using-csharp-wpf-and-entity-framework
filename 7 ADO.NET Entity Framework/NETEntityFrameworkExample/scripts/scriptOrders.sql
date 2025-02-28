/****** Object:  Table Customers ******/
CREATE TABLE Customers (
	[CustomerID] [nvarchar](5) NOT NULL,
	[Company] [nvarchar](40) NOT NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[Country] [nvarchar](15) NULL,
	[PhoneNumber] [nvarchar](24) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'ALFKI', N'Alfreds Futterkiste', N'Obere Str. 57', N'Berlin', N'12209', N'Germany', N'030-0074321')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'ANATR', N'Ana Trujillo Sandwiches and Ice Cream', N'Avda. de la Constitución 2222', N'Mexico City', N'05021', N'Mexico', N'(5) 555-4729')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'ANTON', N'Antonio Moreno Taquería', N'Mataderos 2312', N'Mexico City', N'05023', N'Mexico', N'(5) 555-3932')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'AROUT', N'Around the Horn', N'120 Hanover Sq.', N'London', N'WA1 1DP', N'United Kingdom', N'(71) 555-7788')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'BERGS', N'Berglunds Supermarket', N'Berguvsvägen 8', N'Luleå', N'S-958 22', N'Sweden', N'0921-12 34 65')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'BLAUS', N'Blauer See Delicatessen', N'Forsterstr. 57', N'Mannheim', N'68306', N'Germany', N'0621-08460')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'BLONP', N'Blondel Father and Son', N'24, place Kléber', N'Strasbourg', N'67000', N'France', N'88.60.15.31')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'BOLID', N'Bólido Prepared Foods', N'C/ Araquil, 67', N'Madrid', N'28023', N'Spain', N'(91) 555 22 82')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'BONAP', N'Bon App', N'12, rue des Bouchers', N'Marseille', N'13008', N'France', N'91.24.45.40')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'BOTTM', N'Bottom-Dollar Markets', N'23 Tsawassen Blvd.', N'Tsawassen', N'T2F 8M4', N'Canada', N'(604) 555-4729')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'BSBEV', N'B''s Beverages', N'Fauntleroy Circus', N'London', N'EC2 5NT', N'United Kingdom', N'(71) 555-1212')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'CACTU', N'Cactus Comidas para llevar', N'Cerrito 333', N'Buenos Aires', N'1010', N'Argentina', N'(1) 135-5555')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'CENTC', N'Centro comercial Moctezuma', N'Sierras de Granada 9993', N'Mexico City', N'05022', N'Mexico', N'(5) 555-3392')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'CHOPS', N'Chop-suey Chinese', N'Hauptstr. 29', N'Bern', N'3012', N'Switzerland', N'0452-076545')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'COMMI', N'Comércio Mineiro', N'Av. dos Lusíadas, 23', N'São Paulo', N'05432-043', N'Brazil', N'(11) 555-7647')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'CONSH', N'Consolidated Holdings', N'Berkeley Gardens 12 Brewery', N'London', N'WX1 6LT', N'United Kingdom', N'(71) 555-2282')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'DRACD', N'Drachenblut Delikatessen', N'Walserweg 21', N'Aachen', N'52066', N'Germany', N'0241-039123')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'DUMON', N'Du monde entier', N'67, rue des Cinquante Otages', N'Nantes', N'44000', N'France', N'40.67.88.88')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'EASTC', N'Eastern Connection', N'35 King George', N'London', N'WX3 6FW', N'United Kingdom', N'(71) 555-0297')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'ERNSH', N'Ernst Handel', N'Kirchgasse 6', N'Graz', N'8010', N'Austria', N'7675-3425')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'FAMIA', N'Familia Arquibaldo', N'Rua Orós, 92', N'São Paulo', N'05442-030', N'Brazil', N'(11) 555-9857')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'FISSA', N'FISSA Fabrica Inter. Salchichas S.A.', N'C/ Moralzarzal, 86', N'Madrid', N'28034', N'Spain', N'(91) 555 94 44')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'FOLIG', N'Folies gourmandes', N'184, chaussée de Tournai', N'Lille', N'59000', N'France', N'20.16.10.16')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'FOLKO', N'Folk och fä HB', N'Åkergatan 24', N'Bräcke', N'S-844 67', N'Sweden', N'0695-34 67 21')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'FRANK', N'Frankenversand', N'Berliner Platz 43', N'Munich', N'80805', N'Germany', N'089-0877310')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'FRANR', N'France restauration', N'54, rue Royale', N'Nantes', N'44000', N'France', N'40.32.21.21')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'FRANS', N'Franchi S.p.A.', N'Via Monte Bianco 34', N'Turin', N'10100', N'Italy', N'011-4988260')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'FURIB', N'Furia Bacalhau e Frutos do Mar', N'Jardim das rosas n. 32', N'Lisbon', N'1675', N'Portugal', N'(1) 354-2534')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'GALED', N'Galería del gastrónomo', N'Rambla de Cataluña, 23', N'Barcelona', N'08022', N'Spain', N'(93) 203 4560')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'GODOS', N'Godos Cocina Típica', N'C/ Romero, 33', N'Seville', N'41101', N'Spain', N'(95) 555 82 82')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'GOURL', N'Gourmet Lanchonetes', N'Av. Brasil, 442', N'Campinas', N'04876-786', N'Brazil', N'(11) 555-9482')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'GREAL', N'Great Lakes Food Market', N'2732 Baker Blvd.', N'Eugene', N'97403', N'USA', N'(503) 555-7555')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'GROSR', N'GROSELLA-Restaurante', N'5ª Ave. Los Palos Grandes', N'Caracas', N'1081', N'Venezuela', N'(2) 283-2951')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'HANAR', N'Hanari Carnes', N'Rua do Paço, 67', N'Rio de Janeiro', N'05454-876', N'Brazil', N'(21) 555-0091')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'HILAA', N'HILARIÓN-Abastos', N'Carrera 22 con Ave. Carlos Soublette #8-35', N'San Cristóbal', N'5022', N'Venezuela', N'(5) 555-1340')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'HUNGC', N'Hungry Coyote Import Store', N'City Center Plaza 516 Main St.', N'Elgin', N'97827', N'USA', N'(503) 555-6874')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'HUNGO', N'Hungry Owl All-Night Grocers', N'8 Johnstown Road', N'Cork', N'2541', N'Ireland', N'2967 542')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'ISLAT', N'Island Trading', N'Garden House Crowther Way', N'Cowes', N'PO31 7PJ', N'UK', N'(198) 555-8888')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'KOENE', N'Königlich Essen', N'Maubelstr. 90', N'Brandenburg', N'14776', N'Germany', N'0555-09876')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'LACOR', N'La corne abondance', N'67, avenue de l''Europe', N'Versailles', N'78000', N'France', N'30.59.84.10')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'LAMAI', N'La maison d''Asie', N'1 rue Alsace-Lorraine', N'Toulouse', N'31000', N'France', N'61.77.61.10')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'LAUGB', N'Laughing Bacchus Wine Cellars', N'1900 Oak St.', N'Vancouver', N'V3F 2K1', N'Canada', N'(604) 555-3392')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'LAZYK', N'Lazy K Kountry Store', N'12 Orchestra Terrace', N'Walla Walla', N'99362', N'USA', N'(509) 555-7969')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'LEHMS', N'Lehmanns Marktstand', N'Magazinweg 7', N'Frankfurt a.M.', N'60528', N'Germany', N'069-0245984')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'LETSS', N'Let Stop N Shop', N'87 Polk St. Suite 5', N'San Francisco', N'94117', N'USA', N'(415) 555-5938')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'LILAS', N'LILA-Supermercado', N'Carrera 52 con Ave. Bolívar #65-98 Llano Largo', N'Barquisimeto', N'3508', N'Venezuela', N'(9) 331-6954')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'LINOD', N'LINO-Delicateses', N'Ave. 5 de Mayo Porlamar', N'I. de Margarita', N'4980', N'Venezuela', N'(8) 34-56-12')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'LONEP', N'Lonesome Pine Restaurant', N'89 Chiaroscuro Rd.', N'Portland', N'97219', N'USA', N'(503) 555-9573')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'MAGAA', N'Magazzini Alimentari Riuniti', N'Via Ludovico il Moro 22', N'Bergamo', N'24100', N'Italy', N'035-640230')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'MAISD', N'Maison Dewey', N'Rue Joseph-Bens 532', N'Brussels', N'B-1180', N'Belgium', N'(02) 201 24 67')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'MEREP', N'Mère Paillarde', N'43 rue St. Laurent', N'Montreal', N'H1J 1C3', N'Canada', N'(514) 555-8054')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'MORGK', N'Morgenstern Gesundkost', N'Heerstr. 22', N'Leipzig', N'04179', N'Germany', N'0342-023176')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'NORTS', N'North/South', N'South House 300 Queensbridge', N'London', N'SW7 1RZ', N'United Kingdom', N'(71) 555-7733')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'OCEAN', N'Océano Atlántico Ltda.', N'Ing. Gustavo Moncada 8585 Piso 20-A', N'Buenos Aires', N'1010', N'Argentina', N'(1) 135-5333')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'OLDWO', N'Old World Delicatessen', N'2743 Bering St.', N'Anchorage', N'99508', N'United States', N'(907) 555-7584')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'OTTIK', N'Ottilies Käseladen', N'Mehrheimerstr. 369', N'Cologne', N'50739', N'Germany', N'0221-0644327')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'PARIS', N'Paris spécialités', N'265, boulevard Charonne', N'Paris', N'75012', N'France', N'(1) 42.34.22.66')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'PERIC', N'Pericles Comidas clásicas', N'Calle Dr. Jorge Cash 321', N'Mexico City', N'05033', N'Mexico', N'(5) 552-3745')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'PICCO', N'Piccolo und mehr', N'Geislweg 14', N'Salzburg', N'5020', N'Austria', N'6562-9722')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'PRINI', N'Princesa Isabel Vinhos', N'Estrada da saúde n. 58', N'Lisbon', N'1756', N'Portugal', N'(1) 356-5634')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'QUEDE', N'Que Delícia', N'Rua da Panificadora, 12', N'Rio de Janeiro', N'02389-673', N'Brazil', N'(21) 555-4252')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'QUEEN', N'Queen Cozinha', N'Alameda dos Canàrios, 891', N'São Paulo', N'05487-020', N'Brazil', N'(11) 555-1189')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'QUICK', N'QUICK-Stop', N'Taucherstraße 10', N'Cunewalde', N'01307', N'Germany', N'0372-035188')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'RANCH', N'Rancho grande', N'Av. del Libertador 900', N'Buenos Aires', N'1010', N'Argentina', N'(1) 123-5555')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'RATTC', N'Rattlesnake Canyon Grocery', N'2817 Milton Dr.', N'Albuquerque', N'87110', N'United States', N'(505) 555-5939')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'REGGC', N'Reggiani Caseifici', N'Strada Provinciale 124', N'Reggio Emilia', N'42100', N'Italy', N'0522-556721')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'RICAR', N'Ricardo Adocicados', N'Av. Copacabana, 267', N'Rio de Janeiro', N'02389-890', N'Brazil', N'(21) 555-3412')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'RICSU', N'Richter Supermarkt', N'Grenzacherweg 237', N'Geneva', N'1203', N'Switzerland', N'0897-034214')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'ROMEY', N'Romero y tomillo', N'Gran Vía, 1', N'Madrid', N'28001', N'Spain', N'(91) 745 6200')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'SANTG', N'Santé Gourmet', N'Erling Skakkes gate 78', N'Stavern', N'4110', N'Norway', N'07-98 92 35')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'SAVEA', N'Save-a-lot Markets', N'187 Suffolk Ln.', N'Boise', N'83720', N'United States', N'(208) 555-8097')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'SEVES', N'Seven Seas Imports', N'90 Wadhurst Rd.', N'London', N'OX15 4NB', N'United Kingdom', N'(71) 555-1717')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'SIMOB', N'Simons bistro', N'Vinbæltet 34', N'Copenhagen', N'1734', N'Denmark', N'31 12 34 56')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'SPECD', N'Spécialités du monde', N'25, rue Lauriston', N'Paris', N'75016', N'France', N'(1) 47.55.60.10')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'SPLIR', N'Split Rail Beer & Ale', N'P.O. Box 555', N'Lander', N'82520', N'USA', N'(307) 555-4680')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'SUPRD', N'Suprêmes délices', N'Boulevard Tirou, 255', N'Charleroi', N'B-6000', N'Belgium', N'(071) 23 67 22 20')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'THEBI', N'The Big Cheese', N'89 Jefferson Way Suite 2', N'Portland', N'97201', N'USA', N'(503) 555-3612')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'THECR', N'The Cracker Box', N'55 Grizzly Peak Rd.', N'Butte', N'59801', N'USA', N'(406) 555-5834')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'TOMSP', N'Toms Spezialitäten', N'Luisenstr. 48', N'Münster', N'44087', N'Germany', N'0251-031259')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'TORTU', N'Tortuga Restaurante', N'Avda. Azteca 123', N'Mexico City', N'05033', N'Mexico', N'(5) 555-2933')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'TRADH', N'Tradição Hipermercados', N'Av. Inês de Castro, 414', N'São Paulo', N'05634-030', N'Brazil', N'(11) 555-2167')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'TRAIH', N'Trail''s Head Gourmet Provisioners', N'722 DaVinci Blvd.', N'Kirkland', N'98034', N'USA', N'(206) 555-8257')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'VAFFE', N'Vaffeljernet', N'Smagsløget 45', N'Århus', N'8200', N'Denmark', N'86 21 32 43')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'VICTE', N'Victuailles en stock', N'2, rue du Commerce', N'Lyon', N'69004', N'France', N'78.32.54.86')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'VINET', N'Vins et alcools Chevalier', N'59 rue de l''Abbaye', N'Reims', N'51100', N'France', N'26.47.15.10')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'WANDK', N'Die Wandernde Kuh', N'Adenauerallee 900', N'Stuttgart', N'70563', N'Germany', N'0711-020361')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'WARTH', N'Wartian Herkku', N'Torikatu 38', N'Oulu', N'90110', N'Finland', N'981-443655')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'WELLI', N'Wellington Importadora', N'Rua do Mercado, 12', N'Resende', N'08737-363', N'Brazil', N'(14) 555-8122')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'WHITC', N'White Clover Markets', N'305 - 14th Ave. S. Suite 3B', N'Seattle', N'98128', N'USA', N'(206) 555-4112')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'WILMK', N'Wilman Kala', N'Keskuskatu 45', N'Helsinki', N'21240', N'Finland', N'90-224 8858')
INSERT Customers ([CustomerID], [Company], [Address], [City], [PostalCode], [Country], [PhoneNumber]) VALUES (N'WOLZA', N'Wolski  Zajazd', N'ul. Filtrowa 68', N'Warsaw', N'01-012', N'Poland', N'(26) 642-7012')

/****** Object:  Table Employees ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Employees (
	[EmployeeID] [int] NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[FirstName] [nvarchar](10) NOT NULL,
	[JobTitle] [nvarchar](30) NULL,
	[CourtesyTitle] [nvarchar](25) NULL,
	[DateOfBirth] [datetime] NULL,
	[HireDate] [datetime] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT Employees ([EmployeeID], [LastName], [FirstName], [JobTitle], [CourtesyTitle], [DateOfBirth], [HireDate]) VALUES (1, N'Davolio', N'Nancy', N'Vice President Sales', N'Ms.', CAST(0x000045D100000000 AS DateTime), CAST(0x000083CF00000000 AS DateTime))
INSERT Employees ([EmployeeID], [LastName], [FirstName], [JobTitle], [CourtesyTitle], [DateOfBirth], [HireDate]) VALUES (2, N'Fuller', N'Andrew', N'Vice President Sales', N'Mr.', CAST(0x00004A6100000000 AS DateTime), CAST(0x0000842400000000 AS DateTime))
INSERT Employees ([EmployeeID], [LastName], [FirstName], [JobTitle], [CourtesyTitle], [DateOfBirth], [HireDate]) VALUES (3, N'Leverling', N'Janet', N'Sales Representative', N'Ms.', CAST(0x00005AD300000000 AS DateTime), CAST(0x0000839D00000000 AS DateTime))
INSERT Employees ([EmployeeID], [LastName], [FirstName], [JobTitle], [CourtesyTitle], [DateOfBirth], [HireDate]) VALUES (4, N'Peacock', N'Margaret', N'Sales Representative', N'Ms.', CAST(0x000035CF00000000 AS DateTime), CAST(0x0000852A00000000 AS DateTime))
INSERT Employees ([EmployeeID], [LastName], [FirstName], [JobTitle], [CourtesyTitle], [DateOfBirth], [HireDate]) VALUES (5, N'Buchanan', N'Steven', N'Sales Manager', N'Mr.', CAST(0x00004EB600000000 AS DateTime), CAST(0x000085D100000000 AS DateTime))
INSERT Employees ([EmployeeID], [LastName], [FirstName], [JobTitle], [CourtesyTitle], [DateOfBirth], [HireDate]) VALUES (6, N'Suyama', N'Michael', N'Sales Representative', N'Mr.', CAST(0x00005A9800000000 AS DateTime), CAST(0x000085D100000000 AS DateTime))
INSERT Employees ([EmployeeID], [LastName], [FirstName], [JobTitle], [CourtesyTitle], [DateOfBirth], [HireDate]) VALUES (7, N'King', N'Robert', N'Sales Representative', N'Mr.', CAST(0x0000562F00000000 AS DateTime), CAST(0x0000861E00000000 AS DateTime))
INSERT Employees ([EmployeeID], [LastName], [FirstName], [JobTitle], [CourtesyTitle], [DateOfBirth], [HireDate]) VALUES (8, N'Callahan', N'Laura', N'Inside Sales Coordinator', N'Ms.', CAST(0x000052C800000000 AS DateTime), CAST(0x0000865C00000000 AS DateTime))
INSERT Employees ([EmployeeID], [LastName], [FirstName], [JobTitle], [CourtesyTitle], [DateOfBirth], [HireDate]) VALUES (9, N'Dodsworth', N'Anne', N'Sales Representative', N'Ms.', CAST(0x00005E4400000000 AS DateTime), CAST(0x0000875B00000000 AS DateTime))/****** Object:  Table Producten    Script Date: 04/27/2015 11:43:48 ******/

/****** Object:  Table Products ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Products (
	[ProductID] [int] NOT NULL,
	[Name] [nvarchar](40) NOT NULL,
	[Packaging] [nvarchar](20) NULL,
	[Price] [money] NULL,
	[Stock] [smallint] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (1, N'Chai', N'10 boxes x 20 bags', 18.0000, 39)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (2, N'Chang', N'24 bottles of 340 g', 19.0000, 17)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (3, N'Aniseed Syrup', N'12 bottles of 550 ml', 10.0000, 13)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (4, N'Chef Anton''s Cajun Seasoning', N'48 jars of 170 g', 22.0000, 53)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (5, N'Chef Anton''s Gumbo Mix', N'36 boxes', 21.3500, 0)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (6, N'Grandma''s Boysenberry Spread', N'12 jars of 230 g', 25.0000, 120)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (7, N'Uncle Bob''s Organic Dried Pears', N'12 packs of 455 g', 30.0000, 15)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (8, N'Northwoods Cranberry Sauce', N'12 packs of 455 g', 40.0000, 6)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (9, N'Mishi Kobe Niku', N'18 packs of 500 g', 97.0000, 29)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (10, N'Ikura', N'12 jars of 200 ml', 31.0000, 31)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (11, N'Queso Cabrales', N'1 kg per package', 21.0000, 22)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (12, N'Queso Manchego La Pastora', N'10 packs of 500 g', 38.0000, 86)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (13, N'Konbu', N'2 kg per package', 6.0000, 24)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (14, N'Tofu', N'40 packs of 100 mg', 23.2500, 35)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (15, N'Genen Shouyu', N'24 bottles of 250 ml', 15.5000, 39)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (16, N'Pavlova', N'32 boxes of 500 g', 17.4500, 29)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (17, N'Alice Mutton', N'20 cans of 1 kg', 39.0000, 0)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (18, N'Carnarvon Tigers', N'16 per package', 62.5000, 42)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (19, N'Teatime Chocolate Biscuits', N'10 boxes x 12 pieces', 9.2000, 25)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (20, N'Sir Rodney''s Marmalade', N'30 gift packages', 81.0000, 40)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (21, N'Sir Rodney''s Scones', N'24 boxes x 4 pieces', 10.0000, 3)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (22, N'Gustaf''s Knäckebröd', N'24 packs of 500 g', 21.0000, 24)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (23, N'Tunnbröd', N'12 packs of 250 g', 9.0000, 61)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (24, N'Guaraná Fantástica', N'12 cans of 355 ml', 4.5000, 20)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (25, N'NuNuCa Nut-Nougat-Cream', N'20 jars of 450 g', 14.0000, 76)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (26, N'Gumbär Gummy Bears', N'100 bags of 250 g', 31.2300, 15)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (27, N'Schoggi Chocolate', N'100 pieces of 100 g', 43.9000, 49)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (28, N'Rössle Sauerkraut', N'25 cans of 825 g', 45.6000, 26)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (29, N'Thüringer Rostbratwurst', N'50 bags x 30 sausages', 123.7900, 0)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (30, N'Nord-Ost Matjes Herring', N'10 jars of 200 g', 25.8900, 10)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (31, N'Gorgonzola Telino', N'12 packs of 100 g', 12.5000, 0)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (32, N'Mascarpone Fabioli', N'24 packs of 200 g', 32.0000, 9)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (33, N'Geitost', N'500 g', 2.5000, 112)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (34, N'Sasquatch Ale', N'24 bottles of 340 g', 14.0000, 111)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (35, N'Steeleye Stout', N'24 bottles of 340 g', 18.0000, 20)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (36, N'Inlagd Sill', N'24 bottles of 250 g', 19.0000, 112)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (37, N'Gravad Lax', N'12 packs of 500 g', 26.0000, 11)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (38, N'Côte de Blaye', N'12 bottles of 75 cl', 263.5000, 17)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (39, N'Chartreuse Verte', N'750 cc per bottle', 18.0000, 69)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (40, N'Boston Crab Meat', N'24 cans of 114 g', 18.4000, 123)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (41, N'Jack''s New England Clam Chowder', N'12 cans of 340 g', 9.6500, 85)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (42, N'Singaporean Hokkien Fried Mee', N'32 packs of 1 kg', 14.0000, 26)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (43, N'Ipoh Coffee', N'16 cans of 500 g', 46.0000, 17)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (44, N'Gula Malacca', N'20 bags of 2 kg', 19.4500, 27)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (45, N'Smoked Herring', N'1 kg/pack', 9.5000, 5)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (46, N'Pickled Herring', N'4 jars of 450 g', 12.0000, 95)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (47, N'Zaanse Cookies', N'10 boxes of 114 g', 9.5000, 36)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (48, N'Chocolate', N'10 bars', 12.7500, 15)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (49, N'Maxilaku', N'24 bags of 50 g', 20.0000, 10)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (50, N'White Chocolate', N'12 bars of 100 g', 16.2500, 65)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (51, N'Manjimup Dried Apples', N'50 packs of 300 g', 53.0000, 20)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (52, N'Filo Mix', N'16 boxes of 2 kg', 7.0000, 38)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (53, N'Perth Pasties', N'48 pieces', 32.8000, 0)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (54, N'Tourtière', N'16 pieces', 7.4500, 21)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (55, N'Pâté chinois', N'24 boxes of 2 pieces', 24.0000, 115)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (56, N'Gnocchi di nonna Alice', N'24 packs of 250 g', 38.0000, 21)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (57, N'Ravioli Angelo', N'24 packs of 250 g', 19.5000, 18)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (58, N'Escargots de Bourgogne', N'24 pieces', 13.2500, 62)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (59, N'Raclette Courdavault', N'5 kg/pack', 55.0000, 79)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (60, N'Camembert Pierrot', N'15 cheeses of 300 g', 34.0000, 19)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (61, N'Maple Syrup', N'24 bottles of 500 ml', 28.5000, 113)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (62, N'Sugar Pie', N'48 pieces', 49.3000, 17)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (63, N'Veggie Spread', N'15 jars of 625 g', 43.9000, 24)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (64, N'Wimmers Good Bread Dumplings', N'20 bags of 4 pieces', 33.2500, 22)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (65, N'Louisiana Fiery Hot Pepper Sauce', N'32 bottles of 230 g', 21.0500, 76)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (66, N'Louisiana Hot Spiced Okra', N'24 bottles of 230 g', 17.0000, 4)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (67, N'Laughing Lumberjack Lager', N'24 bottles of 340 g', 14.0000, 52)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (68, N'Scottish Longbreads', N'10 boxes of 8 pieces', 12.5000, 6)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (69, N'Gudbrandsdalsost', N'10 kg/pack', 36.0000, 26)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (70, N'Outback Lager', N'24 bottles of 355 ml', 15.0000, 15)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (71, N'Fløtemysost', N'10 packs of 500 g', 21.5000, 26)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (72, N'Mozzarella di Giovanni', N'24 packs of 200 g', 34.8000, 14)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (73, N'Red Caviar', N'24 bottles of 150 g', 15.0000, 101)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (74, N'Longlife Tofu', N'5 kg/pack', 10.0000, 4)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (75, N'Rhönbräu Monastery Beer', N'24 bottles of 0.5 l', 7.7500, 125)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (76, N'Cloudberry Liqueur', N'500 ml', 18.0000, 57)
INSERT Products ([ProductID], [Name], [Packaging], [Price], [Stock]) VALUES (77, N'Original Frankfurt Green Sauce', N'12 boxes', 13.0000, 32)

/****** Object:  Table Orders ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Orders(
	[OrderID] [int] NOT NULL,
	[CustomerID] [nvarchar](5) NULL,
	[EmployeeID] [int] NULL,
	[OrderDate] [datetime] NULL,
	[ShippingCompany] [nvarchar](40) NULL,
	[ShippingAddress] [nvarchar](60) NULL,
	[ShippingCity] [nvarchar](15) NULL,
	[ShippingPostalCode] [nvarchar](10) NULL,
	[ShippingCountry] [nvarchar](15) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10248, N'VINET', 5, CAST(0x0000900900000000 AS DateTime), N'Vins et alcools Chevalier', N'59 rue de l''Abbaye', N'Reims', N'51100', N'France')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10249, N'TOMSP', 6, CAST(0x0000900A00000000 AS DateTime), N'Toms Spezialitäten', N'Luisenstr. 48', N'Münster', N'44087', N'Germany')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10250, N'HANAR', 4, CAST(0x0000900D00000000 AS DateTime), N'Hanari Carnes', N'Rua do Paço, 67', N'Rio de Janeiro', N'05454-876', N'Brazil')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10251, N'VICTE', 3, CAST(0x0000900D00000000 AS DateTime), N'Victuailles en stock', N'2, rue du Commerce', N'Lyon', N'69004', N'France')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10252, N'SUPRD', 4, CAST(0x0000900E00000000 AS DateTime), N'Suprêmes délices', N'Boulevard Tirou, 255', N'Charleroi', N'B-6000', N'Belgium')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10253, N'HANAR', 3, CAST(0x0000900F00000000 AS DateTime), N'Hanari Carnes', N'Rua do Paço, 67', N'Rio de Janeiro', N'05454-876', N'Brazil')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10254, N'CHOPS', 5, CAST(0x0000901000000000 AS DateTime), N'Chop-suey Chinese', N'Hauptstr. 31', N'Bern', N'3012', N'Switzerland')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10255, N'RICSU', 9, CAST(0x0000901100000000 AS DateTime), N'Richter Supermarkt', N'Starenweg 5', N'Geneva', N'1204', N'Switzerland')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10256, N'WELLI', 3, CAST(0x0000901400000000 AS DateTime), N'Wellington Importadora', N'Rua do Mercado, 12', N'Resende', N'08737-363', N'Brazil')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10257, N'HILAA', 4, CAST(0x0000901500000000 AS DateTime), N'HILARIÓN-Abastos', N'Carrera 22 con Ave. Carlos Soublette #8-35', N'San Cristóbal', N'5022', N'Venezuela')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10258, N'ERNSH', 1, CAST(0x0000901600000000 AS DateTime), N'Ernst Handel', N'Kirchgasse 6', N'Graz', N'8010', N'Austria')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10259, N'CENTC', 4, CAST(0x0000901700000000 AS DateTime), N'Centro comercial Moctezuma', N'Sierras de Granada 9993', N'Mexico City', N'05022', N'Mexico')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10260, N'OTTIK', 4, CAST(0x0000901800000000 AS DateTime), N'Ottilies Käseladen', N'Mehrheimerstr. 369', N'Cologne', N'50739', N'Germany')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10261, N'QUEDE', 4, CAST(0x0000901800000000 AS DateTime), N'Que Delícia', N'Rua da Panificadora, 12', N'Rio de Janeiro', N'02389-673', N'Brazil')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10262, N'RATTC', 8, CAST(0x0000901B00000000 AS DateTime), N'Rattlesnake Canyon Grocery', N'2817 Milton Dr.', N'Albuquerque', N'87110', N'United States')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10263, N'ERNSH', 9, CAST(0x0000901C00000000 AS DateTime), N'Ernst Handel', N'Kirchgasse 6', N'Graz', N'8010', N'Austria')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10264, N'FOLKO', 6, CAST(0x0000901D00000000 AS DateTime), N'Folk och fä HB', N'Åkergatan 24', N'Bräcke', N'S-844 67', N'Sweden')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10265, N'BLONP', 2, CAST(0x0000901E00000000 AS DateTime), N'Blondel père et fils', N'24, place Kléber', N'Strasbourg', N'67000', N'France')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10266, N'WARTH', 3, CAST(0x0000901F00000000 AS DateTime), N'Wartian Herkku', N'Torikatu 38', N'Oulu', N'90110', N'Finland')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10267, N'FRANK', 4, CAST(0x0000902200000000 AS DateTime), N'Frankenversand', N'Berliner Platz 43', N'Munich', N'80805', N'Germany')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10268, N'GROSR', 8, CAST(0x0000902300000000 AS DateTime), N'GROSELLA-Restaurante', N'5ª Ave. Los Palos Grandes', N'Caracas', N'1081', N'Venezuela')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10269, N'WHITC', 5, CAST(0x0000902400000000 AS DateTime), N'White Clover Markets', N'1029 - 12th Ave. S.', N'Seattle', N'98124', N'United States')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10270, N'WARTH', 1, CAST(0x0000902500000000 AS DateTime), N'Wartian Herkku', N'Torikatu 38', N'Oulu', N'90110', N'Finland')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10271, N'SPLIR', 6, CAST(0x0000902500000000 AS DateTime), N'Split Rail Beer & Ale', N'P.O. Box 555', N'Lander', N'82520', N'United States')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10272, N'RATTC', 6, CAST(0x0000902600000000 AS DateTime), N'Rattlesnake Canyon Grocery', N'2817 Milton Dr.', N'Albuquerque', N'87110', N'United States')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10273, N'QUICK', 3, CAST(0x0000902900000000 AS DateTime), N'QUICK-Stop', N'Taucherstraße 10', N'Cunewalde', N'01307', N'Germany')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10274, N'VINET', 6, CAST(0x0000902A00000000 AS DateTime), N'Vins et alcools Chevalier', N'59 rue de l''Abbaye', N'Reims', N'51100', N'France')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10275, N'MAGAA', 1, CAST(0x0000902B00000000 AS DateTime), N'Magazzini Alimentari Riuniti', N'Via Ludovico il Moro 22', N'Bergamo', N'24100', N'Italy')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10276, N'TORTU', 8, CAST(0x0000902C00000000 AS DateTime), N'Tortuga Restaurante', N'Avda. Azteca 123', N'Mexico City', N'05033', N'Mexico')
INSERT Orders ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippingCompany], [ShippingAddress], [ShippingCity], [ShippingPostalCode], [ShippingCountry]) VALUES (10277, N'MORGK', 2, CAST(0x0000902D00000000 AS DateTime), N'Morgenstern Gesundkost', N'Heerstr. 22', N'Leipzig', N'04179', N'Germany')

/****** Object:  Table Order lines ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE OrderLines (
    [OrderID] [int] NOT NULL,
    [ProductID] [int] NOT NULL,
    [UnitPrice] [float] NOT NULL,
    [Quantity] [smallint] NOT NULL,
 CONSTRAINT [PK_OrderLines] PRIMARY KEY CLUSTERED 
(
    [OrderID] ASC,
    [ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10248, 11, 14, 12)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10248, 42, 10, 10)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10248, 72, 35, 5)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10249, 14, 19, 9)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10249, 51, 42, 40)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10250, 41, 8, 10)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10250, 51, 42, 35)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10250, 65, 17, 15)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10251, 22, 17, 6)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10251, 57, 16, 15)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10251, 65, 17, 20)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10252, 20, 65, 40)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10252, 33, 2, 25)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10252, 60, 27, 40)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10253, 31, 10, 20)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10253, 39, 14, 42)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10253, 49, 16, 40)
INSERT OrderLines ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (10254, 24, 4, 15)

/****** Object:  ForeignKey [FK_Orders_Customers] ******/
ALTER TABLE Orders WITH CHECK ADD CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID])
REFERENCES Customers ([CustomerID])
GO
ALTER TABLE Orders CHECK CONSTRAINT [FK_Orders_Customers]
GO
/****** Object:  ForeignKey [FK_Orders_Employees] ******/
ALTER TABLE Orders WITH CHECK ADD CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeID])
REFERENCES Employees ([EmployeeID])
GO
ALTER TABLE Orders CHECK CONSTRAINT [FK_Orders_Employees]
GO
/****** Object:  ForeignKey [FK_OrderLines_Orders] ******/
ALTER TABLE OrderLines WITH CHECK ADD CONSTRAINT [FK_OrderLines_Orders] FOREIGN KEY([OrderID])
REFERENCES Orders ([OrderID])
GO
ALTER TABLE OrderLines CHECK CONSTRAINT [FK_OrderLines_Orders]
GO
/****** Object:  ForeignKey [FK_OrderLines_Products] ******/
ALTER TABLE OrderLines WITH CHECK ADD CONSTRAINT [FK_OrderLines_Products] FOREIGN KEY([ProductID])
REFERENCES Products ([ProductID])
GO
ALTER TABLE OrderLines CHECK CONSTRAINT [FK_OrderLines_Products]
GO
