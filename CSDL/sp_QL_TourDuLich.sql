use QL_TourDuLich

----------------------------------------------------------------------------------------------
go
--lấy danh sách tour
IF object_id('sp_layDanhSachTour') IS NOT NULL drop proc sp_layDanhSachTour

go
create proc sp_layDanhSachTour
as
	select t.MaTour,t.TenTour,gt.Gia,t.SoDiemDuLich,t.SLNgay,t.LoaiHinhDL,t.TrangThai,t.GhiChu
	from Tour t , Gia_Tour gt
	where t.MaTour = gt.MaTour and gt.ThoiGianBD <= GETDATE() and gt.ThoiGianKT > GETDATE()
----------------------------------------------------------------------------------------------
go
--tìm kiếm danh sách tour
IF object_id('sp_timkiemDanhSachTour') IS NOT NULL drop proc sp_timkiemDanhSachTour

go
create proc sp_timkiemDanhSachTour
			@keyword nvarchar(50)
as
	select t.MaTour,t.TenTour,gt.Gia,t.SoDiemDuLich,t.SLNgay,t.LoaiHinhDL,t.TrangThai,t.GhiChu
	from Tour t , Gia_Tour gt
	where t.MaTour = gt.MaTour and gt.ThoiGianBD <= GETDATE() and gt.ThoiGianKT > GETDATE() and
		t.MaTour like '%'+@keyword+'%' and t.MaTour = gt.MaTour or t.TenTour like '%'+@keyword+'%' and t.MaTour = gt.MaTour
		or gt.Gia like '%'+@keyword+'%' and t.MaTour = gt.MaTour or t.SLNgay like '%'+@keyword+'%' and t.MaTour = gt.MaTour
		or t.LoaiHinhDL like '%'+@keyword+'%' and t.MaTour = gt.MaTour
----------------------------------------------------------------------------------------------
go
--lấy danh sách các địa điểm
IF object_id('sp_layDanhSachCacDiaDiem') IS NOT NULL drop proc sp_layDanhSachCacDiaDiem

go
create proc sp_layDanhSachCacDiaDiem
			@MaTour int
as
	select dd.*
	from DiaDiemDL dd, Tour_DiaDiemDL tdd
	where tdd.MaTour = @MaTour and tdd.MaDD = dd.MaDD

----------------------------------------------------------------------------------------------
go
--lấy thống kê chi phí khách sạn
IF object_id('sp_layThongKeChiPhiKhachSan') IS NOT NULL drop proc sp_layThongKeChiPhiKhachSan

go
create proc sp_layThongKeChiPhiKhachSan
			@MaTour int,
			@TuNgay date,
			@DenNgay date
as
	select ddl.MaDoan, ddl.TenDoan, dd.TenDD,dks.TenKS,dks.Gia
	from DoanDL ddl, Doan_KhachSan dks, DiaDiemDL dd
	where ddl.MaTour = @MaTour and dks.MaDoan = ddl.MaDoan and dd.MaDD = dks.MaDD and ddl.NgayGioKhoiHanh >= @TuNgay and ddl.NgayGioKetThuc <= @DenNgay

----------------------------------------------------------------------------------------------
go
--lấy thống kê chi phí khách sạn
IF object_id('sp_layThongKeDoanhThu') IS NOT NULL drop proc sp_layThongKeDoanhThu

go
create proc sp_layThongKeDoanhThu
			@MaTour int,
			@TuNgay date,
			@DenNgay date
as
	select t.TenTour,ddl.TenDoan,gt.Gia,ddl.NgayGioKhoiHanh,ddl.NgayGioKetThuc,ddl.SLKhach,ddl.SLNV,ddl.TongCPKS,ddl.TongCPPT,ddl.TongCPBA,ddl.TongCPKhac
	from DoanDL ddl, Gia_Tour gt, Tour t
	where ddl.MaTour = t.MaTour and t.MaTour = @MaTour and ddl.MaTourGia = gt.MaGia and ddl.NgayGioKhoiHanh >= @TuNgay and ddl.NgayGioKetThuc <= @DenNgay

----------------------------------------------------------------------------------------------
go
--lấy thống kê chi phí khách sạn
IF object_id('sp_layThongKeTinhHinh') IS NOT NULL drop proc sp_layThongKeTinhHinh

go
create proc sp_layThongKeTinhHinh
			@MaTour int
as
	select ddl.TenDoan,gt.Gia,ddl.NgayGioKhoiHanh,ddl.NgayGioKetThuc,ddl.SLKhach,ddl.SLNV,ddl.TongCPKS,ddl.TongCPPT,ddl.TongCPBA,ddl.TongCPKhac
	from DoanDL ddl, Gia_Tour gt
	where ddl.MaTour = @MaTour and ddl.MaTourGia = gt.MaGia


