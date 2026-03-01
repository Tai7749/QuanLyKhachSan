namespace QuanLyKhachSan.WinForms.Forms
{
    partial class frmDangKy
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
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            this.btnXacNhan = new ReaLTaiizor.Controls.CyberButton();
            this.txtMatKhau = new ReaLTaiizor.Controls.BigTextBox();
            this.txtTaiKhoan = new ReaLTaiizor.Controls.BigTextBox();
            this.cbxMaNhanVien = new ReaLTaiizor.Controls.MetroComboBox();
            this.txtNhapLaiMatKhau = new ReaLTaiizor.Controls.BigTextBox();
            this.cbxMaBoPhan = new ReaLTaiizor.Controls.MetroComboBox();
            this.parrotGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(248, 52);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(151, 46);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Đăng ký";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.Fuchsia;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.cbxMaBoPhan);
            this.parrotGradientPanel1.Controls.Add(this.cbxMaNhanVien);
            this.parrotGradientPanel1.Controls.Add(this.btnXacNhan);
            this.parrotGradientPanel1.Controls.Add(this.txtNhapLaiMatKhau);
            this.parrotGradientPanel1.Controls.Add(this.txtMatKhau);
            this.parrotGradientPanel1.Controls.Add(this.txtTaiKhoan);
            this.parrotGradientPanel1.Controls.Add(this.metroControlBox1);
            this.parrotGradientPanel1.Controls.Add(this.bigLabel1);
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(639, 365);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Vertical;
            this.parrotGradientPanel1.TabIndex = 0;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // metroControlBox1
            // 
            this.metroControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroControlBox1.CloseNormalForeColor = System.Drawing.Color.White;
            this.metroControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroControlBox1.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            this.metroControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroControlBox1.IsDerivedStyle = true;
            this.metroControlBox1.Location = new System.Drawing.Point(-3, -2);
            this.metroControlBox1.MaximizeBox = false;
            this.metroControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.metroControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.metroControlBox1.MaximizeNormalForeColor = System.Drawing.Color.White;
            this.metroControlBox1.MinimizeBox = true;
            this.metroControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.metroControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.metroControlBox1.MinimizeNormalForeColor = System.Drawing.Color.White;
            this.metroControlBox1.Name = "metroControlBox1";
            this.metroControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroControlBox1.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            this.metroControlBox1.StyleManager = null;
            this.metroControlBox1.TabIndex = 4;
            this.metroControlBox1.Text = "metroControlBox1";
            this.metroControlBox1.ThemeAuthor = "Taiizor";
            this.metroControlBox1.ThemeName = "MetroLight";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Alpha = 20;
            this.btnXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacNhan.Background = true;
            this.btnXacNhan.Background_WidthPen = 4F;
            this.btnXacNhan.BackgroundPen = true;
            this.btnXacNhan.ColorBackground = System.Drawing.Color.White;
            this.btnXacNhan.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnXacNhan.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnXacNhan.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnXacNhan.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnXacNhan.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnXacNhan.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnXacNhan.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnXacNhan.Effect_1 = true;
            this.btnXacNhan.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnXacNhan.Effect_1_Transparency = 25;
            this.btnXacNhan.Effect_2 = true;
            this.btnXacNhan.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnXacNhan.Effect_2_Transparency = 20;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnXacNhan.Lighting = false;
            this.btnXacNhan.LinearGradient_Background = false;
            this.btnXacNhan.LinearGradientPen = false;
            this.btnXacNhan.Location = new System.Drawing.Point(254, 279);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.PenWidth = 15;
            this.btnXacNhan.Rounding = true;
            this.btnXacNhan.RoundingInt = 70;
            this.btnXacNhan.Size = new System.Drawing.Size(130, 52);
            this.btnXacNhan.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnXacNhan.TabIndex = 8;
            this.btnXacNhan.Tag = "Cyber";
            this.btnXacNhan.TextButton = "Xác Nhận";
            this.btnXacNhan.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnXacNhan.Timer_Effect_1 = 5;
            this.btnXacNhan.Timer_RGB = 300;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMatKhau.ForeColor = System.Drawing.Color.DimGray;
            this.txtMatKhau.Image = null;
            this.txtMatKhau.Location = new System.Drawing.Point(329, 166);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.ReadOnly = false;
            this.txtMatKhau.Size = new System.Drawing.Size(298, 41);
            this.txtMatKhau.TabIndex = 7;
            this.txtMatKhau.Text = "Mật khẩu";
            this.txtMatKhau.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatKhau.UseSystemPasswordChar = false;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.DimGray;
            this.txtTaiKhoan.Image = null;
            this.txtTaiKhoan.Location = new System.Drawing.Point(329, 119);
            this.txtTaiKhoan.MaxLength = 32767;
            this.txtTaiKhoan.Multiline = false;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.ReadOnly = false;
            this.txtTaiKhoan.Size = new System.Drawing.Size(298, 41);
            this.txtTaiKhoan.TabIndex = 6;
            this.txtTaiKhoan.Text = "Tài khoản";
            this.txtTaiKhoan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTaiKhoan.UseSystemPasswordChar = false;
            // 
            // cbxMaNhanVien
            // 
            this.cbxMaNhanVien.AllowDrop = true;
            this.cbxMaNhanVien.ArrowColor = System.Drawing.Color.Lime;
            this.cbxMaNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cbxMaNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.cbxMaNhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxMaNhanVien.CausesValidation = false;
            this.cbxMaNhanVien.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxMaNhanVien.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbxMaNhanVien.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbxMaNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMaNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbxMaNhanVien.FormattingEnabled = true;
            this.cbxMaNhanVien.IsDerivedStyle = true;
            this.cbxMaNhanVien.ItemHeight = 29;
            this.cbxMaNhanVien.Location = new System.Drawing.Point(12, 119);
            this.cbxMaNhanVien.Name = "cbxMaNhanVien";
            this.cbxMaNhanVien.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbxMaNhanVien.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbxMaNhanVien.Size = new System.Drawing.Size(298, 35);
            this.cbxMaNhanVien.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cbxMaNhanVien.StyleManager = null;
            this.cbxMaNhanVien.TabIndex = 9;
            this.cbxMaNhanVien.ThemeAuthor = "Taiizor";
            this.cbxMaNhanVien.ThemeName = "MetroLight";
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtNhapLaiMatKhau.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNhapLaiMatKhau.ForeColor = System.Drawing.Color.DimGray;
            this.txtNhapLaiMatKhau.Image = null;
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(329, 216);
            this.txtNhapLaiMatKhau.MaxLength = 32767;
            this.txtNhapLaiMatKhau.Multiline = false;
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.ReadOnly = false;
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(298, 41);
            this.txtNhapLaiMatKhau.TabIndex = 7;
            this.txtNhapLaiMatKhau.Text = "Mật khẩu";
            this.txtNhapLaiMatKhau.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNhapLaiMatKhau.UseSystemPasswordChar = false;
            // 
            // cbxMaBoPhan
            // 
            this.cbxMaBoPhan.AllowDrop = true;
            this.cbxMaBoPhan.ArrowColor = System.Drawing.Color.Red;
            this.cbxMaBoPhan.BackColor = System.Drawing.Color.Transparent;
            this.cbxMaBoPhan.BackgroundColor = System.Drawing.Color.White;
            this.cbxMaBoPhan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxMaBoPhan.CausesValidation = false;
            this.cbxMaBoPhan.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxMaBoPhan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbxMaBoPhan.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbxMaBoPhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMaBoPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbxMaBoPhan.FormattingEnabled = true;
            this.cbxMaBoPhan.IsDerivedStyle = true;
            this.cbxMaBoPhan.ItemHeight = 29;
            this.cbxMaBoPhan.Location = new System.Drawing.Point(12, 166);
            this.cbxMaBoPhan.Name = "cbxMaBoPhan";
            this.cbxMaBoPhan.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbxMaBoPhan.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbxMaBoPhan.Size = new System.Drawing.Size(298, 35);
            this.cbxMaBoPhan.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cbxMaBoPhan.StyleManager = null;
            this.cbxMaBoPhan.TabIndex = 9;
            this.cbxMaBoPhan.ThemeAuthor = "Taiizor";
            this.cbxMaBoPhan.ThemeName = "MetroLight";
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(639, 365);
            this.ControlBox = false;
            this.Controls.Add(this.parrotGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1009);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "frmDangKy";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.parrotGradientPanel1.ResumeLayout(false);
            this.parrotGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private ReaLTaiizor.Controls.CyberButton btnXacNhan;
        private ReaLTaiizor.Controls.BigTextBox txtMatKhau;
        private ReaLTaiizor.Controls.BigTextBox txtTaiKhoan;
        private ReaLTaiizor.Controls.MetroComboBox cbxMaNhanVien;
        private ReaLTaiizor.Controls.BigTextBox txtNhapLaiMatKhau;
        private ReaLTaiizor.Controls.MetroComboBox cbxMaBoPhan;
    }
}