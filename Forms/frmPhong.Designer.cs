namespace QuanLyKhachSan.WinForms.Forms
{
    partial class frmPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
            this.frmMain = new ReaLTaiizor.Forms.ParrotForm();
            this.parrotSlidingPanel1 = new ReaLTaiizor.Controls.ParrotSlidingPanel();
            this.pnlPhong = new ReaLTaiizor.Controls.ParrotSlidingPanel();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.picAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.lblBoPhan = new ReaLTaiizor.Controls.FoxBigLabel();
            this.lblHoVaTen = new ReaLTaiizor.Controls.FoxBigLabel();
            this.btnDangXuat = new ReaLTaiizor.Controls.FoxButton();
            this.frmMain.WorkingArea.SuspendLayout();
            this.frmMain.SuspendLayout();
            this.parrotSlidingPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // frmMain
            // 
            this.frmMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.frmMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmMain.ExitApplication = true;
            this.frmMain.FormStyle = ReaLTaiizor.Forms.ParrotForm.Style.MacOS;
            this.frmMain.Location = new System.Drawing.Point(0, 0);
            this.frmMain.MacOSForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.frmMain.MacOSLeftBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.frmMain.MacOSRightBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.frmMain.MacOSSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.frmMain.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.frmMain.MaterialForeColor = System.Drawing.Color.White;
            this.frmMain.Name = "frmMain";
            this.frmMain.ShowMaximize = true;
            this.frmMain.ShowMinimize = true;
            this.frmMain.Size = new System.Drawing.Size(1207, 593);
            this.frmMain.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.frmMain.TabIndex = 0;
            this.frmMain.TitleText = "Trang chủ";
            this.frmMain.UbuntuForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.frmMain.UbuntuLeftBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(80)))));
            this.frmMain.UbuntuRightBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            // 
            // frmMain.WorkingArea
            // 
            this.frmMain.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.frmMain.WorkingArea.Controls.Add(this.pnlPhong);
            this.frmMain.WorkingArea.Controls.Add(this.parrotSlidingPanel1);
            this.frmMain.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmMain.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.frmMain.WorkingArea.Name = "WorkingArea";
            this.frmMain.WorkingArea.Size = new System.Drawing.Size(1207, 554);
            this.frmMain.WorkingArea.TabIndex = 0;
            // 
            // parrotSlidingPanel1
            // 
            this.parrotSlidingPanel1.BottomLeft = System.Drawing.Color.Azure;
            this.parrotSlidingPanel1.BottomRight = System.Drawing.Color.Azure;
            this.parrotSlidingPanel1.CollapseControl = null;
            this.parrotSlidingPanel1.Collapsed = true;
            this.parrotSlidingPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotSlidingPanel1.Controls.Add(this.btnDangXuat);
            this.parrotSlidingPanel1.Controls.Add(this.panel1);
            this.parrotSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.parrotSlidingPanel1.HideControls = false;
            this.parrotSlidingPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotSlidingPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotSlidingPanel1.Name = "parrotSlidingPanel1";
            this.parrotSlidingPanel1.PanelWidthCollapsed = 50;
            this.parrotSlidingPanel1.PanelWidthExpanded = 200;
            this.parrotSlidingPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotSlidingPanel1.Size = new System.Drawing.Size(200, 554);
            this.parrotSlidingPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotSlidingPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotSlidingPanel1.TabIndex = 0;
            this.parrotSlidingPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotSlidingPanel1.TopLeft = System.Drawing.Color.Black;
            this.parrotSlidingPanel1.TopRight = System.Drawing.Color.Black;
            // 
            // pnlPhong
            // 
            this.pnlPhong.BottomLeft = System.Drawing.Color.Azure;
            this.pnlPhong.BottomRight = System.Drawing.Color.Azure;
            this.pnlPhong.CollapseControl = null;
            this.pnlPhong.Collapsed = true;
            this.pnlPhong.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.pnlPhong.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPhong.HideControls = false;
            this.pnlPhong.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.pnlPhong.Location = new System.Drawing.Point(206, 0);
            this.pnlPhong.Name = "pnlPhong";
            this.pnlPhong.PanelWidthCollapsed = 50;
            this.pnlPhong.PanelWidthExpanded = 200;
            this.pnlPhong.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.pnlPhong.PrimerColor = System.Drawing.Color.White;
            this.pnlPhong.Size = new System.Drawing.Size(1001, 554);
            this.pnlPhong.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.pnlPhong.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.pnlPhong.TabIndex = 1;
            this.pnlPhong.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.pnlPhong.TopLeft = System.Drawing.Color.Black;
            this.pnlPhong.TopRight = System.Drawing.Color.Black;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblHoVaTen);
            this.panel1.Controls.Add(this.lblBoPhan);
            this.panel1.Controls.Add(this.picAnhDaiDien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.EdgeColor = System.Drawing.Color.Silver;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(200, 138);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // picAnhDaiDien
            // 
            this.picAnhDaiDien.Image = ((System.Drawing.Image)(resources.GetObject("picAnhDaiDien.Image")));
            this.picAnhDaiDien.Location = new System.Drawing.Point(-1, 0);
            this.picAnhDaiDien.Name = "picAnhDaiDien";
            this.picAnhDaiDien.Size = new System.Drawing.Size(67, 57);
            this.picAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhDaiDien.TabIndex = 0;
            this.picAnhDaiDien.TabStop = false;
            this.picAnhDaiDien.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblBoPhan
            // 
            this.lblBoPhan.BackColor = System.Drawing.Color.Transparent;
            this.lblBoPhan.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lblBoPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.lblBoPhan.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.lblBoPhan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblBoPhan.Location = new System.Drawing.Point(72, 8);
            this.lblBoPhan.Name = "lblBoPhan";
            this.lblBoPhan.Size = new System.Drawing.Size(125, 41);
            this.lblBoPhan.TabIndex = 2;
            this.lblBoPhan.Text = "Bộ phận";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoVaTen.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lblHoVaTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.lblHoVaTen.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.lblHoVaTen.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblHoVaTen.Location = new System.Drawing.Point(-1, 63);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(125, 41);
            this.lblHoVaTen.TabIndex = 2;
            this.lblHoVaTen.Text = "Họ và Tên";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnDangXuat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.DisabledBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnDangXuat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnDangXuat.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnDangXuat.EnabledCalc = true;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.btnDangXuat.Location = new System.Drawing.Point(0, 514);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDangXuat.Size = new System.Drawing.Size(200, 40);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 593);
            this.Controls.Add(this.frmMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1009);
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "frmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dungeonForm1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.frmMain.WorkingArea.ResumeLayout(false);
            this.frmMain.ResumeLayout(false);
            this.parrotSlidingPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ParrotForm frmMain;
        private ReaLTaiizor.Controls.ParrotSlidingPanel pnlPhong;
        private ReaLTaiizor.Controls.ParrotSlidingPanel parrotSlidingPanel1;
        private ReaLTaiizor.Controls.Panel panel1;
        private System.Windows.Forms.PictureBox picAnhDaiDien;
        private ReaLTaiizor.Controls.FoxBigLabel lblBoPhan;
        private ReaLTaiizor.Controls.FoxBigLabel lblHoVaTen;
        private ReaLTaiizor.Controls.FoxButton btnDangXuat;
    }
}