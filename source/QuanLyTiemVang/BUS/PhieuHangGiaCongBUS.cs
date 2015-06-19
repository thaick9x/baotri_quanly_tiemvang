using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;

namespace QuanLyTiemVang.BUS
{
    class PhieuHangGiaCongBUS
    {
        public static bool ThemPhieuHangGiaCong(PhieuHangGiaCongDTO phgc)
        {
            PhieuHangGiaCongDAO.Insert(phgc);
            return true;
        }
        public static bool XoaPhieuHangGiaCong(PhieuHangGiaCongDTO phgc)
        {
            PhieuHangGiaCongDAO.Delete(phgc);
            return true;
        }
    }
}
