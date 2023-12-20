create database DBSYSfinal

use DBSYSfinal

--Creates the user account table
CREATE TABLE UserAccount (
userId integer IDENTITY(1,1) primary key,
userName varchar (MAX) not null,
userPassword varchar (MAX) not null,
userInfLname varchar (MAX) not null,
userInfFname varchar (MAX) not null,
userInfAddress varchar (MAX) not null default 'No Address',
userInfEmail varchar(MAX) not null,
roleId int,
userStatus varchar (10) not NULL default 'ACTIVE',
);

DROP TABLE UserAccount

CREATE TABLE SecurityStaff(
userIdStaff integer IDENTITY(1,1) primary key,
userIdnum int not null,
staffPassword varchar(MAX) not null
);
--To view the user account table
CREATE VIEW vw_UserAccounts AS
SELECT * FROM UserAccount

--Creates the user information table

CREATE TABLE UserParking(
userParkId integer IDENTITY(1,1) primary key,
userFullName varchar (MAX) not null,
userParkGate varchar(50) not null,
userPlatenum varchar(50) not null,
userVechile varchar(50) not null,
userParkingnum varchar (50) not null,
);

CREATE VIEW vw_TransactionHistory AS
SELECT * FROM UserParking

DROP TABLE UserParking

CREATE TABLE [dbo].[UserRole](
	[roleId] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [nvarchar](50) NULL,
	[roleDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [DBSYSfinal]
GO
SET IDENTITY_INSERT [dbo].[UserRole] ON 

INSERT [dbo].[UserRole] ([roleId], [roleName], [roleDescription]) VALUES (1, N'Student', N'Student ')
INSERT [dbo].[UserRole] ([roleId], [roleName], [roleDescription]) VALUES (2, N'Teacher', N'Teacher')
INSERT [dbo].[UserRole] ([roleId], [roleName], [roleDescription]) VALUES (3, N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[UserRole] OFF