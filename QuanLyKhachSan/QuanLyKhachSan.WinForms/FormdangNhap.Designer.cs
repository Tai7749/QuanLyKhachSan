namespace QuanLyKhachSan.WinForms
{
    partial class FormdangNhap
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(157, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(14, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(117, 225);
            this.txt_matkhau.Multiline = true;
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(239, 31);
            this.txt_matkhau.TabIndex = 4;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(121, 143);
            this.txt_taikhoan.Multiline = true;
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(239, 31);
            this.txt_taikhoan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = " ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_taotaikhoan
            // 
            this.lbl_taotaikhoan.AutoSize = true;
            this.lbl_taotaikhoan.Location = new System.Drawing.Point(257, 372);
            this.lbl_taotaikhoan.Name = "lbl_taotaikhoan";
            this.lbl_taotaikhoan.Size = new System.Drawing.Size(90, 16);
            this.lbl_taotaikhoan.TabIndex = 8;
            this.lbl_taotaikhoan.Text = "Tạo tài Khoản";
            // 
            // bxt_dangnhap
            // 
            this.bxt_dangnhap.Location = new System.Drawing.Point(163, 293);
            this.bxt_dangnhap.Name = "bxt_dangnhap";
            this.bxt_dangnhap.Size = new System.Drawing.Size(131, 37);
            this.bxt_dangnhap.TabIndex = 9;
            this.bxt_dangnhap.Text = "Đăng Nhập";
            this.bxt_dangnhap.UseVisualStyleBackColor = true;
            // 
            // lbl_quenmatkhau
            // 
            this.lbl_quenmatkhau.AutoSize = true;
            this.lbl_quenmatkhau.Location = new System.Drawing.Point(114, 372);
            this.lbl_quenmatkhau.Name = "lbl_quenmatkhau";
            this.lbl_quenmatkhau.Size = new System.Drawing.Size(104, 16);
            this.lbl_quenmatkhau.TabIndex = 10;
            this.lbl_quenmatkhau.Text = "Quên Mật Khẩu?";
            // 
            // FormdangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 441);
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
            this.Name = "FormdangNhap";
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

