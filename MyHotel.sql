-----------------------------Create Database-----------------------------
CREATE DATABASE MyHotel
GO

-----------------------------Use Database-----------------------------
USE MyHotel
GO

-----------------------------Service-----------------------------
CREATE TABLE ServiceType(
	serviceTypeID INT IDENTITY(1,1) PRIMARY KEY,
	serviceTypeName NVARCHAR(250) NOT NULL
);
GO

CREATE TABLE Service(
    serviceID INT IDENTITY(1,1) PRIMARY KEY,
    serviceTypeID INT NOT NULL,
    serviceName NVARCHAR(250) NOT NULL,
    servicePrice BIGINT NOT NULL,
	FOREIGN KEY (serviceTypeID) REFERENCES ServiceType (serviceTypeID)
);
GO

-----------------------------Room-----------------------------
CREATE TABLE Room(
    roomID INT IDENTITY(1,1) PRIMARY KEY,
    roomNo NVARCHAR(250) NOT NULL UNIQUE,
    roomType NVARCHAR(250) NOT NULL,
    roomBed NVARCHAR(250) NOT NULL,
    roomPrice BIGINT NOT NULL,
	roomBooked INT NOT NULL DEFAULT 0,
	roomCheckin DATETIME,
	customerID INT
);
GO

-----------------------------Customer-----------------------------
CREATE TABLE Customer(
     customerID INT IDENTITY(1,1) PRIMARY KEY,
     customerName NVARCHAR(250) NOT NULL,
     customerMobile NVARCHAR(20) NOT NULL,
     customerNationality NVARCHAR(250) NOT NULL,
     customerGender NVARCHAR(50) NOT NULL,
     customerDateofbirth DATE NOT NULL,
     customerIndentification NVARCHAR(50) NOT NULL,
     customerAddress NVARCHAR(250) NOT NULL,
);
GO

-----------------------------Employee/Account-----------------------------
CREATE TABLE Employee(
     employeeID INT IDENTITY(1,1) PRIMARY KEY,
     employeeName NVARCHAR(250) NOT NULL,
     employeeMobile NVARCHAR(20) NOT NULL,
     employeeGender NVARCHAR(50) NOT NULL,
     employeeEmailID NVARCHAR(250) NOT NULL,
     employeeAddress NVARCHAR(250) NOT NULL,
);
GO

CREATE TABLE Account(
	accountID INT IDENTITY(1,1) PRIMARY KEY,
	employeeID INT NOT NULL,
    username NVARCHAR(150) NOT NULL,
    password NVARCHAR(150) NOT NULL,
	FOREIGN KEY (employeeID) REFERENCES Employee (employeeID),
);
GO

-----------------------------Bill-----------------------------
CREATE TABLE Bill(
	billID INT IDENTITY(1,1) PRIMARY KEY,
	customerID INT NOT NULL,
	checkIn DATETIME,
	checkOut DATETIME,
	totalPrice BIGINT,
	FOREIGN KEY (customerID) REFERENCES Customer (customerID),
);
GO

CREATE TABLE BillService(
	billServiceID INT IDENTITY(1,1) PRIMARY KEY,
	billID INT NOT NULL,
	serviceID INT NOT NULL,
	quantityService INT NOT NULL,
	totalPriceService BIGINT NOT NULL,
	FOREIGN KEY (billID) REFERENCES Bill (billID),
	FOREIGN KEY (serviceID) REFERENCES Service (serviceID),
);
GO

CREATE TABLE BillRoom(
	billRoomID INT IDENTITY(1,1) PRIMARY KEY,
	billID INT NOT NULL,
	roomID INT NOT NULL,
	quantityHour INT NOT NULL,
	totalPriceRoom BIGINT NOT NULL,
	FOREIGN KEY (billID) REFERENCES Bill (billID),
	FOREIGN KEY (roomID) REFERENCES Room (roomID),
);
GO





