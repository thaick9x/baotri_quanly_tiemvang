using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class PhieuMuaHangDAO
    {
        public static DataTable GetAllPhieuMuaHang()
        {
            string sql = "select * from PHIEUMUAHANG";
            return DataBase.ExcuQuery(sql);
        }
        public static DataTable SelectPhieuMuaHang()
        {
            string sql = "select MaPhieuMuaHang, TongCong from PHIEUMUAHANG";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(PhieuMuaHangDTO pmh)
        {
            string sql = "insert into PHIEUMUAHANG(MaKhachHang, NgayMua, NgayThanhToan, TongCong) values('" + pmh.MaKhachHang + "','" + pmh.NgayMua + "','" + pmh.NgayThanhToan + "','" + pmh.TongCong + "')";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(PhieuMuaHangDTO pmh)
        {
            string sql = "delete from PHIEUMUAHANG where MaPhieuMuaHang = " + pmh.MaPhieuMuaHang + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
