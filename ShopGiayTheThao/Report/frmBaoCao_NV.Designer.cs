namespace ShopGiayTheThao.Report
{
    partial class frmBaoCao_NV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spLoadNhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sHOPGIAYDataSet = new ShopGiayTheThao.SHOPGIAYDataSet();
            this.spLoadNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rpv_NV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sp_LoadNhanVienTableAdapter = new ShopGiayTheThao.SHOPGIAYDataSetTableAdapters.sp_LoadNhanVienTableAdapter();
            this.sHOPGIAYDataSet1 = new ShopGiayTheThao.SHOPGIAYDataSet1();
            this.spLoadNhanVienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sp_LoadNhanVienTableAdapter1 = new ShopGiayTheThao.SHOPGIAYDataSet1TableAdapters.sp_LoadNhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spLoadNhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPGIAYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLoadNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPGIAYDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLoadNhanVienBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // spLoadNhanVienBindingSource1
            // 
            this.spLoadNhanVienBindingSource1.DataMember = "sp_LoadNhanVien";
            this.spLoadNhanVienBindingSource1.DataSource = this.sHOPGIAYDataSet;
            // 
            // sHOPGIAYDataSet
            // 
            this.sHOPGIAYDataSet.DataSetName = "SHOPGIAYDataSet";
            this.sHOPGIAYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spLoadNhanVienBindingSource
            // 
            this.spLoadNhanVienBindingSource.DataMember = "sp_LoadNhanVien";
            this.spLoadNhanVienBindingSource.DataSource = this.sHOPGIAYDataSet;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 79);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(852, 478);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panel2);
            this.xtraTabPage1.Image = global::ShopGiayTheThao.Properties.Resources.Calendar_16x162;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(846, 447);
            this.xtraTabPage1.Text = "Nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rpv_NV);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 447);
            this.panel2.TabIndex = 0;
            // 
            // rpv_NV
            // 
            this.rpv_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.spLoadNhanVienBindingSource2;
            this.rpv_NV.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_NV.LocalReport.ReportEmbeddedResource = "ShopGiayTheThao.Report.Report2.rdlc";
            this.rpv_NV.Location = new System.Drawing.Point(70, 0);
            this.rpv_NV.Name = "rpv_NV";
            this.rpv_NV.Size = new System.Drawing.Size(699, 447);
            this.rpv_NV.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(769, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(77, 447);
            this.panel5.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 447);
            this.panel4.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 79);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ShopGiayTheThao.Properties.Resources.Capture1;
            this.pictureBox1.Location = new System.Drawing.Point(376, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 33);
            this.label1.TabIndex = 70;
            this.label1.Text = "Báo Cáo Nhân Viên";
            // 
            // sp_LoadNhanVienTableAdapter
            // 
            this.sp_LoadNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // sHOPGIAYDataSet1
            // 
            this.sHOPGIAYDataSet1.DataSetName = "SHOPGIAYDataSet1";
            this.sHOPGIAYDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spLoadNhanVienBindingSource2
            // 
            this.spLoadNhanVienBindingSource2.DataMember = "sp_LoadNhanVien";
            this.spLoadNhanVienBindingSource2.DataSource = this.sHOPGIAYDataSet1;
            // 
            // sp_LoadNhanVienTableAdapter1
            // 
            this.sp_LoadNhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // frmBaoCao_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 557);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaoCao_NV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Nhân viên";
            this.Load += new System.EventHandler(this.frmBaoCao_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spLoadNhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPGIAYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLoadNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPGIAYDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLoadNhanVienBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_NV;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private SHOPGIAYDataSet sHOPGIAYDataSet;
        private System.Windows.Forms.BindingSource spLoadNhanVienBindingSource;
        private SHOPGIAYDataSetTableAdapters.sp_LoadNhanVienTableAdapter sp_LoadNhanVienTableAdapter;
        private System.Windows.Forms.BindingSource spLoadNhanVienBindingSource1;
        private SHOPGIAYDataSet1 sHOPGIAYDataSet1;
        private System.Windows.Forms.BindingSource spLoadNhanVienBindingSource2;
        private SHOPGIAYDataSet1TableAdapters.sp_LoadNhanVienTableAdapter sp_LoadNhanVienTableAdapter1;
    }
}