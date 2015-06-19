using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DAO;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.BUS
{
    class ChiTietPhieuBanHangBUS
    {
        public static bool ThemChiTietPhieuBanHang(ChiTietPhieuBanHangDTO ctpbh)
        {
            ChiTietPhieuBanHangDAO.Insert(ctpbh);
            return true;
        }
        public static bool XoaChiTietPhieuBanHang(ChiTietPhieuBanHangDTO ctpbh)
        {
            ChiTietPhieuBanHangDAO.Delete(ctpbh);
            return true;
        }
    }
}
