using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class ChiTietPhieuMuaHangDAO
    {
        static public DataTable GetAllChiTietPhieuMuaHang()
        {
            string sql = "select * from CHITIETPHIEUMUAHANG";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(ChiTietPhieuMuaHangDTO ctpmh)
        {
            string sql = "insert into CHITIETPHIEUMUAHANG(MaPhieuMuaHang, MaSanPham, SoLuongMua, DonGiaMua, ThanhTien) values(" + ctpmh.MaPhieuMuaHang + "," + ctpmh.MaSanPham + "," + ctpmh.SoLuongMua + "," + ctpmh.DonGiaMua + "," + ctpmh.ThanhTien + ")";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(ChiTietPhieuMuaHangDTO ctpmh)
        {
            string sql = "delete from CHITIETPHIEUMUAHANG where MaChiTietPhieuMuaHang = " + ctpmh.MaChiTietPhieuMuaHang + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
