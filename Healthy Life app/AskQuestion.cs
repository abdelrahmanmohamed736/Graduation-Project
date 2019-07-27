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
    public partial class AskQuestion : Form
    {
        SqlConnection cn = new SqlConnection("Server =.;DataBase = HealthyLifeApp;Integrated Security = true"); // اتصال 
        SqlCommand cmd;// الامر اللى بيتنفذ
        public AskQuestion()
        {
            InitializeComponent();
        }

        private void txtuser_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            KnoweldgeSociety KnoweldgeSociety = new KnoweldgeSociety();
            KnoweldgeSociety.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void AskQuestion_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "")
            {
                MessageBox.Show(" غير ممكن ترك النص فارغاً ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // try ... catch بينفذ السطور اللى جوه try 
                // ولو فيه اى مشكلة فيهم بيقف وينفذ اللى جوه كاتش
                try
                {
                    
                    cn.Open();
                    cmd = new SqlCommand("insert into Knowledge_Table(Question,Visitor_Email) values ('" + txtQuestion.Text + "','" + UserInfo.instance.Email +"')", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" تم ارسال السؤال بنجاح .. جاري المعاينة وتلقي الاجابة بأسرع وقت ");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("خطأ", "message Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
