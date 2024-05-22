create database dbBookStore
go
use dbBookStore
go

-- create table

create table tblNhanVien
(	sMaNV  varchar(5) primary key,
	sTenNV nvarchar(25) ,
	dNgaysinh date  check (datediff(day,dNgaysinh , getdate())/365 >=18),
	sGioitinh nvarchar(4)  check (sGioiTinh = N'Nam' or sGioiTinh = N'Nữ'),
	sQuequan nvarchar(25) ,
	sSDT varchar(11) 
)


create table tblKhachHang 
(	sMaKH varchar(5) primary key,
	sTenKH nvarchar(60) not null,
	sDiachi nvarchar(25) not null,
	sSDT varchar(11) not null
)

go
create table tblNXB 
(	sMaNXB varchar(5) primary key,
	sTenNXB nvarchar(60) not null,
	sDiachi nvarchar(25),
	sSDT varchar(11)
)
go
create table tblSach 
(	sMasach varchar(5) primary key,
	sTensach nvarchar(25) not null,
	sMaNXB varchar(5) not null references tblNXB(sMaNXB),
	sTacgia nvarchar(25) not null,
	sTheloai nvarchar(30),
	iGia int check (iGia > 0)
)
go

create table tblHoaDon
(	sMaHD varchar(5) primary key,
	sMaNV varchar(5) not null references tblNhanVien(sMaNV),
	sMaKH varchar(5) not null references tblKhachHang(sMaKH),
	dNgaylap date check(dNgayLap <= getDate())
)
go
create table tblChiTietHD 
(	sMaHD varchar(5) references tblHoaDon(sMaHD),
	sMasach varchar(5) references tblSach(sMaSach),
	iSl int not null check (iSL >0),
	iTien int not null 
	constraint pk primary key (sMaHD, sMaSach)
)




---------------------------------------------------------------
insert into tblNXB
values('NXB1', N'Nhà xuất bản Kim Đồng',N'Hà Nội','0395478923'),
	  ('NXB2', N'Nhà xuất bản Trẻ', N'Thành phố Hồ Chí Minh', '0346985345'),
	  ('NXB3', N'Nhà xuất bản Giáo dục Việt Nam', N'Hà Nội', '0346985314'),
	  ('NXB4', N'Nhà xuất bản Thanh Niên', N'Thành phố Hồ Chí Minh', '0398742563'),
	  ('NXB5', N'Nhà xuất bản Văn Học', N'Thành phố Hồ Chí Minh', '0316789521')
go

select * from tblNhanVien

insert into tblNhanVien
values('NV01',N'Đỗ Trọng Ninh','2003/09/28',N'Nam',N'Thái Bình','0382127429','Admin','ninh','ninh'),
	('NV02',N'Nguyễn Đức Cường','2003/12/18',N'Nam',N'Bắc Ninh','0982127429',N'Nhân viên','cuong','cuong'),
	('NV03',N'Vũ Việt Anh','2003/12/18',N'Nam',N'Thái Bình','0782127429','Nhân viên','vanh','vanh'),
	('NV04',N'Lê Thu Hiền','2001/06/02',N'Nữ',N'Bình Dương','0482127429','Nhân viên','hien','hien'),
	('NV05',N'Bùi Thị Trang','2003/11/05',N'Nữ',N'Hà Nội','0582127429','Nhân viên','trang','trang')
go
select * from tblNhanVien
insert into tblSach
values('S01', N'Thám tử lừng danh Conan', 'NXB1', 'Gosho Aoyama', N'Truyện trinh thám', 18000,1998),
	  ('S02', N'Doraemon', 'NXB1', 'Fujiko F Fujio', N'Truyện tranh', 18000,1998),
	  ('S03', N'Shin - Cậu bé bút chì', 'NXB1', 'Yoshito Usui', N'Truyện tranh', 18000,2000),
	  ('S04', N'Còn chút gì để nhớ', 'NXB2', N'Nguyễn Nhật Ánh', N'Truyện dài', 550000,2000),
	  ('S05', N'Bàn có năm chỗ ngồi', 'NXB2', N'Nguyễn Nhật Ánh', N'Truyện dài', 38000,1999),
	  ('S06', 'Digiscience 3', 'NXB3', N'Trương Hạ Dương', N'Sách tham khảo', 65000,2001),
	  ('S07', N'Mãi mãi tuổi hai mươi', 'NXB4', N'Nguyễn Văn Thạc', N'Hồi ký', 123000,2003),
	  ('S08', N'Nghìn lẻ một đêm', 'NXB5', 'Antoine Galland', N'Truyện cổ tích', 70000,1997)
