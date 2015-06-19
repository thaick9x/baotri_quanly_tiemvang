using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;

namespace QuanLyTiemVang.BUS
{
    class PhieuDichVuBUS
    {
        public static bool ThemPhieuDichVu(PhieuDichVuDTO pdv)
        {
            PhieuDichVuDAO.Insert(pdv);
            return true;
        }
        public static bool XoaPhieuDichVu(PhieuDichVuDTO pdv)
        {
            PhieuDichVuDAO.Delete(pdv);
            return true;
        }
    }
}
