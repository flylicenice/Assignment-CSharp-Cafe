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
    public partial class CSharpCafe : Form
    {
        List<Image> imagesList = new List<Image>();
        int currentImage = 0;

        public CSharpCafe()
        {
            InitializeComponent();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (currentImage == 0)
            {
                MessageBox.Show("You have reached the lower limit!" + currentImage);
            } else
            {
                currentImage -= 1;
                cafePic.Image = imagesList[currentImage];
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentImage == imagesList.Count - 1)
            {
                MessageBox.Show("You have reached the upper limit!" + currentImage);
            }
            else
            {
                currentImage += 1;
                cafePic.Image = imagesList[currentImage];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imagesList.Add(Properties.Resources.cafe1);
            imagesList.Add(Properties.Resources.cafe2);
            imagesList.Add(Properties.Resources.cafe3);
            cafePic.Image = imagesList[currentImage];

            passwdBox.PasswordChar = '*';
            passwdBox.MaxLength = 14;
        }

        private void bgcolorBtn_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                this.BackColor = System.Drawing.Color.DarkGray;
            }
            else if (this.BackColor == Color.DarkGray)
            {
                this.BackColor = System.Drawing.Color.White;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameBox.Clear();
            passwdBox.Clear();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            FormMenuList formMenuList = new FormMenuList();
            formMenuList.Show();
        }

        private void showChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showChkBox.Checked)
            {
                passwdBox.PasswordChar = '\0';
            } else
            {
                passwdBox.PasswordChar = '*';
            }
        }
    }
}
