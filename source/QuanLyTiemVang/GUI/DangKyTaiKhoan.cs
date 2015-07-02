using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;  
using System.Windows.Forms;
using QuanLyTiemVang.DAO;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.BUS;

namespace QuanLyTiemVang.GUI
{
    public partial class DangKyTaiKhoan : Form
    {
        private bool ktra_tendangnhap = false;
        private bool ktra_matkhau = false;
        private bool ktra_xacnhanmatkhau = false;
        private bool ktra_email = false;

        public DangKyTaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_DangKyTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO dn = new TaiKhoanDTO();
            dn.TenDangNhap = txt_TenDangNhap.Text;
            DataTable dt1 = TaiKhoanDAO.SelectTaiKhoanByTenDangNhap(dn);
            if (txt_TenDangNhap.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!");
                ktra_tendangnhap = false;
            }
            else
                if (dt1 != null && dt1.Rows.Count > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã có người sử dụng, vui lòng nhập tên khác!");
                    ktra_tendangnhap = false;
                }
                else
                    if (txt_TenDangNhap.Text.Length < 6)
                    {
                        MessageBox.Show("Vui lòng nhập tên đăng nhập từ 6 ký tự trở lên!");
                        ktra_tendangnhap = false;
                    }
                    else
                        ktra_tendangnhap = true;

            if (txt_MatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                ktra_matkhau = false;
            }
            else
                if (txt_MatKhau.Text.Length < 6)
                {
                    MessageBox.Show("Mật khẩu quá ngắn, vui lòng nhập ít nhất 6 ký tự!");
                    ktra_matkhau = false;
                }
                else
                    ktra_matkhau = true;

            if (txt_XacNhanMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu xác nhận không được để trống!");
                ktra_xacnhanmatkhau = false;
            }
            else
                if (txt_XacNhanMatKhau.Text != txt_MatKhau.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận sai, xin vui lòng nhập lại!");
                    ktra_xacnhanmatkhau = false;
                }
                else
                    ktra_xacnhanmatkhau = true;

            dn.Email = txt_Email.Text;
            DataTable dt2 = TaiKhoanDAO.SelectTaiKhoanByEmail(dn);
            if (txt_Email.Text == "")
                MessageBox.Show("Email không được để trống!");
            else
                if (dt2 != null && dt2.Rows.Count > 0)
                {
                    MessageBox.Show("Email đã có người sử dụng, vui lòng nhập email khác!");
                    ktra_email = false;
                }
                else
                    ktra_email = true;
            // Tạo tài khoản
            if (ktra_tendangnhap && ktra_matkhau && ktra_xacnhanmatkhau && ktra_email)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.TenDangNhap = txt_TenDangNhap.Text;
                tk.MatKhau = DataBase.getMD5(txt_MatKhau.Text);
                tk.Email = txt_Email.Text;
                if (TaiKhoanBUS.ThemTaiKhoan(tk))
                    MessageBox.Show("Đăng ký tài khoản thành công!");
                else
                    MessageBox.Show("Đăng ký thất bại!");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có thực sự muốn thoát không?",
              "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            txt_TenDangNhap.Text = "";
            txt_MatKhau.Text = "";
            txt_XacNhanMatKhau.Text = "";
            txt_Email.Text = "";
        }

        private void txt_TenDangNhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txt_MatKhau.Select();
        }

        private void txt_MatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txt_XacNhanMatKhau.Select();
        }

        private void txt_XacNhanMatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txt_Email.Select();
        }

        private void txt_Email_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                btn_DangKyTaiKhoan.Select();
        }

        private void txt_TenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (txt_TenDangNhap.Text.Length < 6)
                lbl_LoiDangNhap.Text = "Nhập từ 6 ký tự trở lên";
            else
                lbl_LoiDangNhap.Text = "OK";
        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text.Length < 6)
                lbl_MatKhau.Text = "Nhập từ 6 ký tự trở lên";
            else
                lbl_MatKhau.Text = "OK";
        }

        private void txt_XacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text == txt_XacNhanMatKhau.Text)
                label5.Text = "OK";
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"; 
            lbl_LoiEmail.Text = ""; 
            Regex reg = new Regex(match); 
            if (reg.IsMatch(txt_Email.Text)) lbl_LoiEmail.Text = "OK"; 
            else lbl_LoiEmail.Text = "email không hợp lệ"; 

        }
    }
}
