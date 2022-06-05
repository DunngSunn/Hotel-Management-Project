USE MyHotel
GO

EXEC USP_AddServiceType @serviceTypeName = N'Đồ ăn'
EXEC USP_AddServiceType @serviceTypeName = N'Nước uống'
EXEC USP_AddServiceType @serviceTypeName = N'Vận chuyển'
GO

EXEC USP_AddService @serviceTypeID = 1, @serviceName = N'Mì ly', @servicePrice = 15000
EXEC USP_AddService @serviceTypeID = 1, @serviceName = N'Mì xào', @servicePrice = 20000
EXEC USP_AddService @serviceTypeID = 1, @serviceName = N'Mì trứng', @servicePrice = 20000
EXEC USP_AddService @serviceTypeID = 1, @serviceName = N'Cơm rang', @servicePrice = 25000
EXEC USP_AddService @serviceTypeID = 1, @serviceName = N'Cơm cháy', @servicePrice = 25000
EXEC USP_AddService @serviceTypeID = 1, @serviceName = N'Cơm thập cẩm', @servicePrice = 30000
EXEC USP_AddService @serviceTypeID = 2, @serviceName = N'Coca', @servicePrice = 10000
EXEC USP_AddService @serviceTypeID = 2, @serviceName = N'Pepsi', @servicePrice = 10000
EXEC USP_AddService @serviceTypeID = 2, @serviceName = N'7Up', @servicePrice = 10000
EXEC USP_AddService @serviceTypeID = 2, @serviceName = N'Bia', @servicePrice = 15000
EXEC USP_AddService @serviceTypeID = 2, @serviceName = N'Rượu', @servicePrice = 15000
EXEC USP_AddService @serviceTypeID = 3, @serviceName = N'Đưa đón sân bay', @servicePrice = 200000
EXEC USP_AddService @serviceTypeID = 3, @serviceName = N'Xách hành lý', @servicePrice = 50000
GO

EXEC USP_AddEmployee @employeeName = N'Nguyễn Văn Dũng', @employeeMobile = N'0973089304', @employeeGender = N'Nam', @employeeEmailID = N'ngdungitkthn@gmail.com', @employeeAddress = N'Nội thành Hà Nội'
EXEC USP_AddEmployee @employeeName = N'Bùi Thị Ngọc Ánh', @employeeMobile = N'0398106702', @employeeGender = N'Nữ', @employeeEmailID = N'buingocanh@gmail.com', @employeeAddress = N'Ngoại thành Hà Nội'
EXEC USP_AddEmployee @employeeName = N'Chịu', @employeeMobile = N'1234', @employeeGender = N'Chịu', @employeeEmailID = N'Chịu', @employeeAddress = N'Chịu'
GO

EXEC USP_AddAccount @employeeID = 1, @username = N'dungadmin', @password = N'admin'
EXEC USP_AddAccount @employeeID = 2, @username = N'anhadmin', @password = N'admin'
EXEC USP_AddAccount @employeeID = 3, @username = N'admin', @password = N'admin'
GO

EXEC USP_AddRoom @roomNo = N'P101', @roomType = N'Phòng đơn', @roomBed = N'1 Giường đơn', @roomPrice = 50000
EXEC USP_AddRoom @roomNo = N'P102', @roomType = N'Phòng đơn', @roomBed = N'1 Giường đơn', @roomPrice = 50000
EXEC USP_AddRoom @roomNo = N'P103', @roomType = N'Phòng đơn', @roomBed = N'1 Giường đơn', @roomPrice = 50000
EXEC USP_AddRoom @roomNo = N'P104', @roomType = N'Phòng đơn', @roomBed = N'1 Giường đơn', @roomPrice = 50000
EXEC USP_AddRoom @roomNo = N'P105', @roomType = N'Phòng đơn', @roomBed = N'1 Giường đơn', @roomPrice = 50000
EXEC USP_AddRoom @roomNo = N'P106', @roomType = N'Phòng đơn', @roomBed = N'1 Giường đơn', @roomPrice = 50000
EXEC USP_AddRoom @roomNo = N'P107', @roomType = N'Phòng đơn', @roomBed = N'1 Giường đơn', @roomPrice = 50000
EXEC USP_AddRoom @roomNo = N'P108', @roomType = N'Phòng đơn', @roomBed = N'1 Giường đơn', @roomPrice = 50000
EXEC USP_AddRoom @roomNo = N'P109', @roomType = N'Phòng đơn', @roomBed = N'1 Giường đơn', @roomPrice = 50000
EXEC USP_AddRoom @roomNo = N'P110', @roomType = N'Phòng đơn', @roomBed = N'1 Giường đơn', @roomPrice = 50000
GO

