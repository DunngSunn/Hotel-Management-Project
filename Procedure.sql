-----------------------------Use Database-----------------------------
USE MyHotel
GO

-----------------------------Service-----------------------------
--Lấy loại dịch vụ
CREATE PROC USP_GetAllServiceType
AS
BEGIN
	SELECT *
	FROM ServiceType
END
GO
--EXEC USP_GetAllServiceType

--Lấy index cuối trong loại dịch vụ
CREATE PROC USP_GetLastIndexServiceType
AS
BEGIN
	SELECT MAX(serviceTypeID)
	FROM ServiceType
END
GO
--EXEC USP_GetLastIndexServiceType

--Thêm loại dịch vụ
CREATE PROC USP_AddServiceType
@serviceTypeName NVARCHAR(250)
AS
BEGIN
	INSERT INTO ServiceType( serviceTypeName )
	VALUES ( @serviceTypeName )
END
GO
--EXEC USP_AddServiceType @serviceTypeName = N''

--Sửa loại dịch vụ
CREATE PROC USP_EditServiceType
@serviceTypeID INT,
@serviceTypeName NVARCHAR(250)
AS
BEGIN
	UPDATE ServiceType 
	SET serviceTypeName = @serviceTypeName
	WHERE serviceTypeID = @serviceTypeID
END
GO
--EXEC USP_EditServiceType @serviceTypeID = , @serviceTypeName = N''

--Xoá loại dịch vụ
CREATE PROC USP_DeleteServiceType
@serviceTypeID INT
AS
BEGIN
	DELETE FROM Service
	WHERE serviceTypeID = @serviceTypeID
	DELETE FROM ServiceType
	WHERE serviceTypeID = @serviceTypeID
END
GO
--EXEC USP_DeleteServiceType @serviceTypeID = 

--Lấy dịch vụ
CREATE PROC USP_GetAllService
AS
BEGIN
	SELECT *
	FROM Service
	INNER JOIN ServiceType
	ON Service.serviceTypeID = ServiceType.serviceTypeID
END
GO
--EXEC USP_GetAllService

--Lấy index cuối trong dịch vụ
CREATE PROC USP_GetLastIndexService
AS
BEGIN
	SELECT MAX(serviceID)
	FROM Service
END
GO
--EXEC USP_GetLastIndexService

--Thêm dịch vụ
CREATE PROC USP_AddService
@serviceTypeID INT,
@serviceName NVARCHAR(250),
@servicePrice BIGINT
AS
BEGIN
	INSERT INTO Service( serviceTypeID, serviceName, servicePrice )
	VALUES ( @serviceTypeID, @serviceName, @servicePrice )
END
GO
--EXEC USP_AddService @serviceTypeID = , @serviceName = N'', @servicePrice = 

--Sửa dịch vụ
CREATE PROC USP_EditService
@serviceID INT,
@serviceTypeID INT,
@serviceName NVARCHAR(250),
@servicePrice BIGINT
AS
BEGIN
	UPDATE Service 
	SET serviceTypeID = @serviceTypeID, serviceName = @serviceName, servicePrice = @servicePrice
	WHERE serviceID = @serviceID
END
GO
--EXEC USP_EditService @serviceID = , @serviceTypeID = , @serviceName = N'', @servicePrice = 

--Xoá dịch vụ
CREATE PROC USP_DeleteService
@serviceID INT
AS
BEGIN
	DELETE FROM Service
	WHERE serviceID = @serviceID
	DELETE FROM BillService
	WHERE serviceID = @serviceID
END
GO
--EXEC USP_DeleteService @serviceID = 

-----------------------------Employee/Account-----------------------------
--Thêm nhân viên
CREATE PROC USP_AddEmployee
@employeeName NVARCHAR(250),
@employeeMobile NVARCHAR(20),
@employeeGender NVARCHAR(50),
@employeeEmailID NVARCHAR(250),
@employeeAddress NVARCHAR(250)
AS
BEGIN
	INSERT INTO Employee( employeeName, employeeMobile, employeeGender, employeeEmailID, employeeAddress )
	VALUES ( @employeeName, @employeeMobile, @employeeGender, @employeeEmailID, @employeeAddress )
END
GO
--EXEC USP_AddEmployee @employeeName = N'', @employeeMobile = N'', @employeeGender = N'', @employeeEmailID = N'', @employeeAddress = N''

--Lấy tất cả thông tin nhân viên
CREATE PROC USP_GetAllEmployee
AS
BEGIN
	SELECT *  
	FROM Employee
END
GO
--EXEC USP_GetAllEmployee

--Lấy index cuối trong nhân viên
CREATE PROC USP_GetLastIndexEmployee
AS
BEGIN
	SELECT MAX(employeeID)
	FROM Employee
END
GO
--EXEC USP_GetLastIndexEmployee

