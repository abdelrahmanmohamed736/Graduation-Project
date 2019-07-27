using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Healthy_Life_app
{
    public partial class FormForgetPass : Form
    {
        SqlConnection cn = new SqlConnection("Server =.;DataBase = HealthyLifeApp;Integrated Security = true"); // اتصال 
        SqlCommand cmd;// الامر اللى بيتنفذ
        SqlDataReader reader;// قراية البياانات اللى بتيجى من الداتا
        // OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Healthy Life app\Healthy Life app\HealThyLife.accdb");
        public FormForgetPass()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsulting FormConsulting = new FormConsulting();
            FormConsulting.ShowDialog();
        }

        private void buttonParts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPartsMedical FormPartsMedical = new FormPartsMedical();
            FormPartsMedical.ShowDialog();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormServices FormServices = new FormServices();
            FormServices.ShowDialog();
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select * from UsersLogin_Table where User_Email='" + txtemail.Text + "'",cn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    cmd = new SqlCommand("update UsersLogin_Table set Password='" + txtPass.Text + "' where User_Email = '" + txtemail.Text + "'", cn); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" رائع .. تم حفظ رمز الحماية الجديد");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "message Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                reader.Close();
            }
        }
            
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
    


