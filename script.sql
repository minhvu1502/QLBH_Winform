USE [master]
GO
/****** Object:  Database [QLNhaHang]    Script Date: 07/07/2020 18:29:37 ******/
CREATE DATABASE [QLNhaHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLNhaHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QLNhaHang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLNhaHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QLNhaHang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QLNhaHang] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNhaHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLNhaHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNhaHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNhaHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNhaHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNhaHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNhaHang] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLNhaHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNhaHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNhaHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNhaHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNhaHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNhaHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNhaHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNhaHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNhaHang] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLNhaHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNhaHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNhaHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNhaHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNhaHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNhaHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNhaHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNhaHang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLNhaHang] SET  MULTI_USER 
GO
ALTER DATABASE [QLNhaHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNhaHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLNhaHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLNhaHang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLNhaHang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLNhaHang] SET QUERY_STORE = OFF
GO
USE [QLNhaHang]
GO
/****** Object:  Table [dbo].[PhieuDatBan]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDatBan](
	[MaPhieu] [varchar](50) NOT NULL,
	[MaKhach] [varchar](50) NULL,
	[MaNhanVien] [varchar](50) NULL,
	[NgayDat] [date] NULL,
	[NgayDung] [date] NULL,
	[TongTien] [float] NULL,
	[MaBan] [varchar](50) NULL,
 CONSTRAINT [PK_PhieuDatBan] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[TongTienQuy]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[TongTienQuy](@nam int) returns table
as
return(
	select MONTH(NgayDat) as Thang, SUM(TongTien) as TongTien
	from PhieuDatBan
	where YEAR(NgayDat)=@nam
	group by MONTH(NgayDat)
)
GO
/****** Object:  UserDefinedFunction [dbo].[TongTienNam]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[TongTienNam]() returns table
as
return(
	
	select SUM(TongTien) as TongTien
	from(
	select year(NgayDat) as Nam, SUM(TongTien) as TongTien
	from PhieuDatBan
	group by year(NgayDat)) as p
)
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMonAn] [varchar](50) NOT NULL,
	[TenMonAn] [nvarchar](50) NULL,
	[MaCongDung] [varchar](50) NULL,
	[MaLoai] [varchar](50) NULL,
	[CachLam] [nvarchar](200) NULL,
	[YeuCau] [nvarchar](200) NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_MonAn] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiMon]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMon](
	[MaLoai] [varchar](50) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiMon] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongDung]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongDung](
	[MaCongDung] [varchar](50) NOT NULL,
	[TenCongDung] [nvarchar](100) NULL,
 CONSTRAINT [PK_CongDung] PRIMARY KEY CLUSTERED 
(
	[MaCongDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[BaoCaoMonAn]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[BaoCaoMonAn]
as
select TenMonAn, TenCongDung, TenLoai, CachLam, DonGia
from MonAn, CongDung, LoaiMon
where MonAn.MaCongDung=CongDung.MaCongDung and MonAn.MaLoai=LoaiMon.MaLoai
GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[MaHoaDonNhap] [varchar](50) NOT NULL,
	[NgayNhap] [datetime] NULL,
	[MaNhanVien] [varchar](50) NULL,
	[MaNhaCungCap] [varchar](50) NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNguyenLieu] [varchar](50) NOT NULL,
	[TenNguyenLieu] [nvarchar](50) NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[SoLuong] [float] NULL,
	[DonGiaNhap] [float] NULL,
	[DonGiaBan] [float] NULL,
	[CongDung] [varchar](50) NULL,
	[YeuCau] [nvarchar](200) NULL,
	[ChongChiDinh] [nvarchar](200) NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonNhap]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhap](
	[MaNguyenLieu] [varchar](50) NOT NULL,
	[MaHoaDonNhap] [varchar](50) NOT NULL,
	[SoLuong] [float] NULL,
	[DonGia] [float] NULL,
	[KhuyenMai] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_ChiTietHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaNguyenLieu] ASC,
	[MaHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[BaoCaoNhapNL]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[BaoCaoNhapNL]
AS
SELECT        dbo.ChiTietHoaDonNhap.MaNguyenLieu as N'Mã Nguyên Liệu', dbo.NguyenLieu.TenNguyenLieu as N'Tên Nguyên Liệu', dbo.ChiTietHoaDonNhap.SoLuong as N'Số Lượng', dbo.ChiTietHoaDonNhap.DonGia as N'Đơn Giá', dbo.ChiTietHoaDonNhap.ThanhTien as N'Thành Tiền'
FROM            dbo.HoaDonNhap INNER JOIN
                         dbo.ChiTietHoaDonNhap ON dbo.HoaDonNhap.MaHoaDonNhap = dbo.ChiTietHoaDonNhap.MaHoaDonNhap INNER JOIN
                         dbo.NguyenLieu ON dbo.ChiTietHoaDonNhap.MaNguyenLieu = dbo.NguyenLieu.MaNguyenLieu
WHERE        (MONTH(dbo.HoaDonNhap.NgayNhap) = MONTH(GETDATE())) AND (YEAR(dbo.HoaDonNhap.NgayNhap) = YEAR(GETDATE()))
GO
/****** Object:  Table [dbo].[ChiTietPhieuDB]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuDB](
	[MaPhieu] [varchar](50) NOT NULL,
	[MaMonAn] [varchar](50) NOT NULL,
	[MaLoai] [varchar](50) NULL,
	[SoLuong] [float] NULL,
	[GiamGia] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_ChiTietPhieuDB] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieu_MonAn]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu_MonAn](
	[MaMonAn] [varchar](50) NOT NULL,
	[MaNguyenLieu] [varchar](50) NOT NULL,
	[SoLuong] [float] NULL,
 CONSTRAINT [PK_NguyenLieu_MonAn] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[BaoCaoXuatNL]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[BaoCaoXuatNL]
as
select NguyenLieu_MonAn.MaNguyenLieu, TenNguyenLieu, NguyenLieu_MonAn.SoLuong, DonGiaBan
from NguyenLieu_MonAn, NguyenLieu, PhieuDatBan, ChiTietPhieuDB, MonAn
where NguyenLieu.MaNguyenLieu=NguyenLieu_MonAn.MaNguyenLieu and PhieuDatBan.MaPhieu=ChiTietPhieuDB.MaPhieu and ChiTietPhieuDB.MaMonAn=MonAn.MaMonAn and MonAn.MaMonAn=NguyenLieu_MonAn.MaMonAn and MONTH(NgayDat)=MONTH(GETDATE()) and YEAR(NgayDat)=YEAR(GETDATE())
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](50) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](200) NULL,
	[MaQue] [varchar](50) NOT NULL,
	[DienThoai] [nchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khach]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach](
	[MaKhach] [varchar](50) NOT NULL,
	[TenKhach] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[DienThoai] [nchar](10) NULL,
 CONSTRAINT [PK_Khach] PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[BaoCaoPDB]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[BaoCaoPDB]
as
select MaPhieu, TenKhach, TenNhanVien, NgayDat, NgayDung, TongTien
from PhieuDatBan, Khach, NhanVien
where PhieuDatBan.MaKhach=Khach.MaKhach and PhieuDatBan.MaNhanVien=NhanVien.MaNhanVien
GO
/****** Object:  UserDefinedFunction [dbo].[TongTienThang]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[TongTienThang](@nam int) returns table
as
return(
	select MONTH(NgayDat) as Thang, SUM(TongTien) as TongTien
	from PhieuDatBan
	where YEAR(NgayDat)=@nam
	group by MONTH(NgayDat)
)
GO
/****** Object:  UserDefinedFunction [dbo].[TongTienTungNam]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[TongTienTungNam]() returns table
as
return(
	select year(NgayDat) as N'Năm', SUM(TongTien) as N'Tổng Tiền'
	from PhieuDatBan
	group by year(NgayDat)
	
)
GO
/****** Object:  Table [dbo].[a]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[a](
	[Nam] [int] NULL,
	[TongTien] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[phone] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[id] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[MaBan] [varchar](50) NOT NULL,
	[MaLoaiBan] [varchar](50) NULL,
 CONSTRAINT [PK_Ban] PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiBan]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiBan](
	[MaLoaiBan] [varchar](50) NOT NULL,
	[TenLoaiBan] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiBan] PRIMARY KEY CLUSTERED 
(
	[MaLoaiBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [varchar](50) NOT NULL,
	[TenNhaCungCap] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[DienThoai] [nchar](10) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[p]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[p](
	[Nam] [int] NULL,
	[TongTien] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Que]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Que](
	[MaQue] [varchar](50) NOT NULL,
	[TenQue] [nvarchar](50) NULL,
 CONSTRAINT [PK_Que] PRIMARY KEY CLUSTERED 
(
	[MaQue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[a] ([Nam], [TongTien]) VALUES (2019, NULL)
INSERT [dbo].[a] ([Nam], [TongTien]) VALUES (2020, 3575)
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([username], [password], [name], [phone], [email], [id]) VALUES (N'admin', N'admin', N'Vũ Quang Minh', NULL, NULL, 1)
INSERT [dbo].[Account] ([username], [password], [name], [phone], [email], [id]) VALUES (N'minhvuql', N'minhminh', N'Vũ Quang Minh', N'0394835311', N'vuquangminhql123@gmail.com', 2)
INSERT [dbo].[Account] ([username], [password], [name], [phone], [email], [id]) VALUES (N'admin123', N'minhminh', N'vcs', N'xcv', N'xvcv', 3)
INSERT [dbo].[Account] ([username], [password], [name], [phone], [email], [id]) VALUES (N'admin12345', N'minhminh', N'vcvc', N'vc', N'vcv', 4)
SET IDENTITY_INSERT [dbo].[Account] OFF
INSERT [dbo].[Ban] ([MaBan], [MaLoaiBan]) VALUES (N'MB01', N'MLB01')
INSERT [dbo].[Ban] ([MaBan], [MaLoaiBan]) VALUES (N'MB02', N'MLB02')
INSERT [dbo].[ChiTietHoaDonNhap] ([MaNguyenLieu], [MaHoaDonNhap], [SoLuong], [DonGia], [KhuyenMai], [ThanhTien]) VALUES (N'MNL01', N'HD01', 50, 10, 0, 500)
INSERT [dbo].[ChiTietPhieuDB] ([MaPhieu], [MaMonAn], [MaLoai], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'PDB01', N'MMA01', N'ML01', 19, 5, 1083)
INSERT [dbo].[ChiTietPhieuDB] ([MaPhieu], [MaMonAn], [MaLoai], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'PDB01', N'MMA02', N'ML01', 10, 0, 400000)
INSERT [dbo].[ChiTietPhieuDB] ([MaPhieu], [MaMonAn], [MaLoai], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'PDB02', N'MMA02', N'ML03', 5, 0, 1000)
INSERT [dbo].[ChiTietPhieuDB] ([MaPhieu], [MaMonAn], [MaLoai], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'PDB02', N'MMA03', N'ML01', 5, 0, 3575)
INSERT [dbo].[CongDung] ([MaCongDung], [TenCongDung]) VALUES (N'MCD01', N'Làm Đẹp Da')
INSERT [dbo].[CongDung] ([MaCongDung], [TenCongDung]) VALUES (N'MCD02', N'Sáng Mắt')
INSERT [dbo].[CongDung] ([MaCongDung], [TenCongDung]) VALUES (N'MCD03', N'Bổ Thận Tráng Dương')
INSERT [dbo].[CongDung] ([MaCongDung], [TenCongDung]) VALUES (N'MCD04', N'Tăng Cường Sinh Lực')
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap], [TongTien]) VALUES (N'12312', CAST(N'2020-06-30T00:00:00.000' AS DateTime), N'MNV01', N'NCC2', 0)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap], [TongTien]) VALUES (N'dâsd', CAST(N'2020-06-20T00:00:00.000' AS DateTime), N'2', N'NCC2', 0)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap], [TongTien]) VALUES (N'HD01', CAST(N'2019-11-11T00:00:00.000' AS DateTime), N'MNV01', N'MNCC01', 500)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap], [TongTien]) VALUES (N'HD02', CAST(N'2020-01-06T00:00:00.000' AS DateTime), N'MNV05', N'MNCC01', 0)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap], [TongTien]) VALUES (N'HD03', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'MNV03', N'NCC2', 0)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap], [TongTien]) VALUES (N'HD04', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'MNV03', N'MNCC01', 0)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap], [TongTien]) VALUES (N'HD05', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'MNV03', N'MNCC01', 0)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap], [TongTien]) VALUES (N'HD06', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'MNV03', N'NCC2', 0)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap], [TongTien]) VALUES (N'HD07', CAST(N'2020-09-20T00:00:00.000' AS DateTime), N'MNV01', N'NCC2', 0)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap], [TongTien]) VALUES (N'HD08', CAST(N'1999-02-15T00:00:00.000' AS DateTime), N'MNV01', N'NCC2', 0)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap], [TongTien]) VALUES (N'HD09', CAST(N'2020-06-30T00:00:00.000' AS DateTime), N'MNV01', N'NCC2', 1600)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap], [TongTien]) VALUES (N'sdf', CAST(N'2020-06-30T00:00:00.000' AS DateTime), N'2', N'NCC2', 0)
INSERT [dbo].[HoaDonNhap] ([MaHoaDonNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap], [TongTien]) VALUES (N'zxc', CAST(N'2020-06-30T00:00:00.000' AS DateTime), N'2', N'NCC2', 0)
INSERT [dbo].[Khach] ([MaKhach], [TenKhach], [DiaChi], [DienThoai]) VALUES (N'KH01', N'Minh Vũ', N'Nhà Nghèo Nhất Việt Nam', N'0386123369')
INSERT [dbo].[Khach] ([MaKhach], [TenKhach], [DiaChi], [DienThoai]) VALUES (N'KH02', N'Nhà Nghèo Học Dốt', N'Không Có', N'0394835311')
INSERT [dbo].[LoaiBan] ([MaLoaiBan], [TenLoaiBan]) VALUES (N'MLB01', N'2 chỗ ngồi')
INSERT [dbo].[LoaiBan] ([MaLoaiBan], [TenLoaiBan]) VALUES (N'MLB02', N'3 chỗ ngồi')
INSERT [dbo].[LoaiBan] ([MaLoaiBan], [TenLoaiBan]) VALUES (N'MLB03', N'4 chỗ ngồi')
INSERT [dbo].[LoaiBan] ([MaLoaiBan], [TenLoaiBan]) VALUES (N'MLB04', N'5 chỗ ngồi')
INSERT [dbo].[LoaiBan] ([MaLoaiBan], [TenLoaiBan]) VALUES (N'MLB05', N'6 chỗ ngồi')
INSERT [dbo].[LoaiMon] ([MaLoai], [TenLoai]) VALUES (N'ML01', N'Nướng')
INSERT [dbo].[LoaiMon] ([MaLoai], [TenLoai]) VALUES (N'ML02', N'Lẩu')
INSERT [dbo].[LoaiMon] ([MaLoai], [TenLoai]) VALUES (N'ML03', N'Hải Sản')
INSERT [dbo].[LoaiMon] ([MaLoai], [TenLoai]) VALUES (N'vxcv', N'xcvx')
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaCongDung], [MaLoai], [CachLam], [YeuCau], [DonGia]) VALUES (N'MMA01', N'Thịt chó', N'MCD01', N'ML02', N'Lên gg search', N'Sạch Sẽ', NULL)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaCongDung], [MaLoai], [CachLam], [YeuCau], [DonGia]) VALUES (N'MMA02', N'Thịt Bò', N'MCD02', N'ML03', N'23423', N'5234', 200)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaCongDung], [MaLoai], [CachLam], [YeuCau], [DonGia]) VALUES (N'MMA03', N'Cơm Rang Dưa Bò', N'MCD03', N'ML01', N'google', N'Chín', 715)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaCongDung], [MaLoai], [CachLam], [YeuCau], [DonGia]) VALUES (N'MMA04', N'Phở Thìn', N'MCD02', N'ML03', N'fffss', N'fdsf', 0)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaCongDung], [MaLoai], [CachLam], [YeuCau], [DonGia]) VALUES (N'MMA05', N'Bún Chả', N'MCD02', N'ML03', N'Google', N'Ngon', 0)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [SoLuong], [DonGiaNhap], [DonGiaBan], [CongDung], [YeuCau], [ChongChiDinh]) VALUES (N'MNL01', N'1231', N'', 32, 10, 10, N'', N'', N'')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [DonViTinh], [SoLuong], [DonGiaNhap], [DonGiaBan], [CongDung], [YeuCau], [ChongChiDinh]) VALUES (N'MNL03', N'Tỏi', N'Kg', 0, 0, 0, N'', N'', N'')
INSERT [dbo].[NguyenLieu_MonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MMA01', N'MNL01', 8)
INSERT [dbo].[NguyenLieu_MonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MMA03', N'MNL01', 10)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai]) VALUES (N'MNCC01', N'Liên Minh Huyền Thoại', N'New York', N'0386123369')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai]) VALUES (N'NCC2', N'Công Ty Minh Vũ', N'Hà Nội', N'0394835311')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NgaySinh], [DiaChi], [MaQue], [DienThoai]) VALUES (N'2', N'12', N'Nữ', CAST(N'2020-12-06' AS Date), N'12312', N'MQ04', N'3123123   ')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NgaySinh], [DiaChi], [MaQue], [DienThoai]) VALUES (N'MNV01', N'123123123', N'Nữ', CAST(N'1999-09-04' AS Date), N'Đấu trường chân lý', N'MQ01', N'0386123369')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NgaySinh], [DiaChi], [MaQue], [DienThoai]) VALUES (N'MNV03', N'Nguyễn Văn Nam12', N'Nam', CAST(N'1999-02-05' AS Date), N'Hà Nội', N'MQ03', N'0215124123')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NgaySinh], [DiaChi], [MaQue], [DienThoai]) VALUES (N'MNV05', N'vũ quang minh', N'Nam', CAST(N'1999-04-09' AS Date), N'12312', N'MQ01', N'2312      ')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NgaySinh], [DiaChi], [MaQue], [DienThoai]) VALUES (N'uer', N'erwe', N'Nữ', CAST(N'2020-06-30' AS Date), N'e', N'MQ03', N'rue       ')
INSERT [dbo].[p] ([Nam], [TongTien]) VALUES (2019, NULL)
INSERT [dbo].[p] ([Nam], [TongTien]) VALUES (2020, 3575)
INSERT [dbo].[PhieuDatBan] ([MaPhieu], [MaKhach], [MaNhanVien], [NgayDat], [NgayDung], [TongTien], [MaBan]) VALUES (N'PDB01', N'KH01', N'MNV01', CAST(N'2019-11-11' AS Date), CAST(N'2019-11-11' AS Date), 401083, NULL)
INSERT [dbo].[PhieuDatBan] ([MaPhieu], [MaKhach], [MaNhanVien], [NgayDat], [NgayDung], [TongTien], [MaBan]) VALUES (N'PDB02', N'KH01', N'MNV05', CAST(N'2020-03-06' AS Date), CAST(N'2020-04-06' AS Date), 4575, NULL)
INSERT [dbo].[Que] ([MaQue], [TenQue]) VALUES (N'MQ01', N'Nghệ An')
INSERT [dbo].[Que] ([MaQue], [TenQue]) VALUES (N'MQ02', N'hồ chí minh')
INSERT [dbo].[Que] ([MaQue], [TenQue]) VALUES (N'MQ03', N'Hà Nội')
INSERT [dbo].[Que] ([MaQue], [TenQue]) VALUES (N'MQ04', N'Hung Yên')
INSERT [dbo].[Que] ([MaQue], [TenQue]) VALUES (N'MQ05', N'Ba Vì')
INSERT [dbo].[Que] ([MaQue], [TenQue]) VALUES (N'MQ06', N'Đà Năng')
ALTER TABLE [dbo].[Ban]  WITH CHECK ADD  CONSTRAINT [FK_Ban_LoaiBan] FOREIGN KEY([MaLoaiBan])
REFERENCES [dbo].[LoaiBan] ([MaLoaiBan])
GO
ALTER TABLE [dbo].[Ban] CHECK CONSTRAINT [FK_Ban_LoaiBan]
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_HoaDonNhap] FOREIGN KEY([MaHoaDonNhap])
REFERENCES [dbo].[HoaDonNhap] ([MaHoaDonNhap])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhap_HoaDonNhap]
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_NguyenLieu] FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhap_NguyenLieu]
GO
ALTER TABLE [dbo].[ChiTietPhieuDB]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuDB_LoaiMon] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiMon] ([MaLoai])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuDB] CHECK CONSTRAINT [FK_ChiTietPhieuDB_LoaiMon]
GO
ALTER TABLE [dbo].[ChiTietPhieuDB]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuDB_MonAn] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MonAn] ([MaMonAn])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuDB] CHECK CONSTRAINT [FK_ChiTietPhieuDB_MonAn]
GO
ALTER TABLE [dbo].[ChiTietPhieuDB]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuDB_PhieuDatBan] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuDatBan] ([MaPhieu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuDB] CHECK CONSTRAINT [FK_ChiTietPhieuDB_PhieuDatBan]
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_MonAn_CongDung] FOREIGN KEY([MaCongDung])
REFERENCES [dbo].[CongDung] ([MaCongDung])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_MonAn_CongDung]
GO
ALTER TABLE [dbo].[NguyenLieu_MonAn]  WITH CHECK ADD  CONSTRAINT [FK_NguyenLieu_MonAn_MonAn] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MonAn] ([MaMonAn])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NguyenLieu_MonAn] CHECK CONSTRAINT [FK_NguyenLieu_MonAn_MonAn]
GO
ALTER TABLE [dbo].[NguyenLieu_MonAn]  WITH CHECK ADD  CONSTRAINT [FK_NguyenLieu_MonAn_NguyenLieu] FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NguyenLieu_MonAn] CHECK CONSTRAINT [FK_NguyenLieu_MonAn_NguyenLieu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Que] FOREIGN KEY([MaQue])
REFERENCES [dbo].[Que] ([MaQue])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_Que]
GO
ALTER TABLE [dbo].[PhieuDatBan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatBan_Ban] FOREIGN KEY([MaBan])
REFERENCES [dbo].[Ban] ([MaBan])
GO
ALTER TABLE [dbo].[PhieuDatBan] CHECK CONSTRAINT [FK_PhieuDatBan_Ban]
GO
ALTER TABLE [dbo].[PhieuDatBan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatBan_Khach] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[Khach] ([MaKhach])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuDatBan] CHECK CONSTRAINT [FK_PhieuDatBan_Khach]
GO
ALTER TABLE [dbo].[PhieuDatBan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatBan_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuDatBan] CHECK CONSTRAINT [FK_PhieuDatBan_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[DonGia]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--form món ăn: mã công dụng - mã loại là combobox, đơn giá không cho nhập
CREATE proc [dbo].[DonGia] @mamon varchar(50), @dongia float output
as
begin
	select @dongia=DonGia
	from MonAn
	where MaMonAn=@mamon
end
GO
/****** Object:  StoredProcedure [dbo].[RpMonAn]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[RpMonAn]
	@mama nvarchar(50)
	as
	begin
		select * from MonAn where MaMonAn = @mama
	end
GO
/****** Object:  StoredProcedure [dbo].[RpNam]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[RpNam] @nam int
	as
	begin
	select @nam as Nam, sum(TongTien) as ThanhTien
	from PhieuDatBan
	where YEAR(NgayDat) = @nam
	end
GO
/****** Object:  StoredProcedure [dbo].[RpPDB]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[RpPDB]
	@mapdb nvarchar(50)
	as
	begin
		select * from PhieuDatBan where MaPhieu = @mapdb
	end
GO
/****** Object:  StoredProcedure [dbo].[RpQuy]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[RpQuy] @quy nvarchar(50),@thang_1st int, @thang_2nd int,@thang_3rd int, @nam int
	as
	begin
		select  @quy as Quy ,@nam as Nam , sum(PhieuDatBan.TongTien) as TongTien
		from PhieuDatBan
		where (MONTH(NgayDat) =@thang_1st or MONTH(NgayDat) =@thang_2nd or MONTH(NgayDat) =@thang_3rd)  and YEAR(NgayDat) = @nam
		group by year(NgayDat)
	end
GO
/****** Object:  StoredProcedure [dbo].[RpThang]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[RpThang] @thang int, @nam int
as
begin
	select @thang as thang, @nam as Nam , sum((SoLuong*MonAn.DonGia) - GiamGia) as ThanhTien
	from PhieuDatBan, ChiTietPhieuDB, MonAn
	where PhieuDatBan.MaPhieu = ChiTietPhieuDB.MaPhieu and ChiTietPhieuDB.MaMonAn = MonAn.MaMonAn and MONTH(NgayDat) = @thang and YEAR(NgayDat) = @nam
	group by MONTH(NgayDat)
end
GO
/****** Object:  StoredProcedure [dbo].[SoLuong]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SoLuong] @manl varchar(50), @sl float output, @gianhap float output, @giaban float output
as
begin
	select @sl=SoLuong, @gianhap=DonGiaNhap, @giaban=DonGiaBan
	from NguyenLieu
	where MaNguyenLieu=@manl
end
GO
/****** Object:  StoredProcedure [dbo].[ThanhTien]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThanhTien] @maphieu varchar(50), @mamon varchar(50), @tien float output
as
begin
	declare @sl float, @giamgia float, @dongia float
	select @sl=SoLuong, @giamgia=GiamGia
	from ChiTietPhieuDB
	where MaPhieu=@maphieu and MaMonAn=@mamon
	select @dongia=DonGia
	from MonAn
	where MaMonAn=@mamon
	set @tien=@sl*@dongia-(@giamgia/100)*@sl*@dongia
end
GO
/****** Object:  StoredProcedure [dbo].[ThanhTienHD]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThanhTienHD] @mahdn varchar(50), @manl varchar(50), @tien float output
as
begin
	declare @sl float, @khuyenmai float, @dongia float
	select @sl=SoLuong, @khuyenmai=KhuyenMai, @dongia=DonGia
	from ChiTietHoaDonNhap
	where MaHoaDonNhap=@mahdn and MaNguyenLieu=@manl
	set @tien=@sl*@dongia-(@khuyenmai/100)*@sl*@dongia
end
GO
/****** Object:  StoredProcedure [dbo].[TongtienHDN]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TongtienHDN] @mahdn varchar(50), @tongtien float output
as
begin	
	select @tongtien=sum(ThanhTien)
	from ChiTietHoaDonNhap
	where MaHoaDonNhap=@mahdn
end
GO
/****** Object:  StoredProcedure [dbo].[TongtienPDB]    Script Date: 07/07/2020 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TongtienPDB] @maphieu varchar(50), @tongtien float output
as
begin	
	select @tongtien=sum(ThanhTien)
	from ChiTietPhieuDB
	where MaPhieu=@maphieu
end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "HoaDonNhap"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 217
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ChiTietHoaDonNhap"
            Begin Extent = 
               Top = 6
               Left = 255
               Bottom = 136
               Right = 434
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NguyenLieu"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'BaoCaoNhapNL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'BaoCaoNhapNL'
GO
USE [master]
GO
ALTER DATABASE [QLNhaHang] SET  READ_WRITE 
GO
