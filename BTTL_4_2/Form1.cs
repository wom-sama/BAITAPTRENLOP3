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
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
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
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo");
            }
            else
            {
                // Cập nhật
                foundRow.Cells["HoTen"].Value = hoten;
                foundRow.Cells["GT"].Value = gioitinh;
                foundRow.Cells["DTB"].Value = dtb;
                foundRow.Cells["Khoa"].Value = khoa;
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo");
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

            // Thiết lập DataGridView bằng 10 cột
            dataStudent.ColumnCount = 5;
            dataStudent.Columns[0].Name = "MSSV";
            dataStudent.Columns[1].Name = "HoTen";
            dataStudent.Columns[2].Name = "GT";
            dataStudent.Columns[3].Name = "DTB";
            dataStudent.Columns[4].Name = "Khoa";
            dataStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataStudent.MultiSelect = false;
            dataStudent.AllowUserToAddRows = false;
            dataStudent.ReadOnly = true;
            dataStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataStudent.RowHeadersVisible = false;
            dataStudent.AllowUserToResizeRows = false;
            dataStudent.AllowUserToResizeColumns = false;
            dataStudent.AllowUserToOrderColumns = false;
            dataStudent.AllowUserToDeleteRows = false;
            dataStudent.AllowUserToAddRows = false;
            dataStudent.BackgroundColor = Color.White;
            dataStudent.GridColor = Color.LightGray;    
            dataStudent.BorderStyle = BorderStyle.None;
            dataStudent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataStudent.EnableHeadersVisualStyles = false;
            dataStudent.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataStudent.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataStudent.ColumnHeadersDefaultCellStyle.Font = new Font(dataStudent.Font, FontStyle.Bold);
            dataStudent.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dataStudent.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataStudent.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataStudent.RowTemplate.Height = 30;
            dataStudent.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dataStudent.Rows.Add("123", "Nguyễn Văn A", "Nam", "8.5", "CNTT");
            dataStudent.Rows.Add("124", "Trần Thị B", "Nữ", "9.0", "QTKD");
      
            dataStudent.Rows.Add("125", "Lê Văn C", "Nam", "7.5", "CNTT");
       
            dataStudent.Rows.Add("126", "Phạm Thị D", "Nữ", "8.0", "QTKD");
       
            dataStudent.Rows.Add("127", "Hoàng Văn E", "Nam", "6.5", "CNTT");
          
            dataStudent.Rows.Add("128", "Đỗ Thị F", "Nữ", "9.5", "QTKD");
           
            dataStudent.Rows.Add("129", "Vũ Văn G", "Nam", "7.0", "CNTT");
          
            dataStudent.Rows.Add("130", "Bùi Thị H", "Nữ", "8.8", "QTKD");
        
            dataStudent.Rows.Add("131", "Đặng Văn I", "Nam", "6.8", "CNTT");
      
            dataStudent.Rows.Add("132", "Ngô Thị K", "Nữ", "9.2", "QTKD");

            dataStudent.Rows.Add("133", "Trịnh Văn L", "Nam", "7.8", "CNTT");
            dataStudent.Rows.Add("134", "Lý Thị M", "Nữ", "8.3", "QTKD"); 
            dataStudent.Rows.Add("135", "Phan Văn N", "Nam", "6.9", "CNTT"); 
            dataStudent.Rows.Add("136", "Cao Thị O", "Nữ", "9.1", "QTKD"); 
            dataStudent.Rows.Add("137", "Trương Văn P", "Nam", "7.2", "CNTT"); 
            dataStudent.Rows.Add("138", "Hồ Thị Q", "Nữ", "8.7", "QTKD"); 
            dataStudent.Rows.Add("139", "Võ Văn R", "Nam", "6.6", "CNTT"); 
            dataStudent.Rows.Add("140", "Đinh Thị S", "Nữ", "9.3", "QTKD"); 
            dataStudent.Rows.Add("141", "Lâm Văn T", "Nam", "7.4", "CNTT"); 
            dataStudent.Rows.Add("142", "Tạ Thị U", "Nữ", "8.9", "QTKD"); 
            dataStudent.Rows.Add("143", "Trần Văn V", "Nam", "6.7", "CNTT"); 
            dataStudent.Rows.Add("144", "Nguyễn Thị W", "Nữ", "9.4", "QTKD"); 
            dataStudent.Rows.Add("145", "Lê Văn X", "Nam", "7.6", "CNTT"); 
            dataStudent.Rows.Add("146", "Phạm Thị Y", "Nữ", "8.4", "QTKD"); 
            dataStudent.Rows.Add("147", "Hoàng Văn Z", "Nam", "6.8", "CNTT"); 
            dataStudent.Rows.Add("148", "Đỗ Thị A1", "Nữ", "9.0", "QTKD"); 
            dataStudent.Rows.Add("149", "Vũ Văn B1", "Nam", "7.1", "CNTT"); 
            dataStudent.Rows.Add("150", "Bùi Thị C1", "Nữ", "8.6", "QTKD"); 
            dataStudent.Rows.Add("151", "Đặng Văn D1", "Nam", "6.9", "CNTT"); 
            dataStudent.Rows.Add("152", "Ngô Thị E1", "Nữ", "9.2", "QTKD"); 
            dataStudent.Rows.Add("153", "Trịnh Văn F1", "Nam", "7.3", "CNTT"); 
            dataStudent.Rows.Add("154", "Lý Thị G1", "Nữ", "8.8", "QTKD"); 
            dataStudent.Rows.Add("155", "Phan Văn H1", "Nam", "6.5", "CNTT"); 
            dataStudent.Rows.Add("156", "Cao Thị I1", "Nữ", "9.1", "QTKD"); 
            dataStudent.Rows.Add("157", "Trương Văn J1", "Nam", "7.4", "CNTT"); 
            dataStudent.Rows.Add("158", "Hồ Thị K1", "Nữ", "8.5", "QTKD"); 
            dataStudent.Rows.Add("159", "Võ Văn L1", "Nam", "6.7", "CNTT"); 
            dataStudent.Rows.Add("160", "Đinh Thị M1", "Nữ", "9.3", "QTKD"); 
            dataStudent.Rows.Add("161", "Lâm Văn N1", "Nam", "7.2", "CNTT"); 
            dataStudent.Rows.Add("162", "Tạ Thị O1", "Nữ", "8.9", "QTKD"); 
            dataStudent.Rows.Add("163", "Trần Văn P1", "Nam", "6.8", "CNTT"); 
            dataStudent.Rows.Add("164", "Nguyễn Thị Q1", "Nữ", "9.4", "QTKD"); 
            dataStudent.Rows.Add("165", "Lê Văn R1", "Nam", "7.5", "CNTT"); 
            dataStudent.Rows.Add("166", "Phạm Thị S1", "Nữ", "8.2", "QTKD"); 
            dataStudent.Rows.Add("167", "Hoàng Văn T1", "Nam", "6.6", "CNTT"); 
            dataStudent.Rows.Add("168", "Đỗ Thị U1", "Nữ", "9.1", "QTKD"); 
            dataStudent.Rows.Add("169", "Vũ Văn V1", "Nam", "7.3", "CNTT"); 
            dataStudent.Rows.Add("170", "Bùi Thị W1", "Nữ", "8.7", "QTKD"); 
            dataStudent.Rows.Add("171", "Đặng Văn X1", "Nam", "6.9", "CNTT"); 
            dataStudent.Rows.Add("172", "Ngô Thị Y1", "Nữ", "9.2", "QTKD"); 
            dataStudent.Rows.Add("173", "Trịnh Văn Z1", "Nam", "7.4", "CNTT");
            dataStudent.Rows.Add("174", "Lý Thị A2", "Nữ", "8.5", "QTKD"); 
            dataStudent.Rows.Add("175", "Phan Văn B2", "Nam", "6.7", "CNTT"); 
            dataStudent.Rows.Add("176", "Cao Thị C2", "Nữ", "9.3", "QTKD"); 
            dataStudent.Rows.Add("177", "Trương Văn D2", "Nam", "7.1", "CNTT"); 
                
            dataStudent.Rows.Add("178", "Hồ Thị E2", "Nữ", "8.6", "QTKD"); 
            dataStudent.Rows.Add("179", "Võ Văn F2", "Nam", "6.8", "CNTT"); 
            dataStudent.Rows.Add("180", "Đinh Thị G2", "Nữ", "9.0", "QTKD"); 
            dataStudent.Rows.Add("181", "Lâm Văn H2", "Nam", "7.2", "CNTT"); 
            dataStudent.Rows.Add("182", "Tạ Thị I2", "Nữ", "8.8", "QTKD"); 
            dataStudent.Rows.Add("183", "Trần Văn J2", "Nam", "6.5", "CNTT"); 
            dataStudent.Rows.Add("184", "Nguyễn Thị K2", "Nữ", "9.1", "QTKD"); 
            dataStudent.Rows.Add("185", "Lê Văn L2", "Nam", "7.3", "CNTT"); 
            dataStudent.Rows.Add("186", "Phạm Thị M2", "Nữ", "8.4", "QTKD"); 
            dataStudent.Rows.Add("187", "Hoàng Văn N2", "Nam", "6.9", "CNTT"); 
            dataStudent.Rows.Add("188", "Đỗ Thị O2", "Nữ", "9.2", "QTKD"); 
            dataStudent.Rows.Add("189", "Vũ Văn P2", "Nam", "7.5", "CNTT"); 
                
            dataStudent.Rows.Add("190", "Bùi Thị Q2", "Nữ", "8.1", "QTKD"); 
            dataStudent.Rows.Add("191", "Đặng Văn R2", "Nam", "6.6", "CNTT"); 
            



            TinhTongSV();
            dataStudent.ClearSelection();

        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            if (mssv == "")
            {
                MessageBox.Show("Vui lòng nhập MSSV cần xóa!", "Thông báo");
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
                MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dataStudent.Rows.Remove(foundRow);
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo");
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

        private void txtMSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím điều khiển
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
