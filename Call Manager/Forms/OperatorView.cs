using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Call_Manager
{
    public partial class OperatorView : Form
    {
        public OperatorView()
        {
            InitializeComponent();
        }

        private void OperatorView_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CallInfo CallInfoWindow = new CallInfo();
            CallInfoWindow.Show();
        }

        private void webBrowserOperator_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
            webBrowserOperator.Document.Window.ScrollTo(0, 45);
        }

        private void webBrowserTier_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
            webBrowserTier.Document.Window.ScrollTo(0, 45);
        }
    }
}