using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class ChiTietPhieuDichVuDAO
    {
        static public DataTable GetAllChiTietPhieuDichVu()
        {
            string sql = "select * from CHITIETPHIEUDICHVU";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(ChiTietPhieuDichVuDTO ctpdv)
        {
            string sql = "insert into CHITIETPHIEUDICHVU(MaPhieuDichVu, MaDichVu, SoLuong, ThanhTien) values('" + ctpdv.MaPhieuDichVu + "'," + ctpdv.MaDichVu + ",'" + ctpdv.SoLuong + "','" + ctpdv.ThanhTien + "')";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(ChiTietPhieuDichVuDTO ctpdv)
        {
            string sql = "delete from CHITIETPHIEUDICHVU where MaChiTietPhieuDichVu = " + ctpdv.MaChiTietPhieuDichVu + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
