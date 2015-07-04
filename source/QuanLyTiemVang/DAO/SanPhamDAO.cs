using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class SanPhamDAO : IRestorableData
    {
        private static string column_list = "MaSanPham, TenSanPham, LoaiSanPham, SoLuongTon";
        static public DataTable SelectSanPhamLikeMaSanPham(SanPhamDTO sp)
        {
            string sql = "Select " + column_list + " from SANPHAM where MaSanPham like '%" + sp.MaSanPham + "%' and TamXoa = 0";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable SelectSanPhamLikeTenSanPham(SanPhamDTO sp)
        {
            string sql = "Select " + column_list + " from SANPHAM where TenSanPham like '%" + sp.TenSanPham + "%' and TamXoa = 0";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable SelectSanPhamLikeLoaiSanPham(SanPhamDTO sp)
        {
            string sql = "Select " + column_list + " from SANPHAM where LoaiSanPham like '%" + sp.LoaiSanPham + "%' and TamXoa = 0";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable SelectSanPhamBySoLuongTon(int soluongtonmin, int soluongtonmax)
        {
            string sql = "Select " + column_list + " from SANPHAM where (SoLuongTon >= " + soluongtonmin + ") and (SoLuongTon <= " + soluongtonmax + ") and TamXoa = 0";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable SelectSanPhamByMaSanPham(SanPhamDTO sp)
        {
            string sql = "Select " + column_list + " from SANPHAM where MaSanPham = " + sp.MaSanPham + " and TamXoa = 0";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable GetAllSanPham()
        {
            string sql = "Select " + column_list + " from SANPHAM where TamXoa = 0";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable GetAllTempDeleteSanPham()
        {
            string sql = "Select " + column_list + " from SANPHAM where TamXoa = 1";
            return DataBase.ExcuQuery(sql);
        }
        public static void UpdateSoLuongTon(SanPhamDTO sp)
        {
            string sql = "update SANPHAM set SoLuongTon = " + sp.SoLuongTon + " where MaSanPham = " + sp.MaSanPham + "";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Insert(SanPhamDTO sp)
        {
            string sql = "insert into SANPHAM(TenSanPham, LoaiSanPham, SoLuongTon) values ('" + sp.TenSanPham + "', '" + sp.LoaiSanPham + "', " + sp.SoLuongTon + ")";
            DataBase.ExcuNonQuery(sql);
        }
        public static void Delete(SanPhamDTO sp)
        {
            string sql = "delete from SANPHAM where MaSanPham = " + sp.MaSanPham + "";
            DataBase.ExcuNonQuery(sql);
        }
        public static void TempDelete(SanPhamDTO sp)
        {
            string sql = "Update SANPHAM set TamXoa = 1 where MaSanPham =" + sp.MaSanPham;
            DataBase.ExcuNonQuery(sql);
        }
        public static void RestoreTempDelete(SanPhamDTO sp)
        {
            string sql = "Update SANPHAM set TamXoa = 0 where MaSanPham =" + sp.MaSanPham;
            DataBase.ExcuNonQuery(sql);
        }
        public static void Update(SanPhamDTO sp)
        {
            string sql = "Update SANPHAM set TenSanPham =('" + sp.TenSanPham + "'), LoaiSanPham =('" + sp.LoaiSanPham + "') where MaSanPham =" + sp.MaSanPham + "";
            DataBase.ExcuNonQuery(sql);
        }

        public void RestoreTemp(uint id)
        {
            SanPhamDTO sp = new SanPhamDTO();
            sp.MaSanPham = id;
            RestoreTempDelete(sp);
        }

        public void PermDelete(uint id)
        {
            SanPhamDTO sp = new SanPhamDTO();
            sp.MaSanPham = id;
            Delete(sp);
        }


        public DataTable GetAllDeletedItem()
        {
            return GetAllTempDeleteSanPham();
        }
    }
}
