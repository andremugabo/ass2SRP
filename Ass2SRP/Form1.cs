using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net.Mail;

namespace Ass2SRP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS01;Initial Catalog=studentRequestDB;Integrated Security=True");

        public void DisplayDepartment()
        {
            // create a tunnel to the the db
            String query = "SELECT * FROM department";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            //Create a data to store 
            DataSet ds = new DataSet();
            da.Fill(ds, "department");
            //display the data
            cBox_department.DataSource = ds.Tables["department"];
            cBox_department.DisplayMember = "d_name";
            cBox_department.ValueMember = "d_id";

        }

        public void DisplayProgram()
        {
            //create tunnel to the db
            String query = "SELECT * FROM programs";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //create a data store 
            DataSet ds = new DataSet();
            sda.Fill(ds, "programs");
            //display the data
            cBox_program.DataSource = ds.Tables["programs"];
            cBox_program.DisplayMember = "p_name";
            cBox_program.ValueMember = "p_id";
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


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtB_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtB_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtB_names_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtB_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //String ID = txtB_id.Text;
            String names = txtB_names.Text;
            String email = txtB_email.Text;
            String password = txtB_password.Text;
            int d_id = Convert.ToInt32(cBox_department.SelectedValue);
            int p_id = Convert.ToInt32(cBox_program.SelectedValue);
            String reg_number = null;


            if (names != "" && email != "" && password != "")
            {
                String selectQuery = "SELECT count(*) FROM students";
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                con.Open();
                int countStudents = Convert.ToInt32(cmd.ExecuteScalar());
                //MessageBox.Show(countStudents.ToString());
                if (countStudents >= 0 && countStudents < 10)
                {
                    countStudents++;
                    reg_number = "St-0000" + countStudents;

                }
                else if (countStudents >= 10 && countStudents < 100)
                {
                    countStudents++;
                    reg_number = "St-000" + countStudents;
                }
                else if (countStudents >= 100 && countStudents < 1000)
                {
                    countStudents++;
                    reg_number = "St-00" + countStudents;
                }
                else if (countStudents >= 1000 && countStudents < 10000)
                {
                    countStudents++;
                    reg_number = "St-0" + countStudents;
                }
                else
                {
                    countStudents++;
                    reg_number = "St-" + countStudents;
                }

                password = MD5Hash(password);
                //MessageBox.Show(password);
                bool isValidEmail = IsValidEmail(email);
                // MessageBox.Show(isValidEmail.ToString());

                if (isValidEmail)
                {
                    String checkIfExistEmail = "SELECT count(*) FROM students where st_email = '"+email+"'";
                    SqlCommand cmdCheckmail = new SqlCommand(checkIfExistEmail, con);
                    int howManyTimeEmail = Convert.ToInt32(cmdCheckmail.ExecuteScalar());

                    if (howManyTimeEmail == 0)
                    {

                        try
                        {
                            String query = "INSERT INTO students(st_names,st_email,st_password,d_id,p_id,st_status,st_reg) VALUES('" + names + "','" + email + "','" + password + "'," + d_id + "," + p_id + "," + 1 + ",'" + reg_number + "')";
                            SqlCommand cmdCreate_st = new SqlCommand(query, con);
                            cmdCreate_st.ExecuteNonQuery();
                            MessageBox.Show("Student with  " + email + " Created");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }


                    }
                    else
                    {
                        MessageBox.Show("Sorry STUDENT WITH " + email + " Allready Exist ");
                    }






                    //SqlCommand cmdInsert = new SqlCommand(query, con);
                    //cmdInsert.ExecuteNonQuery();


                }
                else
                {
                    //MessageBox.Show("Wrong format of Email Try again");
                    lbl_error_message.Text = "Wrong format of Email Try again !!";
                }



                //MessageBox.Show(ID + " " + names + " " + email + " " + password + " " + d_id + " " + p_id);

            }
            else
            {
                lbl_error_message.Text = "Fill out all the above fieldText !!";
            }

            con.Close();

        }

        private void lklb_to_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDepartment();
            DisplayProgram();
        }

        private void lbl_error_message_Click(object sender, EventArgs e)
        {

        }

        private void chB_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chB_showPassword.Checked == true)
            {
                txtB_password.UseSystemPasswordChar = false;
            }
            else
            {

                txtB_password.UseSystemPasswordChar = true;
            }
        }
    }
}
