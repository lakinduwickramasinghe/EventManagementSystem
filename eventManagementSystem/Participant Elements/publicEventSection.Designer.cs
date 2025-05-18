namespace eventManagementSystem.Class
{
    partial class publicEventSection
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
            this.panelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.imageBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ticketButton = new Guna.UI2.WinForms.Guna2Button();
            this.eventtypeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.eventNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.addressLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BorderColor = System.Drawing.Color.LightGray;
            this.panelContainer.BorderRadius = 10;
            this.panelContainer.BorderThickness = 1;
            this.panelContainer.Controls.Add(this.imageBox);
            this.panelContainer.Controls.Add(this.ticketButton);
            this.panelContainer.Controls.Add(this.eventtypeLabel);
            this.panelContainer.Controls.Add(this.eventNameLabel);
            this.panelContainer.Controls.Add(this.addressLabel);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(10);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.ShadowDecoration.Parent = this.panelContainer;
            this.panelContainer.Size = new System.Drawing.Size(876, 120);
            this.panelContainer.TabIndex = 0;
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(7, 7);
            this.imageBox.Name = "imageBox";
            this.imageBox.ShadowDecoration.Parent = this.imageBox;
            this.imageBox.Size = new System.Drawing.Size(190, 107);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 5;
            this.imageBox.TabStop = false;
            // 
            // ticketButton
            // 
            this.ticketButton.CheckedState.Parent = this.ticketButton;
            this.ticketButton.CustomImages.Parent = this.ticketButton;
            this.ticketButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(138)))), ((int)(((byte)(169)))));
            this.ticketButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketButton.ForeColor = System.Drawing.Color.White;
            this.ticketButton.HoverState.Parent = this.ticketButton;
            this.ticketButton.Location = new System.Drawing.Point(657, 39);
            this.ticketButton.Name = "ticketButton";
            this.ticketButton.ShadowDecoration.Parent = this.ticketButton;
            this.ticketButton.Size = new System.Drawing.Size(180, 45);
            this.ticketButton.TabIndex = 4;
            this.ticketButton.Text = "Find Tickets";
            this.ticketButton.Click += new System.EventHandler(this.ticketButton_Click);
            // 
            // eventtypeLabel
            // 
            this.eventtypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.eventtypeLabel.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventtypeLabel.Location = new System.Drawing.Point(231, 77);
            this.eventtypeLabel.Name = "eventtypeLabel";
            this.eventtypeLabel.Size = new System.Drawing.Size(58, 32);
            this.eventtypeLabel.TabIndex = 3;
            this.eventtypeLabel.Text = "APR 01";
            this.eventtypeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.eventNameLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.Location = new System.Drawing.Point(231, 46);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(233, 38);
            this.eventNameLabel.TabIndex = 2;
            this.eventNameLabel.Text = "New York Jazz Festival";
            this.eventNameLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressLabel
            // 
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Poppins ExtraLight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(231, 15);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(211, 32);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Central Park, New York, NY";
            this.addressLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // publicEventSection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelContainer);
            this.Name = "publicEventSection";
            this.Size = new System.Drawing.Size(880, 120);
            this.Load += new System.EventHandler(this.publicEventSection_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel panelContainer;
        public Guna.UI2.WinForms.Guna2Button ticketButton;
        public Guna.UI2.WinForms.Guna2HtmlLabel eventtypeLabel;
        public Guna.UI2.WinForms.Guna2HtmlLabel eventNameLabel;
        public Guna.UI2.WinForms.Guna2HtmlLabel addressLabel;
        public Guna.UI2.WinForms.Guna2PictureBox imageBox;
    }
}
