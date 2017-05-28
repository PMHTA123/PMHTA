use CSDL
GO
------- Bảng đăng nhập-----
create table DangNhap
	(
	idDangNhap varchar(20) primary key,
	matKhau nvarchar (20),
	trangThai bit
	)
insert into DangNhap values ('admin','admin',1)
Go

