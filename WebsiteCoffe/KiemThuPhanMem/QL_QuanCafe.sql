create database QL_QuanCafe

use QL_QuanCafe
---------------------
--drop table Tam_NhapKho
--drop table PhanQuyen
--drop table NhanVien
--drop table TenDoUong
--drop table LoaiDoUong
--drop table Kho
--drop table HoaDon
--drop table ChiTietBanHang
--drop table Tam_GioHang
--drop table ViTriNhanVien
--drop table ChiNhanh
--drop table DonViNguyenLieu
-------------------

create table MayChu
(
	TaiKhoan_admin		nvarchar(50) primary key,
	MatKhau_admin		nvarchar(50)
)
Insert into MayChu values(N'admin','123')

----------------------

create table ChiNhanh
(
	MaChiNhanh		char(2) primary key,
	TenChiNhanh		nvarchar(60)
)
-------------------
create table ViTriNhanVien
(
	MaNV			char(3) primary key,
	ViTri			nvarchar(20)
)

------------------
create table NhanVien
(
	STT				int identity(1,1),
	MaChiNhanh		char(2),
	MaNV			char(3),
	TenNhanVien		nvarchar(50),
	NamSinh			char(4),	
	SDT				char(11),
	foreign key (MaChiNhanh) references ChiNhanh(MaChiNhanh) on update cascade,
	foreign key (MaNV) references ViTriNhanVien(MaNV) on update cascade
)

create table PhanQuyen
(
	MaChiNhanh		char(2),
	TaiKhoan		 nvarchar(50) , -- chọn trong Combobox	
	MaNV			 char(3),
	Trang_QuanLy	 bit,-- trang Quản Lý
	Trang_BanHang	 bit,
	Trang_Kho		 bit,
	Trang_TongKet	 bit,	
)
create table Kho
(	
	MaChiNhanh			char(2),
	NgayNhap			datetime,
	TenNguyenLieu		nvarchar(50),
	SlNhap				float,
	DonViNguyenLieu		nvarchar(20),	
	DonGia				decimal(18,0),
	ThanhTien			decimal(18,0)
)
create table  Tam_NhapKho -- bảng tạm lưu nguyên liệu mới nhập vào kho để xuất báo cáo
(
	STT					int identity (1,1),
	MaChiNhanh			char(2),
	TenChiNhanh			nvarchar(60),
	MaNV				char(3), -- mã nv nhập kho
	NgayNhap			datetime,
	TenNguyenLieu		nvarchar(50),
	SlNhap				float,
	DonViNguyenLieu		nvarchar(20),	
	DonGia				decimal(18,0),
	ThanhTien			decimal(18,0),
	foreign key (MaChiNhanh) references ChiNhanh(MaChiNhanh) on update cascade
)
create table LoaiDoUong
(
	MaLoai		int identity(1,1) primary key,
	TenLoai		nvarchar(50),
	TrangThai	nvarchar(50)
)
create table TenDoUong
(
	STT				int identity(1,1),
	MaLoai			int,
	TenDoUong		nvarchar(70)  Primary key,
	DonGia			decimal(18,0),
	TrangThai		nvarchar(50),
	foreign key (MaLoai) references LoaiDoUong(MaLoai) on update cascade
)

create table Tam_GioHang -- Bảng Tạm Mua Hàng để in Hóa Đơn
(
	STT			int identity(1,1),
	MaHD		char(5),
	MaChiNhanh	char(2),
	TenChiNhanh	nvarchar(60),
	MaNV		char(3), -- mã nv lập phiếu
	Ngay		date,
	Gio			time,		
	TenDoUong	nvarchar(70),
	DonGia		decimal(18,0),
	SlMua		int,
	Tong		decimal(18,0),
	foreign key (MaChiNhanh) references ChiNhanh(MaChiNhanh) on update cascade
)
set dateformat dmy

create table HoaDon
(
	STT			int identity(1,1) ,
	MaHD		char(5) ,
	primary key (STT,MaHD),
	MaChiNhanh	char(2),
	Ngay		date,	
	Gio			time					
)

create table ChiTietBanHang
(
	STT			int identity(1,1) ,
	MaHD		char(5),
	MaChiNhanh	char(2),
	MaNV		char(3), -- mã nv lập phiếu
	Ngay		date,	
	Gio			time,		
	TenDoUong	nvarchar(70) ,
	DonGia		decimal(18,0),
	SlMua		int,
	Tong		decimal(18,0),
	primary key(TenDoUong,STT,MaHD),
	foreign key (MaChiNhanh) references ChiNhanh(MaChiNhanh) on update cascade,
	foreign key (TenDoUong) references TenDoUong(TenDoUong) on update cascade,	
	
	
)

create table DonViNguyenLieu
(
	DonViNhap	nvarchar(20)		
)
---------------------------
---
-- ghi chú: Mã Nhân Viên: Kho: k1, k2
--		                  Bán Hàng: b1,b2,b3,b4
---						  Quản Lý : ql	

