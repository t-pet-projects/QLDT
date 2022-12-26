using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDT.GUI;

namespace QLDT
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnqlsinhvien_Click(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void btnquanlydiem_Click(object sender, EventArgs e)
        {

            frmDiem f = new frmDiem();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void btnloai_Click(object sender, EventArgs e)
        {
            frmXetTotNghiep f = new frmXetTotNghiep();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }
    }
}
