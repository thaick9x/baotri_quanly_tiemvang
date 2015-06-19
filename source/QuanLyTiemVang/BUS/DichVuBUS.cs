using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;

namespace QuanLyTiemVang.BUS
{
    class DichVuBUS
    {
        public static bool ThemDichVu(DichVuDTO dv)
        {
            DichVuDAO.Insert(dv);
            return true;
        }
        public static bool XoaDichVu(DichVuDTO dv)
        {
            DichVuDAO.Delete(dv);
            return true;
        }
        public static bool CapNhatDichVu(DichVuDTO dv)
        {
            DichVuDAO.Update(dv);
            return true;
        }
    }
}
