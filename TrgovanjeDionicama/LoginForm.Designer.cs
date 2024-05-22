namespace TrgovanjeDionicama
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.labelaGuest = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLabela = new System.Windows.Forms.Label();
            this.usernameLabela = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usernameTextBox.Location = new System.Drawing.Point(135, 228);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(265, 22);
            this.usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.Location = new System.Drawing.Point(135, 356);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(265, 22);
            this.passwordTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.labelaGuest);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.passwordLabela);
            this.panel1.Controls.Add(this.usernameLabela);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.ForeColor = System.Drawing.Color.Salmon;
            this.panel1.Location = new System.Drawing.Point(260, 172);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 738);
            this.panel1.TabIndex = 2;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(243, 575);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(36, 27);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "or";
            // 
            // labelaGuest
            // 
            this.labelaGuest.ActiveLinkColor = System.Drawing.Color.Lime;
            this.labelaGuest.AutoSize = true;
            this.labelaGuest.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaGuest.LinkColor = System.Drawing.Color.Red;
            this.labelaGuest.Location = new System.Drawing.Point(136, 602);
            this.labelaGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelaGuest.Name = "labelaGuest";
            this.labelaGuest.Size = new System.Drawing.Size(252, 32);
            this.labelaGuest.TabIndex = 6;
            this.labelaGuest.TabStop = true;
            this.labelaGuest.Text = "continue as guest";
            this.labelaGuest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(96, 532);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(350, 32);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create your user account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.loginButton.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Red;
            this.loginButton.Location = new System.Drawing.Point(196, 439);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(135, 50);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabela
            // 
            this.passwordLabela.AutoSize = true;
            this.passwordLabela.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabela.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabela.ForeColor = System.Drawing.Color.Red;
            this.passwordLabela.Location = new System.Drawing.Point(197, 299);
            this.passwordLabela.Name = "passwordLabela";
            this.passwordLabela.Size = new System.Drawing.Size(126, 32);
            this.passwordLabela.TabIndex = 3;
            this.passwordLabela.Text = "Password";
            // 
            // usernameLabela
            // 
            this.usernameLabela.AutoSize = true;
            this.usernameLabela.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabela.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabela.ForeColor = System.Drawing.Color.Red;
            this.usernameLabela.Location = new System.Drawing.Point(197, 169);
            this.usernameLabela.Name = "usernameLabela";
            this.usernameLabela.Size = new System.Drawing.Size(126, 32);
            this.usernameLabela.TabIndex = 2;
            this.usernameLabela.Text = "Username";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 805);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkSalmon;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabela;
        private System.Windows.Forms.Label usernameLabela;
        public System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel labelaGuest;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}
