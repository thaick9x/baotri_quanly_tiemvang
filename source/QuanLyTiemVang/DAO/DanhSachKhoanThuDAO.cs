using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class DanhSachKhoanThuDAO
    {
        public static void Insert(DanhSachKhoanThuDTO dskt)
        {
            string sql = "insert into DANHSACHKHOANTHU (NgayThu, TienThuPhieuBanHang, TienThuPhieuDichVu, TongTienThu) values ('"
                + dskt.NgayThu + "', " + dskt.TienThuPhieuBanHang + ", " + dskt.TienThuPhieuDichVu + ", " + dskt.TongTienThu + ")";
            DataBase.ExcuNonQuery(sql);
        }
        public static DataTable SelectAllDanhSachKhoanThu()
        {
            string sql = "select * from DANHSACHKHOANTHU";
            return DataBase.ExcuQuery(sql);
        }
    }
}
