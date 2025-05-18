namespace eventManagementSystem
{
    partial class expenseView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.emsDataSet7 = new eventManagementSystem.emsDataSet7();
            this.eventexpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.event_expenseTableAdapter = new eventManagementSystem.emsDataSet7TableAdapters.event_expenseTableAdapter();
            this.expenseDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.expenseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseRemarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventexpenseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emsDataSet8 = new eventManagementSystem.emsDataSet8();
            this.event_expenseTableAdapter1 = new eventManagementSystem.emsDataSet8TableAdapters.event_expenseTableAdapter();
            this.categoriesButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventexpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventexpenseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // emsDataSet7
            // 
            this.emsDataSet7.DataSetName = "emsDataSet7";
            this.emsDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventexpenseBindingSource
            // 
            this.eventexpenseBindingSource.DataMember = "event_expense";
            this.eventexpenseBindingSource.DataSource = this.emsDataSet7;
            // 
            // event_expenseTableAdapter
            // 
            this.event_expenseTableAdapter.ClearBeforeFill = true;
            // 
            // expenseDataGrid
            // 
            this.expenseDataGrid.AllowUserToAddRows = false;
            this.expenseDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.expenseDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.expenseDataGrid.AutoGenerateColumns = false;
            this.expenseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expenseDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.expenseDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expenseDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.expenseDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.expenseDataGrid.ColumnHeadersHeight = 27;
            this.expenseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expenseIdDataGridViewTextBoxColumn,
            this.eventIdDataGridViewTextBoxColumn,
            this.expenseAmountDataGridViewTextBoxColumn,
            this.expenseCategoryDataGridViewTextBoxColumn,
            this.expenseRemarksDataGridViewTextBoxColumn});
            this.expenseDataGrid.DataSource = this.eventexpenseBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expenseDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.expenseDataGrid.EnableHeadersVisualStyles = false;
            this.expenseDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.expenseDataGrid.Location = new System.Drawing.Point(15, 75);
            this.expenseDataGrid.Name = "expenseDataGrid";
            this.expenseDataGrid.ReadOnly = true;
            this.expenseDataGrid.RowHeadersVisible = false;
            this.expenseDataGrid.RowHeadersWidth = 51;
            this.expenseDataGrid.RowTemplate.Height = 50;
            this.expenseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expenseDataGrid.Size = new System.Drawing.Size(1139, 422);
            this.expenseDataGrid.TabIndex = 0;
            this.expenseDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.expenseDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.expenseDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.expenseDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.expenseDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.expenseDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.expenseDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.expenseDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.expenseDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.expenseDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.expenseDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.expenseDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.expenseDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.expenseDataGrid.ThemeStyle.HeaderStyle.Height = 27;
            this.expenseDataGrid.ThemeStyle.ReadOnly = true;
            this.expenseDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.expenseDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.expenseDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.expenseDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.expenseDataGrid.ThemeStyle.RowsStyle.Height = 50;
            this.expenseDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.expenseDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // expenseIdDataGridViewTextBoxColumn
            // 
            this.expenseIdDataGridViewTextBoxColumn.DataPropertyName = "expenseId";
            this.expenseIdDataGridViewTextBoxColumn.HeaderText = "Expense ID";
            this.expenseIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expenseIdDataGridViewTextBoxColumn.Name = "expenseIdDataGridViewTextBoxColumn";
            this.expenseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventIdDataGridViewTextBoxColumn
            // 
            this.eventIdDataGridViewTextBoxColumn.DataPropertyName = "eventId";
            this.eventIdDataGridViewTextBoxColumn.HeaderText = "Event ID";
            this.eventIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventIdDataGridViewTextBoxColumn.Name = "eventIdDataGridViewTextBoxColumn";
            this.eventIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseAmountDataGridViewTextBoxColumn
            // 
            this.expenseAmountDataGridViewTextBoxColumn.DataPropertyName = "expenseAmount";
            this.expenseAmountDataGridViewTextBoxColumn.HeaderText = "Expense Amount";
            this.expenseAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expenseAmountDataGridViewTextBoxColumn.Name = "expenseAmountDataGridViewTextBoxColumn";
            this.expenseAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseCategoryDataGridViewTextBoxColumn
            // 
            this.expenseCategoryDataGridViewTextBoxColumn.DataPropertyName = "expenseCategory";
            this.expenseCategoryDataGridViewTextBoxColumn.HeaderText = "Expense Category";
            this.expenseCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expenseCategoryDataGridViewTextBoxColumn.Name = "expenseCategoryDataGridViewTextBoxColumn";
            this.expenseCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseRemarksDataGridViewTextBoxColumn
            // 
            this.expenseRemarksDataGridViewTextBoxColumn.DataPropertyName = "expenseRemarks";
            this.expenseRemarksDataGridViewTextBoxColumn.HeaderText = "Expense Remarks";
            this.expenseRemarksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expenseRemarksDataGridViewTextBoxColumn.Name = "expenseRemarksDataGridViewTextBoxColumn";
            this.expenseRemarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventexpenseBindingSource1
            // 
            this.eventexpenseBindingSource1.DataMember = "event_expense";
            this.eventexpenseBindingSource1.DataSource = this.emsDataSet8;
            // 
            // emsDataSet8
            // 
            this.emsDataSet8.DataSetName = "emsDataSet8";
            this.emsDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // event_expenseTableAdapter1
            // 
            this.event_expenseTableAdapter1.ClearBeforeFill = true;
            // 
            // categoriesButton
            // 
            this.categoriesButton.CheckedState.Parent = this.categoriesButton;
            this.categoriesButton.CustomImages.Parent = this.categoriesButton;
            this.categoriesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(138)))), ((int)(((byte)(169)))));
            this.categoriesButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoriesButton.ForeColor = System.Drawing.Color.White;
            this.categoriesButton.HoverState.Parent = this.categoriesButton;
            this.categoriesButton.Location = new System.Drawing.Point(960, 13);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.ShadowDecoration.Parent = this.categoriesButton;
            this.categoriesButton.Size = new System.Drawing.Size(180, 48);
            this.categoriesButton.TabIndex = 1;
            this.categoriesButton.Text = "Expenses Categories";
            this.categoriesButton.Click += new System.EventHandler(this.categoriesButton_Click);
            // 
            // expenseView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.categoriesButton);
            this.Controls.Add(this.expenseDataGrid);
            this.Name = "expenseView";
            this.Size = new System.Drawing.Size(1174, 523);
            this.Load += new System.EventHandler(this.load);
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventexpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventexpenseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private emsDataSet7 emsDataSet7;
        private System.Windows.Forms.BindingSource eventexpenseBindingSource;
        private emsDataSet7TableAdapters.event_expenseTableAdapter event_expenseTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView expenseDataGrid;
        private System.Windows.Forms.BindingSource eventexpenseBindingSource1;
        private emsDataSet8 emsDataSet8;
        private emsDataSet8TableAdapters.event_expenseTableAdapter event_expenseTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseRemarksDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button categoriesButton;
    }
}
