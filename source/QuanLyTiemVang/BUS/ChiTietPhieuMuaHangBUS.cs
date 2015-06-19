using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;

namespace QuanLyTiemVang.BUS
{
    class ChiTietPhieuMuaHangBUS
    {
        public static bool ThemChiTietPhieuMuaHang(ChiTietPhieuMuaHangDTO ctpmh)
        {
            ChiTietPhieuMuaHangDAO.Insert(ctpmh);
            return true;
        }
        public static bool XoaChiTietPhieuMuaHang(ChiTietPhieuMuaHangDTO ctpmh)
        {
            ChiTietPhieuMuaHangDAO.Delete(ctpmh);
            return true;
        }
    }
}
