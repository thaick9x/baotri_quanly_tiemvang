using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class TaiKhoanDAO
    {
        public static DataTable SelectTaiKhoanByTenDangNhap(TaiKhoanDTO tk)
        {
            string sql = "select * from TAIKHOAN where TenDangNhap = '" + tk.TenDangNhap + "'";
            return DataBase.ExcuQuery(sql);
        }
        public static DataTable SelectTaiKhoanByEmail(TaiKhoanDTO tk)
        {
            string sql = "select * from TAIKHOAN where Email = '" + tk.Email + "'";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(TaiKhoanDTO tk)
        {
            string sql = "insert into TAIKHOAN(TenDangNhap, MatKhau, Email) values ('" + tk.TenDangNhap + "', '" + tk.MatKhau + "', '" + tk.Email + "')";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