go





alter table tblSach
add iNamXB int

go


go
create proc prThemNXB(@manxb varchar(5), @tennxb nvarchar(60), @diachi nvarchar(25), @sdt varchar(11))
as
	begin
		insert into tblNXB
		values(@manxb, @tennxb, @diachi, @sdt)
	end
go
create view vvNXB
as
	select sMaNXB as [Mã nhà xuất bản], sTenNXB as [Tên nhà xuất bản], sDiachi as [Địa chỉ], sSDT as [Số điện thoại] 
	from tblNXB
go
create proc prSuaNXB(@manxb varchar(5), @tennxb nvarchar(60), @diachi nvarchar(25), @sdt varchar(11))
as
	begin
		update tblNXB
		set sTenNXB = @tennxb,
			sSDT = @sdt,
			sDiachi = @diachi
		where sMaNXB = @manxb
	end
go

create proc prThemSach(@masach varchar(5), @tensach nvarchar(25), @manxb varchar(5), @tacgia nvarchar(25), @theloai nvarchar(30),@gia int, @namxb int)
as
	begin
		insert into tblSach
		values(@masach, @tensach, @manxb, @tacgia, @theloai,@gia, @namxb)
	end
go
create proc prSuaSach(@masach varchar(5), @tensach nvarchar(25), @manxb varchar(5), @tacgia nvarchar(25), @theloai nvarchar(30),@gia int, @namxb int)
as
	begin
		update tblSach
		set sTensach = @tensach,
			sMaNXB = @manxb,
			sTacgia = @tacgia,
			sTheloai = @theloai,
			iGia = @gia,
			iNamXB = @namxb
		where sMasach = @masach
	end
go
create proc prXoaSach(@masach varchar(5))
as
	begin
		delete tblSach
		where sMasach = @masach
	end
go
create proc prXoaNXB(@manxb varchar(5))
as
	begin
		delete tblNXB
		where sMaNXB = @manxb
	end
go
create view vvSach
as
	select sMasach as [Mã sách], sTensach as [Tên sách], sMaNXB as [Mã nhà xuất bản], sTacgia as [Tác giả], sTheloai as [Thể loại], iGia as [Giá], iNamXB as [Năm xuất bản]
	from tblSach
go

create proc pr_thongkesach_nxb @thang int, @nam int
as
	begin
	SELECT 
    tblNXB.sMaNXB AS [Mã nhà xuất bản],
    MAX(tblNXB.sTenNXB) AS [Tên nhà xuất bản],
    SUM(tblChiTietHD.iSl) AS [Số lượng sách đã bán],
    SUM(tblChiTietHD.iSl * tblSach.iGia) AS [Tổng tiền sách bán được]
	FROM 
    tblNXB 
    JOIN tblSach ON tblNXB.sMaNXB = tblSach.sMaNXB
    JOIN tblChiTietHD ON tblSach.sMasach = tblChiTietHD.sMasach
    JOIN tblHoaDon ON tblChiTietHD.sMaHD = tblHoaDon.sMaHD
	WHERE 
    MONTH(tblHoaDon.dNgaylap) = @thang
	AND YEAR(tblHoaDon.dNgaylap) = @nam
	GROUP BY 
    tblNXB.sMaNXB
	end



go
	

	create proc prThemNV(@manv varchar(5), @tennv nvarchar(25),@ngaysinh date,@gioitinh nvarchar(4), @diachi nvarchar(25), @sdt varchar(11),@chucvu nvarchar(50),@tk varchar(50),@mk varchar(50))
