using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;

namespace QuanLyTiemVang.BUS
{
    class ChiTietPhieuHangGiaCongBUS
    {
        public static bool ThemChiTietPhieuHangGiaCong(ChiTietPhieuHangGiaCongDTO ctphgc)
        {
            ChiTietPhieuHangGiaCongDAO.Insert(ctphgc);
            return true;
        }
        public static bool XoaChiTietPhieuHangGiaCong(ChiTietPhieuHangGiaCongDTO ctphgc)
        {
            ChiTietPhieuHangGiaCongDAO.Delete(ctphgc);
            return true;
        }
    }
}
