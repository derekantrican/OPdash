namespace Call_Manager.Forms
{
    partial class Config
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabelBugReport = new System.Windows.Forms.LinkLabel();
            this.labelBugReport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSqlConnection = new System.Windows.Forms.Button();
            this.labelSqlConnection = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonConfigSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(12, 159);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(221, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Automatically Check for Updates";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabelBugReport
            // 
            this.linkLabelBugReport.AutoSize = true;
            this.linkLabelBugReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBugReport.Location = new System.Drawing.Point(329, 128);
            this.linkLabelBugReport.Name = "linkLabelBugReport";
            this.linkLabelBugReport.Size = new System.Drawing.Size(55, 20);
            this.linkLabelBugReport.TabIndex = 1;
            this.linkLabelBugReport.TabStop = true;
            this.linkLabelBugReport.Text = "HERE";
            this.linkLabelBugReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBugReport_LinkClicked);
            // 
            // labelBugReport
            // 
            this.labelBugReport.AutoSize = true;
            this.labelBugReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBugReport.Location = new System.Drawing.Point(8, 128);
            this.labelBugReport.Name = "labelBugReport";
            this.labelBugReport.Size = new System.Drawing.Size(324, 20);
            this.labelBugReport.TabIndex = 2;
            this.labelBugReport.Text = "Please submit all questions and bug reports: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(242, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "2016 - Seattle Technical Support WEST";
            // 
            // buttonSqlConnection
            // 
            this.buttonSqlConnection.Location = new System.Drawing.Point(16, 38);
            this.buttonSqlConnection.Name = "buttonSqlConnection";
            this.buttonSqlConnection.Size = new System.Drawing.Size(68, 36);
            this.buttonSqlConnection.TabIndex = 4;
            this.buttonSqlConnection.Text = "Connect";
            this.buttonSqlConnection.UseVisualStyleBackColor = true;
            this.buttonSqlConnection.Click += new System.EventHandler(this.buttonSqlConnection_Click);
            // 
            // labelSqlConnection
            // 
            this.labelSqlConnection.AutoSize = true;
            this.labelSqlConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSqlConnection.Location = new System.Drawing.Point(104, 48);
            this.labelSqlConnection.Name = "labelSqlConnection";
            this.labelSqlConnection.Size = new System.Drawing.Size(110, 16);
            this.labelSqlConnection.TabIndex = 5;
            this.labelSqlConnection.Text = "SQL DATABASE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Database Connection";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 34);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonConfigSave
            // 
            this.buttonConfigSave.Location = new System.Drawing.Point(9, 196);
            this.buttonConfigSave.Name = "buttonConfigSave";
            this.buttonConfigSave.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigSave.TabIndex = 8;
            this.buttonConfigSave.Text = "SAVE";
            this.buttonConfigSave.UseVisualStyleBackColor = true;
            this.buttonConfigSave.Click += new System.EventHandler(this.buttonConfigSave_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 223);
            this.Controls.Add(this.buttonConfigSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSqlConnection);
            this.Controls.Add(this.buttonSqlConnection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBugReport);
            this.Controls.Add(this.linkLabelBugReport);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Config";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabelBugReport;
        private System.Windows.Forms.Label labelBugReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSqlConnection;
        private System.Windows.Forms.Label labelSqlConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonConfigSave;
    }
}