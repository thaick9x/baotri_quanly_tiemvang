using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;

namespace QuanLyTiemVang.BUS
{
    class PhieuNoBUS
    {
        public static bool ThemPhieuNo(PhieuNoDTO pn)
        {
            PhieuNoDAO.Insert(pn);
            return true;
        }
        public static bool XoaPhieuNo(PhieuNoDTO pn)
        {
            PhieuNoDAO.Delete(pn);
            return true;
        }
    }
}
