using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;

namespace QuanLyTiemVang.BUS
{
    class PhieuChiBUS
    {
        public static bool ThemPhieuChi(PhieuChiDTO pc)
        {
            PhieuChiDAO.Insert(pc);
            return true;
        }
        public static bool XoaPhieuChi(PhieuChiDTO pc)
        {
            PhieuChiDAO.Delete(pc);
            return true;
        }
    }
}
