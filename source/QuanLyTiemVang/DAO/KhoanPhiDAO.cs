using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class KhoanPhiDAO
    {
        public static DataTable GetAllKhoanPhi()
        {
            string sql = "select * from KHOANPHI";
            return DataBase.ExcuQuery(sql);
        }
        public static DataTable SelectKhoanPhiByMaKhoanPhi(KhoanPhiDTO kp)
        {
            string sql = "select * from KHOANPHI where MaKhoanPhi = " + kp.MaKhoanPhi + "";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(KhoanPhiDTO kp)
        {
            string sql = "insert into KHOANPHI(TenKhoanPhi) values ('" + kp.TenKhoanPhi + "')";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(KhoanPhiDTO kp)
        {
            string sql = "delete from KHOANPHI where MaKhoanPhi = " + kp.MaKhoanPhi + "";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Update(KhoanPhiDTO kp)
        {
            string sql = "Update KHOANPHI set TenKhoanPhi = ('" + kp.TenKhoanPhi + "') where MaKhoanPhi = " + kp.MaKhoanPhi + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
