using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Ass2SRP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS01;Initial Catalog=studentRequestDB;Integrated Security=True");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       // VALIDATE EMAIL

        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        // CRYPT PASSWORD
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }


        private void lklb_to_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 sg = new Form1();
            sg.Show();
            this.Hide();
        }

        private void chB_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chB_showPassword.Checked == true)
            {
                txtB_LPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtB_LPassword.UseSystemPasswordChar = true;


            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String email = txtB_LEmail.Text;
            String password = txtB_LPassword.Text;
            if(email != "" && password != "")
            {
                bool validEmail = IsValidEmail(email);
                if (validEmail)
                {
                    password = MD5Hash(password);
                    //MessageBox.Show(password);
                    con.Open();

                    if (lbl_staff.Checked == false)
                    {
                        String query = "SELECT count(*) FROM students  WHERE st_email = '" +email+ "' AND st_password = '"+password+"'  AND st_status = 1 ";
                        SqlCommand cmd = new SqlCommand(query, con);
                        int countLog = Convert.ToInt32(cmd.ExecuteScalar());

                        if(countLog == 1)
                        {

                            try {

                                    //MessageBox.Show(countLog.ToString());
                                    String selectLog = "SELECT st_id FROM students WHERE st_email ='"+email+"' ";
                                    SqlCommand cmdLog = new SqlCommand(selectLog, con);
                                    object results = cmdLog.ExecuteScalar();
                                    String IdLog =results.ToString();

                                    LogInfo.logId = IdLog;
                                    StudentDashoard std = new StudentDashoard();
                                    std.Show();
                                    this.Hide();
                            } catch(Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            
                        }
                        else
                        {
                            lbl_errorMessage.Text = "User not found !!!";
                        }


                        
                    }
                    else
                    {
                        String query = "SELECT count(*) FROM staffs  WHERE stf_email = '" + email + "' AND stf_password = '" + password + "'  AND stf_status = 1 ";
                        SqlCommand cmd = new SqlCommand(query, con);
                        int countLog = Convert.ToInt32(cmd.ExecuteScalar());

                        if (countLog == 1)
                        {

                            try
                            {

                                //MessageBox.Show(countLog.ToString());
                                String selectLog = "SELECT stf_id FROM staffs WHERE stf_email ='" + email + "' ";
                                SqlCommand cmdLog = new SqlCommand(selectLog, con);
                                object results = cmdLog.ExecuteScalar();
                                String IdLog = results.ToString();

                                LogInfo.logId = IdLog;
                                AdminDashoard std = new AdminDashoard();
                                std.Show();
                                this.Hide();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }

                        }
                        else
                        {
                            lbl_errorMessage.Text = "User not found !!!";
                        }
                    }
                    

                }
                else
                {
                    lbl_errorMessage.Text = "Wrong email Format";
                }
            }
            else
            {
                lbl_errorMessage.Text = "Fillout all the above textfield !!";
            }

            con.Close();
        }

        private void lbl_errorMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
