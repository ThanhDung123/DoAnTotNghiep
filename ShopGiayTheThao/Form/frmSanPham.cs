using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace ShopGiayTheThao.Form
{
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {


        #region --VARIABLES--

        string sql;
        DataTable dt;
        string base64_image;

        List<SanPham> l_sanpham = new List<SanPham>();
        public class SanPham
        {
            public string MaSanPham { get; set; }
            public string TenSanPham { get; set; }
            public string TenThuongHieu { get; set; }
            public string SoLuong { get; set; }
            public string DonGiaNhap { get; set; }
            public string DonGiaBan { get; set; }
            public string Anh { get; set; }
            public string GhiChu { get; set; }
        }

        #endregion

        #region --EVENTS--

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            btn_Luu.Enabled = false;
            btn_CN.Enabled = false;
            cbo_MaTH.Enabled = false;
            btn_them_anh.Enabled = false;
            txt_Anh.ReadOnly = true;
            loadSP();
            loadTH();
        }

        private void gv_SanPham_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
            ptb_sp.Visible = true;

            txt_MaSP.Text = gv_SanPham.GetRowCellValue(gv_SanPham.FocusedRowHandle, "MaSanPham").ToString();
            txt_TenSP.Text = gv_SanPham.GetRowCellValue(gv_SanPham.FocusedRowHandle, "TenSanPham").ToString();
            txt_SL.Text = gv_SanPham.GetRowCellValue(gv_SanPham.FocusedRowHandle, "SoLuong").ToString();
            txt_DonGiaNhap.Text = gv_SanPham.GetRowCellValue(gv_SanPham.FocusedRowHandle, "DonGiaNhap").ToString();
            txt_DonGiaBan.Text = gv_SanPham.GetRowCellValue(gv_SanPham.FocusedRowHandle, "DonGiaBan").ToString();
            txt_Anh.Text = gv_SanPham.GetRowCellValue(gv_SanPham.FocusedRowHandle, "Anh").ToString();
            txt_GhiChu.Text = gv_SanPham.GetRowCellValue(gv_SanPham.FocusedRowHandle, "GhiChu").ToString();
            cbo_MaTH.Text = gv_SanPham.GetRowCellValue(gv_SanPham.FocusedRowHandle, "TenThuongHieu").ToString();
            ptb_sp.Image = Base64ToImage(gv_SanPham.GetRowCellValue(gv_SanPham.FocusedRowHandle, "Anh").ToString());
            base64_image = gv_SanPham.GetRowCellValue(gv_SanPham.FocusedRowHandle, "Anh").ToString();

            txt_TenSP.ReadOnly = true;
            txt_SL.ReadOnly = true;
            txt_DonGiaBan.ReadOnly = true;
            txt_DonGiaNhap.ReadOnly = true;
            txt_GhiChu.ReadOnly = true;
            txt_MaSP.ReadOnly = true;
            txt_Anh.ReadOnly = true;
            cbo_MaTH.Enabled = false;

            btn_Luu.Enabled = false;
            btn_Sua.Enabled = true;
            btn_them_anh.Enabled = false;
            }
            catch (Exception)
            {
                
              
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
                string ID = gv_SanPham.GetRowCellValue(gv_SanPham.FocusedRowHandle, "MaSanPham").ToString();
                sql = "EXEC dbo.sp_XoaSP @maSP =" + ID;
                Class.Functions.RunSQL(sql);
                MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_TenSP.ReadOnly = true;
                txt_SL.ReadOnly = true;
                txt_DonGiaBan.ReadOnly = true;
                txt_DonGiaNhap.ReadOnly = true;
                txt_GhiChu.ReadOnly = true;
                txt_MaSP.ReadOnly = true;
                txt_Anh.ReadOnly = true;
                cbo_MaTH.Enabled = false;

                txt_MaSP.Text = "";
                txt_TenSP.Text = "";
                txt_SL.Text = "";
                txt_DonGiaNhap.Text = "";
                txt_DonGiaBan.Text = "";
                txt_GhiChu.Text = "";
                txt_Anh.Text = "";

                loadSP();

            }
            catch (Exception s)
            {

                MessageBox.Show("Lỗi xóa: " + s.ToString());
            }
        }

        private void txt_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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

        #region --FUNCTIONS--

        void loadSP()
        {
            sql = "EXEC dbo.sp_LoadSanPham";
            dt = Class.Functions.GetDataToTable(sql);
            if (dt.Rows.Count > 0)
            {
                l_sanpham.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    l_sanpham.Add(new SanPham()
                    {
                        MaSanPham = item["MaSanPham"].ToString(),
                        TenSanPham = item["TenSanPham"].ToString(),
                        TenThuongHieu = item["TenThuongHieu"].ToString(),
                        SoLuong = item["SoLuong"].ToString(),
                        DonGiaNhap = item["DonGiaNhap"].ToString(),
                        DonGiaBan = item["DonGiaBan"].ToString(),
                        Anh = item["Anh"].ToString(),
                        GhiChu = item["GhiChu"].ToString()

                    });
                }
                gc_SanPham.DataSource = l_sanpham;
                gc_SanPham.RefreshDataSource();
            }
        }

        void loadTH()
        {
            sql = "EXEC dbo.sp_LoadThuongHieu";
            dt = Class.Functions.GetDataToTable(sql);
            if (dt.Rows.Count > 0)
            {
                cbo_MaTH.DataSource = dt;
                cbo_MaTH.DisplayMember = "TenThuongHieu";
                cbo_MaTH.ValueMember = "MaThuongHieu";
            }
            else
            {
                MessageBox.Show("Lỗi load");
            }
        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
        #endregion

        #region --BUTTONS--
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
            txt_MaSP.Text = "";
            txt_TenSP.Text = "";
            txt_SL.Text = "0";
            txt_DonGiaNhap.Text = "0";
            txt_DonGiaBan.Text = "0";
            txt_GhiChu.Text = "";
            txt_Anh.Text = "";
            btn_Sua.Enabled = false; 

            txt_TenSP.ReadOnly = false;
            txt_SL.ReadOnly = false;
            txt_DonGiaNhap.ReadOnly = false;
            txt_DonGiaBan.ReadOnly = false;
            txt_GhiChu.ReadOnly = false;
            cbo_MaTH.Enabled = true;
            btn_them_anh.Enabled = true;
            btn_Luu.Enabled = true;

            ptb_sp.Visible = false;
            }
            catch (Exception)
            {
                
               
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            try
            {
            txt_TenSP.ReadOnly = false;
            txt_SL.ReadOnly = false;
            txt_DonGiaNhap.ReadOnly = false;
            txt_DonGiaBan.ReadOnly = false;
            txt_GhiChu.ReadOnly = false;
            cbo_MaTH.Enabled = true;
            btn_them_anh.Enabled = true;
            btn_Luu.Enabled = false;
            btn_CN.Enabled = true;

            }
            catch (Exception)
            {
                
               
            }
        }

        private void btn_them_anh_Click(object sender, EventArgs e)
        {
            try
            {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.JPG)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                ptb_sp.Visible = true;
                ptb_sp.Image = Image.FromFile(dlgOpen.FileName);

                byte[] imagearr = System.IO.File.ReadAllBytes(dlgOpen.FileName);
                 base64_image = Convert.ToBase64String(imagearr);
            }
            }
            catch (Exception)
            {
                
               
            }
        }

        private void btn_CN_Click(object sender, EventArgs e)
        {
             try
            {
                if (string.IsNullOrEmpty(txt_TenSP.Text))
                {
                    MessageBox.Show("Tên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TenSP.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_SL.Text) || txt_SL.Text.Equals("0"))
                {
                    MessageBox.Show("Số Lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_SL.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_DonGiaNhap.Text) || txt_DonGiaNhap.Text.Equals("0"))
                {
                    MessageBox.Show("Đơn giá nhập phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_DonGiaNhap.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_DonGiaBan.Text) || txt_DonGiaBan.Text.Equals("0"))
                {
                    MessageBox.Show("Đơn giá bán phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_DonGiaBan.Focus();
                    return;
                }

                sql = "dbo.sp_CapNhatSP @maSP='" + txt_MaSP.Text + "',@tenSP = N'" + txt_TenSP.Text + "',@thuonghieu = N'" + cbo_MaTH.SelectedValue.ToString() + "', @SL =" + txt_SL.Text + ",@DonGiaNhap =" + txt_DonGiaNhap.Text + ", @DonGiaBan =" + txt_DonGiaBan.Text + ", @Anh = N'" + base64_image + "', @GhiChu = N'" + txt_GhiChu.Text + "'";
                Class.Functions.RunSQL(sql);
                MessageBox.Show("Lưu Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txt_TenSP.ReadOnly = true;
                txt_SL.ReadOnly = true;
                txt_DonGiaBan.ReadOnly = true;
                txt_DonGiaNhap.ReadOnly = true;
                txt_GhiChu.ReadOnly = true;
                txt_MaSP.ReadOnly = true;
                txt_Anh.ReadOnly = true;
                cbo_MaTH.Enabled = false;
                btn_them_anh.Enabled = false;
                btn_Sua.Enabled = false;
                btn_CN.Enabled = false;

                txt_MaSP.Text = "";
                txt_TenSP.Text = "";
                txt_SL.Text = "";
                txt_DonGiaNhap.Text = "";
                txt_DonGiaBan.Text = "";
                txt_GhiChu.Text = "";
                txt_Anh.Text = "";
                ptb_sp.Visible = false;

                loadSP();
            }
            catch (Exception s)
            {

                MessageBox.Show("Lỗi : " + s.ToString());
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_TenSP.Text))
                {
                    MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TenSP.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_SL.Text) || txt_SL.Text.Equals("0"))
                {
                    MessageBox.Show("Số Lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_SL.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_DonGiaNhap.Text) || txt_DonGiaNhap.Text.Equals("0"))
                {
                    MessageBox.Show("Đơn giá nhập phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_DonGiaNhap.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_DonGiaBan.Text) || txt_DonGiaBan.Text.Equals("0"))
                {
                    MessageBox.Show("Đơn giá bán phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_DonGiaBan.Focus();
                    return;
                }
                sql = "EXEC dbo.CheckTrungTen @type = 2,@ten = N'" + txt_TenSP.Text + "'";
                dt = Class.Functions.GetDataToTable(sql);

                if (dt.Rows[0]["SL"].ToString().Equals("0"))
                {
                    sql = "EXEC dbo.sp_ThemSP @tenSP = N'" + txt_TenSP.Text + "',@thuonghieu = N'" + cbo_MaTH.SelectedValue.ToString() + "', @SL =" + txt_SL.Text + ",@DonGiaNhap =" + txt_DonGiaNhap.Text + ", @DonGiaBan =" + txt_DonGiaBan.Text + ", @Anh = N'" + base64_image + "', @GhiChu = N'" + txt_GhiChu.Text + "'";
                    Class.Functions.RunSQL(sql);
                    MessageBox.Show("Lưu Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TenSP.ReadOnly = true;
                    txt_SL.ReadOnly = true;
                    txt_DonGiaBan.ReadOnly = true;
                    txt_DonGiaNhap.ReadOnly = true;
                    txt_GhiChu.ReadOnly = true;
                    txt_MaSP.ReadOnly = true;
                    txt_Anh.ReadOnly = true;
                    cbo_MaTH.Enabled = false;

                    txt_MaSP.Text = "";
                    txt_TenSP.Text = "";
                    txt_SL.Text = "";
                    txt_DonGiaNhap.Text = "";
                    txt_DonGiaBan.Text = "";
                    txt_GhiChu.Text = "";
                    txt_Anh.Text = "";
                    ptb_sp.Visible = false;
                    btn_Luu.Enabled = false;
                    btn_Sua.Enabled = false;
                    btn_them_anh.Enabled = false;
                    loadSP();
                }
                else
                {
                    MessageBox.Show("Sản Phẩm này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception s)
            {

                MessageBox.Show("Lỗi : " + s.ToString());
            }
        }
        #endregion

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            sql = "EXEC dbo.sp_TimKiem @ten = N'" + txt_timkiem.Text + "',@type =2";
            dt = Class.Functions.GetDataToTable(sql);
            if (dt.Rows.Count > 0)
            {
                l_sanpham.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    l_sanpham.Add(new SanPham()
                    {
                        MaSanPham = item["MaSanPham"].ToString(),
                        TenSanPham = item["TenSanPham"].ToString(),
                        TenThuongHieu = item["TenThuongHieu"].ToString(),
                        SoLuong = item["SoLuong"].ToString(),
                        DonGiaNhap = item["DonGiaNhap"].ToString(),
                        DonGiaBan = item["DonGiaBan"].ToString(),
                        Anh = item["Anh"].ToString(),
                        GhiChu = item["GhiChu"].ToString()

                    });
                }
                gc_SanPham.DataSource = l_sanpham;
                gc_SanPham.RefreshDataSource();
            }
        }

    }
}