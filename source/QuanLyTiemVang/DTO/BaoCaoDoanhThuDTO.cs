using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class BaoCaoDoanhThuDTO
    {
        private DateTime m_NgayBaoCao;
        public DateTime NgayBaoCao
        {
            get { return m_NgayBaoCao; }
            set { m_NgayBaoCao = value; }
        }
        private int m_MaDanhSachKhoanThu;
        public int MaDanhSachKhoanThu
        {
            get { return m_MaDanhSachKhoanThu; }
            set { m_MaDanhSachKhoanThu = value; }
        }
        private int m_MaDanhSachKhoanChi;
        public int MaDanhSachKhoanChi
        {
            get { return m_MaDanhSachKhoanChi; }
            set { m_MaDanhSachKhoanChi = value; }
        }
        private long m_TonQuyBanDau;
        public long TonQuyBanDau
        {
            get { return m_TonQuyBanDau; }
            set { m_TonQuyBanDau = value; }
        }
        private long m_TonQuyConLai;
        public long TonQuyConLai
        {
            get { return m_TonQuyConLai; }
            set { m_TonQuyConLai = value; }
        }
    }
}
