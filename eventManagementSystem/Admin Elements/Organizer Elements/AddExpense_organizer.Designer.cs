namespace eventManagementSystem.admin
{
    partial class AddExpense_organizer
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
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.addexpenseButton = new Guna.UI2.WinForms.Guna2Button();
            this.expenseCategoryCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.expenseRemarksTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.expenseAmountTextbox = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.expenseAmountTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.CheckedState.Parent = this.cancelButton;
            this.cancelButton.CustomImages.Parent = this.cancelButton;
            this.cancelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(138)))), ((int)(((byte)(169)))));
            this.cancelButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.HoverState.Parent = this.cancelButton;
            this.cancelButton.Location = new System.Drawing.Point(417, 412);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.ShadowDecoration.Parent = this.cancelButton;
            this.cancelButton.Size = new System.Drawing.Size(180, 45);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addexpenseButton
            // 
            this.addexpenseButton.CheckedState.Parent = this.addexpenseButton;
            this.addexpenseButton.CustomImages.Parent = this.addexpenseButton;
            this.addexpenseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(138)))), ((int)(((byte)(169)))));
            this.addexpenseButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addexpenseButton.ForeColor = System.Drawing.Color.White;
            this.addexpenseButton.HoverState.Parent = this.addexpenseButton;
            this.addexpenseButton.Location = new System.Drawing.Point(629, 412);
            this.addexpenseButton.Name = "addexpenseButton";
            this.addexpenseButton.ShadowDecoration.Parent = this.addexpenseButton;
            this.addexpenseButton.Size = new System.Drawing.Size(180, 45);
            this.addexpenseButton.TabIndex = 15;
            this.addexpenseButton.Text = "Add Expense";
            this.addexpenseButton.Click += new System.EventHandler(this.addexpenseButton_Click);
            // 
            // expenseCategoryCombobox
            // 
            this.expenseCategoryCombobox.BackColor = System.Drawing.Color.Transparent;
            this.expenseCategoryCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.expenseCategoryCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expenseCategoryCombobox.FocusedColor = System.Drawing.Color.Empty;
            this.expenseCategoryCombobox.FocusedState.Parent = this.expenseCategoryCombobox;
            this.expenseCategoryCombobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.expenseCategoryCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.expenseCategoryCombobox.FormattingEnabled = true;
            this.expenseCategoryCombobox.HoverState.Parent = this.expenseCategoryCombobox;
            this.expenseCategoryCombobox.ItemHeight = 30;
            this.expenseCategoryCombobox.ItemsAppearance.Parent = this.expenseCategoryCombobox;
            this.expenseCategoryCombobox.Location = new System.Drawing.Point(542, 167);
            this.expenseCategoryCombobox.Name = "expenseCategoryCombobox";
            this.expenseCategoryCombobox.ShadowDecoration.Parent = this.expenseCategoryCombobox;
            this.expenseCategoryCombobox.Size = new System.Drawing.Size(267, 36);
            this.expenseCategoryCombobox.TabIndex = 14;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(366, 270);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(169, 32);
            this.guna2HtmlLabel3.TabIndex = 13;
            this.guna2HtmlLabel3.Text = "Remarks (Optional)";
            // 
            // expenseRemarksTextbox
            // 
            this.expenseRemarksTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expenseRemarksTextbox.DefaultText = "";
            this.expenseRemarksTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.expenseRemarksTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.expenseRemarksTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expenseRemarksTextbox.DisabledState.Parent = this.expenseRemarksTextbox;
            this.expenseRemarksTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expenseRemarksTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expenseRemarksTextbox.FocusedState.Parent = this.expenseRemarksTextbox;
            this.expenseRemarksTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expenseRemarksTextbox.HoverState.Parent = this.expenseRemarksTextbox;
            this.expenseRemarksTextbox.Location = new System.Drawing.Point(542, 270);
            this.expenseRemarksTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expenseRemarksTextbox.Name = "expenseRemarksTextbox";
            this.expenseRemarksTextbox.PasswordChar = '\0';
            this.expenseRemarksTextbox.PlaceholderText = "";
            this.expenseRemarksTextbox.SelectedText = "";
            this.expenseRemarksTextbox.ShadowDecoration.Parent = this.expenseRemarksTextbox;
            this.expenseRemarksTextbox.Size = new System.Drawing.Size(267, 44);
            this.expenseRemarksTextbox.TabIndex = 12;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(379, 167);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(157, 32);
            this.guna2HtmlLabel2.TabIndex = 11;
            this.guna2HtmlLabel2.Text = "Expense Category";
            // 
            // expenseAmountTextbox
            // 
            this.expenseAmountTextbox.BackColor = System.Drawing.Color.Transparent;
            this.expenseAmountTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expenseAmountTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.expenseAmountTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.expenseAmountTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expenseAmountTextbox.DisabledState.Parent = this.expenseAmountTextbox;
            this.expenseAmountTextbox.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.expenseAmountTextbox.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.expenseAmountTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expenseAmountTextbox.FocusedState.Parent = this.expenseAmountTextbox;
            this.expenseAmountTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseAmountTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.expenseAmountTextbox.Location = new System.Drawing.Point(542, 66);
            this.expenseAmountTextbox.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.expenseAmountTextbox.Name = "expenseAmountTextbox";
            this.expenseAmountTextbox.ShadowDecoration.Parent = this.expenseAmountTextbox;
            this.expenseAmountTextbox.Size = new System.Drawing.Size(267, 36);
            this.expenseAmountTextbox.TabIndex = 10;
            this.expenseAmountTextbox.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(138)))), ((int)(((byte)(169)))));
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(390, 66);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(146, 32);
            this.guna2HtmlLabel1.TabIndex = 9;
            this.guna2HtmlLabel1.Text = "Expense Amount";
            // 
            // AddExpense_organizer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addexpenseButton);
            this.Controls.Add(this.expenseCategoryCombobox);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.expenseRemarksTextbox);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.expenseAmountTextbox);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "AddExpense_organizer";
            this.Size = new System.Drawing.Size(1174, 523);
            this.Load += new System.EventHandler(this.AddExpense_organizer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expenseAmountTextbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2Button addexpenseButton;
        private Guna.UI2.WinForms.Guna2ComboBox expenseCategoryCombobox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox expenseRemarksTextbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2NumericUpDown expenseAmountTextbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
