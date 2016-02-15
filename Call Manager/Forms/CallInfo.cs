using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Call_Manager
{
    public partial class CallInfo : Form
    {
        public string SendStatus{ get; set; }

        public CallInfo()
        {
            InitializeComponent();

            this.ActiveControl = textBoxName;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Guid CallGuid = Guid.NewGuid();

            Debug.Write(CallGuid);

            //Send the call data to the database

            DateTime localDate = DateTime.UtcNow;
            Debug.Write("\n\n\n");
            SqlConnection Connection = new SqlConnection("Data Source=MICHAELF-3800\\SIGMANEST;Initial Catalog=3CXSupportDBase;Persist Security Info=True;User ID=AE;Password=ne$t123");
            Connection.Open();

            string sqlCommandString = "INSERT INTO dbo.Call VALUES('" + CallGuid + "','" + localDate.ToString("yyyy-MM-ddThh:mm:ss") + "','" + textBoxName.Text + "','" + textBoxCompany.Text + "','" + textBoxAreacode.Text + "','" + textBoxSIMNo.Text + "','" + textBoxTicket.Text + "','" + textBoxDescription.Text + "','','" + Environment.UserName + "');";
            SqlCommand sqlcomm = new SqlCommand(sqlCommandString, Connection);

            try
            {
                int o = sqlcomm.ExecuteNonQuery();
                SendStatus = "Sent Successfully!";

                System.Threading.Thread.Sleep(3000);

                if (checkBoxPersistent.Checked)
                {
                    textBoxName.Text = "";
                    textBoxCompany.Text = "";
                    textBoxAreacode.Text = "";
                    textBoxSIMNo.Text = "";
                    textBoxTicket.Text = "";
                    textBoxDescription.Text = "";
                    textBoxName.Focus();
                }
                else
                {
                    this.Close();
                }
            }

            catch (SqlException exp)
            {
                Debug.Write("Error: " + exp + "\n");
                SendStatus = "Failed...";
            }

            Connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSuccess.Text = SendStatus;
        }

        private void buttonHelpdesk_Click(object sender, EventArgs e)
        {
            if (checkBoxBuiltInBrowser.Checked)
            {
                Browser BrowserWindow = new Browser();
                BrowserWindow.Show();
            }
            else
            {
                Process.Start("http://info.sigmatek.net/Helpdesk/Ticket");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CallInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
