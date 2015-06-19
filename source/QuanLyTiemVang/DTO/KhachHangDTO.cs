using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class KhachHangDTO
    {
        private uint m_MaKhachHang;
        public uint MaKhachHang
        {
            get { return m_MaKhachHang; }
            set { m_MaKhachHang = value; }
        }
        private string m_TenKhachHang;
        public string TenKhachHang
        {
            get { return m_TenKhachHang; }
            set { m_TenKhachHang = value; }
        }
        private string m_LoaiKhachHang;
        public string LoaiKhachHang
        {
            get { return m_LoaiKhachHang; }
            set { m_LoaiKhachHang = value; }
        }
        private string m_DiaChi;
        public string DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }
        private uint m_TienNoHienTai;
        public uint TienNoHienTai
        {
            get { return m_TienNoHienTai; }
            set { m_TienNoHienTai = value; }
        }
    }
}
