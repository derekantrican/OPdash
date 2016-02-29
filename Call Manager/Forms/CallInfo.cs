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

        public CallInfo()
        {
            InitializeComponent();

            this.ActiveControl = textBoxName;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

            string SIMString = "cast(@SIMNo as int)";
            string TicketString = "cast(@Ticket as int)";

            if (textBoxName.Text == "")
            {
                MessageBox.Show("\"Customer Name\" cannot be empty");
                return;
            }
            else if(textBoxCompany.Text == "")
            {
                MessageBox.Show("\"Company\" cannot be empty");
                return;
            }
            else if(textBoxAreacode.Text == "")
            {
                MessageBox.Show("\"Area Code\" cannot be empty");
                return;
            }
            else if(textBoxDescription.Text == "")
            {
                MessageBox.Show("\"Description\" cannot be empty");
                return;
            }
            else if(textBoxSIMNo.Text == "")
            {
                SIMString = "NULL";
            }
            else if(textBoxTicket.Text == "")
            {
                TicketString = "NULL";
            }

            Guid CallGuid = Guid.NewGuid();

            Debug.Write(CallGuid);

            //Send the call data to the database

            DateTime localDate = DateTime.UtcNow;
            Debug.Write("\n\n\n");
            SqlConnection Conn = new SqlConnection("Data Source=MICHAELF-3800\\SIGMANEST;Initial Catalog=3CXSupportDBase;Persist Security Info=True;User ID=AE;Password=ne$t123");
            Conn.Open();
            Debug.Write(localDate.GetType());
            SqlCommand sqlcomm = new SqlCommand("INSERT INTO dbo.Call VALUES( @Guid, cast(@Time as datetime), @Name, @Comp, @AreaCode, " + SIMString + ", " + TicketString + ", @Desc,'', @Operator);", Conn);

            //Add the parameter types
            sqlcomm.Parameters.Add("@Guid", SqlDbType.UniqueIdentifier);
            sqlcomm.Parameters.AddWithValue("@Time", localDate);
            sqlcomm.Parameters.Add("@Name", SqlDbType.NVarChar);
            sqlcomm.Parameters.Add("@Comp", SqlDbType.NVarChar);
            sqlcomm.Parameters.Add("@AreaCode", SqlDbType.Int);
            sqlcomm.Parameters.AddWithValue("@SIMNo", textBoxSIMNo.Text);
            sqlcomm.Parameters.AddWithValue("@Ticket", textBoxTicket.Text);
            sqlcomm.Parameters.Add("@Desc", SqlDbType.NVarChar);
            sqlcomm.Parameters.Add("@Operator", SqlDbType.NVarChar);

            //Define the values for the parameters
            sqlcomm.Parameters["@Guid"].Value = CallGuid;
            sqlcomm.Parameters["@Name"].Value = textBoxName.Text;
            sqlcomm.Parameters["@Comp"].Value = textBoxCompany.Text;
            sqlcomm.Parameters["@AreaCode"].Value = textBoxAreacode.Text;
            //sqlcomm.Parameters["@SIMNo"].Value = textBoxSIMNo.Text;
            //sqlcomm.Parameters["@Ticket"].Value = textBoxTicket.Text;
            sqlcomm.Parameters["@Desc"].Value = textBoxDescription.Text;
            sqlcomm.Parameters["@Operator"].Value = Environment.UserName;

            try
            {
                Int32 o = sqlcomm.ExecuteNonQuery();
                this.labelSuccess.Text = "Sent Successfully!";

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
                this.labelSuccess.Text = "Failed...";
            }

            Conn.Close();
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

        private void CannedResponses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.Write("Selected: " + CannedResponses.SelectedItem + "\n");

            if (CannedResponses.SelectedItem.ToString() == "SIM not found")
            {
                textBoxDescription.Text = "SIM not found";
            }
            else if (CannedResponses.SelectedItem.ToString() == "Database connection")
            {
                textBoxDescription.Text = "Trouble connecting to the database";
            }
            else if (CannedResponses.SelectedItem.ToString() == "SIM Programmed")
            {
                textBoxDescription.Text = "\"The SIM needs to be programmed over the network\"";
            }
            else if (CannedResponses.SelectedItem.ToString() == "No material match")
            {
                textBoxDescription.Text = "User is getting a \"No matching material in tec file\" error";
            }
            else if (CannedResponses.SelectedItem.ToString() == "Installation")
            {
                textBoxDescription.Text = "User wants help installing SigmaNEST";
            }
        }
    }
}
