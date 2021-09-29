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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {

        #region --VARIABLES--

        DataTable dt;
        string sql;
        string tenkh_tmp, sdt_tmp;

        List<KhachHang> L_KhachHang = new List<KhachHang>();
        public class KhachHang
        {
            public string MaKhachHang { get; set; }
            public string TenKhachHang { get; set; }
            public string DiaChi { get; set; }
            public string DienThoai { get; set; }
        }

        #endregion

        #region --EVENTS--

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
            btn_Luu.Enabled = false;
            btn_CN.Enabled = false;
        }

        private void gv_KhachHang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btn_Luu.Enabled = false;
            btn_CN.Enabled = false;

            txt_MaKH.ReadOnly = true; 
            txt_TenKH.ReadOnly = true;
            txt_DiaChi.ReadOnly = true;
            txt_DT.ReadOnly = true;

            txt_MaKH.Text = gv_KhachHang.GetRowCellValue(gv_KhachHang.FocusedRowHandle, "MaKhachHang").ToString();
            txt_TenKH.Text = gv_KhachHang.GetRowCellValue(gv_KhachHang.FocusedRowHandle, "TenKhachHang").ToString();
            txt_DiaChi.Text = gv_KhachHang.GetRowCellValue(gv_KhachHang.FocusedRowHandle, "DiaChi").ToString();
            txt_DT.Text = gv_KhachHang.GetRowCellValue(gv_KhachHang.FocusedRowHandle, "DienThoai").ToString();

            tenkh_tmp = txt_TenKH.Text;
            sdt_tmp = txt_DT.Text;
        }

        private void txt_DT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BE_del_Thuonghieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xác nhận xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                string ID = gv_KhachHang.GetRowCellValue(gv_KhachHang.FocusedRowHandle, "MaKhachHang").ToString();
                sql = "EXEC dbo.sp_XoaKH @maKH =" + ID;
                Class.Functions.RunSQL(sql);
                MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKH();
            }
            catch (Exception s)
            {

                MessageBox.Show("Lỗi xóa: " + s.ToString());
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.F1 && btn_Them.Enabled) 
            {
                btn_Them_Click(btn_Them, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.F2 && btn_Luu.Enabled) 
            {
                btn_Luu_Click(btn_Luu, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.F3 && btn_Sua.Enabled) 
            {
                btn_Sua_Click(btn_Sua, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.F4 && btn_CN.Enabled )
            {
                btn_CN_Click(btn_CN, EventArgs.Empty);
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

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_DiaChi.Text = "";
            txt_DT.Text = "";

            txt_TenKH.ReadOnly = false;
            txt_DiaChi.ReadOnly = false;
            txt_DT.ReadOnly = false;

            btn_Luu.Enabled = true;
            btn_CN.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txt_TenKH.ReadOnly = false;
            txt_DiaChi.ReadOnly = false;
            txt_DT.ReadOnly = false;

            btn_CN.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void btn_CN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_MaKH.Text))
                {
                    MessageBox.Show("Chọn dòng dữ liệu để cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(txt_TenKH.Text)) 
                {
                    MessageBox.Show("Tên Khách Hàng không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TenKH.Text = tenkh_tmp;
                    txt_TenKH.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_DT.Text) || (txt_DT.Text.Length < 10 || txt_DT.Text.Length > 11))
                {
                    MessageBox.Show("SDT không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_DT.Text = sdt_tmp;
                    txt_DT.Focus();
                    return;
                }

                sql = "EXEC dbo.sp_CapNhatKH @makh ="+txt_MaKH.Text+ ",@tenkh = N'" + txt_TenKH.Text + "',@diachi = N'" + txt_DiaChi.Text + "',@dienthoai = '" + txt_DT.Text + "'";
                Class.Functions.RunSQL(sql);
                MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");

                txt_MaKH.Text = "";
                txt_TenKH.Text = "";
                txt_DiaChi.Text = "";
                txt_DT.Text = "";

                txt_TenKH.ReadOnly = true;
                txt_DiaChi.ReadOnly = true;
                txt_DT.ReadOnly = true;

                LoadKH();



            }
            catch (Exception s)
            {

                MessageBox.Show("Lỗi cập nhật :"+ s.ToString());
            }
          
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_TenKH.Text)) 
                {
                    MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TenKH.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_DT.Text)) 
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
                MessageBox.Show("Lưu Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_MaKH.Text = "";
                txt_TenKH.Text = "";
                txt_DiaChi.Text = "";
                txt_DT.Text = "";
              

                LoadKH();
               

            }
            catch (Exception s)
            {

                MessageBox.Show("Lỗi lưu : " + s.ToString());

            }
        }

        #endregion

        #region --FUNCTIONS--

        public void LoadKH()
        {
            sql = "EXEC dbo.sp_LoadKhachHang";
            dt = Class.Functions.GetDataToTable(sql);
            if (dt.Rows.Count > 0)
            {
                L_KhachHang.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    L_KhachHang.Add(new KhachHang()
                    {
                        MaKhachHang = item["MaKhachHang"].ToString(),
                        TenKhachHang = item["TenKhachHang"].ToString(),
                        DiaChi = item["DiaChi"].ToString(),
                        DienThoai = item["DienThoai"].ToString()
                    });
                };
                gc_KhachHang.DataSource = L_KhachHang;
                gc_KhachHang.RefreshDataSource();
            }
        }

        #endregion

    }
}