EXEC USP_AddRoom @roomNo = N'P201', @roomType = N'Phòng đôi', @roomBed = N'1 Giường đôi', @roomPrice = 65000
EXEC USP_AddRoom @roomNo = N'P202', @roomType = N'Phòng đôi', @roomBed = N'1 Giường đôi', @roomPrice = 65000
EXEC USP_AddRoom @roomNo = N'P203', @roomType = N'Phòng đôi', @roomBed = N'1 Giường đôi', @roomPrice = 65000
EXEC USP_AddRoom @roomNo = N'P204', @roomType = N'Phòng đôi', @roomBed = N'1 Giường đôi', @roomPrice = 65000
EXEC USP_AddRoom @roomNo = N'P205', @roomType = N'Phòng đôi', @roomBed = N'1 Giường đôi', @roomPrice = 65000
EXEC USP_AddRoom @roomNo = N'P206', @roomType = N'Phòng đôi', @roomBed = N'1 Giường đôi', @roomPrice = 65000
EXEC USP_AddRoom @roomNo = N'P207', @roomType = N'Phòng đôi', @roomBed = N'1 Giường đôi', @roomPrice = 65000
GO

EXEC USP_AddRoom @roomNo = N'P301', @roomType = N'Phòng gia đình', @roomBed = N'1 Giường bốn', @roomPrice = 80000
EXEC USP_AddRoom @roomNo = N'P302', @roomType = N'Phòng gia đình', @roomBed = N'1 Giường bốn', @roomPrice = 80000
EXEC USP_AddRoom @roomNo = N'P303', @roomType = N'Phòng gia đình', @roomBed = N'1 Giường bốn', @roomPrice = 80000
EXEC USP_AddRoom @roomNo = N'P304', @roomType = N'Phòng gia đình', @roomBed = N'1 Giường bốn', @roomPrice = 80000
EXEC USP_AddRoom @roomNo = N'P305', @roomType = N'Phòng gia đình', @roomBed = N'1 Giường bốn', @roomPrice = 80000
GO

EXEC USP_AddCustomer @customerName = N'Nguyễn Văn Dũng', @customerMobile = N'0987654321', @customerNationality = N'Việt Nam', @customerGender = N'Nam', @customerDateofbirth = '2000-05-02', @customerIndentification = N'1234567', @customerAddress = N'Nội thành'
EXEC USP_AddCustomer @customerName = N'Bùi Ngọc Ánh', @customerMobile = N'0987654321', @customerNationality = N'Việt Nam', @customerGender = N'Nữ', @customerDateofbirth = '2000-10-20', @customerIndentification = N'1234567', @customerAddress = N'Ngoại thành'
EXEC USP_AddCustomer @customerName = N'Bùi Thị Diệu Linh', @customerMobile = N'0987654321', @customerNationality = N'Việt Nam', @customerGender = N'Nữ', @customerDateofbirth = '2000-05-28', @customerIndentification = N'1234567', @customerAddress = N'Nội thành'
EXEC USP_AddCustomer @customerName = N'Bùi Lê Vy', @customerMobile = N'0987654321', @customerNationality = N'Việt Nam', @customerGender = N'Nữ', @customerDateofbirth = '2000-04-17', @customerIndentification = N'1234567', @customerAddress = N'Nội thành'
EXEC USP_AddCustomer @customerName = N'Trần Thị Duyên', @customerMobile = N'0987654321', @customerNationality = N'Việt Nam', @customerGender = N'Nữ', @customerDateofbirth = '2000-07-07', @customerIndentification = N'1234567', @customerAddress = N'Hàn Quốc'
GO