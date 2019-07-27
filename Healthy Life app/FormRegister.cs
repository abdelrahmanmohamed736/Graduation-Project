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
    public partial class FormRegister : Form
    {
        SqlConnection cn = new SqlConnection("Server =.;DataBase = HealthyLifeApp;Integrated Security = true");
        SqlCommand cmd;
        public FormRegister()
        {

            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPartsMedical FormPartsMedical = new FormPartsMedical();
            FormPartsMedical.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormServices FormServices = new FormServices();
            FormServices.ShowDialog();
        }

        //private void bunifuThinButton21_Click(object sender, EventArgs e)
        //{
        //    //مينا كود الاكسس
        //    if (RadioDoc.Checked == true)
        //    {
        //        con.Open();
        //        OleDbCommand cmd = con.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        if (radioMan.Checked == true)
        //        {

        //            cmd.CommandText = "insert into Doctor values ('" + txtFullName.Text + "','" + txtPass.Text + "','" + txtemail.Text + "','" + maskedTextBox1.Text + "','" + bunifuMaterialTextbox1.Text + "','" + label14.Text + "','" + txtClinic.Text + "')";
        //        }

        //        else
        //        {
        //            cmd.CommandText = "insert into Doctor values ('" + txtFullName.Text + "','" + txtPass.Text + "','" + txtemail.Text + "','" + maskedTextBox1.Text + "','" + bunifuMaterialTextbox1.Text + "','" + label13.Text + "','" + txtClinic.Text + "')";
        //        }

        //        cmd.ExecuteNonQuery();
        //        con.Close();

        //    }
        //    this.Hide();
        //    FormForgetPass f1 = new FormForgetPass();
        //    f1.Show();
        //    if (RadioUser.Checked == true)
        //    {
        //        con.Open();
        //        OleDbCommand cmd = con.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        if (RadioUser.Checked == true)
        //        {

        //            cmd.CommandText = "insert into Visit values ('" + txtFullName.Text + "','" + txtPass.Text + "','" + txtemail.Text + "','" + bunifuMaterialTextbox1.Text + "','" + maskedTextBox1.Text + "','" + label14.Text + "')";
        //        }

        //        else
        //        {
        //            cmd.CommandText = "insert into Visit values ('" + txtFullName.Text + "','" + txtPass.Text + "','" + txtemail.Text + "','" + bunifuMaterialTextbox1.Text + "','" + maskedTextBox1.Text + "','" + label13.Text + "')";
        //        }

        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //    }
        //    this.Hide();
        //    FormForgetPass f2 = new FormForgetPass();
        //    f2.Show();
        //}

        private void buttonHealth_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsulting FormConsulting = new FormConsulting();
            FormConsulting.ShowDialog();
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

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormServices FormServices = new FormServices();
            FormServices.ShowDialog();
        }

        private void RadioUser_Click(object sender, EventArgs e)
        {
            if (RadioUser.Checked == true)
            {
                txtClinic.Visible = false;
                txthrs.Visible = false;
                txtSpecialize.Visible = false;
                label12.Visible = false;
                label1.Visible = false;
                label16.Visible = false;
            }
           
        }

        private void RadioDoc_Click(object sender, EventArgs e)
        {
            if (RadioDoc.Checked == true)
            {
                txtClinic.Visible = true;
                txthrs.Visible = true;
                txtSpecialize.Visible = true;
                label12.Visible = true;
                label1.Visible = true;
                label16.Visible = true;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (!animation1.IsCompleted) return;
            if (Menu.Width == 60)
            {
                Menu.Visible = false;
                Menu.Width = 266;
                animation1.ShowSync(Menu);
            }
            else
            {
                Menu.Visible = false;
                Menu.Width = 60;
                animation1.ShowSync(Menu);
            }
        }

        string user_type = "";
        string gender = "";

        private void btnConfig_Click(object sender, EventArgs e)
        {

            gender = radioMan.Checked ? "ذكر" : "انثى";
            if (RadioUser.Checked == true)
            {
                if (txtFullName.Text == "" || txtPass.Text == "" || txtemail.Text == "")
                {
                    MessageBox.Show(" (برجاء تعبئة حقول (الإسم - الباسوورد - الإيميل ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    user_type = "زائر";              
                    try
                    {
                        cn.Open();
                        cmd = new SqlCommand("insert into UsersLogin_Table values ('" + txtemail.Text + "','" + txtPass.Text + "','" + user_type + "','True')", cn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into Registeration_Table values ('" + txtFullName.Text + "','" + Birthdate.Value.ToShortDateString() + "','" + txtPhoneNum.Text + "','" 
                            + gender + "','" + txtemail.Text + "')", cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" تم حفظ البيانات بنجاح .. برجاء اعادة تسجيل الدخول ");
                        this.Hide();
                        FormLogin f2 = new FormLogin();
                        f2.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show(" خطأ ! برجاء ادخال البيانات بشكل صحيح ");
                    }
                    finally
                    {
                        cn.Close();
                    }
                   
                }
            }

            if (RadioDoc.Checked == true)
            {
                if (txtFullName.Text == "" || txtPass.Text == "" || txtemail.Text == "" || txtPhoneNum.Text == "" || txtSpecialize.Text == "")
                {
                    MessageBox.Show(" ( برجاء تعبئة حقول (الإسم - الباسوورد - الإيميل - رقم الهاتف - التخصص", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    user_type = "طبيب";
                    try
                    {
                        cn.Open();
                        cmd = new SqlCommand("insert into UsersLogin_Table values ('" + txtemail.Text + "','" + txtPass.Text + "','" + user_type + "','True')", cn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into Registeration_Table values ('" + txtFullName.Text + "','" + Birthdate.Value.ToShortDateString() + "','" + txtPhoneNum.Text + "','" + gender + "','" + txtemail.Text + "')", cn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into ComDr_Table values ('" + txtClinic.Text + "','" + txthrs.Text + "','" + txtSpecialize.Text + "','" + txtemail.Text + "')", cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" تم حفظ البيانات بنجاح .. برجاء اعادة تسجيل الدخول ");
                        this.Hide();
                        FormLogin f2 = new FormLogin();
                        f2.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show(" خطأ ! برجاء ادخال البيانات بشكل صحيح ");
                    }
                    finally
                    {
                        cn.Close();
                    }
                   
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            String imageLocation = ""; 
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*"﻿;

                if (dialog.ShowDialog () == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    UserPic.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("عذرا لقد حدث خطأ ما .. برجاء اعادة المحاولة", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pncontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtemail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
