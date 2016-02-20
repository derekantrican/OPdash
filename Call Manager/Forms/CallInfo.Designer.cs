namespace Call_Manager
{
    partial class CallInfo
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.labelCompany = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxAreacode = new System.Windows.Forms.TextBox();
            this.labelAreacode = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxSIMNo = new System.Windows.Forms.TextBox();
            this.labelSIMNo = new System.Windows.Forms.Label();
            this.textBoxTicket = new System.Windows.Forms.TextBox();
            this.labelTicket = new System.Windows.Forms.Label();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.buttonHelpdesk = new System.Windows.Forms.Button();
            this.checkBoxBuiltInBrowser = new System.Windows.Forms.CheckBox();
            this.checkBoxPersistent = new System.Windows.Forms.CheckBox();
            this.NameRequired = new System.Windows.Forms.Label();
            this.CompanyRequired = new System.Windows.Forms.Label();
            this.AreaCodeRequired = new System.Windows.Forms.Label();
            this.DescriptionRequired = new System.Windows.Forms.Label();
            this.CannedResponses = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(197, 214);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Send to Tier";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Customer Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(103, 18);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(154, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(103, 44);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(154, 20);
            this.textBoxCompany.TabIndex = 4;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(13, 46);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(54, 13);
            this.labelCompany.TabIndex = 3;
            this.labelCompany.Text = "Company:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 168);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(82, 26);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Brief description\r\nof the problem:";
            // 
            // textBoxAreacode
            // 
            this.textBoxAreacode.Location = new System.Drawing.Point(103, 70);
            this.textBoxAreacode.MaxLength = 3;
            this.textBoxAreacode.Name = "textBoxAreacode";
            this.textBoxAreacode.Size = new System.Drawing.Size(35, 20);
            this.textBoxAreacode.TabIndex = 5;
            // 
            // labelAreacode
            // 
            this.labelAreacode.AutoSize = true;
            this.labelAreacode.Location = new System.Drawing.Point(12, 72);
            this.labelAreacode.Name = "labelAreacode";
            this.labelAreacode.Size = new System.Drawing.Size(59, 13);
            this.labelAreacode.TabIndex = 5;
            this.labelAreacode.Text = "Area code:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(103, 168);
            this.textBoxDescription.MaxLength = 140;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(153, 40);
            this.textBoxDescription.TabIndex = 8;
            // 
            // textBoxSIMNo
            // 
            this.textBoxSIMNo.AcceptsTab = true;
            this.textBoxSIMNo.Location = new System.Drawing.Point(104, 97);
            this.textBoxSIMNo.MaxLength = 5;
            this.textBoxSIMNo.Name = "textBoxSIMNo";
            this.textBoxSIMNo.Size = new System.Drawing.Size(55, 20);
            this.textBoxSIMNo.TabIndex = 6;
            // 
            // labelSIMNo
            // 
            this.labelSIMNo.AutoSize = true;
            this.labelSIMNo.Location = new System.Drawing.Point(13, 99);
            this.labelSIMNo.Name = "labelSIMNo";
            this.labelSIMNo.Size = new System.Drawing.Size(39, 13);
            this.labelSIMNo.TabIndex = 9;
            this.labelSIMNo.Text = "SIM #:";
            // 
            // textBoxTicket
            // 
            this.textBoxTicket.AcceptsTab = true;
            this.textBoxTicket.Location = new System.Drawing.Point(103, 126);
            this.textBoxTicket.MaxLength = 6;
            this.textBoxTicket.Name = "textBoxTicket";
            this.textBoxTicket.Size = new System.Drawing.Size(56, 20);
            this.textBoxTicket.TabIndex = 7;
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Location = new System.Drawing.Point(12, 128);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(79, 13);
            this.labelTicket.TabIndex = 11;
            this.labelTicket.Text = "Existing Ticket:";
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.ForeColor = System.Drawing.Color.Red;
            this.labelSuccess.Location = new System.Drawing.Point(100, 219);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(37, 13);
            this.labelSuccess.TabIndex = 13;
            this.labelSuccess.Text = "Status";
            // 
            // buttonHelpdesk
            // 
            this.buttonHelpdesk.Location = new System.Drawing.Point(179, 124);
            this.buttonHelpdesk.Name = "buttonHelpdesk";
            this.buttonHelpdesk.Size = new System.Drawing.Size(93, 23);
            this.buttonHelpdesk.TabIndex = 14;
            this.buttonHelpdesk.Text = "Open Helpdesk";
            this.buttonHelpdesk.UseVisualStyleBackColor = true;
            this.buttonHelpdesk.Click += new System.EventHandler(this.buttonHelpdesk_Click);
            // 
            // checkBoxBuiltInBrowser
            // 
            this.checkBoxBuiltInBrowser.AutoSize = true;
            this.checkBoxBuiltInBrowser.Location = new System.Drawing.Point(179, 145);
            this.checkBoxBuiltInBrowser.Name = "checkBoxBuiltInBrowser";
            this.checkBoxBuiltInBrowser.Size = new System.Drawing.Size(99, 17);
            this.checkBoxBuiltInBrowser.TabIndex = 15;
            this.checkBoxBuiltInBrowser.Text = "Built-In Browser";
            this.checkBoxBuiltInBrowser.UseVisualStyleBackColor = true;
            this.checkBoxBuiltInBrowser.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxPersistent
            // 
            this.checkBoxPersistent.AutoSize = true;
            this.checkBoxPersistent.Location = new System.Drawing.Point(13, 216);
            this.checkBoxPersistent.Name = "checkBoxPersistent";
            this.checkBoxPersistent.Size = new System.Drawing.Size(72, 17);
            this.checkBoxPersistent.TabIndex = 16;
            this.checkBoxPersistent.Text = "Persistent";
            this.checkBoxPersistent.UseVisualStyleBackColor = true;
            // 
            // NameRequired
            // 
            this.NameRequired.AutoSize = true;
            this.NameRequired.ForeColor = System.Drawing.Color.Red;
            this.NameRequired.Location = new System.Drawing.Point(258, 21);
            this.NameRequired.Name = "NameRequired";
            this.NameRequired.Size = new System.Drawing.Size(11, 13);
            this.NameRequired.TabIndex = 17;
            this.NameRequired.Text = "*";
            // 
            // CompanyRequired
            // 
            this.CompanyRequired.AutoSize = true;
            this.CompanyRequired.ForeColor = System.Drawing.Color.Red;
            this.CompanyRequired.Location = new System.Drawing.Point(258, 47);
            this.CompanyRequired.Name = "CompanyRequired";
            this.CompanyRequired.Size = new System.Drawing.Size(11, 13);
            this.CompanyRequired.TabIndex = 18;
            this.CompanyRequired.Text = "*";
            // 
            // AreaCodeRequired
            // 
            this.AreaCodeRequired.AutoSize = true;
            this.AreaCodeRequired.ForeColor = System.Drawing.Color.Red;
            this.AreaCodeRequired.Location = new System.Drawing.Point(140, 75);
            this.AreaCodeRequired.Name = "AreaCodeRequired";
            this.AreaCodeRequired.Size = new System.Drawing.Size(11, 13);
            this.AreaCodeRequired.TabIndex = 19;
            this.AreaCodeRequired.Text = "*";
            // 
            // DescriptionRequired
            // 
            this.DescriptionRequired.AutoSize = true;
            this.DescriptionRequired.ForeColor = System.Drawing.Color.Red;
            this.DescriptionRequired.Location = new System.Drawing.Point(258, 171);
            this.DescriptionRequired.Name = "DescriptionRequired";
            this.DescriptionRequired.Size = new System.Drawing.Size(11, 13);
            this.DescriptionRequired.TabIndex = 20;
            this.DescriptionRequired.Text = "*";
            // 
            // CannedResponses
            // 
            this.CannedResponses.DropDownWidth = 150;
            this.CannedResponses.FormattingEnabled = true;
            this.CannedResponses.Items.AddRange(new object[] {
            "SIM not found",
            "Database connection",
            "License files"});
            this.CannedResponses.Location = new System.Drawing.Point(257, 187);
            this.CannedResponses.Name = "CannedResponses";
            this.CannedResponses.Size = new System.Drawing.Size(17, 21);
            this.CannedResponses.TabIndex = 21;
            this.CannedResponses.SelectedIndexChanged += new System.EventHandler(this.CannedResponses_SelectedIndexChanged);
            // 
            // CallInfo
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(284, 245);
            this.Controls.Add(this.CannedResponses);
            this.Controls.Add(this.DescriptionRequired);
            this.Controls.Add(this.AreaCodeRequired);
            this.Controls.Add(this.CompanyRequired);
            this.Controls.Add(this.NameRequired);
            this.Controls.Add(this.checkBoxPersistent);
            this.Controls.Add(this.checkBoxBuiltInBrowser);
            this.Controls.Add(this.buttonHelpdesk);
            this.Controls.Add(this.labelSuccess);
            this.Controls.Add(this.textBoxTicket);
            this.Controls.Add(this.labelTicket);
            this.Controls.Add(this.textBoxSIMNo);
            this.Controls.Add(this.labelSIMNo);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxAreacode);
            this.Controls.Add(this.labelAreacode);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonSend);
            this.Name = "CallInfo";
            this.Text = "Call Info";
            this.Load += new System.EventHandler(this.CallInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxAreacode;
        private System.Windows.Forms.Label labelAreacode;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxSIMNo;
        private System.Windows.Forms.Label labelSIMNo;
        private System.Windows.Forms.TextBox textBoxTicket;
        private System.Windows.Forms.Label labelTicket;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.Button buttonHelpdesk;
        private System.Windows.Forms.CheckBox checkBoxBuiltInBrowser;
        private System.Windows.Forms.CheckBox checkBoxPersistent;
        private System.Windows.Forms.Label NameRequired;
        private System.Windows.Forms.Label CompanyRequired;
        private System.Windows.Forms.Label AreaCodeRequired;
        private System.Windows.Forms.Label DescriptionRequired;
        private System.Windows.Forms.ComboBox CannedResponses;
    }
}