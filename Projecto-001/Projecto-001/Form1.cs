using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projecto_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool username = false, password = false;
            switch(usernameTxt.Text)
            {
                case "lpalminteri":
                    usernameTxt.BackColor = System.Drawing.Color.LightGreen;
                    username = true;
                    break;
                default:
                    usernameTxt.BackColor = System.Drawing.Color.Red;
                    username = false;
                    break;
            }
            switch (this.passwordTxt.Text)
            {
                case "1234":
                    this.passwordTxt.BackColor = System.Drawing.Color.LightGreen;
                    password = true;
                    break;
                default:
                    this.passwordTxt.BackColor = System.Drawing.Color.Red;
                    password = false;
                    break;
            }

            if (username && password)
            {
                panel1.Visible = true;
                usernameTxt.Text = "";
                this.passwordTxt.Text = "";
                usernameTxt.BackColor = System.Drawing.SystemColors.Window;
                this.passwordTxt.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createAccountPanel.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            messageSucces.Visible = true;
            Thread.Sleep(2000);
            messageSucces.Visible = false;
            createAccountPanel.Visible = false;
        }
    }
}
