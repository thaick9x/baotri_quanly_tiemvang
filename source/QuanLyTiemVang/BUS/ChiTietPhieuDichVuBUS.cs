using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;

namespace QuanLyTiemVang.BUS
{
    class ChiTietPhieuDichVuBUS
    {
        public static bool ThemChiTietPhieuDichVu(ChiTietPhieuDichVuDTO ctpdv)
        {
            ChiTietPhieuDichVuDAO.Insert(ctpdv);
            return true;
        }
        public static bool XoaChiTietPhieuDichVu(ChiTietPhieuDichVuDTO ctpdv)
        {
            ChiTietPhieuDichVuDAO.Delete(ctpdv);
            return true;
        }
    }
}
