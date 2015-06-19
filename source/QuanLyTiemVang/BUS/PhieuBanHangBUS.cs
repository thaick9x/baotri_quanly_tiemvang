using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DAO;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.BUS
{
    class PhieuBanHangBUS
    {
        public static bool ThemPhieuBanHang(PhieuBanHangDTO pbh)
        {
            PhieuBanHangDAO.Insert(pbh);
            return true;
        }
        public static bool XoaPhieuBanHang(PhieuBanHangDTO pbh)
        {
            PhieuBanHangDAO.Delete(pbh);
            return true;
        }
    }
}
