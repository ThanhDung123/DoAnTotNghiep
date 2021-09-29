namespace ShopGiayTheThao.Report
{
    partial class frmMenu_LoaiBaoCao
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_NV = new System.Windows.Forms.Button();
            this.btn_KH = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_SP = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(747, 90);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ShopGiayTheThao.Properties.Resources.Capture1;
            this.pictureBox1.Location = new System.Drawing.Point(194, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(221, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "CHỌN LOẠI BÁO CÁO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_NV);
            this.groupBox1.Controls.Add(this.btn_KH);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btn_SP);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Báo Cáo";
            // 
            // btn_NV
            // 
            this.btn_NV.BackColor = System.Drawing.Color.Olive;
            this.btn_NV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NV.ForeColor = System.Drawing.Color.White;
            this.btn_NV.Image = global::ShopGiayTheThao.Properties.Resources.Bird;
            this.btn_NV.Location = new System.Drawing.Point(397, 40);
            this.btn_NV.Name = "btn_NV";
            this.btn_NV.Size = new System.Drawing.Size(113, 68);
            this.btn_NV.TabIndex = 100;
            this.btn_NV.Text = "Nhân Viên";
            this.btn_NV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_NV.UseVisualStyleBackColor = false;
            this.btn_NV.Click += new System.EventHandler(this.btn_NV_Click);
            // 
            // btn_KH
            // 
            this.btn_KH.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_KH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KH.ForeColor = System.Drawing.Color.White;
            this.btn_KH.Image = global::ShopGiayTheThao.Properties.Resources.Alien;
            this.btn_KH.Location = new System.Drawing.Point(216, 40);
            this.btn_KH.Name = "btn_KH";
            this.btn_KH.Size = new System.Drawing.Size(113, 68);
            this.btn_KH.TabIndex = 99;
            this.btn_KH.Text = "Khách Hàng";
            this.btn_KH.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_KH.UseVisualStyleBackColor = false;
            this.btn_KH.Click += new System.EventHandler(this.btn_KH_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.DimGray;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Image = global::ShopGiayTheThao.Properties.Resources.Exit;
            this.btn_Thoat.Location = new System.Drawing.Point(580, 40);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(113, 68);
            this.btn_Thoat.TabIndex = 98;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_SP
            // 
            this.btn_SP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_SP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SP.ForeColor = System.Drawing.Color.White;
            this.btn_SP.Image = global::ShopGiayTheThao.Properties.Resources.Buddy;
            this.btn_SP.Location = new System.Drawing.Point(58, 40);
            this.btn_SP.Name = "btn_SP";
            this.btn_SP.Size = new System.Drawing.Size(113, 68);
            this.btn_SP.TabIndex = 97;
            this.btn_SP.Text = "Sản Phẩm";
            this.btn_SP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_SP.UseVisualStyleBackColor = false;
            this.btn_SP.Click += new System.EventHandler(this.btn_SP_Click);
            // 
            // frmMenu_LoaiBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu_LoaiBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Báo Cáo";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SP;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_KH;
        private System.Windows.Forms.Button btn_NV;
    }
}