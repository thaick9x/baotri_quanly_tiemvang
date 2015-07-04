using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class KhachHangDAO : IRestorableData
    {
        static string column_list = "MaKhachHang, TenKhachHang, LoaiKhachHang, DiaChi, TienNoHienTai";

        static public DataTable SelectKhachHangLikeMaKhachHang(KhachHangDTO kh)
        {
            string sql = "Select " + column_list + " from KHACHHANG where MaKhachHang like '%" + kh.MaKhachHang + "%' and TamXoa = 0" ;
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable SelectKhachHangLikeTenKhachHang(KhachHangDTO kh)
        {
            string sql = "Select " + column_list + " from KHACHHANG where TenKhachHang like '%" + kh.TenKhachHang + "%' and TamXoa = 0";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable SelectKhachHangLikeLoaiKhachHang(KhachHangDTO kh)
        {
            string sql = "Select " + column_list + " from KHACHHANG where LoaiKhachHang like '%" + kh.LoaiKhachHang + "%' and TamXoa = 0";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable SelectKhachHangLikeDiaChi(KhachHangDTO kh)
        {
            string sql = "Select " + column_list + " from KHACHHANG where DiaChi like '%" + kh.DiaChi + "%' and TamXoa = 0";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable SelectKhachHangByTienNoHienTai(int tiennomin, int tiennomax)
        {
            string sql = "Select " + column_list + " from KHACHHANG where (TienNoHienTai >= " + tiennomin + ") and (TienNoHienTai <= " + tiennomax + ") and TamXoa = 0";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable SelectKhachHangByMaKhachHang(uint makh)
        {
            string sql = "Select " + column_list + " from KHACHHANG where MaKhachHang = " + makh + " and TamXoa = 0";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable GetAllKhachHang()
        {
            string sql = "Select " + column_list + " from KHACHhANG where TamXoa = 0";
            return DataBase.ExcuQuery(sql);
        }
        public static DataTable GetAllTempDeletedKhachHang()
        {
            string sql = "Select " + column_list + " from KHACHhANG where TamXoa != 0";
            return DataBase.ExcuQuery(sql);
        }
        public static void RestoreTempDelete(KhachHangDTO kh)
        {
            string sql = "update KHACHHANG set TamXoa = 0 where MaKhachHang = " + kh.MaKhachHang + "";
            DataBase.ExcuNonQuery(sql);
        }


        public static void Insert(KhachHangDTO kh)
        {
            string sql = "insert into KHACHHANG(TenKhachHang, LoaiKhachHang, DiaChi, TienNoHienTai) values ('" + kh.TenKhachHang + "', '" + kh.LoaiKhachHang + "', '" + kh.DiaChi + "', " + kh.TienNoHienTai + ")";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(KhachHangDTO kh)
        {
            string sql = "delete from KHACHHANG where MaKhachHang = " + kh.MaKhachHang + "";
            DataBase.ExcuNonQuery(sql);
        }
        public static void TempDelete(KhachHangDTO kh)
        {
            string sql = "update KHACHHANG set TamXoa = 1 where MaKhachHang = " + kh.MaKhachHang + "";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Update(KhachHangDTO kh)
        {
            string sql = "Update KHACHHANG set TenKhachHang =('" + kh.TenKhachHang + "'), LoaiKhachHang =('" + kh.LoaiKhachHang + "'),  DiaChi =('" + kh.DiaChi + "') where MaKhachHang = " + kh.MaKhachHang + "";
            DataBase.ExcuNonQuery(sql);
        }
        public static void UpdateTienNo(KhachHangDTO kh)
        {
            string sql = "Update KHACHHANG set TienNoHienTai = (" + kh.TienNoHienTai + ") where MaKhachHang = " + kh.MaKhachHang + "";
            DataBase.ExcuNonQuery(sql);
        }
    
        public void RestoreTemp(uint makh)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKhachHang = makh;
            RestoreTempDelete(kh);
        }

        public void PermDelete(uint makh)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKhachHang = makh;
            Delete(kh);
        }


        public DataTable GetAllDeletedItem()
        {
            return GetAllTempDeletedKhachHang();
        }
    }
}