--------------------------------------------------------------
Insert into ChiNhanh Values ('1',N'Cơ sở Điện Biên Phủ')
Insert into ChiNhanh Values ('2',N'Cơ sở Ung Văn Khiêm')
--------------------------------------------------------------
Insert into ViTriNhanVien Values ('ql',N'Quản Lý')
Insert into ViTriNhanVien Values ('tn1',N'Thu Ngân')
Insert into ViTriNhanVien Values ('tn2',N'Thu Ngân')
Insert into ViTriNhanVien Values ('pv1',N'Phục Vụ')
Insert into ViTriNhanVien Values ('pv2',N'Phục Vụ')
Insert into ViTriNhanVien Values ('pc1',N'Pha Chế')
Insert into ViTriNhanVien Values ('pc2',N'Pha Chế')
Insert into ViTriNhanVien Values ('k1',N'Kho')
--------------------------------------------------------------
Insert into NhanVien Values('1','ql',N'Nguyễn Thành Luận','1997','0123456789')
Insert into NhanVien Values('1','tn1',N'Nguyễn Mạnh Duy','1997','0123456789')
Insert into NhanVien Values('1','tn2',N'Phạm Ngọc Nhàn','1997','0123456789')
Insert into NhanVien Values('1','pv1',N'Đỗ Phạm Quang Khải','1997','0123456789')
Insert into NhanVien Values('1','pv2',N'Nguyễn Ngọc Hùng','1997','0123456789')
Insert into NhanVien Values('1','pc1',N'Nguyễn Minh Hoàng','1997','0123456789')
Insert into NhanVien Values('1','pc2',N'Đỗ Chí Cường','1997','0123456789')
Insert into NhanVien Values('1','k1',N'Nguyễn Cát Tiên','1997','0123456789')
---
Insert into NhanVien Values('2','ql',N'Đặng Ngọc Trầm','1997','0123456789')
Insert into NhanVien Values('2','tn1',N'Nguyễn Thanh Huy','1997','0123456789')
Insert into NhanVien Values('2','tn2',N'Nguyễn Phi Việt','1997','0123456789')
Insert into NhanVien Values('2','pv1',N'Nguyễn Công Khanh','1997','0123456789')
Insert into NhanVien Values('2','pv2',N'Nguyễn Minh Thuận','1997','0123456789')
Insert into NhanVien Values('2','pc1',N'Lê Mai Quyền','1997','0123456789')
Insert into NhanVien Values('2','pc2',N'Phương Thái Sơn','1997','0123456789')
Insert into NhanVien Values('2','k1',N'Trương Quang Học','1997','0123456789')
------------------------------------------------------------------

------------------------------Tài Khoản,QuanLy,Ban,Kho,TongKet 
Insert into PhanQuyen Values ('1',N'Quản Lý','ql','1','1', '1','1')
Insert into PhanQuyen Values ('1',N'Thu Ngân','tn1','0','1', '0','0')
Insert into PhanQuyen Values ('1',N'Thu Ngân','tn2','0','1', '0','0')
Insert into PhanQuyen Values ('1',N'Phục Vụ','pv1','0','1', '0','0')
Insert into PhanQuyen Values ('1',N'Phục Vụ','pv2','0','1', '0','0')
Insert into PhanQuyen Values ('1',N'Pha Chế','pc1','0','1', '0','0')
Insert into PhanQuyen Values ('1',N'Pha Chế','pc2','0','1', '0','0')
Insert into PhanQuyen Values ('1',N'Kho','k1',	   '0','0','1','0')

Insert into PhanQuyen Values ('2',N'Quản Lý','ql','1','1', '1','1')
Insert into PhanQuyen Values ('2',N'Thu Ngân','tn1','0','1', '0','0')
Insert into PhanQuyen Values ('2',N'Thu Ngân','tn2','0','1', '0','0')
Insert into PhanQuyen Values ('2',N'Phục Vụ','pv1','0','1', '0','0')
Insert into PhanQuyen Values ('2',N'Phục Vụ','pv2','0','1', '0','0')
Insert into PhanQuyen Values ('2',N'Pha Chế','pc1','0','1', '0','0')
Insert into PhanQuyen Values ('2',N'Pha Chế','pc2','0','1', '0','0')
Insert into PhanQuyen Values ('2',N'Kho','k1',	   '0','0','1','0')

