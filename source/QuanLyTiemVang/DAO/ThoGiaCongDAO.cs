using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class ThoGiaCongDAO
    {
        public static DataTable SelectThoGiaCongByMaThoGiaCong(uint matho)
        {
            string sql = "select * from THOGIACONG where MaTho = " + matho + "";
            return DataBase.ExcuQuery(sql);
        }
        public static DataTable GetAllThoGiaCong()
        {
            string sql = "select * from THOGIACONG";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(ThoGiaCongDTO tgc)
        {
            string sql = "insert into THOGIACONG(TenTho, DiaChi) values ('" + tgc.TenTho + "', '" + tgc.DiaChi + "')";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(ThoGiaCongDTO tgc)
        {
            string sql = "delete from THOGIACONG where MaTho = " + tgc.MaTho + "";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Update(ThoGiaCongDTO tgc)
        {
            string sql = "Update THOGIACONG set TenTho =('" + tgc.TenTho + "'), DiaChi =('" + tgc.DiaChi + "') where MaTho =" + tgc.MaTho + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
