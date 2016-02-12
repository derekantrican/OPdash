using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            OperatorView newMDIChild = new OperatorView();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void labelTierTab_Click(object sender, EventArgs e)
        {
            TierView newMDIChild = new TierView();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void MasterView_Load(object sender, EventArgs e)
        {

        }
    }
}