------------------------------------------------------------------------------------------------------------------------------
INSERT LoaiDoUong(TenLoai, TrangThai) VALUES (N'Cà Phê',N'Hết Phục Vụ')
INSERT LoaiDoUong(TenLoai, TrangThai) VALUES (N'Trà Sữa',N'')
INSERT LoaiDoUong(TenLoai, TrangThai) VALUES (N'Sinh Tố',N'')
INSERT LoaiDoUong(TenLoai, TrangThai) VALUES (N'Trà',N'')
INSERT LoaiDoUong(TenLoai, TrangThai) VALUES (N'Nước Chanh',N'')
INSERT LoaiDoUong(TenLoai, TrangThai) VALUES (N'Cà Phê Ý',N'')
select * from LoaiDoUong
--
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (1,N'Cà Phê Đen',12000,N'')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (1,N'Cà Phê Sữa',14000,N'')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (2,N'Trà Sữa Trân Châu',15000,N'Hết Phục Vụ')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (2,N'Trà Sữa Phô Mai',15000,N'')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (3,N'Sinh Tố Bơ',10000,N'')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (3,N'Sinh Tố Dưa Hấu',12000,N'')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (4,N'Trà LipTon Chanh',20000,N'')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (4,N'Trà Đào',20000,N'')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (4,N'Trà Matcha',25000,N'')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (5,N'Nước Chanh Đá',25000,N'')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (5,N'Nước Chanh Muối',25000,N'')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (5,N'Nước Chanh Dây',27000,N'')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (6,N'Cà Phê Ý Americano',30000,N'')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (6,N'Cà Phê Ý Latte',30000,N'')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (6,N'Cà Phê Ý Cappuccino',30000,N'')
INSERT TenDoUong(MaLoai, TenDoUong, DonGia, TrangThai) VALUES (6,N'Cà Phê Ý Mocha',30000,N'')

