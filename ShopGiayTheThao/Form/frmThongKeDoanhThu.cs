using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COMExcel = Microsoft.Office.Interop.Excel;
using ShopGiayTheThao.Class;

namespace ShopGiayTheThao.Form
{
    public partial class frmThongKeDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        #region --VARIABLES--

        DataTable dt;
        string sql = "";

        List<HoaDon_search> l_HD_search = new List<HoaDon_search>();
        public class HoaDon_search
        {
            public string MaHoaDon { get; set; }
            public string TenNhanVien { get; set; }
            public string TenKhachHang { get; set; }
            public string NgayBan { get; set; }
            public string TongTien { get; set; }
        }

        List<CTHD_search> l_CTHD_search = new List<CTHD_search>();
        public class CTHD_search
        {
            public string MaSanPham { get; set; }
            public string TenSanPham { get; set; }
            public string SoLuong { get; set; }
            public string DonGia { get; set; }
            public string GiamGia { get; set; }
            public string ThanhTien { get; set; }
        }
        #endregion

        #region --EVENTS--
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }
        #endregion

        #region -BUTTONS--
        private void button1_Click(object sender, EventArgs e)
        {
            dtp_datefrom.Value = DateTime.Now;
            dtp_dateto.Value = DateTime.Now;
            gc_DoanhThu.DataSource = "";
        }

        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            sql = "EXEC dbo.sp_ThongKeDoanhThu @Datefrom = '" + dtp_datefrom.Value.ToString("yyyy/MM/dd") + "',@Dateto = '" + dtp_dateto.Value.ToString("yyyy/MM/dd") + "'";
            dt = Class.Functions.GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                l_HD_search.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    l_HD_search.Add(new HoaDon_search()
                    {
                        MaHoaDon = item["MaHoaDon"].ToString(),
                        TenNhanVien = item["TenNhanVien"].ToString(),
                        TenKhachHang = item["TenKhachHang"].ToString(),
                        NgayBan = item["NgayBan"].ToString(),
                        TongTien = item["TongTien"].ToString()
                    });
                }

                gc_DoanhThu.DataSource = l_HD_search;
                gc_DoanhThu.RefreshDataSource();
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào được tìm thấy ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

       

     

       

       

       
    }
}