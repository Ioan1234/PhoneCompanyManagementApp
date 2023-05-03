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
    public partial class ExtraOptionForm : Form
    {
        private ExtraOption ExtraOption;
        public ExtraOptionForm()
        {
            InitializeComponent();
        }
        public ExtraOptionForm(ExtraOption extraOption):this()
        {
            ExtraOption = extraOption;
            ctrlName.Text = extraOption.ExtraOptionName;
            ctrlPrice.Text = extraOption.Price;
            ctrlCreated.Value = extraOption.Created;
            ctrlBenefits.Text = extraOption.Benefits;
        }

       
        private void cancel_Click(object sender, EventArgs e)
        {
            
        }
       
       

        private void ok_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(ctrlName) == string.Empty)
            {
                ExtraOption.ExtraOptionName = ctrlName.Text;
                ExtraOption.Price = ctrlPrice.Text;
                ExtraOption.Created = ctrlCreated.Value;
                ExtraOption.Benefits = ctrlBenefits.Text;
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
        private void ctrlName_Validating(object sender, CancelEventArgs e)
        {
            if (ctrlName.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(ctrlName, "Name cannot be null!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void ctrlName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
