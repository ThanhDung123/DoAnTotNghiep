namespace ShopGiayTheThao.Form
{
    partial class frmNhanVien
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gc_NhanVien = new DevExpress.XtraGrid.GridControl();
            this.gv_NhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BE_del_Thuonghieu = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdb_nu = new System.Windows.Forms.RadioButton();
            this.rdbs_nam = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_CN = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DT = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BE_del_Thuonghieu)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 84);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ShopGiayTheThao.Properties.Resources.Capture1;
            this.pictureBox1.Location = new System.Drawing.Point(415, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Nhân Viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 468);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gc_NhanVien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 256);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // gc_NhanVien
            // 
            this.gc_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_NhanVien.Location = new System.Drawing.Point(3, 22);
            this.gc_NhanVien.MainView = this.gv_NhanVien;
            this.gc_NhanVien.Name = "gc_NhanVien";
            this.gc_NhanVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.BE_del_Thuonghieu});
            this.gc_NhanVien.Size = new System.Drawing.Size(963, 231);
            this.gc_NhanVien.TabIndex = 9;
            this.gc_NhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_NhanVien});
            // 
            // gv_NhanVien
            // 
            this.gv_NhanVien.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.gv_NhanVien.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gv_NhanVien.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gv_NhanVien.Appearance.Row.Options.UseFont = true;
            this.gv_NhanVien.Appearance.Row.Options.UseTextOptions = true;
            this.gv_NhanVien.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gv_NhanVien.ColumnPanelRowHeight = 40;
            this.gv_NhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gv_NhanVien.GridControl = this.gc_NhanVien;
            this.gv_NhanVien.Name = "gv_NhanVien";
            this.gv_NhanVien.OptionsBehavior.ReadOnly = true;
            this.gv_NhanVien.OptionsSelection.MultiSelect = true;
            this.gv_NhanVien.RowHeight = 30;
            this.gv_NhanVien.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_NhanVien_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Xóa";
            this.gridColumn1.ColumnEdit = this.BE_del_Thuonghieu;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 32;
            // 
            // BE_del_Thuonghieu
            // 
            this.BE_del_Thuonghieu.AutoHeight = false;
            this.BE_del_Thuonghieu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::ShopGiayTheThao.Properties.Resources.Recycle_bin, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.BE_del_Thuonghieu.Name = "BE_del_Thuonghieu";
            this.BE_del_Thuonghieu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.BE_del_Thuonghieu.Click += new System.EventHandler(this.BE_del_Thuonghieu_Click);
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Mã Nhân Viên";
            this.gridColumn2.FieldName = "MaNhanVien";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 66;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Tên Nhân Viên";
            this.gridColumn3.FieldName = "TenNhanVien";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 155;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Giới Tính";
            this.gridColumn4.FieldName = "GioiTinh";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 74;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Địa Chỉ";
            this.gridColumn5.FieldName = "DiaChi";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 132;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Điện Thoại";
            this.gridColumn6.FieldName = "DienThoai";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 88;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Ngày Sinh";
            this.gridColumn7.FieldName = "NgaySinh";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 90;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtp_NgaySinh);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_DT);
            this.panel3.Controls.Add(this.txt_DiaChi);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_TenNV);
            this.panel3.Controls.Add(this.txt_MaNV);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 212);
            this.panel3.TabIndex = 9;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(641, 91);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(228, 27);
            this.dtp_NgaySinh.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rdb_nu);
            this.panel5.Controls.Add(this.rdbs_nam);
            this.panel5.Location = new System.Drawing.Point(207, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 37);
            this.panel5.TabIndex = 17;
            // 
            // rdb_nu
            // 
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.Location = new System.Drawing.Point(180, 11);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Size = new System.Drawing.Size(39, 17);
            this.rdb_nu.TabIndex = 9;
            this.rdb_nu.TabStop = true;
            this.rdb_nu.Text = "Nữ";
            this.rdb_nu.UseVisualStyleBackColor = true;
            // 
            // rdbs_nam
            // 
            this.rdbs_nam.AutoSize = true;
            this.rdbs_nam.Location = new System.Drawing.Point(51, 11);
            this.rdbs_nam.Name = "rdbs_nam";
            this.rdbs_nam.Size = new System.Drawing.Size(46, 17);
            this.rdbs_nam.TabIndex = 8;
            this.rdbs_nam.TabStop = true;
            this.rdbs_nam.Text = "Nam";
            this.rdbs_nam.UseVisualStyleBackColor = true;
            this.rdbs_nam.CheckedChanged += new System.EventHandler(this.rdbs_nam_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_CN);
            this.panel4.Controls.Add(this.btn_Thoat);
            this.panel4.Controls.Add(this.btn_Luu);
            this.panel4.Controls.Add(this.btn_Sua);
            this.panel4.Controls.Add(this.btn_Them);
            this.panel4.Location = new System.Drawing.Point(90, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(779, 81);
            this.panel4.TabIndex = 16;
            // 
            // btn_CN
            // 
            this.btn_CN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CN.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CN.ForeColor = System.Drawing.Color.White;
            this.btn_CN.Image = global::ShopGiayTheThao.Properties.Resources.Refresh_32x32;
            this.btn_CN.Location = new System.Drawing.Point(480, 4);
            this.btn_CN.Name = "btn_CN";
            this.btn_CN.Size = new System.Drawing.Size(102, 70);
            this.btn_CN.TabIndex = 16;
            this.btn_CN.Text = "Cập Nhật (F4)";
            this.btn_CN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_CN.UseVisualStyleBackColor = false;
            this.btn_CN.Click += new System.EventHandler(this.btn_CN_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Image = global::ShopGiayTheThao.Properties.Resources.Login;
            this.btn_Thoat.Location = new System.Drawing.Point(587, 3);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(106, 68);
            this.btn_Thoat.TabIndex = 17;
            this.btn_Thoat.Text = "Thoát (ESC)";
            this.btn_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Image = global::ShopGiayTheThao.Properties.Resources.Apply;
            this.btn_Luu.Location = new System.Drawing.Point(270, 5);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(101, 68);
            this.btn_Luu.TabIndex = 14;
            this.btn_Luu.Text = "Lưu (F2)";
            this.btn_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Teal;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = global::ShopGiayTheThao.Properties.Resources.Maintenance;
            this.btn_Sua.Location = new System.Drawing.Point(377, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(97, 68);
            this.btn_Sua.TabIndex = 15;
            this.btn_Sua.Text = "Sửa (F3)";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Olive;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Image = global::ShopGiayTheThao.Properties.Resources.Add;
            this.btn_Them.Location = new System.Drawing.Point(165, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(99, 68);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.Text = "Thêm (F1)";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(523, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày Sinh :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giới Tính :";
            // 
            // txt_DT
            // 
            this.txt_DT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DT.Location = new System.Drawing.Point(641, 48);
            this.txt_DT.Multiline = true;
            this.txt_DT.Name = "txt_DT";
            this.txt_DT.ReadOnly = true;
            this.txt_DT.Size = new System.Drawing.Size(227, 32);
            this.txt_DT.TabIndex = 11;
            this.txt_DT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(641, 8);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.ReadOnly = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(227, 32);
            this.txt_DiaChi.TabIndex = 10;
            this.txt_DiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(522, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Điện Thoại :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa Chỉ :";
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNV.Location = new System.Drawing.Point(230, 48);
            this.txt_TenNV.Multiline = true;
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.ReadOnly = true;
            this.txt_TenNV.Size = new System.Drawing.Size(255, 32);
            this.txt_TenNV.TabIndex = 7;
            this.txt_TenNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(230, 8);
            this.txt_MaNV.Multiline = true;
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.ReadOnly = true;
            this.txt_MaNV.Size = new System.Drawing.Size(253, 34);
            this.txt_MaNV.TabIndex = 6;
            this.txt_MaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Nhân Viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Nhân Viên :";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BE_del_Thuonghieu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdb_nu;
        private System.Windows.Forms.RadioButton rdbs_nam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_CN;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DT;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gc_NhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_NhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BE_del_Thuonghieu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}