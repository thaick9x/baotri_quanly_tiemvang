using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class PhieuBanHangDAO
    {
        public static DataTable GetAllPhieuBanHang()
        {
            string sql = "select * from PHIEUBANHANG";
            return DataBase.ExcuQuery(sql);
        }
        public static DataTable SelectPhieuBanHang()
        {
            string sql = "select MaPhieuBanHang, TongCong from PHIEUBANHANG";
            return DataBase.ExcuQuery(sql);
        }

        public static DataTable SelectPhieuBanHangByMaPhieuBanHang(PhieuBanHangDTO pbh)
        {
            string sql = "select * from PHIEUBANHANG where MaPhieuBanHang = " + pbh.MaPhieuBanHang + "";
            return DataBase.ExcuQuery(sql);
        }
        public static DataTable SelectPhieuBanHangByNgayThanhToan(PhieuBanHangDTO pbh)
        {
            string sql = "select MaPhieuBanHang, TongCong from PHIEUBANHANG where NgayThanhToan = " + pbh.NgayThanhToan.Date + "";
            return DataBase.ExcuQuery(sql);
        }
        public static void Insert(PhieuBanHangDTO pbh)
        {
            string sql = "insert into PHIEUBANHANG(MaKhachHang, NgayBan, NgayThanhToan, TongCong, SoTienThanhToan, SoTienNo) values('" + pbh.MaKhachHang + "','" + pbh.NgayBan.ToString("yyyy-MM-dd") + "','" + pbh.NgayThanhToan.ToString("yyyy-MM-dd") + "','" + pbh.TongCong + "','" + pbh.SoTienThanhToan + "','" + pbh.SoTienNo + "')";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(PhieuBanHangDTO pbh)
        {
            string sql = "delete from PHIEUBANHANG where MaPhieuBanHang = " + pbh.MaPhieuBanHang + "";
            DataBase.ExcuNonQuery(sql);
        }
        public static void UpdateTienNo(PhieuBanHangDTO pbh)
        {
            string sql = "update PHIEUBANHANG set SoTienNo = " + pbh.SoTienNo + " where MaPhieuBanHang = " + pbh.MaPhieuBanHang + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
