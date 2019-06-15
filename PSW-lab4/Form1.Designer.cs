namespace PSW_lab4
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
            this.tab_logging = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_lp_title = new System.Windows.Forms.Label();
            this.label_lp_login = new System.Windows.Forms.Label();
            this.label_lp_password = new System.Windows.Forms.Label();
            this.lp_name = new System.Windows.Forms.TextBox();
            this.lp_password = new System.Windows.Forms.TextBox();
            this.button_lp_login = new System.Windows.Forms.Button();
            this.lp_checkBox = new System.Windows.Forms.CheckBox();
            this.tab_register = new System.Windows.Forms.TabPage();
            this.table_register = new System.Windows.Forms.TableLayoutPanel();
            this.label_rp_title = new System.Windows.Forms.Label();
            this.label_rp_name = new System.Windows.Forms.Label();
            this.label_rp_surname = new System.Windows.Forms.Label();
            this.label_rp_login = new System.Windows.Forms.Label();
            this.label_rp_password1 = new System.Windows.Forms.Label();
            this.label_rp_password2 = new System.Windows.Forms.Label();
            this.label_rp_email = new System.Windows.Forms.Label();
            this.checkBox_rp_password = new System.Windows.Forms.CheckBox();
            this.label_rp_password_match = new System.Windows.Forms.Label();
            this.label_rp_email_valid = new System.Windows.Forms.Label();
            this.textBox_rp_email = new System.Windows.Forms.TextBox();
            this.textBox_rp_name = new System.Windows.Forms.TextBox();
            this.textBox_rp_surname = new System.Windows.Forms.TextBox();
            this.textBox_rp_login = new System.Windows.Forms.TextBox();
            this.textBox_rp_password1 = new System.Windows.Forms.TextBox();
            this.textBox_rp_password2 = new System.Windows.Forms.TextBox();
            this.button_rp_register = new System.Windows.Forms.Button();
            this.button_rp_login = new System.Windows.Forms.Button();
            this.tab_logging.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tab_register.SuspendLayout();
            this.table_register.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_logging
            // 
            this.tab_logging.Controls.Add(this.tabPage1);
            this.tab_logging.Controls.Add(this.tab_register);
            this.tab_logging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_logging.Location = new System.Drawing.Point(0, 0);
            this.tab_logging.Name = "tab_logging";
            this.tab_logging.SelectedIndex = 0;
            this.tab_logging.Size = new System.Drawing.Size(484, 261);
            this.tab_logging.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Logowanie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label_lp_title, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_lp_login, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_lp_password, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lp_name, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lp_password, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_lp_login, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lp_checkBox, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 229);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label_lp_title
            // 
            this.label_lp_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_lp_title.AutoSize = true;
            this.label_lp_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label_lp_title.Location = new System.Drawing.Point(120, 0);
            this.label_lp_title.Name = "label_lp_title";
            this.label_lp_title.Size = new System.Drawing.Size(229, 38);
            this.label_lp_title.TabIndex = 0;
            this.label_lp_title.Text = "Zaloguj";
            this.label_lp_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_lp_login
            // 
            this.label_lp_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_lp_login.AutoSize = true;
            this.label_lp_login.Location = new System.Drawing.Point(3, 64);
            this.label_lp_login.Name = "label_lp_login";
            this.label_lp_login.Size = new System.Drawing.Size(111, 13);
            this.label_lp_login.TabIndex = 2;
            this.label_lp_login.Text = "Nazwa użytkownika: ";
            this.label_lp_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_lp_password
            // 
            this.label_lp_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_lp_password.AutoSize = true;
            this.label_lp_password.Location = new System.Drawing.Point(3, 90);
            this.label_lp_password.Name = "label_lp_password";
            this.label_lp_password.Size = new System.Drawing.Size(111, 13);
            this.label_lp_password.TabIndex = 3;
            this.label_lp_password.Text = "Hasło: ";
            this.label_lp_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lp_name
            // 
            this.lp_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lp_name.Location = new System.Drawing.Point(120, 61);
            this.lp_name.MaxLength = 90;
            this.lp_name.Name = "lp_name";
            this.lp_name.Size = new System.Drawing.Size(229, 20);
            this.lp_name.TabIndex = 12;
            // 
            // lp_password
            // 
            this.lp_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lp_password.Location = new System.Drawing.Point(120, 87);
            this.lp_password.MaxLength = 90;
            this.lp_password.Name = "lp_password";
            this.lp_password.Size = new System.Drawing.Size(229, 20);
            this.lp_password.TabIndex = 13;
            this.lp_password.UseSystemPasswordChar = true;
            // 
            // button_lp_login
            // 
            this.button_lp_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_lp_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_lp_login.Location = new System.Drawing.Point(120, 133);
            this.button_lp_login.Name = "button_lp_login";
            this.button_lp_login.Size = new System.Drawing.Size(229, 33);
            this.button_lp_login.TabIndex = 17;
            this.button_lp_login.Text = "ZALOGUJ";
            this.button_lp_login.UseVisualStyleBackColor = true;
            this.button_lp_login.Click += new System.EventHandler(this.button_lp_login_Click);
            // 
            // lp_checkBox
            // 
            this.lp_checkBox.AutoSize = true;
            this.lp_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.lp_checkBox.Location = new System.Drawing.Point(355, 87);
            this.lp_checkBox.Name = "lp_checkBox";
            this.lp_checkBox.Size = new System.Drawing.Size(77, 16);
            this.lp_checkBox.TabIndex = 18;
            this.lp_checkBox.Text = "Odsłoń hasło";
            this.lp_checkBox.UseVisualStyleBackColor = true;
            this.lp_checkBox.CheckedChanged += new System.EventHandler(this.lp_checkBox_CheckedChanged);
            // 
            // tab_register
            // 
            this.tab_register.Controls.Add(this.table_register);
            this.tab_register.Location = new System.Drawing.Point(4, 22);
            this.tab_register.Name = "tab_register";
            this.tab_register.Padding = new System.Windows.Forms.Padding(3);
            this.tab_register.Size = new System.Drawing.Size(476, 235);
            this.tab_register.TabIndex = 1;
            this.tab_register.Text = "Rejestracja";
            this.tab_register.UseVisualStyleBackColor = true;
            // 
            // table_register
            // 
            this.table_register.AutoSize = true;
            this.table_register.ColumnCount = 3;
            this.table_register.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_register.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_register.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_register.Controls.Add(this.label_rp_title, 1, 0);
            this.table_register.Controls.Add(this.label_rp_name, 0, 1);
            this.table_register.Controls.Add(this.label_rp_surname, 0, 2);
            this.table_register.Controls.Add(this.label_rp_login, 0, 3);
            this.table_register.Controls.Add(this.label_rp_password1, 0, 4);
            this.table_register.Controls.Add(this.label_rp_password2, 0, 5);
            this.table_register.Controls.Add(this.label_rp_email, 0, 6);
            this.table_register.Controls.Add(this.checkBox_rp_password, 2, 4);
            this.table_register.Controls.Add(this.label_rp_password_match, 2, 5);
            this.table_register.Controls.Add(this.label_rp_email_valid, 2, 6);
            this.table_register.Controls.Add(this.textBox_rp_email, 1, 6);
            this.table_register.Controls.Add(this.textBox_rp_name, 1, 1);
            this.table_register.Controls.Add(this.textBox_rp_surname, 1, 2);
            this.table_register.Controls.Add(this.textBox_rp_login, 1, 3);
            this.table_register.Controls.Add(this.textBox_rp_password1, 1, 4);
            this.table_register.Controls.Add(this.textBox_rp_password2, 1, 5);
            this.table_register.Controls.Add(this.button_rp_register, 1, 8);
            this.table_register.Controls.Add(this.button_rp_login, 2, 3);
            this.table_register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_register.Location = new System.Drawing.Point(3, 3);
            this.table_register.Name = "table_register";
            this.table_register.RowCount = 9;
            this.table_register.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_register.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_register.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_register.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_register.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_register.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_register.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_register.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_register.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_register.Size = new System.Drawing.Size(470, 229);
            this.table_register.TabIndex = 0;
            // 
            // label_rp_title
            // 
            this.label_rp_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rp_title.AutoSize = true;
            this.label_rp_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label_rp_title.Location = new System.Drawing.Point(120, 0);
            this.label_rp_title.Name = "label_rp_title";
            this.label_rp_title.Size = new System.Drawing.Size(229, 38);
            this.label_rp_title.TabIndex = 0;
            this.label_rp_title.Text = "Zarejestruj";
            this.label_rp_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_rp_name
            // 
            this.label_rp_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rp_name.AutoSize = true;
            this.label_rp_name.Location = new System.Drawing.Point(3, 44);
            this.label_rp_name.Name = "label_rp_name";
            this.label_rp_name.Size = new System.Drawing.Size(111, 13);
            this.label_rp_name.TabIndex = 1;
            this.label_rp_name.Text = "Imię: ";
            this.label_rp_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_rp_surname
            // 
            this.label_rp_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rp_surname.AutoSize = true;
            this.label_rp_surname.Location = new System.Drawing.Point(3, 70);
            this.label_rp_surname.Name = "label_rp_surname";
            this.label_rp_surname.Size = new System.Drawing.Size(111, 13);
            this.label_rp_surname.TabIndex = 2;
            this.label_rp_surname.Text = "Nazwisko: ";
            this.label_rp_surname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_rp_login
            // 
            this.label_rp_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rp_login.AutoSize = true;
            this.label_rp_login.Location = new System.Drawing.Point(3, 98);
            this.label_rp_login.Name = "label_rp_login";
            this.label_rp_login.Size = new System.Drawing.Size(111, 13);
            this.label_rp_login.TabIndex = 3;
            this.label_rp_login.Text = "Nazwa użytkownika: ";
            this.label_rp_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_rp_password1
            // 
            this.label_rp_password1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rp_password1.AutoSize = true;
            this.label_rp_password1.Location = new System.Drawing.Point(3, 125);
            this.label_rp_password1.Name = "label_rp_password1";
            this.label_rp_password1.Size = new System.Drawing.Size(111, 13);
            this.label_rp_password1.TabIndex = 4;
            this.label_rp_password1.Text = "Hasło: ";
            this.label_rp_password1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_rp_password2
            // 
            this.label_rp_password2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rp_password2.AutoSize = true;
            this.label_rp_password2.Location = new System.Drawing.Point(3, 151);
            this.label_rp_password2.Name = "label_rp_password2";
            this.label_rp_password2.Size = new System.Drawing.Size(111, 13);
            this.label_rp_password2.TabIndex = 5;
            this.label_rp_password2.Text = "Powtórz hasło: ";
            this.label_rp_password2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_rp_email
            // 
            this.label_rp_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rp_email.AutoSize = true;
            this.label_rp_email.Location = new System.Drawing.Point(3, 177);
            this.label_rp_email.Name = "label_rp_email";
            this.label_rp_email.Size = new System.Drawing.Size(111, 13);
            this.label_rp_email.TabIndex = 6;
            this.label_rp_email.Text = "E-Mail: ";
            this.label_rp_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox_rp_password
            // 
            this.checkBox_rp_password.AutoSize = true;
            this.checkBox_rp_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.checkBox_rp_password.Location = new System.Drawing.Point(355, 122);
            this.checkBox_rp_password.Name = "checkBox_rp_password";
            this.checkBox_rp_password.Size = new System.Drawing.Size(77, 16);
            this.checkBox_rp_password.TabIndex = 7;
            this.checkBox_rp_password.Text = "Odsłoń hasło";
            this.checkBox_rp_password.UseVisualStyleBackColor = true;
            this.checkBox_rp_password.CheckedChanged += new System.EventHandler(this.checkBox_rp_password_CheckedChanged);
            // 
            // label_rp_password_match
            // 
            this.label_rp_password_match.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rp_password_match.AutoSize = true;
            this.label_rp_password_match.ForeColor = System.Drawing.Color.Red;
            this.label_rp_password_match.Location = new System.Drawing.Point(355, 151);
            this.label_rp_password_match.Name = "label_rp_password_match";
            this.label_rp_password_match.Size = new System.Drawing.Size(112, 13);
            this.label_rp_password_match.TabIndex = 8;
            this.label_rp_password_match.Text = "Hasła nie są zgodne!";
            this.label_rp_password_match.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_rp_password_match.Visible = false;
            // 
            // label_rp_email_valid
            // 
            this.label_rp_email_valid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rp_email_valid.AutoSize = true;
            this.label_rp_email_valid.ForeColor = System.Drawing.Color.Red;
            this.label_rp_email_valid.Location = new System.Drawing.Point(355, 171);
            this.label_rp_email_valid.Name = "label_rp_email_valid";
            this.label_rp_email_valid.Size = new System.Drawing.Size(112, 26);
            this.label_rp_email_valid.TabIndex = 9;
            this.label_rp_email_valid.Text = "Wprowadź prawidłowy email";
            this.label_rp_email_valid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_rp_email_valid.Visible = false;
            // 
            // textBox_rp_email
            // 
            this.textBox_rp_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_rp_email.Location = new System.Drawing.Point(120, 174);
            this.textBox_rp_email.MaxLength = 90;
            this.textBox_rp_email.Name = "textBox_rp_email";
            this.textBox_rp_email.Size = new System.Drawing.Size(229, 20);
            this.textBox_rp_email.TabIndex = 10;
            this.textBox_rp_email.TextChanged += new System.EventHandler(this.textBox_rp_email_TextChanged);
            // 
            // textBox_rp_name
            // 
            this.textBox_rp_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_rp_name.Location = new System.Drawing.Point(120, 41);
            this.textBox_rp_name.MaxLength = 90;
            this.textBox_rp_name.Name = "textBox_rp_name";
            this.textBox_rp_name.Size = new System.Drawing.Size(229, 20);
            this.textBox_rp_name.TabIndex = 11;
            // 
            // textBox_rp_surname
            // 
            this.textBox_rp_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_rp_surname.Location = new System.Drawing.Point(120, 67);
            this.textBox_rp_surname.MaxLength = 90;
            this.textBox_rp_surname.Name = "textBox_rp_surname";
            this.textBox_rp_surname.Size = new System.Drawing.Size(229, 20);
            this.textBox_rp_surname.TabIndex = 12;
            // 
            // textBox_rp_login
            // 
            this.textBox_rp_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_rp_login.ForeColor = System.Drawing.Color.Black;
            this.textBox_rp_login.Location = new System.Drawing.Point(120, 94);
            this.textBox_rp_login.MaxLength = 90;
            this.textBox_rp_login.Name = "textBox_rp_login";
            this.textBox_rp_login.Size = new System.Drawing.Size(229, 20);
            this.textBox_rp_login.TabIndex = 13;
            // 
            // textBox_rp_password1
            // 
            this.textBox_rp_password1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_rp_password1.Location = new System.Drawing.Point(120, 122);
            this.textBox_rp_password1.MaxLength = 90;
            this.textBox_rp_password1.Name = "textBox_rp_password1";
            this.textBox_rp_password1.Size = new System.Drawing.Size(229, 20);
            this.textBox_rp_password1.TabIndex = 14;
            this.textBox_rp_password1.UseSystemPasswordChar = true;
            this.textBox_rp_password1.TextChanged += new System.EventHandler(this.textBox_rp_password1_TextChanged);
            // 
            // textBox_rp_password2
            // 
            this.textBox_rp_password2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_rp_password2.Location = new System.Drawing.Point(120, 148);
            this.textBox_rp_password2.MaxLength = 90;
            this.textBox_rp_password2.Name = "textBox_rp_password2";
            this.textBox_rp_password2.Size = new System.Drawing.Size(229, 20);
            this.textBox_rp_password2.TabIndex = 15;
            this.textBox_rp_password2.UseSystemPasswordChar = true;
            this.textBox_rp_password2.TextChanged += new System.EventHandler(this.textBox_rp_password2_TextChanged);
            // 
            // button_rp_register
            // 
            this.button_rp_register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rp_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_rp_register.Location = new System.Drawing.Point(120, 200);
            this.button_rp_register.Name = "button_rp_register";
            this.button_rp_register.Size = new System.Drawing.Size(229, 29);
            this.button_rp_register.TabIndex = 16;
            this.button_rp_register.Text = "ZAREJESTRUJ";
            this.button_rp_register.UseVisualStyleBackColor = true;
            this.button_rp_register.Click += new System.EventHandler(this.button_rp_register_Click);
            // 
            // button_rp_login
            // 
            this.button_rp_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rp_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.button_rp_login.Location = new System.Drawing.Point(355, 93);
            this.button_rp_login.Name = "button_rp_login";
            this.button_rp_login.Size = new System.Drawing.Size(112, 23);
            this.button_rp_login.TabIndex = 17;
            this.button_rp_login.Text = "Sprawdź dostępność";
            this.button_rp_login.UseVisualStyleBackColor = true;
            this.button_rp_login.Click += new System.EventHandler(this.button_rp_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.tab_logging);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSW lab4 logowanie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_logging.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tab_register.ResumeLayout(false);
            this.tab_register.PerformLayout();
            this.table_register.ResumeLayout(false);
            this.table_register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_logging;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tab_register;
        private System.Windows.Forms.TableLayoutPanel table_register;
        private System.Windows.Forms.Label label_rp_title;
        private System.Windows.Forms.Label label_rp_name;
        private System.Windows.Forms.Label label_rp_surname;
        private System.Windows.Forms.Label label_rp_login;
        private System.Windows.Forms.Label label_rp_password1;
        private System.Windows.Forms.Label label_rp_password2;
        private System.Windows.Forms.Label label_rp_email;
        private System.Windows.Forms.CheckBox checkBox_rp_password;
        private System.Windows.Forms.Label label_rp_password_match;
        private System.Windows.Forms.Label label_rp_email_valid;
        private System.Windows.Forms.TextBox textBox_rp_email;
        private System.Windows.Forms.TextBox textBox_rp_name;
        private System.Windows.Forms.TextBox textBox_rp_surname;
        private System.Windows.Forms.TextBox textBox_rp_login;
        private System.Windows.Forms.TextBox textBox_rp_password1;
        private System.Windows.Forms.TextBox textBox_rp_password2;
        private System.Windows.Forms.Button button_rp_register;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_lp_title;
        private System.Windows.Forms.Label label_lp_login;
        private System.Windows.Forms.Label label_lp_password;
        private System.Windows.Forms.TextBox lp_name;
        private System.Windows.Forms.TextBox lp_password;
        private System.Windows.Forms.Button button_lp_login;
        private System.Windows.Forms.Button button_rp_login;
        private System.Windows.Forms.CheckBox lp_checkBox;
    }
}

