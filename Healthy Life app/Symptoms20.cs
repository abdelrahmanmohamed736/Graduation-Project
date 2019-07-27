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
    public partial class Symptoms20 : Form
    {
        public Symptoms20()
        {
            InitializeComponent();
        }

        private void Symptoms20_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Symptoms Symptoms = new Symptoms();
            Symptoms.ShowDialog();
        }
    }
}
