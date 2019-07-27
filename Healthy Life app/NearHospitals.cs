using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Healthy_Life_app
{
    public partial class NearHospitals : Form
    {
        public NearHospitals()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HospitalsInfo HospitalsInfo = new HospitalsInfo();
            HospitalsInfo.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("https://www.google.com/maps/search/hosptial/@28.6396356,30.8121438,13z/data=!3m1!4b1");

            webBrowser1.Navigate(queryaddress.ToString());
       
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HospitalsInfo HospitalsInfo = new HospitalsInfo();
            HospitalsInfo.ShowDialog();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
