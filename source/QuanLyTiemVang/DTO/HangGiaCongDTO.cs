using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class HangGiaCongDTO
    {
        private uint m_MaHangGiaCong;
        public uint MaHangGiaCong
        {
            get { return m_MaHangGiaCong; }
            set { m_MaHangGiaCong = value; }
        }
        private string m_TenHangGiaCong;
        public string TenHangGiaCong
        {
            get { return m_TenHangGiaCong; }
            set { m_TenHangGiaCong = value; }
        }
        private uint m_DonGiaGiaCong;
        public uint DonGiaGiaCong
        {
            get { return m_DonGiaGiaCong; }
            set { m_DonGiaGiaCong = value; }
        }
    }
}
