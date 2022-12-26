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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            Load_DataGridView();

            List<GioiTinhDTO> gioitinhs = new List<DTO.GioiTinhDTO>()
            {
                new GioiTinhDTO() {index = 0, value = "Nữ" },
                new GioiTinhDTO() {index = 1, value = "Nam" },
            };

            cbogioitinh.DisplayMember = "value";
            cbogioitinh.DataSource = gioitinhs;
        }
        public void Load_DataGridView()
        {
            DataTable dt = SinhVienDAO.ThongTinSinhVien();
            gvdanhsach.DataSource = dt;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                MessageBox.Show("Thông tin không được rỗng");
                return;
            }
            try
            {
                SinhVienDTO sv = new SinhVienDTO()
                {
                    MSSV = txtma.Text,
                    HoTen = txtten.Text,
                    GioiTinh = (cbogioitinh.SelectedItem as GioiTinhDTO).index,
                    NgaySinh = this.convertDate(dtpngaysinh.Value),
                    Nganh = txtnganh.Text,
                };
                SinhVienDAO.Luu(sv);
                Load_DataGridView();
                XoaTrang();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                MessageBox.Show("Thông tin không được rỗng");
                return;
            }
            try
            {
                SinhVienDTO sv = new SinhVienDTO()
                {
                    MSSV = txtma.Text,
                    HoTen = txtten.Text,
                    GioiTinh = (cbogioitinh.SelectedItem as GioiTinhDTO).index,
                    NgaySinh = this.convertDate(dtpngaysinh.Value),
                    Nganh = txtnganh.Text,
                };
                SinhVienDAO.Sua(sv);
                Load_DataGridView();
                XoaTrang();
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sinh viên cần xoá!");
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xoá ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            try
            {
                SinhVienDTO sv = new SinhVienDTO() { MSSV = txtma.Text };
                SinhVienDAO.Xoa(sv);
                Load_DataGridView();
                XoaTrang();
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá thất bại");
            }
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
            string gioitinh = row.Cells[2].Value.ToString();
            string ngaysinh = row.Cells[3].Value.ToString();
            string nganh = row.Cells[4].Value.ToString();

            txtma.Text = ma;
            txtten.Text = ten;
            cbogioitinh.SelectedIndex = Int32.Parse(gioitinh);
            dtpngaysinh.Value = DateTime.Parse(ngaysinh);
            txtnganh.Text = nganh;
        }
        private bool KiemTra()
        {
            if (txtma.Text == "" || txtten.Text == "" || txtnganh.Text == "")
            {
                return true;
            }
            return false;
        }
        private void XoaTrang()
        {
            txtma.Text = txtten.Text = txtnganh.Text = "";
        }

        private string convertDate(DateTime s)
        {
            return String.Format("{0:MM/dd/yyyy}", s);
        }
    }
}
