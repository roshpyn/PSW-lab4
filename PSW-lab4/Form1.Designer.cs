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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoggingBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel1 = new System.Windows.Forms.Label();
            this.PasswordLabel2 = new System.Windows.Forms.Label();
            this.PasswordErrorBox = new System.Windows.Forms.Label();
            this.PasswordCheckBox1 = new System.Windows.Forms.CheckBox();
            this.PasswordTextbox1 = new System.Windows.Forms.TextBox();
            this.PasswordTextbox2 = new System.Windows.Forms.TextBox();
            this.LoggingBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoggingBox
            // 
            this.LoggingBox.Controls.Add(this.tableLayoutPanel1);
            this.LoggingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoggingBox.Location = new System.Drawing.Point(0, 0);
            this.LoggingBox.Name = "LoggingBox";
            this.LoggingBox.Size = new System.Drawing.Size(476, 312);
            this.LoggingBox.TabIndex = 2;
            this.LoggingBox.TabStop = false;
            this.LoggingBox.Text = "Logowanie";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.LoginTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LoginLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PasswordLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PasswordErrorBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.PasswordCheckBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordTextbox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordTextbox2, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 87);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginTextBox.Location = new System.Drawing.Point(90, 3);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.LoginTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginLabel.Location = new System.Drawing.Point(3, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(81, 26);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login: ";
            // 
            // PasswordLabel1
            // 
            this.PasswordLabel1.AutoSize = true;
            this.PasswordLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordLabel1.Location = new System.Drawing.Point(3, 26);
            this.PasswordLabel1.Name = "PasswordLabel1";
            this.PasswordLabel1.Size = new System.Drawing.Size(81, 26);
            this.PasswordLabel1.TabIndex = 2;
            this.PasswordLabel1.Text = "Hasło: ";
            // 
            // PasswordLabel2
            // 
            this.PasswordLabel2.AutoSize = true;
            this.PasswordLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordLabel2.Location = new System.Drawing.Point(3, 52);
            this.PasswordLabel2.Name = "PasswordLabel2";
            this.PasswordLabel2.Size = new System.Drawing.Size(81, 35);
            this.PasswordLabel2.TabIndex = 3;
            this.PasswordLabel2.Text = "Powtórz hasło: ";
            // 
            // PasswordErrorBox
            // 
            this.PasswordErrorBox.AutoSize = true;
            this.PasswordErrorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordErrorBox.ForeColor = System.Drawing.Color.Red;
            this.PasswordErrorBox.Location = new System.Drawing.Point(287, 52);
            this.PasswordErrorBox.Name = "PasswordErrorBox";
            this.PasswordErrorBox.Size = new System.Drawing.Size(113, 35);
            this.PasswordErrorBox.TabIndex = 9;
            this.PasswordErrorBox.Text = "Hasła nie są zgodne";
            this.PasswordErrorBox.Visible = false;
            // 
            // PasswordCheckBox1
            // 
            this.PasswordCheckBox1.AutoSize = true;
            this.PasswordCheckBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordCheckBox1.Location = new System.Drawing.Point(196, 29);
            this.PasswordCheckBox1.Name = "PasswordCheckBox1";
            this.PasswordCheckBox1.Size = new System.Drawing.Size(85, 20);
            this.PasswordCheckBox1.TabIndex = 6;
            this.PasswordCheckBox1.Text = "pokaż hasło";
            this.PasswordCheckBox1.UseVisualStyleBackColor = true;
            this.PasswordCheckBox1.CheckedChanged += new System.EventHandler(this.PasswordCheckbox1_Checked);
            // 
            // PasswordTextbox1
            // 
            this.PasswordTextbox1.Location = new System.Drawing.Point(90, 29);
            this.PasswordTextbox1.Name = "PasswordTextbox1";
            this.PasswordTextbox1.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextbox1.TabIndex = 10;
            this.PasswordTextbox1.UseSystemPasswordChar = true;
            // 
            // PasswordTextbox2
            // 
            this.PasswordTextbox2.Location = new System.Drawing.Point(90, 55);
            this.PasswordTextbox2.Name = "PasswordTextbox2";
            this.PasswordTextbox2.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextbox2.TabIndex = 11;
            this.PasswordTextbox2.UseSystemPasswordChar = true;
            this.PasswordTextbox2.TextChanged += new System.EventHandler(this.PasswordTextbox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 312);
            this.Controls.Add(this.LoggingBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSW lab4 logowanie";
            this.LoggingBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox LoggingBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label PasswordLabel1;
        private System.Windows.Forms.Label PasswordLabel2;
        private System.Windows.Forms.CheckBox PasswordCheckBox1;
        private System.Windows.Forms.Label PasswordErrorBox;
        private System.Windows.Forms.TextBox PasswordTextbox1;
        private System.Windows.Forms.TextBox PasswordTextbox2;
    }
}

