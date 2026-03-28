using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class FormCheckOut : Form
    {
        public FormCheckOut(string food_Drinks)
        {
            InitializeComponent();
            foodTextBox2.Text += food_Drinks;
        }

        private void previousB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goB_Click(object sender, EventArgs e)
        {
            List<CheckBox> checkList = new List<CheckBox>();
            foreach (CheckBox checkbox in panel1.Controls.OfType<CheckBox>())
            {
                if (checkbox.Checked)
                {
                    checkList.Add(checkbox);
                }
            }

            foreach (CheckBox checkbox in checkList)
            {
                panel2.Controls.Add(checkbox);
            }
        }

        private void backB_Click(object sender, EventArgs e)
        {
            List<CheckBox> checkList = new List<CheckBox>();
            foreach (CheckBox checkbox in panel2.Controls.OfType<CheckBox>())
            {
                if (checkbox.Checked)
                {
                    checkList.Add(checkbox);
                }
            }

            foreach (CheckBox checkbox in checkList)
            {
                panel1.Controls.Add(checkbox);
            }
        }

        private void nextB_Click(object sender, EventArgs e)
        {
            RadioButton anyRB = paymentBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (anyRB != null)
            {
                MessageBox.Show("Pay with " + anyRB.Text + ".");
            } else
            {
                MessageBox.Show("Please select a payment method!");
            }
        }
    }
}
