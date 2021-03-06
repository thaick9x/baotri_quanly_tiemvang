﻿using System;
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
using QuanLyTiemVang.GUI;
using QuanLyTiemVang;

namespace QuanLyTiemVang.GUI
{
    public partial class DangNhap : Form
    {
        public class KiemTraDangNhap
        {
            public static bool ktradangnhap = false;
        }
        private bool ktra_tendangnhap = false;
        private bool ktra_matkhau = false;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.TenDangNhap = txt_TenDangNhap.Text;
            DataTable dt = TaiKhoanDAO.SelectTaiKhoanByTenDangNhap(tk);
            if (dt != null && dt.Rows.Count > 0)
            {
                ktra_tendangnhap = true;
                tk.MatKhau = Convert.ToString(dt.Rows[0]["MatKhau"]);
            }
            if (tk.MatKhau == txt_MatKhau.Text)
                ktra_matkhau = true;
            if (ktra_tendangnhap == false || ktra_matkhau == false)
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không hợp lệ, xin vui lòng nhập lại!");
            else
            {
                KiemTraDangNhap.ktradangnhap = true;
                this.Close();
                FormMain f = new FormMain();
                f.Activate();
            }
        }

        private void txt_TenDangNhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.TenDangNhap = txt_TenDangNhap.Text;
                DataTable dt = TaiKhoanDAO.SelectTaiKhoanByTenDangNhap(tk);
                if (dt != null && dt.Rows.Count > 0)
                {
                    ktra_tendangnhap = true;
                    txt_MatKhau.Select();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập chưa có, vui lòng đăng ký tài khoản!");
                    ktra_tendangnhap = false;
                }
            }
        }

        private void txt_MatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (txt_TenDangNhap.Text == null)
                    MessageBox.Show("Vui lòng nhập tên đăng nhập trước!");
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.TenDangNhap = txt_TenDangNhap.Text;
                DataTable dt = TaiKhoanDAO.SelectTaiKhoanByTenDangNhap(tk);
                if (dt != null && dt.Rows.Count > 0)
                    tk.MatKhau = Convert.ToString(dt.Rows[0]["MatKhau"]);
                if (tk.MatKhau == txt_MatKhau.Text)
                {
                    KiemTraDangNhap.ktradangnhap = true;
                    this.Close();
                    FormMain f = new FormMain();
                    f.FormMain_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không hợp lệ, xin vui lòng nhập lại!");
                    ktra_matkhau = false;
                }
            }
        }

        private void btn_DangKyTaiKhoan_Click(object sender, EventArgs e)
        {
            DangKyTaiKhoan frmDangKyTaiKhoan = new DangKyTaiKhoan();
            frmDangKyTaiKhoan.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có thực sự muốn thoát không?",
              "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
