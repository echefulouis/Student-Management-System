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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Login Details");
            }
            else if (UNameTb.Text == "Admin" && PasswordTb.Text == "Password")
            {
                Students Obj = new Students();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Login Details");
                UNameTb.Text = "";
                PasswordTb.Text = "";
                
            }
        }
    }
}
