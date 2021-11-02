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

        List<SanPham2> l_sanpham2= new List<SanPham2>();
        public class SanPham2
        {
            public string MaSanPham { get; set; }
            public string TenSanPham { get; set; }
            public string SoLuong { get; set; }
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

        private void SLE_LoaiBaoCao_TextChanged(object sender, EventArgs e)
        {
            if (SLE_LoaiBaoCao.EditValue.Equals(2))
            {
                lblsl.Visible = true;
                nmrSL.Visible = true;

                dtp_datefrom.Enabled = false;
                dtp_dateto.Enabled = false;

                gc_SanPham.DataSource = "";
                gc_sp3.DataSource = "";
            }

            if (SLE_LoaiBaoCao.EditValue.Equals(3))
            {
                dtp_datefrom.Enabled = true;
                dtp_dateto.Enabled = true;

                lblsl.Visible = false;
                nmrSL.Visible = false;

                gc_SanPham.DataSource = "";
                gc_sp2.DataSource = "";
            }

            if (SLE_LoaiBaoCao.EditValue.Equals(1))
            {
                dtp_datefrom.Enabled = false;
                dtp_dateto.Enabled = false;

                lblsl.Visible = false;
                nmrSL.Visible = false;

                gc_sp2.DataSource = "";
                gc_sp3.DataSource = "";

            }
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
            gc_sp2.DataSource = "";
            gc_sp3.DataSource = "";
            lblsl.Visible = false;
            nmrSL.Visible = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            try
            {
                if (SLE_LoaiBaoCao.EditValue.Equals(1))
                {
                    sql = "EXEC dbo.[sp.BaoCaoSP] @type =" + SLE_LoaiBaoCao.EditValue + ",@sl = " + nmrSL.Value;
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
                        tabControl1.SelectedTab = tabPage1;
                    }
                    else
                    {
                        MessageBox.Show("Không có thông tin nào được tìm thấy ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gc_sp3.DataSource = "";
                        gc_sp3.RefreshDataSource();
                    }
                }

                if (SLE_LoaiBaoCao.EditValue.Equals(3))
                {
                    sql = "EXEC dbo.sp_SPBantrongthang @datefrom = '" + dtp_datefrom.Value.ToString("yyyy/MM/dd") + "',@dateto = '" + dtp_dateto.Value.ToString("yyyy/MM/dd") + "'";
                    dt = Class.Functions.GetDataToTable(sql);
                    if (dt.Rows.Count > 0)
                    {
                        l_sanpham2.Clear();
                        foreach (DataRow item in dt.Rows)
                        {
                            l_sanpham2.Add(new SanPham2()
                            {
                                MaSanPham = item["MaSanPham"].ToString(),
                                TenSanPham = item["TenSanPham"].ToString(),
                                SoLuong = item["SoLuong"].ToString()
                            });
                        }

                        gc_sp3.DataSource = l_sanpham2;
                        gc_sp3.RefreshDataSource();
                        tabControl1.SelectedTab = tabPage3;
                    }
                    else
                    {
                        MessageBox.Show("Không có thông tin nào được tìm thấy ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gc_sp3.DataSource = "";
                        gc_sp3.RefreshDataSource();
                    }
                }

                if (SLE_LoaiBaoCao.EditValue.Equals(2))
                {
                    sql = "EXEC dbo.[sp.BaoCaoSP] @type =" +SLE_LoaiBaoCao.EditValue+",@sl = "+ nmrSL.Value;
                    dt = Class.Functions.GetDataToTable(sql);
                    if (dt.Rows.Count > 0)
                    {
                        l_sanpham2.Clear();
                        foreach (DataRow item in dt.Rows)
                        {
                            l_sanpham2.Add(new SanPham2()
                            {
                                MaSanPham = item["MaSanPham"].ToString(),
                                TenSanPham = item["TenSanPham"].ToString(),
                                SoLuong = item["SoLuong"].ToString()
                            });
                        }
                        gc_sp2.DataSource = l_sanpham2;
                        gc_sp2.RefreshDataSource();
                        tabControl1.SelectedTab = tabPage2;
                    }
                    else
                    {
                        gc_sp2.DataSource = "";
                        gc_sp2.RefreshDataSource();
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
                if (SLE_LoaiBaoCao.EditValue.Equals(1))
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
                        FileName = "BaoCaoDSSP"
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

                                var row = curentWorkSheet.SelectedRange["A1:B1"];
                                row.Merge = true;
                                row.Value = "Cửa Hàng Dụng Cụ Thể Thao DL SHOP";
                                row.Style.Font.Size = 14;
                                row.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                row.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                var row2 = curentWorkSheet.SelectedRange["A2:B2"];
                                row2.Merge = true;
                                row2.Value = "Nhân viên :";
                                row2.Style.Font.Size = 12;
                                row2.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                                row2.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                curentWorkSheet.SelectedRange["A2:B2"].Style.Font.Italic = true;

                                var row3 = curentWorkSheet.SelectedRange["A3:B3"];
                                row3.Merge = true;
                                row3.Value = "Ngày: " + DateTime.Now.Date.ToString("yyyy/MM/dd");
                                row3.Style.Font.Size = 12;
                                row3.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                                row3.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                curentWorkSheet.SelectedRange["A3:E3"].Style.Font.Italic = true;

                                var row1 = curentWorkSheet.SelectedRange["A4:B4"];
                                row1.Merge = true;
                                row1.Value = "Báo Cáo Danh Sách Sản Phẩm";
                                row1.Style.Font.Size = 12;
                                row1.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                row1.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                curentWorkSheet.Cells[5, 1].Value = "Mã sản phẩm";
                                curentWorkSheet.Cells[5, 2].Value = "Tên sản phẩm";

                                curentWorkSheet.SelectedRange["A5:B5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                #endregion

                                #region Style
                                //broder all
                                var row9 = curentWorkSheet.SelectedRange["A5:B5"];
                                row9.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                                row9.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                row9.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                                row9.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                                row9.AutoFitColumns();

                                curentWorkSheet.SelectedRange["A5:B5"].Style.Font.Bold = true;
                                #endregion

                                #region Content
                                int start = 6;
                                int line = 6;
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    curentWorkSheet.Cells[start + i, 1].Value = dt.Rows[i]["MaSanPham"].ToString();
                                    curentWorkSheet.Cells[start + i, 2].Value = dt.Rows[i]["TenSanPham"].ToString();
                                    line++;
                                }
                                int linee = line - 1;
                                var row10 = curentWorkSheet.SelectedRange["A6:B" + linee];
                                row10.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                                row10.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                row10.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                                row10.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                                row10.AutoFitColumns();

                                curentWorkSheet.Cells[line + 2, 2].Value = "Chữ ký";
                                #endregion
                                var newFile = new FileInfo(saveFile.FileName);
                                package.SaveAs(newFile);
                            }
                        }

                        MessageBox.Show("Xuất thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button1_Click(button1, EventArgs.Empty);
                    }
                } 
                if (SLE_LoaiBaoCao.EditValue.Equals(2))
                {
                    if (gv_sp2.RowCount == 0)
                        {
                            MessageBox.Show("Chưa có thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        SaveFileDialog saveFile = new SaveFileDialog
                        {
                            InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments),
                            Filter = @"(*.XLSX)|*.xlsx",
                            FileName = "BaoCaoSLSP"
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

                                    var row = curentWorkSheet.SelectedRange["A1:C1"];
                                    row.Merge = true;
                                    row.Value = "Cửa Hàng Dụng Cụ Thể Thao DL SHOP";
                                    row.Style.Font.Size = 14;
                                    row.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    row.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                    var row2 = curentWorkSheet.SelectedRange["A2:C2"];
                                    row2.Merge = true;
                                    row2.Value = "Nhân viên :";
                                    row2.Style.Font.Size = 12;
                                    row2.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                                    row2.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    curentWorkSheet.SelectedRange["A2:C2"].Style.Font.Italic = true;

                                    var row3 = curentWorkSheet.SelectedRange["A3:C3"];
                                    row3.Merge = true;
                                    row3.Value = "Ngày: " + DateTime.Now.Date.ToString("yyyy/MM/dd");
                                    row3.Style.Font.Size = 12;
                                    row3.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                                    row3.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    curentWorkSheet.SelectedRange["A3:C3"].Style.Font.Italic = true;

                                    var row1 = curentWorkSheet.SelectedRange["A4:C4"];
                                    row1.Merge = true;
                                    row1.Value = "Báo Cáo Sản Phẩm Sắp Hết";
                                    row1.Style.Font.Size = 12;
                                    row1.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    row1.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                    curentWorkSheet.Cells[5, 1].Value = "Mã sản phẩm";
                                    curentWorkSheet.Cells[5, 2].Value = "Tên sản phẩm";
                                    curentWorkSheet.Cells[5, 3].Value = "Số lượng";

                                    curentWorkSheet.SelectedRange["A5:C5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    #endregion

                                    #region Style
                                    //broder all
                                    var row9 = curentWorkSheet.SelectedRange["A5:C5"];
                                    row9.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                                    row9.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    row9.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                                    row9.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                                    row9.AutoFitColumns();

                                    curentWorkSheet.SelectedRange["A5:C5"].Style.Font.Bold = true;
                                    #endregion

                                    #region Content
                                    int start = 6;
                                    int line = 6;
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {
                                        curentWorkSheet.Cells[start + i, 1].Value = dt.Rows[i]["MaSanPham"].ToString();
                                        curentWorkSheet.Cells[start + i, 2].Value = dt.Rows[i]["TenSanPham"].ToString();
                                        curentWorkSheet.Cells[start + i, 3].Value = dt.Rows[i]["SoLuong"].ToString();
                                        line++;
                                    }
                                    int linee = line - 1;
                                    var row10 = curentWorkSheet.SelectedRange["A6:C" + linee];
                                    row10.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                                    row10.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    row10.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                                    row10.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                                    row10.AutoFitColumns();

                                    curentWorkSheet.Cells[line + 2, 3].Value = "Chữ ký";
                                    #endregion
                                    var newFile = new FileInfo(saveFile.FileName);
                                    package.SaveAs(newFile);
                                }
                            }
                            MessageBox.Show("Xuất thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button1_Click(button1, EventArgs.Empty);
                        }
                    }
                if (SLE_LoaiBaoCao.EditValue.Equals(3))
                {
                    if (gv_sp3.RowCount == 0)
                    {
                        MessageBox.Show("Chưa có thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    SaveFileDialog saveFile = new SaveFileDialog
                    {
                        InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments),
                        Filter = @"(*.XLSX)|*.xlsx",
                        FileName = "BaoCaoSP_BanTrongThang"
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

                                var row = curentWorkSheet.SelectedRange["A1:C1"];
                                row.Merge = true;
                                row.Value = "Cửa Hàng Dụng Cụ Thể Thao DL SHOP";
                                row.Style.Font.Size = 14;
                                row.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                row.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                var row2 = curentWorkSheet.SelectedRange["A2:C2"];
                                row2.Merge = true;
                                row2.Value = "Nhân viên :";
                                row2.Style.Font.Size = 12;
                                row2.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                                row2.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                curentWorkSheet.SelectedRange["A2:F2"].Style.Font.Italic = true;

                                var row3 = curentWorkSheet.SelectedRange["A3:C3"];
                                row3.Merge = true;
                                row3.Value = "Ngày: " + DateTime.Now.Date.ToString("yyyy/MM/dd");
                                row3.Style.Font.Size = 12;
                                row3.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                                row3.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                curentWorkSheet.SelectedRange["A3:B3"].Style.Font.Italic = true;

                                var row1 = curentWorkSheet.SelectedRange["A4:C4"];
                                row1.Merge = true;
                                row1.Value = "Báo Cáo Sản Phẩm Bán Được";
                                row1.Style.Font.Size = 12;
                                row1.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                row1.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                var row5 = curentWorkSheet.SelectedRange["A5:C5"];
                                row5.Merge = true;
                                row5.Value = "Từ ngày: " + dtp_datefrom.Value.ToString("yyyy/MM/dd");
                                row5.Style.Font.Size = 12;
                                row5.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                                row5.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                var row6 = curentWorkSheet.SelectedRange["A6:C6"];
                                row6.Merge = true;
                                row6.Value = "Đến Ngày: " + dtp_dateto.Value.ToString("yyyy/MM/dd");
                                row6.Style.Font.Size = 12;
                                row6.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                                row6.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                curentWorkSheet.Cells[7, 1].Value = "Mã Sản Phẩm";
                                curentWorkSheet.Cells[7, 2].Value = "Tên Sản Phẩm";
                                curentWorkSheet.Cells[7, 3].Value = "Số Lượng Bán";

                                #endregion

                                #region Style
                                //broder all
                                var row9 = curentWorkSheet.SelectedRange["A7:C7"];
                                row9.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                                row9.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                row9.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                                row9.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                                row9.AutoFitColumns();

                                #endregion

                                #region Content
                                int start = 8;
                                int line = 8;
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    curentWorkSheet.Cells[start + i, 1].Value = dt.Rows[i]["MaSanPham"].ToString();
                                    curentWorkSheet.Cells[start + i, 2].Value = dt.Rows[i]["TenSanPham"].ToString();
                                    curentWorkSheet.Cells[start + i, 3].Value = dt.Rows[i]["SoLuong"].ToString();
                                    line++;
                                }
                                int linee = line - 1;
                                var row10 = curentWorkSheet.SelectedRange["A8:C" + linee];
                                row10.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                                row10.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                row10.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                                row10.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                                row10.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                row10.AutoFitColumns();


                                curentWorkSheet.Cells[line + 1, 3].Value = "Chữ ký";
                                #endregion
                                var newFile = new FileInfo(saveFile.FileName);
                                package.SaveAs(newFile);
                            }
                        }
                        MessageBox.Show("Xuất thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button1_Click(button1, EventArgs.Empty);

                    }
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