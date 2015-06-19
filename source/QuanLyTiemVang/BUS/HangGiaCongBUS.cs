using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;
using QuanLyTiemVang.BUS;

namespace QuanLyTiemVang.BUS
{
    class HangGiaCongBUS
    {
        public static bool ThemHangGiaCong(HangGiaCongDTO hgc)
        {
            HangGiaCongDAO.Insert(hgc);
            return true;
        }
        public static bool XoaHangGiaCong(HangGiaCongDTO hgc)
        {
            HangGiaCongDAO.Delete(hgc);
            return true;
        }
        public static bool CapNhatHangGiaCong(HangGiaCongDTO hgc)
        {
            HangGiaCongDAO.Update(hgc);
            return true;
        }
    }
}
