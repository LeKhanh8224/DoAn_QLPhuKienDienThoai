USE master
GO
CREATE DATABASE QL_PKDIENTHOAI
GO
USE QL_PKDIENTHOAI
GO
---------------------------------------
CREATE TABLE LOAI 
(
	MALOAI CHAR(10) NOT NULL,
	TENLOAI NVARCHAR(70),
	CONSTRAINT PK_LOAI PRIMARY KEY (MALOAI)
);
go

CREATE TABLE NCC 
(
	MANCC CHAR(10) NOT NULL,
	TENNCC NVARCHAR(100),
	DCNCC NVARCHAR(100)
	CONSTRAINT PK_NCC PRIMARY KEY (MANCC)
);
go

CREATE TABLE SANPHAM
(
	MASP CHAR(20) NOT NULL,
	TENSP NVARCHAR(100),
	MALOAI CHAR(10), 
	MANCC CHAR(10), 
	MOTA NVARCHAR(255),
	GIABAN MONEY,
	TONKHO INT DEFAULT 0,
	TINHTRANG NVARCHAR(20),
	CONSTRAINT PK_SP PRIMARY KEY (MASP),
	CONSTRAINT FK_SP_LOAI FOREIGN KEY (MALOAI) REFERENCES LOAI(MALOAI),
	CONSTRAINT FK_SP_NCC FOREIGN KEY (MANCC) REFERENCES NCC(MANCC)
);
go

CREATE TABLE KHACHHANG 
(
	MAKH CHAR(10) NOT NULL,
	TENKH NVARCHAR(100),
	GIOITINH NVARCHAR(5),
	SDT NVARCHAR(15),
	CONSTRAINT PK_KH PRIMARY KEY (MAKH)
);
go

CREATE TABLE VAITRO 
(
	MAVT CHAR(10) NOT NULL,
	TENVT NVARCHAR(70) NOT NULL,
	CONSTRAINT PK_VT PRIMARY KEY (MAVT)
);
go

CREATE TABLE TAIKHOAN
(
	TENDN NVARCHAR(50) NOT NULL, 
	MKHAU NVARCHAR (100) NOT NULL,
	MAVT CHAR(10) NOT NULL,
	CONSTRAINT PK_TK PRIMARY KEY (TENDN),
	CONSTRAINT FK_TK_VT FOREIGN KEY (MAVT) REFERENCES VAITRO(MAVT)
);
go

CREATE TABLE NHANVIEN
(
	MANV CHAR(10) NOT NULL,
	TENNV NVARCHAR(100),
	GIOITINH NVARCHAR(5),
	SDT NVARCHAR(15),
	NGAYSINH DATE,
	DCNV NVARCHAR(255),
	TRANGTHAI NVARCHAR(20),
	TENDN NVARCHAR(50) NULL
	CONSTRAINT PK_NV PRIMARY KEY (MANV),
	CONSTRAINT FK_NV_TENDN FOREIGN KEY (TENDN) REFERENCES TAIKHOAN(TENDN)
);
go

CREATE TABLE HOADON
(
	MAHD CHAR(10) NOT NULL,
	NGAYLAP DATE DEFAULT GETDATE(), 
	TONGTIEN MONEY NOT NULL DEFAULT 0,
	MAKH CHAR(10) NOT NULL,
	MANV CHAR(10) NOT NULL,
	CONSTRAINT PK_HD PRIMARY KEY (MAHD),
	CONSTRAINT FK_HD_KH FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	CONSTRAINT FK_HD_NV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);
go

CREATE TABLE CHITIETHD
(
	MAHD CHAR(10) NOT NULL,
	MASP CHAR(20) NOT NULL,
	SLMUA INT,
	THANHTIEN MONEY,
	CONSTRAINT PK_CTHD PRIMARY KEY (MAHD, MASP),
	CONSTRAINT FK_CTHD_HD FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD),
	CONSTRAINT FK_CTHD_SP FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP)
);
go


CREATE TABLE PHIEUNHAP
(
	MAPN CHAR(10) NOT NULL,
	NGAYDAT DATE DEFAULT GETDATE(),
	TONGDAT MONEY NOT NULL DEFAULT 0,
	MANCC CHAR(10) NOT NULL,
	CONSTRAINT PK_PN PRIMARY KEY (MAPN),
	CONSTRAINT FK_PN_NCC FOREIGN KEY (MANCC) REFERENCES NCC(MANCC)
);
go


