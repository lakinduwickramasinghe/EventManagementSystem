namespace eventManagementSystem
{
    partial class viewCategories
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
            this.categorisDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensecategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emsDataSet9 = new eventManagementSystem.emsDataSet9();
            this.expense_categoriesTableAdapter = new eventManagementSystem.emsDataSet9TableAdapters.expense_categoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categorisDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensecategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // categorisDataGrid
            // 
            this.categorisDataGrid.AllowUserToAddRows = false;
            this.categorisDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.categorisDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.categorisDataGrid.AutoGenerateColumns = false;
            this.categorisDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categorisDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.categorisDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categorisDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.categorisDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categorisDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.categorisDataGrid.ColumnHeadersHeight = 27;
            this.categorisDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryId,
            this.categoryNameDataGridViewTextBoxColumn});
            this.categorisDataGrid.DataSource = this.expensecategoriesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categorisDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.categorisDataGrid.EnableHeadersVisualStyles = false;
            this.categorisDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categorisDataGrid.Location = new System.Drawing.Point(19, 16);
            this.categorisDataGrid.Name = "categorisDataGrid";
            this.categorisDataGrid.ReadOnly = true;
            this.categorisDataGrid.RowHeadersVisible = false;
            this.categorisDataGrid.RowHeadersWidth = 51;
            this.categorisDataGrid.RowTemplate.Height = 40;
            this.categorisDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categorisDataGrid.Size = new System.Drawing.Size(554, 459);
            this.categorisDataGrid.TabIndex = 0;
            this.categorisDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.categorisDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.categorisDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.categorisDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.categorisDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.categorisDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.categorisDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.categorisDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categorisDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.categorisDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.categorisDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.categorisDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.categorisDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.categorisDataGrid.ThemeStyle.HeaderStyle.Height = 27;
            this.categorisDataGrid.ThemeStyle.ReadOnly = true;
            this.categorisDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.categorisDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.categorisDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.categorisDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.categorisDataGrid.ThemeStyle.RowsStyle.Height = 40;
            this.categorisDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categorisDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.categorisDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categorisDataGrid_CellContentClick);
            // 
            // categoryId
            // 
            this.categoryId.DataPropertyName = "categoryId";
            this.categoryId.HeaderText = "Category ID";
            this.categoryId.MinimumWidth = 6;
            this.categoryId.Name = "categoryId";
            this.categoryId.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "categoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Category Name";
            this.categoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expensecategoriesBindingSource
            // 
            this.expensecategoriesBindingSource.DataMember = "expense_categories";
            this.expensecategoriesBindingSource.DataSource = this.emsDataSet9;
            // 
            // emsDataSet9
            // 
            this.emsDataSet9.DataSetName = "emsDataSet9";
            this.emsDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expense_categoriesTableAdapter
            // 
            this.expense_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // viewCategories
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.categorisDataGrid);
            this.Name = "viewCategories";
            this.Size = new System.Drawing.Size(600, 500);
            this.Load += new System.EventHandler(this.viewCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categorisDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensecategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView categorisDataGrid;
        private System.Windows.Forms.BindingSource expensecategoriesBindingSource;
        private emsDataSet9 emsDataSet9;
        private emsDataSet9TableAdapters.expense_categoriesTableAdapter expense_categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
    }
}
