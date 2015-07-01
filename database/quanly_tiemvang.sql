-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 01, 2015 at 09:59 AM
-- Server version: 5.6.24
-- PHP Version: 5.5.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `quanlytiemvang`
--

-- --------------------------------------------------------

--
-- Table structure for table `baocaocongno`
--

CREATE TABLE IF NOT EXISTS `baocaocongno` (
  `MaBaoCao` int(11) DEFAULT NULL,
  `NgayBaoCao` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `baocaodoanhthu`
--

CREATE TABLE IF NOT EXISTS `baocaodoanhthu` (
  `MaBaoCaoDoanhThu` int(11) DEFAULT NULL,
  `NgayBaocao` date DEFAULT NULL,
  `MaDanhSachKhoanThu` int(11) DEFAULT NULL,
  `MaDanhSachKhoanChi` int(11) DEFAULT NULL,
  `TonQuyBanDau` int(11) DEFAULT NULL,
  `TonQuyConLai` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `baocaodoanhthu`
--

INSERT INTO `baocaodoanhthu` (`MaBaoCaoDoanhThu`, `NgayBaocao`, `MaDanhSachKhoanThu`, `MaDanhSachKhoanChi`, `TonQuyBanDau`, `TonQuyConLai`) VALUES
(1, '2013-06-11', 1, 1, 0, 0),
(2, '2013-06-13', 4, 2, 0, 890000),
(10, '2013-06-19', 12, 10, 890000, 1780000),
(11, '2013-07-01', 13, 11, 1780000, 5550000),
(12, '2013-06-15', 14, 12, 5550000, 10920000),
(13, '2013-06-15', 15, 13, 10920000, 16920000),
(14, '2013-06-15', 16, 14, 16290000, 21660000),
(15, '2013-05-08', 17, 15, 21660000, 27030000),
(16, '2013-02-10', 18, 16, 27030000, 3240000);

-- --------------------------------------------------------

--
-- Table structure for table `baocaoton`
--

CREATE TABLE IF NOT EXISTS `baocaoton` (
  `MaBaoCaoTon` int(11) DEFAULT NULL,
  `NgayBaoCao` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `baocaoton`
--

INSERT INTO `baocaoton` (`MaBaoCaoTon`, `NgayBaoCao`) VALUES
(1, '2013-07-02');

-- --------------------------------------------------------

--
-- Table structure for table `chitietbaocaocongno`
--

CREATE TABLE IF NOT EXISTS `chitietbaocaocongno` (
  `MaChiTietBaoCaoCongNo` int(11) DEFAULT NULL,
  `MaBaoCaoCongNo` int(11) DEFAULT NULL,
  `MaKhachHang` int(11) DEFAULT NULL,
  `NoDau` int(11) DEFAULT NULL,
  `NoPhatSinh` int(11) DEFAULT NULL,
  `NoCuoi` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `chitietbaocaoton`
--

CREATE TABLE IF NOT EXISTS `chitietbaocaoton` (
  `MaChiTietBaoCaoTon` int(11) DEFAULT NULL,
  `MaSanPham` int(11) DEFAULT NULL,
  `MaBaoCaoTon` int(11) DEFAULT NULL,
  `TonDauKy` int(11) DEFAULT NULL,
  `SoLuongBan` int(11) DEFAULT NULL,
  `SoLuongMua` int(11) DEFAULT NULL,
  `TonCuoiKy` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `chitietbaocaoton`
--

INSERT INTO `chitietbaocaoton` (`MaChiTietBaoCaoTon`, `MaSanPham`, `MaBaoCaoTon`, `TonDauKy`, `SoLuongBan`, `SoLuongMua`, `TonCuoiKy`) VALUES
(1, 102, 1, 134, 5, 1, 133),
(2, 101, 2, 110, 4, 0, 110),
(3, 106, 1, 246, 0, 0, 246),
(4, 104, 1, 500, 0, 0, 500),
(5, 103, 1, 194, 0, 0, 194),
(6, 101, 1, 50, 0, 0, 50),
(7, 1077, 1, 398, 0, 0, 398),
(8, 105, 1, 391, 0, 0, 391),
(9, 105, 1, 300, 0, 0, 300),
(10, 102, 1, 600, 0, 0, 600),
(11, 105, 1, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `chitietphieubanhang`
--

CREATE TABLE IF NOT EXISTS `chitietphieubanhang` (
  `MaChiTietPhieuBanHang` int(11) DEFAULT NULL,
  `MaPhieuBanHang` int(11) DEFAULT NULL,
  `MaSanPham` int(11) DEFAULT NULL,
  `SoLuongBan` int(11) DEFAULT NULL,
  `DonGiaBan` int(11) DEFAULT NULL,
  `ThanhTien` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `chitietphieubanhang`
--

INSERT INTO `chitietphieubanhang` (`MaChiTietPhieuBanHang`, `MaPhieuBanHang`, `MaSanPham`, `SoLuongBan`, `DonGiaBan`, `ThanhTien`) VALUES
(1, 10, 102, 1, 5000, 5000),
(2, 1, 103, 2, 10000, 20000),
(3, 2, 101, 2, 5000, 10000),
(4, 3, 102, 2, 10000, 20000),
(5, 4, 103, 2, 10000, 20000),
(6, 5, 104, 4, 5, 6000),
(7, 6, 104, 4, 6000, 30000),
(8, 7, 101, 10, 200000, 2000000),
(9, 7, 1077, 2, 100000, 200000),
(10, 7, 101, 3, 200000, 600000),
(11, 6, 101, 2, 40000, 80000),
(12, 9, 102, 20, 100000, 2000000),
(13, 10, 103, 4, 100000, 400000),
(14, 10, 105, 6, 200000, 1200000);

-- --------------------------------------------------------

--
-- Table structure for table `chitietphieuchi`
--

CREATE TABLE IF NOT EXISTS `chitietphieuchi` (
  `MaChiTietPhieuChi` int(11) DEFAULT NULL,
  `MaPhieuChi` int(11) DEFAULT NULL,
  `MaKhoanPhi` int(11) DEFAULT NULL,
  `ThanhTien` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `chitietphieuchi`
--

INSERT INTO `chitietphieuchi` (`MaChiTietPhieuChi`, `MaPhieuChi`, `MaKhoanPhi`, `ThanhTien`) VALUES
(1, 1, 2, 400000);

-- --------------------------------------------------------

--
-- Table structure for table `chitietphieudichvu`
--

CREATE TABLE IF NOT EXISTS `chitietphieudichvu` (
  `MaChiTietPhieuDichVu` int(11) DEFAULT NULL,
  `MaPhieuDichVu` int(11) DEFAULT NULL,
  `MaDichVu` int(11) DEFAULT NULL,
  `SoLuong` int(11) DEFAULT NULL,
  `ThanhTien` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `chitietphieudichvu`
--

INSERT INTO `chitietphieudichvu` (`MaChiTietPhieuDichVu`, `MaPhieuDichVu`, `MaDichVu`, `SoLuong`, `ThanhTien`) VALUES
(1, 1, 1, 2, 20000),
(2, 1, 2, 3, 150000),
(3, 2, 2, 4, 200000),
(4, 3, 1, 4, 40000);

-- --------------------------------------------------------

--
-- Table structure for table `chitietphieuhanggiacong`
--

CREATE TABLE IF NOT EXISTS `chitietphieuhanggiacong` (
  `MaChiTietPhieuHangGiaCong` int(11) DEFAULT NULL,
  `MaPhieuHangGiaCong` int(11) DEFAULT NULL,
  `MaHangGiaCong` int(11) DEFAULT NULL,
  `SoLuong` int(11) DEFAULT NULL,
  `ThanhTien` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `chitietphieuhanggiacong`
--

INSERT INTO `chitietphieuhanggiacong` (`MaChiTietPhieuHangGiaCong`, `MaPhieuHangGiaCong`, `MaHangGiaCong`, `SoLuong`, `ThanhTien`) VALUES
(1, 1, 2, 2, 1400000),
(2, 1, 1, 3, 1500000);

-- --------------------------------------------------------

--
-- Table structure for table `chitietphieumuahang`
--

CREATE TABLE IF NOT EXISTS `chitietphieumuahang` (
  `MaChiTietPhieuMuaHang` int(11) DEFAULT NULL,
  `MaPhieuMuaHang` int(11) DEFAULT NULL,
  `MaSanPham` int(11) DEFAULT NULL,
  `SoLuongMua` int(11) DEFAULT NULL,
  `DonGiaMua` int(11) DEFAULT NULL,
  `ThanhTien` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `chitietphieumuahang`
--

INSERT INTO `chitietphieumuahang` (`MaChiTietPhieuMuaHang`, `MaPhieuMuaHang`, `MaSanPham`, `SoLuongMua`, `DonGiaMua`, `ThanhTien`) VALUES
(1, 4, 101, 1, 1000000, 2000000);

-- --------------------------------------------------------

--
-- Table structure for table `danhsachkhoanchi`
--

CREATE TABLE IF NOT EXISTS `danhsachkhoanchi` (
  `MaDanhSachKhoanChi` int(11) DEFAULT NULL,
  `NgayChi` date DEFAULT NULL,
  `TienChiPhieuMuaHang` int(11) DEFAULT NULL,
  `TienChiPhieuHangGiaCong` int(11) DEFAULT NULL,
  `TienChiPhieuChi` int(11) DEFAULT NULL,
  `TongTienChi` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `danhsachkhoanchi`
--

INSERT INTO `danhsachkhoanchi` (`MaDanhSachKhoanChi`, `NgayChi`, `TienChiPhieuMuaHang`, `TienChiPhieuHangGiaCong`, `TienChiPhieuChi`, `TongTienChi`) VALUES
(1, '2013-06-11', 0, 0, 0, 0),
(2, '2013-06-13', 10250000, 2900000, 400000, 13550000),
(3, '2013-06-13', 10250000, 2900000, 400000, 13550000),
(4, '2013-06-13', 10250000, 2900000, 400000, 13550000),
(5, '2013-06-13', 10250000, 2900000, 400000, 13550000),
(6, '2013-06-13', 10250000, 2900000, 400000, 13550000),
(7, '2013-06-13', 10250000, 2900000, 400000, 13550000),
(8, '2013-06-13', 10250000, 2900000, 400000, 13550000),
(9, '2013-06-18', 10250000, 2900000, 400000, 13550000),
(10, '2013-06-19', 10250000, 2900000, 400000, 13550000),
(11, '2013-06-19', 10250000, 2900000, 400000, 13550000),
(12, '2013-07-01', 10250000, 2900000, 400000, 13550000),
(13, '2013-06-15', 10250000, 2900000, 400000, 13550000),
(14, '2013-06-15', 10250000, 2900000, 400000, 13550000),
(15, '2013-06-15', 10250000, 2900000, 400000, 13550000),
(16, '2013-05-08', 10250000, 2900000, 400000, 13550000),
(17, '2013-02-10', 10250000, 2900000, 400000, 13550000);

-- --------------------------------------------------------

--
-- Table structure for table `danhsachkhoanthu`
--

CREATE TABLE IF NOT EXISTS `danhsachkhoanthu` (
  `MaDanhSachKhoanThu` int(11) DEFAULT NULL,
  `NgayThu` date DEFAULT NULL,
  `TienThuPhieuBanHang` int(11) DEFAULT NULL,
  `TienThuPhieuDichVu` int(11) DEFAULT NULL,
  `TongTienThu` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `danhsachkhoanthu`
--

INSERT INTO `danhsachkhoanthu` (`MaDanhSachKhoanThu`, `NgayThu`, `TienThuPhieuBanHang`, `TienThuPhieuDichVu`, `TongTienThu`) VALUES
(1, '2013-06-11', 0, 0, 0),
(2, '2013-06-13', 14030000, 410000, 14440000),
(3, '2013-06-13', 14030000, 410000, 14440000),
(4, '2013-06-13', 14030000, 410000, 14440000),
(5, '2013-06-13', 14030000, 410000, 14440000),
(6, '2013-06-13', 14030000, 410000, 14440000),
(7, '2013-06-13', 14030000, 410000, 14440000),
(8, '2013-06-13', 14030000, 410000, 14440000),
(9, '2013-06-13', 14030000, 410000, 14440000),
(10, '2013-06-13', 14030000, 410000, 14440000),
(11, '2013-06-13', 14030000, 410000, 14440000),
(12, '2013-06-18', 14030000, 410000, 14440000),
(13, '2013-06-19', 14030000, 410000, 14440000),
(14, '2013-07-01', 16910000, 410000, 17320000),
(15, '2013-06-15', 18510000, 410000, 18920000),
(16, '2013-06-15', 18510000, 410000, 18920000),
(17, '2013-05-08', 18510000, 410000, 18920000),
(18, '2013-02-10', 18510000, 410000, 18920000);

-- --------------------------------------------------------

--
-- Table structure for table `dichvu`
--

CREATE TABLE IF NOT EXISTS `dichvu` (
  `MaDichVu` int(11) DEFAULT NULL,
  `TenDichVu` char(100) DEFAULT NULL,
  `DonGiaDichVu` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `dichvu`
--

INSERT INTO `dichvu` (`MaDichVu`, `TenDichVu`, `DonGiaDichVu`) VALUES
(1, 'Gia công nữ trang', 10000),
(2, 'cân thử vàng', 50000);

-- --------------------------------------------------------

--
-- Table structure for table `hanggiacong`
--

CREATE TABLE IF NOT EXISTS `hanggiacong` (
  `MaHangGiaCong` int(11) DEFAULT NULL,
  `TenHangGiaCong` char(100) DEFAULT NULL,
  `DonGiaGiaCong` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `hanggiacong`
--

INSERT INTO `hanggiacong` (`MaHangGiaCong`, `TenHangGiaCong`, `DonGiaGiaCong`) VALUES
(1, 'Vàng', 5000000),
(2, 'Kim Cương', 700000);

-- --------------------------------------------------------

--
-- Table structure for table `khachhang`
--

CREATE TABLE IF NOT EXISTS `khachhang` (
  `MaKhachHang` int(11) DEFAULT NULL,
  `TenKhachHang` char(100) DEFAULT NULL,
  `LoaiKhachHang` char(50) DEFAULT NULL,
  `DiaChi` char(255) DEFAULT NULL,
  `TienNoHienTai` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `khachhang`
--

INSERT INTO `khachhang` (`MaKhachHang`, `TenKhachHang`, `LoaiKhachHang`, `DiaChi`, `TienNoHienTai`) VALUES
(1, 'Lê Tuấn', 'Khách quen', 'Sài Gòn', 14000),
(2, 'Lê Thu Thảo', 'Khách vãng lai', 'Tiền giang', 900),
(3, 'Trần Huy Hùng', 'Khách quen', 'Long an', 7000),
(4, 'Võ thị lựu', 'khách quen', 'Sài gòn', 0),
(5, 'Nguyễn phúc', 'khách vãng lại', 'Tiền giang', 30000),
(6, 'phạm thị hạnh', 'khách quen', ' Sai gòn', 15000),
(7, 'Nguyễn Kiều loan', 'khách vãng lai', 'Long n', 50000),
(8, 'Lê Thúy', 'Khách quen', 'Tây ninh', 25000),
(9, 'Lý Đức', 'khách vãng lai', 'bình Dương', 100000),
(10, 'Lý phúc', 'Khách vãng lai', 'long an', 0),
(11, 'Trần Hưng', 'khách quen', 'Tiền giang', 0),
(13, 'HKT', 'khách quen', 'sài gòn', 0);

-- --------------------------------------------------------

--
-- Table structure for table `khoanphi`
--

CREATE TABLE IF NOT EXISTS `khoanphi` (
  `MaKhoanPhi` int(11) DEFAULT NULL,
  `TenKhoanPhi` char(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `khoanphi`
--

INSERT INTO `khoanphi` (`MaKhoanPhi`, `TenKhoanPhi`) VALUES
(2, 'Tiền điện'),
(3, 'Tiền mặt bằng');

-- --------------------------------------------------------

--
-- Table structure for table `loaisanpham`
--

CREATE TABLE IF NOT EXISTS `loaisanpham` (
  `MaLoaiSanPham` int(11) DEFAULT NULL,
  `TenLoaiSanPham` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `loaisanpham`
--

INSERT INTO `loaisanpham` (`MaLoaiSanPham`, `TenLoaiSanPham`) VALUES
(1, 'Nữ trang'),
(2, 'Đá Quý'),
(3, 'Vàng');

-- --------------------------------------------------------

--
-- Table structure for table `phieubanhang`
--

CREATE TABLE IF NOT EXISTS `phieubanhang` (
  `MaPhieuBanHang` int(11) DEFAULT NULL,
  `MaDanhSachKhoanThu` int(11) DEFAULT NULL,
  `MaKhachHang` int(11) DEFAULT NULL,
  `NgayBan` date DEFAULT NULL,
  `NgayThanhToan` date DEFAULT NULL,
  `TongCong` int(11) DEFAULT NULL,
  `SoTienThanhToan` int(11) DEFAULT NULL,
  `SoTienNo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `phieubanhang`
--

INSERT INTO `phieubanhang` (`MaPhieuBanHang`, `MaDanhSachKhoanThu`, `MaKhachHang`, `NgayBan`, `NgayThanhToan`, `TongCong`, `SoTienThanhToan`, `SoTienNo`) VALUES
(2, 0, 1, '2013-05-09', '2013-05-09', 10000, 1000, 50000),
(3, 0, 1, '2013-05-09', '2013-05-09', 20000, 1000, 19000),
(5, 0, 3, '2013-06-12', '2013-06-12', 2000000, 1000000, 0),
(6, 0, 2, '2013-06-12', '2013-06-12', 12000000, 8000000, 4000000),
(7, 0, 3, '2013-06-22', '2013-06-22', 800000, 500000, 0),
(8, 0, 4, '2013-06-22', '2013-06-22', 80000, 60000, 10000),
(9, 0, 2, '2013-06-22', NULL, 2000000, 2000000, 0),
(10, 0, 4, '2013-07-01', '2013-07-01', 1600000, 1600000, 0);

-- --------------------------------------------------------

--
-- Table structure for table `phieuchi`
--

CREATE TABLE IF NOT EXISTS `phieuchi` (
  `MaPhieuChi` int(11) DEFAULT NULL,
  `MaDanhSachKhoanChi` int(11) DEFAULT NULL,
  `NgayChi` date DEFAULT NULL,
  `TongCong` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `phieuchi`
--

INSERT INTO `phieuchi` (`MaPhieuChi`, `MaDanhSachKhoanChi`, `NgayChi`, `TongCong`) VALUES
(1, 0, '2013-06-12', 490000);

-- --------------------------------------------------------

--
-- Table structure for table `phieudichvu`
--

CREATE TABLE IF NOT EXISTS `phieudichvu` (
  `MaPhieuDichVu` int(11) DEFAULT NULL,
  `MaDanhSachKhoanThu` int(11) DEFAULT NULL,
  `MaKhachHang` int(11) DEFAULT NULL,
  `NgayDangKy` date DEFAULT NULL,
  `NgayGiao` date DEFAULT NULL,
  `TongCong` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `phieudichvu`
--

INSERT INTO `phieudichvu` (`MaPhieuDichVu`, `MaDanhSachKhoanThu`, `MaKhachHang`, `NgayDangKy`, `NgayGiao`, `TongCong`) VALUES
(1, 0, 1, '2013-06-12', '2013-06-12', 170000),
(2, 0, 4, '2013-06-12', '2013-06-12', 200000),
(3, 0, 3, '2013-06-12', '2013-06-12', 4000000);

-- --------------------------------------------------------

--
-- Table structure for table `phieuhanggiacong`
--

CREATE TABLE IF NOT EXISTS `phieuhanggiacong` (
  `MaPhieuHangGiaCong` int(11) DEFAULT NULL,
  `MaDanhSachKhoanChi` int(11) DEFAULT NULL,
  `MaTho` int(11) DEFAULT NULL,
  `NgayGiaCong` date DEFAULT NULL,
  `NgayNhanHangGiaCong` date DEFAULT NULL,
  `TongCong` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `phieuhanggiacong`
--

INSERT INTO `phieuhanggiacong` (`MaPhieuHangGiaCong`, `MaDanhSachKhoanChi`, `MaTho`, `NgayGiaCong`, `NgayNhanHangGiaCong`, `TongCong`) VALUES
(1, 0, 0, '2013-06-12', '2013-06-12', 2900000);

-- --------------------------------------------------------

--
-- Table structure for table `phieumuahang`
--

CREATE TABLE IF NOT EXISTS `phieumuahang` (
  `MaPhieuMuaHang` int(11) DEFAULT NULL,
  `MaDanhSachKhoanChi` int(11) DEFAULT NULL,
  `MaKhachHang` int(11) DEFAULT NULL,
  `NgayMua` date DEFAULT NULL,
  `NgayThanhToan` date DEFAULT NULL,
  `TongCong` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `phieumuahang`
--

INSERT INTO `phieumuahang` (`MaPhieuMuaHang`, `MaDanhSachKhoanChi`, `MaKhachHang`, `NgayMua`, `NgayThanhToan`, `TongCong`) VALUES
(1, 0, 2, '2013-06-12', '2013-06-12', 450000),
(2, 0, 1, '2013-06-12', '2013-06-12', 1800000),
(3, 0, 2, '2013-06-12', '2013-06-12', 6000000),
(4, 0, 1, '2013-06-12', '2013-06-12', 2000000);

-- --------------------------------------------------------

--
-- Table structure for table `phieuno`
--

CREATE TABLE IF NOT EXISTS `phieuno` (
  `MaPhieuNo` int(11) DEFAULT NULL,
  `MaPhieuBanHang` int(11) DEFAULT NULL,
  `NgayNo` date DEFAULT NULL,
  `NgayTra` date DEFAULT NULL,
  `SoTienTra` int(11) DEFAULT NULL,
  `TienConLai` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `phieuno`
--

INSERT INTO `phieuno` (`MaPhieuNo`, `MaPhieuBanHang`, `NgayNo`, `NgayTra`, `SoTienTra`, `TienConLai`) VALUES
(1, 8, '2013-09-07', '2013-09-07', 10000, 10000),
(2, 7, '2013-01-07', '2013-01-07', 300000, 0),
(3, 5, '2013-01-07', '2013-01-07', 1900000, 0),
(4, 2, '2013-02-07', '2013-02-07', 194990, 51455);

-- --------------------------------------------------------

--
-- Table structure for table `sanpham`
--

CREATE TABLE IF NOT EXISTS `sanpham` (
  `MaSanPham` int(11) NOT NULL,
  `TenSanPham` char(100) DEFAULT NULL,
  `LoaiSanPham` char(100) DEFAULT NULL,
  `SoLuongTon` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `sanpham`
--

INSERT INTO `sanpham` (`MaSanPham`, `TenSanPham`, `LoaiSanPham`, `SoLuongTon`) VALUES
(101, 'Vàng 24K', 'Nhẫn', 104),
(103, 'Vàng 18K', 'Nữ trang', 379),
(102, 'Dây Chuyền', 'Nữ trang', 400),
(104, 'Vàng SJC', 'Vàng', 194),
(105, 'Đá Quý Cao Cấp', 'Đá quý', 145),
(106, 'Vàng 9999', 'Vàng', 321),
(1077, 'Bông Tai', 'Nữ trang', 314),
(108, 'Vòng đeo tay', 'Nữ trang', 244);

-- --------------------------------------------------------

--
-- Table structure for table `taikhoan`
--

CREATE TABLE IF NOT EXISTS `taikhoan` (
  `TenDangNhap` varchar(50) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `MatKhau` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `taikhoan`
--

INSERT INTO `taikhoan` (`TenDangNhap`, `Email`, `MatKhau`) VALUES
('admin', 'duong@gmail.com', 'admin'),
('admin2', 'theanh@gmail.com', 'admin2'),
('admin3', 'tuan@gmail.com', 'admin3'),
('admin1', 'tra@gmail.com', 'admin1'),
('giangnguyen', 'giangnt@gmail.com', '56781234');

-- --------------------------------------------------------

--
-- Table structure for table `thogiacong`
--

CREATE TABLE IF NOT EXISTS `thogiacong` (
  `MaTho` int(11) DEFAULT NULL,
  `TenTho` char(100) DEFAULT NULL,
  `DiaChi` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `thogiacong`
--

INSERT INTO `thogiacong` (`MaTho`, `TenTho`, `DiaChi`) VALUES
(NULL, NULL, NULL),
(NULL, NULL, NULL),
(5, 'Le Nhat Linh', '45 Nguyen Canh Chan, Q1, TpHCM'),
(1, 'Nguyen Van A', '731 Tran Hung Dao, Q5, TpHCM'),
(3, 'Nguyen Ngoc Linh', '45 Nguyen Canh Chan, Q1, TpHCM'),
(4, 'Nguyen Ngoc Long', '50/34 Le Dai Hanh, Q10, TpHCM'),
(5, 'Le Nhat Linh', '34 Truong Dinh, Q3, TpHCM'),
(6, 'Le Hoai Thuong', '227 Nguyen Van Cu, Q5, TpHCM'),
(7, 'Nguyen Van Tam', '32/3 Tran Binh Trong, Q5, TpHCM'),
(8, 'Phan Thi Thanh', '45/2 An Duong Vuong, Q5, TpHCM'),
(9, 'Le Ha Ving', '873 Le Hong Phong, Q5, TpHCM'),
(10, 'Ha huy Lap', '34/34B Nguyen Trai, Q1, TpHCM'),
(2, 'Nguyen Ngoc Han', '34/34B Nguyen Trai, Q1, TpHCM'),
(11, 'Nguyen Thi Tuat', '301 Tran Hung Dao, Q5, TpHCM');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
