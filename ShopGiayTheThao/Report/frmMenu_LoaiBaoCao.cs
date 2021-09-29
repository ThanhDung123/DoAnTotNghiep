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
    public partial class frmMenu_LoaiBaoCao : DevExpress.XtraEditors.XtraForm
    {
        public frmMenu_LoaiBaoCao()
        {
            InitializeComponent();
        }

        private void btn_SP_Click(object sender, EventArgs e)
        {
            frmBaocao_SP f = new frmBaocao_SP();
            f.ShowDialog();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_KH_Click(object sender, EventArgs e)
        {
            frmBaoCao_KH f = new frmBaoCao_KH();
            f.ShowDialog();
        }

        private void btn_NV_Click(object sender, EventArgs e)
        {
            frmBaoCao_NV f = new frmBaoCao_NV();
            f.ShowDialog();
        }
    }
}