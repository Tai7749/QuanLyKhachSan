using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.WinForms.Forms
{
    public partial class frmBoPhan : Form
    {
        private Form _main;

        public frmBoPhan(Form main)
        {
            InitializeComponent();
            _main = main;
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmBoPhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.Show();
        }


    }
}