as
	begin
		insert into tblNhanVien
		values(@manv, @tennv,@ngaysinh,@gioitinh, @diachi, @sdt,@chucvu,@tk,@mk)
	end

go
create or alter proc prSuaNV(@manv varchar(5), @tennv nvarchar(25),@ngaysinh date,@gioitinh nvarchar(4), @diachi nvarchar(25), @sdt varchar(11),@chucvu nvarchar(50),@tk varchar(50),@mk varchar(50))
 as begin
       update tblNhanVien set sMaNV=@manv,
	   sTenNV=@tennv,
	   dNgaysinh=@ngaysinh,
	   sGioitinh=@gioitinh,
	   sQuequan=@diachi,
	   sSDT=@sdt,sChucvu=@chucvu,
	   sMatk=@tk,sMk=@mk

	   
	   where sMaNV=@manv
 end
 go
 create proc prxoaNV(@manxb varchar(5))
as
	begin
		delete  tblNhanVien where sMaNV=@manxb
		
	end
go


create view vvNV
as
select sMaNV as[Mã NV],sTenNV as[Họ Tên],dNgaysinh as[Ngày sinh] ,sGioitinh as[Giới tính],sQuequan as[Quê quán],sSDT as[SDT],sChucvu as[Chức vụ]
from tblNhanVien
go 
select * from vvNV where ='Vũ Việt Anh'
go

create or alter proc prThongKeNhanVienNghiHuu
as
begin
    select sMaNV as [Mã NV] ,sTenNV as[Tên Nhân Viên] ,sGioitinh as[Giới Tính], dNgaysinh as[Ngày Sinh],sQuequan as[Quê Quán] ,sSDT as [SDT] ,sChucvu as[Chức Vụ] 
	from tblNhanVien
	where (sGioitinh = 'Nam' and datediff(year,dNgaysinh , getdate()) > 60) or (sGioitinh = N'Nữ' and datediff(year,dNgaysinh , getdate()) > 55)

end
go
exec prThongKeNhanVienNghiHuu




--tạo proc thêm mới khách hàng 1
go
create or alter proc prThemKH(@ma varchar(5) , @ten nvarchar(60) , @diachi nvarchar(25), @sdt nvarchar(11) ) 
	as
		begin 
			if not exists (select * from tblKhachHang where sMaKH = @ma)
				insert into tblKhachHang
					values(@ma, @ten, @diachi, @sdt)
			else
				print(N'Mã khách hàng đã tồn tại')
				
		end
go
exec prThemKH'001', N'Cao Nhật Minh', N'Hà Nội', '0392097532'
go


--tao proc cập nhật thông tin khách hàng 2
create or alter proc prCapnhatKH (@ma varchar(5) , @ten nvarchar(60) , @diachi nvarchar(25), @sdt nvarchar(11))
	as
	begin
	if exists (select * from tblKhachHang where sMaKH = @ma)
		update tblKhachHang
			set  sTenKH = @ten, sDiachi=@diachi, sSDT = @sdt
				where sMaKH = @ma
	else
		print(N'Mã khách hàng không tồn tại')
		
		

	end
	go
exec prCapnhatKH '001', N'Cao Nhật Minh', N'Hà Nội', '0392097532'
go
	-- tạo proc xem thông tin chi tiết 1 khách hàng 3
create or alter proc prChitietKH(@ma varchar(5))
	as
		begin 
			if exists (select *from tblKhachHang where sMaKH = @ma)	
				select *from tblKhachHang
					where sMaKH = @ma
			else
				print(N'Mã khách hàng không tồn tại')
		end
		go
exec prChitietKH @ma = '001'


go 
	--tạo proc hiển thị danh sách khách hàng 4
create or alter proc prHthiDSKH
as
select * from tblKhachHang



go

	-- tạo proc tìm kiếm khách hàng theo từ khóa 5
create or alter proc prTimkiemKH (@tukhoa nvarchar(30))
as
	begin
		select* from tblKhachHang
		where 
			lower(sTenKH) like '%' +lower(trim(@tukhoa)) + '%'
			or lower (sDiachi) like '%' +lower(trim(@tukhoa)) + '%'
			or lower (sSDT) like '%' + lower(trim(@tukhoa)) + '%'
		order by sTenKH asc 
	end


