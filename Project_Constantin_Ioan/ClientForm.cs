using Project_Constantin_Ioan.Entities;
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
    public partial class ClientForm : Form
    {
        private Client Client;
        public ClientForm()
        {
            InitializeComponent();
        }
        public ClientForm(Client client):this()
        {
            Client = client;
            ctrlLastName.Text = client.LastName;
            ctrlFirstName.Text = client.FirstName;
            ctrlSsn.Text = client.Ssn;
            ctrlAddress.Text = client.Address;
            ctrlPhoneNumber.Text = client.PhoneNo;

        }

        private void cancel_Click(object sender, EventArgs e)
        {
           

        }
       

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ctrlLastName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the client's last name";
        }

        private void ctrlFirstName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the client's first name";
        }

        private void ctrlSsn_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the client's ssn";
        }

        private void ctrlAddress_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the client's address";
        }

        private void ctrlPhoneNumber_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the client's phone number";
        }

        private void ctrlLastName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void ctrlFirstName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void ctrlSsn_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void ctrlAddress_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void ctrlPhoneNumber_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void ok_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to add the client";
        }

        private void ok_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void cancel_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to cancel adding the client";
        }

        private void cancel_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            statusStrip1.BackColor = Color.Bisque;
            
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(ctrlSsn) == string.Empty)
            {
                Client.LastName=ctrlLastName.Text;
                Client.FirstName=ctrlFirstName.Text;
                Client.Address=ctrlAddress.Text;
                Client.PhoneNo = ctrlPhoneNumber.Text;
                Client.Ssn=ctrlSsn.Text;
            }
            else
            {
                MessageBox.Show(
                    "Errors in form",
                    "Your form contains errors",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ctrlSsn_Validating(object sender, CancelEventArgs e)
        {
            if (ctrlSsn.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(ctrlSsn, "Ssn cannot be null!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void ctrlId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ctrlLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctrlSsn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
