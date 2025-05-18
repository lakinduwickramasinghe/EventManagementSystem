namespace eventManagementSystem.admin
{
    partial class ProfileView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileView));
            this.profilePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.emailLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.resetPasswordButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteAccountButton = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.profilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.deleteAccountButton);
            this.profilePanel.Controls.Add(this.resetPasswordButton);
            this.profilePanel.Controls.Add(this.emailLabel);
            this.profilePanel.Controls.Add(this.guna2ImageButton1);
            this.profilePanel.Location = new System.Drawing.Point(67, 29);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.ShadowDecoration.Parent = this.profilePanel;
            this.profilePanel.Size = new System.Drawing.Size(319, 521);
            this.profilePanel.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(840, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(143, 38);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Your Bookings";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(200, 200);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(200, 200);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(200, 200);
            this.guna2ImageButton1.Location = new System.Drawing.Point(62, 25);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(186, 221);
            this.guna2ImageButton1.TabIndex = 0;
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(18, 269);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(268, 33);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "lakindusudaraka@gmail.com";
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.CheckedState.Parent = this.resetPasswordButton;
            this.resetPasswordButton.CustomImages.Parent = this.resetPasswordButton;
            this.resetPasswordButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resetPasswordButton.ForeColor = System.Drawing.Color.White;
            this.resetPasswordButton.HoverState.Parent = this.resetPasswordButton;
            this.resetPasswordButton.Location = new System.Drawing.Point(25, 334);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.ShadowDecoration.Parent = this.resetPasswordButton;
            this.resetPasswordButton.Size = new System.Drawing.Size(268, 45);
            this.resetPasswordButton.TabIndex = 2;
            this.resetPasswordButton.Text = "Reset Password";
            this.resetPasswordButton.Click += new System.EventHandler(this.resetPasswordButton_Click);
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.CheckedState.Parent = this.deleteAccountButton;
            this.deleteAccountButton.CustomImages.Parent = this.deleteAccountButton;
            this.deleteAccountButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteAccountButton.ForeColor = System.Drawing.Color.White;
            this.deleteAccountButton.HoverState.Parent = this.deleteAccountButton;
            this.deleteAccountButton.Location = new System.Drawing.Point(25, 399);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.ShadowDecoration.Parent = this.deleteAccountButton;
            this.deleteAccountButton.Size = new System.Drawing.Size(268, 45);
            this.deleteAccountButton.TabIndex = 3;
            this.deleteAccountButton.Text = "Delete Account";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Location = new System.Drawing.Point(451, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(930, 469);
            this.mainPanel.TabIndex = 0;
            // 
            // ProfileView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.profilePanel);
            this.Name = "ProfileView";
            this.Size = new System.Drawing.Size(1400, 587);
            this.Load += new System.EventHandler(this.ProfileView_Load);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel profilePanel;
        private Guna.UI2.WinForms.Guna2Button deleteAccountButton;
        private Guna.UI2.WinForms.Guna2Button resetPasswordButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel emailLabel;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
    }
}
