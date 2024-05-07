﻿CREATE DATABASE QLTL
GO
USE QLTL
GO

CREATE TABLE tb_CHUCVU(
MACV VARCHAR(10) PRIMARY KEY,
TENCV NVARCHAR(100),
HSL DECIMAL(10,2)
)

CREATE TABLE tb_PHONGBAN(
MAPB VARCHAR(10) PRIMARY KEY,
TENPB NVARCHAR(100)
)

CREATE TABLE tb_NHANVIEN(
MANV VARCHAR(10) PRIMARY KEY,
HOTEN NVARCHAR(30),
NGAYSINH DATE,
GT NVARCHAR(3),
DIACHI NVARCHAR(200),
SDT VARCHAR(11),
EMAIL VARCHAR(100),
NGAYVAOLAM DATE,
MAPB VARCHAR(10) FOREIGN KEY REFERENCES PHONGBAN(MAPB),
MACV VARCHAR(10) FOREIGN KEY REFERENCES CHUCVU(MACV),
LUONGCB DECIMAL(10,2)
)

CREATE TABLE tb_CHAMCONG(
MABCC VARCHAR(10),
MANV VARCHAR(10) FOREIGN KEY REFERENCES NHANVIEN(MANV),
SONC INT,
TANGCA INT,
MUON INT,
PRIMARY KEY (MABCC, MANV)
)

CREATE TABLE tb_LUONG(
MABL INT IDENTITY(1,1) PRIMARY KEY,
MABCC VARCHAR(10),
MANV VARCHAR(10),
BHXH DECIMAL(10,2),
BHYT DECIMAL(10,2),
THUETNCN DECIMAL(10,2),
THUCLANH DECIMAL(10,2),
FOREIGN KEY (MABCC, MANV) REFERENCES tb_CHAMCONG(MABCC, MANV)
)


INSERT INTO tb_CHUCVU VALUES
('TP', N'TRƯỞNG PHÒNG', 2.6),
('PP', N'PHÓ PHÒNG', 2.3),
('QL', N'QUẢN LÝ', 1.8),
('NV', N'NHÂN VIÊN', 1.5),
('TV', N'THỬ VIỆC', 1.0),
('TT', N'THỰC TẬP', 0.8)

INSERT INTO tb_PHONGBAN VALUES
('MKT', N'MARKETING'),
('TS',N'TELE-SALE'),
('IT',N'CÔNG NGHỆ'),
('HR',N'NHÂN SỰ' )

INSERT INTO tb_NHANVIEN VALUES
('01', N'Lê Việt Anh ', '1998-03-01', N'Nam', N'Hà Nội', '0987567463', ' levietanh@gmail.com', '2019-01-02', 'MKT', 'TP', 20000),
('02', N'Võ Thế Anh ', '2000-10-01', N'Nam ', N'Hà Nội', '0987567464', ' votheanh@gmail.com', '2019-01-02', 'MKT', 'PP', 16000),
('03', N'Nguyễn Thị Lan Ánh ', '1999-09-01', N'Nữ', N'Nghệ An', '0987567465', ' nguyenlananh@gmail.com', '2019-01-04', 'IT', 'TT', 8000),
('04', N'Đào Linh Chi', '1997-09-05', N'Nữ', N'Bắc Ninh', '0987567466', ' daolinhchi@gmail.com', '2019-01-05', 'IT', 'QL', 15000),
('05', N'Đỗ Thùy Dung', '2001-09-05', N'Nữ', N'Bắc Giang', '0987567467', ' dothuydung@gmail.com', '2019-01-04', 'HR', 'QL', 10000),
('06', N'Ngô Anh Duy', '1995-09-01', N'Nam', N'Thái Bình', '0987567468', ' ngoanhduy@gmail.com', '2019-01-07', 'TS', 'TP', 15000),
('07', N'Nguyễn Vũ Tiến Dũng ', '1999-04-06', N'Nam', N'Thái Nguyên', '0987567469', ' nguyenvutiendung@gmail.com', '2019-01-08', 'HR', 'NV', 10000),
('08', N'Kiều Quốc Đạt', '2003-01-11', N'Nam', N'Nghệ An', '0987567470', ' kieuquocdat@gmail.com', '2019-01-09', 'IT', 'NV', 12000),
('09', N'Nguyễn Ngọc Đạt', '2003-06-14', N'Nam', N'Hà Tĩnh', '0987567471', ' nguyenngocdat@gmail.com', '2019-01-04', 'TS', 'QL', 12000)
INSERT INTO tb_CHAMCONG VALUES
('T1-2024', '01', 23, 4, 2),
('T1-2024', '02', 22, 6, 4),
('T1-2024', '03', 25, 0, 1),
('T1-2024', '04', 2, 6, 4),
('T1-2024', '02', 22, 6, 4),
('T1-2024', '02', 22, 6, 4),
('T1-2024', '02', 22, 6, 4),
('T1-2024', '02', 22, 6, 4),
('T1-2024', '02', 22, 6, 4)
