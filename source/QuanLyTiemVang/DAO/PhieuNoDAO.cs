using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class PhieuNoDAO
    {
        public static DataTable GetAllPhieuNo()
        {
            string sql = "select * from PHIEUNO";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(PhieuNoDTO pn)
        {
            string sql = "insert into PHIEUNO(MaPhieuBanHang, NgayNo, NgayTra, SoTienTra, TienConLai) values('" + pn.MaPhieuBanHang + "','" + pn.NgayNo.ToString("yyyy-MM-dd") + "','" + pn.NgayTra.ToString("yyyy-MM-dd") + "','" + pn.SoTienTra + "','" + pn.TienConLai + "')";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(PhieuNoDTO pn)
        {
            string sql = "delete from PHIEUNO where MaPhieuNo = " + pn.MaPhieuNo + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
