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
    public partial class FormConsulting : Form
    {
        public FormConsulting()
        {
            InitializeComponent();

        }

        private void labelMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMyAccount FormRegister = new FormMyAccount();
            FormRegister.ShowDialog();
        }

        private void buttonParts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPartsMedical FormPartsMedical = new FormPartsMedical();
            FormPartsMedical.ShowDialog();
        }

        private void buttonHealth_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormServices FormServices = new FormServices();
            FormServices.ShowDialog();
        }
    }
}
