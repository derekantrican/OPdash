using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Call_Manager
{
    public partial class MasterView : Form
    {
        public MasterView()
        {
            InitializeComponent();

            this.FormClosing += MasterView_FormClosing;
        }

        private void MasterView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString("%h:mm tt", CultureInfo.InvariantCulture);
        }

        private void labelOperatorTab_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null && this.ActiveMdiChild.Text.ToString() == "Tier View")
            {
                this.ActiveMdiChild.Close();
            }         

            OperatorView operatorMDIChild = new OperatorView();
            // Set the Parent Form of the Child window.
            operatorMDIChild.MdiParent = this;
            // Display the new form.
            operatorMDIChild.Show();
            operatorMDIChild.Location = new Point(12, 45);
        }

        private void labelTierTab_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null && this.ActiveMdiChild.Text.ToString() == "Operator View")
            {
                this.ActiveMdiChild.Close();
            }

            TierView tierMDIChild = new TierView();
            // Set the Parent Form of the Child window.
            tierMDIChild.MdiParent = this;
            // Display the new form.
            tierMDIChild.Show();
            tierMDIChild.Location = new Point(12, 45);
        }

        private void MasterView_Load(object sender, EventArgs e)
        {

        }
    }
}
