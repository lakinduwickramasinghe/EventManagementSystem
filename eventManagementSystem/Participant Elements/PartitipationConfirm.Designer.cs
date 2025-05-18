namespace eventManagementSystem.admin
{
    partial class PartitipationConfirm
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
            this.confirmButton = new Guna.UI2.WinForms.Guna2Button();
            this.countBox = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ticketPriceLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.eventtypeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.eventNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.addressLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pb1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.countBox)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.CheckedState.Parent = this.confirmButton;
            this.confirmButton.CustomImages.Parent = this.confirmButton;
            this.confirmButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(19)))), ((int)(((byte)(1)))));
            this.confirmButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.HoverState.Parent = this.confirmButton;
            this.confirmButton.Location = new System.Drawing.Point(548, 82);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.ShadowDecoration.Parent = this.confirmButton;
            this.confirmButton.Size = new System.Drawing.Size(180, 45);
            this.confirmButton.TabIndex = 16;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // countBox
            // 
            this.countBox.BackColor = System.Drawing.Color.Transparent;
            this.countBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.countBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.countBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.countBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.countBox.DisabledState.Parent = this.countBox;
            this.countBox.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.countBox.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.countBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.countBox.FocusedState.Parent = this.countBox;
            this.countBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.countBox.Location = new System.Drawing.Point(383, 82);
            this.countBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.countBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countBox.Name = "countBox";
            this.countBox.ShadowDecoration.Parent = this.countBox;
            this.countBox.Size = new System.Drawing.Size(118, 36);
            this.countBox.TabIndex = 15;
            this.countBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ticketPriceLabel
            // 
            this.ticketPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.ticketPriceLabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketPriceLabel.Location = new System.Drawing.Point(203, 86);
            this.ticketPriceLabel.Name = "ticketPriceLabel";
            this.ticketPriceLabel.Size = new System.Drawing.Size(159, 32);
            this.ticketPriceLabel.TabIndex = 11;
            this.ticketPriceLabel.Text = "Participant Count :";
            // 
            // eventtypeLabel
            // 
            this.eventtypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.eventtypeLabel.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventtypeLabel.Location = new System.Drawing.Point(306, 77);
            this.eventtypeLabel.Name = "eventtypeLabel";
            this.eventtypeLabel.Size = new System.Drawing.Size(58, 32);
            this.eventtypeLabel.TabIndex = 6;
            this.eventtypeLabel.Text = "APR 01";
            this.eventtypeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.eventNameLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.Location = new System.Drawing.Point(306, 46);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(233, 38);
            this.eventNameLabel.TabIndex = 5;
            this.eventNameLabel.Text = "New York Jazz Festival";
            this.eventNameLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressLabel
            // 
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Poppins ExtraLight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(306, 15);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(211, 32);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Central Park, New York, NY";
            this.addressLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.guna2Panel1.Controls.Add(this.eventtypeLabel);
            this.guna2Panel1.Controls.Add(this.eventNameLabel);
            this.guna2Panel1.Controls.Add(this.addressLabel);
            this.guna2Panel1.Controls.Add(this.pb1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(888, 148);
            this.guna2Panel1.TabIndex = 2;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(42, 15);
            this.pb1.Name = "pb1";
            this.pb1.ShadowDecoration.Parent = this.pb1;
            this.pb1.Size = new System.Drawing.Size(213, 120);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.guna2Panel2.Controls.Add(this.confirmButton);
            this.guna2Panel2.Controls.Add(this.countBox);
            this.guna2Panel2.Controls.Add(this.ticketPriceLabel);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 149);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(888, 184);
            this.guna2Panel2.TabIndex = 3;
            // 
            // PartitipationConfirm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "PartitipationConfirm";
            this.Size = new System.Drawing.Size(888, 333);
            this.Load += new System.EventHandler(this.PartitipationConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countBox)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button confirmButton;
        private Guna.UI2.WinForms.Guna2NumericUpDown countBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel ticketPriceLabel;
        public Guna.UI2.WinForms.Guna2HtmlLabel eventtypeLabel;
        public Guna.UI2.WinForms.Guna2HtmlLabel eventNameLabel;
        public Guna.UI2.WinForms.Guna2HtmlLabel addressLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pb1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
