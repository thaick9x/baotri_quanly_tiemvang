using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class ChiTietBaoCaoTonDAO
    {
        public static DataTable SelectAllChiTietBaoCaoTon()
        {
            string sql = "select MaSanPham, TonDauKy, SoLuongBan, SoLuongMua, TonCuoiKy from CHITIETBAOCAOTON";
            return DataBase.ExcuQuery(sql);
        }
    }
}
