namespace eventManagementSystem
{
    partial class addCategory
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.categoryNameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(152, 15);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(287, 42);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Add Expense Category";
            // 
            // categoryNameTextbox
            // 
            this.categoryNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoryNameTextbox.DefaultText = "";
            this.categoryNameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categoryNameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categoryNameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryNameTextbox.DisabledState.Parent = this.categoryNameTextbox;
            this.categoryNameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryNameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryNameTextbox.FocusedState.Parent = this.categoryNameTextbox;
            this.categoryNameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryNameTextbox.HoverState.Parent = this.categoryNameTextbox;
            this.categoryNameTextbox.Location = new System.Drawing.Point(258, 107);
            this.categoryNameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoryNameTextbox.Name = "categoryNameTextbox";
            this.categoryNameTextbox.PasswordChar = '\0';
            this.categoryNameTextbox.PlaceholderText = "";
            this.categoryNameTextbox.SelectedText = "";
            this.categoryNameTextbox.ShadowDecoration.Parent = this.categoryNameTextbox;
            this.categoryNameTextbox.Size = new System.Drawing.Size(267, 44);
            this.categoryNameTextbox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.CheckedState.Parent = this.addButton;
            this.addButton.CustomImages.Parent = this.addButton;
            this.addButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(138)))), ((int)(((byte)(169)))));
            this.addButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.HoverState.Parent = this.addButton;
            this.addButton.Location = new System.Drawing.Point(212, 232);
            this.addButton.Name = "addButton";
            this.addButton.ShadowDecoration.Parent = this.addButton;
            this.addButton.Size = new System.Drawing.Size(180, 45);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Category";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(89, 118);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(148, 33);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Category Name";
            // 
            // addCategory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.categoryNameTextbox);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "addCategory";
            this.Size = new System.Drawing.Size(600, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox categoryNameTextbox;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}
