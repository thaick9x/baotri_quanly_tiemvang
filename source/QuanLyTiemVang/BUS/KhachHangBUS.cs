using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DAO;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.BUS
{
    class KhachHangBUS
    {
        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            KhachHangDAO.Insert(kh);
            return true;
        }
        public static bool XoaKhachHang(KhachHangDTO kh)
        {
            KhachHangDAO.Delete(kh);
            return true;
        }
        public static bool CapNhatKhachHang(KhachHangDTO kh)
        {
            KhachHangDAO.Update(kh);
            return true;
        }
    }
}
