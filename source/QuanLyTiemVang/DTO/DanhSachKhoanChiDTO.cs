using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class DanhSachKhoanChiDTO
    {
        private DateTime m_NgayChi;
        public DateTime NgayChi
        {
            get { return m_NgayChi; }
            set { m_NgayChi = value; }
        }
        private long m_TienChiPhieuMuaHang;
        public long TienChiPhieuMuaHang
        {
            get { return m_TienChiPhieuMuaHang; }
            set { m_TienChiPhieuMuaHang = value; }
        }
        private long m_TienChiPhieuHangGiaCong;
        public long TienChiPhieuHangGiaCong
        {
            get { return m_TienChiPhieuHangGiaCong; }
            set { m_TienChiPhieuHangGiaCong = value; }
        }
        private long m_TienChiPhieuChi;
        public long TienChiPhieuChi
        {
            get { return m_TienChiPhieuChi; }
            set { m_TienChiPhieuChi = value; }
        }
        private long m_TongTienChi;
        public long TongTienChi
        {
            get { return m_TongTienChi; }
            set { m_TongTienChi = value; }
        }
    }
}
