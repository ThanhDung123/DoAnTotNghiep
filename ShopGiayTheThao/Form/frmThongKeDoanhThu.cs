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
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

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

        private void btn_Xuatexel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_thongke.RowCount == 0)
                {
                    MessageBox.Show("Chưa có thông tin ", "Thông báo");
                    return;
                }
                SaveFileDialog saveFile = new SaveFileDialog
                {
                    InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments),
                    Filter = @"(*.XLSX)|*.xlsx",
                    FileName = "ThongKeDoanhThu"
                };

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    using (var package = new ExcelPackage())
                    {
                        ExcelWorkbook workBook = package.Workbook;
                        if (workBook != null)
                         {
                            #region set header
                            ExcelWorksheet curentWorkSheet = workBook.Worksheets.Add("DATA");
                            curentWorkSheet.SelectedRange["A1:F900"].Clear();

                            var row1 = curentWorkSheet.SelectedRange["A1:F1"];
                            row1.Merge = true;
                            row1.Value = "THỐNG KÊ DOANH THU";
                            row1.Style.Font.Size = 14;
                            row1.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            row1.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                            curentWorkSheet.Cells[2, 1].Value = "Mã hóa đơn";
                            curentWorkSheet.Cells[2, 2].Value = "Tên nhân viên";
                            curentWorkSheet.Cells[2, 3].Value = "Khách hàng";
                            curentWorkSheet.Cells[2, 4].Value = "Ngày Bán";
                            curentWorkSheet.Cells[2, 5].Value = "Tổng Tiền";

                            curentWorkSheet.SelectedRange["A2:F2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            #endregion

                            #region Style
                            //broder all
                            var row = curentWorkSheet.SelectedRange["A2:E2"];
                            row.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                            row.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            row.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                            row.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                            row.AutoFitColumns();

                            curentWorkSheet.SelectedRange["A2:E2"].Style.Font.Bold = true;
                            #endregion

                            #region Content
                            int start = 3;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                curentWorkSheet.Cells[start + i, 1].Value = dt.Rows[i]["MaHoaDon"].ToString();
                                curentWorkSheet.Cells[start + i, 2].Value = dt.Rows[i]["TenNhanVien"].ToString();
                                curentWorkSheet.Cells[start + i, 3].Value = dt.Rows[i]["TenKhachHang"].ToString();
                                curentWorkSheet.Cells[start + i, 4].Value = dt.Rows[i]["NgayBan"].ToString();
                                curentWorkSheet.Cells[start + i, 5].Value = dt.Rows[i]["TongTien"].ToString();
                            }
                            #endregion
                            var newFile = new FileInfo(saveFile.FileName);
                            package.SaveAs(newFile);
                        }
                    }
                   
                   MessageBox.Show("Xuất thành công ", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Xuất Execl", "Thông báo");
            }
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.F1 && btn_Thongke.Enabled)
            {
                btn_Thongke_Click(btn_Thongke, EventArgs.Empty);
                return true;
            }
 
            if (keyData == Keys.F2 && btn_Xuatexel.Enabled)
            {
                btn_Xuatexel_Click(btn_Xuatexel, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.F3 && button1.Enabled)
            {
                button1_Click(button1, EventArgs.Empty);
                return true;
            }

           

            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

     

       

       

       
    }
}