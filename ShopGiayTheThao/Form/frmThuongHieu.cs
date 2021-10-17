

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopGiayTheThao
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        #region --VARIABLES--

        DataTable dt;
        string sql;
        string tmp;

        List<ThuongHieu> l_thuonghieu = new List<ThuongHieu>();
        public class ThuongHieu
        {
            public string MaThuongHieu { get; set; }
            public string TenThuongHieu { get; set; }
        }

        #endregion

        #region --EVENTS--

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            btn_Luu.Enabled = false;
            btn_CN.Enabled = false;
        }

        private void gv_thuonghieu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            txt_maTH.Text = gv_thuonghieu.GetRowCellValue(gv_thuonghieu.FocusedRowHandle, "MaThuongHieu").ToString();
            txt_TenTH.Text = gv_thuonghieu.GetRowCellValue(gv_thuonghieu.FocusedRowHandle, "TenThuongHieu").ToString();

            txt_maTH.ReadOnly = true;
            txt_TenTH.ReadOnly = true;

            btn_Sua.Enabled = true;

            tmp = txt_TenTH.Text;


        }

        private void BE_del_Thuonghieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xác nhận xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                string ID = gv_thuonghieu.GetRowCellValue(gv_thuonghieu.FocusedRowHandle, "MaThuongHieu").ToString();
                sql = "EXEC dbo.sp_XoaTH @maTH =" + ID;
                Class.Functions.RunSQL(sql);
                MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenTH.Text = "";
                txt_maTH.Text = "";
                txt_TenTH.ReadOnly = true;
                LoadData();
            }
            catch (Exception s)
            {

                MessageBox.Show("Lỗi xóa: " + s.ToString());
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

        #region --BUTTONS--

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txt_TenTH.ReadOnly = false;
            btn_CN.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_maTH.Text = "";
            txt_TenTH.Text = "";
            txt_TenTH.ReadOnly = false;

            btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_TenTH.Text))
                {
                    MessageBox.Show("Bạn phải nhập tên thương hiệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TenTH.Focus();
                    return;
                }
                txt_TenTH.Focus();
                sql = "EXEC dbo.CheckTrungTen @type = 1,@ten = N'" + txt_TenTH.Text + "'";
                dt = Class.Functions.GetDataToTable(sql);

                if (dt.Rows[0]["SL"].ToString().Equals("0"))
                {
                    sql = "EXEC dbo.sp_ThemThuongHieu @tenTH = N'" + txt_TenTH.Text + "'";
                    Class.Functions.RunSQL(sql);
                    MessageBox.Show("Lưu Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TenTH.Text = "";
                    txt_TenTH.ReadOnly = true;
                    LoadData();

                    btn_Luu.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thương Hiệu này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception s)
            {

                MessageBox.Show("Lỗi lưu : " + s.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btn_CN_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_maTH.Text == "")
                {
                    MessageBox.Show("Chọn dòng dữ liệu để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(txt_TenTH.Text))
                {
                    MessageBox.Show("Tên thương hiệu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TenTH.Text = tmp;
                    txt_TenTH.Focus();
                    return;
                }
                sql = "EXEC dbo.sp_CapNhatTH @maTH =" + txt_maTH.Text.ToString() + ",@tenTH = N'" + txt_TenTH.Text + "'";
                Class.Functions.RunSQL(sql);
                MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenTH.Text = "";
                txt_maTH.Text = "";
                txt_TenTH.ReadOnly = true;
                LoadData();

                btn_Sua.Enabled = false;
                btn_CN.Enabled = false;
            }
            catch (Exception s)
            {

                MessageBox.Show("Lỗi Cập Nhật: " + s.ToString());
            }
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "EXEC dbo.sp_TimKiem @ten = N'" + txt_timkiem.Text + "',@type = 1";
                dt = Class.Functions.GetDataToTable(sql);
                if (dt.Rows.Count > 0)
                {
                    l_thuonghieu.Clear();
                    foreach (DataRow item in dt.Rows)
                    {
                        l_thuonghieu.Add(new ThuongHieu()
                        {
                            MaThuongHieu = item["MaThuongHieu"].ToString(),
                            TenThuongHieu = item["TenThuongHieu"].ToString(),

                        });
                    }
                    gc_thuonghieu.DataSource = l_thuonghieu;
                    gc_thuonghieu.RefreshDataSource();
                }
            }
            catch (Exception)
            {


            }
        }
        #endregion

        #region --FUNCTIONS--

        private void LoadData()
        {
            sql = "EXEC dbo.sp_LoadThuongHieu";
            dt = Class.Functions.GetDataToTable(sql);
            if (dt.Rows.Count > 0)
            {
                l_thuonghieu.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    l_thuonghieu.Add(new ThuongHieu()
                    {
                        MaThuongHieu = item["MaThuongHieu"].ToString(),
                        TenThuongHieu = item["TenThuongHieu"].ToString(),

                    });
                }
                gc_thuonghieu.DataSource = l_thuonghieu;
                gc_thuonghieu.RefreshDataSource();
            }


        }

        #endregion

      
    }
}
