using System;
using System.Windows.Forms;

namespace PSW_lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void r_TextBoxPassword2_TextChanged(object sender, EventArgs e)
        {
            changeTextBoxVilability(r_TextBoxPassword1, r_TextBoxPassword2, r_PasswordError);
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

        private void PasswordCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextbox1.UseSystemPasswordChar = !PasswordTextbox1.UseSystemPasswordChar;
        }
    }
}
