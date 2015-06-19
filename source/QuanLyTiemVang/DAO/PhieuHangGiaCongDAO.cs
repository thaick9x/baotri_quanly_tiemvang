using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class PhieuHangGiaCongDAO
    {
        public static DataTable GetAllPhieuHangGiaCong()
        {
            string sql = "select * from PHIEUHANGGIACONG";
            return DataBase.ExcuQuery(sql);
        }
        public static DataTable SelectPhieuHangGiaCong()
        {
            string sql = "select MaPhieuHangGiaCong, TongCong from PHIEUHANGGIACONG";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(PhieuHangGiaCongDTO phgc)
        {
            string sql = "insert into PHIEUHANGGIACONG(MaTho, NgayGiaCong, NgayNhanHangGiaCong, TongCong) values('" + phgc.MaTho + "','" + phgc.NgayGiaCong + "','" + phgc.NgayNhanHangGiaCong + "','" + phgc.TongCong + "')";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(PhieuHangGiaCongDTO phgc)
        {
            string sql = "delete from PHIEUHANGGIACONG where MaPhieuHangGiaCong = " + phgc.MaPhieuHangGiaCong + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
