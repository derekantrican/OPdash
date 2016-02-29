namespace Call_Manager
{
    partial class AdminMode
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
            this.labelSQLQuery = new System.Windows.Forms.Label();
            this.textBoxSQLQuery = new System.Windows.Forms.TextBox();
            this.buttonSQLQuery = new System.Windows.Forms.Button();
            this.CannedQueries = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelSQLQuery
            // 
            this.labelSQLQuery.AutoSize = true;
            this.labelSQLQuery.Location = new System.Drawing.Point(13, 13);
            this.labelSQLQuery.Name = "labelSQLQuery";
            this.labelSQLQuery.Size = new System.Drawing.Size(62, 13);
            this.labelSQLQuery.TabIndex = 0;
            this.labelSQLQuery.Text = "SQL Query:";
            // 
            // textBoxSQLQuery
            // 
            this.textBoxSQLQuery.Location = new System.Drawing.Point(13, 30);
            this.textBoxSQLQuery.Name = "textBoxSQLQuery";
            this.textBoxSQLQuery.Size = new System.Drawing.Size(442, 20);
            this.textBoxSQLQuery.TabIndex = 1;
            // 
            // buttonSQLQuery
            // 
            this.buttonSQLQuery.Location = new System.Drawing.Point(484, 29);
            this.buttonSQLQuery.Name = "buttonSQLQuery";
            this.buttonSQLQuery.Size = new System.Drawing.Size(42, 23);
            this.buttonSQLQuery.TabIndex = 2;
            this.buttonSQLQuery.Text = "Run";
            this.buttonSQLQuery.UseVisualStyleBackColor = true;
            // 
            // CannedQueries
            // 
            this.CannedQueries.DropDownWidth = 150;
            this.CannedQueries.FormattingEnabled = true;
            this.CannedQueries.Items.AddRange(new object[] {
            "SELECT",
            "UPDATE"});
            this.CannedQueries.Location = new System.Drawing.Point(461, 30);
            this.CannedQueries.Name = "CannedQueries";
            this.CannedQueries.Size = new System.Drawing.Size(17, 21);
            this.CannedQueries.TabIndex = 22;
            this.CannedQueries.SelectedIndexChanged += new System.EventHandler(this.CannedQueries_SelectedIndexChanged);
            // 
            // AdminMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 72);
            this.Controls.Add(this.CannedQueries);
            this.Controls.Add(this.buttonSQLQuery);
            this.Controls.Add(this.textBoxSQLQuery);
            this.Controls.Add(this.labelSQLQuery);
            this.Name = "AdminMode";
            this.Text = "Admin Mode";
            this.Load += new System.EventHandler(this.AdminMode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSQLQuery;
        private System.Windows.Forms.TextBox textBoxSQLQuery;
        private System.Windows.Forms.Button buttonSQLQuery;
        private System.Windows.Forms.ComboBox CannedQueries;
    }
}