using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class ChiTietPhieuChiDTO
    {
        private uint m_MaChiTietPhieuChi;
        public uint MaChiTietPhieuChi
        {
            get { return m_MaChiTietPhieuChi; }
            set { m_MaChiTietPhieuChi = value; }
        }
        private uint m_MaPhieuChi;
        public uint MaPhieuChi
        {
            get { return m_MaPhieuChi; }
            set { m_MaPhieuChi = value; }
        }
        private uint m_MaKhoanPhi;
        public uint MaKhoanPhi
        {
            get { return m_MaKhoanPhi; }
            set { m_MaKhoanPhi = value; }
        }
        private uint m_ThanhTien;
        public uint ThanhTien
        {
            get { return m_ThanhTien; }
            set { m_ThanhTien = value; }
        }
    }
}
