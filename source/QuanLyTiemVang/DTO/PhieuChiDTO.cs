using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class PhieuChiDTO
    {
        private uint m_MaPhieuChi;
        public uint MaPhieuChi
        {
            get { return m_MaPhieuChi; }
            set { m_MaPhieuChi = value; }
        }
        private DateTime m_NgayChi;
        public DateTime NgayChi
        {
            get { return m_NgayChi; }
            set { m_NgayChi = value; }
        }
        private uint m_TongCong;
        public uint TongCong
        {
            get { return m_TongCong; }
            set { m_TongCong = value; }
        }
    }
}
