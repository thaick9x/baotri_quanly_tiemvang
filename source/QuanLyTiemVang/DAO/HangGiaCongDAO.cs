using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class HangGiaCongDAO
    {
        public static DataTable SelectHangGiaCongByMaHangGiaCong(HangGiaCongDTO hgc)
        {
            string sql = "select * from HANGGIACONG where MaHangGiaCong = " + hgc.MaHangGiaCong;
            return DataBase.ExcuQuery(sql);
        }
        public static DataTable GetAllHangGiaCong()
        {
            string sql = "select * from HANGGIACONG";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(HangGiaCongDTO hgc)
        {
            string sql = "insert into HANGGIACONG(TenHangGiaCong, DonGiaGiaCong) values ('" + hgc.TenHangGiaCong + "', " + hgc.DonGiaGiaCong + ")";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(HangGiaCongDTO hgc)
        {
            string sql = "delete from HANGGIACONG where MaHangGiaCong = " + hgc.MaHangGiaCong + "";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Update(HangGiaCongDTO hgc)
        {
            string sql = "Update HANGGIACONG set TenHangGiaCong =('" + hgc.TenHangGiaCong + "'), DonGiaGiaCong =('" + hgc.DonGiaGiaCong + "') where MaHangGiaCong =" + hgc.MaHangGiaCong + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
