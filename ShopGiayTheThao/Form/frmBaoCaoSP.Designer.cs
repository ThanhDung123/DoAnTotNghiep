namespace ShopGiayTheThao.Form
{
    partial class frmBaoCaoSP
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gc_SanPham = new DevExpress.XtraGrid.GridControl();
            this.gv_SanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BE_del_Thuonghieu = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SLE_LoaiBaoCao = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Xuatexel = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Thongke = new System.Windows.Forms.Button();
            this.dtp_dateto = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_datefrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BE_del_Thuonghieu)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SLE_LoaiBaoCao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 88);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ShopGiayTheThao.Properties.Resources.Capture1;
            this.pictureBox1.Location = new System.Drawing.Point(572, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(43, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 33);
            this.label6.TabIndex = 72;
            this.label6.Text = "Báo Cáo Sản Phẩm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 506);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gc_SanPham);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1126, 394);
            this.panel4.TabIndex = 1;
            // 
            // gc_SanPham
            // 
            this.gc_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_SanPham.Location = new System.Drawing.Point(0, 0);
            this.gc_SanPham.MainView = this.gv_SanPham;
            this.gc_SanPham.Name = "gc_SanPham";
            this.gc_SanPham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.BE_del_Thuonghieu});
            this.gc_SanPham.Size = new System.Drawing.Size(1126, 394);
            this.gc_SanPham.TabIndex = 3;
            this.gc_SanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_SanPham});
            // 
            // gv_SanPham
            // 
            this.gv_SanPham.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gv_SanPham.Appearance.Row.Options.UseFont = true;
            this.gv_SanPham.Appearance.Row.Options.UseTextOptions = true;
            this.gv_SanPham.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gv_SanPham.ColumnPanelRowHeight = 40;
            this.gv_SanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3});
            this.gv_SanPham.GridControl = this.gc_SanPham;
            this.gv_SanPham.Name = "gv_SanPham";
            this.gv_SanPham.OptionsView.ShowGroupPanel = false;
            this.gv_SanPham.RowHeight = 30;
            // 
            // BE_del_Thuonghieu
            // 
            this.BE_del_Thuonghieu.AutoHeight = false;
            this.BE_del_Thuonghieu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::ShopGiayTheThao.Properties.Resources.Recycle_bin, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject11, "", null, null, true)});
            this.BE_del_Thuonghieu.Name = "BE_del_Thuonghieu";
            this.BE_del_Thuonghieu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Mã Sản Phẩm";
            this.gridColumn2.FieldName = "MaSanPham";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 53;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Tên Sản Phẩm";
            this.gridColumn3.FieldName = "TenSanPham";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 108;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtp_dateto);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dtp_datefrom);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btn_Xuatexel);
            this.panel3.Controls.Add(this.btn_Thoat);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_Thongke);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.SLE_LoaiBaoCao);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1126, 112);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Loại Báo Cáo :";
            // 
            // SLE_LoaiBaoCao
            // 
            this.SLE_LoaiBaoCao.Location = new System.Drawing.Point(152, 16);
            this.SLE_LoaiBaoCao.Name = "SLE_LoaiBaoCao";
            this.SLE_LoaiBaoCao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLE_LoaiBaoCao.Properties.Appearance.Options.UseFont = true;
            this.SLE_LoaiBaoCao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SLE_LoaiBaoCao.Properties.View = this.searchLookUpEdit1View;
            this.SLE_LoaiBaoCao.Size = new System.Drawing.Size(346, 26);
            this.SLE_LoaiBaoCao.TabIndex = 35;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.searchLookUpEdit1View.AppearancePrint.Row.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.searchLookUpEdit1View.AppearancePrint.Row.Options.UseFont = true;
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn15});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn15
            // 
            this.gridColumn15.AppearanceHeader.BorderColor = System.Drawing.Color.Transparent;
            this.gridColumn15.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn15.AppearanceHeader.ForeColor = System.Drawing.Color.SlateGray;
            this.gridColumn15.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn15.AppearanceHeader.Options.UseFont = true;
            this.gridColumn15.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn15.Caption = "Loại báo cáo";
            this.gridColumn15.FieldName = "text";
            this.gridColumn15.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 0;
            this.gridColumn15.Width = 476;
            // 
            // btn_Xuatexel
            // 
            this.btn_Xuatexel.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Xuatexel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xuatexel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuatexel.ForeColor = System.Drawing.Color.White;
            this.btn_Xuatexel.Image = global::ShopGiayTheThao.Properties.Resources.printer_white_21;
            this.btn_Xuatexel.Location = new System.Drawing.Point(796, 8);
            this.btn_Xuatexel.Name = "btn_Xuatexel";
            this.btn_Xuatexel.Size = new System.Drawing.Size(100, 78);
            this.btn_Xuatexel.TabIndex = 121;
            this.btn_Xuatexel.Text = "Xuất Excel (F2)";
            this.btn_Xuatexel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Xuatexel.UseVisualStyleBackColor = false;
            this.btn_Xuatexel.Click += new System.EventHandler(this.btn_Xuatexel_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Image = global::ShopGiayTheThao.Properties.Resources.Login;
            this.btn_Thoat.Location = new System.Drawing.Point(1002, 7);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(108, 78);
            this.btn_Thoat.TabIndex = 120;
            this.btn_Thoat.Text = "Thoát (ESC)";
            this.btn_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ShopGiayTheThao.Properties.Resources.Refresh_32x32;
            this.button1.Location = new System.Drawing.Point(902, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 78);
            this.button1.TabIndex = 119;
            this.button1.Text = "Làm Mới (F3)";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Thongke
            // 
            this.btn_Thongke.BackColor = System.Drawing.Color.Olive;
            this.btn_Thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thongke.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thongke.ForeColor = System.Drawing.Color.White;
            this.btn_Thongke.Image = global::ShopGiayTheThao.Properties.Resources.Zoom;
            this.btn_Thongke.Location = new System.Drawing.Point(693, 7);
            this.btn_Thongke.Name = "btn_Thongke";
            this.btn_Thongke.Size = new System.Drawing.Size(100, 78);
            this.btn_Thongke.TabIndex = 118;
            this.btn_Thongke.Text = "Thống kê (F1)";
            this.btn_Thongke.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Thongke.UseVisualStyleBackColor = false;
            this.btn_Thongke.Click += new System.EventHandler(this.btn_Thongke_Click);
            // 
            // dtp_dateto
            // 
            this.dtp_dateto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateto.Location = new System.Drawing.Point(488, 57);
            this.dtp_dateto.Name = "dtp_dateto";
            this.dtp_dateto.Size = new System.Drawing.Size(200, 26);
            this.dtp_dateto.TabIndex = 124;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 125;
            this.label4.Text = "Đến Ngày :";
            // 
            // dtp_datefrom
            // 
            this.dtp_datefrom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_datefrom.Location = new System.Drawing.Point(152, 56);
            this.dtp_datefrom.Name = "dtp_datefrom";
            this.dtp_datefrom.Size = new System.Drawing.Size(200, 26);
            this.dtp_datefrom.TabIndex = 122;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 123;
            this.label5.Text = "Từ Ngày :";
            // 
            // frmBaoCaoSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaoCaoSP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCaoSP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_SanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BE_del_Thuonghieu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SLE_LoaiBaoCao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl gc_SanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_SanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BE_del_Thuonghieu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SearchLookUpEdit SLE_LoaiBaoCao;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Xuatexel;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Thongke;
        private System.Windows.Forms.DateTimePicker dtp_dateto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_datefrom;
        private System.Windows.Forms.Label label5;
    }
}