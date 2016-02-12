namespace Call_Manager
{
    partial class ViewChanger
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
            this.buttonOperator = new System.Windows.Forms.Button();
            this.buttonTier = new System.Windows.Forms.Button();
            this.labelChooseView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOperator
            // 
            this.buttonOperator.Location = new System.Drawing.Point(46, 25);
            this.buttonOperator.Name = "buttonOperator";
            this.buttonOperator.Size = new System.Drawing.Size(75, 23);
            this.buttonOperator.TabIndex = 0;
            this.buttonOperator.Text = "Operator";
            this.buttonOperator.UseVisualStyleBackColor = true;
            this.buttonOperator.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonTier
            // 
            this.buttonTier.Location = new System.Drawing.Point(172, 25);
            this.buttonTier.Name = "buttonTier";
            this.buttonTier.Size = new System.Drawing.Size(75, 23);
            this.buttonTier.TabIndex = 1;
            this.buttonTier.Text = "Tier";
            this.buttonTier.UseVisualStyleBackColor = true;
            this.buttonTier.Click += new System.EventHandler(this.buttonTier_Click);
            // 
            // labelChooseView
            // 
            this.labelChooseView.AutoSize = true;
            this.labelChooseView.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseView.ForeColor = System.Drawing.Color.White;
            this.labelChooseView.Location = new System.Drawing.Point(72, 2);
            this.labelChooseView.Name = "labelChooseView";
            this.labelChooseView.Size = new System.Drawing.Size(149, 21);
            this.labelChooseView.TabIndex = 2;
            this.labelChooseView.Text = "Choose your view:";
            this.labelChooseView.Click += new System.EventHandler(this.labelChooseView_Click);
            // 
            // ViewChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(284, 65);
            this.Controls.Add(this.labelChooseView);
            this.Controls.Add(this.buttonTier);
            this.Controls.Add(this.buttonOperator);
            this.Name = "ViewChanger";
            this.Text = "View Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOperator;
        private System.Windows.Forms.Button buttonTier;
        private System.Windows.Forms.Label labelChooseView;
    }
}