----------------------------------------------------------------------------------------------------------------------
----------
--STT	MaChiNhanh MaNV	Ngay TenLoai TenDoUong	DonGia	SlMua Tong
set dateformat dmy
INSERT into ChiTietBanHang VALUES ('1','1','tn2','20/4/2018','08:30', N'Cà Phê Ý Americano',30000,2,60000 )
INSERT into ChiTietBanHang VALUES ('1','1','tn2','20/4/2018','08:30',N'Trà Sữa Trân Châu',15000,3,45000 )
INSERT into ChiTietBanHang VALUES ('2','1','tn2','20/4/2018','10:30', N'Trà Sữa Trân Châu',15000,3,45000 )
INSERT into ChiTietBanHang VALUES ('2','1','tn2','20/4/2018','10:30', N'Trà Sữa Trân Châu',15000,3,45000 )
INSERT into ChiTietBanHang VALUES ('3','1','tn2','20/4/2018','10:30', N'Trà Sữa Trân Châu',15000,3,45000 )
INSERT into ChiTietBanHang VALUES ('4','1','tn2','20/4/2018','11:00', N'Trà Đào',20000,3,60000 )
INSERT into ChiTietBanHang VALUES ('4','1','tn2','20/4/2018','11:00', N'Trà Đào',20000,3,60000 )
INSERT into ChiTietBanHang VALUES ('5','1','tn2','20/4/2018','12:00', N'Trà Đào',20000,3,60000 )
INSERT into ChiTietBanHang VALUES ('5','1','tn2','20/4/2018','12:00', N'Nước Chanh Đá',25000,2,50000 )
------
INSERT into ChiTietBanHang VALUES ('5','1','tn1','20/4/2018','12:00', N'Cà Phê Ý Cappuccino',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('5','1','tn1','20/4/2018','12:00', N'Cà Phê Ý Cappuccino',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('5','1','tn1','20/4/2018','12:00', N'Cà Phê Ý Cappuccino',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('5','1','tn1','20/4/2018','12:00', N'Cà Phê Ý Cappuccino',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('5','1','tn1','20/4/2018','12:00', N'Cà Phê Ý Cappuccino',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('6','1','tn1','20/4/2018','13:15', N'Cà Phê Ý Mocha',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('6','1','tn1','20/4/2018','13:15', N'Cà Phê Ý Mocha',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('6','1','tn1','20/4/2018','13:15', N'Cà Phê Ý Mocha',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('6','1','tn1','20/4/2018','13:15', N'Cà Phê Ý Mocha',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('7','1','tn1','20/4/2018','14:00', N'Trà Sữa Phô Mai',15000,2,30000 )
INSERT into ChiTietBanHang VALUES ('7','1','tn1','20/4/2018','14:00', N'Trà Sữa Phô Mai',15000,3,45000 )
INSERT into ChiTietBanHang VALUES ('7','1','tn1','20/4/2018','14:00', N'Trà Sữa Phô Mai',15000,3,45000 )
----------
INSERT into ChiTietBanHang VALUES ('8','1','tn2','21/4/2018','09:00', N'Cà Phê Ý Latte',30000,2,60000 )
INSERT into ChiTietBanHang VALUES ('8','1','tn2','21/4/2018','09:00', N'Cà Phê Ý Latte',30000,2,60000 )
INSERT into ChiTietBanHang VALUES ('8','1','tn2','21/4/2018','09:00', N'Cà Phê Ý Latte',30000,1,60000 )
INSERT into ChiTietBanHang VALUES ('8','1','tn2','21/4/2018','09:00', N'Cà Phê Ý Latte',30000,1,60000 )
INSERT into ChiTietBanHang VALUES ('8','1','tn2','21/4/2018','09:00', N'Cà Phê Ý Latte',30000,1,60000 )
INSERT into ChiTietBanHang VALUES ('8','1','tn2','21/4/2018','09:00', N'Cà Phê Ý Latte',30000,1,60000 )
INSERT into ChiTietBanHang VALUES ('9','1','tn2','21/4/2018','09:30', N'Cà Phê Ý Latte',30000,1,60000 )
INSERT into ChiTietBanHang VALUES ('9','1','tn2','21/4/2018','09:30', N'Cà Phê Ý Latte',30000,1,60000 )
------------------
INSERT into ChiTietBanHang VALUES ('9','1','tn1','21/4/2017','09:30', N'Cà Phê Đen',14000,2,28000 )
INSERT into ChiTietBanHang VALUES ('10','1','tn1','21/4/2017','09:45', N'Cà Phê Đen',14000,2,28000 )
INSERT into ChiTietBanHang VALUES ('11','1','tn1','21/4/2017','10:00', N'Cà Phê Đen',14000,2,28000 )
INSERT into ChiTietBanHang VALUES ('12','1','tn1','21/4/2017','10:30', N'Cà Phê Đen',14000,2,28000 )
INSERT into ChiTietBanHang VALUES ('13','1','tn1','21/4/2017','10:30', N'Cà Phê Đen',14000,2,28000 )
INSERT into ChiTietBanHang VALUES ('13','1','tn1','21/4/2017','10:30', N'Cà Phê Đen',12000,2,24000 )
INSERT into ChiTietBanHang VALUES ('13','1','tn1','21/4/2017','10:30', N'Cà Phê Đen',12000,2,24000 )
INSERT into ChiTietBanHang VALUES ('13','1','tn1','21/4/2017','10:30', N'Cà Phê Đen',12000,2,24000 )
--
INSERT into ChiTietBanHang VALUES ('13','1','tn2','21/4/2017','10:30', N'Trà Sữa Phô Mai',15000,1,15000 )
INSERT into ChiTietBanHang VALUES ('13','1','tn2','21/4/2017','10:30', N'Trà Đào',20000,3,60000 )
INSERT into ChiTietBanHang VALUES ('13','1','tn2','21/4/2017','10:30', N'Trà Đào',20000,3,60000 )
INSERT into ChiTietBanHang VALUES ('13','1','tn2','21/4/2017','10:30', N'Trà Đào',20000,3,60000 )
INSERT into ChiTietBanHang VALUES ('14','1','tn2','21/4/2017','11:00',N'Nước Chanh Dây',16000,5,80000 )
------
INSERT into ChiTietBanHang VALUES ('14','1','tn2','22/4/2017','09:00', N'Sinh Tố Bơ',10000,2,20000 )
INSERT into ChiTietBanHang VALUES ('14','1','tn2','22/4/2017','09:00', N'Sinh Tố Bơ',10000,2,20000 )
INSERT into ChiTietBanHang VALUES ('14','1','tn2','22/4/2017','09:00', N'Sinh Tố Bơ',10000,2,20000 )
INSERT into ChiTietBanHang VALUES ('14','1','tn2','22/4/2017','09:00', N'Sinh Tố Bơ',10000,2,20000 )
INSERT into ChiTietBanHang VALUES ('15','1','tn2','22/4/2017','10:30', N'Sinh Tố Dưa Hấu',12000,3,36000 )
INSERT into ChiTietBanHang VALUES ('15','1','tn2','22/4/2017','10:30', N'Sinh Tố Dưa Hấu',12000,3,36000  )
INSERT into ChiTietBanHang VALUES ('15','1','tn2','22/4/2017','10:30', N'Sinh Tố Dưa Hấu',12000,3,36000  )
INSERT into ChiTietBanHang VALUES ('15','1','tn2','22/4/2017','10:30', N'Sinh Tố Dưa Hấu',12000,3,36000  )
------
INSERT into ChiTietBanHang VALUES ('15','1','tn1','22/4/2017','10:30', N'Sinh Tố Dưa Hấu',12000,3,36000  )
INSERT into ChiTietBanHang VALUES ('15','1','tn1','22/4/2017','10:30', N'Trà Sữa Trân Châu',15000,1,15000 )
INSERT into ChiTietBanHang VALUES ('15','1','tn1','22/4/2017','10:30', N'Trà Sữa Trân Châu',15000,1,15000 )
INSERT into ChiTietBanHang VALUES ('15','1','tn1','22/4/2017','10:30', N'Trà Sữa Phô Mai',15000,1,15000 )
INSERT into ChiTietBanHang VALUES ('16','1','tn1','20/4/2017','15:30', N'Trà Sữa Trân Châu',15000,1,15000 )
INSERT into ChiTietBanHang VALUES ('16','1','tn1','20/4/2017','15:30', N'Trà Lipton Chanh',20000,2,40000 )
INSERT into ChiTietBanHang VALUES ('16','1','tn1','20/4/2017','15:30', N'Trà Lipton Chanh',20000,2,40000 )
INSERT into ChiTietBanHang VALUES ('16','1','tn1','20/4/2017','15:30', N'Trà Lipton Chanh',20000,2,40000 )
INSERT into ChiTietBanHang VALUES ('16','1','tn1','20/4/2017','15:30', N'Nước Chanh Dây',27000,1,27000 )

--------------------------------------------------------------------------------------------------
INSERT into ChiTietBanHang VALUES ('16','2','tn2','20/4/2018','08:45', N'Cà Phê Ý Americano',30000,2,60000 )
INSERT into ChiTietBanHang VALUES ('16','2','tn2','20/4/2018','08:45', N'Trà Sữa Trân Châu',15000,3,45000 )
INSERT into ChiTietBanHang VALUES ('16','2','tn2','20/4/2018','08:45', N'Trà Sữa Trân Châu',15000,3,45000 )
INSERT into ChiTietBanHang VALUES ('16','2','tn2','20/4/2018','08:45', N'Trà Sữa Trân Châu',15000,3,45000 )
INSERT into ChiTietBanHang VALUES ('16','2','tn2','20/4/2018','08:45', N'Trà Sữa Trân Châu',15000,3,45000 )
INSERT into ChiTietBanHang VALUES ('16','2','tn2','20/4/2018','08:45', N'Trà Đào',20000,3,60000 )
INSERT into ChiTietBanHang VALUES ('16','2','tn2','20/4/2018','08:45', N'Trà Đào',20000,3,60000 )
INSERT into ChiTietBanHang VALUES ('16','2','tn2','20/4/2018','08:45', N'Trà Đào',20000,3,60000 )
INSERT into ChiTietBanHang VALUES ('17','2','tn2','21/4/2018','09:00', N'Nước Chanh Đá',25000,2,50000 )
----
INSERT into ChiTietBanHang VALUES ('17','2','tn1','21/4/2018','09:00', N'Cà Phê Ý Cappuccino',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('17','2','tn1','21/4/2018','09:00', N'Cà Phê Ý Cappuccino',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('17','2','tn1','21/4/2018','09:00', N'Cà Phê Ý Cappuccino',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('17','2','tn1','21/4/2018','09:00', N'Cà Phê Ý Cappuccino',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('17','2','tn1','21/4/2018','09:00', N'Cà Phê Ý Cappuccino',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('17','2','tn1','21/4/2018','09:00', N'Cà Phê Ý Mocha',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('17','2','tn1','21/4/2018','09:00', N'Cà Phê Ý Mocha',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('17','2','tn1','21/4/2018','09:00', N'Cà Phê Ý Mocha',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('17','2','tn1','21/4/2018','09:00', N'Cà Phê Ý Mocha',30000,1,30000 )
INSERT into ChiTietBanHang VALUES ('17','2','tn1','21/4/2018','09:00', N'Trà Sữa Phô Mai',15000,2,30000 )
INSERT into ChiTietBanHang VALUES ('18','2','tn1','22/4/2018','09:30', N'Trà Sữa Phô Mai',15000,3,45000 )
INSERT into ChiTietBanHang VALUES ('18','2','tn1','22/4/2018','09:30', N'Trà Sữa Phô Mai',15000,3,45000 )
---------
INSERT into ChiTietBanHang VALUES ('18','2','tn2','22/4/2018','09:30', N'Cà Phê Ý Latte',30000,2,60000 )
INSERT into ChiTietBanHang VALUES ('18','2','tn2','22/4/2018','09:30', N'Cà Phê Ý Latte',30000,2,60000 )
INSERT into ChiTietBanHang VALUES ('18','2','tn2','22/4/2018','09:30', N'Cà Phê Ý Latte',30000,1,60000 )
INSERT into ChiTietBanHang VALUES ('18','2','tn2','22/4/2018','09:30', N'Cà Phê Ý Latte',30000,1,60000 )
INSERT into ChiTietBanHang VALUES ('18','2','tn2','22/4/2018','09:30', N'Cà Phê Ý Latte',30000,1,60000 )
INSERT into ChiTietBanHang VALUES ('18','2','tn2','22/4/2018','09:30', N'Cà Phê Ý Latte',30000,1,60000 )
INSERT into ChiTietBanHang VALUES ('18','2','tn2','22/4/2018','09:30', N'Cà Phê Ý Latte',30000,1,60000 )
INSERT into ChiTietBanHang VALUES ('18','2','tn2','22/4/2018','09:30', N'Cà Phê Ý Latte',30000,1,60000 )
------------------
INSERT into ChiTietBanHang VALUES ('19','2','tn1','23/4/2017','10:30', N'Cà Phê Đen',14000,2,28000 )
INSERT into ChiTietBanHang VALUES ('19','2','tn1','23/4/2017','10:30', N'Cà Phê Đen',14000,2,28000 )
INSERT into ChiTietBanHang VALUES ('19','2','tn1','23/4/2017','10:30', N'Cà Phê Đen',14000,2,28000 )
INSERT into ChiTietBanHang VALUES ('19','2','tn1','23/4/2017','10:30', N'Cà Phê Đen',14000,2,28000 )
INSERT into ChiTietBanHang VALUES ('19','2','tn1','23/4/2017','10:30', N'Cà Phê Đen',14000,2,28000 )
INSERT into ChiTietBanHang VALUES ('19','2','tn1','23/4/2017','10:30', N'Cà Phê Đen',12000,2,24000 )
INSERT into ChiTietBanHang VALUES ('19','2','tn1','23/4/2017','10:30', N'Cà Phê Đen',12000,2,24000 )
INSERT into ChiTietBanHang VALUES ('19','2','tn1','23/4/2017','10:30', N'Cà Phê Đen',12000,2,24000 )
---
INSERT into ChiTietBanHang VALUES ('19','2','tn2','23/4/2017','10:30', N'Trà Sữa Phô Mai',15000,1,15000 )
INSERT into ChiTietBanHang VALUES ('19','2','tn2','23/4/2017','10:30', N'Trà Đào',20000,3,60000 )
INSERT into ChiTietBanHang VALUES ('19','2','tn2','23/4/2017','10:30', N'Trà Đào',20000,3,60000 )
INSERT into ChiTietBanHang VALUES ('19','2','tn2','23/4/2017','10:30', N'Trà Đào',20000,3,60000 )
INSERT into ChiTietBanHang VALUES ('19','2','tn2','23/4/2017','10:30', N'Nước Chanh Dây',16000,5,80000 )
------
INSERT into ChiTietBanHang VALUES ('20','2','tn2','24/4/2017','11:00', N'Sinh Tố Bơ',10000,2,20000 )
INSERT into ChiTietBanHang VALUES ('20','2','tn2','24/4/2017','11:00', N'Sinh Tố Bơ',10000,2,20000 )
INSERT into ChiTietBanHang VALUES ('20','2','tn2','24/4/2017','11:00', N'Sinh Tố Bơ',10000,2,20000 )
INSERT into ChiTietBanHang VALUES ('20','2','tn2','24/4/2017','11:00', N'Sinh Tố Dưa Hấu',12000,3,36000 )
INSERT into ChiTietBanHang VALUES ('20','2','tn2','24/4/2017','11:00', N'Sinh Tố Dưa Hấu',12000,3,36000  )
INSERT into ChiTietBanHang VALUES ('20','2','tn2','24/4/2017','11:00', N'Sinh Tố Dưa Hấu',12000,3,36000  )
INSERT into ChiTietBanHang VALUES ('20','2','tn2','24/4/2017','11:00', N'Sinh Tố Dưa Hấu',12000,3,36000  )
-----
INSERT into ChiTietBanHang VALUES ('21','2','tn1','24/4/2017','20:30', N'Sinh Tố Dưa Hấu',12000,3,36000  )
INSERT into ChiTietBanHang VALUES ('21','2','tn1','24/4/2017','20:30', N'Trà Sữa Trân Châu',15000,1,15000 )
INSERT into ChiTietBanHang VALUES ('21','2','tn1','24/4/2017','20:30', N'Trà Sữa Trân Châu',15000,1,15000 )
INSERT into ChiTietBanHang VALUES ('21','2','tn1','24/4/2017','20:30', N'Trà Sữa Phô Mai',15000,1,15000 )
INSERT into ChiTietBanHang VALUES ('21','2','tn1','24/4/2017','20:30', N'Trà Sữa Trân Châu',15000,1,15000 )
INSERT into ChiTietBanHang VALUES ('21','2','tn1','24/4/2017','20:30', N'Trà Lipton Chanh',20000,2,40000 )
INSERT into ChiTietBanHang VALUES ('21','2','tn1','24/4/2017','20:30', N'Trà Lipton Chanh',20000,2,40000 )
INSERT into ChiTietBanHang VALUES ('21','2','tn1','24/4/2017','20:30', N'Trà Lipton Chanh',20000,2,40000 )
INSERT into ChiTietBanHang VALUES ('21','2','tn1','24/4/2017','20:30', N'Nước Chanh Dây',27000,1,27000 )
------------------------------------------------------------------------------------------------------------------------------
	---------------------- MaHD,MaCN,Ngay,Gio
set dateformat dmy
INSERT into HoaDon VALUES ('1','1','20/4/2018','08:30' )
INSERT into HoaDon VALUES ('1','1','20/4/2018','08:30')
INSERT into HoaDon VALUES ('2','1','20/4/2018','10:30')
INSERT into HoaDon VALUES ('2','1','20/4/2018','10:30')
INSERT into HoaDon VALUES ('3','1','20/4/2018','10:30')
INSERT into HoaDon VALUES ('4','1','20/4/2018','11:00' )
INSERT into HoaDon VALUES ('4','1','20/4/2018','11:00')
INSERT into HoaDon VALUES ('5','1','20/4/2018','12:00' )
INSERT into HoaDon VALUES ('5','1','20/4/2018','12:00')

INSERT into HoaDon VALUES ('5','1','20/4/2018','12:00')
INSERT into HoaDon VALUES ('5','1','20/4/2018','12:00')
INSERT into HoaDon VALUES ('5','1','20/4/2018','12:00' )
INSERT into HoaDon VALUES ('5','1','20/4/2018','12:00')
INSERT into HoaDon VALUES ('5','1','20/4/2018','12:00' )
INSERT into HoaDon VALUES ('6','1','20/4/2018','13:15' )
INSERT into HoaDon VALUES ('6','1','20/4/2018','13:15' )
INSERT into HoaDon VALUES ('6','1','20/4/2018','13:15')
INSERT into HoaDon VALUES ('6','1','20/4/2018','13:15' )
INSERT into HoaDon VALUES ('7','1','20/4/2018','14:00' )
INSERT into HoaDon VALUES ('7','1','20/4/2018','14:00' )
INSERT into HoaDon VALUES ('7','1','20/4/2018','14:00' )
----------
INSERT into HoaDon VALUES ('8','1','21/4/2018','09:00')
INSERT into HoaDon VALUES ('8','1','21/4/2018','09:00' )
INSERT into HoaDon VALUES ('8','1','21/4/2018','09:00' )
INSERT into HoaDon VALUES ('8','1','21/4/2018','09:00')
INSERT into HoaDon VALUES ('8','1','21/4/2018','09:00' )
INSERT into HoaDon VALUES ('8','1','21/4/2018','09:00')
INSERT into HoaDon VALUES ('9','1','21/4/2018','09:30' )
INSERT into HoaDon VALUES ('9','1','21/4/2018','09:30')
------------------
INSERT into HoaDon VALUES ('9','1','21/4/2017','09:30' )
INSERT into HoaDon VALUES ('10','1','21/4/2017','09:45' )
INSERT into HoaDon VALUES ('11','1','21/4/2017','10:00')
INSERT into HoaDon VALUES ('12','1','21/4/2017','10:30' )
INSERT into HoaDon VALUES ('13','1','21/4/2017','10:30')
INSERT into HoaDon VALUES ('13','1','21/4/2017','10:30' )
INSERT into HoaDon VALUES ('13','1','21/4/2017','10:30')
INSERT into HoaDon VALUES ('13','1','21/4/2017','10:30' )
--
INSERT into HoaDon VALUES ('13','1','21/4/2017','10:30' )
INSERT into HoaDon VALUES ('13','1','21/4/2017','10:30' )
INSERT into HoaDon VALUES ('13','1','21/4/2017','10:30')
INSERT into HoaDon VALUES ('13','1','21/4/2017','10:30')
INSERT into HoaDon VALUES ('14','1','21/4/2017','11:00' )
------
INSERT into HoaDon VALUES ('14','1','22/4/2017','09:00')
INSERT into HoaDon VALUES ('14','1','22/4/2017','09:00' )
INSERT into HoaDon VALUES ('14','1','22/4/2017','09:00' )
INSERT into HoaDon VALUES ('14','1','22/4/2017','09:00' )
INSERT into HoaDon VALUES ('15','1','22/4/2017','10:30' )
INSERT into HoaDon VALUES ('15','1','22/4/2017','10:30')
INSERT into HoaDon VALUES ('15','1','22/4/2017','10:30' )
INSERT into HoaDon VALUES ('15','1','22/4/2017','10:30')
------
INSERT into HoaDon VALUES ('15','1','22/4/2017','10:30')
INSERT into HoaDon VALUES ('15','1','22/4/2017','10:30')
INSERT into HoaDon VALUES ('15','1','22/4/2017','10:30' )
INSERT into HoaDon VALUES ('15','1','22/4/2017','10:30' )
INSERT into HoaDon VALUES ('16','1','20/4/2017','15:30' )
INSERT into HoaDon VALUES ('16','1','20/4/2017','15:30')
INSERT into HoaDon VALUES ('16','1','20/4/2017','15:30' )
INSERT into HoaDon VALUES ('16','1','20/4/2017','15:30')
INSERT into HoaDon VALUES ('16','1','20/4/2017','15:30' )

--------------------------------------------------------------------------------------------------
INSERT into HoaDon VALUES ('16','2','20/4/2018','08:45' )
INSERT into HoaDon VALUES ('16','2','20/4/2018','08:45')
INSERT into HoaDon VALUES ('16','2','20/4/2018','08:45' )
INSERT into HoaDon VALUES ('16','2','20/4/2018','08:45' )
INSERT into HoaDon VALUES ('16','2','20/4/2018','08:45' )
INSERT into HoaDon VALUES ('16','2','20/4/2018','08:45')
INSERT into HoaDon VALUES ('16','2','20/4/2018','08:45')
INSERT into HoaDon VALUES ('16','2','20/4/2018','08:45' )
INSERT into HoaDon VALUES ('17','2','21/4/2018','09:00')
----
INSERT into HoaDon VALUES ('17','2','21/4/2018','09:00' )
INSERT into HoaDon VALUES ('17','2','21/4/2018','09:00')
INSERT into HoaDon VALUES ('17','2','21/4/2018','09:00')
INSERT into HoaDon VALUES ('17','2','21/4/2018','09:00' )
INSERT into HoaDon VALUES ('17','2','21/4/2018','09:00')
INSERT into HoaDon VALUES ('17','2','21/4/2018','09:00')
INSERT into HoaDon VALUES ('17','2','21/4/2018','09:00')
INSERT into HoaDon VALUES ('17','2','21/4/2018','09:00')
INSERT into HoaDon VALUES ('17','2','21/4/2018','09:00')
INSERT into HoaDon VALUES ('17','2','21/4/2018','09:00')
INSERT into HoaDon VALUES ('18','2','22/4/2018','09:30' )
INSERT into HoaDon VALUES ('18','2','22/4/2018','09:30')
---------
INSERT into HoaDon VALUES ('18','2','22/4/2018','09:30')
INSERT into HoaDon VALUES ('18','2','22/4/2018','09:30' )
INSERT into HoaDon VALUES ('18','2','22/4/2018','09:30' )
INSERT into HoaDon VALUES ('18','2','22/4/2018','09:30' )
INSERT into HoaDon VALUES ('18','2','22/4/2018','09:30' )
INSERT into HoaDon VALUES ('18','2','22/4/2018','09:30' )
INSERT into HoaDon VALUES ('18','2','22/4/2018','09:30')
INSERT into HoaDon VALUES ('18','2','22/4/2018','09:30')
------------------
INSERT into HoaDon VALUES ('19','2','23/4/2017','10:30')
INSERT into HoaDon VALUES ('19','2','23/4/2017','10:30')
INSERT into HoaDon VALUES ('19','2','23/4/2017','10:30' )
INSERT into HoaDon VALUES ('19','2','23/4/2017','10:30' )
INSERT into HoaDon VALUES ('19','2','23/4/2017','10:30' )
INSERT into HoaDon VALUES ('19','2','23/4/2017','10:30' )
INSERT into HoaDon VALUES ('19','2','23/4/2017','10:30')
INSERT into HoaDon VALUES ('19','2','23/4/2017','10:30' )
---
INSERT into HoaDon VALUES ('19','2','23/4/2017','10:30' )
INSERT into HoaDon VALUES ('19','2','23/4/2017','10:30')
INSERT into HoaDon VALUES ('19','2','23/4/2017','10:30' )
INSERT into HoaDon VALUES ('19','2','23/4/2017','10:30')
INSERT into HoaDon VALUES ('19','2','23/4/2017','10:30' )
------
INSERT into HoaDon VALUES ('20','2','24/4/2017','11:00' )
INSERT into HoaDon VALUES ('20','2','24/4/2017','11:00' )
INSERT into HoaDon VALUES ('20','2','24/4/2017','11:00')
INSERT into HoaDon VALUES ('20','2','24/4/2017','11:00')
INSERT into HoaDon VALUES ('20','2','24/4/2017','11:00' )
INSERT into HoaDon VALUES ('20','2','24/4/2017','11:00' )
INSERT into HoaDon VALUES ('20','2','24/4/2017','11:00' )
-----
INSERT into HoaDon VALUES ('21','2','24/4/2017','20:30' )
INSERT into HoaDon VALUES ('21','2','24/4/2017','20:30' )
INSERT into HoaDon VALUES ('21','2','24/4/2017','20:30' )
INSERT into HoaDon VALUES ('21','2','24/4/2017','20:30')
INSERT into HoaDon VALUES ('21','2','24/4/2017','20:30' )
INSERT into HoaDon VALUES ('21','2','24/4/2017','20:30')
INSERT into HoaDon VALUES ('21','2','24/4/2017','20:30')
INSERT into HoaDon VALUES ('21','2','24/4/2017','20:30' )
INSERT into HoaDon VALUES ('21','2','24/4/2017','20:30' )

------------------------------------------------------------------------------------------
Insert Into DonViNguyenLieu Values(N'Kg')
Insert Into DonViNguyenLieu Values(N'Bịch')
Insert Into DonViNguyenLieu Values(N'Hộp')
Insert Into DonViNguyenLieu Values(N'Lon')
Insert Into DonViNguyenLieu Values(N'Chai')
Insert Into DonViNguyenLieu Values(N'Cái')
Insert Into DonViNguyenLieu Values(N'Trái')

------------------------------------------------------------------------------------------------------------------------------
--select * from LoaiDoUong
--select LoaiDoUong.MaLoai,TenLoai,TenDoUong,DonGia from TenDoUong,LoaiDoUong where TenDoUong.MaLoai = LoaiDoUong.MaLoai
--select * from ChiTietBanHang
--select * from LoaiDoUong where TrangThai=N''