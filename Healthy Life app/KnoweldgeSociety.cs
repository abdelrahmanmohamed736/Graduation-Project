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
    public partial class KnoweldgeSociety : Form
    {
        public KnoweldgeSociety()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewKnowledgeSoceity NewKnowledgeSoceity = new NewKnowledgeSoceity();
            NewKnowledgeSoceity.ShowDialog();
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AskQuestion AskQuestion = new AskQuestion();
            AskQuestion.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
