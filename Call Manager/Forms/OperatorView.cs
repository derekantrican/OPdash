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
    public partial class OperatorView : Form
    {
        public static bool ChangeView;

        public OperatorView()
        {
            InitializeComponent();
            ChangeView = false;

            toolTip1.SetToolTip(this.Clock, "Brandon wanted a \"Big Ass Clock\"");

            labelUser.Text = "Welcome back, " + Environment.UserName + "!";
        }

        private void OperatorView_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CallInfo CallInfoWindow = new CallInfo();
            CallInfoWindow.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Convert.ToDecimal(DateTime.Now.ToString("hh")) / 10 > 1)
            {
                Clock.Text = DateTime.Now.ToString("hh:mm", CultureInfo.InvariantCulture);
            }
            else
            {
                Clock.Text = DateTime.Now.ToString(" h:mm", CultureInfo.InvariantCulture);
            }
            
            AMPM.Text = DateTime.Now.ToString("tt", CultureInfo.InvariantCulture);
        }

        private void richTextBoxClock_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            ChangeView = true;
            ViewChanger ViewWindow = new ViewChanger();
            ViewWindow.Show();
            this.Close();
        }

        private void AMPM_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void Clock_Click(object sender, EventArgs e)
        {

        }
    }
}