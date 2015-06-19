using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class SanPhamDTO
    {
        private uint m_MaSanPham;
        public uint MaSanPham
        {
            get { return m_MaSanPham; }
            set { m_MaSanPham = value; }
        }
        private string m_TenSanPham;
        public string TenSanPham
        {
            get { return m_TenSanPham; }
            set { m_TenSanPham = value; }
        }
        private string m_LoaiSanPham;
        public string LoaiSanPham
        {
            get { return m_LoaiSanPham; }
            set { m_LoaiSanPham = value; }
        }
        private uint m_SoLuongTon;
        public uint SoLuongTon
        {
            get { return m_SoLuongTon; }
            set { m_SoLuongTon = value; }
        }
    }
}
