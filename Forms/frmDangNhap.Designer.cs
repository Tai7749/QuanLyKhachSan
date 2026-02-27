namespace QuanLyKhachSan.WinForms
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_taotaikhoan = new System.Windows.Forms.Label();
            this.bxt_dangnhap = new System.Windows.Forms.Button();
            this.lbl_quenmatkhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(118, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(9, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(9, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(88, 183);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(2);
            this.txt_matkhau.Multiline = true;
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(180, 26);
            this.txt_matkhau.TabIndex = 2;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(91, 116);
            this.txt_taikhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_taikhoan.Multiline = true;
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(180, 26);
            this.txt_taikhoan.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = " ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_taotaikhoan
            // 
            this.lbl_taotaikhoan.AutoSize = true;
            this.lbl_taotaikhoan.Location = new System.Drawing.Point(172, 302);
            this.lbl_taotaikhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_taotaikhoan.Name = "lbl_taotaikhoan";
            this.lbl_taotaikhoan.Size = new System.Drawing.Size(74, 13);
            this.lbl_taotaikhoan.TabIndex = 5;
            this.lbl_taotaikhoan.Text = "Tạo tài Khoản";
            // 
            // bxt_dangnhap
            // 
            this.bxt_dangnhap.Location = new System.Drawing.Point(122, 238);
            this.bxt_dangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.bxt_dangnhap.Name = "bxt_dangnhap";
            this.bxt_dangnhap.Size = new System.Drawing.Size(98, 30);
            this.bxt_dangnhap.TabIndex = 3;
            this.bxt_dangnhap.Text = "Đăng Nhập";
            this.bxt_dangnhap.UseVisualStyleBackColor = true;
            // 
            // lbl_quenmatkhau
            // 
            this.lbl_quenmatkhau.AutoSize = true;
            this.lbl_quenmatkhau.Location = new System.Drawing.Point(78, 302);
            this.lbl_quenmatkhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_quenmatkhau.Name = "lbl_quenmatkhau";
            this.lbl_quenmatkhau.Size = new System.Drawing.Size(88, 13);
            this.lbl_quenmatkhau.TabIndex = 4;
            this.lbl_quenmatkhau.Text = "Quên Mật Khẩu?";
            this.lbl_quenmatkhau.Click += new System.EventHandler(this.lbl_quenmatkhau_Click);
            // 
            // FmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 358);
            this.Controls.Add(this.lbl_quenmatkhau);
            this.Controls.Add(this.bxt_dangnhap);
            this.Controls.Add(this.lbl_taotaikhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormdangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_taotaikhoan;
        private System.Windows.Forms.Button bxt_dangnhap;
        private System.Windows.Forms.Label lbl_quenmatkhau;
    }
}

