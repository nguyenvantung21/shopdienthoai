USE [master]
GO
/****** Object:  Database [QLDienThoai]    Script Date: 4/23/2022 9:50:40 PM ******/
CREATE DATABASE [QLDienThoai]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDienThoai', FILENAME = N'D:\Programs file\SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLDienThoai.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLDienThoai_log', FILENAME = N'D:\Programs file\SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLDienThoai_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLDienThoai] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDienThoai].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDienThoai] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDienThoai] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDienThoai] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDienThoai] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDienThoai] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDienThoai] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLDienThoai] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDienThoai] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDienThoai] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDienThoai] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDienThoai] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDienThoai] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDienThoai] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDienThoai] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDienThoai] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLDienThoai] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDienThoai] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDienThoai] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDienThoai] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDienThoai] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDienThoai] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDienThoai] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDienThoai] SET RECOVERY FULL 
GO
ALTER DATABASE [QLDienThoai] SET  MULTI_USER 
GO
ALTER DATABASE [QLDienThoai] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDienThoai] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDienThoai] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDienThoai] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLDienThoai] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLDienThoai] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLDienThoai', N'ON'
GO
ALTER DATABASE [QLDienThoai] SET QUERY_STORE = OFF
GO
USE [QLDienThoai]
GO
/****** Object:  Table [dbo].[CHITIETDONHANG]    Script Date: 4/23/2022 9:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETDONHANG](
	[MaSanPham] [nvarchar](50) NOT NULL,
	[MaDon] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC,
	[MaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANHMUCSP]    Script Date: 4/23/2022 9:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUCSP](
	[MaDanhMuc] [nvarchar](50) NOT NULL,
	[TenDanhMuc] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONHANG]    Script Date: 4/23/2022 9:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONHANG](
	[MaDon] [nvarchar](50) NOT NULL,
	[NgayDat] [date] NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[MaKhachHang] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 4/23/2022 9:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKhachHang] [nvarchar](50) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[TaiKhoanKH] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 4/23/2022 9:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[TaiKhoanNV] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[NgaySinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 4/23/2022 9:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSanPham] [nvarchar](50) NOT NULL,
	[TenSanPham] [nvarchar](50) NULL,
	[Anh] [nvarchar](50) NULL,
	[MoTa] [nvarchar](50) NULL,
	[GiaTien] [money] NULL,
	[SoLuong] [int] NULL,
	[MaDanhMuc] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIETDONHANG]  WITH CHECK ADD FOREIGN KEY([MaDon])
REFERENCES [dbo].[DONHANG] ([MaDon])
GO
ALTER TABLE [dbo].[CHITIETDONHANG]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SANPHAM] ([MaSanPham])
GO
ALTER TABLE [dbo].[DONHANG]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[DONHANG]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD FOREIGN KEY([MaDanhMuc])
REFERENCES [dbo].[DANHMUCSP] ([MaDanhMuc])
GO
ALTER TABLE [dbo].[HOME]  WITH CHECK ADD FOREIGN KEY([MaDanhMuc])
REFERENCES [dbo].[DANHMUCSP] ([MaDanhMuc])
GO
USE [master]
GO
ALTER DATABASE [QLDienThoai] SET  READ_WRITE 
GO
