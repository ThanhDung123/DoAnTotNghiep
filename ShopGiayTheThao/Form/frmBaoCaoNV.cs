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
            public string DienThoai { get; set; }
            public string NgaySinh { get; set; }
            public string DiaChi { get; set; }
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

        private void SLE_LoaiBaoCao_TextChanged(object sender, EventArgs e)
        {
            if (SLE_LoaiBaoCao.EditValue.Equals(1))
            {
                gc_NangXuatNV.DataSource = "";

            }
            else
                gc_SanPham.DataSource = "";

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
                                TenNhanVien = item["TenNhanVien"].ToString(),
                                DienThoai = item["DienThoai"].ToString(),
                                NgaySinh = item["NgaySinh"].ToString(),
                                DiaChi = item["DiaChi"].ToString()
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
                        MessageBox.Show("Chưa có thông tin ", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    SaveFileDialog saveFile = new SaveFileDialog
                    {
                        InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments),
                        Filter = @"(*.XLSX)|*.xlsx",
                        FileName = "BaoCaoDSNV"
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

                                var row = curentWorkSheet.SelectedRange["A1:E1"];
                                row.Merge = true;
                                row.Value = "Cửa Hàng Dụng Cụ Thể Thao DL SHOP";
                                row.Style.Font.Size = 14;
                                row.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                row.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                var row2 = curentWorkSheet.SelectedRange["A2:E2"];
                                row2.Merge = true;
                                row2.Value = "Nhân viên :";
                                row2.Style.Font.Size = 12;
                                row2.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                                row2.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                curentWorkSheet.SelectedRange["A2:F2"].Style.Font.Italic = true;

                                var row3 = curentWorkSheet.SelectedRange["A3:E3"];
                                row3.Merge = true;
                                row3.Value = "Ngày: " + DateTime.Now.Date.ToString("yyyy/MM/dd");
                                row3.Style.Font.Size = 12;
                                row3.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                                row3.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                curentWorkSheet.SelectedRange["A3:E3"].Style.Font.Italic = true;

                                var row5 = curentWorkSheet.SelectedRange["A4:E4"];
                                row5.Merge = true;
                                row5.Value = "Báo Cáo Danh Sách Nhân Viên";
                                row5.Style.Font.Size = 12;
                                row5.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                row5.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                curentWorkSheet.Cells[5, 1].Value = "Mã Nhân Viên";
                                curentWorkSheet.Cells[5, 2].Value = "Tên Nhân Viên";
                                curentWorkSheet.Cells[5, 3].Value = "Điện Thoại";
                                curentWorkSheet.Cells[5, 4].Value = "Ngày Sinh";
                                curentWorkSheet.Cells[5, 5].Value = "Địa Chỉ";

                                curentWorkSheet.SelectedRange["A5:E5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                #endregion

                                #region Style
                                //broder all
                                var row9 = curentWorkSheet.SelectedRange["A5:E5"];
                                row9.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                                row9.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                row9.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                                row9.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                                row9.AutoFitColumns();

                                #endregion

                                #region Content
                                int start = 6;
                                int line  = 6;
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    curentWorkSheet.Cells[start + i, 1].Value = dt.Rows[i]["MaNhanVien"].ToString();
                                    curentWorkSheet.Cells[start + i, 2].Value = dt.Rows[i]["TenNhanVien"].ToString();
                                    curentWorkSheet.Cells[start + i, 3].Value = dt.Rows[i]["DienThoai"].ToString();
                                    curentWorkSheet.Cells[start + i, 4].Value = dt.Rows[i]["NgaySinh"].ToString();
                                    curentWorkSheet.Cells[start + i, 5].Value = dt.Rows[i]["DiaChi"].ToString();
                                    line++;
                                }
                                int linee = line - 1;
                                var row10 = curentWorkSheet.SelectedRange["A6:E"+linee];
                                row10.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                                row10.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                row10.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                                row10.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                                row10.AutoFitColumns();

                                curentWorkSheet.Cells[line + 2, 5].Value = "Chữ ký";
                                #endregion
                                var newFile = new FileInfo(saveFile.FileName);
                                package.SaveAs(newFile);
                            }
                        }
                        MessageBox.Show("Xuất thành công ", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        btn_LamMoi_Click(btn_LamMoi, EventArgs.Empty);
                    }
                }
                if (SLE_LoaiBaoCao.EditValue.Equals(2))
                {
                    if (gv_NXNV.RowCount == 0)
                    {
                        MessageBox.Show("Chưa có thông tin ", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    SaveFileDialog saveFile = new SaveFileDialog
                    {
                        InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments),
                        Filter = @"(*.XLSX)|*.xlsx",
                        FileName = "BaoCaoNXNV"
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
                                curentWorkSheet.SelectedRange["A3:F3"].Style.Font.Italic = true;

                                var row1 = curentWorkSheet.SelectedRange["A4:C4"];
                                row1.Merge = true;
                                row1.Value = "Báo Cáo Năng Xuất Nhân Viên";
                                row1.Style.Font.Size = 12;
                                row1.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                row1.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                var row5 = curentWorkSheet.SelectedRange["A5:C5"];
                                row5.Merge = true;
                                row5.Value = "Từ ngày: " +dtp_datefrom.Value.ToString("yyyy/MM/dd");
                                row5.Style.Font.Size = 12;
                                row5.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                                row5.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                var row6 = curentWorkSheet.SelectedRange["A6:C6"];
                                row6.Merge = true;
                                row6.Value = "Đến Ngày: " + dtp_dateto.Value.ToString("yyyy/MM/dd");
                                row6.Style.Font.Size = 12;
                                row6.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                                row6.Style.VerticalAlignment = ExcelVerticalAlignment.Center;                        

                                curentWorkSheet.Cells[7, 1].Value = "Mã Nhân Viên";
                                curentWorkSheet.Cells[7, 2].Value = "Tên Nhân Viên";
                                curentWorkSheet.Cells[7, 3].Value = "Số Lượng Hóa Đơn";

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
                                    curentWorkSheet.Cells[start + i, 1].Value = dt.Rows[i]["MaNhanVien"].ToString();
                                    curentWorkSheet.Cells[start + i, 2].Value = dt.Rows[i]["TenNhanVien"].ToString();
                                    curentWorkSheet.Cells[start + i, 3].Value = dt.Rows[i]["SL_Ban"].ToString();
                                    line++;
                                }
                                int linee = line -1;
                                var row10 = curentWorkSheet.SelectedRange["A8:C"+linee];
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
                        MessageBox.Show("Xuất thành công ", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        btn_LamMoi_Click(btn_LamMoi, EventArgs.Empty);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Xuất Execl", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
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