namespace eventManagementSystem
{
    partial class ViewVenue_organizer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.venue_pendingTableAdapter = new eventManagementSystem.emsDataSet13TableAdapters.venue_pendingTableAdapter();
            this.venuependingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emsDataSet13 = new eventManagementSystem.emsDataSet13();
            this.compTINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compBRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compContactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueImagesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueContactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueEmailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueAddressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDisplayNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueTableAdapter = new eventManagementSystem.emsDataSet10TableAdapters.venueTableAdapter();
            this.emsDataSet10 = new eventManagementSystem.emsDataSet10();
            this.venueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.venueImagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueMobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDisplayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueRequestsGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.venueDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.venuependingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueRequestsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // venue_pendingTableAdapter
            // 
            this.venue_pendingTableAdapter.ClearBeforeFill = true;
            // 
            // venuependingBindingSource
            // 
            this.venuependingBindingSource.DataMember = "venue_pending";
            this.venuependingBindingSource.DataSource = this.emsDataSet13;
            // 
            // emsDataSet13
            // 
            this.emsDataSet13.DataSetName = "emsDataSet13";
            this.emsDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compTINDataGridViewTextBoxColumn
            // 
            this.compTINDataGridViewTextBoxColumn.DataPropertyName = "compTIN";
            this.compTINDataGridViewTextBoxColumn.HeaderText = "compTIN";
            this.compTINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compTINDataGridViewTextBoxColumn.Name = "compTINDataGridViewTextBoxColumn";
            this.compTINDataGridViewTextBoxColumn.ReadOnly = true;
            this.compTINDataGridViewTextBoxColumn.Visible = false;
            // 
            // compBRNDataGridViewTextBoxColumn
            // 
            this.compBRNDataGridViewTextBoxColumn.DataPropertyName = "compBRN";
            this.compBRNDataGridViewTextBoxColumn.HeaderText = "compBRN";
            this.compBRNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compBRNDataGridViewTextBoxColumn.Name = "compBRNDataGridViewTextBoxColumn";
            this.compBRNDataGridViewTextBoxColumn.ReadOnly = true;
            this.compBRNDataGridViewTextBoxColumn.Visible = false;
            // 
            // compContactNumberDataGridViewTextBoxColumn
            // 
            this.compContactNumberDataGridViewTextBoxColumn.DataPropertyName = "compContactNumber";
            this.compContactNumberDataGridViewTextBoxColumn.HeaderText = "Company Cont. Number";
            this.compContactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compContactNumberDataGridViewTextBoxColumn.Name = "compContactNumberDataGridViewTextBoxColumn";
            this.compContactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compAddressDataGridViewTextBoxColumn
            // 
            this.compAddressDataGridViewTextBoxColumn.DataPropertyName = "compAddress";
            this.compAddressDataGridViewTextBoxColumn.HeaderText = "compAddress";
            this.compAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compAddressDataGridViewTextBoxColumn.Name = "compAddressDataGridViewTextBoxColumn";
            this.compAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.compAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // compNameDataGridViewTextBoxColumn
            // 
            this.compNameDataGridViewTextBoxColumn.DataPropertyName = "compName";
            this.compNameDataGridViewTextBoxColumn.HeaderText = "Company Name";
            this.compNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compNameDataGridViewTextBoxColumn.Name = "compNameDataGridViewTextBoxColumn";
            this.compNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venueImagesDataGridViewTextBoxColumn1
            // 
            this.venueImagesDataGridViewTextBoxColumn1.DataPropertyName = "venueImages";
            this.venueImagesDataGridViewTextBoxColumn1.HeaderText = "venueImages";
            this.venueImagesDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.venueImagesDataGridViewTextBoxColumn1.Name = "venueImagesDataGridViewTextBoxColumn1";
            this.venueImagesDataGridViewTextBoxColumn1.ReadOnly = true;
            this.venueImagesDataGridViewTextBoxColumn1.Visible = false;
            // 
            // venueContactNumberDataGridViewTextBoxColumn
            // 
            this.venueContactNumberDataGridViewTextBoxColumn.DataPropertyName = "venueContactNumber";
            this.venueContactNumberDataGridViewTextBoxColumn.HeaderText = "venueContactNumber";
            this.venueContactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueContactNumberDataGridViewTextBoxColumn.Name = "venueContactNumberDataGridViewTextBoxColumn";
            this.venueContactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.venueContactNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // venueEmailDataGridViewTextBoxColumn1
            // 
            this.venueEmailDataGridViewTextBoxColumn1.DataPropertyName = "venueEmail";
            this.venueEmailDataGridViewTextBoxColumn1.HeaderText = "venueEmail";
            this.venueEmailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.venueEmailDataGridViewTextBoxColumn1.Name = "venueEmailDataGridViewTextBoxColumn1";
            this.venueEmailDataGridViewTextBoxColumn1.ReadOnly = true;
            this.venueEmailDataGridViewTextBoxColumn1.Visible = false;
            // 
            // venueAddressDataGridViewTextBoxColumn1
            // 
            this.venueAddressDataGridViewTextBoxColumn1.DataPropertyName = "venueAddress";
            this.venueAddressDataGridViewTextBoxColumn1.HeaderText = "venueAddress";
            this.venueAddressDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.venueAddressDataGridViewTextBoxColumn1.Name = "venueAddressDataGridViewTextBoxColumn1";
            this.venueAddressDataGridViewTextBoxColumn1.ReadOnly = true;
            this.venueAddressDataGridViewTextBoxColumn1.Visible = false;
            // 
            // venueDescriptionDataGridViewTextBoxColumn1
            // 
            this.venueDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "venueDescription";
            this.venueDescriptionDataGridViewTextBoxColumn1.HeaderText = "venueDescription";
            this.venueDescriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.venueDescriptionDataGridViewTextBoxColumn1.Name = "venueDescriptionDataGridViewTextBoxColumn1";
            this.venueDescriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.venueDescriptionDataGridViewTextBoxColumn1.Visible = false;
            // 
            // venueDisplayNameDataGridViewTextBoxColumn1
            // 
            this.venueDisplayNameDataGridViewTextBoxColumn1.DataPropertyName = "venueDisplayName";
            this.venueDisplayNameDataGridViewTextBoxColumn1.HeaderText = "Venue Name";
            this.venueDisplayNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.venueDisplayNameDataGridViewTextBoxColumn1.Name = "venueDisplayNameDataGridViewTextBoxColumn1";
            this.venueDisplayNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // venueNameDataGridViewTextBoxColumn1
            // 
            this.venueNameDataGridViewTextBoxColumn1.DataPropertyName = "venueName";
            this.venueNameDataGridViewTextBoxColumn1.HeaderText = "venueName";
            this.venueNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.venueNameDataGridViewTextBoxColumn1.Name = "venueNameDataGridViewTextBoxColumn1";
            this.venueNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.venueNameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // venueId
            // 
            this.venueId.DataPropertyName = "venueId";
            this.venueId.HeaderText = "Venue ID";
            this.venueId.MinimumWidth = 6;
            this.venueId.Name = "venueId";
            this.venueId.ReadOnly = true;
            // 
            // venueTableAdapter
            // 
            this.venueTableAdapter.ClearBeforeFill = true;
            // 
            // emsDataSet10
            // 
            this.emsDataSet10.DataSetName = "emsDataSet10";
            this.emsDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // venueBindingSource
            // 
            this.venueBindingSource.DataMember = "venue";
            this.venueBindingSource.DataSource = this.emsDataSet10;
            // 
            // venueImagesDataGridViewTextBoxColumn
            // 
            this.venueImagesDataGridViewTextBoxColumn.DataPropertyName = "venueImages";
            this.venueImagesDataGridViewTextBoxColumn.HeaderText = "venueImages";
            this.venueImagesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueImagesDataGridViewTextBoxColumn.Name = "venueImagesDataGridViewTextBoxColumn";
            this.venueImagesDataGridViewTextBoxColumn.ReadOnly = true;
            this.venueImagesDataGridViewTextBoxColumn.Visible = false;
            // 
            // venueMobileNumberDataGridViewTextBoxColumn
            // 
            this.venueMobileNumberDataGridViewTextBoxColumn.DataPropertyName = "venueMobileNumber";
            this.venueMobileNumberDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.venueMobileNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueMobileNumberDataGridViewTextBoxColumn.Name = "venueMobileNumberDataGridViewTextBoxColumn";
            this.venueMobileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venueEmailDataGridViewTextBoxColumn
            // 
            this.venueEmailDataGridViewTextBoxColumn.DataPropertyName = "venueEmail";
            this.venueEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.venueEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueEmailDataGridViewTextBoxColumn.Name = "venueEmailDataGridViewTextBoxColumn";
            this.venueEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venueAddressDataGridViewTextBoxColumn
            // 
            this.venueAddressDataGridViewTextBoxColumn.DataPropertyName = "venueAddress";
            this.venueAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.venueAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueAddressDataGridViewTextBoxColumn.Name = "venueAddressDataGridViewTextBoxColumn";
            this.venueAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venueDescriptionDataGridViewTextBoxColumn
            // 
            this.venueDescriptionDataGridViewTextBoxColumn.DataPropertyName = "venueDescription";
            this.venueDescriptionDataGridViewTextBoxColumn.HeaderText = "venueDescription";
            this.venueDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueDescriptionDataGridViewTextBoxColumn.Name = "venueDescriptionDataGridViewTextBoxColumn";
            this.venueDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.venueDescriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // venueDisplayNameDataGridViewTextBoxColumn
            // 
            this.venueDisplayNameDataGridViewTextBoxColumn.DataPropertyName = "venueDisplayName";
            this.venueDisplayNameDataGridViewTextBoxColumn.HeaderText = "Venue Name";
            this.venueDisplayNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueDisplayNameDataGridViewTextBoxColumn.Name = "venueDisplayNameDataGridViewTextBoxColumn";
            this.venueDisplayNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venueNameDataGridViewTextBoxColumn
            // 
            this.venueNameDataGridViewTextBoxColumn.DataPropertyName = "venueName";
            this.venueNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.venueNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueNameDataGridViewTextBoxColumn.Name = "venueNameDataGridViewTextBoxColumn";
            this.venueNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.venueNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // venueIdDataGridViewTextBoxColumn
            // 
            this.venueIdDataGridViewTextBoxColumn.DataPropertyName = "venueId";
            this.venueIdDataGridViewTextBoxColumn.HeaderText = "venueId";
            this.venueIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueIdDataGridViewTextBoxColumn.Name = "venueIdDataGridViewTextBoxColumn";
            this.venueIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.venueIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // venueRequestsGrid
            // 
            this.venueRequestsGrid.AllowUserToAddRows = false;
            this.venueRequestsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.venueRequestsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.venueRequestsGrid.AutoGenerateColumns = false;
            this.venueRequestsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.venueRequestsGrid.BackgroundColor = System.Drawing.Color.White;
            this.venueRequestsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.venueRequestsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.venueRequestsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.venueRequestsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.venueRequestsGrid.ColumnHeadersHeight = 27;
            this.venueRequestsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.venueId,
            this.venueNameDataGridViewTextBoxColumn1,
            this.venueDisplayNameDataGridViewTextBoxColumn1,
            this.venueDescriptionDataGridViewTextBoxColumn1,
            this.venueAddressDataGridViewTextBoxColumn1,
            this.venueEmailDataGridViewTextBoxColumn1,
            this.venueContactNumberDataGridViewTextBoxColumn,
            this.venueImagesDataGridViewTextBoxColumn1,
            this.compNameDataGridViewTextBoxColumn,
            this.compAddressDataGridViewTextBoxColumn,
            this.compContactNumberDataGridViewTextBoxColumn,
            this.compBRNDataGridViewTextBoxColumn,
            this.compTINDataGridViewTextBoxColumn});
            this.venueRequestsGrid.DataSource = this.venuependingBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.venueRequestsGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.venueRequestsGrid.EnableHeadersVisualStyles = false;
            this.venueRequestsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.venueRequestsGrid.Location = new System.Drawing.Point(28, 36);
            this.venueRequestsGrid.Name = "venueRequestsGrid";
            this.venueRequestsGrid.ReadOnly = true;
            this.venueRequestsGrid.RowHeadersVisible = false;
            this.venueRequestsGrid.RowHeadersWidth = 51;
            this.venueRequestsGrid.RowTemplate.Height = 50;
            this.venueRequestsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.venueRequestsGrid.Size = new System.Drawing.Size(1118, 460);
            this.venueRequestsGrid.TabIndex = 12;
            this.venueRequestsGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.venueRequestsGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.venueRequestsGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.venueRequestsGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.venueRequestsGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.venueRequestsGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.venueRequestsGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.venueRequestsGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.venueRequestsGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.venueRequestsGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.venueRequestsGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.venueRequestsGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.venueRequestsGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.venueRequestsGrid.ThemeStyle.HeaderStyle.Height = 27;
            this.venueRequestsGrid.ThemeStyle.ReadOnly = true;
            this.venueRequestsGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.venueRequestsGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.venueRequestsGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.venueRequestsGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.venueRequestsGrid.ThemeStyle.RowsStyle.Height = 50;
            this.venueRequestsGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.venueRequestsGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // venueDataGrid
            // 
            this.venueDataGrid.AllowUserToAddRows = false;
            this.venueDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.venueDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.venueDataGrid.AutoGenerateColumns = false;
            this.venueDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.venueDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.venueDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.venueDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.venueDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.venueDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.venueDataGrid.ColumnHeadersHeight = 27;
            this.venueDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.venueIdDataGridViewTextBoxColumn,
            this.venueNameDataGridViewTextBoxColumn,
            this.venueDisplayNameDataGridViewTextBoxColumn,
            this.venueDescriptionDataGridViewTextBoxColumn,
            this.venueAddressDataGridViewTextBoxColumn,
            this.venueEmailDataGridViewTextBoxColumn,
            this.venueMobileNumberDataGridViewTextBoxColumn,
            this.venueImagesDataGridViewTextBoxColumn});
            this.venueDataGrid.DataSource = this.venueBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.venueDataGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.venueDataGrid.EnableHeadersVisualStyles = false;
            this.venueDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.venueDataGrid.Location = new System.Drawing.Point(28, 56);
            this.venueDataGrid.Name = "venueDataGrid";
            this.venueDataGrid.ReadOnly = true;
            this.venueDataGrid.RowHeadersVisible = false;
            this.venueDataGrid.RowHeadersWidth = 51;
            this.venueDataGrid.RowTemplate.Height = 50;
            this.venueDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.venueDataGrid.Size = new System.Drawing.Size(1118, 440);
            this.venueDataGrid.TabIndex = 9;
            this.venueDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.venueDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.venueDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.venueDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.venueDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.venueDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.venueDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.venueDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.venueDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.venueDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.venueDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.venueDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.venueDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.venueDataGrid.ThemeStyle.HeaderStyle.Height = 27;
            this.venueDataGrid.ThemeStyle.ReadOnly = true;
            this.venueDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.venueDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.venueDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.venueDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.venueDataGrid.ThemeStyle.RowsStyle.Height = 50;
            this.venueDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.venueDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ViewVenue_organizer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.venueRequestsGrid);
            this.Controls.Add(this.venueDataGrid);
            this.Name = "ViewVenue_organizer";
            this.Size = new System.Drawing.Size(1174, 523);
            this.Load += new System.EventHandler(this.ViewVenue_organizer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.venuependingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueRequestsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private emsDataSet13TableAdapters.venue_pendingTableAdapter venue_pendingTableAdapter;
        private System.Windows.Forms.BindingSource venuependingBindingSource;
        private emsDataSet13 emsDataSet13;
        private System.Windows.Forms.DataGridViewTextBoxColumn compTINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compBRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compContactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueImagesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueContactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueEmailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueAddressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDisplayNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueId;
        private emsDataSet10TableAdapters.venueTableAdapter venueTableAdapter;
        private emsDataSet10 emsDataSet10;
        private System.Windows.Forms.BindingSource venueBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueImagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueMobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDisplayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueIdDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2DataGridView venueRequestsGrid;
        private Guna.UI2.WinForms.Guna2DataGridView venueDataGrid;
    }
}
