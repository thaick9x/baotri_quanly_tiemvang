using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class ChiTietPhieuHangGiaCongDTO
    {
        private uint m_MaChiTietPhieuHangGiaCong;
        public uint MaChiTietPhieuHangGiaCong
        {
            get { return m_MaChiTietPhieuHangGiaCong; }
            set { m_MaChiTietPhieuHangGiaCong = value; }
        }
        private uint m_MaPhieuHangGiaCong;
        public uint MaPhieuHangGiaCong
        {
            get { return m_MaPhieuHangGiaCong; }
            set { m_MaPhieuHangGiaCong = value; }
        }
        private uint m_MaHangGiaCong;
        public uint MaHangGiaCong
        {
            get { return m_MaHangGiaCong; }
            set { m_MaHangGiaCong = value; }
        }
        private uint m_SoLuong;
        public uint SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        }
        private uint m_ThanhTien;
        public uint ThanhTien
        {
            get { return m_ThanhTien; }
            set { m_ThanhTien = value; }
        }
    }
}
