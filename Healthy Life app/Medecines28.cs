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
    public partial class Medecines28 : Form
    {
        public Medecines28()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medecines Medecines = new Medecines();
            Medecines.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
    }
}
