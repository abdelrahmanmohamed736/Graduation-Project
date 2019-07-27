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
    public partial class FormMyAccount : Form
    {
        SqlConnection cn = new SqlConnection("Server =.;DataBase = HealthyLifeApp;Integrated Security = true");
        SqlCommand cmd;
        public FormMyAccount()
        {
            InitializeComponent();
            lbluser.Text = UserInfo.instance.Name;
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (UserInfo.instance.Type == UserType.Doctor)
            {
                this.Hide();
                FormPartsMedicalDoctorAccess f2 = new FormPartsMedicalDoctorAccess();
                f2.ShowDialog();
            }
            else
            {
                this.Hide();
                FormPartsMedical f2 = new FormPartsMedical();
                f2.ShowDialog();
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormServices FormServices = new FormServices();
            FormServices.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboR_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void buttonHealth_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsulting FormConsulting = new FormConsulting();
            FormConsulting.ShowDialog();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtClinic_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormServices FormServices = new FormServices();
            FormServices.ShowDialog();
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {

        }


        string gender = "";

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            try
            {
                gender = radioMan.Checked ? "ذكر" : "انثى";
                cn.Open();
                cmd = new SqlCommand("update UsersLogin_Table set Password='" + txtPass.Text + "' where User_Email = '"+UserInfo.instance.Email+"'", cn); // مش عارف احط الجيندر
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("update Registeration_Table set User_Name='" + txtFullName.Text + "',User_Date='" +
                    Birthdate.Value.ToShortDateString() + "',User_Phone='"
                    + txtPhoneNum.Text + "',User_Gender='" + gender + "' where UserEmail = '" + UserInfo.instance.Email + "'", cn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("update ComDr_Table set clinic_location='" + txtClinic.Text
                    + "',hrworks='" + txthrs.Text + "',specialization='" + txtSpecialize.Text + "' where UserEmail = '" + UserInfo.instance.Email + "'", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("رائع تم تعديل البيانات بنجاح برجاء اعادة تسجيل الدخول مرة اخري");
                this.Hide();
                FormLogin f2 = new FormLogin();
                f2.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void FormMyAccount_Load(object sender, EventArgs e)
        {          
            if (UserInfo.instance.Type == UserType.Doctor)
            {
                RadioDoc_Click(this, new EventArgs());
                txtSpecialize.Text = UserInfo.instance.DocSpecialization;
                txthrs.Text = UserInfo.instance.hrworks;
                txtClinic.Text = UserInfo.instance.clinic_location;
            }
            else
            {
                RadioUser_Click(this, new EventArgs());
            }
            txtFullName.Text = UserInfo.instance.Name;
            txtPhoneNum.Text = UserInfo.instance.Phone;
            Birthdate.Value = UserInfo.instance.Date;
            Birthdate.Refresh();
            if (UserInfo.instance.Gender == "ذكر")
            {
                radioMan.Checked = true;
                radioWoman.Checked = false;
            }               
            else
            {
                radioWoman.Checked = true;
                radioMan.Checked = false;
            }
                
        }

        private void RadioUser_Click(object sender, EventArgs e)
        {

                txtClinic.Visible = false;
                txthrs.Visible = false;
                txtSpecialize.Visible = false;
                label12.Visible = false;
                label1.Visible = false;
                label16.Visible = false;

        }

        private void RadioDoc_Click(object sender, EventArgs e)
        {

                txtClinic.Visible = true;
                txthrs.Visible = true;
                txtSpecialize.Visible = true;
                label12.Visible = true;
                label1.Visible = true;
                label16.Visible = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure ?", "HealthyLife", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    cn.Open();
                    cmd = new SqlCommand("update UsersLogin_Table set State='False' where User_Email = '" + UserInfo.instance.Email + "'", cn); // مش عارف احط الجيندر
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم تعطيل هذا الحساب فحالة الاسترداد برجاء التواصل معنا");
                    this.Hide();
                    FormLogin f2 = new FormLogin();
                    f2.ShowDialog();
                    this.Close();
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

        private void pncontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        //private class
        //{
            //if (RadioDoc.Checked == true)
            //{
            //    con.Open();
            //    OleDbCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text;
            //    if (radioMan.Checked == true)
            //    {

            //        cmd.CommandText = "insert into Doctor values ('" + txtFullName.Text + "','" + txtPass.Text + "','" + txtemail.Text + "','" + maskedTextBox1.Text + "','" + bunifuMaterialTextbox1.Text + "','" + label14.Text + "','" + txtClinic.Text + "')";
            //    }

            //    else
            //    {
            //        cmd.CommandText = "insert into Doctor values ('" + txtFullName.Text + "','" + txtPass.Text + "','" + txtemail.Text + "','" + maskedTextBox1.Text + "','" + bunifuMaterialTextbox1.Text + "','" + label13.Text + "','" + txtClinic.Text + "')";
            //    }

            //    cmd.ExecuteNonQuery();
            //    con.Close();

            //}
            //this.Hide();
            //FormForgetPass f1 = new FormForgetPass();
            //f1.Show();
            //if (RadioUser.Checked == true)
            //{
            //    con.Open();
            //    OleDbCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text;
            //    if (RadioUser.Checked == true)
            //    {

            //        cmd.CommandText = "insert into Visit values ('" + txtFullName.Text + "','" + txtPass.Text + "','" + txtemail.Text + "','" + bunifuMaterialTextbox1.Text + "','" + maskedTextBox1.Text + "','" + label14.Text + "')";
            //    }

            //    else
            //    {
            //        cmd.CommandText = "insert into Visit values ('" + txtFullName.Text + "','" + txtPass.Text + "','" + txtemail.Text + "','" + bunifuMaterialTextbox1.Text + "','" + maskedTextBox1.Text + "','" + label13.Text + "')";
            //    }

            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
            //this.Hide();
            //FormForgetPass f2 = new FormForgetPass();
            //f2.Show();
        //}
    }
}
