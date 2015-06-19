using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;

namespace QuanLyTiemVang.BUS
{
    class DanhSachKhoanChiBUS
    {
        public static bool ThemDanhSachKhoanChi(DanhSachKhoanChiDTO dskc)
        {
            DanhSachKhoanChiDAO.Insert(dskc);
            return true;
        }
    }
}