CREATE TABLE CHITIETPN
(
	MAPN CHAR(10) NOT NULL,
	MASP CHAR(20) NOT NULL,
	SLDAT INT,
	GIADAT MONEY, 
	CONSTRAINT PK_CTPN PRIMARY KEY (MAPN, MASP),
	CONSTRAINT FK_CTPN_PN FOREIGN KEY (MAPN) REFERENCES PHIEUNHAP(MAPN),
	CONSTRAINT FK_CTPN_SP FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP)
);
go



-- dữ liệu cho các bảng -------------------------------------------------------------------------------------------------

INSERT INTO LOAI (MALOAI, TENLOAI) VALUES
('L001', N'Ốp lưng'),
('L002', N'Cáp sạc'),
('L003', N'Tai nghe'),
('L004', N'Kính cường lực'),
('L005', N'Sạc dự phòng'),
('L006', N'Pin điện thoại'),
('L007', N'Giá đỡ điện thoại'),
('L008', N'Thẻ nhớ'),
('L009', N'Loa Bluetooth');
GO

INSERT INTO NCC (MANCC, TENNCC, DCNCC) VALUES
('NCC001', N'Công ty TNHH Phụ Kiện Việt', N'123 Lê Lợi, Quận 1, TP.HCM'),
('NCC002', N'Công ty CP Điện Tử An Phát', N'456 Hoàng Diệu, Quận 7, TP.HCM'),
('NCC003', N'Tập Đoàn Phụ Kiện Điện Thoại Toàn Cầu', N'789 Trần Hưng Đạo, Quận 5, TP.HCM'),
('NCC004', N'Công ty TNHH Linh Kiện TechPro', N'101 Nguyễn Huệ, Quận 1, TP.HCM'),
('NCC005', N'Nhà Phân Phối Phụ Kiện Mobitech', N'222 Phan Xích Long, Phú Nhuận, TP.HCM');
GO

INSERT INTO SANPHAM (MASP, TENSP, MALOAI, MANCC, MOTA, GIABAN, TONKHO, TINHTRANG) VALUES
('SP001', N'Ốp lưng iPhone 13', 'L001', 'NCC001', N'Ốp lưng chống sốc, chất liệu silicone', 150000, 50, N'Còn hàng'),
('SP002', N'Cáp sạc USB-C', 'L002', 'NCC002', N'Cáp sạc nhanh USB-C 1.5m', 120000, 100, N'Còn hàng'),
('SP003', N'Tai nghe Bluetooth Sony', 'L003', 'NCC003', N'Tai nghe Bluetooth không dây, chất lượng âm thanh cao', 800000, 30, N'Còn hàng'),
('SP004', N'Kính cường lực Samsung S22', 'L004', 'NCC004', N'Kính cường lực trong suốt, chống trầy xước', 200000, 20, N'Còn hàng'),
('SP005', N'Sạc dự phòng 10000mAh', 'L005', 'NCC005', N'Sạc dự phòng dung lượng lớn, hỗ trợ sạc nhanh', 350000, 75, N'Còn hàng'),
('SP006', N'Pin iPhone 12', 'L006', 'NCC001', N'Pin chính hãng cho iPhone 12', 600000, 15, N'Còn hàng'),
('SP007', N'Giá đỡ điện thoại', 'L007', 'NCC002', N'Giá đỡ điện thoại linh hoạt, xoay 360 độ', 90000, 200, N'Còn hàng'),
('SP008', N'Thẻ nhớ 128GB', 'L008', 'NCC003', N'Thẻ nhớ tốc độ cao 128GB, hỗ trợ quay 4K', 450000, 60, N'Còn hàng'),
('SP009', N'Loa Bluetooth JBL', 'L009', 'NCC004', N'Loa Bluetooth âm thanh sống động, pin 12 giờ', 1200000, 40, N'Còn hàng'),
('SP010', N'Đế sạc không dây', 'L005', 'NCC003', N'Đế sạc không dây cho điện thoại, công suất 10W', 350000, 120, N'Còn hàng'),
('SP011', N'Dây đeo đồng hồ thông minh', 'L001', 'NCC005', N'Dây đeo silicone cho Apple Watch, nhiều màu sắc', 200000, 80, N'Còn hàng'),
('SP012', N'Ốp lưng Samsung Galaxy S21', 'L001', 'NCC001', N'Ốp lưng trong suốt, chống va đập', 180000, 70, N'Còn hàng'),
('SP013', N'Cáp Lightning cho iPhone', 'L002', 'NCC003', N'Cáp sạc nhanh Lightning 1m', 250000, 90, N'Còn hàng'),
('SP014', N'Tai nghe có dây Xiaomi', 'L003', 'NCC004', N'Tai nghe có dây, jack 3.5mm, âm thanh tốt', 150000, 100, N'Còn hàng'),
('SP015', N'Kính cường lực Oppo A74', 'L004', 'NCC002', N'Kính cường lực chống trầy xước, chống vỡ', 120000, 30, N'Còn hàng'),
('SP016', N'Sạc dự phòng 20000mAh', 'L005', 'NCC005', N'Sạc dự phòng dung lượng lớn, hỗ trợ 2 cổng sạc', 550000, 40, N'Còn hàng'),
('SP017', N'Pin Samsung Galaxy S9', 'L006', 'NCC003', N'Pin thay thế chính hãng cho Samsung Galaxy S9', 700000, 25, N'Còn hàng'),
('SP018', N'Giá đỡ máy tính bảng', 'L007', 'NCC001', N'Giá đỡ đa năng cho máy tính bảng, xoay 360 độ', 200000, 60, N'Còn hàng'),
('SP019', N'Thẻ nhớ 64GB', 'L008', 'NCC002', N'Thẻ nhớ tốc độ cao 64GB', 300000, 100, N'Còn hàng'),
('SP020', N'Loa Bluetooth Mini', 'L009', 'NCC004', N'Loa Bluetooth mini, âm thanh sống động, nhỏ gọn', 900000, 50, N'Còn hàng');
GO

