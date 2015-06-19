using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class PhieuHangGiaCongDTO
    {
        private uint m_MaPhieuHangGiaCong;
        public uint MaPhieuHangGiaCong
        {
            get { return m_MaPhieuHangGiaCong; }
            set { m_MaPhieuHangGiaCong = value; }
        }
        private uint m_MaTho;
        public uint MaTho
        {
            get { return m_MaTho; }
            set { m_MaTho = value; }
        }
        private DateTime m_NgayGiaCong;
        public DateTime NgayGiaCong
        {
            get { return m_NgayGiaCong; }
            set { m_NgayGiaCong = value; }
        }
        private DateTime m_NgayNhanHangGiaCong;
        public DateTime NgayNhanHangGiaCong
        {
            get { return m_NgayNhanHangGiaCong; }
            set { m_NgayNhanHangGiaCong = value; }
        }
        private DateTime m_NgayThanhToan;
        public DateTime NgayThanhToan
        {
            get { return m_NgayThanhToan; }
            set { m_NgayThanhToan = value; }
        }
        private uint m_TongCong;
        public uint TongCong
        {
            get { return m_TongCong; }
            set { m_TongCong = value; }
        }
    }
}
