using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.DAO
{
    class SanPhamDAO
    {
        static public DataTable SelectSanPhamLikeMaSanPham(SanPhamDTO sp)
        {
            string sql = "select * from SANPHAM where MaSanPham like '%" + sp.MaSanPham + "%'";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable SelectSanPhamLikeTenSanPham(SanPhamDTO sp)
        {
            string sql = "select * from SANPHAM where TenSanPham like '%" + sp.TenSanPham + "%'";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable SelectSanPhamLikeLoaiSanPham(SanPhamDTO sp)
        {
            string sql = "select * from SANPHAM where LoaiSanPham like '%" + sp.LoaiSanPham + "%'";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable SelectSanPhamBySoLuongTon(int soluongtonmin, int soluongtonmax)
        {
            string sql = "select * from SANPHAM where (SoLuongTon >= " + soluongtonmin + ") and (SoLuongTon <= " + soluongtonmax + ")";
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable SelectSanPhamByMaSanPham(SanPhamDTO sp)
        {
            string sql = "select * from SANPHAM where MaSanPham = " + sp.MaSanPham;
            return DataBase.ExcuQuery(sql);
        }
        static public DataTable GetAllSanPham()
        {
            string sql = "select * from SANPHAM";
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
        public static void Update(SanPhamDTO sp)
        {
            string sql = "Update SANPHAM set TenSanPham =('" + sp.TenSanPham + "'), LoaiSanPham =('" + sp.LoaiSanPham + "') where MaSanPham =" + sp.MaSanPham + "";
            DataBase.ExcuNonQuery(sql);
        }
    }
}
