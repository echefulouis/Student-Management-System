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
    public partial class Departments : Form
    {
        //Functions Con;

        private List<DepartmentModel> AllDepartments = GlobalConfig.Connection.GetAllDepartments();


        public Departments()
        {
            InitializeComponent();
            //Con = new Functions();
            ShowDepartments();
        }
        private void ShowDepartments()
        {
            /*
            string Query = "select * from DepartmentTbl";
            DepartmentList.DataSource = Con.GetData(Query);
            */
           
            DepartmentList.DataSource = GlobalConfig.Connection.GetAllDepartments();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DeptNameTb.Text == "" || DeptDetailsTb.Text == "")
            {
                MessageBox.Show("Missing Details","Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                { 
                    string Dname = DeptNameTb.Text;
                    string Details= DeptDetailsTb.Text;

                    DepartmentModel model = new DepartmentModel(Dname,Details);
                    GlobalConfig.Connection.CreateDepartment(model);
                    /*
                    string Query = "insert into DepartmentTbl values ('{0}','{1}')";
                    Query = string.Format(Query, Dname, Details);
                    Con.SetData(Query); 
                    */
                    ShowDepartments();
                    MessageBox.Show("Department Added !!!");
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        int key = 0;
        private void DepartmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DeptNameTb.Text = DepartmentList.SelectedRows[0].Cells[1].Value.ToString();
            DeptDetailsTb.Text = DepartmentList.SelectedRows[0].Cells[2].Value.ToString();
            if(DeptNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DepartmentList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (DeptNameTb.Text == "" || DeptDetailsTb.Text == "")
            {
                MessageBox.Show("Missing Details", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string Dname = DeptNameTb.Text;
                    string Details = DeptDetailsTb.Text;
                    
                    /*
                    string Query = "update DepartmentTbl set DeptName = '{0}', DeptDetails = '{1}' where DeptId = {2}";
                    Query = string.Format(Query, Dname, Details,key);
                    Con.SetData(Query);
                    */
                    ShowDepartments();
                    MessageBox.Show("Department Updated !!!");
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Clear()
        {
            DeptNameTb.Text = "";
            DeptDetailsTb.Text = "";
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a Department", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string Dname = DeptNameTb.Text;
                    string Details = DeptDetailsTb.Text;
                    
                    /*string Query = "Delete from DepartmentTbl where DeptId = {0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);*/
                    ShowDepartments();
                    MessageBox.Show("Department Deleted!!!");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Close();
        }

        private void DashboardLb_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
