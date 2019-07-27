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
    public partial class MiniaDoctors : Form
    {
        public MiniaDoctors()
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

        private void bunifuShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void label91_Click(object sender, EventArgs e)
        {

        }

        private void label114_Click(object sender, EventArgs e)
        {

        }

        private void label123_Click(object sender, EventArgs e)
        {

        }

        private void label120_Click(object sender, EventArgs e)
        {

        }

        private void label149_Click(object sender, EventArgs e)
        {

        }

        private void label212_Click(object sender, EventArgs e)
        {

        }

        private void label220_Click(object sender, EventArgs e)
        {

        }

        private void label235_Click(object sender, EventArgs e)
        {

        }

        private void label250_Click(object sender, EventArgs e)
        {

        }
    }
}
