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
    public partial class NewAddedMedecines : Form
    {
        SqlConnection cn = new SqlConnection("Server =.;DataBase = HealthyLifeApp;Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader reader;
        public NewAddedMedecines()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select * from  Medecines_Table where Medecine_Name='" + comboBox1.SelectedItem + "' ", cn);
                cn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblMedName.Text = reader["Medecine_Name"].ToString();
                    lblMedName2.Text = reader["Medecine_Name"].ToString();
                    lblMedName3.Text = reader["Medecine_Name"].ToString();
                    lblMedName4.Text = reader["Medecine_Name"].ToString();

                    lblMedDef.Text = reader["Medecine_Definition"].ToString();
                    lblMedSide.Text = reader["Medecine_SideEffect"].ToString();
                    lblMedUses.Text = reader["Medecine_Uses"].ToString();
                    lblMedhow.Text = reader["Medecine_Methods"].ToString();
                   
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

        private void NewAddedMedecines_Load(object sender, EventArgs e)
        {
            getids();
        }
        public void getids()
        {
            comboBox1.Items.Clear();
            try
            {

                cmd = new SqlCommand("select Medecine_Name from Medecines_Table ", cn);
                cn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Medecine_Name"] == "")
                        continue;
                    comboBox1.Items.Add(reader["Medecine_Name"]);
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

        private void label11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medecines Medecines = new Medecines();
            Medecines.ShowDialog();
        }

        private void lblMedName4_Click(object sender, EventArgs e)
        {

        }
    }
}
