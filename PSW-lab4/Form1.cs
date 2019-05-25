using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace PSW_lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox_rp_password1_TextChanged(object sender, EventArgs e)
        {
            check_textBox_rp();
        }

        private void textBox_rp_password2_TextChanged(object sender, EventArgs e)
        {
            check_textBox_rp();
        }

        private void check_textBox_rp()
        {
            bool state = (textBox_rp_password1.Text != textBox_rp_password2.Text);
            
            label_rp_password_match.Visible = state;
            
        }

        private void checkBox_rp_password_CheckedChanged(object sender, EventArgs e)
        {
            textBox_rp_password1.UseSystemPasswordChar = !(textBox_rp_password1.UseSystemPasswordChar);
            textBox_rp_password2.UseSystemPasswordChar = !(textBox_rp_password2.UseSystemPasswordChar);
        }

        private void textBox_rp_email_TextChanged(object sender, EventArgs e)
        {
            if (textBox_rp_email.Text.Length > 0)
            {
                label_rp_email_valid.Visible = isNotValidEmail(textBox_rp_email.Text);
            }
        }

        private bool isNotValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return false;
            }
            catch (FormatException)
            {
                return true;
            }
        }
    }
}
