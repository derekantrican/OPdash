namespace Call_Manager
{
    partial class OperatorView
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
            this.newTicket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clock = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AMPM = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelOperatorCount = new System.Windows.Forms.Label();
            this.labelOperator = new System.Windows.Forms.Label();
            this.labelTier2 = new System.Windows.Forms.Label();
            this.labelTier2Count = new System.Windows.Forms.Label();
            this.labelTier1 = new System.Windows.Forms.Label();
            this.labelTier1Count = new System.Windows.Forms.Label();
            this.pictureBoxOperatorNext = new System.Windows.Forms.PictureBox();
            this.pictureBoxTier2Next = new System.Windows.Forms.PictureBox();
            this.webBrowserOperator = new System.Windows.Forms.WebBrowser();
            this.webBrowserTier2 = new System.Windows.Forms.WebBrowser();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.newTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOperatorNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTier2Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // newTicket
            // 
            this.newTicket.BackColor = System.Drawing.Color.Green;
            this.newTicket.Location = new System.Drawing.Point(536, 32);
            this.newTicket.Name = "newTicket";
            this.newTicket.Size = new System.Drawing.Size(125, 125);
            this.newTicket.TabIndex = 0;
            this.newTicket.TabStop = false;
            this.newTicket.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Call_Manager.Properties.Resources.Switch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Clock
            // 
            this.Clock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clock.AutoSize = true;
            this.Clock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Clock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.ForeColor = System.Drawing.Color.White;
            this.Clock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clock.Location = new System.Drawing.Point(18, 50);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(112, 40);
            this.Clock.TabIndex = 3;
            this.Clock.Text = "12:34";
            this.Clock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clock.Click += new System.EventHandler(this.Clock_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(12, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 125);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AMPM
            // 
            this.AMPM.AutoSize = true;
            this.AMPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AMPM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMPM.ForeColor = System.Drawing.Color.White;
            this.AMPM.Location = new System.Drawing.Point(40, 99);
            this.AMPM.Name = "AMPM";
            this.AMPM.Size = new System.Drawing.Size(69, 40);
            this.AMPM.TabIndex = 5;
            this.AMPM.Text = "PM";
            this.AMPM.Click += new System.EventHandler(this.AMPM_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Blue;
            this.pictureBox3.Location = new System.Drawing.Point(143, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 125);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Blue;
            this.pictureBox4.Location = new System.Drawing.Point(274, 32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(125, 125);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Blue;
            this.pictureBox5.Location = new System.Drawing.Point(405, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(125, 125);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // labelOperatorCount
            // 
            this.labelOperatorCount.AutoSize = true;
            this.labelOperatorCount.BackColor = System.Drawing.Color.Blue;
            this.labelOperatorCount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperatorCount.ForeColor = System.Drawing.Color.White;
            this.labelOperatorCount.Location = new System.Drawing.Point(179, 50);
            this.labelOperatorCount.Name = "labelOperatorCount";
            this.labelOperatorCount.Size = new System.Drawing.Size(53, 55);
            this.labelOperatorCount.TabIndex = 9;
            this.labelOperatorCount.Text = "0";
            // 
            // labelOperator
            // 
            this.labelOperator.AutoSize = true;
            this.labelOperator.BackColor = System.Drawing.Color.Blue;
            this.labelOperator.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperator.ForeColor = System.Drawing.Color.White;
            this.labelOperator.Location = new System.Drawing.Point(148, 111);
            this.labelOperator.Name = "labelOperator";
            this.labelOperator.Size = new System.Drawing.Size(118, 28);
            this.labelOperator.TabIndex = 10;
            this.labelOperator.Text = "Operator";
            this.labelOperator.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTier2
            // 
            this.labelTier2.AutoSize = true;
            this.labelTier2.BackColor = System.Drawing.Color.Blue;
            this.labelTier2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTier2.ForeColor = System.Drawing.Color.White;
            this.labelTier2.Location = new System.Drawing.Point(296, 111);
            this.labelTier2.Name = "labelTier2";
            this.labelTier2.Size = new System.Drawing.Size(79, 28);
            this.labelTier2.TabIndex = 12;
            this.labelTier2.Text = "Tier 2";
            this.labelTier2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTier2Count
            // 
            this.labelTier2Count.AutoSize = true;
            this.labelTier2Count.BackColor = System.Drawing.Color.Blue;
            this.labelTier2Count.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTier2Count.ForeColor = System.Drawing.Color.White;
            this.labelTier2Count.Location = new System.Drawing.Point(312, 50);
            this.labelTier2Count.Name = "labelTier2Count";
            this.labelTier2Count.Size = new System.Drawing.Size(53, 55);
            this.labelTier2Count.TabIndex = 11;
            this.labelTier2Count.Text = "0";
            // 
            // labelTier1
            // 
            this.labelTier1.AutoSize = true;
            this.labelTier1.BackColor = System.Drawing.Color.Blue;
            this.labelTier1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTier1.ForeColor = System.Drawing.Color.White;
            this.labelTier1.Location = new System.Drawing.Point(432, 111);
            this.labelTier1.Name = "labelTier1";
            this.labelTier1.Size = new System.Drawing.Size(79, 28);
            this.labelTier1.TabIndex = 14;
            this.labelTier1.Text = "Tier 1";
            // 
            // labelTier1Count
            // 
            this.labelTier1Count.AutoSize = true;
            this.labelTier1Count.BackColor = System.Drawing.Color.Blue;
            this.labelTier1Count.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTier1Count.ForeColor = System.Drawing.Color.White;
            this.labelTier1Count.Location = new System.Drawing.Point(443, 48);
            this.labelTier1Count.Name = "labelTier1Count";
            this.labelTier1Count.Size = new System.Drawing.Size(53, 55);
            this.labelTier1Count.TabIndex = 13;
            this.labelTier1Count.Text = "0";
            // 
            // pictureBoxOperatorNext
            // 
            this.pictureBoxOperatorNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBoxOperatorNext.Location = new System.Drawing.Point(12, 163);
            this.pictureBoxOperatorNext.Name = "pictureBoxOperatorNext";
            this.pictureBoxOperatorNext.Size = new System.Drawing.Size(324, 143);
            this.pictureBoxOperatorNext.TabIndex = 15;
            this.pictureBoxOperatorNext.TabStop = false;
            // 
            // pictureBoxTier2Next
            // 
            this.pictureBoxTier2Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBoxTier2Next.Location = new System.Drawing.Point(342, 163);
            this.pictureBoxTier2Next.Name = "pictureBoxTier2Next";
            this.pictureBoxTier2Next.Size = new System.Drawing.Size(319, 143);
            this.pictureBoxTier2Next.TabIndex = 16;
            this.pictureBoxTier2Next.TabStop = false;
            // 
            // webBrowserOperator
            // 
            this.webBrowserOperator.Location = new System.Drawing.Point(20, 172);
            this.webBrowserOperator.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserOperator.Name = "webBrowserOperator";
            this.webBrowserOperator.ScrollBarsEnabled = false;
            this.webBrowserOperator.Size = new System.Drawing.Size(307, 126);
            this.webBrowserOperator.TabIndex = 17;
            this.webBrowserOperator.Url = new System.Uri("https://script.google.com/macros/s/AKfycby2TVTF693Dtlhww2ElUWmp1jL3DXCYBQPdWjf33H" +
        "GRNWD7uF0/exec", System.UriKind.Absolute);
            // 
            // webBrowserTier2
            // 
            this.webBrowserTier2.Location = new System.Drawing.Point(350, 172);
            this.webBrowserTier2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserTier2.Name = "webBrowserTier2";
            this.webBrowserTier2.ScrollBarsEnabled = false;
            this.webBrowserTier2.Size = new System.Drawing.Size(303, 126);
            this.webBrowserTier2.TabIndex = 18;
            this.webBrowserTier2.Url = new System.Uri("https://script.google.com/macros/s/AKfycbxns1C92ffmLPGB8jlaDgUKx0BWNLYg2t2WWkaRQt" +
        "_sz2so-ys/exec", System.UriKind.Absolute);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Call_Manager.Properties.Resources.gearWhite;
            this.pictureBox6.Location = new System.Drawing.Point(647, -1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(555, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 80);
            this.label1.TabIndex = 20;
            this.label1.Text = "New\r\nCall\r\n";
            this.label1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(260, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(88, 13);
            this.labelUser.TabIndex = 21;
            this.labelUser.Text = "Welcome back, !";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 5000;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // OperatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(672, 315);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.webBrowserTier2);
            this.Controls.Add(this.webBrowserOperator);
            this.Controls.Add(this.pictureBoxTier2Next);
            this.Controls.Add(this.pictureBoxOperatorNext);
            this.Controls.Add(this.labelTier1);
            this.Controls.Add(this.labelTier1Count);
            this.Controls.Add(this.labelTier2);
            this.Controls.Add(this.labelTier2Count);
            this.Controls.Add(this.labelOperator);
            this.Controls.Add(this.labelOperatorCount);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.AMPM);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newTicket);
            this.Controls.Add(this.pictureBox2);
            this.Name = "OperatorView";
            this.Text = "Operator View";
            this.Load += new System.EventHandler(this.OperatorView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOperatorNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTier2Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox newTicket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label AMPM;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelOperatorCount;
        private System.Windows.Forms.Label labelOperator;
        private System.Windows.Forms.Label labelTier2;
        private System.Windows.Forms.Label labelTier2Count;
        private System.Windows.Forms.Label labelTier1;
        private System.Windows.Forms.Label labelTier1Count;
        private System.Windows.Forms.PictureBox pictureBoxOperatorNext;
        private System.Windows.Forms.PictureBox pictureBoxTier2Next;
        private System.Windows.Forms.WebBrowser webBrowserOperator;
        private System.Windows.Forms.WebBrowser webBrowserTier2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}