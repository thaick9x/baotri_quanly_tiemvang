using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class PhieuChiDAO
    {
        public static DataTable GetAllPhieuChi()
        {
            string sql = "select * from PHIEUCHI";
            return DataBase.ExcuQuery(sql);
        }
        public static DataTable SelectPhieuChi()
        {
            string sql = "select MaPhieuChi, TongCong from PHIEUCHI";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(PhieuChiDTO pc)
        {
            string sql = "insert into PHIEUCHI(NgayChi, TongCong) values('" + pc.NgayChi + "','" + pc.TongCong + "')";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(PhieuChiDTO pc)
        {
            string sql = "delete from PHIEUCHI where MaPhieuChi = " + pc.MaPhieuChi + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
