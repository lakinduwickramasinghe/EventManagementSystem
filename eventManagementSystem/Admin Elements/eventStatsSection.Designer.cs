namespace eventManagementSystem.admin
{
    partial class eventStatsSection
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.eventNameLabel = new System.Windows.Forms.RichTextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.soldAmountLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.eventNameLabel);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.soldAmountLabel);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(257, 118);
            this.guna2Panel1.TabIndex = 2;
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.eventNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventNameLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.eventNameLabel.Location = new System.Drawing.Point(16, 3);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.ReadOnly = true;
            this.eventNameLabel.Size = new System.Drawing.Size(215, 60);
            this.eventNameLabel.TabIndex = 3;
            this.eventNameLabel.Text = "";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(37, 69);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(137, 38);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Tickets Sales : ";
            // 
            // soldAmountLabel
            // 
            this.soldAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.soldAmountLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldAmountLabel.ForeColor = System.Drawing.Color.White;
            this.soldAmountLabel.Location = new System.Drawing.Point(191, 69);
            this.soldAmountLabel.Name = "soldAmountLabel";
            this.soldAmountLabel.Size = new System.Drawing.Size(26, 38);
            this.soldAmountLabel.TabIndex = 1;
            this.soldAmountLabel.Text = "27";
            // 
            // eventStatsSection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "eventStatsSection";
            this.Size = new System.Drawing.Size(257, 118);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        public Guna.UI2.WinForms.Guna2HtmlLabel soldAmountLabel;
        public System.Windows.Forms.RichTextBox eventNameLabel;
    }
}
