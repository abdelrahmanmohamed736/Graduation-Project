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
    public partial class HospitalsInfo : Form
    {
        public HospitalsInfo()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPartsMedical FormPartsMedical = new FormPartsMedical();
            FormPartsMedical.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            MiniaHospitals MiniaHospitals = new MiniaHospitals();
            MiniaHospitals.ShowDialog();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NearHospitals NearHospitals = new NearHospitals();
            NearHospitals.ShowDialog();
        }
    }
}
