using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyTiemVang.DAO;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.BUS;

namespace QuanLyTiemVang.GUI
{
    public partial class BaoCaoDoanhThu : Form
    {
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void btn_LapBaoCao_Click(object sender, EventArgs e)
        {
            PhieuBanHangDTO pbh = new PhieuBanHangDTO();
            DataTable dt1 = PhieuBanHangDAO.SelectPhieuBanHang();
            dgv_DanhSachPhieuBanHang.DataSource = dt1;
            DataTable dt2 = PhieuDichVuDAO.SelectPhieuDichVu();
            dgv_DanhSachPhieuDichVu.DataSource = dt2;
            DataTable dt3 = PhieuMuaHangDAO.SelectPhieuMuaHang();
            dgv_DanhSachPhieuMuaHang.DataSource = dt3;
            DataTable dt4 = PhieuHangGiaCongDAO.SelectPhieuHangGiaCong();
            dgv_DanhSachPhieuHangGiaCong.DataSource = dt4;
            DataTable dt5 = PhieuChiDAO.SelectPhieuChi();
            dgv_DanhSachPhieuChi.DataSource = dt5;

            long tienthuphieubanhang = 0;
            for (int i = 0; i < dgv_DanhSachPhieuBanHang.Rows.Count; i++)
                tienthuphieubanhang += Convert.ToInt64(dgv_DanhSachPhieuBanHang.Rows[i].Cells[1].Value);
            txt_TienThuPhieuBanHang.Text = tienthuphieubanhang.ToString();

            long tienthuphieudichvu = 0;
            for (int i = 0; i < dgv_DanhSachPhieuDichVu.Rows.Count; i++)
                tienthuphieudichvu += Convert.ToInt64(dgv_DanhSachPhieuDichVu.Rows[i].Cells[1].Value);
            txt_TienThuPhieuDichVu.Text = tienthuphieudichvu.ToString();

            long tienchiphieumuahang = 0;
            for (int i = 0; i < dgv_DanhSachPhieuMuaHang.Rows.Count; i++)
                tienchiphieumuahang += Convert.ToInt64(dgv_DanhSachPhieuMuaHang.Rows[i].Cells[1].Value);
            txt_TienChiPhieuMuaHang.Text = tienchiphieumuahang.ToString();

            long tienchiphieuhanggiacong = 0;
            for (int i = 0; i < dgv_DanhSachPhieuHangGiaCong.Rows.Count; i++)
                tienchiphieuhanggiacong += Convert.ToInt64(dgv_DanhSachPhieuHangGiaCong.Rows[i].Cells[1].Value);
            txt_TienChiPhieuHangGiaCong.Text = tienchiphieuhanggiacong.ToString();

            long tienchiphieuchi = 0;
            for (int i = 0; i < dgv_DanhSachPhieuChi.Rows.Count; i++)
                tienchiphieuchi += Convert.ToInt64(dgv_DanhSachPhieuChi.Rows[i].Cells[1].Value);
            txt_TienChiPhieuChi.Text = tienchiphieuchi.ToString();

            long tongtienthu = tienthuphieubanhang + tienthuphieudichvu;
            txt_TongTienThu.Text = tongtienthu.ToString();
            long tongtienchi = tienchiphieumuahang + tienchiphieuhanggiacong + tienchiphieuchi;
            txt_TongTienChi.Text = tongtienchi.ToString();


            BaoCaoDoanhThuDTO bcdt = new BaoCaoDoanhThuDTO();
            DataTable dt6 = BaoCaoDoanhThuDAO.SelectAllBaoCaoDoanhThu();
            long tonquybandau = Convert.ToInt64(dt6.Rows[dt6.Rows.Count - 1]["TonQuyConLai"]);
            txt_TonQuyBanDau.Text = tonquybandau.ToString();
            long tonquyconlai = tonquybandau + tongtienthu - tongtienchi;
            txt_TonQuyConLai.Text = tonquyconlai.ToString();

            DanhSachKhoanThuDTO dskt = new DanhSachKhoanThuDTO();
            dskt.NgayThu = dateTimePicker_NgayBaoCao.Value;
            dskt.TienThuPhieuBanHang = tienthuphieubanhang;
            dskt.TienThuPhieuDichVu = tienthuphieudichvu;
            dskt.TongTienThu = tongtienthu;
            if (DanhSachKhoanThuBUS.ThemDanhSachKhoanThu(dskt))
            {
                DataTable dt7 = DanhSachKhoanThuDAO.SelectAllDanhSachKhoanThu();
                bcdt.MaDanhSachKhoanThu = Convert.ToInt32(dt7.Rows[dt7.Rows.Count - 1]["MaDanhSachKhoanThu"]);
            }

            DanhSachKhoanChiDTO dskc = new DanhSachKhoanChiDTO();
            dskc.NgayChi = dateTimePicker_NgayBaoCao.Value;
            dskc.TienChiPhieuMuaHang = tienchiphieumuahang;
            dskc.TienChiPhieuHangGiaCong = tienchiphieuhanggiacong;
            dskc.TienChiPhieuChi = tienchiphieuchi;
            dskc.TongTienChi = tongtienchi;
            if (DanhSachKhoanChiBUS.ThemDanhSachKhoanChi(dskc))
            {
                DataTable dt8 = DanhSachKhoanChiDAO.SelectAllDanhSachKhoanChi();
                bcdt.MaDanhSachKhoanChi = Convert.ToInt32(dt8.Rows[dt8.Rows.Count - 1]["MaDanhSachKhoanChi"]);
            }


            bcdt.NgayBaoCao = dateTimePicker_NgayBaoCao.Value;
            bcdt.TonQuyBanDau = long.Parse(txt_TonQuyBanDau.Text);
            bcdt.TonQuyConLai = long.Parse(txt_TonQuyConLai.Text);
            if (BaoCaoDoanhThuBUS.ThemBaoCaoDoanhThu(bcdt))
            {
                DataTable dt9 = BaoCaoDoanhThuDAO.SelectAllBaoCaoDoanhThu();
                txt_MaBaoCao.Text = Convert.ToString(dt9.Rows[dt9.Rows.Count - 1]["MaBaoCaoDoanhThu"]);
                MessageBox.Show("Lập báo cáo thành công!");
            }
            else
                MessageBox.Show("Lập báo cáo thất bại!");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có thực sự muốn thoát khỏi nghiệp vụ này không?",
              "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }
    }
}
