using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class DanhSachKhoanChiDAO
    {
        public static void Insert(DanhSachKhoanChiDTO dskc)
        {
            string sql = "insert into DANHSACHKHOANCHI (NgayChi, TienChiPhieuMuaHang, TienChiPhieuHangGiaCong, TienChiPhieuChi, TongTienChi) values ('"
                + dskc.NgayChi + "', " + dskc.TienChiPhieuMuaHang + ", " + dskc.TienChiPhieuHangGiaCong + ", " + dskc.TienChiPhieuChi + ", " + dskc.TongTienChi + ")";
            DataBase.ExcuNonQuery(sql);
        }
        public static DataTable SelectAllDanhSachKhoanChi()
        {
            string sql = "select * from DANHSACHKHOANCHI";
            return DataBase.ExcuQuery(sql);
        }
    }
}
