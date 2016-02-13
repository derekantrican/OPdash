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

        public TierView()
        {
            InitializeComponent();
        }

        private void TierView_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            SqlConnection Connection = new SqlConnection("Data Source=MICHAELF-3800\\SIGMANEST;Initial Catalog=3CXSupportDBase;Persist Security Info=True;User ID=AE;Password=ne$t123");
            Connection.Open();

            SqlCommand sc = new SqlCommand("SELECT GUID AS GUID, Time, Customer, Company, Phone, SIM, Ticket, Description, Engineer, Operator FROM dbo.Call", Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sc);
            SqlCommand sc1 = new SqlCommand("SELECT GUID AS GUID, Time, Customer, Company, Phone, SIM, Ticket, Description, Engineer, Operator FROM dbo.Call", Connection);
            SqlDataAdapter adapter1 = new SqlDataAdapter(sc1);

            //Set up the top view table
            adapter.Fill(table);
            callsBindingSource.DataSource = table;
            dataGridViewUnassigned.DataSource = callsBindingSource;
            callsBindingSource.Filter = "Engineer = ''";

            dataGridViewUnassigned.Sort(dataGridViewUnassigned.Columns["timeDataGridViewImageColumn"], ListSortDirection.Descending);

            //Set up the bottom view table
            adapter.Fill(table1);
            bindingSource1.DataSource = table1;
            dataGridViewMine.DataSource = bindingSource1;
            bindingSource1.Filter = "Engineer = '" + Environment.UserName + "'";
            dataGridViewMine.Sort(dataGridViewMine.Columns["timeDataGridViewImageColumn1"], ListSortDirection.Descending);

            Connection.Close();
        }

        private void dataGridViewUnassigned_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridViewUnassigned.Columns["AE"].Index)
                return;

            string guid = dataGridViewUnassigned.Rows[e.RowIndex].Cells["gUIDDataGridViewTextBoxColumn"].Value.ToString();

            Debug.Write("GUID: " + guid + "\n");

            SqlConnection Connection = new SqlConnection("Data Source=MICHAELF-3800\\SIGMANEST;Initial Catalog=3CXSupportDBase;Persist Security Info=True;User ID=AE;Password=ne$t123");
            Connection.Open();
            SqlCommand sc = new SqlCommand("UPDATE dbo.Call SET Engineer ='" + Environment.UserName + "' WHERE GUID = '" + guid + "'", Connection);
            int o = sc.ExecuteNonQuery();
            Connection.Close();
        }

        private void dataGridViewUnassigned_DataSourceChanged(object sender, EventArgs e)
        {
            //Adding "Take" buttons
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Engineer";
            buttonColumn.Name = "AE";
            buttonColumn.Text = "Take";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridViewUnassigned.Columns.Add(buttonColumn);
            buttonColumn.DisplayIndex = 9;
            //dataGridViewUnassigned.Columns[""].DisplayIndex = 6;
            dataGridViewUnassigned.CellClick += new DataGridViewCellEventHandler(dataGridViewUnassigned_CellClick);
        }
    }
}
