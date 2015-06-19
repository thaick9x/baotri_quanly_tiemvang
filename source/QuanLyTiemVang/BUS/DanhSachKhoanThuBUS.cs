using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;

namespace QuanLyTiemVang.BUS
{
    class DanhSachKhoanThuBUS
    {
        public static bool ThemDanhSachKhoanThu(DanhSachKhoanThuDTO dskt)
        {
            DanhSachKhoanThuDAO.Insert(dskt);
            return true;
        }
    }
}
