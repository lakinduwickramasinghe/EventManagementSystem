namespace eventManagementSystem.admin
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
            this.emailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.signinButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passwordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.createNewAccount = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailTextbox
            // 
            this.emailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextbox.DefaultText = "";
            this.emailTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextbox.DisabledState.Parent = this.emailTextbox;
            this.emailTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextbox.FocusedState.Parent = this.emailTextbox;
            this.emailTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextbox.HoverState.Parent = this.emailTextbox;
            this.emailTextbox.Location = new System.Drawing.Point(208, 184);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.PasswordChar = '\0';
            this.emailTextbox.PlaceholderText = "";
            this.emailTextbox.SelectedText = "";
            this.emailTextbox.ShadowDecoration.Parent = this.emailTextbox;
            this.emailTextbox.Size = new System.Drawing.Size(267, 44);
            this.emailTextbox.TabIndex = 1;
            this.emailTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.down);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(136, 190);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(58, 38);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Email";
            // 
            // signinButton
            // 
            this.signinButton.CheckedState.Parent = this.signinButton;
            this.signinButton.CustomImages.Parent = this.signinButton;
            this.signinButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(138)))), ((int)(((byte)(169)))));
            this.signinButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinButton.ForeColor = System.Drawing.Color.White;
            this.signinButton.HoverState.Parent = this.signinButton;
            this.signinButton.Location = new System.Drawing.Point(228, 390);
            this.signinButton.Name = "signinButton";
            this.signinButton.ShadowDecoration.Parent = this.signinButton;
            this.signinButton.Size = new System.Drawing.Size(180, 45);
            this.signinButton.TabIndex = 3;
            this.signinButton.Text = "Sign In";
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(602, 94);
            this.guna2Panel1.TabIndex = 3;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(228, 20);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(116, 60);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Sign In";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(18)))), ((int)(((byte)(0)))));
            this.guna2Panel2.Location = new System.Drawing.Point(-1, 94);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(602, 12);
            this.guna2Panel2.TabIndex = 4;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(95, 258);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(99, 38);
            this.guna2HtmlLabel3.TabIndex = 6;
            this.guna2HtmlLabel3.Text = "Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextbox.DefaultText = "";
            this.passwordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextbox.DisabledState.Parent = this.passwordTextbox;
            this.passwordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextbox.FocusedState.Parent = this.passwordTextbox;
            this.passwordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextbox.HoverState.Parent = this.passwordTextbox;
            this.passwordTextbox.Location = new System.Drawing.Point(210, 258);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.PlaceholderText = "";
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.ShadowDecoration.Parent = this.passwordTextbox;
            this.passwordTextbox.Size = new System.Drawing.Size(267, 44);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddown);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(410, 331);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(156, 32);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Forgot Password";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // createNewAccount
            // 
            this.createNewAccount.CheckedState.Parent = this.createNewAccount;
            this.createNewAccount.CustomImages.Parent = this.createNewAccount;
            this.createNewAccount.FillColor = System.Drawing.Color.Transparent;
            this.createNewAccount.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewAccount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.createNewAccount.HoverState.Parent = this.createNewAccount;
            this.createNewAccount.Location = new System.Drawing.Point(371, 478);
            this.createNewAccount.Name = "createNewAccount";
            this.createNewAccount.ShadowDecoration.Parent = this.createNewAccount;
            this.createNewAccount.Size = new System.Drawing.Size(211, 32);
            this.createNewAccount.TabIndex = 7;
            this.createNewAccount.Text = "Create A New Account";
            this.createNewAccount.Click += new System.EventHandler(this.createNewAccount_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(604, 560);
            this.Controls.Add(this.createNewAccount);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.signinButton);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.emailTextbox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "Sign In";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox emailTextbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button signinButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextbox;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button createNewAccount;
    }
}