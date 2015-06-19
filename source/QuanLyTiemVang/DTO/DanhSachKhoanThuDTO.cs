using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DTO
{
    class DanhSachKhoanThuDTO
    {
        private uint m_MaDanhSachKhoanThu;
        public uint MaDanhSachKhoanThu
        {
            get { return m_MaDanhSachKhoanThu; }
            set { m_MaDanhSachKhoanThu = value; }
        }
        private DateTime m_NgayThu;
        public DateTime NgayThu
        {
            get { return m_NgayThu; }
            set { m_NgayThu = value; }
        }
        private long m_TienThuPhieuBanHang;
        public long TienThuPhieuBanHang
        {
            get { return m_TienThuPhieuBanHang; }
            set { m_TienThuPhieuBanHang = value; }
        }
        private long m_TienThuPhieuDichVu;
        public long TienThuPhieuDichVu
        {
            get { return m_TienThuPhieuDichVu; }
            set { m_TienThuPhieuDichVu = value; }
        }
        private long m_TongTienThu;
        public long TongTienThu
        {
            get { return m_TongTienThu; }
            set { m_TongTienThu = value; }
        }
    }
}
