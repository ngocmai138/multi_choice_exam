drop database NganHangCauHoi;
go

create database NganHangCauHoi;
go
use NganHangCauHoi;
go
create table tblLop(
					maLop nvarchar(10) primary key
					);
create table tblGiaoVien(
					ID int identity(1,1),
					maGV as 'GV' + right('0000' + cast(ID as nvarchar(10)),4) persisted primary key, 
					maLop nvarchar(10) references tblLop(maLop), 
					tenGV nvarchar(30));
create table tblSinhVien(
					ID int identity(1,1),
					maSV as 'SV' + right('0000' + cast(ID as nvarchar(10)),4) persisted primary key, 
					maLop nvarchar(10) references tblLop(maLop), 
					tenSV nvarchar(10));
create table tblCauHoi(
					ID int identity(1,1),
					maCH as 'CH' + right('0000'+cast (ID as nvarchar(10)), 4) persisted primary key, 
					noiDungCH nvarchar(100));
create table tblDapAn(
					ID int identity(1,1),
					maCH nvarchar(6), 
					maDA as 'DA' + right(cast(ID as nvarchar(10)),4) persisted, 
					noiDungDA nvarchar(100), 
					dung bit,
					primary key(maCH, maDA), 
					foreign key(maCH) references tblCauHoi(maCH) on delete cascade
					);
create table tblDeThi(
					ID int identity(1,1),
					maDe as 'DE' + right(cast(ID as nvarchar(10)),4) persisted primary key
					);
create table tblDeThi_CauHoi(
					maDe nvarchar(6) references tblDeThi(maDe),
					maCH nvarchar(6) references tblCauHoi(maCH),
					maDA nvarchar(6),
					primary key(maDe, maCH),
					foreign key(maCH, maDA) references tblDapAn(maCH, maDA)
					);

create table tblKetQua(
					ID int identity(1,1),
					maKQ as 'KQ' + right(cast (ID as nvarchar(10)),4) persisted primary key, 
					maSV nvarchar(6) references tblSinhVien(maSV), 
					maDe nvarchar(6) references tblDeThi(maDe), 
					ngayThi datetime, 
					diem float
					);
create table tblBaiLam(
					maKQ nvarchar(6) references tblKetQua(maKQ) on delete cascade, 
					maCH nvarchar(6) references tblCauHoi(maCH), 
					maDA nvarchar(6), 
					primary key(maKQ,maCH), 
					foreign key(maCH,maDA) references tblDapAn(maCH, maDA));
create table tblTaiKhoan(
					id nvarchar(10) primary key,
					matKhau nvarchar(20) default '123',
					loaiTK nvarchar(10) check(loaiTK in ('GiaoVien','SinhVien')));

go
-- Dữ liệu mẫu 
INSERT INTO tblLop(maLop) VALUES ('Lop1'), ('Lop2');

-- Thêm dữ liệu vào bảng tblGiaoVien
INSERT INTO tblGiaoVien(maLop, tenGV) VALUES ('Lop1', 'GiaoVien1'), ('Lop2', 'GiaoVien2');

-- Thêm dữ liệu vào bảng tblSinhVien
INSERT INTO tblSinhVien(maLop, tenSV) VALUES ('Lop1', 'SinhVien1'), ('Lop2', 'SinhVien2');
-- Thêm dữ liệu vào bảng tblTaiKhoan
insert into tblTaiKhoan(id, loaiTK) 
select maGV, 'GiaoVien' from tblGiaoVien 
union all
select maSV, 'SinhVien' from tblSinhVien;
-- Thêm dữ liệu vào bảng tblCauHoi
DECLARE @i INT = 1;
WHILE @i <= 20
BEGIN
  INSERT INTO tblCauHoi(noiDungCH) VALUES ('NoiDungCauHoi' + CAST(@i AS NVARCHAR(10)));
  SET @i = @i + 1;
END

-- Thêm dữ liệu vào bảng tblDapAn
DECLARE @j INT = 1;
WHILE @j <= 20
BEGIN
  DECLARE @k INT = 1;
  WHILE @k <= 4
  BEGIN
    -- Đảm bảo rằng mỗi câu hỏi có ít nhất một câu trả lời đúng
    DECLARE @dung BIT = CASE WHEN @k = 1 THEN 1 ELSE 0 END;
    INSERT INTO tblDapAn(maCH, noiDungDA, dung) VALUES ('CH' + RIGHT('0000' + CAST(@j AS NVARCHAR(10)), 4), 'NoiDungDapAn' + CAST(@k AS NVARCHAR(10)), @dung);
    SET @k = @k + 1;
  END
  SET @j = @j + 1;
