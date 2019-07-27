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
    public partial class NewSymptoms : Form
    {
        SqlConnection cn = new SqlConnection("Server =.;DataBase = HealthyLifeApp;Integrated Security = true");
        SqlCommand cmd;
        public NewSymptoms()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPartsMedicalDoctorAccess FormPartsMedicalDoctorAccess = new FormPartsMedicalDoctorAccess();
            FormPartsMedicalDoctorAccess.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (Medname.Text == "" || MedDef.Text == "" || MedSide.Text == "" || MedUse.Text == "" || MedMethod.Text == "")
            {
                MessageBox.Show(" (برجاء تعبئة حقول (اسم الداء - التعريف بالداء - اسباب حدوث الداء - ماهي علامات ظهور الداء - كيفية علاج الداء ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    cn.Open();
                    cmd = new SqlCommand("insert into Symptoms_Table values ('" + Medname.Text + "','" + MedDef.Text + "','" + MedSide.Text + "','" + MedUse.Text + "','" 
                        + MedMethod.Text + "','" + UserInfo.instance.Email + "')", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" تم ارسال البيانات بنجاح .. جاري المعاينة ورفع الداء للمنصة ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}
