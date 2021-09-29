using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.Data;
using System.IO;



namespace ShopGiayTheThao.Form
{
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
       

        #region --VARIABLES--

        StringWriter sw = new StringWriter();
        DataTable dt;
        string sql, TenSP;
        string param, taikhoan;
        string sl, masp;
        

        List<CTHD> l_CTHD = new List<CTHD>();
        public class CTHD
        {
            public string MaHoaDon { get; set; }
            public string MaSanPham { get; set; }
            public string TenSanPham { get; set; }
            public string SoLuong { get; set; }
            public string DonGia { get; set; }
            public string GiamGia { get; set; }
            public string ThanhTien { get; set; }
        }
        

        #endregion

        #region --EVENTS--

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            load_SLE_NV();
            load_SLE_TH();
            load_SLE_SP();
            load_MaKH();
        }

        private void SLE_ThuongHieu_EditValueChanged(object sender, EventArgs e)
        {
            load_SLE_SP();
        }

        private void SLE_MaKH_EditValueChanged(object sender, EventArgs e)
        {
            load_KH_Theo_MaKH();
        }

        private void txt_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SLE_SanPham_EditValueChanged(object sender, EventArgs e)
        {
            sql = "EXEC dbo.sp_Load_DonGia @maSP = '" + SLE_SanPham.EditValue + "'";
            dt = Class.Functions.GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    txt_DonGia.Text = item["DonGiaBan"].ToString();
                    TenSP = item["TenSanPham"].ToString();
                }
            }
        }

        private void txt_SL_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SL.Text))
            {
                txt_ThanhTien.Text = "";
            }

            //if (string.IsNullOrEmpty(SLE_SanPham.Text))
            //{
            //    MessageBox.Show("Chưa chọn sản phẩm ","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txt_SL.Text = "";
            //    txt_ThanhTien.Text = "";
            //    return;
            //}

            if (!string.IsNullOrEmpty(txt_SL.Text))
            {
                sql = "EXEC dbo.sp_Check_SL @MA_SP = " + SLE_SanPham.EditValue + ", @SL =" + txt_SL.Text;
                dt = Class.Functions.GetDataToTable(sql);

                if (dt.Rows[0]["result"].ToString().Equals("1"))
                {
                    double tong = 0;
                    double SL, DonGia, GiamGia;

                    if (txt_SL.Text == "")
                        SL = 0;
                    else
                        SL = Convert.ToDouble(txt_SL.Text);

                    if (txt_GiamGia.Text == "")
                        GiamGia = 0;
                    else
                        GiamGia = Convert.ToDouble(txt_GiamGia.Text);

                    if (txt_DonGia.Text == "")
                        DonGia = 0;
                    else
                        DonGia = Convert.ToDouble(txt_DonGia.Text);

                    tong = SL * DonGia - SL * DonGia * GiamGia / 100;
                    txt_ThanhTien.Text = tong.ToString();
                }

                if (dt.Rows[0]["result"].ToString().Equals("0"))
                {
                    MessageBox.Show("Số lượng trong kho chỉ còn lại :" + dt.Rows[0]["soluong"], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_SL.Focus();
                }
            }
           
           
        }

        private void txt_GiamGia_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SLE_SanPham.Text))
            {
                MessageBox.Show("Chưa chọn sản phẩm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(txt_SL.Text)) 
            {
                MessageBox.Show("Chưa nhập số lượng  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SL.Focus();
                return;
            }
            double tong = 0;

            double SL, DonGia, GiamGia;

            if (txt_SL.Text == "")
                SL = 0;
            else
                SL = Convert.ToDouble(txt_SL.Text);

            if (txt_GiamGia.Text == "")
                GiamGia = 0;
            else
                GiamGia = Convert.ToDouble(txt_GiamGia.Text);

            if (txt_DonGia.Text == "")
                DonGia = 0;
            else
                DonGia = Convert.ToDouble(txt_DonGia.Text);

            tong = SL * DonGia - SL * DonGia * GiamGia / 100;
            txt_ThanhTien.Text = tong.ToString();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.F1 && btn_TaoMoi.Enabled)
            {
                btn_TaoMoi_Click(btn_TaoMoi, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.F2 && btn_them_sp_HD.Enabled)
            {
                btn_them_sp_HD_Click(btn_them_sp_HD, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.F3 && btn_ThanhToan.Enabled)
            {
                btn_ThanhToan_Click(btn_ThanhToan, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.F4 && btn_CN_CTHD.Enabled)
            {
                btn_CN_CTHD_Click(btn_CN_CTHD, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.F5 && btn_reset.Enabled)
            {
                btn_reset_Click(btn_reset, EventArgs.Empty);
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

        private void btn_Thoat_search_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_themkh_Click(object sender, EventArgs e)
        {
            frmThemKH f = new frmThemKH();
            f.ShowDialog();
            load_MaKH();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_MaHD.Text = "";
            dtp_NgayBan.Value = DateTime.Now;
            SLE_MaKH.EditValue = "";
            txt_TenKH.Text = "";
            txt_DiaChi.Text = "";
            txt_DT.Text = "";
            SLE_NhanVien.EditValue = "";

            SLE_ThuongHieu.EditValue = "";
            txt_SL.Text = "";
            SLE_SanPham.EditValue = "";
            txt_GiamGia.Text = "";
            txt_DonGia.Text = "";
            txt_ThanhTien.Text = "";

            l_CTHD.Clear();
            gc_CTHoaDon.DataSource = "";

            dtp_NgayBan.Enabled = true;
            SLE_MaKH.Enabled = true;
            SLE_NhanVien.Enabled = true;
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SLE_NhanVien.Text))
            {
                MessageBox.Show("Nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(SLE_MaKH.Text)) 
            {
                MessageBox.Show("Khách Hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txt_MaHD.Text =Class.Functions.CreateKey("HDB");

            sql = "EXEC dbo.sp_ThemHoaDon @maHD = '"+txt_MaHD.Text+"', @maNV = '"+SLE_NhanVien.EditValue+"', @ngayban = '"+dtp_NgayBan.Value.ToString("yyyy/MM/dd")+"', @maKH = '"+SLE_MaKH.EditValue+"', @TongTien = 0.0";
            Class.Functions.RunSQL(sql);

            dtp_NgayBan.Enabled = false;
            SLE_MaKH.Enabled = false;
            SLE_NhanVien.Enabled = false;
        }

        private void btn_them_sp_HD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaHD.Text))
            {
                MessageBox.Show("Bạn chưa tạo hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(SLE_SanPham.EditValue.ToString()))
            {
                MessageBox.Show("Không có sản phẩm nào để thêm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txt_SL.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txt_GiamGia.Text))
            {
                txt_GiamGia.Text = "0";
            }

          
            l_CTHD.Add(new CTHD
            {
                MaHoaDon = txt_MaHD.Text,
                MaSanPham = SLE_SanPham.EditValue.ToString(),
                TenSanPham = TenSP,
                SoLuong = txt_SL.Text,
                DonGia = txt_DonGia.Text,
                GiamGia = txt_GiamGia.Text,
                ThanhTien = txt_ThanhTien.Text
            });

           
            gc_CTHoaDon.DataSource = l_CTHD;
            gc_CTHoaDon.RefreshDataSource();
            txt_GiamGia.Text = "";
            txt_SL.Text = "";
            txt_ThanhTien.Text = "";
            txt_GiamGia.Text = "";
            txt_DonGia.Text = "";
            SLE_ThuongHieu.EditValue = "";

           
        }

        private void BE_del_Thuonghieu_Click(object sender, EventArgs e)
        {
            l_CTHD.RemoveAt(gv_CTHoaDon.FocusedRowHandle);
            gc_CTHoaDon.RefreshDataSource();
        }

        private void btn_CN_CTHD_Click(object sender, EventArgs e)
        {
            if (SLE_SanPham.EditValue != null) 
            {
                btn_them_sp_HD_Click(btn_them_sp_HD, EventArgs.Empty);

                l_CTHD.RemoveAt(gv_CTHoaDon.FocusedRowHandle);
                gc_CTHoaDon.RefreshDataSource();
                MessageBox.Show("Cập nhật thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            MessageBox.Show("Không có sản phẩm nào để cập nhật ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            
        }

        private void BE_edit_CTHD_Click(object sender, EventArgs e)
        {
            txt_SL.Text = gv_CTHoaDon.GetRowCellValue(gv_CTHoaDon.FocusedRowHandle, "SoLuong").ToString();
            txt_GiamGia.Text = gv_CTHoaDon.GetRowCellValue(gv_CTHoaDon.FocusedRowHandle, "GiamGia").ToString();
            SLE_SanPham.EditValue = gv_CTHoaDon.GetRowCellValue(gv_CTHoaDon.FocusedRowHandle, "MaSanPham").ToString();
            txt_ThanhTien.Text = gv_CTHoaDon.GetRowCellValue(gv_CTHoaDon.FocusedRowHandle, "ThanhTien").ToString();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_CTHoaDon.RowCount == 0)
                {
                    MessageBox.Show("Không có sản phẩm để nào để thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("Xác nhận thanh toán đơn hàng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                DataTable t_Data = new DataTable("Data");

                t_Data.Columns.Add("MaHoaDon");
                t_Data.Columns.Add("MaSanPham");
                t_Data.Columns.Add("SoLuong");
                t_Data.Columns.Add("DonGia");
                t_Data.Columns.Add("GiamGia");
                t_Data.Columns.Add("ThanhTien");

                t_Data.Clear();
                foreach (var item in l_CTHD)
                {
                    t_Data.Rows.Add(item.MaHoaDon, item.MaSanPham, item.SoLuong, item.DonGia, item.GiamGia, item.ThanhTien);
                }

                sw = new StringWriter();
                t_Data.WriteXml(sw);
                string sData = sw.ToString();

                param = sData.ToString();

                sql = "EXEC dbo.sp_ThanhToan @table = N'"+param+"',@maHD = '"+txt_MaHD.Text+"'";
                dt = Class.Functions.GetDataToTable(sql);


                MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                #region --Cập Nhật Lại Số Lượng Kho--
                for (int i = 0; i < l_CTHD.Count; i++)
                {
                    sl = gv_CTHoaDon.GetRowCellValue( i,"SoLuong").ToString();
                    masp = gv_CTHoaDon.GetRowCellValue(i, "MaSanPham").ToString();
                    sql = "EXEC dbo.sp_CN_SL @soluong_mua = " + sl + ", @masp = " + masp;
                    Class.Functions.RunSQL(sql);
                }
                #endregion
               
                btn_reset_Click(btn_reset, EventArgs.Empty);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.ToString());
            }




        }

        private void btn_XuatHD_Click(object sender, EventArgs e)
        {
            frmTimKiemHD f = new frmTimKiemHD(taikhoan);
            f.ShowDialog();
        }

        #endregion

        #region --FUNCTIONS--

        void load_SLE_NV()
        {
            sql = "EXEC dbo.sp_LoadNhanVien";
            dt = Class.Functions.GetDataToTable(sql);

            SLE_NhanVien.Properties.DataSource = dt;
            SLE_NhanVien.Properties.ValueMember = "MaNhanVien";
            SLE_NhanVien.Properties.DisplayMember = "TenNhanVien";
            SLE_NhanVien.Text = "";
        }

        void load_SLE_TH()
        {
            sql = "EXEC dbo.sp_LoadThuongHieu";
            dt = Class.Functions.GetDataToTable(sql);

            SLE_ThuongHieu.Properties.DataSource = dt;
            SLE_ThuongHieu.Properties.ValueMember = "MaThuongHieu";
            SLE_ThuongHieu.Properties.DisplayMember = "TenThuongHieu";
            SLE_ThuongHieu.EditValue = "";
        }

        void load_SLE_SP()
        {

            sql = "EXEC dbo.sp_Load_SP_Theo_ThuongHieu @maTH = " + "'" +SLE_ThuongHieu.EditValue+ "'";
            dt = Class.Functions.GetDataToTable(sql);

            SLE_SanPham.Properties.DataSource = dt;
            SLE_SanPham.Properties.ValueMember = "MaSanPham";
            SLE_SanPham.Properties.DisplayMember = "TenSanPham";
            SLE_SanPham.Text = "";

        }

        void load_MaKH()
        {
            sql = "EXEC dbo.sp_LoadKhachHang";
            dt = Class.Functions.GetDataToTable(sql);

            SLE_MaKH.Properties.DataSource = dt;
            SLE_MaKH.Properties.ValueMember = "MaKhachHang";
            SLE_MaKH.Properties.DisplayMember = "MaKhachHang";
            SLE_MaKH.Text = "";
        }

        void load_KH_Theo_MaKH()
        {

            sql = "EXEC dbo.sp_Load_thongtin_KH @maKH = " + "'" + SLE_MaKH.EditValue + "'"; 
            dt = Class.Functions.GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    txt_TenKH.Text = item["TenKhachHang"].ToString();
                    txt_DiaChi.Text = item["DiaChi"].ToString();
                    txt_DT.Text = item["DienThoai"].ToString();

                }
             }

        }

        public frmHoaDon(string giatri) : this()
        {
            taikhoan = giatri;
        }

  
        #endregion

        

       

    }
}