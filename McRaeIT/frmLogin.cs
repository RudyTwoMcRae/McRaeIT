using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using McraeitContext;

namespace McRaeIT
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public McraeitDataContext Context = new McraeitDataContext();

        private bool IsValid()
        {
            string sUsername = txtUsername.Text.Trim();
            var oUsername = from User in Context.Users
                            where User.User1 == sUsername
                            select User;
            if (oUsername.Count() > 0 && oUsername.First().Password == txtPassword.Text.Trim())
                return true;
            else
                return false;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtUsername.ForeColor = Color.Black;
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.ForeColor = Color.LightGray;
                txtUsername.Text = "Username";
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.Text = "Username";
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
                cmdLogin_Click(sender, new EventArgs());
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                frmEmployees EmployeesForm = new frmEmployees();
                EmployeesForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                txtUsername.Text = "Rudy";
                txtPassword.Text = "McRaeDM4090";
            }
        }
    }
}
