using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class DichVuDTO
    {
        private uint m_MaDichVu;
        public uint MaDichVu
        {
            get { return m_MaDichVu; }
            set { m_MaDichVu = value; }
        }
        private string m_TenDichVu;
        public string TenDichVu
        {
            get { return m_TenDichVu; }
            set { m_TenDichVu = value; }
        }
        private uint m_DonGiaDichVu;
        public uint DonGiaDichVu
        {
            get { return m_DonGiaDichVu; }
            set { m_DonGiaDichVu = value; }
        }
    }
}
