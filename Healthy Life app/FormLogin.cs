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
    public partial class FormLogin : Form
    {
        SqlConnection cn = new SqlConnection("Server =.;DataBase = HealthyLifeApp;Integrated Security = true"); // اتصال 
        SqlCommand cmd;// الامر اللى بيتنفذ
        SqlDataReader reader;// قراية البياانات اللى بتيجى من الداتا
        public FormLogin()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister FormRegister = new FormRegister();
            FormRegister.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormForgetPass FormForgetPass = new FormForgetPass();
            FormForgetPass.ShowDialog();
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show(" (برجاء تعبئة حقلي (الإسم و رمز الحماية ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // try ... catch بينفذ السطور اللى جوه try 
                // ولو فيه اى مشكلة فيهم بيقف وينفذ اللى جوه كاتش
                try
                {
                    cmd = new SqlCommand("Select * from UsersLogin_Table where User_Email ='" + txtuser.Text + "' and Password='" + txtpass.Text + "'", cn);
                    cn.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["State"].ToString() == "False")
                        {
                            MessageBox.Show("Locked");
                            return;
                        }
                        // user table
                        UserInfo.instance = new UserInfo()
                        {
                            Email = txtuser.Text,
                            Type = reader["UserType"].ToString() == "طبيب" ? UserType.Doctor:UserType.User
                        };
                        this.Hide();
                        reader.Close();

                        cmd = new SqlCommand("Select * from Registeration_Table where UserEmail ='" + txtuser.Text + "'", cn);
                        reader = cmd.ExecuteReader();
                        // read common data
                        if(reader.Read())
                        {
                            UserInfo.instance.Name = reader["User_Name"].ToString();
                            UserInfo.instance.Date = DateTime.Parse(reader["User_Date"].ToString());
                            UserInfo.instance.Phone = reader["User_Phone"].ToString();
                            UserInfo.instance.Gender = reader["User_Gender"].ToString();
                        }
                        reader.Close();

                        if(UserInfo.instance.Type == UserType.Doctor)
                        {
                            cmd = new SqlCommand("Select * from ComDr_Table where UserEmail ='" + txtuser.Text + "'", cn);
                            reader = cmd.ExecuteReader();
                            // read Doctor table data
                            if (reader.Read())
                            {
                                UserInfo.instance.DocSpecialization = reader["specialization"].ToString();
                                UserInfo.instance.clinic_location = reader["clinic_location"].ToString();
                                UserInfo.instance.hrworks = reader["hrworks"].ToString();
                            }
                            reader.Close();
                            FormPartsMedicalDoctorAccess f2 = new FormPartsMedicalDoctorAccess();
                            f2.ShowDialog();
                        }
                        else
                        {
                            FormPartsMedical f2 = new FormPartsMedical();
                            f2.ShowDialog();
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("برجاء التأكد من كتابة الإسم ورمز الحماية بشكل صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("خطأ", "message Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cn.Close();
                    reader.Close();
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
