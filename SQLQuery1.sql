use master;
drop database QlyHangHoaNhap;
create database QlyHangHoaNhap;
use QlyHangHoaNhap;

create table tblNhaCungCap(
	PK_sNhacungcapID nvarchar(10) primary key,
	sTenNhacungcap nvarchar(30),
	sFax nvarchar(30),
	sDiachi nvarchar(30),
	sSodienthoai nvarchar(20),
	sWebsite nvarchar(20));

create table tblHang(
	PK_sHangID nvarchar(10) primary key,
	sTenHang nvarchar(30),
	FK_sNhacungcapID nvarchar(10) references tblNhaCungCap(PK_sNhacungcapID),
	sDonvitinh nvarchar(10),
	sQuycach nvarchar(10));

create table tblHoadonNhap(
	PK_sHoadonNhapID nvarchar(10) primary key,
	tThoigianlap datetime,
	sHotenNguoilap nvarchar(30));

create table tblChitietHoadonNhap(
	FK_sHoadonNhapID nvarchar(10) references tblHoadonNhap(PK_sHoadonNhapID),
	FK_sHanghoaID nvarchar(10) references tblHang(PK_sHangID),
	fSoluong float);

	-- Nhập dữ liệu vào bảng Nhà cung cấp
INSERT INTO tblNhaCungcap (PK_sNhacungcapID, sTenNhacungcap, sFax, sDiachi, sSodienthoai, sWebsite)
VALUES ('NCC01', N'Nhà cung cấp A', '123456', N'Hà Nội', '0123456789', 'www.nhacungcapA.com'),
       ('NCC02', N'Nhà cung cấp B', '234567', N'Hải Phòng', '0234567891', 'www.nhacungcapB.com'),
       ('NCC03', N'Nhà cung cấp C', '345678', N'Đà Nẵng', '0345678912', 'www.nhacungcapC.com');

-- Nhập dữ liệu vào bảng Hàng
INSERT INTO tblHang (PK_sHangID, sTenHang, FK_sNhacungcapID, sDonvitinh, sQuycach)
VALUES ('H01', N'Hàng A', 'NCC01', N'Cái', N'Quy cách A'),
       ('H02', N'Hàng B', 'NCC02', N'Bộ', N'Quy cách B'),
       ('H03', N'Hàng C', 'NCC03', N'Thùng', N'Quy cách C');

-- Nhập dữ liệu vào bảng Hóa đơn nhập
INSERT INTO tblHoadonNhap (PK_sHoadonNhapID, tThoigianlap, sHotenNguoilap)
VALUES ('HDN01', '2023-12-01', N'Người lập 1'),
       ('HDN02', '2023-12-02', N'Người lập 2'),
       ('HDN03', '2023-12-03', N'Người lập 3');

-- Nhập dữ liệu vào bảng Chi tiết hóa đơn nhập
INSERT INTO tblChitietHoadonNhap (FK_sHoadonNhapID, FK_sHanghoaID, fSoluong)
VALUES ('HDN01', 'H01', 10),
       ('HDN02', 'H02', 20),
       ('HDN03', 'H03', 30);