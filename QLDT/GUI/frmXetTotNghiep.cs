using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDT.DAO;
using QLDT.DTO;

namespace QLDT.GUI
{
    public partial class frmXetTotNghiep : Form
    {
        public frmXetTotNghiep()
        {
            InitializeComponent();
        }

    
        private void frmXetTotNghiep_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtnganh.Enabled = false;
            txtdiemquatrinh.Enabled = false;
            txtdiemgiuahp.Enabled = false;
            txtdiemketthuc.Enabled = false;
            txtxeploai.Enabled = false;

        }
        public void Load_DataGridView()
        {
            DataTable dt = DiemDAO.ThongTinSinhVien();
            gvdanhsach.DataSource = dt;
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = gvdanhsach.Rows[e.RowIndex];
            string ma = row.Cells[0].Value.ToString();
            string ten = row.Cells[1].Value.ToString();
            string nganh = row.Cells[4].Value.ToString();
            string diemQuaTrinh = row.Cells[5].Value.ToString();
            string diemGiuaHP = row.Cells[6].Value.ToString();
            string diemKetThuc = row.Cells[7].Value.ToString();

            txtxeploai.Text = "";
            txtdiemtotnghiep.Text = "";
            txtma.Text = ma;
            txtten.Text = ten;
            txtnganh.Text = nganh;
            txtdiemquatrinh.Text = diemQuaTrinh.ToString();
            txtdiemgiuahp.Text = diemGiuaHP.ToString();
            txtdiemketthuc.Text = diemKetThuc.ToString();


            if (!KiemTraDiemHopLe(txtdiemgiuahp.Text) || !KiemTraDiemHopLe(txtdiemketthuc.Text) || !KiemTraDiemHopLe(txtdiemquatrinh.Text))
            {
               txtdiemtotnghiep.Text = "";
               return;
            }
            double diemXepLoai = DiemXepLoai();
            txtdiemtotnghiep.Text = diemXepLoai.ToString();

            if (diemXepLoai >= 9) txtxeploai.Text = "Xuất sắc";
            else if (diemXepLoai >= 8.5) txtxeploai.Text = "Giỏi";
            else if (diemXepLoai >= 7) txtxeploai.Text = "Khá";
            else txtxeploai.Text = "Trung bình";

        }

        private bool KiemTraDiemHopLe(string s)
        {
            double n;
            bool isNumeric = Double.TryParse(s, out n);
            if (!isNumeric) return false;
            if (n < 0 || n > 10) return false;
            return isNumeric;
        }
        private double DiemXepLoai()
        {

            double diemQuaTrinh = Double.Parse(txtdiemquatrinh.Text);
            double diemGiuaHP = Double.Parse(txtdiemgiuahp.Text);
            double diemKetThuc = Double.Parse(txtdiemketthuc.Text);

            return (diemQuaTrinh + diemGiuaHP * 2 + diemKetThuc * 3) / 6;
        }

    }
}
