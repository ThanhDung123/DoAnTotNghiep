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
    public partial class frmBaoCaoNV : DevExpress.XtraEditors.XtraForm
    {
      
        #region Variables
        string sql = "";
        DataTable dt;

        List<NV> l_nv = new List<NV>();
        public class NV
        {
            public string MaNhanVien { get; set; }
            public string TenNhanVien { get; set; }
        }

        List<Nx_nv> l_nangxuatNV = new List<Nx_nv>();
        public class Nx_nv
        {
            public string MaNhanVien { get; set; }
            public string TenNhanVien { get; set; }
            public string SL_Ban { get; set; }
        }
        #endregion

        #region events
        public frmBaoCaoNV()
        {
            InitializeComponent();
        }

        private void frmBaoCaoNV_Load(object sender, EventArgs e)
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

            if (keyData == Keys.F3 && btn_LamMoi.Enabled)
            {
                btn_LamMoi_Click(btn_LamMoi, EventArgs.Empty);
                return true;
            }



            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region functions
        void loadLoaiBC()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value", typeof(int));
            dt.Columns.Add("text", typeof(string));

            dt.Rows.Add(1, "Tất cả nhân viên");
            dt.Rows.Add(2, "Năng xuất bán hàng");

            SLE_LoaiBaoCao.Properties.DataSource = dt;
            SLE_LoaiBaoCao.Properties.DisplayMember = "text";
            SLE_LoaiBaoCao.Properties.ValueMember = "value";
            SLE_LoaiBaoCao.Text = "";
        }
        #endregion

        #region buttons
        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            try
            {
                if (SLE_LoaiBaoCao.EditValue.Equals(1))
                {
                    xtraTabControl1.SelectedTabPage = xtraTabPage1;
                    sql = "EXEC dbo.sp_BaoCaoNV @type =" + SLE_LoaiBaoCao.EditValue + " ,@datefrom = '" + dtp_datefrom.Value.ToString("yyyy/MM/dd") + "', @dateto = '" + dtp_dateto.Value.ToString("yyyy/MM/dd") + "'";
                    dt = Class.Functions.GetDataToTable(sql);
                    if (dt.Rows.Count > 0)
                    {
                        l_nv.Clear();
                        foreach (DataRow item in dt.Rows)
                        {
                            l_nv.Add(new NV()
                            {
                                MaNhanVien = item["MaNhanVien"].ToString(),
                                TenNhanVien = item["TenNhanVien"].ToString()
                            });
                        }
                        gc_SanPham.DataSource = l_nv;
                        gc_SanPham.RefreshDataSource();
                    }
                    else
                    {
                        gc_SanPham.DataSource = "";
                        gc_SanPham.RefreshDataSource();
                    }
                }
                if (SLE_LoaiBaoCao.EditValue.Equals(2))
                {
                    xtraTabControl1.SelectedTabPage = xtraTabPage2;

                    sql = "EXEC dbo.sp_BaoCaoNV @type =" + SLE_LoaiBaoCao.EditValue + " ,@datefrom = '" + dtp_datefrom.Value.ToString("yyyy/MM/dd") + "', @dateto = '" + dtp_dateto.Value.ToString("yyyy/MM/dd") + "'";
                    dt = Class.Functions.GetDataToTable(sql);
                    if (dt.Rows.Count > 0)
                    {
                        l_nangxuatNV.Clear();
                        foreach (DataRow item in dt.Rows)
                        {
                            l_nangxuatNV.Add(new Nx_nv()
                            {
                                MaNhanVien = item["MaNhanVien"].ToString(),
                                TenNhanVien = item["TenNhanVien"].ToString(),
                                SL_Ban = item["SL_Ban"].ToString()

                            });
                        }
                        gc_NangXuatNV.DataSource = l_nangxuatNV;
                        gc_NangXuatNV.RefreshDataSource();
                    }
                    else
                    {
                        gc_NangXuatNV.DataSource = "";
                        gc_SanPham.RefreshDataSource();
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

                if (SLE_LoaiBaoCao.EditValue.Equals(1))
                {
                    if (gv_SanPham.RowCount == 0)
                    {
                        MessageBox.Show("Chưa có thông tin ", "Thông báo");
                        return;
                    }
                    SaveFileDialog saveFile = new SaveFileDialog
                    {
                        InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments),
                        Filter = @"(*.XLSX)|*.xlsx",
                        FileName = "BaoCaoNV"
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
                                row1.Value = "Báo Cáo Nhân Viên";
                                row1.Style.Font.Size = 12;
                                row1.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                row1.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                curentWorkSheet.Cells[2, 1].Value = "Mã Nhân Viên";
                                curentWorkSheet.Cells[2, 2].Value = "Tên Nhân Viên";

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
                                    curentWorkSheet.Cells[start + i, 1].Value = dt.Rows[i]["MaNhanVien"].ToString();
                                    curentWorkSheet.Cells[start + i, 2].Value = dt.Rows[i]["TenNhanVien"].ToString();
                                }
                                #endregion
                                var newFile = new FileInfo(saveFile.FileName);
                                package.SaveAs(newFile);
                            }
                        }
                        MessageBox.Show("Xuất thành công ", "Thông báo");
                    }
                }
                if (SLE_LoaiBaoCao.EditValue.Equals(2))
                {
                    if (gv_SanPham.RowCount == 0)
                    {
                        MessageBox.Show("Chưa có thông tin ", "Thông báo");
                        return;
                    }
                    SaveFileDialog saveFile = new SaveFileDialog
                    {
                        InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments),
                        Filter = @"(*.XLSX)|*.xlsx",
                        FileName = "BaoCaoNV"
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

                                var row1 = curentWorkSheet.SelectedRange["A1:C1"];
                                row1.Merge = true;
                                row1.Value = "Báo Cáo Nhân Viên";
                                row1.Style.Font.Size = 12;
                                row1.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                row1.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                curentWorkSheet.Cells[2, 1].Value = "Mã Nhân Viên";
                                curentWorkSheet.Cells[2, 2].Value = "Tên Nhân Viên";
                                curentWorkSheet.Cells[2, 3].Value = "Số Lượng Hóa Đơn";

                                curentWorkSheet.SelectedRange["A2:F2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                #endregion

                                #region Style
                                //broder all
                                var row = curentWorkSheet.SelectedRange["A2:C2"];
                                row.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                                row.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                row.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                                row.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                                row.AutoFitColumns();

                                curentWorkSheet.SelectedRange["A2:C2"].Style.Font.Bold = true;
                                #endregion

                                #region Content
                                int start = 3;
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    curentWorkSheet.Cells[start + i, 1].Value = dt.Rows[i]["MaNhanVien"].ToString();
                                    curentWorkSheet.Cells[start + i, 2].Value = dt.Rows[i]["TenNhanVien"].ToString();
                                    curentWorkSheet.Cells[start + i, 3].Value = dt.Rows[i]["SL_Ban"].ToString();
                                }
                                #endregion
                                var newFile = new FileInfo(saveFile.FileName);
                                package.SaveAs(newFile);
                            }
                        }
                        MessageBox.Show("Xuất thành công ", "Thông báo");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Xuất Execl", "Thông báo");
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            SLE_LoaiBaoCao.Text = "";
            gc_NangXuatNV.DataSource = "";
            gc_SanPham.DataSource = "";
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
            dtp_datefrom.Value = DateTime.Now;
            dtp_dateto.Value = DateTime.Now;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
  }

     

}