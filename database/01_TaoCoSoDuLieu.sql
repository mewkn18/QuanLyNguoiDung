/* Bai tap 2.2 - Tao co so du lieu QuanLyNguoiDung
   Chay lai nhieu lan van an toan. */

IF DB_ID(N'QuanLyNguoiDung') IS NULL
    CREATE DATABASE QuanLyNguoiDung;
GO

USE QuanLyNguoiDung;
GO

IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Users (
        UserId          INT IDENTITY(1,1) PRIMARY KEY,
        TenDangNhap     NVARCHAR(20)  NOT NULL,
        MatKhauBam      NVARCHAR(64)  NOT NULL,
        Salt            NVARCHAR(32)  NOT NULL,
        HoTen           NVARCHAR(50)  NOT NULL,
        Email           NVARCHAR(100) NULL,
        NgayTao         DATETIME2     NOT NULL CONSTRAINT DF_Users_NgayTao DEFAULT SYSDATETIME(),
        LanDangNhapCuoi DATETIME2     NULL,
        CONSTRAINT UQ_Users_TenDangNhap UNIQUE (TenDangNhap)
    );
END
GO

/* Ban ghi thu: chi de kiem tra bang. Tai khoan nay KHONG dang nhap duoc. */
IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE TenDangNhap = N'thu_nghiem')
    INSERT INTO dbo.Users (TenDangNhap, MatKhauBam, Salt, HoTen)
    VALUES (N'thu_nghiem', N'chua-bam', N'chua-co-salt', N'Người Dùng Thử');
GO

SELECT * FROM dbo.Users;