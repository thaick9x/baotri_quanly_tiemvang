using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class PhieuDichVuDTO
    {
        private uint m_MaPhieuDichVu;
        public uint MaPhieuDichVu
        {
            get { return m_MaPhieuDichVu; }
            set { m_MaPhieuDichVu = value; }
        }
        private uint m_MaKhachHang;
        public uint MaKhachHang
        {
            get { return m_MaKhachHang; }
            set { m_MaKhachHang = value; }
        }
        private DateTime m_NgayDangKy;
        public DateTime NgayDangKy
        {
            get { return m_NgayDangKy; }
            set { m_NgayDangKy = value; }
        }
        private DateTime m_NgayGiao;
        public DateTime NgayGiao
        {
            get { return m_NgayGiao; }
            set { m_NgayGiao = value; }
        }
        private uint m_TongCong;
        public uint TongCong
        {
            get { return m_TongCong; }
            set { m_TongCong = value; }
        }

        public DateTime NgayChi { get; set; }
    }
}
