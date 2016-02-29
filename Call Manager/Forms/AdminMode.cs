using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Call_Manager
{
    public partial class AdminMode : Form
    {
        public AdminMode()
        {
            InitializeComponent();
        }

        private void AdminMode_Load(object sender, EventArgs e)
        {

        }

        private void CannedQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CannedQueries.SelectedItem.ToString() == "SELECT")
            {
                textBoxSQLQuery.Text = "SELECT * FROM dbo.Call";
            }
            else if (CannedQueries.SelectedItem.ToString() == "UPDATE")
            {
                textBoxSQLQuery.Text = "UPDATE dbo.Call SET [column1=value1,column2=value2] WHERE [columnName=value]";
            }
        }
    }
}
