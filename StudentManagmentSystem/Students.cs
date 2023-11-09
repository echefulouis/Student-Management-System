using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagmentSystem
{
    public partial class Students : Form
    {
        //Functions Con;

        private List<StudentModel> AllStudents = GlobalConfig.Connection.GetAllStudents();

        private List<DepartmentModel> AllDepartments = GlobalConfig.Connection.GetAllDepartments();


        public Students()
        {
            InitializeComponent();
            //Con = new Functions();
            ShowStudents();
            GetDepartment();
        }

        private void ShowStudents()
        {
            //string Query = "select * from StudentTbl";
            StudentList.DataSource = GlobalConfig.Connection.GetAllStudents();
        }

        private void GetDepartment()
        {
            /*
            string Query = "select * from DepartmentTbl";
            DeptCb.DisplayMember = Con.GetData(Query).Columns["DeptName"].ToString();
            DeptCb.ValueMember = Con.GetData(Query).Columns["DeptId"].ToString();
            DeptCb.DataSource = Con.GetData(Query);
            */
            DeptCb.DataSource = AllDepartments;
            DeptCb.DisplayMember = "DeptName";
            DeptCb.ValueMember = "DeptId".ToString();

            
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clear()
        {
            StNameTb.Text = "";
            StPhoneTb.Text ="";
            StParentTb.Text = "";
            StAddressTb.Text = "";
            //DeptCb.SelectedIndex = -1;
            StGenderCb.SelectedIndex = -1;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || StPhoneTb.Text == "" || StParentTb.Text =="" 
                || StAddressTb.Text == "" || DeptCb.SelectedIndex == -1 || StGenderCb.SelectedIndex == -1 )
            {
                MessageBox.Show("Missing Details","Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string StName = StNameTb.Text;
                    string StGender= StGenderCb.SelectedItem.ToString();
                    string StPhone = StPhoneTb.Text;
                    string StParent = StParentTb.Text;
                    string StAddress = StAddressTb.Text;
                    int StDept = Convert.ToInt32(DeptCb.SelectedValue.ToString());

                    StudentModel model = new StudentModel(StName,StPhone,StAddress,StGender,StDept);
                    GlobalConfig.Connection.CreateStudent(model);
                    /*
                    string Query = "insert into StudentTbl values ('{0}','{1}','{2}','{3}','{4}', {5})";
                    Query = string.Format(Query, StName, StGender,StPhone,StParent,StAddress,StDept);
                    Con.SetData(Query);*/

                    ShowStudents();
                    MessageBox.Show("Student Added !!!");
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
        int key = 0;
        private void StudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StNameTb.Text = StudentList.SelectedRows[0].Cells[1].Value.ToString();
            StGenderCb.SelectedItem = StudentList.SelectedRows[0].Cells[4].Value;
            StPhoneTb.Text = StudentList.SelectedRows[0].Cells[2].Value.ToString();
            //StParentTb.Text = StudentList.SelectedRows[0].Cells[4].Value.ToString();
            StAddressTb.Text = StudentList.SelectedRows[0].Cells[3].Value.ToString();
            DeptCb.SelectedItem = StudentList.SelectedRows[0].Cells[5].Value.ToString();

            if (StNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(StudentList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || StPhoneTb.Text == "" || StParentTb.Text == ""
                || StAddressTb.Text == "" || DeptCb.SelectedIndex == -1 || StGenderCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Details", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string StName = StNameTb.Text;
                    string StGender = StGenderCb.SelectedItem.ToString();
                    string StPhone = StPhoneTb.Text;
                    string StParent = StParentTb.Text;
                    string StAddress = StAddressTb.Text;
                    int StDept = Convert.ToInt32(DeptCb.SelectedValue.ToString());
                    /*
                    string Query = "update StudentTbl set StudentName ='{0}',StudentGen = '{1}', " +
                        "StudentPhone = '{2}',StudentParent = '{3}',StudentAddress = '{4}',StudentDepart = {5} where StudentID={6}";
                    Query = string.Format(Query, StName, StGender, StPhone, StParent, StAddress, StDept,key);
                    Con.SetData(Query);
                    */
                    ShowStudents();
                    MessageBox.Show("Student Updated !!!");
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Details", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string StName = StNameTb.Text;
                    string StGender = StGenderCb.SelectedItem.ToString();
                    string StPhone = StPhoneTb.Text;
                    string StParent = StParentTb.Text;
                    string StAddress = StAddressTb.Text;
                    int StDept = Convert.ToInt32(DeptCb.SelectedValue.ToString());

                    /*
                    string Query = "Delete from StudentTbl where StudentID={0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    */
                    ShowStudents();
                    MessageBox.Show("Student Deleted !!!");
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeptLb_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Close();
        }

        private void DashBoardLb_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

