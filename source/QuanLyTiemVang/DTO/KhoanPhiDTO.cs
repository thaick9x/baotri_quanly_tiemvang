using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class KhoanPhiDTO
    {
        private uint m_MaKhoanPhi;
        public uint MaKhoanPhi
        {
            get { return m_MaKhoanPhi; }
            set { m_MaKhoanPhi = value; }
        }
        private string m_TenKhoanPhi;
        public string TenKhoanPhi
        {
            get { return m_TenKhoanPhi; }
            set { m_TenKhoanPhi = value; }
        }
    }
}
