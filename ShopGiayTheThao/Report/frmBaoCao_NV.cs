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
    public partial class frmBaoCao_NV : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCao_NV()
        {
            InitializeComponent();
        }

        private void frmBaoCao_NV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sHOPGIAYDataSet1.sp_LoadNhanVien' table. You can move, or remove it, as needed.
            this.sp_LoadNhanVienTableAdapter1.Fill(this.sHOPGIAYDataSet1.sp_LoadNhanVien);
            // TODO: This line of code loads data into the 'sHOPGIAYDataSet.sp_LoadNhanVien' table. You can move, or remove it, as needed.
            this.sp_LoadNhanVienTableAdapter.Fill(this.sHOPGIAYDataSet.sp_LoadNhanVien);

            this.rpv_NV.RefreshReport(); 
        }
    }
}