--Sửa thông tin nhân viên
CREATE PROC USP_EditEmployee
@employeeID INT,
@employeeName NVARCHAR(250),
@employeeMobile NVARCHAR(20),
@employeeGender NVARCHAR(50),
@employeeEmailID NVARCHAR(250),
@employeeAddress NVARCHAR(250)
AS
BEGIN
	UPDATE Employee 
	SET employeeName = @employeeName, employeeMobile = @employeeMobile, employeeGender = @employeeGender, employeeEmailID = @employeeEmailID, employeeAddress = @employeeAddress
	WHERE employeeID = @employeeID
END
GO
--EXEC USP_EditEmployee @employeeID = , @employeeName = N'', @employeeMobile = N'', @employeeGender = N'', @employeeEmailID = N'', @employeeAddress = N''

--Xoá nhân viên 
CREATE PROC USP_DeleteEmployee
@employeeID INT
AS
BEGIN
	DELETE FROM Employee
	WHERE employeeID = @employeeID
END
GO
--EXEC USP_DeleteEmployee @employeeID = 

--Thêm tài khoản
CREATE PROC USP_AddAccount
@employeeID INT,
@username NVARCHAR(150),
@password NVARCHAR(150)
AS
BEGIN
	INSERT INTO Account ( employeeID, username, password )
	VALUES ( @employeeID, @username, @password )
END
GO
--EXEC USP_AddAccount @employeeID = , @username = N'', @password = N''

--Lấy tất cả thông tin tài khoản
CREATE PROC USP_GetAllAccount
AS
BEGIN
	SELECT *  
	FROM Account
END
GO
--EXEC USP_GetAllAccount

--Lấy index cuối trong account
CREATE PROC USP_GetLastIndexAccount
AS
BEGIN
	SELECT MAX(accountID)
	FROM Account
END
GO
--EXEC USP_GetLastIndexAccount

--Sửa tài khoản
CREATE PROC USP_EditAccount
@accountID INT,
@username NVARCHAR(150),
@password NVARCHAR(150)
AS
BEGIN
	UPDATE Account 
	SET username = @username, password = @password
	WHERE accountID = @accountID
END
GO
--EXEC USP_EditAccount @accountID = , @username = N'', @password = N''

--Xoá tài khoản
CREATE PROC USP_DeleteAccount
@employeeID INT
AS
BEGIN
	DELETE FROM Account
	WHERE employeeID = @employeeID
END
GO
--EXEC USP_DeleteAccount @employeeID = 

-----------------------------Customer-----------------------------
--Thêm khách hàng
CREATE PROC USP_AddCustomer
@customerName NVARCHAR(250),
@customerMobile NVARCHAR(20),
@customerNationality NVARCHAR(250),
@customerGender NVARCHAR(50),
@customerDateofbirth DATE,
@customerIndentification NVARCHAR(50),
@customerAddress NVARCHAR(250)
AS
BEGIN
	INSERT INTO Customer( customerName, customerMobile, customerNationality, customerGender, customerDateofbirth, customerIndentification, customerAddress )
	VALUES ( @customerName, @customerMobile, @customerNationality, @customerGender, CAST(@customerDateofbirth as DATE) ,@customerIndentification, @customerAddress )
END
GO
--EXEC USP_AddCustomer @customerName = N'', @customerMobile = N'', @customerNationality = N'', @customerGender = N'', @customerDateofbirth = '', @customerIndentification = N'', @customerAddress = N''

--Lấy tất cả thông tin khách hàng
CREATE PROC USP_GetAllCustomer
AS
BEGIN
	SELECT *  
	FROM Customer
END
GO
--EXEC USP_GetAllCustomer

--Lấy index cuối trong customer
CREATE PROC USP_GetLastIndexCustomer
AS
BEGIN
	SELECT MAX(customerID)
	FROM Customer
END
GO
--EXEC USP_GetLastIndexCustomer

--Sửa thông tin khách hàng
CREATE PROC USP_EditCustomer
@customerID INT,
@customerName NVARCHAR(250),
@customerMobile NVARCHAR(20),
@customerNationality NVARCHAR(250),
@customerGender NVARCHAR(50),
@customerDateofbirth DATE,
@customerIndentification NVARCHAR(50),
@customerAddress NVARCHAR(250)
AS
BEGIN
	UPDATE Customer 
	SET customerName = @customerName, customerMobile = @customerMobile, customerNationality = @customerNationality, customerGender = @customerGender, customerDateofbirth = CAST(@customerDateofbirth as DATE), customerIndentification = @customerIndentification, customerAddress = @customerAddress
	WHERE customerID = @customerID
END
GO
--EXEC USP_EditCustomer @customerID = , @customerName = N'', @customerMobile = N'', @customerNationality = N'', @customerGender = N'', @customerDateofbirth = '', @customerIndentification = N'', @customerAddress = N''

