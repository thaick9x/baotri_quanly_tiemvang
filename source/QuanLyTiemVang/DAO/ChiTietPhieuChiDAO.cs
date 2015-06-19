using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class ChiTietPhieuChiDAO
    {
        public static void Insert(ChiTietPhieuChiDTO ctpc)
        {
            string sql = "insert into CHITIETPHIEUCHI(MaPhieuChi, MaKhoanPhi, ThanhTien) values('" + ctpc.MaPhieuChi + "','" + ctpc.MaKhoanPhi + "','" + ctpc.ThanhTien + "')";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(ChiTietPhieuChiDTO ctpc)
        {
            string sql = "delete from CHITIETPHIEUCHI where MaPhieuChi = " + ctpc.MaPhieuChi + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
