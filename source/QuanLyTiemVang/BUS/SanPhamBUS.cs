using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;

namespace QuanLyTiemVang.BUS
{
    class SanPhamBUS
    {
        public static bool ThemSanPham(SanPhamDTO sp)
        {
            SanPhamDAO.Insert(sp);
            return true;
        }

        public static bool XoaSanPham(SanPhamDTO sp)
        {
            SanPhamDAO.TempDelete(sp);
            return true;
        }
        public static bool CapNhatSanPham(SanPhamDTO sp)
        {
            SanPhamDAO.Update(sp);
            return true;
        }
    }
}
