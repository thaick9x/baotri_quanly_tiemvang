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
    public partial class DanhSachThoGiaCong : Form
    {
        private uint mathogiacong = 0;

        public DanhSachThoGiaCong()
        {
            InitializeComponent();
        }

        private void DanhSachThoGiaCong_Load(object sender, EventArgs e)
        {
            txt_TenTho.Select();
            DataTable dt = ThoGiaCongDAO.GetAllThoGiaCong();
            dgv_DanhSachThoGiaCong.DataSource = dt;
        }

        private void dgv_DanhSachThoGiaCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            int Row = dgv_DanhSachThoGiaCong.Rows.Count;
            if (Index >= 0 && Index < Row - 1)
            {
                mathogiacong = Convert.ToUInt32(dgv_DanhSachThoGiaCong.Rows[Index].Cells[0].Value);
                txt_MaTho.Text = Convert.ToString(mathogiacong);
                txt_TenTho.Text = Convert.ToString(dgv_DanhSachThoGiaCong.Rows[Index].Cells[1].Value);
                txt_DiaChi.Text = Convert.ToString(dgv_DanhSachThoGiaCong.Rows[Index].Cells[2].Value);
            }

            if (Index >= Row - 1)
            {
                txt_MaTho.Text = "";
                txt_TenTho.Text = "";
                txt_DiaChi.Text = "";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThoGiaCongDTO tgc = new ThoGiaCongDTO();
            if (txt_TenTho.Text == "")
                MessageBox.Show("Chưa nhập Tên thợ");
            else if (txt_DiaChi.Text == "")
                MessageBox.Show("Chưa nhập Địa chỉ");
            else
            {
                tgc.TenTho = txt_TenTho.Text;
                tgc.DiaChi = txt_DiaChi.Text;
                if (ThoGiaCongBUS.ThemThoGiaCong(tgc))
                {
                    DanhSachThoGiaCong_Load(sender, e);
                    int num = dgv_DanhSachThoGiaCong.Rows.Count;
                    mathogiacong = Convert.ToUInt32(dgv_DanhSachThoGiaCong.Rows[num - 2].Cells[0].Value);
                    txt_MaTho.Text = Convert.ToString(mathogiacong);
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            ThoGiaCongDTO tgc = new ThoGiaCongDTO();
            try
            {
                tgc.MaTho = uint.Parse(txt_MaTho.Text);
            }
            catch (System.FormatException ex)
            {
                tgc.MaTho = 0;
            }
            if (tgc.MaTho != 0)
            {
                DialogResult dl = MessageBox.Show("Bạn có thực sự muốn thoát không?",
                            "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    if (ThoGiaCongBUS.XoaThoGiaCong(tgc))
                    {
                        string ten_tho = txt_TenTho.Text;
                        DanhSachThoGiaCong_Load(sender, e);
                        TaoMoi();
                        MessageBox.Show("Xóa thợ " + ten_tho + " thành công");
                    }
                    else
                        MessageBox.Show("Xoá thất bại");


                }

            }
            else
                MessageBox.Show("Bạn chưa chọn thợ gia công để xóa");
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            ThoGiaCongDTO tgc = new ThoGiaCongDTO();
            tgc.MaTho = uint.Parse(txt_MaTho.Text);
            if (tgc.MaTho != 0)
                if (txt_TenTho.Text == "")
                    MessageBox.Show("Chưa nhập Tên thợ");
                else if (txt_DiaChi.Text == "")
                    MessageBox.Show("Chưa nhập địa chỉ");
                else
                {
                    tgc.TenTho = txt_TenTho.Text;
                    tgc.DiaChi = txt_DiaChi.Text;
                    if (ThoGiaCongBUS.CapNhatThoGiaCong(tgc))
                    {
                        DanhSachThoGiaCong_Load(sender, e);
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                        MessageBox.Show("Cập nhật thất bại");
                }
            else
                MessageBox.Show("Bạn chưa chọn thợ gia công để cập nhật lại thông tin");
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            TaoMoi();
        }

        private void TaoMoi()
        {
            txt_MaTho.Text = "";
            txt_TenTho.Text = "";
            txt_DiaChi.Text = "";
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
