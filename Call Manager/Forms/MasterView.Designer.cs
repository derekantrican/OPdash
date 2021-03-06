﻿namespace Call_Manager
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
            this.Clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.labelSelectViewPrompt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOperatorTab
            // 
            this.labelOperatorTab.AutoSize = true;
            this.labelOperatorTab.BackColor = System.Drawing.Color.Blue;
            this.labelOperatorTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperatorTab.ForeColor = System.Drawing.Color.White;
            this.labelOperatorTab.Location = new System.Drawing.Point(12, 1);
            this.labelOperatorTab.Name = "labelOperatorTab";
            this.labelOperatorTab.Size = new System.Drawing.Size(121, 31);
            this.labelOperatorTab.TabIndex = 2;
            this.labelOperatorTab.Text = "Operator";
            this.labelOperatorTab.Click += new System.EventHandler(this.labelOperatorTab_Click);
            // 
            // labelTierTab
            // 
            this.labelTierTab.AutoSize = true;
            this.labelTierTab.BackColor = System.Drawing.Color.Yellow;
            this.labelTierTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTierTab.ForeColor = System.Drawing.Color.Black;
            this.labelTierTab.Location = new System.Drawing.Point(164, 1);
            this.labelTierTab.Name = "labelTierTab";
            this.labelTierTab.Size = new System.Drawing.Size(61, 31);
            this.labelTierTab.TabIndex = 3;
            this.labelTierTab.Text = "Tier";
            this.labelTierTab.Click += new System.EventHandler(this.labelTierTab_Click);
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.BackColor = System.Drawing.Color.Transparent;
            this.Clock.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.ForeColor = System.Drawing.Color.Red;
            this.Clock.Location = new System.Drawing.Point(864, 2);
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
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::Call_Manager.Properties.Resources.SigmaTEKWest__black__fw;
            this.pictureBoxLogo.Location = new System.Drawing.Point(989, 574);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(92, 56);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.Image = global::Call_Manager.Properties.Resources.gearWhite;
            this.pictureBoxSettings.Location = new System.Drawing.Point(1055, 0);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxSettings.TabIndex = 4;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // labelSelectViewPrompt
            // 
            this.labelSelectViewPrompt.AutoSize = true;
            this.labelSelectViewPrompt.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectViewPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectViewPrompt.Location = new System.Drawing.Point(256, 264);
            this.labelSelectViewPrompt.Name = "labelSelectViewPrompt";
            this.labelSelectViewPrompt.Size = new System.Drawing.Size(542, 31);
            this.labelSelectViewPrompt.TabIndex = 8;
            this.labelSelectViewPrompt.Text = "Please select a view from the options above";
            // 
            // MasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1084, 632);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.labelTierTab);
            this.Controls.Add(this.labelOperatorTab);
            this.Controls.Add(this.labelSelectViewPrompt);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 671);
            this.MinimumSize = new System.Drawing.Size(1100, 671);
            this.Name = "MasterView";
            this.Text = "MasterView";
            this.Load += new System.EventHandler(this.MasterView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelSelectViewPrompt;
    }
}