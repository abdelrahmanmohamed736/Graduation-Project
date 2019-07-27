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
    public partial class NewKnowledgeSoceity : Form
    {
        SqlConnection cn = new SqlConnection("Server =.;DataBase = HealthyLifeApp;Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader reader;
        public NewKnowledgeSoceity()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            KnoweldgeSociety KnoweldgeSociety = new KnoweldgeSociety();
            KnoweldgeSociety.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

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
                    label1.Text = reader["Question_Specialize"].ToString();
                    label2.Text = reader["Question"].ToString();
                    label6.Text = reader["Answer"].ToString();
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

        private void NewKnowledgeSoceity_Load(object sender, EventArgs e)
        {
            getids();
        }
        public void getids()
        {
            comboBox1.Items.Clear();
            try
            {

                cmd = new SqlCommand("select QID from Knowledge_Table ", cn);
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

    }
}