INSERT INTO KHACHHANG (MAKH, TENKH, GIOITINH, SDT) VALUES
('KH001', N'Nguyễn Văn A', N'Nam', N'0123456789'),
('KH002', N'Trần Thị B', N'Nữ', N'0980000001'),
('KH003', N'Phạm Văn H', N'Nam', N'0987654321'),
('KH004', N'Nguyễn Văn C', N'Nam', N'0970000002'), 
('KH005', N'Hoàng Thị I', N'Nữ', N'0960000003'),
('KH006', N'Lê Thị D', N'Nữ', N'0912345678'),
('KH007', N'Bùi Văn K', N'Nam', N'0776543210'), 
('KH008', N'Phạm Văn E', N'Nam', N'0930000004'), 
('KH009', N'Nguyễn Thị F', N'Nữ', N'0834567890'),
('KH010', N'Vũ Thị L', N'Nữ', N'0978765432'), 
('KH011', N'Trần Văn G', N'Nam', N'0920000005'), 
('KH012', N'Đặng Thị M', N'Nữ', N'0950000006');
GO

INSERT INTO VAITRO (MAVT, TENVT) VALUES
('admin', N'admin'),
('VT001', N'Nhân viên quản lí nhân sự'),
('VT002', N'Nhân viên quản lí kho hàng'),
('VT003', N'Nhân viên kế toán'),
('VT004', N'Nhân viên báo cáo tài chính');
GO

INSERT INTO TAIKHOAN (TENDN, MKHAU, MAVT) VALUES
('admin', 'admin', 'admin'),
('nv001', '123', 'VT001'),
('nv002', '123', 'VT002'),
('nv003', '123', 'VT003'),
('nv004', '123', 'VT004');
GO

INSERT INTO NHANVIEN (MANV, TENNV, GIOITINH, SDT, NGAYSINH, DCNV, TRANGTHAI, TENDN) VALUES
('NV001', N'Nguyễn Văn A', N'Nam', '0123456789', '1985-01-15', N'Số 1, Đường A, Quận 1', N'Còn làm', 'nv001'),
('NV002', N'Trần Thị B', N'Nữ', '0987654321', '1990-02-20', N'Số 2, Đường B, Quận 2', N'Còn làm', 'nv002'),
('NV003', N'Phạm Văn C', N'Nam', '0112233445', '1988-03-25', N'Số 3, Đường C, Quận 3', N'Đã nghỉ', NULL),
('NV004', N'Nguyễn Thị D', N'Nữ', '0223344556', '1992-04-30', N'Số 4, Đường D, Quận 4', N'Còn làm', NULL),
('NV005', N'Trần Văn E', N'Nam', '0334455667', '1987-05-10', N'Số 5, Đường E, Quận 5', N'Đã nghỉ', NULL);
GO


