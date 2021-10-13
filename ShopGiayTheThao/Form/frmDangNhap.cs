using System;
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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        #region --VARIABLES--

        string sql;
        DataTable dt;
        public delegate void delPassData(TextBox text);

        #endregion

        #region --EVENTS--

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }
        #endregion

        #region --BUTTONS--
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {

            try
            {
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

            sql = "EXEC dbo.sp_DangNhap @taikhoan = '" + txt_taikhoan.Text + "', @matkhau = '" + sb + "'";
            dt = Class.Functions.GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                frmMENU f = new frmMENU();
                delPassData del = new delPassData(f.funData);
                del(this.txt_taikhoan);

                this.Hide();
                f.ShowDialog();
            }
            else
                MessageBox.Show("Đăng nhập thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                
                throw;
            }

        }
        #endregion
        
    }
    
}