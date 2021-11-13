namespace ShopGiayTheThao.Form
{
    partial class frmThemTaiKhoan
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_ThemTK = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_matkhau2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SLE_nhanvien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_loaiTK = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLE_nhanvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::ShopGiayTheThao.Properties.Resources.Capture1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(671, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(232, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 33);
            this.label6.TabIndex = 106;
            this.label6.Text = "TẠO TÀI KHOẢN";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(273, 245);
            this.txt_matkhau.Multiline = true;
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(227, 32);
            this.txt_matkhau.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 110;
            this.label2.Text = "Loại Tài Khoản :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 109;
            this.label1.Text = "Mật Khẩu :";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taikhoan.Location = new System.Drawing.Point(273, 205);
            this.txt_taikhoan.Multiline = true;
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.ReadOnly = true;
            this.txt_taikhoan.Size = new System.Drawing.Size(227, 32);
            this.txt_taikhoan.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(149, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 19);
            this.label16.TabIndex = 107;
            this.label16.Text = "Tài Khoản :";
            // 
            // btn_ThemTK
            // 
            this.btn_ThemTK.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_ThemTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemTK.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTK.ForeColor = System.Drawing.Color.White;
            this.btn_ThemTK.Image = global::ShopGiayTheThao.Properties.Resources.Apply;
            this.btn_ThemTK.Location = new System.Drawing.Point(250, 393);
            this.btn_ThemTK.Name = "btn_ThemTK";
            this.btn_ThemTK.Size = new System.Drawing.Size(121, 56);
            this.btn_ThemTK.TabIndex = 6;
            this.btn_ThemTK.Text = "Thêm (F1)";
            this.btn_ThemTK.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_ThemTK.UseVisualStyleBackColor = false;
            this.btn_ThemTK.Click += new System.EventHandler(this.btn_ThemTK_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Image = global::ShopGiayTheThao.Properties.Resources.Login;
            this.btn_thoat.Location = new System.Drawing.Point(377, 393);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(121, 56);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát (ESC)";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_matkhau2
            // 
            this.txt_matkhau2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau2.Location = new System.Drawing.Point(273, 288);
            this.txt_matkhau2.Multiline = true;
            this.txt_matkhau2.Name = "txt_matkhau2";
            this.txt_matkhau2.PasswordChar = '*';
            this.txt_matkhau2.Size = new System.Drawing.Size(227, 32);
            this.txt_matkhau2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 115;
            this.label3.Text = "Nhập Lại Mật Khẩu :";
            // 
            // SLE_nhanvien
            // 
            this.SLE_nhanvien.EditValue = " ";
            this.SLE_nhanvien.Location = new System.Drawing.Point(273, 162);
            this.SLE_nhanvien.Name = "SLE_nhanvien";
            this.SLE_nhanvien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLE_nhanvien.Properties.Appearance.Options.UseFont = true;
            this.SLE_nhanvien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SLE_nhanvien.Properties.View = this.searchLookUpEdit1View;
            this.SLE_nhanvien.Size = new System.Drawing.Size(227, 28);
            this.SLE_nhanvien.TabIndex = 1;
            this.SLE_nhanvien.EditValueChanged += new System.EventHandler(this.SLE_nhanvien_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Nhân Viên";
            this.gridColumn1.FieldName = "TenNhanVien";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 119;
            this.label4.Text = "Nhân Viên :";
            // 
            // cbo_loaiTK
            // 
            this.cbo_loaiTK.Enabled = false;
            this.cbo_loaiTK.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_loaiTK.FormattingEnabled = true;
            this.cbo_loaiTK.Location = new System.Drawing.Point(273, 333);
            this.cbo_loaiTK.Name = "cbo_loaiTK";
            this.cbo_loaiTK.Size = new System.Drawing.Size(121, 26);
            this.cbo_loaiTK.TabIndex = 121;
            // 
            // frmThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 489);
            this.Controls.Add(this.cbo_loaiTK);
            this.Controls.Add(this.SLE_nhanvien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_matkhau2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_ThemTK);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Tài Khoản";
            this.Load += new System.EventHandler(this.frmTemTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLE_nhanvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_ThemTK;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_matkhau2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SearchLookUpEdit SLE_nhanvien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_loaiTK;
    }
}