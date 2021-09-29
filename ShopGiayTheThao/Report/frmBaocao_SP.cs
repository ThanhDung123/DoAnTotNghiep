using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ShopGiayTheThao.Report
{
    public partial class frmBaocao_SP : DevExpress.XtraEditors.XtraForm
    {
        public frmBaocao_SP()
        {
            InitializeComponent();
        }

        private void frmBaocao_SP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sHOPGIAYDataSet.sp_load_KH_Report' table. You can move, or remove it, as needed.
            this.sp_load_KH_ReportTableAdapter.Fill(this.sHOPGIAYDataSet.sp_load_KH_Report);
            // TODO: This line of code loads data into the 'sHOPGIAYDataSet.sp_LoadSanPham' table. You can move, or remove it, as needed.
            this.sp_LoadSanPhamTableAdapter.Fill(this.sHOPGIAYDataSet.sp_LoadSanPham);
            // TODO: This line of code loads data into the 'sHOPGIAYDataSet.sp_LoadSanPham' table. You can move, or remove it, as needed.
          
            this.rpv_SP.RefreshReport();
        }

      
    }
}