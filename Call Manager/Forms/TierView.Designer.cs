namespace Call_Manager
{
    partial class TierView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitTableView = new System.Windows.Forms.SplitContainer();
            this.dataGridViewUnassigned = new System.Windows.Forms.DataGridView();
            this.callBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._3CXSupportDBaseDataSet1 = new Call_Manager._3CXSupportDBaseDataSet1();
            this.labelMyTickets = new System.Windows.Forms.Label();
            this.dataGridViewMine = new System.Windows.Forms.DataGridView();
            this.callBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.callsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.callsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.callManagerDataSet = new Call_Manager.CallManagerDataSet();
            this.callManagerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.callsTableAdapter = new Call_Manager._3CXSupportDBaseDataSetTableAdapters.CallsTableAdapter();
            this._3CXSupportDBaseDataSet = new Call_Manager._3CXSupportDBaseDataSet();
            this.callsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.callTableAdapter = new Call_Manager._3CXSupportDBaseDataSet1TableAdapters.CallTableAdapter();
            this.cXSupportDBaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gUIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitTableView)).BeginInit();
            this.splitTableView.Panel1.SuspendLayout();
            this.splitTableView.Panel2.SuspendLayout();
            this.splitTableView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnassigned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._3CXSupportDBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callManagerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._3CXSupportDBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cXSupportDBaseDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitTableView
            // 
            this.splitTableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTableView.Location = new System.Drawing.Point(0, 0);
            this.splitTableView.Name = "splitTableView";
            this.splitTableView.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitTableView.Panel1
            // 
            this.splitTableView.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitTableView.Panel1.Controls.Add(this.dataGridViewUnassigned);
            this.splitTableView.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitTableView.Panel2
            // 
            this.splitTableView.Panel2.BackColor = System.Drawing.Color.LightCyan;
            this.splitTableView.Panel2.Controls.Add(this.labelMyTickets);
            this.splitTableView.Panel2.Controls.Add(this.dataGridViewMine);
            this.splitTableView.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitTableView.Size = new System.Drawing.Size(1055, 521);
            this.splitTableView.SplitterDistance = 188;
            this.splitTableView.TabIndex = 0;
            // 
            // dataGridViewUnassigned
            // 
            this.dataGridViewUnassigned.AllowUserToAddRows = false;
            this.dataGridViewUnassigned.AllowUserToDeleteRows = false;
            this.dataGridViewUnassigned.AutoGenerateColumns = false;
            this.dataGridViewUnassigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnassigned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gUIDDataGridViewTextBoxColumn,
            this.timeDataGridViewImageColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.sIMDataGridViewTextBoxColumn,
            this.ticketDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.engineerDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn});
            this.dataGridViewUnassigned.DataSource = this.callBindingSource;
            this.dataGridViewUnassigned.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewUnassigned.Name = "dataGridViewUnassigned";
            this.dataGridViewUnassigned.ReadOnly = true;
            this.dataGridViewUnassigned.ShowEditingIcon = false;
            this.dataGridViewUnassigned.Size = new System.Drawing.Size(1049, 182);
            this.dataGridViewUnassigned.TabIndex = 16;
            this.dataGridViewUnassigned.DataSourceChanged += new System.EventHandler(this.dataGridViewUnassigned_DataSourceChanged);
            this.dataGridViewUnassigned.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUnassigned_CellClick);
            // 
            // callBindingSource
            // 
            this.callBindingSource.DataMember = "Call";
            this.callBindingSource.DataSource = this._3CXSupportDBaseDataSet1;
            // 
            // _3CXSupportDBaseDataSet1
            // 
            this._3CXSupportDBaseDataSet1.DataSetName = "_3CXSupportDBaseDataSet1";
            this._3CXSupportDBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelMyTickets
            // 
            this.labelMyTickets.AutoSize = true;
            this.labelMyTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyTickets.Location = new System.Drawing.Point(12, 1);
            this.labelMyTickets.Name = "labelMyTickets";
            this.labelMyTickets.Size = new System.Drawing.Size(109, 24);
            this.labelMyTickets.TabIndex = 1;
            this.labelMyTickets.Text = "My Tickets";
            // 
            // dataGridViewMine
            // 
            this.dataGridViewMine.AllowUserToAddRows = false;
            this.dataGridViewMine.AllowUserToDeleteRows = false;
            this.dataGridViewMine.AutoGenerateColumns = false;
            this.dataGridViewMine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gUIDDataGridViewTextBoxColumn1,
            this.timeDataGridViewImageColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.customerDataGridViewTextBoxColumn1,
            this.companyDataGridViewTextBoxColumn1,
            this.sIMDataGridViewTextBoxColumn1,
            this.ticketDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.engineerDataGridViewTextBoxColumn1,
            this.operatorDataGridViewTextBoxColumn1});
            this.dataGridViewMine.DataSource = this.callBindingSource1;
            this.dataGridViewMine.Location = new System.Drawing.Point(3, 27);
            this.dataGridViewMine.Name = "dataGridViewMine";
            this.dataGridViewMine.ReadOnly = true;
            this.dataGridViewMine.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewMine.ShowEditingIcon = false;
            this.dataGridViewMine.Size = new System.Drawing.Size(1049, 299);
            this.dataGridViewMine.TabIndex = 0;
            // 
            // callBindingSource1
            // 
            this.callBindingSource1.DataMember = "Call";
            this.callBindingSource1.DataSource = this._3CXSupportDBaseDataSet1;
            // 
            // callsBindingSource
            // 
            this.callsBindingSource.DataSource = this._3CXSupportDBaseDataSet1;
            this.callsBindingSource.Position = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // callManagerDataSet
            // 
            this.callManagerDataSet.DataSetName = "CallManagerDataSet";
            this.callManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // callManagerDataSetBindingSource
            // 
            this.callManagerDataSetBindingSource.DataSource = this.callManagerDataSet;
            this.callManagerDataSetBindingSource.Position = 0;
            // 
            // callsTableAdapter
            // 
            this.callsTableAdapter.ClearBeforeFill = true;
            // 
            // _3CXSupportDBaseDataSet
            // 
            this._3CXSupportDBaseDataSet.DataSetName = "_3CXSupportDBaseDataSet";
            this._3CXSupportDBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // callsBindingSource2
            // 
            this.callsBindingSource2.DataMember = "Calls";
            this.callsBindingSource2.DataSource = this._3CXSupportDBaseDataSet;
            // 
            // callTableAdapter
            // 
            this.callTableAdapter.ClearBeforeFill = true;
            // 
            // cXSupportDBaseDataSet1BindingSource
            // 
            this.cXSupportDBaseDataSet1BindingSource.DataSource = this._3CXSupportDBaseDataSet1;
            this.cXSupportDBaseDataSet1BindingSource.Position = 0;
            // 
            // gUIDDataGridViewTextBoxColumn1
            // 
            this.gUIDDataGridViewTextBoxColumn1.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.Name = "gUIDDataGridViewTextBoxColumn1";
            this.gUIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // timeDataGridViewImageColumn1
            // 
            this.timeDataGridViewImageColumn1.DataPropertyName = "Time";
            this.timeDataGridViewImageColumn1.HeaderText = "Time";
            this.timeDataGridViewImageColumn1.Name = "timeDataGridViewImageColumn1";
            this.timeDataGridViewImageColumn1.ReadOnly = true;
            this.timeDataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.timeDataGridViewImageColumn1.Visible = false;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            this.phoneDataGridViewTextBoxColumn1.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn1.Width = 40;
            // 
            // customerDataGridViewTextBoxColumn1
            // 
            this.customerDataGridViewTextBoxColumn1.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn1.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn1.Name = "customerDataGridViewTextBoxColumn1";
            this.customerDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn1
            // 
            this.companyDataGridViewTextBoxColumn1.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn1.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn1.Name = "companyDataGridViewTextBoxColumn1";
            this.companyDataGridViewTextBoxColumn1.ReadOnly = true;
            this.companyDataGridViewTextBoxColumn1.Width = 150;
            // 
            // sIMDataGridViewTextBoxColumn1
            // 
            this.sIMDataGridViewTextBoxColumn1.DataPropertyName = "SIM";
            this.sIMDataGridViewTextBoxColumn1.HeaderText = "SIM";
            this.sIMDataGridViewTextBoxColumn1.Name = "sIMDataGridViewTextBoxColumn1";
            this.sIMDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sIMDataGridViewTextBoxColumn1.Width = 50;
            // 
            // ticketDataGridViewTextBoxColumn1
            // 
            this.ticketDataGridViewTextBoxColumn1.DataPropertyName = "Ticket";
            this.ticketDataGridViewTextBoxColumn1.HeaderText = "Ticket";
            this.ticketDataGridViewTextBoxColumn1.Name = "ticketDataGridViewTextBoxColumn1";
            this.ticketDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ticketDataGridViewTextBoxColumn1.Width = 50;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn1.Width = 415;
            // 
            // engineerDataGridViewTextBoxColumn1
            // 
            this.engineerDataGridViewTextBoxColumn1.DataPropertyName = "Engineer";
            this.engineerDataGridViewTextBoxColumn1.HeaderText = "Engineer";
            this.engineerDataGridViewTextBoxColumn1.Name = "engineerDataGridViewTextBoxColumn1";
            this.engineerDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // operatorDataGridViewTextBoxColumn1
            // 
            this.operatorDataGridViewTextBoxColumn1.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn1.HeaderText = "Operator";
            this.operatorDataGridViewTextBoxColumn1.Name = "operatorDataGridViewTextBoxColumn1";
            this.operatorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // timeDataGridViewImageColumn
            // 
            this.timeDataGridViewImageColumn.DataPropertyName = "Time";
            this.timeDataGridViewImageColumn.HeaderText = "Time";
            this.timeDataGridViewImageColumn.Name = "timeDataGridViewImageColumn";
            this.timeDataGridViewImageColumn.ReadOnly = true;
            this.timeDataGridViewImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.timeDataGridViewImageColumn.Visible = false;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 40;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyDataGridViewTextBoxColumn.Width = 150;
            // 
            // sIMDataGridViewTextBoxColumn
            // 
            this.sIMDataGridViewTextBoxColumn.DataPropertyName = "SIM";
            this.sIMDataGridViewTextBoxColumn.HeaderText = "SIM";
            this.sIMDataGridViewTextBoxColumn.Name = "sIMDataGridViewTextBoxColumn";
            this.sIMDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIMDataGridViewTextBoxColumn.Width = 50;
            // 
            // ticketDataGridViewTextBoxColumn
            // 
            this.ticketDataGridViewTextBoxColumn.DataPropertyName = "Ticket";
            this.ticketDataGridViewTextBoxColumn.HeaderText = "Ticket";
            this.ticketDataGridViewTextBoxColumn.Name = "ticketDataGridViewTextBoxColumn";
            this.ticketDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketDataGridViewTextBoxColumn.Width = 50;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 415;
            // 
            // engineerDataGridViewTextBoxColumn
            // 
            this.engineerDataGridViewTextBoxColumn.DataPropertyName = "Engineer";
            this.engineerDataGridViewTextBoxColumn.HeaderText = "Engineer";
            this.engineerDataGridViewTextBoxColumn.Name = "engineerDataGridViewTextBoxColumn";
            this.engineerDataGridViewTextBoxColumn.ReadOnly = true;
            this.engineerDataGridViewTextBoxColumn.Visible = false;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "Operator";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1055, 521);
            this.ControlBox = false;
            this.Controls.Add(this.splitTableView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TierView";
            this.Text = "Tier View";
            this.Load += new System.EventHandler(this.TierView_Load);
            this.splitTableView.Panel1.ResumeLayout(false);
            this.splitTableView.Panel2.ResumeLayout(false);
            this.splitTableView.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTableView)).EndInit();
            this.splitTableView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnassigned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._3CXSupportDBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callManagerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._3CXSupportDBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cXSupportDBaseDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitTableView;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource callManagerDataSetBindingSource;
        private CallManagerDataSet callManagerDataSet;
        private System.Windows.Forms.BindingSource callsBindingSource;
        private _3CXSupportDBaseDataSetTableAdapters.CallsTableAdapter callsTableAdapter;
        private System.Windows.Forms.Label labelMyTickets;
        private System.Windows.Forms.DataGridView dataGridViewMine;
        private System.Windows.Forms.BindingSource callsBindingSource1;
        private System.Windows.Forms.BindingSource callsBindingSource2;
        private _3CXSupportDBaseDataSet _3CXSupportDBaseDataSet;
        private System.Windows.Forms.DataGridView dataGridViewUnassigned;
        private _3CXSupportDBaseDataSet1 _3CXSupportDBaseDataSet1;
        private System.Windows.Forms.BindingSource callBindingSource;
        private _3CXSupportDBaseDataSet1TableAdapters.CallTableAdapter callTableAdapter;
        private System.Windows.Forms.BindingSource callBindingSource1;
        private System.Windows.Forms.BindingSource cXSupportDBaseDataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn timeDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn timeDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
    }
}