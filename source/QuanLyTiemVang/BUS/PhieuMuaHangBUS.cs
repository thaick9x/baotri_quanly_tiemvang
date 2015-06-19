using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DAO;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.BUS
{
    class PhieuMuaHangBUS
    {
        public static bool ThemPhieuMuaHang(PhieuMuaHangDTO pmh)
        {
            PhieuMuaHangDAO.Insert(pmh);
            return true;
        }
        public static bool XoaPhieuMuaHang(PhieuMuaHangDTO pmh)
        {
            PhieuMuaHangDAO.Delete(pmh);
            return true;
        }
    }
}
