using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;
using QuanLyTiemVang.BUS;

namespace QuanLyTiemVang.BUS
{
    class TaiKhoanBUS
    {
        public static bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            TaiKhoanDAO.Insert(tk);
            return true;
        }
    }
}
