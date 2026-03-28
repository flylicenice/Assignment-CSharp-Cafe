using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class FormMenuList : Form
    {
        string[] foodItem, icedDrink, hotDrinks;
        public FormMenuList()
        {
            InitializeComponent();
        }

        private void getHotDrinkBtn_Click(object sender, EventArgs e)
        {
            hotDrinkTextBox.Text = "";
            foreach (CheckBox checkbox in HotDrinkPanel.Controls.OfType<CheckBox>())
            {
                if (checkbox.Checked)
                {
                    hotDrinkTextBox.Text += checkbox.Text + Environment.NewLine;
                }
            }
        }

        private void getIcedDrinkBtn_Click(object sender, EventArgs e)
        {
            icedDrinkTextBox.Text = "";
            foreach (CheckBox checkbox in icedDrinkPanel.Controls.OfType<CheckBox>())
            {
                if (checkbox.Checked)
                {
                    icedDrinkTextBox.Text += checkbox.Text + Environment.NewLine;
                }
            }
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            string food_and_drinks = foodTextBox.Text + hotDrinkTextBox.Text + icedDrinkTextBox.Text;
            FormCheckOut formChkOut = new FormCheckOut(food_and_drinks);
            formChkOut.Show();
        }

        private void FormMenuList_Load(object sender, EventArgs e)
        {

        }

        private void getFoodBtn_Click(object sender, EventArgs e)
        {
            foodTextBox.Text = "";
            foreach (CheckBox checkbox in foodMenuBox.Controls.OfType<CheckBox>())
            {
                if (checkbox.Checked)
                {
                    foodTextBox.Text += checkbox.Text + Environment.NewLine;
                }
            }
        }
    }
}
