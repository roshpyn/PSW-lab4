﻿namespace PSW_lab4
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PalelLogging = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel1 = new System.Windows.Forms.Label();
            this.PasswordTextbox1 = new System.Windows.Forms.TextBox();
            this.Logging_button = new System.Windows.Forms.Button();
            this.PasswordCheckBox1 = new System.Windows.Forms.CheckBox();
            this.PalelRegister = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.r_name = new System.Windows.Forms.Label();
            this.r_surname = new System.Windows.Forms.Label();
            this.r_login = new System.Windows.Forms.Label();
            this.r_password1 = new System.Windows.Forms.Label();
            this.r_password2 = new System.Windows.Forms.Label();
            this.r_email = new System.Windows.Forms.Label();
            this.r_TextBoxName = new System.Windows.Forms.TextBox();
            this.r_TextBoxSurname = new System.Windows.Forms.TextBox();
            this.r_TextBoxPassword1 = new System.Windows.Forms.TextBox();
            this.r_TextBoxPassword2 = new System.Windows.Forms.TextBox();
            this.r_TextBoxEmail = new System.Windows.Forms.TextBox();
            this.r_TextBoxLogin = new System.Windows.Forms.TextBox();
            this.r_register = new System.Windows.Forms.Button();
            this.r_PasswordError = new System.Windows.Forms.Label();
            this.r_infoEmail = new System.Windows.Forms.Label();
            this.r_PasswordCheckBox1 = new System.Windows.Forms.CheckBox();
            this.r_loginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PalelLogging.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PalelRegister.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PalelLogging);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PalelRegister);
            this.splitContainer1.Size = new System.Drawing.Size(884, 261);
            this.splitContainer1.SplitterDistance = 413;
            this.splitContainer1.TabIndex = 3;
            // 
            // PalelLogging
            // 
            this.PalelLogging.Controls.Add(this.tableLayoutPanel1);
            this.PalelLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PalelLogging.Location = new System.Drawing.Point(0, 0);
            this.PalelLogging.MinimumSize = new System.Drawing.Size(405, 0);
            this.PalelLogging.Name = "PalelLogging";
            this.PalelLogging.Size = new System.Drawing.Size(413, 261);
            this.PalelLogging.TabIndex = 0;
            this.PalelLogging.TabStop = false;
            this.PalelLogging.Text = "Logowanie";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.LoginTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LoginLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PasswordLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordTextbox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Logging_button, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.PasswordCheckBox1, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(407, 242);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginTextBox.Location = new System.Drawing.Point(93, 3);
            this.LoginTextBox.MaxLength = 15;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(98, 20);
            this.LoginTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginLabel.Location = new System.Drawing.Point(3, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(84, 30);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login: ";
            // 
            // PasswordLabel1
            // 
            this.PasswordLabel1.AutoSize = true;
            this.PasswordLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordLabel1.Location = new System.Drawing.Point(3, 30);
            this.PasswordLabel1.Name = "PasswordLabel1";
            this.PasswordLabel1.Size = new System.Drawing.Size(84, 30);
            this.PasswordLabel1.TabIndex = 2;
            this.PasswordLabel1.Text = "Hasło: ";
            // 
            // PasswordTextbox1
            // 
            this.PasswordTextbox1.Location = new System.Drawing.Point(93, 33);
            this.PasswordTextbox1.MaxLength = 15;
            this.PasswordTextbox1.Name = "PasswordTextbox1";
            this.PasswordTextbox1.Size = new System.Drawing.Size(98, 20);
            this.PasswordTextbox1.TabIndex = 10;
            this.PasswordTextbox1.UseSystemPasswordChar = true;
            // 
            // Logging_button
            // 
            this.Logging_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Logging_button.Location = new System.Drawing.Point(306, 93);
            this.Logging_button.Name = "Logging_button";
            this.Logging_button.Size = new System.Drawing.Size(98, 24);
            this.Logging_button.TabIndex = 12;
            this.Logging_button.Text = "Zaloguj";
            this.Logging_button.UseVisualStyleBackColor = true;
            // 
            // PasswordCheckBox1
            // 
            this.PasswordCheckBox1.AutoSize = true;
            this.PasswordCheckBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.PasswordCheckBox1.Location = new System.Drawing.Point(197, 33);
            this.PasswordCheckBox1.Name = "PasswordCheckBox1";
            this.PasswordCheckBox1.Size = new System.Drawing.Size(86, 24);
            this.PasswordCheckBox1.TabIndex = 13;
            this.PasswordCheckBox1.Text = "Pokaż hasło";
            this.PasswordCheckBox1.UseVisualStyleBackColor = true;
            this.PasswordCheckBox1.CheckedChanged += new System.EventHandler(this.PasswordCheckBox1_CheckedChanged);
            // 
            // PalelRegister
            // 
            this.PalelRegister.Controls.Add(this.tableLayoutPanel2);
            this.PalelRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PalelRegister.Location = new System.Drawing.Point(0, 0);
            this.PalelRegister.Name = "PalelRegister";
            this.PalelRegister.Size = new System.Drawing.Size(467, 261);
            this.PalelRegister.TabIndex = 0;
            this.PalelRegister.TabStop = false;
            this.PalelRegister.Text = "Rejestruj";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel2.Controls.Add(this.r_name, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.r_surname, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.r_login, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.r_password1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.r_password2, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.r_email, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.r_TextBoxName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.r_TextBoxSurname, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.r_TextBoxPassword1, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.r_TextBoxPassword2, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.r_TextBoxEmail, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.r_TextBoxLogin, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.r_register, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.r_PasswordError, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.r_infoEmail, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.r_PasswordCheckBox1, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.r_loginButton, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(460, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(461, 242);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // r_name
            // 
            this.r_name.AutoSize = true;
            this.r_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_name.Location = new System.Drawing.Point(3, 0);
            this.r_name.Name = "r_name";
            this.r_name.Size = new System.Drawing.Size(81, 30);
            this.r_name.TabIndex = 1;
            this.r_name.Text = "Imię: ";
            // 
            // r_surname
            // 
            this.r_surname.AutoSize = true;
            this.r_surname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_surname.Location = new System.Drawing.Point(3, 30);
            this.r_surname.Name = "r_surname";
            this.r_surname.Size = new System.Drawing.Size(81, 30);
            this.r_surname.TabIndex = 2;
            this.r_surname.Text = "Nazwisko: ";
            // 
            // r_login
            // 
            this.r_login.AutoSize = true;
            this.r_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_login.Location = new System.Drawing.Point(3, 80);
            this.r_login.Name = "r_login";
            this.r_login.Size = new System.Drawing.Size(81, 30);
            this.r_login.TabIndex = 3;
            this.r_login.Text = "Login:";
            // 
            // r_password1
            // 
            this.r_password1.AutoSize = true;
            this.r_password1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_password1.Location = new System.Drawing.Point(3, 110);
            this.r_password1.Name = "r_password1";
            this.r_password1.Size = new System.Drawing.Size(81, 30);
            this.r_password1.TabIndex = 4;
            this.r_password1.Text = "Hasło: ";
            // 
            // r_password2
            // 
            this.r_password2.AutoSize = true;
            this.r_password2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_password2.Location = new System.Drawing.Point(3, 140);
            this.r_password2.Name = "r_password2";
            this.r_password2.Size = new System.Drawing.Size(81, 30);
            this.r_password2.TabIndex = 5;
            this.r_password2.Text = "Powtórz hasło: ";
            // 
            // r_email
            // 
            this.r_email.AutoSize = true;
            this.r_email.Location = new System.Drawing.Point(3, 170);
            this.r_email.Name = "r_email";
            this.r_email.Size = new System.Drawing.Size(38, 13);
            this.r_email.TabIndex = 6;
            this.r_email.Text = "Email: ";
            // 
            // r_TextBoxName
            // 
            this.r_TextBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_TextBoxName.Location = new System.Drawing.Point(90, 3);
            this.r_TextBoxName.MaxLength = 15;
            this.r_TextBoxName.Name = "r_TextBoxName";
            this.r_TextBoxName.Size = new System.Drawing.Size(200, 20);
            this.r_TextBoxName.TabIndex = 7;
            // 
            // r_TextBoxSurname
            // 
            this.r_TextBoxSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_TextBoxSurname.Location = new System.Drawing.Point(90, 33);
            this.r_TextBoxSurname.MaxLength = 15;
            this.r_TextBoxSurname.Name = "r_TextBoxSurname";
            this.r_TextBoxSurname.Size = new System.Drawing.Size(200, 20);
            this.r_TextBoxSurname.TabIndex = 8;
            // 
            // r_TextBoxPassword1
            // 
            this.r_TextBoxPassword1.Location = new System.Drawing.Point(90, 113);
            this.r_TextBoxPassword1.MaxLength = 15;
            this.r_TextBoxPassword1.Name = "r_TextBoxPassword1";
            this.r_TextBoxPassword1.Size = new System.Drawing.Size(100, 20);
            this.r_TextBoxPassword1.TabIndex = 10;
            this.r_TextBoxPassword1.UseSystemPasswordChar = true;
            // 
            // r_TextBoxPassword2
            // 
            this.r_TextBoxPassword2.Location = new System.Drawing.Point(90, 143);
            this.r_TextBoxPassword2.MaxLength = 15;
            this.r_TextBoxPassword2.Name = "r_TextBoxPassword2";
            this.r_TextBoxPassword2.Size = new System.Drawing.Size(100, 20);
            this.r_TextBoxPassword2.TabIndex = 11;
            this.r_TextBoxPassword2.UseSystemPasswordChar = true;
            this.r_TextBoxPassword2.TextChanged += new System.EventHandler(this.r_TextBoxPassword2_TextChanged);
            // 
            // r_TextBoxEmail
            // 
            this.r_TextBoxEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.r_TextBoxEmail.Location = new System.Drawing.Point(90, 173);
            this.r_TextBoxEmail.MaxLength = 30;
            this.r_TextBoxEmail.Name = "r_TextBoxEmail";
            this.r_TextBoxEmail.Size = new System.Drawing.Size(200, 20);
            this.r_TextBoxEmail.TabIndex = 12;
            // 
            // r_TextBoxLogin
            // 
            this.r_TextBoxLogin.Location = new System.Drawing.Point(90, 83);
            this.r_TextBoxLogin.MaxLength = 15;
            this.r_TextBoxLogin.Name = "r_TextBoxLogin";
            this.r_TextBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.r_TextBoxLogin.TabIndex = 13;
            // 
            // r_register
            // 
            this.r_register.Dock = System.Windows.Forms.DockStyle.Right;
            this.r_register.Location = new System.Drawing.Point(355, 203);
            this.r_register.MinimumSize = new System.Drawing.Size(104, 25);
            this.r_register.Name = "r_register";
            this.r_register.Size = new System.Drawing.Size(104, 25);
            this.r_register.TabIndex = 14;
            this.r_register.Text = "Zarejestruj";
            this.r_register.UseVisualStyleBackColor = true;
            // 
            // r_PasswordError
            // 
            this.r_PasswordError.AutoSize = true;
            this.r_PasswordError.Dock = System.Windows.Forms.DockStyle.Left;
            this.r_PasswordError.ForeColor = System.Drawing.Color.Red;
            this.r_PasswordError.Location = new System.Drawing.Point(296, 140);
            this.r_PasswordError.Name = "r_PasswordError";
            this.r_PasswordError.Size = new System.Drawing.Size(108, 30);
            this.r_PasswordError.TabIndex = 15;
            this.r_PasswordError.Text = "Hasła nie są zgodne!";
            this.r_PasswordError.Visible = false;
            // 
            // r_infoEmail
            // 
            this.r_infoEmail.AutoSize = true;
            this.r_infoEmail.Location = new System.Drawing.Point(296, 170);
            this.r_infoEmail.Name = "r_infoEmail";
            this.r_infoEmail.Size = new System.Drawing.Size(133, 26);
            this.r_infoEmail.TabIndex = 16;
            this.r_infoEmail.Text = "Email może składać się \n z maksymalnie 30 znaków";
            this.r_infoEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // r_PasswordCheckBox1
            // 
            this.r_PasswordCheckBox1.AutoSize = true;
            this.r_PasswordCheckBox1.Location = new System.Drawing.Point(296, 113);
            this.r_PasswordCheckBox1.Name = "r_PasswordCheckBox1";
            this.r_PasswordCheckBox1.Size = new System.Drawing.Size(86, 17);
            this.r_PasswordCheckBox1.TabIndex = 17;
            this.r_PasswordCheckBox1.Text = "Pokaż hasło";
            this.r_PasswordCheckBox1.UseVisualStyleBackColor = true;
            this.r_PasswordCheckBox1.CheckedChanged += new System.EventHandler(this.r_PasswordCheckBox1_CheckedChanged);
            // 
            // r_loginButton
            // 
            this.r_loginButton.Location = new System.Drawing.Point(296, 83);
            this.r_loginButton.Name = "r_loginButton";
            this.r_loginButton.Size = new System.Drawing.Size(133, 23);
            this.r_loginButton.TabIndex = 18;
            this.r_loginButton.Text = "Sprawdź dostępność";
            this.r_loginButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 261);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 300);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSW lab4 logowanie";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PalelLogging.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.PalelRegister.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox PalelLogging;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel1;
        private System.Windows.Forms.TextBox PasswordTextbox1;
        private System.Windows.Forms.GroupBox PalelRegister;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label r_name;
        private System.Windows.Forms.Label r_surname;
        private System.Windows.Forms.Button Logging_button;
        private System.Windows.Forms.Label r_login;
        private System.Windows.Forms.Label r_password1;
        private System.Windows.Forms.Label r_password2;
        private System.Windows.Forms.Label r_email;
        private System.Windows.Forms.TextBox r_TextBoxName;
        private System.Windows.Forms.TextBox r_TextBoxSurname;
        private System.Windows.Forms.TextBox r_TextBoxPassword1;
        private System.Windows.Forms.TextBox r_TextBoxPassword2;
        private System.Windows.Forms.TextBox r_TextBoxEmail;
        private System.Windows.Forms.CheckBox PasswordCheckBox1;
        private System.Windows.Forms.TextBox r_TextBoxLogin;
        private System.Windows.Forms.Button r_register;
        private System.Windows.Forms.Label r_PasswordError;
        private System.Windows.Forms.Label r_infoEmail;
        private System.Windows.Forms.CheckBox r_PasswordCheckBox1;
        private System.Windows.Forms.Button r_loginButton;
    }
}

