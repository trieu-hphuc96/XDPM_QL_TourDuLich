use QL_TourDuLich

----------------------------------------------------------------------------------------------
go
--lấy danh sách tour
IF object_id('sp_layDanhSachTour') IS NOT NULL drop proc sp_layDanhSachTour

go
create proc sp_layDanhSachTour
as
	select *
	from Tour
