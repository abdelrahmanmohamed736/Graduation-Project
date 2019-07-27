using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Healthy_Life_app
{
    public partial class NewAddedSymptoms : Form
    {
        SqlConnection cn = new SqlConnection("Server =.;DataBase = HealthyLifeApp;Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader reader;
        public NewAddedSymptoms()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select * from  Symptoms_Table where Symptom_Name ='" + comboBox1.SelectedItem + "' ", cn);
                cn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblMedName.Text = reader["Symptom_Name"].ToString();
                    lblMedName2.Text = reader["Symptom_Name"].ToString();
                    lblMedName3.Text = reader["Symptom_Name"].ToString();
                    lblMedName4.Text = reader["Symptom_Name"].ToString();

                    lblMedDef.Text = reader["Symptom_Definition"].ToString();
                    lblMedSide.Text = reader["Symptom_Reasons"].ToString();
                    lblMedUses.Text = reader["Symptom_Apearance"].ToString();
                    lblMedhow.Text = reader["Symptom_Treatment"].ToString();

                }
            }
            catch
            {

            }
            finally
            {
                cn.Close();
                reader.Close();
            }
        }

        private void NewAddedSymptoms_Load(object sender, EventArgs e)
        {
            getids();
        }
        public void getids()
        {
            comboBox1.Items.Clear();
            try
            {

                cmd = new SqlCommand("select Symptom_Name from Symptoms_Table ", cn);
                cn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Symptom_Name"] == "")
                        continue;
                    comboBox1.Items.Add(reader["Symptom_Name"]);
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Symptoms Symptoms = new Symptoms();
            Symptoms.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
