use master
go

IF EXISTS(select * from sys.databases where name='QL_TourDuLich')
DROP DATABASE QL_TourDuLich
go

create database QL_TourDuLich
go

use QL_TourDuLich
go


create table KhachHang
(
	MaKH int identity(1,1) not null,
	HoTen nvarchar(30),
	GioiTinh int,
	NgaySinh date,
	SoDT varchar(20),
	CMND varchar(30),
	Passport varchar(30),
	QuocTich nvarchar(20),
	DiaChi nvarchar(30),
	TrangThai int,

	primary key (MaKH) 
)
create table NhanVien
(
	MaNV int identity(1,1),
	HoTen nvarchar(30),
	GioiTinh int,
	NgaySinh date,
	SoDT varchar(20),
	CMND varchar(30),
	DiaChi nvarchar(30),
	TrangThai int,

	primary key (MaNV) 
)
create table NhiemVu
(
	MaNVu int identity(1,1) not null,
	TenNVu nvarchar(30),

	primary key (MaNVu) 
)

go
insert into NhiemVu (TenNVu)
values 
(N'Tài xế'),
(N'Dướng dẫn viên'),
(N'Phục vụ'),
(N'Thông dịch viên'),
(N'Tạp vụ')


go
create table LoaiHinhDL
(
	MaLHDL int identity(1,1) not null,
	TenLHDL nvarchar(30),

	primary key (MaLHDL) 
)

go
insert into LoaiHinhDL (TenLHDL)
values 
(N'Du lịch di động'),
(N'Du lịch kết hợp nghề nghiệp'),
(N'Du lịch xã hội và gia đình')

go
create table TinhThanh
(
	MaTT int identity(1,1) not null,
	TenTT nvarchar(30),

	primary key (MaTT) 
)
create table DiaDiemDL
(
	MaDD int identity(1,1) not null,
	TenDD nvarchar(30),
	TinhThanh int,
	QuocGia nvarchar(30),

	primary key (MaDD),
	foreign key (TinhThanh) references TinhThanh(MaTT)
)
----------------------------------------------------
create table Tour
(
	MaTour int identity(1,1) not null,
	TenTour nvarchar(30),
	Gia int,
	SoDiemDuLich int ,
	SLNgay int,
	LoaiHinhDL int,
	TrangThai int,
	GhiChu nvarchar(50),

	primary key (MaTour),
	foreign key (LoaiHinhDL) references LoaiHinhDL(MaLHDL)
)
go
insert into Tour (TenTour,SoDiemDuLich,SLNgay,LoaiHinhDL)
values 
(N'Sài Gòn - Cà Mau',4,3,1),
(N'Sài Gòn - Nha Trang',4,3,1),
(N'Sài Gòn - Mũi Né',4,3,1)

go

create table Gia_Tour
(
	MaGia int identity(1,1) not null,
	MaTour int not null,
	ThoiGianBD date,-- thoi gian cu the
	ThoiGianKT date,
	Gia int,
	TrangThai int,
	GhiChu nvarchar(50),

	primary key (MaGia),
	foreign key (MaTour) references Tour(MaTour)
)

create table Tour_DiaDiemDL
(
	MaTour int not null,
	MaDD int not null,
	GhiChu nvarchar(50)

	primary key (MaTour,MaDD),
	foreign key (MaTour) references Tour(MaTour),
	foreign key (MaDD) references DiaDiemDL(MaDD)
)

create table DoanDL
(
	MaDoan int identity(1,1) not null,
	MaTour int not null,
	TenDoan nvarchar(30),
	NgayGioKhoiHanh date,
	NgayGioKetThuc date, 
	SLKhach int,
	SLNV int,
	NoiDungHanhTrinh nvarchar(max),
	TongCPKS int, --khach san
	TongCPPT int, --phuong tien
	TongCPBA int, --bua an
	TongCPKhac int,
	MaTourGia int,

	primary key (MaDoan)
)
create table DoanDL_KhachHang
(
	MaDoan int not null,
	MaKH int not null,
	GhiChu nvarchar(50)

	primary key (MaDoan,MaKH),
	foreign key (MaDoan) references DoanDL(MaDoan),
	foreign key (MaKH) references KhachHang(MaKH)
)

create table DoanDL_NhanVien
(
	MaDoan int not null,
	MaNV int not null,
	MaNhiemVu int not null,

	primary key (MaDoan,MaNV),
	foreign key (MaDoan) references DoanDL(MaDoan),
	foreign key (MaNV) references NhanVien(MaNV),
	foreign key (MaNhiemVu) references NhiemVu(MaNVu)
)

create table Doan_KhachSan
(
	MaDKS int identity(1,1) not null,
	MaDoan int not null,
	MaDD int not null,
	TenKS nvarchar(30),
	Gia int,
	GhiChu nvarchar(50),

	primary key (MaDKS),
	foreign key (MaDoan) references DoanDL(MaDoan),
	foreign key (MaDD) references DiaDiemDL(MaDD)
)

create table Doan_QuanAn
(
	MaDQA int identity(1,1) not null,
	MaDoan int not null,
	MaDD int not null,
	TenQA nvarchar(30),
	Gia int,
	GhiChu nvarchar(50),

	primary key (MaDQA),
	foreign key (MaDoan) references DoanDL(MaDoan),
	foreign key (MaDD) references DiaDiemDL(MaDD)
)

create table Doan_PhuongTien
(
	MaDPT int identity(1,1) not null,
	MaDoan int not null,
	TenPT nvarchar(30),
	Gia int,
	GhiChu nvarchar(50),

	primary key (MaDPT),
	foreign key (MaDoan) references DoanDL(MaDoan)
)

create table Doan_ChiPhiKhac
(
	MaDCPK int identity(1,1) not null,
	MaDoan int,
	TenCPKhac nvarchar(30),
	Gia int,
	GhiChu nvarchar(50),

	primary key (MaDCPK),
	foreign key (MaDoan) references DoanDL(MaDoan)
)

