use master
drop database NganHangCauHoi;

create database NganHangCauHoi;
use NganHangCauHoi;

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
					primary key(maDe, maCH)
					);
create table tblKetQua(
					ID int identity(1,1),
					maKQ as 'KQ' + right(cast (ID as nvarchar(10)),4) persisted primary key, 
					maSV nvarchar(6) references tblSinhVien(maSV), 
					maDe nvarchar(6) references tblDeThi(maDe), 
					ngayThi datetime, 
					diem float,
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
SELECT * FROM INFORMATION_SCHEMA.TABLES;

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


select * from tblDapAn

--TÀI KHOẢN
-- Đăng nhập
create procedure p_DangNhap
	@id nvarchar(10),
	@mk nvarchar(10)
as
select * from tblTaiKhoan where id = @id and matKhau = @mk;

-- NGÂN HÀNG CÂU HỎI
-- xem danh sách Câu hỏi
create procedure p_DanhSachCH
as
select maCH as N'Mã câu hỏi', noiDungCH as N'Nội dung câu hỏi'
from tblCauHoi
exec p_DanhSachCH
-- Xem đáp án theo maCH
drop procedure if exists p_ChiTietDA
create procedure p_ChiTietDA
	@maCH nvarchar(6)
as
select c.maCH as N'Mã câu hỏi', noiDungDA as N'Câu trả lời', dung as N'Đáp án đúng'
from tblCauHoi c
join tblDapAn d
on c.maCH = d.maCH
where c.maCH = @maCH

-- Tìm kiếm câu hỏi theo mã câu hỏi
drop procedure p_TimCHTheoMaCH
create procedure p_TimCHTheoMaCH
	@maCH nvarchar(6)
as
select maCH as N'Mã câu hỏi', noiDungCH as N'Nội dung câu hỏi' 
from tblCauHoi 
where maCH like @maCH;
exec p_TimCHTheoMaCH @maCH='CH0001'

-- Tìm kiếm câu hỏi theo nội dung
create procedure p_TimCHTheoND
	@noiDungCH nvarchar(50)
as
select maCH as N'Mã câu hỏi', noiDungCH as N'Nội dung câu hỏi' 
from tblCauHoi 
where noiDungCH like '%'+@noiDungCH+'%';

-- Thêm câu hỏi và đáp án
drop procedure p_ThemCauHoivaDapAn
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

exec p_ThemCauHoivaDapAn
		@noidungCH = N'Câu hỏi mới thêm vào',
		@noidungda1 = N'Đáp án 1', @dung1 = 0,
		@noidungda2 = N'Đáp án 2', @dung2 = 1,
		@noidungda3 = N'Đáp án 3', @dung3 = 0,
		@noidungda4 = N'Đáp án 4', @dung4 = 0;

exec p_DanhSachNHCH

-- Sửa câu hỏi và đáp án
create procedure p_SuaCauHoivaDapAn
	@maCH nvarchar(10),
	@noiDungCH nvarchar(100),
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
update tblCauHoi
set noiDungCH = @noiDungCH
where maCH = @maCH;

with cte as(
select maDA, noiDungDA, dung, ROW_NUMBER() over (order by maDA)
as RowNum
from tblDapAn
where maCH = @maCH)

update cte
set noiDungDA = 
case RowNum when 1 then @noidungda1
			when 2 then @noidungda2
			when 3 then @noidungda3
			when 4 then @noidungda4
			end,
dung = 
case RowNum when 1 then @dung1
			when 2 then @dung2
			when 3 then @dung3
			when 4 then @dung4
			end;
end;

exec p_SuaCauHoivaDapAn
		@maCH = 'CH0022',
		@noiDungCH = N'Câu hỏi sửa 1',
		@noidungda1 = N'Sửa Đáp án 1',
		@dung1 = 0,
		@noidungda2 = N'Đáp án sửa 2',
		@dung2 = 0,
		@noidungda3 = N'Đáp án sửa 3',
		@dung3 = 0,
		@noidungda4 = N'Đáp án sửa 4',
		@dung4 = 1

-- Xóa câu hỏi và đáp án
create procedure p_XoaCauHoi
@maCH nvarchar(10)
as
begin
delete from tblCauHoi
where maCH = @maCH;
end;
exec p_XoaCauHoi @maCH = 'CH0002'

-- Tạo đề thi mới
drop procedure p_TaoDeThi
create procedure p_TaoDeThi
@socau int
as
begin
declare @maDe nvarchar(6);
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
exec p_TaoDeThi @socau=10

select * from tblDeThi_CauHoi

-- QUẢN LÝ BÀI THI
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

-- Thêm mới bài thi
drop procedure p_ThemBaiThiMoi if exists p_ThemBaiThiMoi
create procedure p_ThemBaiThiMoi
	@maDe nvarchar(6),
	@maSV nvarchar(6)
as
begin
declare @ngaythi datetime;
set @ngaythi = GETDATE();
insert into tblKetQua(maSV, maDe, ngayThi) values (@maSV, @maDe, @ngaythi);
end
exec p_ThemBaiThiMoi @maDe='DE2',@maSV='SV0001'

-- TRIGGER
-- Tự động thêm mới tk vào tblTaiKhoan
create trigger t_ThemMoiTKGV
on tblGiaoVien
after insert
as
begin
insert into tblTaiKhoan(id, loaiTK) select maGV, 'GiaoVien' from inserted;
end;

create trigger t_ThemMoiTKSV
on tblSinhVien
after insert
as
begin
insert into tblTaiKhoan(id, loaiTK) select maSV, 'SinhVien' from inserted;
end;
select * from tblTaiKhoan