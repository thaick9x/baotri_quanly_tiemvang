using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class PhieuBanHangDTO
    {
        private uint m_MaPhieuBanHang;
        public uint MaPhieuBanHang
        {
            get { return m_MaPhieuBanHang; }
            set { m_MaPhieuBanHang = value; }
        }
        private uint m_MaKhachHang;
        public uint MaKhachHang
        {
            get { return m_MaKhachHang; }
            set { m_MaKhachHang = value; }
        }
        private DateTime m_NgayBan;
        public DateTime NgayBan
        {
            get { return m_NgayBan; }
            set { m_NgayBan = value; }
        }
        private DateTime m_NgayThanhToan;
        public DateTime NgayThanhToan
        {
            get { return m_NgayThanhToan.Date; }
            set { m_NgayThanhToan = value.Date; }
        }
        private uint m_TongCong;
        public uint TongCong
        {
            get { return m_TongCong; }
            set { m_TongCong = value; }
        }
        private uint m_SoTienThanhToan;
        public uint SoTienThanhToan
        {
            get { return m_SoTienThanhToan; }
            set { m_SoTienThanhToan = value; }
        }
        private uint m_SoTienNo;
        public uint SoTienNo
        {
            get { return m_SoTienNo; }
            set { m_SoTienNo = value; }
        }
    }
}
