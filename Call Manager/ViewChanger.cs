using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Call_Manager
{
    public partial class ViewChanger : Form
    {
        public static bool ChangeView;

        public ViewChanger()
        {
            InitializeComponent();
            ChangeView = false;
            this.FormClosing += ViewChanger_FormClosing;

            SqlConnection conn = new SqlConnection("Data Source = MICHAELF-3800\\SIGMANEST; Initial Catalog = 3CXSupportDBase; Persist Security Info = True; User ID = AE; Password = ne$t123");

            using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from Engineers where AE like @username", conn))
            {
                conn.Open();
                sqlCommand.Parameters.AddWithValue("@username", Environment.UserName);
                int userCount = (int)sqlCommand.ExecuteScalar();
                
                if (userCount < 1)
                {
                    MessageBox.Show("\"" + Environment.UserName + "\" is not in the system. Please talk to Mike Fink");
                }
            }
            conn.Close();
        }

        private void ViewChanger_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ChangeView)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
            ChangeView = true;

            OperatorView OperatorWindow = new OperatorView();
            OperatorWindow.Show();
            this.Close();
        }

        private void buttonTier_Click(object sender, EventArgs e)
        {
            ChangeView = true;

            TierView TierWindow = new TierView();
            TierWindow.Show();
            this.Close();
        }

        private void labelChooseView_Click(object sender, EventArgs e)
        {

        }
    }
}
