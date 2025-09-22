namespace BAITAPTRENLOP3
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nguyễn",
            "Hoài Nam",
            "0034832832"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Trần ",
            "Duy Tân",
            ")088282"}, -1);
            this.LvStudent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fn = new System.Windows.Forms.TextBox();
            this.Ln = new System.Windows.Forms.TextBox();
            this.ThemLV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuaLv = new System.Windows.Forms.Button();
            this.XoaLv = new System.Windows.Forms.Button();
            this.dataStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // LvStudent
            // 
            this.LvStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LvStudent.FullRowSelect = true;
            this.LvStudent.GridLines = true;
            this.LvStudent.HideSelection = false;
            this.LvStudent.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.LvStudent.Location = new System.Drawing.Point(12, 0);
            this.LvStudent.Name = "LvStudent";
            this.LvStudent.Size = new System.Drawing.Size(259, 91);
            this.LvStudent.TabIndex = 2;
            this.LvStudent.UseCompatibleStateImageBehavior = false;
            this.LvStudent.View = System.Windows.Forms.View.Details;
            this.LvStudent.Visible = false;
            this.LvStudent.SelectedIndexChanged += new System.EventHandler(this.LvStudent_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "LastName";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FirstName";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone";
            // 
            // Fn
            // 
            this.Fn.Location = new System.Drawing.Point(435, 120);
            this.Fn.Name = "Fn";
            this.Fn.Size = new System.Drawing.Size(184, 22);
            this.Fn.TabIndex = 3;
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(435, 214);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(184, 22);
            this.Ln.TabIndex = 4;
            // 
            // ThemLV
            // 
            this.ThemLV.Location = new System.Drawing.Point(435, 293);
            this.ThemLV.Name = "ThemLV";
            this.ThemLV.Size = new System.Drawing.Size(75, 23);
            this.ThemLV.TabIndex = 6;
            this.ThemLV.Text = "Them";
            this.ThemLV.UseVisualStyleBackColor = true;
            this.ThemLV.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // SuaLv
            // 
            this.SuaLv.Location = new System.Drawing.Point(516, 293);
            this.SuaLv.Name = "SuaLv";
            this.SuaLv.Size = new System.Drawing.Size(75, 23);
            this.SuaLv.TabIndex = 10;
            this.SuaLv.Text = "Sua";
            this.SuaLv.UseVisualStyleBackColor = true;
            this.SuaLv.Click += new System.EventHandler(this.SuaLv_Click);
            // 
            // XoaLv
            // 
            this.XoaLv.Location = new System.Drawing.Point(597, 293);
            this.XoaLv.Name = "XoaLv";
            this.XoaLv.Size = new System.Drawing.Size(75, 23);
            this.XoaLv.TabIndex = 11;
            this.XoaLv.Text = "xoa";
            this.XoaLv.UseVisualStyleBackColor = true;
            this.XoaLv.Click += new System.EventHandler(this.XoaLv_Click);
            // 
            // dataStudent
            // 
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Location = new System.Drawing.Point(12, 103);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.RowHeadersWidth = 51;
            this.dataStudent.RowTemplate.Height = 24;
            this.dataStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStudent.Size = new System.Drawing.Size(389, 251);
            this.dataStudent.TabIndex = 12;
            this.dataStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStudent_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataStudent);
            this.Controls.Add(this.XoaLv);
            this.Controls.Add(this.SuaLv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThemLV);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Fn);
            this.Controls.Add(this.LvStudent);
            this.Name = "Form1";
            this.Text = "frm comboBox";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView LvStudent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox Fn;
        private System.Windows.Forms.TextBox Ln;
        private System.Windows.Forms.Button ThemLV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SuaLv;
        private System.Windows.Forms.Button XoaLv;
        private System.Windows.Forms.DataGridView dataStudent;
    }
}

