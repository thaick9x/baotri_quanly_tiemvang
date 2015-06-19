using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;

namespace QuanLyTiemVang.BUS
{
    class ThoGiaCongBUS
    {
        public static bool ThemThoGiaCong(ThoGiaCongDTO tgc)
        {
            ThoGiaCongDAO.Insert(tgc);
            return true;
        }
        public static bool XoaThoGiaCong(ThoGiaCongDTO tgc)
        {
            ThoGiaCongDAO.Delete(tgc);
            return true;
        }
        public static bool CapNhatThoGiaCong(ThoGiaCongDTO tgc)
        {
            ThoGiaCongDAO.Update(tgc);
            return true;
        }
    }
}
