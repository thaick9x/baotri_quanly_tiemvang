using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class ChiTietPhieuBanHangDTO
    {
        private uint m_MaChiTietPhieuBanHang;
        public uint MaChiTietPhieuBanHang
        {
            get { return m_MaChiTietPhieuBanHang; }
            set { m_MaChiTietPhieuBanHang = value; }
        }
        private uint m_MaPhieuBanHang;
        public uint MaPhieuBanHang
        {
            get { return m_MaPhieuBanHang; }
            set { m_MaPhieuBanHang = value; }
        }
        private uint m_MaSanPham;
        public uint MaSanPham
        {
            get { return m_MaSanPham; }
            set { m_MaSanPham = value; }
        }
        private uint m_SoLuongBan;
        public uint SoLuongBan
        {
            get { return m_SoLuongBan; }
            set { m_SoLuongBan = value; }
        }
        private uint m_DonGiaBan;
        public uint DonGiaBan
        {
            get { return m_DonGiaBan; }
            set { m_DonGiaBan = value; }
        }
        private uint m_ThanhTien;
        public uint ThanhTien
        {
            get { return m_ThanhTien; }
            set { m_ThanhTien = value; }
        }
    }
}
