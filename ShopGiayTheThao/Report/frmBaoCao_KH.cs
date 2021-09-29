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
    public partial class frmBaoCao_KH : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCao_KH()
        {
            InitializeComponent();
        }

        private void frmBaoCao_KH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sHOPGIAYDataSet.sp_load_KH_Report' table. You can move, or remove it, as needed.
            this.sp_load_KH_ReportTableAdapter.Fill(this.sHOPGIAYDataSet.sp_load_KH_Report);
            // TODO: This line of code loads data into the 'sHOPGIAYDataSet1.sp_LoadKhachHang' table. You can move, or remove it, as needed.
          

            this.rpv_KH.RefreshReport();
        }
    }
}