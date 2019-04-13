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

        private void PasswordTextbox2_TextChanged(object sender, EventArgs e)
        {
            changeTextBoxVilability(PasswordTextbox1, PasswordTextbox2, PasswordErrorBox);
        }

        private void r_TextBoxPassword2_TextChanged(object sender, EventArgs e)
        {
            changeTextBoxVilability(r_TextBoxPassword1, r_TextBoxPassword2, r_PasswordError);
        }

        private void PasswordCheckbox1_Checked(object sender, EventArgs e)
        {
            changePasswordChar(PasswordTextbox1, PasswordTextbox2, !PasswordCheckBox1.Checked);
        }

        private void r_PasswordCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            changePasswordChar(r_TextBoxPassword1, r_TextBoxPassword2, !r_PasswordCheckBox1.Checked);
        }

        private void changeTextBoxVilability(TextBox textBox1, TextBox textBox2, Label label)
        {
            label.Visible = textBox1.Text != textBox2.Text ? true : false;
        }

        private void changePasswordChar(TextBox box1,TextBox box2 , Boolean booleanValue)
        {
            box1.UseSystemPasswordChar = booleanValue;
            box2.UseSystemPasswordChar = booleanValue;
        }
    }
}
