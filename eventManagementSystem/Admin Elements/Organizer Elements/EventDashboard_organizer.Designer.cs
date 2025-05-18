namespace eventManagementSystem.Class
{
    partial class EventDashboard_organizer
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
            this.eventTableAdapter = new eventManagementSystem.emsDataSet1TableAdapters.eventTableAdapter();
            this.emsDataSet1 = new eventManagementSystem.emsDataSet1();
            this.eIsActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eMaxBudgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eBudgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTicketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTicketCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMaxCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNeedLocationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eNeedParticipationConfirmationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eNeedTicketingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eIsPublicDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDisplayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventDataView = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // emsDataSet1
            // 
            this.emsDataSet1.DataSetName = "emsDataSet1";
            this.emsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eIsActiveDataGridViewCheckBoxColumn
            // 
            this.eIsActiveDataGridViewCheckBoxColumn.DataPropertyName = "eIsActive";
            this.eIsActiveDataGridViewCheckBoxColumn.HeaderText = "Event Status";
            this.eIsActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.eIsActiveDataGridViewCheckBoxColumn.Name = "eIsActiveDataGridViewCheckBoxColumn";
            this.eIsActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // eMaxBudgetDataGridViewTextBoxColumn
            // 
            this.eMaxBudgetDataGridViewTextBoxColumn.DataPropertyName = "eMaxBudget";
            this.eMaxBudgetDataGridViewTextBoxColumn.HeaderText = "eMaxBudget";
            this.eMaxBudgetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMaxBudgetDataGridViewTextBoxColumn.Name = "eMaxBudgetDataGridViewTextBoxColumn";
            this.eMaxBudgetDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMaxBudgetDataGridViewTextBoxColumn.Visible = false;
            // 
            // eBudgetDataGridViewTextBoxColumn
            // 
            this.eBudgetDataGridViewTextBoxColumn.DataPropertyName = "eBudget";
            this.eBudgetDataGridViewTextBoxColumn.HeaderText = "Budget";
            this.eBudgetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eBudgetDataGridViewTextBoxColumn.Name = "eBudgetDataGridViewTextBoxColumn";
            this.eBudgetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eTicketPriceDataGridViewTextBoxColumn
            // 
            this.eTicketPriceDataGridViewTextBoxColumn.DataPropertyName = "eTicketPrice";
            this.eTicketPriceDataGridViewTextBoxColumn.HeaderText = "eTicketPrice";
            this.eTicketPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eTicketPriceDataGridViewTextBoxColumn.Name = "eTicketPriceDataGridViewTextBoxColumn";
            this.eTicketPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.eTicketPriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // eTicketCountDataGridViewTextBoxColumn
            // 
            this.eTicketCountDataGridViewTextBoxColumn.DataPropertyName = "eTicketCount";
            this.eTicketCountDataGridViewTextBoxColumn.HeaderText = "eTicketCount";
            this.eTicketCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eTicketCountDataGridViewTextBoxColumn.Name = "eTicketCountDataGridViewTextBoxColumn";
            this.eTicketCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.eTicketCountDataGridViewTextBoxColumn.Visible = false;
            // 
            // eMaxCapacityDataGridViewTextBoxColumn
            // 
            this.eMaxCapacityDataGridViewTextBoxColumn.DataPropertyName = "eMaxCapacity";
            this.eMaxCapacityDataGridViewTextBoxColumn.HeaderText = "eMaxCapacity";
            this.eMaxCapacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMaxCapacityDataGridViewTextBoxColumn.Name = "eMaxCapacityDataGridViewTextBoxColumn";
            this.eMaxCapacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMaxCapacityDataGridViewTextBoxColumn.Visible = false;
            // 
            // eCapacityDataGridViewTextBoxColumn
            // 
            this.eCapacityDataGridViewTextBoxColumn.DataPropertyName = "eCapacity";
            this.eCapacityDataGridViewTextBoxColumn.HeaderText = "Guest Count";
            this.eCapacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eCapacityDataGridViewTextBoxColumn.Name = "eCapacityDataGridViewTextBoxColumn";
            this.eCapacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNeedLocationDataGridViewCheckBoxColumn
            // 
            this.eNeedLocationDataGridViewCheckBoxColumn.DataPropertyName = "eNeedLocation";
            this.eNeedLocationDataGridViewCheckBoxColumn.HeaderText = "eNeedLocation";
            this.eNeedLocationDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.eNeedLocationDataGridViewCheckBoxColumn.Name = "eNeedLocationDataGridViewCheckBoxColumn";
            this.eNeedLocationDataGridViewCheckBoxColumn.ReadOnly = true;
            this.eNeedLocationDataGridViewCheckBoxColumn.Visible = false;
            // 
            // eNeedParticipationConfirmationDataGridViewCheckBoxColumn
            // 
            this.eNeedParticipationConfirmationDataGridViewCheckBoxColumn.DataPropertyName = "eNeedParticipationConfirmation";
            this.eNeedParticipationConfirmationDataGridViewCheckBoxColumn.HeaderText = "eNeedParticipationConfirmation";
            this.eNeedParticipationConfirmationDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.eNeedParticipationConfirmationDataGridViewCheckBoxColumn.Name = "eNeedParticipationConfirmationDataGridViewCheckBoxColumn";
            this.eNeedParticipationConfirmationDataGridViewCheckBoxColumn.ReadOnly = true;
            this.eNeedParticipationConfirmationDataGridViewCheckBoxColumn.Visible = false;
            // 
            // eNeedTicketingDataGridViewCheckBoxColumn
            // 
            this.eNeedTicketingDataGridViewCheckBoxColumn.DataPropertyName = "eNeedTicketing";
            this.eNeedTicketingDataGridViewCheckBoxColumn.HeaderText = "eNeedTicketing";
            this.eNeedTicketingDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.eNeedTicketingDataGridViewCheckBoxColumn.Name = "eNeedTicketingDataGridViewCheckBoxColumn";
            this.eNeedTicketingDataGridViewCheckBoxColumn.ReadOnly = true;
            this.eNeedTicketingDataGridViewCheckBoxColumn.Visible = false;
            // 
            // eIsPublicDataGridViewCheckBoxColumn
            // 
            this.eIsPublicDataGridViewCheckBoxColumn.DataPropertyName = "eIsPublic";
            this.eIsPublicDataGridViewCheckBoxColumn.HeaderText = "Public Event";
            this.eIsPublicDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.eIsPublicDataGridViewCheckBoxColumn.Name = "eIsPublicDataGridViewCheckBoxColumn";
            this.eIsPublicDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // eEndTimeDataGridViewTextBoxColumn
            // 
            this.eEndTimeDataGridViewTextBoxColumn.DataPropertyName = "eEndTime";
            this.eEndTimeDataGridViewTextBoxColumn.HeaderText = "End Time";
            this.eEndTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eEndTimeDataGridViewTextBoxColumn.Name = "eEndTimeDataGridViewTextBoxColumn";
            this.eEndTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eStartTimeDataGridViewTextBoxColumn
            // 
            this.eStartTimeDataGridViewTextBoxColumn.DataPropertyName = "eStartTime";
            this.eStartTimeDataGridViewTextBoxColumn.HeaderText = "Start Time";
            this.eStartTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eStartTimeDataGridViewTextBoxColumn.Name = "eStartTimeDataGridViewTextBoxColumn";
            this.eStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eDateDataGridViewTextBoxColumn
            // 
            this.eDateDataGridViewTextBoxColumn.DataPropertyName = "eDate";
            this.eDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.eDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eDateDataGridViewTextBoxColumn.Name = "eDateDataGridViewTextBoxColumn";
            this.eDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eTypeDataGridViewTextBoxColumn
            // 
            this.eTypeDataGridViewTextBoxColumn.DataPropertyName = "eType";
            this.eTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.eTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eTypeDataGridViewTextBoxColumn.Name = "eTypeDataGridViewTextBoxColumn";
            this.eTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eDisplayNameDataGridViewTextBoxColumn
            // 
            this.eDisplayNameDataGridViewTextBoxColumn.DataPropertyName = "eDisplayName";
            this.eDisplayNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.eDisplayNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eDisplayNameDataGridViewTextBoxColumn.Name = "eDisplayNameDataGridViewTextBoxColumn";
            this.eDisplayNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNameDataGridViewTextBoxColumn
            // 
            this.eNameDataGridViewTextBoxColumn.DataPropertyName = "eName";
            this.eNameDataGridViewTextBoxColumn.HeaderText = "eName";
            this.eNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eNameDataGridViewTextBoxColumn.Name = "eNameDataGridViewTextBoxColumn";
            this.eNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // eId
            // 
            this.eId.DataPropertyName = "eId";
            this.eId.HeaderText = "Event ID";
            this.eId.MinimumWidth = 6;
            this.eId.Name = "eId";
            this.eId.ReadOnly = true;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "event";
            // 
            // eventDataView
            // 
            this.eventDataView.AllowUserToAddRows = false;
            this.eventDataView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.eventDataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.eventDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eventDataView.BackgroundColor = System.Drawing.Color.White;
            this.eventDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.eventDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.eventDataView.ColumnHeadersHeight = 27;
            this.eventDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eId,
            this.eNameDataGridViewTextBoxColumn,
            this.eDisplayNameDataGridViewTextBoxColumn,
            this.eTypeDataGridViewTextBoxColumn,
            this.eDateDataGridViewTextBoxColumn,
            this.eStartTimeDataGridViewTextBoxColumn,
            this.eEndTimeDataGridViewTextBoxColumn,
            this.eIsPublicDataGridViewCheckBoxColumn,
            this.eNeedTicketingDataGridViewCheckBoxColumn,
            this.eNeedParticipationConfirmationDataGridViewCheckBoxColumn,
            this.eNeedLocationDataGridViewCheckBoxColumn,
            this.eCapacityDataGridViewTextBoxColumn,
            this.eMaxCapacityDataGridViewTextBoxColumn,
            this.eTicketCountDataGridViewTextBoxColumn,
            this.eTicketPriceDataGridViewTextBoxColumn,
            this.eBudgetDataGridViewTextBoxColumn,
            this.eMaxBudgetDataGridViewTextBoxColumn,
            this.eIsActiveDataGridViewCheckBoxColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.eventDataView.DefaultCellStyle = dataGridViewCellStyle3;
            this.eventDataView.EnableHeadersVisualStyles = false;
            this.eventDataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.eventDataView.Location = new System.Drawing.Point(23, 22);
            this.eventDataView.Name = "eventDataView";
            this.eventDataView.ReadOnly = true;
            this.eventDataView.RowHeadersVisible = false;
            this.eventDataView.RowHeadersWidth = 51;
            this.eventDataView.RowTemplate.Height = 40;
            this.eventDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventDataView.Size = new System.Drawing.Size(1128, 452);
            this.eventDataView.TabIndex = 1;
            this.eventDataView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.eventDataView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.eventDataView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.eventDataView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.eventDataView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.eventDataView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.eventDataView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.eventDataView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.eventDataView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.eventDataView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.eventDataView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.eventDataView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.eventDataView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.eventDataView.ThemeStyle.HeaderStyle.Height = 27;
            this.eventDataView.ThemeStyle.ReadOnly = true;
            this.eventDataView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.eventDataView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.eventDataView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.eventDataView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.eventDataView.ThemeStyle.RowsStyle.Height = 40;
            this.eventDataView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.eventDataView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.eventDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventDataView_CellClick);
            // 
            // EventDashboard_organizer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.eventDataView);
            this.Name = "EventDashboard_organizer";
            this.Size = new System.Drawing.Size(1174, 497);
            this.Load += new System.EventHandler(this.EventDashboard_organizer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private emsDataSet1TableAdapters.eventTableAdapter eventTableAdapter;
        private emsDataSet1 emsDataSet1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eIsActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMaxBudgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBudgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTicketPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTicketCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMaxCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eNeedLocationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eNeedParticipationConfirmationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eNeedTicketingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eIsPublicDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDisplayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eId;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private Guna.UI2.WinForms.Guna2DataGridView eventDataView;
    }
}
