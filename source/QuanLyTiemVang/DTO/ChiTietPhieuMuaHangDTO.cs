using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class ChiTietPhieuMuaHangDTO
    {
        private uint m_MaChiTietPhieuMuaHang;
        public uint MaChiTietPhieuMuaHang
        {
            get { return m_MaChiTietPhieuMuaHang; }
            set { m_MaChiTietPhieuMuaHang = value; }
        }
        private uint m_MaPhieuMuaHang;
        public uint MaPhieuMuaHang
        {
            get { return m_MaPhieuMuaHang; }
            set { m_MaPhieuMuaHang = value; }
        }
        private uint m_MaSanPham;
        public uint MaSanPham
        {
            get { return m_MaSanPham; }
            set { m_MaSanPham = value; }
        }
        private uint m_SoLuongMua;
        public uint SoLuongMua
        {
            get { return m_SoLuongMua; }
            set { m_SoLuongMua = value; }
        }
        private uint m_DonGiaMua;
        public uint DonGiaMua
        {
            get { return m_DonGiaMua; }
            set { m_DonGiaMua = value; }
        }
        private uint m_ThanhTien;
        public uint ThanhTien
        {
            get { return m_ThanhTien; }
            set { m_ThanhTien = value; }
        }
    }
}
