namespace QuanLyKhachSan.WinForms.Forms
{
    partial class frmMain
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
            this.btnBoPhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoPhan
            // 
            this.btnBoPhan.Location = new System.Drawing.Point(12, 82);
            this.btnBoPhan.Name = "btnBoPhan";
            this.btnBoPhan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBoPhan.Size = new System.Drawing.Size(148, 72);
            this.btnBoPhan.TabIndex = 0;
            this.btnBoPhan.Text = "Bộ Phận";
            this.btnBoPhan.UseVisualStyleBackColor = true;
            this.btnBoPhan.Click += new System.EventHandler(this.btnBoPhan_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btnBoPhan);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chính";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoPhan;
    }
}