go

	-- tạo proc xóa thông tin 1 khách hàng 6
create or alter proc prXoaKH(@ma varchar(5))
	as
		begin
			if exists (select * from tblKhachHang where sMaKH = @ma)
				delete from tblKhachHang where sMaKH = @ma
			else
				print(N'Mã khách hàng không tồn tại')
		end

go
--TẠO PROC 

	--hien chi tiet 1 hoa don  7
create or alter proc prChitietHD (@mahd varchar(5) )
	as
		begin					
		select  sMaHD , sTensach, iSl  , iSl*iGia as N'thanhtien'
		from tblChiTietHD, tblSach
		where tblChiTietHD.sMasach = tblSach.sMasach and sMaHD = @mahd
		end

exec prChitietHD 'HD1'
	-- thêm mới hóa đơn cơ bản 8
go
create or alter proc prthemhdcoban (@mahd varchar(5) , @manv varchar(5) , @makh varchar(5) , @ngaylap date, @masach varchar(5) , @sl int )
	as
		begin 
			if not exists (select * from tblHoaDon where sMaHD = @mahd) 
				insert into tblHoaDon
					values(@mahd, @manv, @makh, @ngaylap)
			if not exists (select * from tblChiTietHD where sMaHD = @mahd) 
				insert into tblChiTietHD
						values (@mahd, @masach, @sl)

			else 
				print(N'Mã hóa đơn tồn tại')
				
		end
go
select * from tblKhachHang
exec prthemhdcoban 'HD3', 'NV1', '002' , '20220501','S01', 30

select * from tblHoaDon
select * from tblChiTietHD
	-- thêm mới thông tin chi tiết hóa đơn 9
go
create or alter proc prThemCTHD (@mahd varchar(5) , @masach varchar(5) , @sl int  )
	as

		begin
			if  exists (select * from tblHoaDon where sMaHD = @mahd) 
				if not exists(select * from tblChiTietHD where sMaHD = @mahd)
					insert into tblChiTietHD
						values (@mahd, @masach, @sl)
				
			else 
				print(N'khong the thuc thi')
		end

exec prThemCTHD 'HD2', 'S02' , 450

go
	-- pr hien ds hoa don 10
create or alter proc prHiendsHD 
	as
		select tblChiTietHD.sMaHD,dNgaylap, sTenKH, sTensach, iSl , iGia , iSl*iGia as 'thanhtien'
		from tblHoaDon, tblChiTietHD, tblKhachHang, tblSach
		where tblHoaDon.sMaHD = tblChiTietHD.sMaHD and tblHoaDon.sMaKH = tblKhachHang.sMaKH and tblChiTietHD.sMasach = tblSach.sMasach


exec prHiendsHD

	--proc lấy thông tin 1 hóa đơn cơ bản 11
go
create or alter proc prChitietHD_coban(@ma varchar(5))
	as
		begin 
			if exists (select *from tblHoaDon where sMaHD = @ma)	
				select *
				from tblHoaDon
					
				print(N'Mã hóa đơn không tồn tại')
		end
		go
exec prChitietHD_coban @ma = 'HD2'

go
	-- xóa hóa đơn cơ bản 12
create or alter proc prXoaHDcb (@mahd varchar(5))
	as
		begin
		if exists (select * from tblChiTietHD where sMaHD = @mahd)
					delete from tblChiTietHD
						where sMaHD = @mahd
			if exists (select * from tblHoaDon where sMaHD = @mahd)
				delete from tblHoaDon
					where sMaHD = @mahd
			
			else
				print(N'mã hóa đơn không tồn tại')
		end
go
exec prXoaHDcb HD1
go
--tim kiem danh sach hoadon 13

