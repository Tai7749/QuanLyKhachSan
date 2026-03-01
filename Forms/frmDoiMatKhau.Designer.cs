namespace QuanLyKhachSan.WinForms.Forms
{
    partial class frmDoiMatKhau
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
            this.txtMatKhauCu = new ReaLTaiizor.Controls.BigTextBox();
            this.txtMatKhauMoi = new ReaLTaiizor.Controls.BigTextBox();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            this.btnXacNhan = new ReaLTaiizor.Controls.CyberButton();
            this.lblTaiKhoan = new ReaLTaiizor.Controls.BigLabel();
            this.parrotGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(210, 35);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(234, 46);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Đổi mật khẩu";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhauCu.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMatKhauCu.ForeColor = System.Drawing.Color.DimGray;
            this.txtMatKhauCu.Image = null;
            this.txtMatKhauCu.Location = new System.Drawing.Point(169, 142);
            this.txtMatKhauCu.MaxLength = 32767;
            this.txtMatKhauCu.Multiline = false;
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.ReadOnly = false;
            this.txtMatKhauCu.Size = new System.Drawing.Size(298, 41);
            this.txtMatKhauCu.TabIndex = 1;
            this.txtMatKhauCu.Text = "Mật khẩu cũ";
            this.txtMatKhauCu.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatKhauCu.UseSystemPasswordChar = false;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMatKhauMoi.ForeColor = System.Drawing.Color.DimGray;
            this.txtMatKhauMoi.Image = null;
            this.txtMatKhauMoi.Location = new System.Drawing.Point(169, 202);
            this.txtMatKhauMoi.MaxLength = 32767;
            this.txtMatKhauMoi.Multiline = false;
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.ReadOnly = false;
            this.txtMatKhauMoi.Size = new System.Drawing.Size(298, 41);
            this.txtMatKhauMoi.TabIndex = 2;
            this.txtMatKhauMoi.Text = "Mật khẩu mới";
            this.txtMatKhauMoi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatKhauMoi.UseSystemPasswordChar = false;
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.Fuchsia;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.metroControlBox1);
            this.parrotGradientPanel1.Controls.Add(this.btnXacNhan);
            this.parrotGradientPanel1.Controls.Add(this.txtMatKhauMoi);
            this.parrotGradientPanel1.Controls.Add(this.txtMatKhauCu);
            this.parrotGradientPanel1.Controls.Add(this.lblTaiKhoan);
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
            this.metroControlBox1.Location = new System.Drawing.Point(-5, -3);
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
            this.btnXacNhan.Location = new System.Drawing.Point(253, 263);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.PenWidth = 15;
            this.btnXacNhan.Rounding = true;
            this.btnXacNhan.RoundingInt = 70;
            this.btnXacNhan.Size = new System.Drawing.Size(130, 50);
            this.btnXacNhan.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Tag = "Cyber";
            this.btnXacNhan.TextButton = "Xác nhận";
            this.btnXacNhan.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnXacNhan.Timer_Effect_1 = 5;
            this.btnXacNhan.Timer_RGB = 300;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTaiKhoan.Location = new System.Drawing.Point(165, 98);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(84, 21);
            this.lblTaiKhoan.TabIndex = 0;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // frmDoiMatKhau
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
            this.Name = "frmDoiMatKhau";
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
        private ReaLTaiizor.Controls.BigTextBox txtMatKhauCu;
        private ReaLTaiizor.Controls.BigTextBox txtMatKhauMoi;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.CyberButton btnXacNhan;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private ReaLTaiizor.Controls.BigLabel lblTaiKhoan;
    }
}