using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;
using QuanLyTiemVang.BUS;

namespace QuanLyTiemVang.GUI
{
    public partial class DanhSachHangGiaCong : Form
    {
        private uint mahanggiacong = 0;

        public DanhSachHangGiaCong()
        {
            InitializeComponent();
        }

        private void DanhSachHangGiaCong_Load(object sender, EventArgs e)
        {
            txt_TenHangGiaCong.Select();
            DataTable dt = HangGiaCongDAO.GetAllHangGiaCong();
            dgv_DanhSachHangGiaCong.DataSource = dt;
        }

        private void dgv_DanhSachHangGiaCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            int Row = dgv_DanhSachHangGiaCong.Rows.Count;
            if (Index >= 0 && Index < Row - 1)
            {
                mahanggiacong = Convert.ToUInt32(dgv_DanhSachHangGiaCong.Rows[Index].Cells[0].Value);
                txt_MaHangGiaCong.Text = Convert.ToString(mahanggiacong);
                txt_TenHangGiaCong.Text = Convert.ToString(dgv_DanhSachHangGiaCong.Rows[Index].Cells[1].Value);
                txt_DonGiaGiaCong.Text = Convert.ToString(dgv_DanhSachHangGiaCong.Rows[Index].Cells[2].Value);
            }

            if (Index >= Row - 1)
            {
                txt_MaHangGiaCong.Text = "";
                txt_TenHangGiaCong.Text = "";
                txt_DonGiaGiaCong.Text = "";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            HangGiaCongDTO hgc = new HangGiaCongDTO();
            if (txt_TenHangGiaCong.Text == "")
                MessageBox.Show("Chưa nhập Tên hàng gia công");
            else if (txt_DonGiaGiaCong.Text == "")
                MessageBox.Show("Chưa nhập đơn giá gia công");
            else
            {
                hgc.TenHangGiaCong = txt_TenHangGiaCong.Text;
                hgc.DonGiaGiaCong = uint.Parse(txt_DonGiaGiaCong.Text);
                if (HangGiaCongBUS.ThemHangGiaCong(hgc))
                {
                    DanhSachHangGiaCong_Load(sender, e);
                    int num = dgv_DanhSachHangGiaCong.Rows.Count;
                    mahanggiacong = Convert.ToUInt32(dgv_DanhSachHangGiaCong.Rows[num - 2].Cells[0].Value);
                    txt_MaHangGiaCong.Text = Convert.ToString(mahanggiacong);
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            HangGiaCongDTO hgc = new HangGiaCongDTO();
            hgc.MaHangGiaCong = mahanggiacong;
            if (hgc.MaHangGiaCong != 0)
            {
                DialogResult dl = MessageBox.Show("Bạn có thực sự muốn thoát không?",
                            "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    if (HangGiaCongBUS.XoaHangGiaCong(hgc))
                    {
                        string ten_hgc = txt_TenHangGiaCong.Text;
                        DanhSachHangGiaCong_Load(sender, e);
                        TaoMoi();
                        MessageBox.Show("Xóa hàng gia công " + ten_hgc + " thành công");
                    }
                    else
                        MessageBox.Show("Xoá thất bại");

                    mahanggiacong = 0;
                }
                
            }
            else
                MessageBox.Show("Bạn chưa chọn hàng gia công để xóa");
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            HangGiaCongDTO hgc = new HangGiaCongDTO();
            hgc.MaHangGiaCong = mahanggiacong;
            if (hgc.MaHangGiaCong != 0)
                if (txt_TenHangGiaCong.Text == "")
                    MessageBox.Show("Chưa nhập Tên hàng gia công");
                else if (txt_DonGiaGiaCong.Text == "")
                    MessageBox.Show("Chưa nhập đơn giá hàng gia công");
                else
                {
                    hgc.TenHangGiaCong = txt_TenHangGiaCong.Text;
                    hgc.DonGiaGiaCong = uint.Parse(txt_DonGiaGiaCong.Text);
                    if (HangGiaCongBUS.CapNhatHangGiaCong(hgc))
                    {
                        DanhSachHangGiaCong_Load(sender, e);
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                        MessageBox.Show("Cập nhật thất bại");
                }
            else
                MessageBox.Show("Bạn chưa chọn hàng gia công để cập nhật lại thông tin");
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            TaoMoi();
        }

        private void TaoMoi()
        {
            txt_MaHangGiaCong.Text = "";
            txt_TenHangGiaCong.Text = "";
            txt_DonGiaGiaCong.Text = "";
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
