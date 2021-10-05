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
    public partial class frmThongTinCaNhan : DevExpress.XtraEditors.XtraForm
    {
        #region --VARIABLES--

        string sql;
        DataTable dt;
        string strNhan, strNhan2;
        string MaNV, taikhoan;

        #endregion

        #region --EVENTS--

        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            load_ThongTin_CaNhan();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            if (keyData == Keys.F1)
            {
                btn_CNMK_Click(btn_CNMK, EventArgs.Empty);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region --BUTTONS--

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            frmMENU f = new frmMENU();
            this.Hide();
            f.ShowDialog();
        }
        private void btn_CNMK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_MK.Text))
                {
                    MessageBox.Show("Nhập mật khẩu cũ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrEmpty(txt_MK_moi.Text))
                {
                    MessageBox.Show("Nhập mật khẩu mới !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrEmpty(txt_nhap_lai_MK.Text))
                {
                    MessageBox.Show("Nhập lại mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!txt_nhap_lai_MK.Text.Equals(txt_MK_moi.Text))
                {
                    MessageBox.Show("Mật khẩu nhập lại không trùng khớp với mật khẩu mới !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                #region --Mã hóa MK--

                MD5 mh = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txt_MK.Text);
                byte[] hash = mh.ComputeHash(inputBytes);
                StringBuilder matkhaucu = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    matkhaucu.Append(hash[i].ToString("X2"));
                }

                MD5 mhh = MD5.Create();
                byte[] inputBytess = System.Text.Encoding.ASCII.GetBytes(txt_MK_moi.Text);
                byte[] hashh = mhh.ComputeHash(inputBytess);
                StringBuilder matkhaumoi = new StringBuilder();

                for (int i = 0; i < hashh.Length; i++)
                {
                    matkhaumoi.Append(hashh[i].ToString("X2"));
                }

                #endregion

                sql = "EXEC dbo.sp_CapNhat_MK @tenTK = '" + txt_taikhoan.Text + "', @matkhau = '" + matkhaucu + "', @matkhaumoi = '" + matkhaumoi + "'";
                dt = Class.Functions.GetDataToTable(sql);

                if (dt.Rows.Count > 0 && dt.Rows[0]["result"].ToString().Equals("1"))
                {
                    MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_MK.Text = "";
                    txt_nhap_lai_MK.Text = "";
                    txt_MK_moi.Text = "";
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không trùng khớp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi :  " + ex.ToString(), "Thông báo");
            }
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region --FUNCTIONS--
       
        void load_ThongTin_CaNhan()
        {
            txt_taikhoan.Text = taikhoan;

            sql = "EXEC dbo.sp_Load_thongtin_canhan @manv = '"+MaNV+"'";
            dt = Class.Functions.GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    txt_maNV.Text = item["MaNhanVien"].ToString();
                    txt_TenNV.Text = item["TenNhanVien"].ToString();
                    txt_NgaySinh.Text = item["NgaySinh"].ToString();
                    txt_DiaChi.Text = item["DiaChi"].ToString();
                    txt_DT.Text = item["DienThoai"].ToString();
                    txt_GT.Text = item["GioiTinh"].ToString();

                }
            }

        }

        public frmThongTinCaNhan(string giatrinhan, string giatrinhan2) : this()
        {
            strNhan = giatrinhan;
            MaNV = strNhan;

            strNhan2 = giatrinhan2;
            taikhoan = strNhan2;

        }

        #endregion

     
   

      
    
    }
}