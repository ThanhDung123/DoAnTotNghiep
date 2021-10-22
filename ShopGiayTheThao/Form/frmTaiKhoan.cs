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
    public partial class frmTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        #region variables
        DataTable dt;
        string sql;

        List<TaiKhoan> l_taikhoan = new List<TaiKhoan>();
        public class TaiKhoan
        {
            public string TenTaiKhoan { get; set; }
            public string MaNhanVien { get; set; }
            public string TenNhanVien { get; set; }
        }
        #endregion

        #region functions
        void loadTk()
        {
            try
            {
                sql = "EXEC dbo.sp_LoadTaiKhoan";
                dt = Class.Functions.GetDataToTable(sql);
                if (dt.Rows.Count > 0)
                {
                    l_taikhoan.Clear();
                    foreach (DataRow item in dt.Rows)
                    {
                        l_taikhoan.Add(new TaiKhoan()
                        {
                            TenTaiKhoan = item["TenTaiKhoan"].ToString(),
                            MaNhanVien = item["MaNhanVien"].ToString(),
                            TenNhanVien = item["TenNhanVien"].ToString()

                        });
                    }
                    gc_taikhoan.DataSource = l_taikhoan;
                    gc_taikhoan.RefreshDataSource();
                }
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region events

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            loadTk();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.F1 && btn_Them.Enabled)
            {
                btn_Them_Click(btn_Them, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void gv_taikhoan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txt_tk.Text = gv_taikhoan.GetRowCellValue(gv_taikhoan.FocusedRowHandle, "TenTaiKhoan").ToString();
                txt_MaNV.Text = gv_taikhoan.GetRowCellValue(gv_taikhoan.FocusedRowHandle, "MaNhanVien").ToString();
                txt_tenNV.Text = gv_taikhoan.GetRowCellValue(gv_taikhoan.FocusedRowHandle, "TenNhanVien").ToString();
            }
            catch (Exception)
            {


            }
        }
        #endregion

        #region buutons
        private void btn_Them_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan f = new frmThemTaiKhoan();
            f.ShowDialog();
            this.loadTk();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BE_del_Thuonghieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xác nhận xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                string ID = gv_taikhoan.GetRowCellValue(gv_taikhoan.FocusedRowHandle, "TenTaiKhoan").ToString();
                sql = "EXEC dbo.sp_XoaTaiKhoan @tentaikhoan =" + ID;
                Class.Functions.RunSQL(sql);
                MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tk.Text = "";
                txt_MaNV.Text = "";
                txt_tenNV.Text = "";
                loadTk();
            }
            catch (Exception s)
            {

                MessageBox.Show("Lỗi xóa: " + s.ToString());
            }
        }
        #endregion

       
    }
}