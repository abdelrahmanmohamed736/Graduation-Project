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
    public partial class FormPartsMedicalDoctorAccess : Form
    {
        public FormPartsMedicalDoctorAccess()
        {
            InitializeComponent();
            lbluser.Text = UserInfo.instance.Name;
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

        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnswersQuestions AnswersQuestions = new AnswersQuestions();
            AnswersQuestions.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewSymptoms NewArticle = new NewSymptoms();
            NewArticle.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewMedicine NewMedicine = new NewMedicine();
            NewMedicine.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPartsMedical FormPartsMedical = new FormPartsMedical();
            FormPartsMedical.ShowDialog();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMyAccount FormMyAccount = new FormMyAccount();
            FormMyAccount.ShowDialog();
        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }

        private void FormPartsMedicalDoctorAccess_Load(object sender, EventArgs e)
        {

        }
    }
}
