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
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            Load_DataGridView();

            List<GioiTinhDTO> gioitinhs = new List<DTO.GioiTinhDTO>()
            {
                new GioiTinhDTO() {index = 0, value = "Nữ" },
                new GioiTinhDTO() {index = 1, value = "Nam" },
            };

            cbogioitinh.DisplayMember = "value";
            cbogioitinh.DataSource = gioitinhs;
            txtma.Enabled = false;
        }
        public void Load_DataGridView()
        {
            DataTable dt = DiemDAO.ThongTinSinhVien();
            gvdanhsach.DataSource = dt;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                // Có lỗi dừng lại, không làm gì tiếp
                return;
            }
            try
            {
                DiemDTO sv = new DiemDTO()
                {
                    MSSV = txtma.Text,
                    DiemGiuaHocPhan = formatDiem(txtdiemgiuahp.Text),
                    DiemQuaTrinh = formatDiem(txtdiemquatrinh.Text),
                    DiemThiKetThuc = formatDiem(txtdiemketthuc.Text)
                };
                DiemDAO.Luu(sv);
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
                return;
            }
            try
            {
                DiemDTO sv = new DiemDTO()
                {
                    MSSV = txtma.Text,
                    DiemGiuaHocPhan = formatDiem(txtdiemgiuahp.Text),
                    DiemQuaTrinh = formatDiem(txtdiemquatrinh.Text),
                    DiemThiKetThuc = formatDiem(txtdiemketthuc.Text)
                };
                DiemDAO.Sua(sv);
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
                DiemDTO sv = new DiemDTO() { MSSV = txtma.Text };
                DiemDAO.Xoa(sv);
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
            string gioiTinh = row.Cells[2].Value.ToString();
            string ngaySinh = row.Cells[3].Value.ToString();
            string nganh = row.Cells[4].Value.ToString();
            string diemQuaTrinh = row.Cells[5].Value.ToString();
            string diemGiuaHP = row.Cells[6].Value.ToString();
            string diemKetThuc = row.Cells[7].Value.ToString();

            txtma.Text = ma;
            txtten.Text = ten;
            cbogioitinh.SelectedIndex = Int32.Parse(gioiTinh);
            dtpngaysinh.Value = DateTime.Parse(ngaySinh);
            txtnganh.Text = nganh;
            txtdiemquatrinh.Text = diemQuaTrinh.ToString();
            txtdiemgiuahp.Text = diemGiuaHP.ToString();
            txtdiemketthuc.Text = diemKetThuc.ToString();

        }
        private bool KiemTra()
        {

            if (txtma.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần thêm");
                return true;
            }

            if (txtma.Text == "" || txtdiemgiuahp.Text == "" || txtdiemketthuc.Text == "" || txtdiemquatrinh.Text == "")
            {
                MessageBox.Show("Thông tin không được rỗng");
                return true;
            }

            if (!KiemTraDiemHopLe(txtdiemgiuahp.Text) || !KiemTraDiemHopLe(txtdiemketthuc.Text) || !KiemTraDiemHopLe(txtdiemquatrinh.Text))
            {
                MessageBox.Show("Điểm không hợp lệ");
                return true;
            }
            return false;
        }

        private bool KiemTraDiemHopLe(string s)
        {
            double n;
            bool isNumeric = Double.TryParse(s, out n);
            if (!isNumeric) return false;
            if (n < 0 || n > 10) return false;
            return isNumeric;
        }
        private void XoaTrang()
        {
            txtma.Text = txtten.Text = txtnganh.Text = txtdiemgiuahp.Text = txtdiemketthuc.Text = txtdiemquatrinh.Text = "";
        }

        private string convertDate(DateTime s)
        {
            return String.Format("{0:MM/dd/yyyy}", s);
        }

        private string formatDiem(string s)
        {
            return s.Replace(",", ".");
        }
    }
}