create or alter proc prtimkiemhoadon(@ngay int = 0  , @thang int = 0, @nam int = 0, @tenkh nvarchar(60), @tensach nvarchar(60))
as
	begin
		select tblChiTietHD.sMaHD,dNgaylap, sTenKH ,sTensach,iSl, iGia, iSl*iGia as 'thanhtien'
		from tblHoaDon, tblChiTietHD, tblKhachHang, tblSach
		where tblHoaDon.sMaHD = tblChiTietHD.sMaHD 
		and tblHoaDon.sMaKH = tblKhachHang.sMaKH 
		and tblChiTietHD.sMasach = tblSach.sMasach
		and 
			DAY(dNgaylap) = 

				case 
				when @ngay = 0 then day(dNgaylap)
				else @ngay 
				end
			and
			
			month(dNgaylap) = 
				case when @thang = 0 then month(dNgaylap)
				else @thang 
				end
			and
			year(dNgaylap) = 
				case when @nam = 0 then year(dNgaylap)
				else @nam
				end
		and
			sTenKH like '%' +@tenkh + '%'
		and
			sTensach like '%' +@tensach+'%'
			
	end


exec prtimkiemhd '16',0,0, N'', ''
go



select * from tblKhachHang




go
-- proc cập nhật thông tin của bảng hóa đơn cơ bản 17
create or alter proc prCapnhatHDcb (@mahd varchar(5) , @manv varchar(5) , @makh varchar(5), @ngaylap date)
	as
	begin
	if exists (select * from tblHoaDon where sMaHD = @mahd )
		update tblHoaDon
		set sMaNV = @manv , sMaKH = @makh, dNgaylap = @ngaylap where sMaHD = @mahd
		
	else
		print(N'Mã hóa đơn không tồn tại')

	end
	exec prCapnhatHDcb 'HD1', 'NV2', '002', '20230401'
	select * from tblHoaDon


	
	
go

-- tao proc sua chi tiet hoa don  18
create or alter proc prCapnhatchitiethd (@mahd varchar(5) , @sl int, @masach varchar(5) )
as
begin
	update tblChiTietHD
	 set iSl = @sl, sMasach = @masach
	 where sMaHD = @mahd
end

select * from tblChiTietHD
go


-- hien hoa don theo ma 21
create or alter proc prhienchitiethd( @ma varchar(5))
	as
		begin
			select tblChiTietHD.sMaHD, sMasach, sMaKH, sMaNV, dNgaylap ,iSl
			from tblChiTietHD, tblHoaDon
			where tblChiTietHD.sMaHD = @ma and tblChiTietHD.sMaHD = tblHoaDon.sMaHD

		end
--22
go
create or alter proc prthemhoadonct(@mahd varchar(5) , @masach varchar(5) , @sl int)
as
	begin
	
				insert into tblChiTietHD
						values (@mahd, @masach, @sl)
	end



	--23
	go
	create or alter proc prhienthisachdamua(@mahd varchar(5))
as
	select tblChiTietHD.sMasach,sTensach, iSl, iGia from tblSach, tblChiTietHD
	where tblChiTietHD.sMasach = tblSach.sMasach
	and tblChiTietHD.sMaHD = @mahd
	go

	--
	-- proc 9 : thêm mới thông tin của bảng chi tiết hóa đơn

create or alter proc prthemhoadonct(@mahd varchar(5) , @masach varchar(5) , @sl int)
as
	begin
	
				insert into tblChiTietHD
						values (@mahd, @masach, @sl)
	end

go


create or alter proc prsuahoadonct(@mahd varchar(5) , @masach varchar(5) , @sl int)
as
	begin
	
	

    UPDATE tblChiTietHD
    SET iSl = @sl
    WHERE sMaHD = @mahd
        AND sMaSach = @masach;
END



go


--xóa schi tiết
CREATE OR ALTER PROCEDURE DeleteFromTblChiTietHD
    @sMaHD varchar(5),
    @sMaSach varchar(5)
AS
BEGIN
   
    DELETE FROM tblChiTietHD
    WHERE sMaHD = @sMaHD AND sMaSach = @sMaSach;
END;




--------------------------------------------------đạt--------------------------------------------------------------

go
create proc prThongkeTheoLoai(@Loai nvarchar(30))
as
 begin
 select * from vvSach where [Thể loại]= @Loai
 end



------------------------------------------------------------quang----------------------------------------------------
select * from tblNhanVien where sMaNV like '%5%'