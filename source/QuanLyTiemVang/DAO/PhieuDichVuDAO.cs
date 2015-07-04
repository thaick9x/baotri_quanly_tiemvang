using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class PhieuDichVuDAO
    {
        public static DataTable GetAllPhieuDichVu()
        {
            string sql = "select * from PHIEUDICHVU";
            return DataBase.ExcuQuery(sql);
        }
        public static DataTable SelectPhieuDichVu()
        {
            string sql = "select MaPhieuDichVu, TongCong from PHIEUDICHVU";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(PhieuDichVuDTO pdv)
        {
            string sql = "insert into PHIEUDICHVU(MaKhachHang, NgayDangKy, NgayGiao, TongCong) values('" + pdv.MaKhachHang + "','" + pdv.NgayDangKy.ToString("yyyy-MM-dd") + "','" + pdv.NgayGiao.ToString("yyyy-MM-dd") + "','" + pdv.TongCong + "')";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(PhieuDichVuDTO pdv)
        {
            string sql = "delete from PHIEUDICHVU where MaPhieuDichVu = " + pdv.MaPhieuDichVu + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
