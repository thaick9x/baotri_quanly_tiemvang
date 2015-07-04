using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class BaoCaoDoanhThuDAO
    {
        public static DataTable SelectAllBaoCaoDoanhThu()
        {
            string sql = "select * from BAOCAODOANHTHU";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(BaoCaoDoanhThuDTO bcdt)
        {
            string sql = "insert into BAOCAODOANHTHU (NgayBaoCao, MaDanhSachKhoanThu, MaDanhSachKhoanChi, TonQuyBanDau, TonQuyConLai) values ('" 
                + bcdt.NgayBaoCao.ToString("yyyy-MM-dd") + "', " + bcdt.MaDanhSachKhoanThu + ", " + bcdt.MaDanhSachKhoanChi + ", " + bcdt.TonQuyBanDau + ", " + bcdt.TonQuyConLai + ")";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
