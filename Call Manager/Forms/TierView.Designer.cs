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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TierView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelUser = new System.Windows.Forms.Label();
            this.pictureboxSettings = new System.Windows.Forms.PictureBox();
            this.callsTableAdapter = new Call_Manager._3CXSupportDBaseDataSetTableAdapters.CallsTableAdapter();
            this.callsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._3CXSupportDBaseDataSet = new Call_Manager._3CXSupportDBaseDataSet();
            this.Clock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._3CXSupportDBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 5000;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(508, 10);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(88, 13);
            this.labelUser.TabIndex = 22;
            this.labelUser.Text = "Welcome back, !";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // pictureboxSettings
            // 
            this.pictureboxSettings.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxSettings.Image")));
            this.pictureboxSettings.Location = new System.Drawing.Point(1151, 1);
            this.pictureboxSettings.Name = "pictureboxSettings";
            this.pictureboxSettings.Size = new System.Drawing.Size(23, 22);
            this.pictureboxSettings.TabIndex = 23;
            this.pictureboxSettings.TabStop = false;
            this.pictureboxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // callsTableAdapter
            // 
            this.callsTableAdapter.ClearBeforeFill = true;
            // 
            // callsBindingSource
            // 
            this.callsBindingSource.DataMember = "Calls";
            this.callsBindingSource.DataSource = this._3CXSupportDBaseDataSet;
            // 
            // _3CXSupportDBaseDataSet
            // 
            this._3CXSupportDBaseDataSet.DataSetName = "_3CXSupportDBaseDataSet";
            this._3CXSupportDBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.ForeColor = System.Drawing.Color.White;
            this.Clock.Location = new System.Drawing.Point(962, 1);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(164, 39);
            this.Clock.TabIndex = 5;
            this.Clock.Text = "12:34 PM";
            // 
            // TierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1175, 521);
            this.Controls.Add(this.pictureboxSettings);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TierView";
            this.Text = "Tier View";
            this.Load += new System.EventHandler(this.TierView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._3CXSupportDBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.PictureBox pictureboxSettings;
        private _3CXSupportDBaseDataSetTableAdapters.CallsTableAdapter callsTableAdapter;
        private System.Windows.Forms.BindingSource callsBindingSource;
        private _3CXSupportDBaseDataSet _3CXSupportDBaseDataSet;
        private System.Windows.Forms.Label Clock;
    }
}