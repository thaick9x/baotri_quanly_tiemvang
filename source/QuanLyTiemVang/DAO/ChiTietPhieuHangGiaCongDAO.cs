using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class ChiTietPhieuHangGiaCongDAO
    {
        static public DataTable GetAllChiTietPhieuHangGiaCong()
        {
            string sql = "select * from CHITIETPHIEUHANGGIACONG";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(ChiTietPhieuHangGiaCongDTO ctphgc)
        {
            string sql = "insert into CHITIETPHIEUHANGGIACONG(MaPhieuHangGiaCong, MaHangGiaCong, SoLuong, ThanhTien) values('" + ctphgc.MaPhieuHangGiaCong + "'," + ctphgc.MaHangGiaCong + ",'" + ctphgc.SoLuong + "','" + ctphgc.ThanhTien + "')";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(ChiTietPhieuHangGiaCongDTO ctphgc)
        {
            string sql = "delete from CHITIETPHIEUHANGGIACONG where MaChiTietPhieuHangGiaCong = " + ctphgc.MaChiTietPhieuHangGiaCong + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
