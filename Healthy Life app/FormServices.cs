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
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
            lbluser.Text = UserInfo.instance.Name;
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void FormServices_Load(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuCustomTextbox1_HideSelectionChanged(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonHealth_Click(object sender, EventArgs e)
        {

        }

        private void labelMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            if (UserInfo.instance.Type == UserType.Doctor)
            {
                this.Hide();
                FormMyAccount FormMyAccount = new FormMyAccount();
                FormMyAccount.ShowDialog();
            }
            else
            {
                this.Hide();
                FormMyAccount FormMyAccount = new FormMyAccount();
                FormMyAccount.ShowDialog();
            }
        }

        private void buttonParts_Click(object sender, EventArgs e)
        {
            if (UserInfo.instance.Type == UserType.Doctor)
            {
                this.Hide();
                FormPartsMedicalDoctorAccess f2 = new FormPartsMedicalDoctorAccess();
                f2.ShowDialog();
            }
            else
            {
                this.Hide();
                FormPartsMedical f2 = new FormPartsMedical();
                f2.ShowDialog();
            }
        }

        private void buttonHealth_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormConsulting FormConsulting = new FormConsulting();
            FormConsulting.ShowDialog();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
        }
    }
}
