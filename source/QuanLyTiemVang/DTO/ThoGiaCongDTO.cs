using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class ThoGiaCongDTO
    {
        private uint m_MaTho;
        public uint MaTho
        {
            get { return m_MaTho; }
            set { m_MaTho = value; }
        }
        private string m_TenTho;
        public string TenTho
        {
            get { return m_TenTho; }
            set { m_TenTho = value; }
        }
        private string m_DiaChi;
        public string DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }
    }
}