END
go

--select * from tblDapAn

--TÀI KHOẢN
-- Đăng nhập
create procedure p_DangNhap
	@id nvarchar(10),
	@mk nvarchar(10)
as
select loaiTK from tblTaiKhoan where id = @id and matKhau = @mk;
go
-- Xem thông tin sv
create procedure p_SinhVien @maSV nvarchar(10)
as
select tenSV, maLop from tblSinhVien where maSV = @maSV
go
-- NGÂN HÀNG CÂU HỎI
-- xem danh sách Câu hỏi
create procedure p_DanhSachCH
as
select maCH as N'Mã câu hỏi', noiDungCH as N'Nội dung câu hỏi'
from tblCauHoi
go
--exec p_DanhSachCH
-- Xem đáp án theo maCH
create procedure p_ChiTietDA
	@maCH nvarchar(6)
as
select c.maCH as N'Mã câu hỏi', maDA as 'Mã đáp án', noiDungDA as N'Câu trả lời', dung as N'Đáp án đúng'
from tblCauHoi c
join tblDapAn d
on c.maCH = d.maCH
where c.maCH = @maCH
go
--exec p_ChiTietDA 'Ch0003'
-- Tìm kiếm câu hỏi theo mã câu hỏi
create procedure p_TimCHTheoMaCH
	@maCH nvarchar(6)
as
select maCH as N'Mã câu hỏi', noiDungCH as N'Nội dung câu hỏi' 
from tblCauHoi 
where maCH like @maCH;
--exec p_TimCHTheoMaCH @maCH='CH0001'
go
-- Tìm kiếm câu hỏi theo nội dung
create procedure p_TimCHTheoND
	@noiDungCH nvarchar(50)
as
select maCH as N'Mã câu hỏi', noiDungCH as N'Nội dung câu hỏi' 
from tblCauHoi 
where noiDungCH like '%'+@noiDungCH+'%';
go
-- Thêm câu hỏi và đáp án
create procedure p_ThemCauHoivaDapAn
	@noidungCH nvarchar(100),
	@noidungda1 nvarchar(100),
	@dung1 bit,
	@noidungda2 nvarchar(100),
	@dung2 bit,
	@noidungda3 nvarchar(100),
	@dung3 bit,
	@noidungda4 nvarchar(100),
	@dung4 bit
as
begin
declare @OutputTbl table (maCH nvarchar(10));
insert into tblCauHoi(noiDungCH) output inserted.maCH into @OutputTbl values (@noiDungCH);

declare @maCH nvarchar(10);
select @maCH = maCH from @OutputTbl;

insert into tblDapAn(maCH, noiDungDA, dung)
values 
	(@maCH,@noidungda1,@dung1),
	(@maCH,@noidungda2,@dung2),
	(@maCH,@noidungda3,@dung3),
	(@maCH,@noidungda4,@dung4);
end;
go

-- Sửa câu hỏi 
create procedure p_SuaCauHoi
	@maCH nvarchar(10),
	@noiDungCH nvarchar(100)
as
begin
update tblCauHoi
set noiDungCH = @noiDungCH
where maCH = @maCH;
end
go
-- Sửa đáp án
create procedure p_SuaDapAn
	@maCH nvarchar(10),
	@maDA nvarchar(10),
	@noiDungDA nvarchar(100),
	@dung bit
as
begin
update tblDapAn
set noiDungDA = @noiDungDA, dung = @dung
where maCH = @maCH and maDA = @maDA
end;
go

-- Xóa câu hỏi và đáp án
create procedure p_XoaCauHoi
@maCH nvarchar(10)
as
begin
delete from tblCauHoi
where maCH = @maCH;
end;
go
--exec p_XoaCauHoi @maCH = 'CH0002'

--NGÂN HÀNG ĐỀ THI
-- Xem danh sách mã đề thi
create proc p_XemDeThi
as
select maDe as N'Mã đề' from tblDeThi order by cast(SUBSTRING(maDe, 3, Len(maDE)) as int) desc
go
--exec p_XemDeThi
-- Tạo đề thi mới
create procedure p_TaoDeThi
@socau int, @maDe nvarchar(6) output
as
begin
	declare @maCH nvarchar(6);
	declare @counter int = 0;
	insert into tblDeThi default values;
	set @maDe = (select top 1 maDe from tblDeThi order by id desc);
	while @counter < @socau
	begin 
		select top 1 @maCH = maCH from tblCauHoi 
		where maCH NOT IN (select maCH from tblDeThi_CauHoi where maDe = @maDe) 
		order by NEWID();
		insert into tblDeThi_CauHoi(maDe,maCH) values (@maDe,@maCH);
		set @counter = @counter + 1;
	end
