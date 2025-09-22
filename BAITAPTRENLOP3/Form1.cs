using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAPTRENLOP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // sinh du lieu cho vao combobox
        public List<Studient> GetStudients()
        {
            List<Studient> studients = new List<Studient>();
            studients.Add(new Studient { Name = "Nguyen Van An", ID = "ID1001" });
            studients.Add(new Studient { Name = "Tran Thi Binh", ID = "ID1002" });
            studients.Add(new Studient { Name = "Le Van Cuong", ID = "ID1003" });
            studients.Add(new Studient { Name = "Pham Thi Dung", ID = "ID1004" });
            studients.Add(new Studient { Name = "Hoang Thi Huong", ID = "ID1005" });
            return studients;
        }






        private void button1_Click(object sender, EventArgs e)
        {
            
          /*  String lastName = Fn.Text;
            String firstName = Ln.Text;
            String phone = P.Text;       

            // Thêm dữ liệu 
            ListViewItem item = new ListViewItem(lastName);
            item.SubItems.Add(firstName);
            item.SubItems.Add(phone);
            LvStudent.Items.Add(item);

            // Xóa trắng textbox sau khi thêm
            Fn.Clear();
            Ln.Clear();
            P.Clear();*/
          String name = Fn.Text;
            String id = Ln.Text;
            // Thêm dữ liệu
            Studient studient = new Studient { Name = name, ID = id };
            List<Studient> studients = (List<Studient>)dataStudent.DataSource;
            studients.Add(studient);
            dataStudent.DataSource = null; // Đặt DataSource về null trước khi cập nhật lại
            dataStudent.DataSource = studients; // Cập nhật lại DataSource
            // Xóa trắng textbox sau khi thêm
            Fn.Clear();
            Ln.Clear();

        }

        private void LvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            if (LvStudent.SelectedItems.Count == 0)
                return; // Nếu không có mục nào được chọn, thoát khỏi hàm
            ListViewItem item = LvStudent.SelectedItems[0];
            Fn.Text = item.SubItems[0].Text;
            Ln.Text = item.SubItems[1].Text;
            P.Text = item.SubItems[2].Text;*/
        }

        private void SuaLv_Click(object sender, EventArgs e)
        {
            /*if (LvStudent.SelectedItems.Count == 0)
                return;
            ListViewItem item = LvStudent.SelectedItems[0];

            // Cập nhật lại nội dung theo TextBox
            item.SubItems[0].Text = Fn.Text;  // FirstName
            item.SubItems[1].Text = Ln.Text;  // LastName
            item.SubItems[2].Text = P.Text;   // */
            if (dataStudent.CurrentRow != null)
            {
                DataGridViewRow row = dataStudent.CurrentRow;
                row.Cells["Name"].Value = Fn.Text;
                row.Cells["ID"].Value = Ln.Text;
                // Cập nhật lại DataGridView
                dataStudent.Refresh();
            }


        }

        private void XoaLv_Click(object sender, EventArgs e)
        {/*
            if (LvStudent.SelectedItems.Count == 0)
                return;
            LvStudent.Items.Remove(LvStudent.SelectedItems[0]);

            // Xóa nội dung các TextBox (nếu muốn)
            Fn.Clear();
            Ln.Clear();
            P.Clear();*/

           

            if (dataStudent.CurrentRow != null)
            {
                // Lấy danh sách gốc
                var studients = (List<Studient>)dataStudent.DataSource;

                // Xác định vị trí dòng hiện tại
                int rowIndex = dataStudent.CurrentRow.Index;

                // Xóa trong danh sách gốc
                studients.RemoveAt(rowIndex);

                // Refresh lại DataGridView
                dataStudent.DataSource = null;
                dataStudent.DataSource = studients;

                // Xóa textbox
                Fn.Clear();
                Ln.Clear();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // dua du lieu vao datagridview
            dataStudent.DataSource = GetStudients();

        }

        private void dataStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dua du lieu vao textbox
            if (e.RowIndex >= 0) // Kiểm tra nếu chỉ số hàng hợp lệ
            {
                DataGridViewRow row = dataStudent.Rows[e.RowIndex];
                Fn.Text = row.Cells["Name"].Value.ToString();
                Ln.Text = row.Cells["ID"].Value.ToString();
            }

        }
    }
}
