namespace eventManagementSystem.Usercontrols
{
    partial class VenueView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenueView));
            this.pb1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.venueNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.venueAddressLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.eventSpacesLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.selectVenueButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(10, 13);
            this.pb1.Name = "pb1";
            this.pb1.ShadowDecoration.Parent = this.pb1;
            this.pb1.Size = new System.Drawing.Size(550, 307);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // venueNameLabel
            // 
            this.venueNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.venueNameLabel.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueNameLabel.Location = new System.Drawing.Point(9, 327);
            this.venueNameLabel.Name = "venueNameLabel";
            this.venueNameLabel.Size = new System.Drawing.Size(199, 55);
            this.venueNameLabel.TabIndex = 1;
            this.venueNameLabel.Text = "Taj Samudra";
            // 
            // venueAddressLabel
            // 
            this.venueAddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.venueAddressLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.venueAddressLabel.Location = new System.Drawing.Point(9, 371);
            this.venueAddressLabel.Name = "venueAddressLabel";
            this.venueAddressLabel.Size = new System.Drawing.Size(133, 38);
            this.venueAddressLabel.TabIndex = 2;
            this.venueAddressLabel.Text = "Colombo - 5";
            // 
            // eventSpacesLabel
            // 
            this.eventSpacesLabel.BackColor = System.Drawing.Color.Transparent;
            this.eventSpacesLabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventSpacesLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.eventSpacesLabel.Location = new System.Drawing.Point(10, 414);
            this.eventSpacesLabel.Name = "eventSpacesLabel";
            this.eventSpacesLabel.Size = new System.Drawing.Size(224, 32);
            this.eventSpacesLabel.TabIndex = 3;
            this.eventSpacesLabel.Text = "Available Event Spaces : 9";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderRadius = 2;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.venueAddressLabel);
            this.guna2Panel1.Controls.Add(this.selectVenueButton);
            this.guna2Panel1.Controls.Add(this.pb1);
            this.guna2Panel1.Controls.Add(this.eventSpacesLabel);
            this.guna2Panel1.Controls.Add(this.venueNameLabel);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(570, 526);
            this.guna2Panel1.TabIndex = 4;
            // 
            // selectVenueButton
            // 
            this.selectVenueButton.BorderColor = System.Drawing.Color.Azure;
            this.selectVenueButton.BorderRadius = 21;
            this.selectVenueButton.CheckedState.Parent = this.selectVenueButton;
            this.selectVenueButton.CustomImages.Parent = this.selectVenueButton;
            this.selectVenueButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.selectVenueButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectVenueButton.ForeColor = System.Drawing.Color.White;
            this.selectVenueButton.HoverState.Parent = this.selectVenueButton;
            this.selectVenueButton.Image = ((System.Drawing.Image)(resources.GetObject("selectVenueButton.Image")));
            this.selectVenueButton.ImageOffset = new System.Drawing.Point(60, 0);
            this.selectVenueButton.ImageSize = new System.Drawing.Size(35, 35);
            this.selectVenueButton.Location = new System.Drawing.Point(177, 469);
            this.selectVenueButton.Name = "selectVenueButton";
            this.selectVenueButton.ShadowDecoration.Parent = this.selectVenueButton;
            this.selectVenueButton.Size = new System.Drawing.Size(178, 41);
            this.selectVenueButton.TabIndex = 4;
            this.selectVenueButton.Text = "Select Venue";
            this.selectVenueButton.TextOffset = new System.Drawing.Point(-18, 0);
            this.selectVenueButton.Click += new System.EventHandler(this.selectVenueButton_Click);
            // 
            // VenueView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "VenueView";
            this.Size = new System.Drawing.Size(570, 526);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox pb1;
        public Guna.UI2.WinForms.Guna2HtmlLabel venueNameLabel;
        public Guna.UI2.WinForms.Guna2HtmlLabel venueAddressLabel;
        public Guna.UI2.WinForms.Guna2HtmlLabel eventSpacesLabel;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2Button selectVenueButton;
    }

}
