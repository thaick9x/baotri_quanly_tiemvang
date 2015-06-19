using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class ChiTietPhieuBanHangDAO
    {
        static public DataTable GetAllChiTietPhieuBanHang()
        {
            string sql = "select * from CHITIETPHIEUBANHANG";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(ChiTietPhieuBanHangDTO ctpbh)
        {
            string sql = "insert into CHITIETPHIEUBANHANG(MaPhieuBanHang, MaSanPham, SoLuongBan, DonGiaBan, ThanhTien) values('" + ctpbh.MaPhieuBanHang + "'," + ctpbh.MaSanPham + ",'" + ctpbh.SoLuongBan + "','" + ctpbh.DonGiaBan + "','" + ctpbh.ThanhTien + "')";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(ChiTietPhieuBanHangDTO ctpbh)
        {
            string sql = "delete from CHITIETPHIEUBANHANG where MaChiTietPhieuBanHang = " + ctpbh.MaChiTietPhieuBanHang + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
