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
    public partial class DoctorConsulation : Form
    {
        public DoctorConsulation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPartsMedicalDoctorAccess FormPartsMedicalDoctorAccess = new FormPartsMedicalDoctorAccess();
            FormPartsMedicalDoctorAccess.ShowDialog();
        }
    }
}
