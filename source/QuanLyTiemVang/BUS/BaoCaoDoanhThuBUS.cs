using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DAO;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.BUS
{
    class BaoCaoDoanhThuBUS
    {
        public static bool ThemBaoCaoDoanhThu(BaoCaoDoanhThuDTO bcdt)
        {
            BaoCaoDoanhThuDAO.Insert(bcdt);
            return true;
        }
    }
}
