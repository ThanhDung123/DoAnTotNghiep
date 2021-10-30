using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace ShopGiayTheThao.Form
{
    public partial class frmBaoCaoSP : DevExpress.XtraEditors.XtraForm
    {
       

        #region VARIABLES
        string sql = "";
        DataTable dt;

        List<SanPham> l_sanpham = new List<SanPham>();
        public class SanPham
        {
            public string MaSanPham { get; set; }
            public string TenSanPham { get; set; }
        }
        #endregion

        #region FUNCTIONS

        void loadLoaiBC()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value", typeof(int));
            dt.Columns.Add("text",typeof(string));

            dt.Rows.Add(1, "Tất cả sản phẩm");
            dt.Rows.Add(2, "Sản phẩm sắp hết");
            dt.Rows.Add(3, "Sản phẩm bán trong tháng");

            SLE_LoaiBaoCao.Properties.DataSource = dt;
            SLE_LoaiBaoCao.Properties.DisplayMember = "text";
            SLE_LoaiBaoCao.Properties.ValueMember = "value";
            SLE_LoaiBaoCao.Text= "";
        }

        #endregion
      
        #region EVENTS
        public frmBaoCaoSP()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSP_Load(object sender, EventArgs e)
        {
            loadLoaiBC();
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
        #endregion

        #region BUTTONS
        private void button1_Click(object sender, EventArgs e)
        {
            SLE_LoaiBaoCao.Text = "";
            dtp_datefrom.Value = DateTime.Now;
            dtp_dateto.Value = DateTime.Now;
            gc_SanPham.DataSource = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            try
            {
                if (SLE_LoaiBaoCao.EditValue.Equals(3))
                {
                    sql = "EXEC dbo.sp_SPBantrongthang @datefrom = '" + dtp_datefrom.Value.ToString("yyyy/MM/dd") + "',@dateto = '" + dtp_dateto.Value.ToString("yyyy/MM/dd") + "'";
                    dt = Class.Functions.GetDataToTable(sql);
                    if (dt.Rows.Count > 0)
                    {
                        l_sanpham.Clear();
                        foreach (DataRow item in dt.Rows)
                        {
                            l_sanpham.Add(new SanPham()
                            {
                                MaSanPham = item["MaSanPham"].ToString(),
                                TenSanPham = item["TenSanPham"].ToString()
                            });
                        }
                        gc_SanPham.DataSource = l_sanpham;
                        gc_SanPham.RefreshDataSource();
                    }
                    else
                    {
                        MessageBox.Show("Không có thông tin nào được tìm thấy ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gc_SanPham.DataSource = "";
                        gc_SanPham.RefreshDataSource();
                    }
                }
                else
                {
                    sql = "EXEC dbo.[sp.BaoCaoSP] @type =" + SLE_LoaiBaoCao.EditValue;
                    dt = Class.Functions.GetDataToTable(sql);
                    if (dt.Rows.Count > 0)
                    {
                        l_sanpham.Clear();
                        foreach (DataRow item in dt.Rows)
                        {
                            l_sanpham.Add(new SanPham()
                            {
                                MaSanPham = item["MaSanPham"].ToString(),
                                TenSanPham = item["TenSanPham"].ToString()
                            });
                        }
                        gc_SanPham.DataSource = l_sanpham;
                        gc_SanPham.RefreshDataSource();
                    }
                    else
                    {
                        gc_SanPham.DataSource = "";
                        gc_SanPham.RefreshDataSource();
                        MessageBox.Show("Không có thông tin nào được tìm thấy ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception)
            {


            }
        }
        private void btn_Xuatexel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_SanPham.RowCount == 0)
                {
                    MessageBox.Show("Chưa có thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                SaveFileDialog saveFile = new SaveFileDialog
                {
                    InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments),
                    Filter = @"(*.XLSX)|*.xlsx",
                    FileName = "BaoCaoSP"
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

                            var row1 = curentWorkSheet.SelectedRange["A1:B1"];
                            row1.Merge = true;
                            row1.Value = "Báo Cáo Sản Phẩm";
                            row1.Style.Font.Size = 12;
                            row1.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            row1.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                            curentWorkSheet.Cells[2, 1].Value = "Mã sản phẩm";
                            curentWorkSheet.Cells[2, 2].Value = "Tên sản phẩm";

                            curentWorkSheet.SelectedRange["A2:F2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            #endregion

                            #region Style
                            //broder all
                            var row = curentWorkSheet.SelectedRange["A2:B2"];
                            row.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                            row.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            row.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                            row.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                            row.AutoFitColumns();

                            curentWorkSheet.SelectedRange["A2:B2"].Style.Font.Bold = true;
                            #endregion

                            #region Content
                            int start = 3;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                curentWorkSheet.Cells[start + i, 1].Value = dt.Rows[i]["MaSanPham"].ToString();
                                curentWorkSheet.Cells[start + i, 2].Value = dt.Rows[i]["TenSanPham"].ToString();
                            }
                            #endregion
                            var newFile = new FileInfo(saveFile.FileName);
                            package.SaveAs(newFile);
                        }
                    }

                    MessageBox.Show("Xuất thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1_Click(button1, EventArgs.Empty);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Xuất Execl", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

       
    }
}