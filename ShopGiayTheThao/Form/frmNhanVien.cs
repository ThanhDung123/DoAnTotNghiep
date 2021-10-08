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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {

        #region --VARIABLES--

        DataTable dt;
        string sql;
        string gt;
        string tennv_tmp, sdt_tmp;

        List<NhanVien> l_NV = new List<NhanVien>();
        public class NhanVien
        {
            public string MaNhanVien { get; set; }
            public string TenNhanVien { get; set; }
            public string GioiTinh { get; set; }
            public string DiaChi { get; set; }
            public string DienThoai { get; set; }
            public string NgaySinh { get; set; }
        }

        #endregion

        #region --EVENTS--

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadDataNV();
            btn_Luu.Enabled = false;
            btn_CN.Enabled = false;

        }

        private void gv_NhanVien_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btn_Luu.Enabled = false;
            btn_CN.Enabled = false;

            txt_MaNV.Text = gv_NhanVien.GetRowCellValue(gv_NhanVien.FocusedRowHandle, "MaNhanVien").ToString();
            txt_TenNV.Text = gv_NhanVien.GetRowCellValue(gv_NhanVien.FocusedRowHandle, "TenNhanVien").ToString();
            txt_DT.Text = gv_NhanVien.GetRowCellValue(gv_NhanVien.FocusedRowHandle, "DienThoai").ToString();
            txt_DiaChi.Text = gv_NhanVien.GetRowCellValue(gv_NhanVien.FocusedRowHandle, "DiaChi").ToString();
            dtp_NgaySinh.Text = gv_NhanVien.GetRowCellValue(gv_NhanVien.FocusedRowHandle, "NgaySinh").ToString();
            if ((gv_NhanVien.GetRowCellValue(gv_NhanVien.FocusedRowHandle, "GioiTinh").ToString()) == "Nam")
            {
                rdbs_nam.Checked = true;
                rdbs_nam.Enabled = false;
            }
            else
            {
                rdb_nu.Checked = true;
                rdb_nu.Enabled = false;
            }

            ReadOnly();

            tennv_tmp = txt_TenNV.Text;
            sdt_tmp = txt_DT.Text;


        }

        private void txt_DT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rdbs_nam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbs_nam.Checked == true) gt = rdbs_nam.Text; else gt = rdb_nu.Text;
        }

        private void BE_del_Thuonghieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xác nhận xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                string ID = gv_NhanVien.GetRowCellValue(gv_NhanVien.FocusedRowHandle, "MaNhanVien").ToString();
                sql = "EXEC dbo.sp_XoaNV @maNV =" + ID;
                Class.Functions.RunSQL(sql);
                MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataNV();
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

            if (keyData == Keys.F4 && btn_CN.Enabled)
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
            btn_CN.Enabled = false;
            btn_Luu.Enabled = true;
            Reset();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txt_MaNV.ReadOnly = true;
            txt_TenNV.ReadOnly = false;
            txt_DiaChi.ReadOnly = false;
            txt_DT.ReadOnly = false;
            dtp_NgaySinh.Enabled = true;
            rdbs_nam.Enabled = true;
            rdb_nu.Enabled = true;

            btn_CN.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string gt;
                if (rdbs_nam.Checked == true) gt = rdb_nu.Text; else gt = rdbs_nam.Text;

                if (string.IsNullOrEmpty(txt_TenNV.Text))
                {
                    MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TenNV.Focus();
                    return;
                }
                if (dtp_NgaySinh.Value > DateTime.Now)
                {
                    MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(txt_DT.Text))
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TenNV.Focus();
                    return;
                }
                sql = "EXEC dbo.CheckTrungTen @type = 3,@ten = N'" + txt_DT.Text + "'";
                dt = Class.Functions.GetDataToTable(sql);
                if (dt.Rows[0]["SL"].ToString().Equals("0"))
                {
                    sql = "EXEC dbo.sp_ThemNhanVien @tenNV = N'" + txt_TenNV.Text + "',@DiaChi = N'" + txt_DiaChi.Text + "',@DT = '" + txt_DT.Text + "', @GioiTinh = N'" + gt + "',@NgaySinh = '" + dtp_NgaySinh.Value.ToString("yyyy/MM/dd") + "'";
                    Class.Functions.RunSQL(sql);
                    MessageBox.Show("Lưu Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_TenNV.Text = "";
                    txt_DiaChi.Text = "";
                    txt_DT.Text = "";
                    txt_MaNV.Text = "";
                    ReadOnly();

                    loadDataNV();
                }
                else
                {
                    MessageBox.Show("Nhân Viên  này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception s)
            {

                MessageBox.Show("Lỗi lưu : " + s.ToString());
            }
        }

        private void btn_CN_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txt_MaNV.Text))
            {
                MessageBox.Show("Chọn dòng dữ liệu để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenNV.Focus();
                return;
            }
            if (dtp_NgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txt_TenNV.Text))
            {
                MessageBox.Show("Tên Nhân Viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenNV.Text = tennv_tmp;
                txt_TenNV.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_DT.Text) || (txt_DT.Text.Length < 10 || txt_DT.Text.Length > 11))
            {
                MessageBox.Show("SDT không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_DT.Text = sdt_tmp;
                txt_DT.Focus();
                return;
            }

            sql = "EXEC dbo.sp_CapNhatNV @MaNV=" + txt_MaNV.Text + ",@tenNV = N'" + txt_TenNV.Text + "',@DiaChi = N'" + txt_DiaChi.Text + "',@DienThoai = '" + txt_DT.Text + "', @GT = N'" + gt + "',@NgaySinh = '" + dtp_NgaySinh.Value.ToString("yyyy/MM/dd") + "'";
            Class.Functions.RunSQL(sql);
            MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_TenNV.Text = "";
            txt_DiaChi.Text = "";
            txt_DT.Text = "";
            txt_MaNV.Text = "";
            ReadOnly();

            loadDataNV();
        }

        #endregion

        #region --FUNCTIONS--

        private void ReadOnly()
        {
            txt_MaNV.ReadOnly = true;
            txt_TenNV.ReadOnly = true;
            txt_DiaChi.ReadOnly = true;
            txt_DT.ReadOnly = true;
            dtp_NgaySinh.Enabled = false;
        }

        private void Reset()
        {
            txt_TenNV.Text = "";
            txt_DiaChi.Text = "";
            txt_DT.Text = "";
            txt_MaNV.Text = "";
            dtp_NgaySinh.Value = DateTime.Now;
            rdbs_nam.Enabled = true;
            rdb_nu.Enabled = true;
            rdbs_nam.Checked = false;
            rdb_nu.Checked = false;

            txt_MaNV.ReadOnly = true;
            txt_TenNV.ReadOnly = false;
            txt_DiaChi.ReadOnly = false;
            txt_DT.ReadOnly = false;
            dtp_NgaySinh.Enabled = true;
        }

        private void loadDataNV()
        {
            sql = "EXEC dbo.sp_LoadNhanVien";
            dt = Class.Functions.GetDataToTable(sql);
            if (dt.Rows.Count > 0)
            {
                l_NV.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    l_NV.Add(new NhanVien()
                    {
                        MaNhanVien = item["MaNhanVien"].ToString(),
                        TenNhanVien = item["TenNhanVien"].ToString(),
                        GioiTinh = item["GioiTinh"].ToString(),
                        NgaySinh = item["NgaySinh"].ToString(),
                        DiaChi = item["DiaChi"].ToString(),
                        DienThoai = item["DienThoai"].ToString(),
                    });
                };
                gc_NhanVien.DataSource = l_NV;
                gc_NhanVien.RefreshDataSource();
            }
        }
        #endregion


    }
}