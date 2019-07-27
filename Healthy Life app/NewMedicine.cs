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
    public partial class NewMedicine : Form
    {
        SqlConnection cn = new SqlConnection("Server =.;DataBase = HealthyLifeApp;Integrated Security = true");
        SqlCommand cmd;
        public NewMedicine()
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (Medname.Text == "" || MedDef.Text == "" || MedSide.Text == "" || MedUse.Text == "" || MedMethod.Text == "")
                {
                    MessageBox.Show(" (برجاء تعبئة حقول (اسم الدواء - التعريف بالدواء - الأعراض الجانبية للدواء - ماهي استخدامات الدواء - كيف استخدم الدواء ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                         try
                        {
                            cn.Open();
                            cmd = new SqlCommand("insert into Medecines_Table values ('" + Medname.Text + "','" + MedDef.Text + "','" + MedSide.Text + "','" + MedUse.Text + "','" + MedMethod.Text + "','" + UserInfo.instance.Email + "')", cn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show(" تم ارسال البيانات بنجاح .. جاري المعاينة ورفع الدواء للمنصة ");
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