end
go
-- Xem câu hỏi trong Đề thi
--drop proc p_DeThi_CauHoi 
create proc p_DeThi_CauHoi 
	@maDe nvarchar(6)
as
select d.maCH, c.noiDungCH 
from tblDeThi_CauHoi d 
join tblCauHoi c 
on  d.maCH = c.maCH
where d.maDe = @maDe

--exec p_DeThi_CauHoi @maDe = 'DE2'
go
-- QUẢN LÝ BÀI THI
-- Xem kết quả
create proc p_XemBaiThi
as
select maKQ as N'Mã bài thi', maSV as N'Mã sinh viên', maDe as N'Mã đề', ngayThi as N'Ngày thi', diem as N'Điểm' 
from tblKetQua 
order by cast(SUBSTRING(maKQ, 3, len(maKQ)) as int) desc
go
exec p_XemBaiThi
go
-- Xem bài thi theo maSV và maDe
--drop proc p_XemKetQua
create proc p_XemKetQua @maSV nvarchar(6), @maDe nvarchar(6)
as
select maKQ, ngayThi, diem
from tblKetQua 
where maSV = @maSV and maDe = @maDe
order by cast(SUBSTRING(maKQ, 3, len(maKQ)) as int) desc
go
exec p_XemKetQua @maSV='sv0001', @maDe = 'De1'
go
-- Xem maKQ ket qua theo maSV va maDe
create proc p_XemBaiThi_maSVmaDe @maSV nvarchar(6), @maDe nvarchar(6)
as
select maKQ as N'Mã bài thi'from tblKetQua where maSV = @maSV and maDe = @maDe
go
--Xem maDe
create proc p_XemMaDe
as
select maDe as N'Mã đề' from tblDeThi order by cast(SUBSTRING(maDe, 3, len(maDe)) as int) desc
go
--Xem maSV
create proc p_XemMaSV
as
select maSV as N'Mã sinh viên' from tblSinhVien order by cast(SUBSTRING(maSV, 3, len(maSV)) as int) desc
go
-- Thêm mới bài làm
create procedure p_ThemBaiLamMoi
	@maKQ nvarchar(6),
	@maCH nvarchar(6),
	@maDA nvarchar(6)
as
begin
insert into tblBaiLam(maKQ,maCH,maDA) values (@maKQ, @maCH, @maDA);
update tblKetQua 
set diem = (
			select count(*) 
			from tblBaiLam b join tblDapAn d 
			on b.maCH = d.maCH and b.maDA = d.maDA  
			where b.maKQ = @maKQ and d.dung = 1)
where maKQ = @maKQ;
end;
go
-- Thêm mới bài thi
--drop procedure p_ThemBaiThiMoi
create procedure p_ThemBaiThiMoi
	@maDe nvarchar(6),
	@maSV nvarchar(6),
	@maKQ nvarchar(6) output,
	 @ngaythi datetime output
as
begin
declare @OutputTbl table (maKQ nvarchar(6));
set @ngaythi = GETDATE();
insert into tblKetQua(maSV, maDe, ngayThi)
output inserted.maKQ into @OutputTbl values (@maSV, @maDe, @ngaythi);
select @maKQ = maKQ from @OutputTbl
end

go
-- cập nhật điểm vào tblKetQua
drop proc p_CapNhatDiem 
create proc p_CapNhatDiem 
			@maKQ nvarchar(6), @diem float
as
update tblKetQua 
set diem = @diem
where maKQ = @maKQ;
go
exec p_CapNhatDiem @maKQ = 'kq4', @diem=2
--lấy mã đề ngẫu nhiên
--drop proc p_LayMaDeNgauNhien
create proc p_LayMaDeNgauNhien
as
select top 1 maDe
from tblDeThi
order by NEWID()
go
exec p_LayMaDeNgauNhien
-- TRIGGER
-- Tự động thêm mới tk vào tblTaiKhoan
create trigger t_ThemMoiTKGV
on tblGiaoVien
after insert
as
begin
insert into tblTaiKhoan(id, loaiTK) select maGV, 'GiaoVien' from inserted;
end;
go
create trigger t_ThemMoiTKSV
on tblSinhVien
after insert
as
begin
insert into tblTaiKhoan(id, loaiTK) select maSV, 'SinhVien' from inserted;
end;
go
--select * from tblTaiKhoan


--select * from tblDeThi
select * from tblKetQua