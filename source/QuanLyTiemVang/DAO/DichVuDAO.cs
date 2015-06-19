using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class DichVuDAO
    {
        static public DataTable GetAllDichVu()
        {
            string sql = "select * from DICHVU";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable SelectDichVuByMaDichVu(DichVuDTO dv)
        {
            string sql = "select * from DICHVU where MaDichVu = " + dv.MaDichVu;
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(DichVuDTO dv)
        {
            string sql = "insert into DICHVU(TenDichVu, DonGiaDichVu) values ('" + dv.TenDichVu + "', " + dv.DonGiaDichVu + ")";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(DichVuDTO dv)
        {
            string sql = "delete from DICHVU where MaDichVu = " + dv.MaDichVu + "";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Update(DichVuDTO dv)
        {
            string sql = "Update DICHVU set TenDichVu =('" + dv.TenDichVu + "'), DonGiaDichVu =('" + dv.DonGiaDichVu + "') where MaDichVu=" + dv.MaDichVu + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
