using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;

namespace QuanLyTiemVang.BUS
{
    class ChiTietPhieuChiBUS
    {
        public static bool ThemChiTietPhieuChi(ChiTietPhieuChiDTO ctpc)
        {
            ChiTietPhieuChiDAO.Insert(ctpc);
            return true;
        }
        public static bool XoaChiTietPhieuChi(ChiTietPhieuChiDTO ctpc)
        {
            ChiTietPhieuChiDAO.Delete(ctpc);
            return true;
        }
    }
}
