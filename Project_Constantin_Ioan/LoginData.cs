using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Constantin_Ioan
{
    public partial class LoginData : UserControl
    {
        public LoginData()
        {
            InitializeComponent();
        }

        private void ctrlUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctrlPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = ctrlUsername.Text;
            string password = ctrlPassword.Text;
            if ((this.ctrlUsername.Text == "Admin") && (this.ctrlPassword.Text == "admin"))
            {
                Services services = new Services();
                services.Show();
            }
            else if ((this.ctrlUsername.Text == "") && (this.ctrlPassword.Text == ""))
            {
                MessageBox.Show("Please enter a username and a password");
            }
            else
            {
                MessageBox.Show("Incorrect username/password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlUsername_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
