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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            frmBoPhan frm = new frmBoPhan(this);
            this.Hide();
            frm.Show();
        }
    }
}
