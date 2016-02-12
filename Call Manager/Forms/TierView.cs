using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Call_Manager
{
    public partial class TierView : Form
    {
        public static bool ChangeView;

        public TierView()
        {
            InitializeComponent();
            ChangeView = false;           

            toolTip1.SetToolTip(this.Clock, "Brandon wanted a \"Big Ass Clock\"");

            labelUser.Text = "Welcome back, " + Environment.UserName + "!";

            this.FormClosing += TierView_FormClosing;
        }

        private void TierView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ChangeView)
            {
                Application.Exit();
            }
        }

        private void TierView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_3CXSupportDBaseDataSet.Calls' table. You can move, or remove it, as needed.
            this.callsTableAdapter.Fill(this._3CXSupportDBaseDataSet.Calls);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChangeView = true;
            ViewChanger ViewWindow = new ViewChanger();
            ViewWindow.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString("%h:mm tt", CultureInfo.InvariantCulture);

            try
            {
                //dataGridView1.DataSource = dbManip.PopulateDataSetAsync("SELECT * FROM dbo.Calls", "dbo.Calls", "_3CXSupportDBaseDataSet").Result;
                this.callsTableAdapter.Update(this._3CXSupportDBaseDataSet.Calls);
                Debug.Write("Refreshed\n");
            }
            catch
            {

            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void callManagerDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {

        }

        //private DataTable PopulateDataSet(string sqlQuery, string table, string dataSet)
        //{
        //    string connectionString = @"Data Source = MICHAELF-3800\SIGMANEST; Initial Catalog = 3CXSupportDBase; Persist Security Info = True; User ID = AE; Password = ne$t123";
        //    SqlConnection connString = new SqlConnection(connectionString);
        //    connString.Open();

        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connString);
        //    DataSet dataSetInstance = new DataSet(dataSet);
        //    dataAdapter.FillSchema(dataSetInstance, SchemaType.Source, table);
        //    dataAdapter.Fill(dataSetInstance, table);

        //    DataTable dataTable = dataSetInstance.Tables[table];

        //    return dataTable;
        //}

        //public async Task PopulateDataSetAsync(string sqlQuery, string table, string dataSet)
        //{
        //    return await Task.Run(() => PopulateDataSet(sqlQuery, table, dataSet)).ConfigureAwait(continueOnCapturedContext: false);
        //}
    }
}
