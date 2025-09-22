using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTL_4_2
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void TinhTongSV()
        {
            int tongNam = 0;
            int tongNu = 0;
            foreach (DataGridViewRow row in dataStudent.Rows)
            {
                if (row.Cells["GT"].Value != null)
                {
                    string gt = row.Cells["GT"].Value.ToString();
                    if (gt == "Nam") tongNam++;
                    else if (gt == "Nữ") tongNu++;
                }
            }
            txtTongNam.Text = tongNam.ToString();
            txtTongNu.Text = tongNu.ToString();
        }

        private void butThemSua_Click(object sender, EventArgs e)
        {

            string mssv = txtMSSV.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string gioitinh = radNam.Checked ? "Nam" : "Nữ";
            string khoa = cmbCN.Text;
            string dtb = txtDTB.Text.Trim();

            // Kiểm tra nhập liệu
            if (mssv == "" || hoten == "" || dtb == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Kiểm tra tồn tại MSSV
            DataGridViewRow foundRow = null;
            foreach (DataGridViewRow row in dataStudent.Rows)
            {
                if (row.Cells["MSSV"].Value != null && row.Cells["MSSV"].Value.ToString() == mssv)
                {
                    foundRow = row;
                    break;
                }
            }

            if (foundRow == null)
            {
                // Thêm mới
                dataStudent.Rows.Add(mssv, hoten, gioitinh, dtb, khoa);
                MessageBox.Show("Thêm mới dữ liệu thành công!");
            }
            else
            {
                // Cập nhật
                foundRow.Cells["HoTen"].Value = hoten;
                foundRow.Cells["GT"].Value = gioitinh;
                foundRow.Cells["DTB"].Value = dtb;
                foundRow.Cells["Khoa"].Value = khoa;
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }

            TinhTongSV();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Không cho người dùng nhập, chỉ được chọn
            cmbCN.DropDownStyle = ComboBoxStyle.DropDownList;

            // Chọn mặc định là QTKD
            cmbCN.SelectedIndex = 0;
            
            txtTongNam.Text = "0";
            txtTongNu.Text = "0";
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            if (mssv == "")
            {
                MessageBox.Show("Vui lòng nhập MSSV cần xóa!");
                return;
            }

            DataGridViewRow foundRow = null;
            foreach (DataGridViewRow row in dataStudent.Rows)
            {
                if (row.Cells["MSSV"].Value != null && row.Cells["MSSV"].Value.ToString() == mssv)
                {
                    foundRow = row;
                    break;
                }
            }

            if (foundRow == null)
            {
                MessageBox.Show("Không tìm thấy MSSV cần xóa!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dataStudent.Rows.Remove(foundRow);
                    MessageBox.Show("Xóa sinh viên thành công!");
                    TinhTongSV();
                }
            }
        }

        private void dataStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataStudent.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells["MSSV"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtDTB.Text = row.Cells["DTB"].Value?.ToString();
                cmbCN.Text = row.Cells["Khoa"].Value?.ToString();
                

                string gt = row.Cells["GT"].Value?.ToString();
                if (gt == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
            }
        }
    }
}
