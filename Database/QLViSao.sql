create database QLViSao
go
use QLViSao
go
CREATE TABLE He
(
	MaHe char(5) primary key,
	TenHe nvarchar(50)
)
CREATE TABLE ViSao
(
	MaViSao char(6) primary key,
	TenViSao nvarchar(50),
	Ngaynhap Datetime,
	MaHe char(5) foreign key(MaHe) references He(MaHe)
)
INSERT INTO He values 
('MH001', N'Hệ Mặt Trời'),
('MH002', N'Hệ Mặt Trăng')
INSERT INTO ViSao values
('MVS001', N'Sao Mai', '20201007', 'MH001'),
('MVS002', N'Sao Hôm', '20201007', 'MH002'),
('MVS003', N'Sao Kia', '20201007', 'MH001')
