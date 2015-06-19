using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class TaiKhoanDTO
    {
        private string m_TenDangNhap;
        public string TenDangNhap
        {
            get { return m_TenDangNhap; }
            set { m_TenDangNhap = value; }
        }
        private string m_MatKhau;
        public string MatKhau
        {
            get { return m_MatKhau; }
            set { m_MatKhau = value; }
        }
        private string m_Email;
        public string Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }
    }
}
