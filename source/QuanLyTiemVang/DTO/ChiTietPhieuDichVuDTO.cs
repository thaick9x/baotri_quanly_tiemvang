using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class ChiTietPhieuDichVuDTO
    {
        private uint m_MaChiTietPhieuDichVu;
        public uint MaChiTietPhieuDichVu
        {
            get { return m_MaChiTietPhieuDichVu; }
            set { m_MaChiTietPhieuDichVu = value; }
        }
        private uint m_MaPhieuDichVu;
        public uint MaPhieuDichVu
        {
            get { return m_MaPhieuDichVu; }
            set { m_MaPhieuDichVu = value; }
        }
        private uint m_MaDichVu;
        public uint MaDichVu
        {
            get { return m_MaDichVu; }
            set { m_MaDichVu = value; }
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
