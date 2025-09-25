namespace BTTL_4_2
{
    partial class QLSV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butXoa = new System.Windows.Forms.Button();
            this.butThemSua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataStudent = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongNam = new System.Windows.Forms.TextBox();
            this.txtTongNu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butXoa);
            this.groupBox1.Controls.Add(this.butThemSua);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbCN);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.txtDTB);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(214, 252);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(75, 23);
            this.butXoa.TabIndex = 11;
            this.butXoa.Text = "Xoa";
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butThemSua
            // 
            this.butThemSua.Location = new System.Drawing.Point(98, 252);
            this.butThemSua.Name = "butThemSua";
            this.butThemSua.Size = new System.Drawing.Size(85, 23);
            this.butThemSua.TabIndex = 10;
            this.butThemSua.Text = "Them/Sua";
            this.butThemSua.UseVisualStyleBackColor = true;
            this.butThemSua.Click += new System.EventHandler(this.butThemSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radNu);
            this.groupBox2.Controls.Add(this.radNam);
            this.groupBox2.Location = new System.Drawing.Point(145, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 31);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Checked = true;
            this.radNu.Location = new System.Drawing.Point(69, 11);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 10;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            this.radNu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(6, 11);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 10;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // cmbCN
            // 
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbCN.Location = new System.Drawing.Point(145, 211);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(121, 24);
            this.cmbCN.TabIndex = 8;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(145, 57);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(100, 22);
            this.txtMSSV.TabIndex = 7;
            this.txtMSSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSSV_KeyPress);
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(145, 153);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(100, 22);
            this.txtDTB.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(145, 88);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(187, 22);
            this.txtHoTen.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm Trung Bình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chuyên Ngành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới Tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataStudent
            // 
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HoTen,
            this.GT,
            this.DTB,
            this.Khoa});
            this.dataStudent.Location = new System.Drawing.Point(486, 75);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.RowHeadersWidth = 51;
            this.dataStudent.RowTemplate.Height = 24;
            this.dataStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStudent.Size = new System.Drawing.Size(647, 354);
            this.dataStudent.TabIndex = 1;
            this.dataStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStudent_CellClick);
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // GT
            // 
            this.GT.HeaderText = "Giới Tính";
            this.GT.MinimumWidth = 6;
            this.GT.Name = "GT";
            this.GT.Width = 125;
            // 
            // DTB
            // 
            this.DTB.HeaderText = "Điểm Trung Bình";
            this.DTB.MinimumWidth = 6;
            this.DTB.Name = "DTB";
            this.DTB.Width = 125;
            // 
            // Khoa
            // 
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            this.Khoa.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tông SV Nam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(950, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tông SV Nữ";
            // 
            // txtTongNam
            // 
            this.txtTongNam.Location = new System.Drawing.Point(815, 465);
            this.txtTongNam.Name = "txtTongNam";
            this.txtTongNam.Size = new System.Drawing.Size(100, 22);
            this.txtTongNam.TabIndex = 10;
            this.txtTongNam.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtTongNu
            // 
            this.txtTongNu.Location = new System.Drawing.Point(1033, 462);
            this.txtTongNu.Name = "txtTongNu";
            this.txtTongNu.Size = new System.Drawing.Size(100, 22);
            this.txtTongNu.TabIndex = 11;
            // 
            // QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 517);
            this.Controls.Add(this.txtTongNu);
            this.Controls.Add(this.txtTongNam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataStudent);
            this.Controls.Add(this.groupBox1);
            this.Name = "QLSV";
            this.Text = "Quản Lý thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCN;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.DataGridView dataStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongNam;
        private System.Windows.Forms.TextBox txtTongNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butThemSua;
    }
}

