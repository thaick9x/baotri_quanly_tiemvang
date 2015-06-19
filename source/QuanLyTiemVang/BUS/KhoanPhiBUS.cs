using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;

namespace QuanLyTiemVang.BUS
{
    class KhoanPhiBUS
    {
        public static bool ThemKhoanPhi(KhoanPhiDTO kp)
        {
            KhoanPhiDAO.Insert(kp);
            return true;
        }
        public static bool XoaKhoanPhi(KhoanPhiDTO kp)
        {
            KhoanPhiDAO.Delete(kp);
            return true;
        }
        public static bool CapNhatKhoanPhi(KhoanPhiDTO kp)
        {
            KhoanPhiDAO.Update(kp);
            return true;
        }
    }
}