INSERT INTO HOADON (MAHD, NGAYLAP, MAKH, MANV) VALUES
('HD001', '2024-10-01', 'KH001', 'NV001'),
('HD002', '2024-10-02', 'KH002', 'NV002'),
('HD003', '2024-10-03', 'KH003', 'NV003'),
('HD004', '2024-10-04', 'KH004', 'NV004'),
('HD005', '2024-10-05', 'KH005', 'NV005'),
('HD006', '2024-10-06', 'KH006', 'NV001'),
('HD007', '2024-10-07', 'KH007', 'NV002'),
('HD008', '2024-10-08', 'KH008', 'NV003'),
('HD009', '2024-10-09', 'KH009', 'NV004'),
('HD010', '2024-10-10', 'KH010', 'NV005'),
('HD011', '2024-10-11', 'KH011', 'NV001'),
('HD012', '2024-10-12', 'KH012', 'NV002'),
('HD013', '2024-10-13', 'KH001', 'NV003'),
('HD014', '2024-10-14', 'KH002', 'NV004'),
('HD015', '2024-10-15', 'KH003', 'NV005');
GO

INSERT INTO CHITIETHD (MAHD, MASP, SLMUA) VALUES
('HD001', 'SP001', 2),  -- 2 Ốp lưng iPhone 13
('HD001', 'SP002', 1),  -- 1 Cáp sạc USB-C
('HD002', 'SP003', 3),  -- 3 Tai nghe Bluetooth Sony
('HD002', 'SP004', 1),  -- 1 Kính cường lực Samsung S22
('HD003', 'SP005', 1),  -- 1 Sạc dự phòng 10000mAh
('HD004', 'SP006', 4),  -- 4 Pin iPhone 12
('HD004', 'SP007', 2),  -- 2 Giá đỡ điện thoại
('HD005', 'SP008', 5),  -- 5 Thẻ nhớ 128GB
('HD005', 'SP009', 2);  -- 2 Loa Bluetooth JBL
GO

INSERT INTO PHIEUNHAP (MAPN, NGAYDAT, MANCC) VALUES
('PN001', '2024-10-01', 'NCC001'),
('PN002', '2024-10-02', 'NCC002'),
('PN003', '2024-10-03', 'NCC003'),
('PN004', '2024-10-04', 'NCC004'),
('PN005', '2024-10-05', 'NCC005'),
('PN006', '2024-10-06', 'NCC001'),
('PN007', '2024-10-07', 'NCC002'),
('PN008', '2024-10-08', 'NCC003'),
('PN009', '2024-10-09', 'NCC004'),
('PN010', '2024-10-10', 'NCC005'),
('PN011', '2024-10-11', 'NCC001'),
('PN012', '2024-10-12', 'NCC002'),
('PN013', '2024-10-13', 'NCC003'),
('PN014', '2024-10-14', 'NCC004'),
('PN015', '2024-10-15', 'NCC005');
GO

INSERT INTO CHITIETPN (MAPN, MASP, SLDAT, GIADAT) VALUES
('PN001', 'SP001', 10, 140000),  -- 10 Ốp lưng iPhone 13
('PN001', 'SP002', 20, 110000),  -- 20 Cáp sạc USB-C
('PN002', 'SP003', 15, 750000),  -- 15 Tai nghe Bluetooth Sony
('PN002', 'SP004', 12, 180000),  -- 12 Kính cường lực Samsung S22
('PN003', 'SP005', 30, 300000),  -- 30 Sạc dự phòng 10000mAh
('PN003', 'SP006', 20, 550000),  -- 20 Pin iPhone 12
('PN004', 'SP007', 25, 80000),   -- 25 Giá đỡ điện thoại
('PN004', 'SP008', 15, 400000),   -- 15 Thẻ nhớ 128GB
('PN005', 'SP009', 5, 1100000);   -- 5 Loa Bluetooth JBL
GO

-- Thêm cột Thành tiền vào ChiTietHD
UPDATE CHITIETHD
SET THANHTIEN = SLMUA * (SELECT GIABAN FROM SANPHAM 
						WHERE CHITIETHD.MASP = SANPHAM.MASP);
GO
