using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Call_Manager.Forms
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
            labelSqlConnection.Text = Resources.UserSettings.Default.Server + @"\\" + Resources.UserSettings.Default.Instance;
        }

        private void buttonSqlConnection_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfigSave_Click(object sender, EventArgs e)
        {
            Resources.UserSettings.Default.Server = labelSqlConnection.Text;
            Resources.UserSettings.Default.Save();
        }

        private void linkLabelBugReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/derekantrican/Call-Manager/issues/new");
        }
    }
}
