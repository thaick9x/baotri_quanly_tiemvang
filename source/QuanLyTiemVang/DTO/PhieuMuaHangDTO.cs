using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class PhieuMuaHangDTO
    {
        private uint m_MaPhieuMuaHang;
        public uint MaPhieuMuaHang
        {
            get { return m_MaPhieuMuaHang; }
            set { m_MaPhieuMuaHang = value; }
        }
        private uint m_MaKhachHang;
        public uint MaKhachHang
        {
            get { return m_MaKhachHang; }
            set { m_MaKhachHang = value; }
        }
        private DateTime m_NgayMua;
        public DateTime NgayMua
        {
            get { return m_NgayMua; }
            set { m_NgayMua = value; }
        }
        private DateTime m_NgayThanhToan;
        public DateTime NgayThanhToan
        {
            get { return m_NgayThanhToan; }
            set { m_NgayThanhToan = value; }
        }
        private uint m_TongCong;
        public uint TongCong
        {
            get { return m_TongCong; }
            set { m_TongCong = value; }
        }
    }
}
