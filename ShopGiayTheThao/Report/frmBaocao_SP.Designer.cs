namespace ShopGiayTheThao.Report
{
    partial class frmBaocao_SP
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
            this.spLoadSanPhamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sHOPGIAYDataSet = new ShopGiayTheThao.SHOPGIAYDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rpv_SP = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.spLoadSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_LoadSanPhamTableAdapter = new ShopGiayTheThao.SHOPGIAYDataSetTableAdapters.sp_LoadSanPhamTableAdapter();
            this.sploadKHReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_load_KH_ReportTableAdapter = new ShopGiayTheThao.SHOPGIAYDataSetTableAdapters.sp_load_KH_ReportTableAdapter();
            this.sp_LoadSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spLoadSanPhamBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spLoadSanPhamBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPGIAYDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spLoadSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sploadKHReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LoadSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLoadSanPhamBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // spLoadSanPhamBindingSource1
            // 
            this.spLoadSanPhamBindingSource1.DataMember = "sp_LoadSanPham";
            this.spLoadSanPhamBindingSource1.DataSource = this.sHOPGIAYDataSet;
            // 
            // sHOPGIAYDataSet
            // 
            this.sHOPGIAYDataSet.DataSetName = "SHOPGIAYDataSet";
            this.sHOPGIAYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 79);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ShopGiayTheThao.Properties.Resources.Capture1;
            this.pictureBox1.Location = new System.Drawing.Point(347, 0);
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
            this.label1.Size = new System.Drawing.Size(237, 33);
            this.label1.TabIndex = 70;
            this.label1.Text = "Báo Cáo sản phẩm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xtraTabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 458);
            this.panel2.TabIndex = 2;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(823, 458);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panel3);
            this.xtraTabPage1.Image = global::ShopGiayTheThao.Properties.Resources.Calendar_16x162;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(817, 427);
            this.xtraTabPage1.Text = "Sản Phẩm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rpv_SP);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 427);
            this.panel3.TabIndex = 0;
            // 
            // rpv_SP
            // 
            this.rpv_SP.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spLoadSanPhamBindingSource2;
            this.rpv_SP.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_SP.LocalReport.ReportEmbeddedResource = "ShopGiayTheThao.Report.Report1.rdlc";
            this.rpv_SP.Location = new System.Drawing.Point(70, 0);
            this.rpv_SP.Name = "rpv_SP";
            this.rpv_SP.Size = new System.Drawing.Size(670, 427);
            this.rpv_SP.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(740, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(77, 427);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 427);
            this.panel4.TabIndex = 0;
            // 
            // spLoadSanPhamBindingSource
            // 
            this.spLoadSanPhamBindingSource.DataMember = "sp_LoadSanPham";
            this.spLoadSanPhamBindingSource.DataSource = this.sHOPGIAYDataSet;
            // 
            // sp_LoadSanPhamTableAdapter
            // 
            this.sp_LoadSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // sploadKHReportBindingSource
            // 
            this.sploadKHReportBindingSource.DataMember = "sp_load_KH_Report";
            this.sploadKHReportBindingSource.DataSource = this.sHOPGIAYDataSet;
            // 
            // sp_load_KH_ReportTableAdapter
            // 
            this.sp_load_KH_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // sp_LoadSanPhamBindingSource
            // 
            this.sp_LoadSanPhamBindingSource.DataMember = "sp_LoadSanPham";
            this.sp_LoadSanPhamBindingSource.DataSource = this.sHOPGIAYDataSet;
            // 
            // spLoadSanPhamBindingSource2
            // 
            this.spLoadSanPhamBindingSource2.DataMember = "sp_LoadSanPham";
            this.spLoadSanPhamBindingSource2.DataSource = this.sHOPGIAYDataSet;
            // 
            // frmBaocao_SP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 543);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaocao_SP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo sản phẩm";
            this.Load += new System.EventHandler(this.frmBaocao_SP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spLoadSanPhamBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPGIAYDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spLoadSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sploadKHReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LoadSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLoadSanPhamBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_SP;
        private System.Windows.Forms.Panel panel5;
        private SHOPGIAYDataSet sHOPGIAYDataSet;
        private System.Windows.Forms.BindingSource spLoadSanPhamBindingSource;
        private SHOPGIAYDataSetTableAdapters.sp_LoadSanPhamTableAdapter sp_LoadSanPhamTableAdapter;
        private System.Windows.Forms.BindingSource sploadKHReportBindingSource;
        private SHOPGIAYDataSetTableAdapters.sp_load_KH_ReportTableAdapter sp_load_KH_ReportTableAdapter;
        private System.Windows.Forms.BindingSource sp_LoadSanPhamBindingSource;
        private System.Windows.Forms.BindingSource spLoadSanPhamBindingSource1;
        private System.Windows.Forms.BindingSource spLoadSanPhamBindingSource2;
    }
}