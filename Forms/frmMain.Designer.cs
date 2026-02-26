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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoPhan
            // 
            this.btnBoPhan.Location = new System.Drawing.Point(16, 101);
            this.btnBoPhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBoPhan.Name = "btnBoPhan";
            this.btnBoPhan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBoPhan.Size = new System.Drawing.Size(197, 89);
            this.btnBoPhan.TabIndex = 0;
            this.btnBoPhan.Text = "Bộ Phận";
            this.btnBoPhan.UseVisualStyleBackColor = true;
            this.btnBoPhan.Click += new System.EventHandler(this.btnBoPhan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 690);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBoPhan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chính";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoPhan;
        private System.Windows.Forms.Button button1;
    }
}