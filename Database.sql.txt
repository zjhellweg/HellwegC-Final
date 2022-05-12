USE [master]
GO
/****** Object:  Database [DriverDatabase]    Script Date: 5/11/2022 11:01:14 PM ******/
CREATE DATABASE [DriverDatabase]

GO

USE [DriverDatabase]
GO
/****** Object:  Table [dbo].[Drivers]    Script Date: 5/11/2022 11:01:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drivers](
	[DriverIndex] [int] NOT NULL,
	[FirstName] [varchar](20) NULL,
	[LastName] [varchar](20) NULL,
	[DateOfBirth] [datetime] NULL,
	[SSN] [varchar](9) NULL,
PRIMARY KEY CLUSTERED 
(
	[DriverIndex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 5/11/2022 11:01:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[VehicleIndex] [int] NOT NULL,
	[VehicleOwner] [int] NULL,
	[VehiclePlate] [varchar](10) NULL,
	[VehicleAge] [datetime] NULL,
	[Color] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[VehicleIndex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DriverCars]    Script Date: 5/11/2022 11:01:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[DriverCars]
As
Select
	D.DriverIndex as ID,
	D.FirstName,
	D.LastName,
	D.SSN,
	V.VehiclePlate
From
	Drivers D
Join 
	Vehicle V on D.DriverIndex = V.VehicleOwner
GO
/****** Object:  Table [dbo].[EmployeeAccounts]    Script Date: 5/11/2022 11:01:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeAccounts](
	[EmployeeIndex] [int] NOT NULL,
	[EmployeeUser] [varchar](20) NULL,
	[EmployeePassword] [varchar](20) NULL,
	[EmployeeRole] [varchar](20) NULL,
	[EmployeeLogins] [int] NULL,
 CONSTRAINT [AccountPrimary] PRIMARY KEY CLUSTERED 
(
	[EmployeeIndex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 5/11/2022 11:01:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeIndex] [int] NOT NULL,
	[FirstName] [varchar](20) NULL,
	[LastName] [varchar](20) NULL,
	[DateOfBirth] [datetime] NULL,
	[EMPRoleIndex] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeIndex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpRoles]    Script Date: 5/11/2022 11:01:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpRoles](
	[EmpRoleIndex] [int] NOT NULL,
	[EmpRoleTitle] [varchar](20) NULL,
	[EmpRoleDescription] [varchar](400) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpRoleIndex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Infractions]    Script Date: 5/11/2022 11:01:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Infractions](
	[InfractionIndex] [int] NOT NULL,
	[EmployeeIndex] [int] NULL,
	[VehicleIndex] [int] NULL,
	[InfractionTypeIndex] [int] NULL,
	[InfractionDate] [datetime] NULL,
	[Notes] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[InfractionIndex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InfractionType]    Script Date: 5/11/2022 11:01:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InfractionType](
	[InfractionTypeIndex] [int] NOT NULL,
	[InfractionTypeDescription] [varchar](400) NULL,
	[InfractionTypeName] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[InfractionTypeIndex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (0, N'Ralph', N'Carter', NULL, N'764370155')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (1, N'Tyler', N'Wright', NULL, N'632649231')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (2, N'Christian', N'Nguyen', NULL, N'254097977')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (3, N'Lawrence', N'Evans', NULL, N'129650510')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (4, N'Kathleen', N'Price', NULL, N'231954798')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (5, N'Amy', N'Kim', NULL, N'322645434')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (6, N'Victoria', N'Lee', NULL, N'126624781')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (7, N'Brittany', N'Ruiz', NULL, N'780564380')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (8, N'Doris', N'Roberts', NULL, N'48988580')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (9, N'Beverly', N'Price', NULL, N'455550194')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (10, N'Natalie', N'Price', NULL, N'27022652')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (11, N'Susan', N'Cooper', NULL, N'500063910')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (12, N'Roy', N'Allen', NULL, N'266863528')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (13, N'Nathan', N'Carter', NULL, N'761583499')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (14, N'Kathryn', N'Miller', NULL, N'18112013')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (15, N'Anthony', N'Young', NULL, N'210882465')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (16, N'Jean', N'Flores', NULL, N'338971168')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (17, N'Andrew', N'Parker', NULL, N'420012281')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (18, N'Adam', N'Perez', NULL, N'451128378')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (19, N'Hannah', N'Richardson', NULL, N'150419475')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (20, N'Gabriel', N'Walker', NULL, N'264289519')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (21, N'Jennifer', N'Peterson', NULL, N'107009896')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (22, N'Dennis', N'Evans', NULL, N'139383323')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (23, N'Alice', N'Richardson', NULL, N'546326076')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (24, N'Jerry', N'Chavez', NULL, N'81070448')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (25, N'Frances', N'Ruiz', NULL, N'798286799')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (26, N'Kayla', N'Lopez', NULL, N'775790063')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (27, N'Roger', N'Torres', NULL, N'693902327')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (28, N'Gabriel', N'Reed', NULL, N'302997751')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (29, N'Melissa', N'Foster', NULL, N'346252181')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (30, N'Marilyn', N'Hernandez', NULL, N'2729830')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (31, N'Thomas', N'Bailey', NULL, N'732619675')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (32, N'Nicole', N'Sanders', NULL, N'951142264')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (33, N'Kelly', N'Green', NULL, N'249586732')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (34, N'Jacqueline', N'Ramos', NULL, N'258420676')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (35, N'Vincent', N'Brown', NULL, N'229577141')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (36, N'Larry', N'Edwards', NULL, N'807439617')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (37, N'Christine', N'White', NULL, N'693513788')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (38, N'Dorothy', N'Ortiz', NULL, N'339537737')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (39, N'Jordan', N'Ortiz', NULL, N'930551537')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (40, N'Barbara', N'Allen', NULL, N'787594426')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (41, N'Melissa', N'Jackson', NULL, N'813487865')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (42, N'Nancy', N'Ross', NULL, N'689177970')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (43, N'Nancy', N'James', NULL, N'165854113')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (44, N'Vincent', N'Sanders', NULL, N'878615505')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (45, N'Jennifer', N'Diaz', NULL, N'185843941')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (46, N'Grace', N'Parker', NULL, N'441772959')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (47, N'Richard', N'Diaz', NULL, N'453664338')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (48, N'Bryan', N'Flores', NULL, N'819306437')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (49, N'Gary', N'Turner', NULL, N'123751712')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (50, N'Joan', N'Castillo', NULL, N'497609993')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (51, N'Marie', N'Alvarez', NULL, N'177931474')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (52, N'Dennis', N'Stewart', NULL, N'510324513')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (53, N'Roger', N'Lee', NULL, N'178702320')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (54, N'Julie', N'Foster', NULL, N'416862850')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (55, N'Gerald', N'Diaz', NULL, N'994649567')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (56, N'Christine', N'Bailey', NULL, N'382484872')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (57, N'Louis', N'Young', NULL, N'95126427')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (58, N'Jacob', N'Wright', NULL, N'103472247')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (59, N'Janet', N'Rodriguez', NULL, N'116985405')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (60, N'Ryan', N'Mendoza', NULL, N'850146466')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (61, N'Christopher', N'Gutierrez', NULL, N'9090971')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (62, N'Jeremy', N'Scott', NULL, N'936416756')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (63, N'Michael', N'Rivera', NULL, N'38015237')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (64, N'Olivia', N'Gutierrez', NULL, N'391052743')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (65, N'Ethan', N'Brown', NULL, N'834047714')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (66, N'Nicole', N'Allen', NULL, N'537563815')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (67, N'Eugene', N'Diaz', NULL, N'586552327')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (68, N'Gerald', N'Brown', NULL, N'300333461')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (69, N'Susan', N'Mitchell', NULL, N'190133697')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (70, N'Doris', N'Kelly', NULL, N'537623822')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (71, N'Lawrence', N'Cook', NULL, N'475135384')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (72, N'Victoria', N'Wilson', NULL, N'942518504')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (73, N'Jessica', N'Rodriguez', NULL, N'256718907')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (74, N'Brian', N'Gutierrez', NULL, N'3591917')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (75, N'Amanda', N'Garcia', NULL, N'744365765')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (76, N'Samuel', N'Reed', NULL, N'821384287')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (77, N'Austin', N'Rogers', NULL, N'331777179')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (78, N'Anthony', N'Thompson', NULL, N'915232714')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (79, N'Heather', N'Mitchell', NULL, N'518689347')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (80, N'Anthony', N'Thompson', NULL, N'106592674')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (81, N'Peter', N'Alvarez', NULL, N'760395917')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (82, N'Amy', N'Diaz', NULL, N'627456267')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (83, N'Dylan', N'Jackson', NULL, N'2610913')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (84, N'Lori', N'Hughes', NULL, N'969222118')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (85, N'Sean', N'Rogers', NULL, N'57066451')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (86, N'Arthur', N'Gonzalez', NULL, N'886365410')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (87, N'Jean', N'Kim', NULL, N'515829517')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (88, N'Kimberly', N'Jones', NULL, N'683728931')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (89, N'Dorothy', N'Gutierrez', NULL, N'231846841')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (90, N'Jennifer', N'Mendoza', NULL, N'288018878')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (91, N'Timothy', N'Foster', NULL, N'114465072')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (92, N'Rachel', N'Rodriguez', NULL, N'629646175')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (93, N'Doris', N'Campbell', NULL, N'544856507')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (94, N'Sandra', N'Sanders', NULL, N'197977272')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (95, N'Lawrence', N'Davis', NULL, N'956300301')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (96, N'Bobby', N'Ramos', NULL, N'474413285')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (97, N'Ethan', N'Kelly', NULL, N'368189228')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (98, N'Dylan', N'Baker', NULL, N'77595786')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (99, N'Justin', N'Jones', NULL, N'713447170')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (100, N'Lauren', N'Bailey', NULL, N'823958603')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (101, N'Gerald', N'Wright', NULL, N'487855623')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (102, N'Samantha', N'Jackson', NULL, N'670847951')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (103, N'Peter', N'Martinez', NULL, N'963316130')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (104, N'Raymond', N'Jimenez', NULL, N'685229239')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (105, N'Nathan', N'Clark', NULL, N'885282352')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (106, N'Sandra', N'Green', NULL, N'741546156')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (107, N'Mary', N'Parker', NULL, N'802317936')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (108, N'Nancy', N'Collins', NULL, N'714174137')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (109, N'Frances', N'Mendoza', NULL, N'973627486')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (110, N'Roy', N'Allen', NULL, N'924196585')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (111, N'Julia', N'Parker', NULL, N'811969292')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (112, N'Alice', N'Sanders', NULL, N'431311613')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (113, N'Brittany', N'Garcia', NULL, N'4531208')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (114, N'Gregory', N'Wood', NULL, N'235134648')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (115, N'Helen', N'Peterson', NULL, N'207087771')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (116, N'Gregory', N'Brown', NULL, N'523365749')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (117, N'Katherine', N'Watson', NULL, N'149138573')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (118, N'Amanda', N'Gonzalez', NULL, N'471098776')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (119, N'Kimberly', N'Nelson', NULL, N'477806214')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (120, N'Dylan', N'Moore', NULL, N'357859564')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (121, N'Scott', N'Williams', NULL, N'208516396')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (122, N'Henry', N'Miller', NULL, N'963968936')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (123, N'John', N'Wood', NULL, N'349117222')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (124, N'Juan', N'Moore', NULL, N'333879799')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (125, N'Russell', N'Jimenez', NULL, N'314805058')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (126, N'Charlotte', N'Nelson', NULL, N'313351828')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (127, N'Dylan', N'Alvarez', NULL, N'700905219')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (128, N'Peter', N'Davis', NULL, N'818306215')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (129, N'Amanda', N'Chavez', NULL, N'190264570')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (130, N'Evelyn', N'Cox', NULL, N'114891525')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (131, N'Kenneth', N'Brooks', NULL, N'875579579')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (132, N'Jose', N'Thomas', NULL, N'281043638')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (133, N'Brittany', N'Thompson', NULL, N'915166447')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (134, N'Teresa', N'Martin', NULL, N'845917060')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (135, N'Kevin', N'King', NULL, N'49016406')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (136, N'Susan', N'Scott', NULL, N'398068699')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (137, N'Isabella', N'Watson', NULL, N'284237193')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (138, N'Lisa', N'Collins', NULL, N'400328268')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (139, N'Heather', N'Jimenez', NULL, N'41888786')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (140, N'Bruce', N'Lopez', NULL, N'216431109')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (141, N'Anna', N'Gomez', NULL, N'417708818')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (142, N'Walter', N'Johnson', NULL, N'374960976')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (143, N'Doris', N'Cox', NULL, N'650076880')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (144, N'Ralph', N'Smith', NULL, N'667145856')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (145, N'Jesse', N'Myers', NULL, N'652944282')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (146, N'Ethan', N'Lee', NULL, N'5946864')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (147, N'Theresa', N'Howard', NULL, N'896655859')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (148, N'Lawrence', N'Reyes', NULL, N'912793177')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (149, N'Ronald', N'Long', NULL, N'715671877')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (150, N'Olivia', N'Price', NULL, N'452590410')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (151, N'Terry', N'Lee', NULL, N'806907578')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (152, N'Alexis', N'Martin', NULL, N'80810911')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (153, N'Sandra', N'Williams', NULL, N'710849522')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (154, N'Dylan', N'Turner', NULL, N'778051655')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (155, N'Jack', N'Miller', NULL, N'458096997')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (156, N'Samuel', N'Diaz', NULL, N'471204412')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (157, N'Kyle', N'Edwards', NULL, N'402008794')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (158, N'Roy', N'Chavez', NULL, N'439787580')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (159, N'Beverly', N'Bailey', NULL, N'307176324')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (160, N'Dennis', N'Patel', NULL, N'600803966')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (161, N'Helen', N'Myers', NULL, N'30657508')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (162, N'Rebecca', N'Cooper', NULL, N'83633898')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (163, N'Charlotte', N'Robinson', NULL, N'379584127')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (164, N'Gary', N'Long', NULL, N'475209759')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (165, N'Mark', N'Anderson', NULL, N'351436469')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (166, N'Lori', N'Allen', NULL, N'988015878')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (167, N'David', N'Thomas', NULL, N'926233019')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (168, N'Adam', N'Murphy', NULL, N'926427040')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (169, N'Gerald', N'Brown', NULL, N'893879177')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (170, N'Kimberly', N'Diaz', NULL, N'276896634')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (171, N'Henry', N'Bailey', NULL, N'208963184')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (172, N'Deborah', N'Anderson', NULL, N'753768956')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (173, N'Cheryl', N'Foster', NULL, N'155310038')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (174, N'Douglas', N'Garcia', NULL, N'724652742')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (175, N'Shirley', N'Martinez', NULL, N'738394934')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (176, N'Ann', N'Jimenez', NULL, N'250279223')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (177, N'Diane', N'Stewart', NULL, N'369268168')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (178, N'Joseph', N'Parker', NULL, N'699913950')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (179, N'Lawrence', N'Young', NULL, N'30147923')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (180, N'Heather', N'Kim', NULL, N'110401371')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (181, N'Eugene', N'Smith', NULL, N'707990731')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (182, N'Patrick', N'Rogers', NULL, N'268053558')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (183, N'Abigail', N'Hernandez', NULL, N'209542198')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (184, N'Edward', N'Walker', NULL, N'775130591')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (185, N'Charlotte', N'Taylor', NULL, N'546247953')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (186, N'Pamela', N'Brooks', NULL, N'362291079')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (187, N'Raymond', N'Lewis', NULL, N'656640985')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (188, N'Jennifer', N'Morales', NULL, N'542642311')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (189, N'Mason', N'Scott', NULL, N'85226900')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (190, N'Karen', N'Hernandez', NULL, N'839692638')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (191, N'Gabriel', N'Hall', NULL, N'979849011')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (192, N'Nancy', N'Cooper', NULL, N'995321605')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (193, N'Robert', N'Roberts', NULL, N'137618209')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (194, N'Brian', N'King', NULL, N'653722542')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (195, N'Olivia', N'Hernandez', NULL, N'469818050')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (196, N'Patricia', N'Robinson', NULL, N'959741835')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (197, N'Jacob', N'Johnson', NULL, N'249551457')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (198, N'Laura', N'Howard', NULL, N'948421285')
GO
INSERT [dbo].[Drivers] ([DriverIndex], [FirstName], [LastName], [DateOfBirth], [SSN]) VALUES (199, N'Brenda', N'Campbell', NULL, N'267983669')
GO
INSERT [dbo].[EmployeeAccounts] ([EmployeeIndex], [EmployeeUser], [EmployeePassword], [EmployeeRole], [EmployeeLogins]) VALUES (0, N'test', N'password', N'dmv', 0)
GO
INSERT [dbo].[EmployeeAccounts] ([EmployeeIndex], [EmployeeUser], [EmployeePassword], [EmployeeRole], [EmployeeLogins]) VALUES (1, N'test2', N'password2', N'cop', 0)
GO
INSERT [dbo].[EmployeeAccounts] ([EmployeeIndex], [EmployeeUser], [EmployeePassword], [EmployeeRole], [EmployeeLogins]) VALUES (2, N'test3', N'password3', N'none', 0)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (0, N'Abigail', N'Jackson', NULL, 1)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (1, N'Wayne', N'Robinson', NULL, 4)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (2, N'Martha', N'Gray', NULL, 4)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (3, N'Matthew', N'Hill', NULL, 0)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (4, N'Beverly', N'Richardson', NULL, 3)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (5, N'Jeremy', N'Long', NULL, 0)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (6, N'Jeffrey', N'White', NULL, 2)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (7, N'Nicholas', N'Anderson', NULL, 0)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (8, N'Katherine', N'Robinson', NULL, 4)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (9, N'Amanda', N'White', NULL, 2)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (10, N'Eugene', N'Ward', NULL, 1)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (11, N'Scott', N'Morris', NULL, 1)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (12, N'Kyle', N'Brown', NULL, 3)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (13, N'Anna', N'King', NULL, 2)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (14, N'Kimberly', N'Hughes', NULL, 4)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (15, N'Vincent', N'Jackson', NULL, 4)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (16, N'Donald', N'Mitchell', NULL, 4)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (17, N'Philip', N'Gutierrez', NULL, 2)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (18, N'Alan', N'Evans', NULL, 3)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (19, N'Megan', N'Evans', NULL, 2)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (20, N'Judith', N'Reed', NULL, 0)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (21, N'Dennis', N'Edwards', NULL, 0)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (22, N'Andrea', N'Rogers', NULL, 4)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (23, N'Amanda', N'Carter', NULL, 1)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (24, N'Juan', N'James', NULL, 3)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (25, N'Larry', N'Thomas', NULL, 4)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (26, N'Kathleen', N'Gonzalez', NULL, 1)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (27, N'Eric', N'Harris', NULL, 4)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (28, N'Bobby', N'Scott', NULL, 3)
GO
INSERT [dbo].[Employees] ([EmployeeIndex], [FirstName], [LastName], [DateOfBirth], [EMPRoleIndex]) VALUES (29, N'Rachel', N'Rogers', NULL, 2)
GO
INSERT [dbo].[EmpRoles] ([EmpRoleIndex], [EmpRoleTitle], [EmpRoleDescription]) VALUES (0, N'Cop', N'Protects and Serves')
GO
INSERT [dbo].[EmpRoles] ([EmpRoleIndex], [EmpRoleTitle], [EmpRoleDescription]) VALUES (1, N'Deputy', N'Higher Ranking Cop')
GO
INSERT [dbo].[EmpRoles] ([EmpRoleIndex], [EmpRoleTitle], [EmpRoleDescription]) VALUES (2, N'Sherif', N'Higher Ranking Deputy')
GO
INSERT [dbo].[EmpRoles] ([EmpRoleIndex], [EmpRoleTitle], [EmpRoleDescription]) VALUES (3, N'Dective', N'Investigates Crime')
GO
INSERT [dbo].[EmpRoles] ([EmpRoleIndex], [EmpRoleTitle], [EmpRoleDescription]) VALUES (4, N'Texas Ranger', N'Beats up bad guys')
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (0, 8, 87, 5, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (1, 20, 90, 7, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (2, 12, 209, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (3, 16, 294, 2, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (4, 2, 110, 8, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (5, 10, 126, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (6, 19, 233, 2, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (7, 28, 29, 8, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (8, 4, 80, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (9, 7, 140, 2, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (10, 9, 98, 3, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (11, 27, 4, 2, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (12, 9, 59, 3, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (13, 9, 38, 5, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (14, 24, 391, 2, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (15, 11, 51, 6, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (16, 10, 205, 4, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (17, 0, 101, 2, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (18, 10, 219, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (19, 27, 195, 0, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (20, 3, 221, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (21, 28, 304, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (22, 16, 171, 3, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (23, 8, 171, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (24, 3, 294, 2, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (25, 7, 143, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (26, 5, 139, 8, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (27, 11, 216, 6, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (28, 23, 213, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (29, 2, 213, 4, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (30, 23, 346, 6, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (31, 2, 241, 5, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (32, 5, 309, 4, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (33, 22, 127, 2, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (34, 21, 113, 6, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (35, 9, 387, 5, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (36, 10, 53, 7, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (37, 1, 264, 7, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (38, 29, 351, 4, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (39, 9, 318, 8, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (40, 26, 363, 6, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (41, 17, 354, 2, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (42, 16, 19, 6, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (43, 10, 95, 0, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (44, 24, 8, 5, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (45, 23, 391, 7, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (46, 7, 105, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (47, 25, 243, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (48, 7, 228, 0, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (49, 14, 164, 0, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (50, 26, 393, 9, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (51, 7, 7, 6, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (52, 3, 323, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (53, 1, 337, 7, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (54, 28, 8, 4, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (55, 28, 242, 3, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (56, 16, 303, 0, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (57, 15, 334, 9, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (58, 18, 5, 6, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (59, 10, 290, 3, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (60, 18, 2, 9, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (61, 16, 24, 2, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (62, 10, 184, 2, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (63, 26, 346, 9, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (64, 24, 23, 6, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (65, 11, 192, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (66, 17, 48, 3, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (67, 10, 343, 0, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (68, 0, 212, 2, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (69, 10, 353, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (70, 20, 122, 3, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (71, 17, 168, 5, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (72, 23, 378, 2, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (73, 15, 140, 2, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (74, 28, 257, 4, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (75, 10, 111, 8, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (76, 15, 303, 6, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (77, 23, 82, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (78, 24, 206, 7, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (79, 19, 324, 8, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (80, 27, 192, 9, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (81, 4, 308, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (82, 5, 158, 7, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (83, 9, 2, 1, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (84, 25, 166, 8, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (85, 11, 129, 4, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (86, 19, 338, 5, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (87, 20, 328, 7, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (88, 17, 123, 0, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (89, 14, 91, 7, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (90, 6, 364, 4, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (91, 27, 87, 6, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (92, 16, 293, 0, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (93, 18, 6, 3, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (94, 22, 351, 7, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (95, 13, 128, 4, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (96, 26, 231, 8, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (97, 19, 271, 4, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (98, 17, 98, 3, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[Infractions] ([InfractionIndex], [EmployeeIndex], [VehicleIndex], [InfractionTypeIndex], [InfractionDate], [Notes]) VALUES (99, 12, 358, 6, CAST(N'2022-05-11T11:50:41.487' AS DateTime), NULL)
GO
INSERT [dbo].[InfractionType] ([InfractionTypeIndex], [InfractionTypeDescription], [InfractionTypeName]) VALUES (0, N'Driver was going above the speed limit', N'Speeding Ticket')
GO
INSERT [dbo].[InfractionType] ([InfractionTypeIndex], [InfractionTypeDescription], [InfractionTypeName]) VALUES (1, N'Driver was going well above the speed limit', N'Excessive Speeding')
GO
INSERT [dbo].[InfractionType] ([InfractionTypeIndex], [InfractionTypeDescription], [InfractionTypeName]) VALUES (2, N'Driver faild to use turn signal prior to turn', N'Turn Signal')
GO
INSERT [dbo].[InfractionType] ([InfractionTypeIndex], [InfractionTypeDescription], [InfractionTypeName]) VALUES (3, N'Driver was inebriated at, thus a danger to themselves and others', N'DUI')
GO
INSERT [dbo].[InfractionType] ([InfractionTypeIndex], [InfractionTypeDescription], [InfractionTypeName]) VALUES (4, N'Driver fled the instead of pulling over', N'Resisting Arrest')
GO
INSERT [dbo].[InfractionType] ([InfractionTypeIndex], [InfractionTypeDescription], [InfractionTypeName]) VALUES (5, N'Driver fled the scene of a accident', N'Leaving the Scene')
GO
INSERT [dbo].[InfractionType] ([InfractionTypeIndex], [InfractionTypeDescription], [InfractionTypeName]) VALUES (6, N'Driver was going under the minium speed', N'Slow Driving')
GO
INSERT [dbo].[InfractionType] ([InfractionTypeIndex], [InfractionTypeDescription], [InfractionTypeName]) VALUES (7, N'Driver was driving with expired plates', N'Experation')
GO
INSERT [dbo].[InfractionType] ([InfractionTypeIndex], [InfractionTypeDescription], [InfractionTypeName]) VALUES (8, N'Driver was driving without a licence', N'Unlicenced')
GO
INSERT [dbo].[InfractionType] ([InfractionTypeIndex], [InfractionTypeDescription], [InfractionTypeName]) VALUES (9, N'Aquited, driver was found to be not guilty so Infraction changed', N'Aquited')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (0, 0, N'TOY-ZST', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (1, 0, N'SUA-TLS', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (2, 1, N'ZLS-FLF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (3, 1, N'JUB-CUS', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (4, 2, N'AUY-JXW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (5, 2, N'MWH-RVG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (6, 3, N'IRK-DCZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (7, 3, N'FUX-AZY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (8, 4, N'ZSJ-EID', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (9, 4, N'LYE-YLJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (10, 5, N'ETC-EZB', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (11, 5, N'QKS-KOM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (12, 6, N'NEK-OMX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (13, 6, N'UQN-KBQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (14, 7, N'HXY-BNU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (15, 7, N'TZM-EJJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (16, 8, N'QLS-ESV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (17, 8, N'UOK-SDM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (18, 9, N'WTU-VJW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (19, 9, N'JLL-GPR', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (20, 10, N'SRP-CIB', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (21, 10, N'FNR-HLJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (22, 11, N'ZLV-UEW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (23, 11, N'FFL-UDV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (24, 12, N'OBI-NKU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (25, 12, N'PGN-MYG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (26, 13, N'OWA-ALX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (27, 13, N'PVP-IHB', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (28, 14, N'ZIZ-RRR', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (29, 14, N'UKR-RPV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (30, 15, N'QCH-MMN', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (31, 15, N'QQU-FWE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (32, 16, N'FWM-RRV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (33, 16, N'FUL-LEB', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (34, 17, N'JRH-ISW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (35, 17, N'MEV-HGM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (36, 18, N'NQN-TDI', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (37, 18, N'CXD-EVM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (38, 19, N'KGN-SKM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (39, 19, N'HOM-IMH', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (40, 20, N'KBO-LMQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (41, 20, N'LCY-JSL', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (42, 21, N'CQC-TTW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (43, 21, N'UTE-ZQH', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (44, 22, N'EIE-LYG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (45, 22, N'VII-QAR', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (46, 23, N'GRW-PWZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (47, 23, N'ETK-FYP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (48, 24, N'NSM-CVA', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (49, 24, N'SNQ-EGJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (50, 25, N'JZR-KGE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (51, 25, N'JQO-JGH', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (52, 26, N'VGT-HOK', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (53, 26, N'WPU-MXD', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (54, 27, N'ZTZ-ROV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (55, 27, N'CTW-PIR', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (56, 28, N'NAP-AFK', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (57, 28, N'QVX-PWE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (58, 29, N'GCN-ZST', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (59, 29, N'SPK-KNS', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (60, 30, N'UHZ-GXB', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (61, 30, N'ZWX-XAE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (62, 31, N'EME-PZK', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (63, 31, N'RWS-PGV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (64, 32, N'YGS-RQI', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (65, 32, N'NIB-LMA', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (66, 33, N'HWJ-ARN', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (67, 33, N'OZE-UWI', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (68, 34, N'ZOL-KNL', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (69, 34, N'SQO-EQK', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (70, 35, N'QRG-TKS', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (71, 35, N'AND-UOH', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (72, 36, N'VOM-OAG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (73, 36, N'VLG-HEZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (74, 37, N'BQW-NMQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (75, 37, N'NGZ-GNA', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (76, 38, N'QJF-EZY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (77, 38, N'YRP-SRO', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (78, 39, N'BDT-FVG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (79, 39, N'RNS-LVV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (80, 40, N'JKY-VXT', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (81, 40, N'BJD-GPI', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (82, 41, N'LRH-YWF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (83, 41, N'PGE-HNG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (84, 42, N'QTX-GSD', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (85, 42, N'SBJ-LIV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (86, 43, N'EXM-KMJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (87, 43, N'TWR-TCD', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (88, 44, N'TPP-OKL', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (89, 44, N'GVS-MTF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (90, 45, N'QCY-RIW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (91, 45, N'PDZ-IPI', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (92, 46, N'HXO-TBA', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (93, 46, N'WOE-HKJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (94, 47, N'JSZ-BIR', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (95, 47, N'QXW-NDV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (96, 48, N'MUB-LUJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (97, 48, N'XHA-NJJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (98, 49, N'ANG-GNW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (99, 49, N'NEN-YYC', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (100, 50, N'ACV-JHM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (101, 50, N'QVR-OIS', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (102, 51, N'UYU-LCL', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (103, 51, N'EWH-JKN', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (104, 52, N'VRR-RXU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (105, 52, N'CZC-YWF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (106, 53, N'YRB-VAZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (107, 53, N'TVY-GUD', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (108, 54, N'PCB-QES', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (109, 54, N'UJU-PDM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (110, 55, N'YCD-IZE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (111, 55, N'FNH-BCA', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (112, 56, N'FCU-FEA', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (113, 56, N'IPV-FHP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (114, 57, N'SDS-EPX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (115, 57, N'KYQ-PIA', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (116, 58, N'PHD-ANE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (117, 58, N'OIU-ETY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (118, 59, N'EKB-LTP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (119, 59, N'YVR-DOE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (120, 60, N'OPU-SPZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (121, 60, N'TLK-EDB', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (122, 61, N'HBW-OVU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (123, 61, N'CBW-BDI', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (124, 62, N'QQZ-FSV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (125, 62, N'RKO-QAJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (126, 63, N'NCD-CEH', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (127, 63, N'FFS-AOF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (128, 64, N'LOX-BLY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (129, 64, N'EAH-HVI', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (130, 65, N'AIB-JCS', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (131, 65, N'UOP-PNP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (132, 66, N'NFU-WIC', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (133, 66, N'UCN-LCV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (134, 67, N'DQN-XVE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (135, 67, N'SQS-WQH', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (136, 68, N'ZBT-GEP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (137, 68, N'UUJ-IWS', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (138, 69, N'WWN-NSF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (139, 69, N'HIG-LAI', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (140, 70, N'TKQ-JFA', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (141, 70, N'OHK-GGV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (142, 71, N'BDI-DHN', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (143, 71, N'LJD-BGN', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (144, 72, N'QKY-LAT', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (145, 72, N'NNI-UEZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (146, 73, N'NYU-CIT', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (147, 73, N'YLH-AWW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (148, 74, N'MHZ-JKN', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (149, 74, N'EVM-AAR', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (150, 75, N'NQL-LSW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (151, 75, N'WMA-SJU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (152, 76, N'IVO-DTZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (153, 76, N'LWT-JJP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (154, 77, N'CGG-HTO', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (155, 77, N'NCH-WLY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (156, 78, N'TQI-SUF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (157, 78, N'AMY-RXI', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (158, 79, N'ZBZ-KYF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (159, 79, N'EKP-NJQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (160, 80, N'EVG-TVU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (161, 80, N'WCP-ETR', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (162, 81, N'YMH-FBP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (163, 81, N'OCM-EXO', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (164, 82, N'XHR-IJY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (165, 82, N'WFY-CZL', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (166, 83, N'CQQ-UGN', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (167, 83, N'QRS-OUG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (168, 84, N'BNO-FLP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (169, 84, N'TBZ-LWW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (170, 85, N'TGD-GFJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (171, 85, N'GLV-WDW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (172, 86, N'DVJ-OBL', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (173, 86, N'VDF-IIF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (174, 87, N'AID-BUN', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (175, 87, N'PRM-UGG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (176, 88, N'DUS-TJM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (177, 88, N'VUS-LCY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (178, 89, N'FKE-GYZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (179, 89, N'JIK-ONU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (180, 90, N'GPE-CIH', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (181, 90, N'DHC-LDL', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (182, 91, N'EMY-WOF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (183, 91, N'XVW-OEA', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (184, 92, N'MRH-GSU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (185, 92, N'HXS-XIE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (186, 93, N'TCH-EDM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (187, 93, N'UWX-TMI', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (188, 94, N'HVV-JKU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (189, 94, N'WKX-QZE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (190, 95, N'KYF-HQZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (191, 95, N'NXG-SQA', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (192, 96, N'PYZ-JKF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (193, 96, N'QBV-OBZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (194, 97, N'RUZ-NIE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (195, 97, N'MEL-AQO', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (196, 98, N'ITV-ACL', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (197, 98, N'KGW-WYS', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (198, 99, N'OAF-JDI', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (199, 99, N'MPY-DJJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (200, 100, N'YMY-VZK', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (201, 100, N'NVP-IUC', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (202, 101, N'XWH-PHP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (203, 101, N'IQY-HWV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (204, 102, N'DNT-JGK', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (205, 102, N'NPZ-VNV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (206, 103, N'PJL-ZJV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (207, 103, N'WML-FDQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (208, 104, N'JXO-QJV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (209, 104, N'OWD-WHX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (210, 105, N'HNR-GIE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (211, 105, N'GPX-HAU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (212, 106, N'LLF-MNX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (213, 106, N'FEI-HBY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (214, 107, N'JGL-GUM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (215, 107, N'WNN-HRS', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (216, 108, N'IUZ-OVH', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (217, 108, N'LJW-ZLQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (218, 109, N'EMK-CEQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (219, 109, N'YMR-OCN', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (220, 110, N'ZFZ-TUH', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (221, 110, N'MCZ-FKM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (222, 111, N'MLJ-OTJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (223, 111, N'ZPA-XMR', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (224, 112, N'NKU-TTX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (225, 112, N'KBE-CMW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (226, 113, N'RXI-BOC', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (227, 113, N'WKX-HFE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (228, 114, N'UGM-BPR', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (229, 114, N'LXG-TQC', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (230, 115, N'GBP-IKB', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (231, 115, N'HRX-NIZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (232, 116, N'RQI-ILF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (233, 116, N'IAG-TAK', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (234, 117, N'YYV-PZV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (235, 117, N'OGZ-IWR', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (236, 118, N'FFL-IPP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (237, 118, N'WCB-HFE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (238, 119, N'JVO-CSX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (239, 119, N'KMG-QTT', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (240, 120, N'KHM-QVD', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (241, 120, N'XDW-PEN', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (242, 121, N'ILY-RFW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (243, 121, N'CWN-ZNR', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (244, 122, N'PXG-VEX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (245, 122, N'ADR-FSU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (246, 123, N'CPZ-JQA', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (247, 123, N'QEM-WEG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (248, 124, N'YNC-GKK', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (249, 124, N'WMW-HYU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (250, 125, N'HSS-VNK', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (251, 125, N'MKG-MRT', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (252, 126, N'OUJ-YUS', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (253, 126, N'TXH-KZP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (254, 127, N'SOR-GDV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (255, 127, N'RPK-QEE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (256, 128, N'FBP-UZY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (257, 128, N'GOE-ZQC', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (258, 129, N'JOS-IPT', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (259, 129, N'SVZ-OUQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (260, 130, N'SDK-CIJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (261, 130, N'MAX-AJC', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (262, 131, N'LCH-MVO', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (263, 131, N'FTD-LGQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (264, 132, N'IOA-TJD', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (265, 132, N'CXH-OZQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (266, 133, N'VFT-JJW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (267, 133, N'CNP-JXZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (268, 134, N'YGE-HPZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (269, 134, N'OZO-GJF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (270, 135, N'OYP-MPR', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (271, 135, N'VVV-EWQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (272, 136, N'NXQ-TAW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (273, 136, N'INE-HVV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (274, 137, N'LRF-UQG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (275, 137, N'MZY-WRD', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (276, 138, N'GHU-TTG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (277, 138, N'USG-TAM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (278, 139, N'LJS-SNE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (279, 139, N'RBS-AWC', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (280, 140, N'WMB-ALS', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (281, 140, N'WTI-ACJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (282, 141, N'SSZ-GXU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (283, 141, N'IKW-SFE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (284, 142, N'OJQ-XSM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (285, 142, N'PVV-LRJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (286, 143, N'SBK-ERW', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (287, 143, N'HJE-GXH', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (288, 144, N'JID-JIR', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (289, 144, N'QBK-RHQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (290, 145, N'BXS-DZO', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (291, 145, N'JME-APP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (292, 146, N'DRW-EAO', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (293, 146, N'OCY-WAY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (294, 147, N'AJC-LKG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (295, 147, N'JUR-IYF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (296, 148, N'IOT-QQZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (297, 148, N'BDG-VXX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (298, 149, N'BLX-QUB', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (299, 149, N'EPG-EVX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (300, 150, N'INI-SAV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (301, 150, N'UUS-ZYN', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (302, 151, N'AVG-KVX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (303, 151, N'GHI-LPY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (304, 152, N'WWK-EFI', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (305, 152, N'NGS-AIZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (306, 153, N'CHV-XQL', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (307, 153, N'KGU-CJM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (308, 154, N'EOS-FVD', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (309, 154, N'ASX-SWM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (310, 155, N'RNR-JCP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (311, 155, N'UBS-DZB', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (312, 156, N'VYQ-OWF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (313, 156, N'KCQ-OPF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (314, 157, N'LOQ-EMZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (315, 157, N'TYF-UFC', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (316, 158, N'VIJ-JST', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (317, 158, N'KFO-QFK', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (318, 159, N'AWD-SUY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (319, 159, N'LCP-KUH', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (320, 160, N'PKE-HBE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (321, 160, N'BEK-QEJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (322, 161, N'SGQ-SDE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (323, 161, N'FHB-BHD', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (324, 162, N'CVU-TJG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (325, 162, N'XWY-CTO', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (326, 163, N'OOG-SBA', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (327, 163, N'NTX-UHY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (328, 164, N'NYT-GSZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (329, 164, N'OXS-QPZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (330, 165, N'REB-ZWG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (331, 165, N'MQL-YVP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (332, 166, N'MKB-NNC', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (333, 166, N'XLN-HTI', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (334, 167, N'AAQ-BEZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (335, 167, N'VRL-SGU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (336, 168, N'IDB-APT', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (337, 168, N'KGF-XMR', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (338, 169, N'PON-CXT', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (339, 169, N'KEI-LKS', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (340, 170, N'HMA-NNU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (341, 170, N'SLE-LEE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (342, 171, N'ZDE-MMH', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (343, 171, N'KPQ-KNZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (344, 172, N'DQF-PNC', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (345, 172, N'ZJN-UXZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (346, 173, N'WJI-HFT', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (347, 173, N'BTK-MXD', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (348, 174, N'VQM-PZM', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (349, 174, N'PFF-YSV', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (350, 175, N'HAK-IHG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (351, 175, N'CUQ-YEU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (352, 176, N'BJC-QKX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (353, 176, N'SAD-YVX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (354, 177, N'YKQ-MUG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (355, 177, N'LDM-CAO', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (356, 178, N'JVM-KSD', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (357, 178, N'GEA-PHY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (358, 179, N'TBW-HFC', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (359, 179, N'JLW-VYB', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (360, 180, N'FVI-NIH', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (361, 180, N'TZI-VRY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (362, 181, N'QGU-DDN', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (363, 181, N'GPE-DRO', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (364, 182, N'MFA-DYS', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (365, 182, N'KRO-JPX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (366, 183, N'WZA-QAF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (367, 183, N'OHT-YZL', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (368, 184, N'TET-RGF', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (369, 184, N'BNH-ZAZ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (370, 185, N'KEN-MGT', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (371, 185, N'RGX-UHE', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (372, 186, N'CBJ-UAI', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (373, 186, N'DCH-IED', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (374, 187, N'FBS-BUA', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (375, 187, N'VQQ-RDO', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (376, 188, N'USC-GXU', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (377, 188, N'KBV-YOP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (378, 189, N'UOY-HGG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (379, 189, N'NRB-OAQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (380, 190, N'KUM-DCG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (381, 190, N'DSU-DOP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (382, 191, N'WWP-URJ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (383, 191, N'FZW-CHD', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (384, 192, N'DRI-RXK', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Green')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (385, 192, N'MPS-TYP', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (386, 193, N'KKB-XNQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (387, 193, N'LNL-UPX', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (388, 194, N'XOC-NKY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Red')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (389, 194, N'EYH-VWB', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (390, 195, N'PFR-KOL', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Pink')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (391, 195, N'OYM-IMG', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (392, 196, N'NCN-XPN', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (393, 196, N'ABQ-RYL', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Blue')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (394, 197, N'KGH-FSY', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (395, 197, N'FTX-YZL', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (396, 198, N'VFQ-FII', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Purple')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (397, 198, N'RWW-UQD', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'White')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (398, 199, N'BJL-MOH', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Steel')
GO
INSERT [dbo].[Vehicle] ([VehicleIndex], [VehicleOwner], [VehiclePlate], [VehicleAge], [Color]) VALUES (399, 199, N'RSH-UEQ', CAST(N'2022-05-11T11:37:14.807' AS DateTime), N'Black')
GO
ALTER TABLE [dbo].[Infractions] ADD  DEFAULT (getdate()) FOR [InfractionDate]
GO
ALTER TABLE [dbo].[Vehicle] ADD  DEFAULT (getdate()) FOR [VehicleAge]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD FOREIGN KEY([EMPRoleIndex])
REFERENCES [dbo].[EmpRoles] ([EmpRoleIndex])
GO
ALTER TABLE [dbo].[Infractions]  WITH CHECK ADD FOREIGN KEY([EmployeeIndex])
REFERENCES [dbo].[Employees] ([EmployeeIndex])
GO
ALTER TABLE [dbo].[Infractions]  WITH CHECK ADD FOREIGN KEY([InfractionTypeIndex])
REFERENCES [dbo].[InfractionType] ([InfractionTypeIndex])
GO
ALTER TABLE [dbo].[Infractions]  WITH CHECK ADD FOREIGN KEY([VehicleIndex])
REFERENCES [dbo].[Vehicle] ([VehicleIndex])
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD FOREIGN KEY([VehicleOwner])
REFERENCES [dbo].[Drivers] ([DriverIndex])
GO
USE [master]
GO
ALTER DATABASE [DriverDatabase] SET  READ_WRITE 
GO
