using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSW_lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PasswordCheckbox1_Checked(object sender, EventArgs e)
        {
            if (PasswordCheckBox1.Checked)
            {
                PasswordTextbox1.UseSystemPasswordChar = false;
                PasswordTextbox2.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextbox1.UseSystemPasswordChar = true;
                PasswordTextbox2.UseSystemPasswordChar = true;
            }
        }

        private void PasswordTextbox2_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextbox1.Text != PasswordTextbox2.Text)
            {
                PasswordErrorBox.Visible = true;
            }
            else
            {
                PasswordErrorBox.Visible = false;
            }
        }
        
    }
}
