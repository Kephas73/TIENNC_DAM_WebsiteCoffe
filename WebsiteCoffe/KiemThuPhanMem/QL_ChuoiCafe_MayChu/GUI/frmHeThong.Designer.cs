namespace GUI
{
    partial class frmHeThong
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
            this.pnBangDieuKhien_Show = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNgay = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.btSanPham = new System.Windows.Forms.Button();
            this.btLoaiSanPham = new System.Windows.Forms.Button();
            this.pnSlide_R = new System.Windows.Forms.Panel();
            this.pnSlide_L = new System.Windows.Forms.Panel();
            this.btTrangChu = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.pbTrangChu = new System.Windows.Forms.PictureBox();
            this.ucQuanLy_SanPham1 = new GUI.ucQuanLy_SanPham();
            this.ucQuanLy_LoaiSanPham1 = new GUI.ucQuanLy_LoaiSanPham();
            this.ucNhanVien1 = new GUI.ucNhanVien();
            this.pnRibbon = new System.Windows.Forms.Panel();
            this.btNhanVien_Hide = new System.Windows.Forms.Button();
            this.btSanPham_Hide = new System.Windows.Forms.Button();
            this.btLoaiSanPham_Hide = new System.Windows.Forms.Button();
            this.btTrangChu_Hide = new System.Windows.Forms.Button();
            this.btExit_Hide = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            this.pnSlide_Hide = new System.Windows.Forms.Panel();
            this.pnBangDieuKhien_Hide = new System.Windows.Forms.Panel();
            this.pnBangDieuKhien_Show.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrangChu)).BeginInit();
            this.pnBangDieuKhien_Hide.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBangDieuKhien_Show
            // 
            this.pnBangDieuKhien_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnBangDieuKhien_Show.Controls.Add(this.pictureBox1);
            this.pnBangDieuKhien_Show.Controls.Add(this.lbNgay);
            this.pnBangDieuKhien_Show.Controls.Add(this.btExit);
            this.pnBangDieuKhien_Show.Controls.Add(this.btNhanVien);
            this.pnBangDieuKhien_Show.Controls.Add(this.btSanPham);
            this.pnBangDieuKhien_Show.Controls.Add(this.btLoaiSanPham);
            this.pnBangDieuKhien_Show.Controls.Add(this.pnSlide_R);
            this.pnBangDieuKhien_Show.Controls.Add(this.pnSlide_L);
            this.pnBangDieuKhien_Show.Controls.Add(this.btTrangChu);
            this.pnBangDieuKhien_Show.Controls.Add(this.btBack);
            this.pnBangDieuKhien_Show.Location = new System.Drawing.Point(0, 22);
            this.pnBangDieuKhien_Show.Name = "pnBangDieuKhien_Show";
            this.pnBangDieuKhien_Show.Size = new System.Drawing.Size(226, 693);
            this.pnBangDieuKhien_Show.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(85, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lbNgay.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNgay.Location = new System.Drawing.Point(35, 109);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(47, 19);
            this.lbNgay.TabIndex = 9;
            this.lbNgay.Text = "Ngày";
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExit.Image = global::GUI.Properties.Resources.power_button_off;
            this.btExit.Location = new System.Drawing.Point(85, 451);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(48, 40);
            this.btExit.TabIndex = 5;
            this.btExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btNhanVien
            // 
            this.btNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btNhanVien.FlatAppearance.BorderSize = 0;
            this.btNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNhanVien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNhanVien.Image = global::GUI.Properties.Resources.group;
            this.btNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNhanVien.Location = new System.Drawing.Point(34, 359);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(180, 52);
            this.btNhanVien.TabIndex = 6;
            this.btNhanVien.Text = "Nhân Sự";
            this.btNhanVien.UseVisualStyleBackColor = false;
            this.btNhanVien.Click += new System.EventHandler(this.btNhanVien_Click);
            // 
            // btSanPham
            // 
            this.btSanPham.BackColor = System.Drawing.Color.Transparent;
            this.btSanPham.FlatAppearance.BorderSize = 0;
            this.btSanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSanPham.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSanPham.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSanPham.Image = global::GUI.Properties.Resources.coffee_cup1;
            this.btSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSanPham.Location = new System.Drawing.Point(34, 301);
            this.btSanPham.Name = "btSanPham";
            this.btSanPham.Size = new System.Drawing.Size(180, 52);
            this.btSanPham.TabIndex = 6;
            this.btSanPham.Text = "Sản Phẩm";
            this.btSanPham.UseVisualStyleBackColor = false;
            this.btSanPham.Click += new System.EventHandler(this.btSanPham_Click);
            // 
            // btLoaiSanPham
            // 
            this.btLoaiSanPham.BackColor = System.Drawing.Color.Transparent;
            this.btLoaiSanPham.FlatAppearance.BorderSize = 0;
            this.btLoaiSanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btLoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoaiSanPham.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoaiSanPham.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLoaiSanPham.Image = global::GUI.Properties.Resources.coffee_cup1;
            this.btLoaiSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLoaiSanPham.Location = new System.Drawing.Point(34, 243);
            this.btLoaiSanPham.Name = "btLoaiSanPham";
            this.btLoaiSanPham.Size = new System.Drawing.Size(180, 52);
            this.btLoaiSanPham.TabIndex = 5;
            this.btLoaiSanPham.Text = "    Loại Sản Phẩm";
            this.btLoaiSanPham.UseVisualStyleBackColor = false;
            this.btLoaiSanPham.Click += new System.EventHandler(this.btLoaiSanPham_Click);
            // 
            // pnSlide_R
            // 
            this.pnSlide_R.BackColor = System.Drawing.Color.Brown;
            this.pnSlide_R.Location = new System.Drawing.Point(212, 185);
            this.pnSlide_R.Name = "pnSlide_R";
            this.pnSlide_R.Size = new System.Drawing.Size(13, 52);
            this.pnSlide_R.TabIndex = 4;
            // 
            // pnSlide_L
            // 
            this.pnSlide_L.BackColor = System.Drawing.Color.Brown;
            this.pnSlide_L.Location = new System.Drawing.Point(21, 185);
            this.pnSlide_L.Name = "pnSlide_L";
            this.pnSlide_L.Size = new System.Drawing.Size(13, 52);
            this.pnSlide_L.TabIndex = 3;
            // 
            // btTrangChu
            // 
            this.btTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btTrangChu.FlatAppearance.BorderSize = 0;
            this.btTrangChu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTrangChu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrangChu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTrangChu.Image = global::GUI.Properties.Resources.home;
            this.btTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTrangChu.Location = new System.Drawing.Point(34, 185);
            this.btTrangChu.Name = "btTrangChu";
            this.btTrangChu.Size = new System.Drawing.Size(180, 52);
            this.btTrangChu.TabIndex = 3;
            this.btTrangChu.Text = "Trang Chủ";
            this.btTrangChu.UseVisualStyleBackColor = false;
            this.btTrangChu.Click += new System.EventHandler(this.btTrangChu_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Transparent;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBack.Image = global::GUI.Properties.Resources.left_arrow;
            this.btBack.Location = new System.Drawing.Point(167, 0);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(59, 56);
            this.btBack.TabIndex = 4;
            this.btBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // pbTrangChu
            // 
            this.pbTrangChu.Image = global::GUI.Properties.Resources.rsz_picture4;
            this.pbTrangChu.Location = new System.Drawing.Point(389, 281);
            this.pbTrangChu.Name = "pbTrangChu";
            this.pbTrangChu.Size = new System.Drawing.Size(627, 300);
            this.pbTrangChu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTrangChu.TabIndex = 3;
            this.pbTrangChu.TabStop = false;
            // 
            // ucQuanLy_SanPham1
            // 
            this.ucQuanLy_SanPham1.Location = new System.Drawing.Point(242, 132);
            this.ucQuanLy_SanPham1.Name = "ucQuanLy_SanPham1";
            this.ucQuanLy_SanPham1.Size = new System.Drawing.Size(1039, 500);
            this.ucQuanLy_SanPham1.TabIndex = 6;
            // 
            // ucQuanLy_LoaiSanPham1
            // 
            this.ucQuanLy_LoaiSanPham1.Location = new System.Drawing.Point(242, 152);
            this.ucQuanLy_LoaiSanPham1.Name = "ucQuanLy_LoaiSanPham1";
            this.ucQuanLy_LoaiSanPham1.Size = new System.Drawing.Size(1063, 480);
            this.ucQuanLy_LoaiSanPham1.TabIndex = 5;
            // 
            // ucNhanVien1
            // 
            this.ucNhanVien1.Location = new System.Drawing.Point(242, 167);
            this.ucNhanVien1.Name = "ucNhanVien1";
            this.ucNhanVien1.Size = new System.Drawing.Size(1047, 508);
            this.ucNhanVien1.TabIndex = 4;
            // 
            // pnRibbon
            // 
            this.pnRibbon.BackColor = System.Drawing.Color.Brown;
            this.pnRibbon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnRibbon.Location = new System.Drawing.Point(0, 0);
            this.pnRibbon.Name = "pnRibbon";
            this.pnRibbon.Size = new System.Drawing.Size(1317, 22);
            this.pnRibbon.TabIndex = 10;
            // 
            // btNhanVien_Hide
            // 
            this.btNhanVien_Hide.BackColor = System.Drawing.Color.Transparent;
            this.btNhanVien_Hide.FlatAppearance.BorderSize = 0;
            this.btNhanVien_Hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btNhanVien_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNhanVien_Hide.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhanVien_Hide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNhanVien_Hide.Image = global::GUI.Properties.Resources.group;
            this.btNhanVien_Hide.Location = new System.Drawing.Point(7, 359);
            this.btNhanVien_Hide.Name = "btNhanVien_Hide";
            this.btNhanVien_Hide.Size = new System.Drawing.Size(51, 52);
            this.btNhanVien_Hide.TabIndex = 13;
            this.btNhanVien_Hide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNhanVien_Hide.UseVisualStyleBackColor = false;
            this.btNhanVien_Hide.Click += new System.EventHandler(this.btNhanVien_Click);
            // 
            // btSanPham_Hide
            // 
            this.btSanPham_Hide.BackColor = System.Drawing.Color.Transparent;
            this.btSanPham_Hide.FlatAppearance.BorderSize = 0;
            this.btSanPham_Hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btSanPham_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSanPham_Hide.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSanPham_Hide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSanPham_Hide.Image = global::GUI.Properties.Resources.coffee_cup1;
            this.btSanPham_Hide.Location = new System.Drawing.Point(6, 301);
            this.btSanPham_Hide.Name = "btSanPham_Hide";
            this.btSanPham_Hide.Size = new System.Drawing.Size(52, 52);
            this.btSanPham_Hide.TabIndex = 14;
            this.btSanPham_Hide.UseVisualStyleBackColor = false;
            this.btSanPham_Hide.Click += new System.EventHandler(this.btSanPham_Click);
            // 
            // btLoaiSanPham_Hide
            // 
            this.btLoaiSanPham_Hide.BackColor = System.Drawing.Color.Transparent;
            this.btLoaiSanPham_Hide.FlatAppearance.BorderSize = 0;
            this.btLoaiSanPham_Hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btLoaiSanPham_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoaiSanPham_Hide.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoaiSanPham_Hide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLoaiSanPham_Hide.Image = global::GUI.Properties.Resources.coffee_cup1;
            this.btLoaiSanPham_Hide.Location = new System.Drawing.Point(7, 243);
            this.btLoaiSanPham_Hide.Name = "btLoaiSanPham_Hide";
            this.btLoaiSanPham_Hide.Size = new System.Drawing.Size(51, 52);
            this.btLoaiSanPham_Hide.TabIndex = 10;
            this.btLoaiSanPham_Hide.UseVisualStyleBackColor = false;
            this.btLoaiSanPham_Hide.Click += new System.EventHandler(this.btLoaiSanPham_Click);
            // 
            // btTrangChu_Hide
            // 
            this.btTrangChu_Hide.BackColor = System.Drawing.Color.Transparent;
            this.btTrangChu_Hide.FlatAppearance.BorderSize = 0;
            this.btTrangChu_Hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btTrangChu_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTrangChu_Hide.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrangChu_Hide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTrangChu_Hide.Image = global::GUI.Properties.Resources.home;
            this.btTrangChu_Hide.Location = new System.Drawing.Point(6, 185);
            this.btTrangChu_Hide.Name = "btTrangChu_Hide";
            this.btTrangChu_Hide.Size = new System.Drawing.Size(52, 52);
            this.btTrangChu_Hide.TabIndex = 8;
            this.btTrangChu_Hide.UseVisualStyleBackColor = false;
            this.btTrangChu_Hide.Click += new System.EventHandler(this.btTrangChu_Click);
            // 
            // btExit_Hide
            // 
            this.btExit_Hide.BackColor = System.Drawing.Color.Transparent;
            this.btExit_Hide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit_Hide.FlatAppearance.BorderSize = 0;
            this.btExit_Hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btExit_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit_Hide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExit_Hide.Image = global::GUI.Properties.Resources.power_button_off;
            this.btExit_Hide.Location = new System.Drawing.Point(7, 616);
            this.btExit_Hide.Name = "btExit_Hide";
            this.btExit_Hide.Size = new System.Drawing.Size(48, 40);
            this.btExit_Hide.TabIndex = 9;
            this.btExit_Hide.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExit_Hide.UseVisualStyleBackColor = false;
            this.btExit_Hide.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btMenu
            // 
            this.btMenu.BackColor = System.Drawing.Color.Transparent;
            this.btMenu.FlatAppearance.BorderSize = 0;
            this.btMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMenu.Image = global::GUI.Properties.Resources.menu;
            this.btMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMenu.Location = new System.Drawing.Point(7, -1);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(51, 54);
            this.btMenu.TabIndex = 3;
            this.btMenu.Text = "Menu";
            this.btMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMenu.UseVisualStyleBackColor = false;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // pnSlide_Hide
            // 
            this.pnSlide_Hide.BackColor = System.Drawing.Color.Brown;
            this.pnSlide_Hide.Location = new System.Drawing.Point(52, 185);
            this.pnSlide_Hide.Name = "pnSlide_Hide";
            this.pnSlide_Hide.Size = new System.Drawing.Size(6, 52);
            this.pnSlide_Hide.TabIndex = 16;
            // 
            // pnBangDieuKhien_Hide
            // 
            this.pnBangDieuKhien_Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnBangDieuKhien_Hide.Controls.Add(this.pnSlide_Hide);
            this.pnBangDieuKhien_Hide.Controls.Add(this.btMenu);
            this.pnBangDieuKhien_Hide.Controls.Add(this.btExit_Hide);
            this.pnBangDieuKhien_Hide.Controls.Add(this.btTrangChu_Hide);
            this.pnBangDieuKhien_Hide.Controls.Add(this.btLoaiSanPham_Hide);
            this.pnBangDieuKhien_Hide.Controls.Add(this.btSanPham_Hide);
            this.pnBangDieuKhien_Hide.Controls.Add(this.btNhanVien_Hide);
            this.pnBangDieuKhien_Hide.Location = new System.Drawing.Point(-6, 19);
            this.pnBangDieuKhien_Hide.Name = "pnBangDieuKhien_Hide";
            this.pnBangDieuKhien_Hide.Size = new System.Drawing.Size(58, 696);
            this.pnBangDieuKhien_Hide.TabIndex = 1;
            // 
            // frmHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btExit_Hide;
            this.ClientSize = new System.Drawing.Size(1317, 715);
            this.Controls.Add(this.pnBangDieuKhien_Show);
            this.Controls.Add(this.pnRibbon);
            this.Controls.Add(this.ucQuanLy_SanPham1);
            this.Controls.Add(this.ucQuanLy_LoaiSanPham1);
            this.Controls.Add(this.ucNhanVien1);
            this.Controls.Add(this.pbTrangChu);
            this.Controls.Add(this.pnBangDieuKhien_Hide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống";
            this.Load += new System.EventHandler(this.frmHeThong_Load);
            this.pnBangDieuKhien_Show.ResumeLayout(false);
            this.pnBangDieuKhien_Show.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrangChu)).EndInit();
            this.pnBangDieuKhien_Hide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnBangDieuKhien_Show;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btTrangChu;
        private System.Windows.Forms.Button btLoaiSanPham;
        private System.Windows.Forms.Panel pnSlide_R;
        private System.Windows.Forms.Panel pnSlide_L;
        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.Button btSanPham;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.PictureBox pbTrangChu;
        private ucNhanVien ucNhanVien1;
        private ucQuanLy_LoaiSanPham ucQuanLy_LoaiSanPham1;
        private ucQuanLy_SanPham ucQuanLy_SanPham1;
      
       
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnRibbon;
        private System.Windows.Forms.Button btNhanVien_Hide;
        private System.Windows.Forms.Button btSanPham_Hide;
        private System.Windows.Forms.Button btLoaiSanPham_Hide;
        private System.Windows.Forms.Button btTrangChu_Hide;
        private System.Windows.Forms.Button btExit_Hide;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Panel pnSlide_Hide;
        private System.Windows.Forms.Panel pnBangDieuKhien_Hide;
    }
}

