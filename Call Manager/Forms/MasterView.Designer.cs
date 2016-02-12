namespace Call_Manager
{
    partial class MasterView
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
            this.labelOperatorTab = new System.Windows.Forms.Label();
            this.labelTierTab = new System.Windows.Forms.Label();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.Clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOperatorTab
            // 
            this.labelOperatorTab.AutoSize = true;
            this.labelOperatorTab.BackColor = System.Drawing.Color.Blue;
            this.labelOperatorTab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperatorTab.ForeColor = System.Drawing.Color.White;
            this.labelOperatorTab.Location = new System.Drawing.Point(12, 1);
            this.labelOperatorTab.Name = "labelOperatorTab";
            this.labelOperatorTab.Size = new System.Drawing.Size(135, 32);
            this.labelOperatorTab.TabIndex = 2;
            this.labelOperatorTab.Text = "Operator";
            this.labelOperatorTab.Click += new System.EventHandler(this.labelOperatorTab_Click);
            // 
            // labelTierTab
            // 
            this.labelTierTab.AutoSize = true;
            this.labelTierTab.BackColor = System.Drawing.Color.Yellow;
            this.labelTierTab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTierTab.ForeColor = System.Drawing.Color.Black;
            this.labelTierTab.Location = new System.Drawing.Point(164, 1);
            this.labelTierTab.Name = "labelTierTab";
            this.labelTierTab.Size = new System.Drawing.Size(67, 32);
            this.labelTierTab.TabIndex = 3;
            this.labelTierTab.Text = "Tier";
            this.labelTierTab.Click += new System.EventHandler(this.labelTierTab_Click);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.Image = global::Call_Manager.Properties.Resources.gearWhite;
            this.pictureBoxSettings.Location = new System.Drawing.Point(1183, 1);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxSettings.TabIndex = 4;
            this.pictureBoxSettings.TabStop = false;
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.BackColor = System.Drawing.Color.Transparent;
            this.Clock.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.ForeColor = System.Drawing.Color.Red;
            this.Clock.Location = new System.Drawing.Point(992, 2);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(185, 40);
            this.Clock.TabIndex = 5;
            this.Clock.Text = "12:34 PM";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1209, 632);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.labelTierTab);
            this.Controls.Add(this.labelOperatorTab);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1225, 671);
            this.MinimumSize = new System.Drawing.Size(1225, 671);
            this.Name = "MasterView";
            this.Text = "MasterView";
            this.Load += new System.EventHandler(this.MasterView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOperatorTab;
        private System.Windows.Forms.Label labelTierTab;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Timer timer1;
    }
}