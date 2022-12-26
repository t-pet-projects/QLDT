create database QLDT
go
use QLDT
go

create table TAIKHOAN (
	TenDangNhap varchar(20) primary key(TenDangNhap),
	MatKhau varchar(50)
);
go

create table SINHVIEN (
    MSSV VARCHAR(20) primary key(MSSV),
    HoTen NVARCHAR(50),
    GioiTinh int,
    NgaySinh DATE,
    Nganh NVARCHAR(100),
)



create table DIEM (
    MSSV VARCHAR(20) primary key(MSSV),
    DiemQuaTrinh DECIMAL(5, 3),
    DiemGiuaHocPhan DECIMAL(5, 3),
    DiemThiKetThuc DECIMAL(5, 3),

    foreign key(MSSV) references SINHVIEN(MSSV),
)


create table DIEMTOTNGHIEM (
    MSSV VARCHAR(20) primary key(MSSV),
    Diem DECIMAL(5, 3),
    XepLoai NVARCHAR(50)

    foreign key(MSSV) references SINHVIEN(MSSV),
);



insert into TAIKHOAN values('admin', '123');

insert into SINHVIEN values('018101042', N'Nguyễn Hoàng Phú', 1, '1/1/2000', N'Công Nghệ Thông Tin');
insert into SINHVIEN values('018101043', N'Nguyễn Hoàng Hải', 1, '1/1/2000', N'Công Nghệ Thông Tin');
insert into SINHVIEN values('018101000', N'Ngô Lâm Minh Quốc', 1, '1/1/2000', N'Công Nghệ Thông Tin');


select * from TAIKHOAN;
select * from SINHVIEN;



update SINHVIEN set HoTen=N'Nguyễn Hoàng Hải', GioiTinh=1, NgaySinh='01/02/2000' where MSSV='018101043'




select * from SINHVIEN;



-- Lệnh dùng để xoá csdl
-- USE master;
-- GO

-- ALTER DATABASE QLDT SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
-- GO
-- DROP DATABASE QLDT;
-- GO