--Xoá khách hàng
CREATE PROC USP_DeleteCustomer
@customerID INT
AS
BEGIN
	DELETE FROM BillRoom
	WHERE billID = (SELECT billID FROM Bill WHERE customerID = @customerID)
	DELETE FROM BillService
	WHERE billID = (SELECT billID FROM Bill WHERE customerID = @customerID)
	DELETE FROM Bill
	WHERE customerID = @customerID
	DELETE FROM Customer
	WHERE customerID = @customerID
END
GO
--EXEC USP_DeleteCustomer @customerID = 

-----------------------------Room-----------------------------
--Lấy thông tin phòng
CREATE PROC USP_GetAllRoom
AS
BEGIN
	SELECT *
	FROM Room
END
GO
--EXEC USP_GetAllRoom

--Lấy index cuối trong room
CREATE PROC USP_GetLastIndexRoom
AS
BEGIN
	SELECT MAX(roomID)
	FROM Room
END
GO
--EXEC USP_GetLastIndexRoom

--Thêm phòng
CREATE PROC USP_AddRoom
@roomNo NVARCHAR(250),
@roomType NVARCHAR(250),
@roomBed NVARCHAR(250),
@roomPrice BIGINT
AS
BEGIN
	INSERT INTO Room ( roomNo, roomType, roomBed, roomPrice )
	VALUES ( @roomNo, @roomType, @roomBed, @roomPrice )
END
GO
--EXEC USP_AddRoom @roomNo = N'P101', @roomType = N'Phòng đơn', @roomBed = N'1 Giường đơn', @roomPrice = 50000

--Sửa phòng
CREATE PROC USP_EditRoom
@roomID INT,
@roomNo NVARCHAR(250),
@roomType NVARCHAR(250),
@roomBed NVARCHAR(250),
@roomPrice BIGINT
AS
BEGIN
	UPDATE Room 
	SET roomNo = @roomNo, roomType = @roomType, roomBed = @roomBed, roomPrice = @roomPrice 
	WHERE roomID = @roomID
END
GO
--EXEC USP_EditRoom @roomID = , @roomNo = N'', @roomType = N'', @roomBed = N'', @roomPrice = 

--Sửa tình trạng phòng
CREATE PROC USP_EditRoomStatus
@roomID INT,
@roomBooked INT,
@roomCheckin DateTime,
@customerID INT
AS
BEGIN
	UPDATE Room 
	SET  roomBooked = @roomBooked, roomCheckin = CAST(@roomCheckin as DATETIME), customerID = @customerID
	WHERE roomID = @roomID
END
GO
--EXEC USP_EditRoomStatus @roomID = , @roomBooked = , @roomCheckin = '', @customerID = 

--Xoá phòng
CREATE PROC USP_DeleteRoom
@roomID INT
AS
BEGIN
	DELETE FROM Room
	WHERE roomID = @roomID
END
GO
--EXEC USP_DeleteRoom @roomID = 

-----------------------------Room-----------------------------
--Lấy thông tin hoá đơn
CREATE PROC USP_GetAllBill
AS
BEGIN
	SELECT *
	FROM Bill
END
GO
--EXEC USP_GetAllBill

--Lấy thông tin hoá đơn phòng
CREATE PROC USP_GetAllBillRoom
AS
BEGIN
	SELECT *
	FROM BillRoom
END
GO
--EXEC USP_GetAllBillRoom

--Lấy index cuối trong hoá đơn
CREATE PROC USP_GetLastIndexBill
AS
BEGIN
	SELECT MAX(billID)
	FROM Bill
END
GO
--EXEC USP_GetLastIndexBill

--Lấy index cuối trong hoá đơn phòng
CREATE PROC USP_GetLastIndexBillRoom
AS
BEGIN
	SELECT MAX(billRoomID)
	FROM BillRoom
END
GO
--EXEC USP_GetLastIndexBillRoom

--Thêm hoá đơn
CREATE PROC USP_AddBill
@customerID INT,
@checkIn DATETIME,
@checkOut DATETIME,
@totalPrice BIGINT,
@roomID INT,
@quantityHour INT,
@totalPriceRoom BIGINT
AS
BEGIN
	INSERT INTO Bill( customerID, checkIn, checkOut, totalPrice )
	VALUES ( @customerID, @checkIn, @checkOut, @totalPrice )
	DECLARE @lastBillID INT
	SET @lastBillID = (SELECT MAX(billID) FROM Bill)
	INSERT INTO BillRoom( billID, roomID, quantityHour, totalPriceRoom )
	VALUES ( @lastBillID, @roomID, @quantityHour, @totalPriceRoom )
END
GO
--EXEC USP_AddBill @customerID = , @checkIn = '', @checkOut = '', @totalPrice = , @roomID = , @quantityHour = , @totalPriceRoom = 

--Thêm hoá 


