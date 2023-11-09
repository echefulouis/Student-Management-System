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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void StudentsLb_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Close();
        }

        private void DepartmentLb_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Close();
        }
    }
}
