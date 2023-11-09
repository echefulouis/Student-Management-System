namespace StudentManagmentSystem
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudentList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.DeptCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StGenderCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StPhoneTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StParentTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StAddressTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StudentLb = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DashBoardLb = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DeptLb = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.StudentList);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 600);
            this.panel1.TabIndex = 0;
            // 
            // StudentList
            // 
            this.StudentList.BackgroundColor = System.Drawing.Color.White;
            this.StudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentList.GridColor = System.Drawing.Color.LightSkyBlue;
            this.StudentList.Location = new System.Drawing.Point(374, 52);
            this.StudentList.Name = "StudentList";
            this.StudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentList.Size = new System.Drawing.Size(464, 534);
            this.StudentList.TabIndex = 12;
            this.StudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentList_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(776, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.UpdateBtn);
            this.panel2.Controls.Add(this.Addbtn);
            this.panel2.Controls.Add(this.DeptCb);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.StGenderCb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.StPhoneTb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.StParentTb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.StAddressTb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.StNameTb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 536);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(108, 483);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(109, 40);
            this.DeleteBtn.TabIndex = 21;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(201, 431);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(109, 40);
            this.UpdateBtn.TabIndex = 20;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(30, 431);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(109, 40);
            this.Addbtn.TabIndex = 19;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // DeptCb
            // 
            this.DeptCb.FormattingEnabled = true;
            this.DeptCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.DeptCb.Location = new System.Drawing.Point(22, 378);
            this.DeptCb.Name = "DeptCb";
            this.DeptCb.Size = new System.Drawing.Size(288, 29);
            this.DeptCb.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(18, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Student Department";
            // 
            // StGenderCb
            // 
            this.StGenderCb.FormattingEnabled = true;
            this.StGenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.StGenderCb.Location = new System.Drawing.Point(22, 107);
            this.StGenderCb.Name = "StGenderCb";
            this.StGenderCb.Size = new System.Drawing.Size(288, 29);
            this.StGenderCb.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(18, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Student Gender:";
            // 
            // StPhoneTb
            // 
            this.StPhoneTb.Location = new System.Drawing.Point(22, 163);
            this.StPhoneTb.Name = "StPhoneTb";
            this.StPhoneTb.Size = new System.Drawing.Size(288, 29);
            this.StPhoneTb.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(18, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Student Phone";
            // 
            // StParentTb
            // 
            this.StParentTb.Location = new System.Drawing.Point(22, 225);
            this.StParentTb.Name = "StParentTb";
            this.StParentTb.Size = new System.Drawing.Size(288, 29);
            this.StParentTb.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(18, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Student Parent";
            // 
            // StAddressTb
            // 
            this.StAddressTb.Location = new System.Drawing.Point(22, 281);
            this.StAddressTb.Multiline = true;
            this.StAddressTb.Name = "StAddressTb";
            this.StAddressTb.Size = new System.Drawing.Size(288, 70);
            this.StAddressTb.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(18, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student Address";
            // 
            // StNameTb
            // 
            this.StNameTb.Location = new System.Drawing.Point(22, 43);
            this.StNameTb.Name = "StNameTb";
            this.StNameTb.Size = new System.Drawing.Size(288, 29);
            this.StNameTb.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Students";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(74, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Student MS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.StudentLb);
            this.panel3.Location = new System.Drawing.Point(12, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 30);
            this.panel3.TabIndex = 11;
            // 
            // StudentLb
            // 
            this.StudentLb.AutoSize = true;
            this.StudentLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLb.ForeColor = System.Drawing.Color.White;
            this.StudentLb.Location = new System.Drawing.Point(24, 4);
            this.StudentLb.Name = "StudentLb";
            this.StudentLb.Size = new System.Drawing.Size(70, 21);
            this.StudentLb.TabIndex = 13;
            this.StudentLb.Text = "Students";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Location = new System.Drawing.Point(212, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 31);
            this.panel4.TabIndex = 11;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // DashBoardLb
            // 
            this.DashBoardLb.AutoSize = true;
            this.DashBoardLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardLb.ForeColor = System.Drawing.Color.White;
            this.DashBoardLb.Location = new System.Drawing.Point(24, 4);
            this.DashBoardLb.Name = "DashBoardLb";
            this.DashBoardLb.Size = new System.Drawing.Size(86, 21);
            this.DashBoardLb.TabIndex = 13;
            this.DashBoardLb.Text = "Dashboard";
            this.DashBoardLb.Click += new System.EventHandler(this.DashBoardLb_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.DashBoardLb);
            this.panel5.Location = new System.Drawing.Point(12, 324);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(232, 30);
            this.panel5.TabIndex = 13;
            // 
            // DeptLb
            // 
            this.DeptLb.AutoSize = true;
            this.DeptLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptLb.ForeColor = System.Drawing.Color.White;
            this.DeptLb.Location = new System.Drawing.Point(24, 4);
            this.DeptLb.Name = "DeptLb";
            this.DeptLb.Size = new System.Drawing.Size(100, 21);
            this.DeptLb.TabIndex = 13;
            this.DeptLb.Text = "Departments";
            this.DeptLb.Click += new System.EventHandler(this.DeptLb_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel6.Controls.Add(this.DeptLb);
            this.panel6.Location = new System.Drawing.Point(12, 234);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(232, 30);
            this.panel6.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(55, 526);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 40);
            this.button4.TabIndex = 20;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox StNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StPhoneTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StParentTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StAddressTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DeptCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox StGenderCb;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label StudentLb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label DashBoardLb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label DeptLb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView StudentList;
    }
}