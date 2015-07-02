using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyTiemVang.GUI;
namespace QuanLyTiemVang
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        /*Vô hiệu hóa nút Close(X) mặc định trong Form
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }*/ 

        private void LapPhieuBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuBanHang frmPhieuBanHang = new PhieuBanHang();
            frmPhieuBanHang.Show();
        }

        private void LapPhieuMuaHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuaHang frmPhieuMuaHang = new PhieuMuaHang();
            frmPhieuMuaHang.Show();
        }

        private void LapPhieuDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuDichVu frmPhieuDichVu = new PhieuDichVu();
            frmPhieuDichVu.Show();
        }

        private void LapPhieuNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuNo frmPhieuNo = new PhieuNo();
            frmPhieuNo.Show();
        }

        private void LapPhieuHangGiaCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuHangGiaCong frmPhieuHangGiaCong = new PhieuHangGiaCong();
            frmPhieuHangGiaCong.Show();
        }

        private void LapPhieuChi_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuChi frmPhieuChi = new PhieuChi();
            frmPhieuChi.Show();
        }

        private void DanhSachSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachSanPham frmDanhSachSanPham = new DanhSachSanPham();
            frmDanhSachSanPham.Show();
        }

        private void DanhSachKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachKhachHang frmDanhSạhKhachHang = new DanhSachKhachHang();
            frmDanhSạhKhachHang.Show();
        }

        private void DanhSachDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachDichVu frmDanhSachDichVu = new DanhSachDichVu();
            frmDanhSachDichVu.Show();
        }

        private void DanhSachHangGiaCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachHangGiaCong frmDanhSachHangGiaCong = new DanhSachHangGiaCong();
            frmDanhSachHangGiaCong.Show();
        }

        private void DanhSachThoGiaCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachThoGiaCong frmDanhSachThoGiaCong = new DanhSachThoGiaCong();
            frmDanhSachThoGiaCong.Show();
        }

        private void DanhSachKhoanPhiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachKhoanPhi frmDanhSachKhoanPhi = new DanhSachKhoanPhi();
            frmDanhSachKhoanPhi.Show();
        }

        private void BaoCaoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu frmBaoCaoDoanhThu = new BaoCaoDoanhThu();
            frmBaoCaoDoanhThu.Show();
        }

        public void FormMain_Load(object sender, EventArgs e)
        {
            // Everything is true, no need for sign in
            // WARNING: must delete immediately in production release.
            //DangNhap.KiemTraDangNhap.ktradangnhap = true;

            if (DangNhap.KiemTraDangNhap.ktradangnhap == false)
            {
                DangNhap_ToolStripMenuItem.Enabled = true;
                DangXuat_ToolStripMenuItem1.Enabled = false;
                NghiepVu_ToolStripMenuItem.Enabled = false;
                SanPham_ToolStripMenuItem.Enabled = false;
                KhachHang_ToolStripMenuItem.Enabled = false;
                DichVu_ToolStripMenuItem.Enabled = false;
                GiaCong_ToolStripMenuItem.Enabled = false;
                TroGiup_ToolStripMenuItem.Enabled = false;
            }
            else
            {
                DangNhap_ToolStripMenuItem.Enabled = false;
                DangXuat_ToolStripMenuItem1.Enabled = true;
                NghiepVu_ToolStripMenuItem.Enabled = true;
                SanPham_ToolStripMenuItem.Enabled = true;
                KhachHang_ToolStripMenuItem.Enabled = true;
                DichVu_ToolStripMenuItem.Enabled = true;
                GiaCong_ToolStripMenuItem.Enabled = true;
                TroGiup_ToolStripMenuItem.Enabled = true;
            }
        }

        private void TraCuuKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuuKhachHang frmTraCuuKhachHang = new TraCuuKhachHang();
            frmTraCuuKhachHang.Show();
        }

        private void TraCuuSsanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuuSanPham frmTraCuuSanPham = new TraCuuSanPham();
            frmTraCuuSanPham.Show();
        }

        private void DangNhap_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap frmDangNhap = new DangNhap();
            frmDangNhap.ShowDialog();
        }

        private void Thoat_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*DialogResult dl = MessageBox.Show("Bạn có thực sự muốn thoát không?",
              "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }*/

            this.Close();
        }

        private void DangXuat_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DangNhap.KiemTraDangNhap.ktradangnhap = false;
            FormMain_Load(sender, e);
            MessageBox.Show("Bạn đã đăng xuất thành công!");
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            if (DangNhap.KiemTraDangNhap.ktradangnhap == false)
            {
                DangNhap_ToolStripMenuItem.Enabled = true;
                DangXuat_ToolStripMenuItem1.Enabled = false;
                NghiepVu_ToolStripMenuItem.Enabled = false;
                SanPham_ToolStripMenuItem.Enabled = false;
                KhachHang_ToolStripMenuItem.Enabled = false;
                DichVu_ToolStripMenuItem.Enabled = false;
                GiaCong_ToolStripMenuItem.Enabled = false;
                TroGiup_ToolStripMenuItem.Enabled = false;
            }
            else
            {
                DangNhap_ToolStripMenuItem.Enabled = false;
                DangXuat_ToolStripMenuItem1.Enabled = true;
                NghiepVu_ToolStripMenuItem.Enabled = true;
                SanPham_ToolStripMenuItem.Enabled = true;
                KhachHang_ToolStripMenuItem.Enabled = true;
                DichVu_ToolStripMenuItem.Enabled = true;
                GiaCong_ToolStripMenuItem.Enabled = true;
                TroGiup_ToolStripMenuItem.Enabled = true;
            }
        }

        private void HuongDanSuDung_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDanSuDung frmHuongDanSuDung = new HuongDanSuDung();
            frmHuongDanSuDung.Show();
        }

        private void ThongTinUngDung_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinUngDung frmThongTinUngDung = new ThongTinUngDung();
            frmThongTinUngDung.Show();
        }

        private void LapBaoCaoTon_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoTon frmBaoCaoTon = new BaoCaoTon();
            frmBaoCaoTon.Show();
        }

        private void testInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataBase.OpenConnection();
            
            string sql = "insert into sanpham(TenSanPham, LoaiSanPham, SoLuongTon) values ('" + "ten san pham" + "', '" + "2" + "', " + "55" + ")";
            DataBase.ExcuNonQuery(sql);
            //DataBase.CloseConnection();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Handle form closing confirmation.

            DialogResult dl = MessageBox.Show("Bạn có thực sự muốn thoát không?",
                     "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
    }
}
