﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;

namespace ShopGiayTheThao.Form
{
    public partial class frmThemTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
       

        #region --VARIABLES--

        string sql;
        DataTable dt;

        #endregion

        #region --EVENTS--

        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTemTaiKhoan_Load(object sender, EventArgs e)
        {
            load_SLE_NV();
            load_loai_tk();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.F1 && btn_ThemTK.Enabled) 
            {
                btn_ThemTK_Click(btn_ThemTK, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region --BUTTONS--

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThemTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(SLE_nhanvien.Text))
                {
                    MessageBox.Show("Chưa chọn nhân viên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(txt_taikhoan.Text))
                {
                    MessageBox.Show("Tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(txt_matkhau.Text))
                {
                    MessageBox.Show("Mật khẩu không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!txt_matkhau.Text.Equals(txt_matkhau2.Text))
                {
                    MessageBox.Show("Mật khẩu không trùng khớp ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                #region --Mã hóa MK--

                MD5 mh = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txt_matkhau.Text);
                byte[] hash = mh.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }

                #endregion



                sql = "EXEC dbo.sp_ThemTaiKhoan @taikhoan = '" + txt_taikhoan.Text + "',@matkhau = '" + sb + "',@manhanvien = " + SLE_nhanvien.EditValue + " ,@loaitaikhoan = " + cbo_loaiTK.SelectedValue;
                dt = Class.Functions.GetDataToTable(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_taikhoan.Text = "";
                    txt_matkhau.Text = "";
                    txt_matkhau2.Text = "";
                    SLE_nhanvien.EditValue = "";
                    cbo_loaiTK.SelectedValue = 1;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_taikhoan.Focus();
                return;
            }



        }

        #endregion

        #region --FUNCTIONS--

        void load_SLE_NV()
        {
            sql = "EXEC dbo.sp_LoadNhanVien";
            dt = Class.Functions.GetDataToTable(sql);

            SLE_nhanvien.Properties.DataSource = dt;
            SLE_nhanvien.Properties.ValueMember = "MaNhanVien";
            SLE_nhanvien.Properties.DisplayMember = "TenNhanVien";
            SLE_nhanvien.Text = "";
        }

        void load_loai_tk()
        {
            DataTable dtt = new DataTable();
            dtt.Columns.Add("text", typeof(string));
            dtt.Columns.Add("value", typeof(int));
            dtt.Rows.Add("Nhân viên", 1);
            dtt.Rows.Add("Admin", 0);

            cbo_loaiTK.DataSource = dtt;
            cbo_loaiTK.DisplayMember = "text";
            cbo_loaiTK.ValueMember = "value";
        }

        #endregion

      

       
    }
}