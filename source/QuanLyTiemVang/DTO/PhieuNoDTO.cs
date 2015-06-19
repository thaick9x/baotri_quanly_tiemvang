using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
	class PhieuNoDTO
	{
	    private uint m_MaPhieuNo;
        public uint MaPhieuNo
        {
            get { return m_MaPhieuNo; }
            set { m_MaPhieuNo = value; }
        }
        private uint m_MaPhieuBanHang;
        public uint MaPhieuBanHang
        {
            get { return m_MaPhieuBanHang; }
            set { m_MaPhieuBanHang = value; }
        }
        private DateTime m_NgayNo;
        public DateTime NgayNo
        {
            get { return m_NgayNo; }
            set { m_NgayNo = value; }
        }
        private DateTime m_NgayTra;
        public DateTime NgayTra
        {
            get { return m_NgayTra; }
            set { m_NgayTra = value; }
        }
        private uint m_SoTienTra;
        public uint SoTienTra
        {
            get { return m_SoTienTra; }
            set { m_SoTienTra = value; }
        }
        private uint m_TienConLai;
        public uint TienConLai
        {
            get { return m_TienConLai; }
            set { m_TienConLai = value; }
        }
	}
}
