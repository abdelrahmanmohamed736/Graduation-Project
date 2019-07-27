using Healthy_Life_app.Classes;
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
    public partial class FormPartsMedical : Form
    {
        public FormPartsMedical()
        {
            InitializeComponent();
            lbluser.Text = UserInfo.instance.Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (!animation1.IsCompleted) return;
            if (Menu.Width == 54)
            {
                Menu.Visible = false;
                Menu.Width = 266;
                animation1.ShowSync(Menu);
            }
            else
            {
                Menu.Visible = false;
                Menu.Width = 54;
                animation1.ShowSync(Menu);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            KnoweldgeSociety KnoweldgeSociety = new KnoweldgeSociety();
            KnoweldgeSociety.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Symptoms Symptoms = new Symptoms();
            Symptoms.ShowDialog();
        }

        private void bunifuPictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pncontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstAids FirstAids = new FirstAids();
            FirstAids.ShowDialog();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medecines Medecines = new Medecines();
            Medecines.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            HospitalsInfo HospitalsInfo = new HospitalsInfo();
            HospitalsInfo.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            MiniaDoctors MiniaDoctors = new MiniaDoctors();
            MiniaDoctors.ShowDialog();
        }

        private void labelMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMyAccount FormMyAccount = new FormMyAccount();
            FormMyAccount.ShowDialog();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormServices FormServices = new FormServices();
            FormServices.ShowDialog();
        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }
    }
}
