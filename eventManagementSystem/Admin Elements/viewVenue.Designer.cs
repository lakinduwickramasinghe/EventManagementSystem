namespace eventManagementSystem
{
    partial class viewVenue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.venueDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.venueIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDisplayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueMobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueImagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emsDataSet10 = new eventManagementSystem.emsDataSet10();
            this.venueTableAdapter = new eventManagementSystem.emsDataSet10TableAdapters.venueTableAdapter();
            this.adminButton = new Guna.UI2.WinForms.Guna2Button();
            this.organizerButton = new Guna.UI2.WinForms.Guna2Button();
            this.venueRequestsGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.venueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDisplayNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueAddressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueEmailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueContactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueImagesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compContactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compBRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compTINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venuependingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emsDataSet13 = new eventManagementSystem.emsDataSet13();
            this.venue_pendingTableAdapter = new eventManagementSystem.emsDataSet13TableAdapters.venue_pendingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.venueDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueRequestsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuependingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // venueDataGrid
            // 
            this.venueDataGrid.AllowUserToAddRows = false;
            this.venueDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.venueDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.venueDataGrid.AutoGenerateColumns = false;
            this.venueDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.venueDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.venueDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.venueDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.venueDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.venueDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.venueDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.venueDataGrid.EnableHeadersVisualStyles = false;
            this.venueDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.venueDataGrid.Location = new System.Drawing.Point(23, 53);
            this.venueDataGrid.Name = "venueDataGrid";
            this.venueDataGrid.ReadOnly = true;
            this.venueDataGrid.RowHeadersVisible = false;
            this.venueDataGrid.RowHeadersWidth = 51;
            this.venueDataGrid.RowTemplate.Height = 50;
            this.venueDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.venueDataGrid.Size = new System.Drawing.Size(1118, 440);
            this.venueDataGrid.TabIndex = 0;
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
            // venueIdDataGridViewTextBoxColumn
            // 
            this.venueIdDataGridViewTextBoxColumn.DataPropertyName = "venueId";
            this.venueIdDataGridViewTextBoxColumn.HeaderText = "venueId";
            this.venueIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueIdDataGridViewTextBoxColumn.Name = "venueIdDataGridViewTextBoxColumn";
            this.venueIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.venueIdDataGridViewTextBoxColumn.Visible = false;
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
            // venueDisplayNameDataGridViewTextBoxColumn
            // 
            this.venueDisplayNameDataGridViewTextBoxColumn.DataPropertyName = "venueDisplayName";
            this.venueDisplayNameDataGridViewTextBoxColumn.HeaderText = "Venue Name";
            this.venueDisplayNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueDisplayNameDataGridViewTextBoxColumn.Name = "venueDisplayNameDataGridViewTextBoxColumn";
            this.venueDisplayNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // venueAddressDataGridViewTextBoxColumn
            // 
            this.venueAddressDataGridViewTextBoxColumn.DataPropertyName = "venueAddress";
            this.venueAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.venueAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueAddressDataGridViewTextBoxColumn.Name = "venueAddressDataGridViewTextBoxColumn";
            this.venueAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venueEmailDataGridViewTextBoxColumn
            // 
            this.venueEmailDataGridViewTextBoxColumn.DataPropertyName = "venueEmail";
            this.venueEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.venueEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueEmailDataGridViewTextBoxColumn.Name = "venueEmailDataGridViewTextBoxColumn";
            this.venueEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venueMobileNumberDataGridViewTextBoxColumn
            // 
            this.venueMobileNumberDataGridViewTextBoxColumn.DataPropertyName = "venueMobileNumber";
            this.venueMobileNumberDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.venueMobileNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueMobileNumberDataGridViewTextBoxColumn.Name = "venueMobileNumberDataGridViewTextBoxColumn";
            this.venueMobileNumberDataGridViewTextBoxColumn.ReadOnly = true;
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
            // venueBindingSource
            // 
            this.venueBindingSource.DataMember = "venue";
            this.venueBindingSource.DataSource = this.emsDataSet10;
            // 
            // emsDataSet10
            // 
            this.emsDataSet10.DataSetName = "emsDataSet10";
            this.emsDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // venueTableAdapter
            // 
            this.venueTableAdapter.ClearBeforeFill = true;
            // 
            // adminButton
            // 
            this.adminButton.BorderRadius = 10;
            this.adminButton.CheckedState.Parent = this.adminButton;
            this.adminButton.CustomImages.Parent = this.adminButton;
            this.adminButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adminButton.ForeColor = System.Drawing.Color.White;
            this.adminButton.HoverState.Parent = this.adminButton;
            this.adminButton.Location = new System.Drawing.Point(36, 23);
            this.adminButton.Name = "adminButton";
            this.adminButton.ShadowDecoration.Parent = this.adminButton;
            this.adminButton.Size = new System.Drawing.Size(176, 42);
            this.adminButton.TabIndex = 4;
            this.adminButton.Text = "Venues";
            this.adminButton.TextOffset = new System.Drawing.Point(0, -4);
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // organizerButton
            // 
            this.organizerButton.BorderRadius = 10;
            this.organizerButton.CheckedState.Parent = this.organizerButton;
            this.organizerButton.CustomImages.Parent = this.organizerButton;
            this.organizerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.organizerButton.ForeColor = System.Drawing.Color.White;
            this.organizerButton.HoverState.Parent = this.organizerButton;
            this.organizerButton.Location = new System.Drawing.Point(218, 23);
            this.organizerButton.Name = "organizerButton";
            this.organizerButton.ShadowDecoration.Parent = this.organizerButton;
            this.organizerButton.Size = new System.Drawing.Size(176, 42);
            this.organizerButton.TabIndex = 5;
            this.organizerButton.Text = "Venue - Requests";
            this.organizerButton.TextOffset = new System.Drawing.Point(0, -4);
            this.organizerButton.Click += new System.EventHandler(this.organizerButton_Click);
            // 
            // venueRequestsGrid
            // 
            this.venueRequestsGrid.AllowUserToAddRows = false;
            this.venueRequestsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.venueRequestsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.venueRequestsGrid.AutoGenerateColumns = false;
            this.venueRequestsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.venueRequestsGrid.BackgroundColor = System.Drawing.Color.White;
            this.venueRequestsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.venueRequestsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.venueRequestsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.venueRequestsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.venueRequestsGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.venueRequestsGrid.EnableHeadersVisualStyles = false;
            this.venueRequestsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.venueRequestsGrid.Location = new System.Drawing.Point(23, 53);
            this.venueRequestsGrid.Name = "venueRequestsGrid";
            this.venueRequestsGrid.ReadOnly = true;
            this.venueRequestsGrid.RowHeadersVisible = false;
            this.venueRequestsGrid.RowHeadersWidth = 51;
            this.venueRequestsGrid.RowTemplate.Height = 50;
            this.venueRequestsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.venueRequestsGrid.Size = new System.Drawing.Size(1118, 440);
            this.venueRequestsGrid.TabIndex = 8;
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
            this.venueRequestsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.venueRequestsGrid_CellContentClick);
            // 
            // venueId
            // 
            this.venueId.DataPropertyName = "venueId";
            this.venueId.HeaderText = "Venue ID";
            this.venueId.MinimumWidth = 6;
            this.venueId.Name = "venueId";
            this.venueId.ReadOnly = true;
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
            // venueDisplayNameDataGridViewTextBoxColumn1
            // 
            this.venueDisplayNameDataGridViewTextBoxColumn1.DataPropertyName = "venueDisplayName";
            this.venueDisplayNameDataGridViewTextBoxColumn1.HeaderText = "Venue Name";
            this.venueDisplayNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.venueDisplayNameDataGridViewTextBoxColumn1.Name = "venueDisplayNameDataGridViewTextBoxColumn1";
            this.venueDisplayNameDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // venueAddressDataGridViewTextBoxColumn1
            // 
            this.venueAddressDataGridViewTextBoxColumn1.DataPropertyName = "venueAddress";
            this.venueAddressDataGridViewTextBoxColumn1.HeaderText = "venueAddress";
            this.venueAddressDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.venueAddressDataGridViewTextBoxColumn1.Name = "venueAddressDataGridViewTextBoxColumn1";
            this.venueAddressDataGridViewTextBoxColumn1.ReadOnly = true;
            this.venueAddressDataGridViewTextBoxColumn1.Visible = false;
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
            // venueContactNumberDataGridViewTextBoxColumn
            // 
            this.venueContactNumberDataGridViewTextBoxColumn.DataPropertyName = "venueContactNumber";
            this.venueContactNumberDataGridViewTextBoxColumn.HeaderText = "venueContactNumber";
            this.venueContactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueContactNumberDataGridViewTextBoxColumn.Name = "venueContactNumberDataGridViewTextBoxColumn";
            this.venueContactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.venueContactNumberDataGridViewTextBoxColumn.Visible = false;
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
            // compNameDataGridViewTextBoxColumn
            // 
            this.compNameDataGridViewTextBoxColumn.DataPropertyName = "compName";
            this.compNameDataGridViewTextBoxColumn.HeaderText = "Company Name";
            this.compNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compNameDataGridViewTextBoxColumn.Name = "compNameDataGridViewTextBoxColumn";
            this.compNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // compContactNumberDataGridViewTextBoxColumn
            // 
            this.compContactNumberDataGridViewTextBoxColumn.DataPropertyName = "compContactNumber";
            this.compContactNumberDataGridViewTextBoxColumn.HeaderText = "Company Cont. Number";
            this.compContactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compContactNumberDataGridViewTextBoxColumn.Name = "compContactNumberDataGridViewTextBoxColumn";
            this.compContactNumberDataGridViewTextBoxColumn.ReadOnly = true;
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
            // compTINDataGridViewTextBoxColumn
            // 
            this.compTINDataGridViewTextBoxColumn.DataPropertyName = "compTIN";
            this.compTINDataGridViewTextBoxColumn.HeaderText = "compTIN";
            this.compTINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compTINDataGridViewTextBoxColumn.Name = "compTINDataGridViewTextBoxColumn";
            this.compTINDataGridViewTextBoxColumn.ReadOnly = true;
            this.compTINDataGridViewTextBoxColumn.Visible = false;
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
            // venue_pendingTableAdapter
            // 
            this.venue_pendingTableAdapter.ClearBeforeFill = true;
            // 
            // viewVenue
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.venueRequestsGrid);
            this.Controls.Add(this.venueDataGrid);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.organizerButton);
            this.Name = "viewVenue";
            this.Size = new System.Drawing.Size(1174, 523);
            this.Load += new System.EventHandler(this.viewVenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.venueDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueRequestsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuependingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView venueDataGrid;
        private System.Windows.Forms.BindingSource venueBindingSource;
        private emsDataSet10 emsDataSet10;
        private emsDataSet10TableAdapters.venueTableAdapter venueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDisplayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueMobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueImagesDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button adminButton;
        private Guna.UI2.WinForms.Guna2Button organizerButton;
        private Guna.UI2.WinForms.Guna2DataGridView venueRequestsGrid;
        private System.Windows.Forms.BindingSource venuependingBindingSource;
        private emsDataSet13 emsDataSet13;
        private emsDataSet13TableAdapters.venue_pendingTableAdapter venue_pendingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueId;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDisplayNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueAddressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueEmailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueContactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueImagesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn compNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compContactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compBRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compTINDataGridViewTextBoxColumn;
    }
}
