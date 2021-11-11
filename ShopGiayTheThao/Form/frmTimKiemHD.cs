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
    public partial class frmTimKiemHD : DevExpress.XtraEditors.XtraForm
    {
        #region --VARIABLES--

        string sql, taikhoan;
        int Loai_TK;
        DataTable dt;

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

        #region --EVENS--

        public frmTimKiemHD()
        {
            InitializeComponent();
        }

        private void frmTimKiemHD_Load(object sender, EventArgs e)
        {
            check_loai_tk();
            btn_TimKiem_Click(btn_TimKiem, EventArgs.Empty);
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.F1 && btn_TimKiem.Enabled) 
            {
                btn_TimKiem_Click(btn_TimKiem, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.F2 && btn_reset.Enabled)
            {
                btn_reset_Click(btn_reset, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.F3 && btn_inHD.Enabled) 
            {
                btn_inHD_Click(btn_inHD, EventArgs.Empty);
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

         public frmTimKiemHD(string giatri)
            : this()
        {
            taikhoan = giatri;
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

                }
            }
            if (!(Loai_TK == 0))
            {
                txt_MaHD_search.ReadOnly = true;
                btn_TimKiem.Enabled = false;
                dtp_ngay.Enabled = false;               
            }
        }
        #endregion

        #region --BUTTONS--

        private void btn_Thoat_search_Click(object sender, EventArgs e)    
        {
            this.Close();

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            sql = "EXEC dbo.sp_TimHD @maHD = N'" + txt_MaHD_search.Text + "',@ngaylap = '" + dtp_ngay.Value.ToString("yyyy/MM/dd")+ "'";
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
                gc_TimHD.DataSource = l_HD_search;
                gc_TimHD.RefreshDataSource();

                xtraTabControl1.SelectedTabPage = xtraTabPage1;
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào được tìm thấy ","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BE_Xem_CTHD_Click(object sender, EventArgs e)
        {
            txt_MaHD_search.Text = gv_timHD.GetRowCellValue(gv_timHD.FocusedRowHandle, "MaHoaDon").ToString();

            sql = "EXEC dbo.sp_Xem_CTHD @maHD = '" + txt_MaHD_search.Text + "'";
            dt = Class.Functions.GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                l_CTHD_search.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    l_CTHD_search.Add(new CTHD_search
                    {

                        MaSanPham = item["MaSanPham"].ToString(),
                        TenSanPham = item["TenSanPham"].ToString(),
                        SoLuong = item["SoLuong"].ToString(),
                        DonGia = item["DonGia"].ToString(),
                        GiamGia = item["GiamGia"].ToString(),
                        ThanhTien = item["ThanhTien"].ToString()
                    });
                    gc_CTHoaDon_search.DataSource = l_CTHD_search;
                    gc_CTHoaDon_search.RefreshDataSource();

                    xtraTabControl1.SelectedTabPage = xtraTabPage2;

                }
            }
        }

        private void btn_inHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaHD_search.Text))
            {
                MessageBox.Show("Chưa chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinCTHD;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];

            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "D&D Shop";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Hồ Chí Minh";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (+84)396753432";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán

            sql = "EXEC dbo.Load_HD_excel @maHD = '" + txt_MaHD_search.Text + "'";
            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][9].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][10].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].FormatConditions.ToString();
            exRange.Range["C9:E9"].Value = "(+84) " + tblThongtinHD.Rows[0][11].ToString();


            //Lấy thông tin các mặt hàng
            sql = "EXEC dbo.sp_Xuat_CTHD_Excel @maHD = N'" + txt_MaHD_search.Text + "'";
            tblThongtinCTHD = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng

            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên sản phẩm";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";

            for (hang = 0; hang < tblThongtinCTHD.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12

                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinCTHD.Columns.Count; cot++)

                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinCTHD.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinCTHD.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][6].ToString() + " VND";
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;

            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][3]);
            exRange.Range["A1:C1"].Value = "Hồ Chí Minh, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;

            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][20];

            exSheet.Name = "CTHĐ";
            exApp.Visible = true;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            gc_TimHD.DataSource = "";
            gc_CTHoaDon_search.DataSource = "";

            txt_MaHD_search.Text = "";
            dtp_ngay.Value = DateTime.Now;
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
        }

        private void BE_del_HD_Click(object sender, EventArgs e)
        {
            try
            {
                txt_MaHD_search.Text = gv_timHD.GetRowCellValue(gv_timHD.FocusedRowHandle, "MaHoaDon").ToString();

                sql = "EXEC dbo.sp_Xoa_hoadon @mahoadon = '" + txt_MaHD_search.Text + "', @loai_tk = " + Loai_TK;
                dt = Class.Functions.GetDataToTable(sql);

                if (dt.Rows.Count == 0)
                {
                    l_HD_search.RemoveAt(gv_timHD.FocusedRowHandle);
                    gc_TimHD.RefreshDataSource();
                    txt_MaHD_search.Text = "";
                    MessageBox.Show("Xóa Thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }


       
        #endregion

       

      
     
        



    }
}