using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShopGiayTheThao.Report;

namespace ShopGiayTheThao.Form
{
    public partial class frmMENU : DevExpress.XtraEditors.XtraForm
    {

        #region --VARIABLES--

        string taikhoan = "";
        string MaNV = "";
        string sql;
        DataTable dt;
        int Loai_TK;

        #endregion

        #region --EVENTS--

        public frmMENU()
        {
            InitializeComponent();
        }

        private void frmMENU_Load(object sender, EventArgs e)
        {
            check_loai_tk();
            xtraTabControl1.SelectedTabPage = xtraTabPage4;
        }

        #endregion

        #region --BUTTONS--

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon(taikhoan);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_ThuongHieu_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {

            frmSanPham f = new frmSanPham();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_timkiemHD_Click(object sender, EventArgs e)
        {
            frmTimKiemHD f = new frmTimKiemHD();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_ThongTinCN_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan f = new frmThongTinCaNhan(MaNV, taikhoan);
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            this.Hide();
            f.ShowDialog();
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            frmMenu_LoaiBaoCao f = new frmMenu_LoaiBaoCao();
            f.ShowDialog();
        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan f = new frmThemTaiKhoan();
            f.ShowDialog();

        }

        #endregion

        #region --FUNCTIONS--

        public void funData(TextBox txtForm1)
        {
            taikhoan = txtForm1.Text;
        }

        void check_loai_tk()
        {
            sql = "EXEC dbo.Check_Loai_TK @tenTK = '" + taikhoan + "'";
            dt = Class.Functions.GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Loai_TK = int.Parse(item["LoaiTaiKhoan"].ToString());
                    MaNV = item["MaNhanVien"].ToString();

                }
            }
            if (!(Loai_TK == 0))
            {
                xtraTabPage2.PageVisible = false;
            }
        }

        #endregion

        private void Btn_ThongKe_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu f = new frmThongKeDoanhThu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

    }
}