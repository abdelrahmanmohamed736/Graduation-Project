using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Healthy_Life_app.Classes;

namespace Healthy_Life_app
{
    public partial class AnswersQuestions : Form
    {
        SqlConnection cn = new SqlConnection("Server =.;DataBase = HealthyLifeApp;Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader reader;
        public AnswersQuestions()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPartsMedicalDoctorAccess FormPartsMedicalDoctorAccess = new FormPartsMedicalDoctorAccess();
            FormPartsMedicalDoctorAccess.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select * from  Knowledge_Table where QID='" + comboBox1.SelectedItem + "' ", cn);
                cn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    label1.Text = reader["Question"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                cn.Close();
                reader.Close();
            }
        }

        private void AnswersQuestions_Load(object sender, EventArgs e)
        {
            getids();
        }

        public void getids()
        {
            comboBox1.Items.Clear();
            try
            {

                cmd = new SqlCommand("select QID from Knowledge_Table where Done ='False'", cn);
                cn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToInt64(reader["QID"]) == 0)
                        continue;
                    comboBox1.Items.Add(reader["QID"]);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                cn.Close();
                reader.Close();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("update Knowledge_Table set Question_Specialize='"
                    + txtSpecialize.Text + "',Answer='" + txtAnswer.Text + "',Doctor_Email='" + UserInfo.instance.Email + "',Done='True' where QID = " + comboBox1.SelectedItem.ToString()+ "", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Done ");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                cn.Close();

            }
            getids();
        }

    }
}
