using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ShopGiayTheThao.Form
{
    public partial class frmThemKH : DevExpress.XtraEditors.XtraForm
    {
        #region --VARIABLES--
        string sql;
        #endregion

        #region --BUTTONS--
        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_TenKH.Text))
                {
                    MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TenKH.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_DT.Text)&&(txt_DT.Text.Length < 10||txt_DT.Text.Length >13) )
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_DT.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_DiaChi.Text))
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_DT.Focus();
                    return;
                }

                sql = "EXEC dbo.sp_ThemKhachHang @tenkh = N'" + txt_TenKH.Text + "',@diachi = N'" + txt_DiaChi.Text + "',@dienthoai = '" + txt_DT.Text + "'";
                Class.Functions.RunSQL(sql);
                MessageBox.Show("Thêm khách hàng mới thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_TenKH.Text = "";
                txt_DiaChi.Text = "";
                txt_DT.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region --EVENTS--
        public frmThemKH()
        {
            InitializeComponent();
        }

        private void frmThemKH_Load(object sender, EventArgs e)
        {

        }

        private void txt_DT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.F1 && btn_ThemKH.Enabled)
            {
                btn_ThemKH_Click(btn_ThemKH, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion


    }
}