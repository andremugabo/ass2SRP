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
            SqlDataAdapter da = new SqlDataAdapter(query,con);
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
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            //create a data store 
            DataSet ds = new DataSet();
            sda.Fill(ds, "programs");
            //display the data
            cBox_program.DataSource = ds.Tables["programs"];
            cBox_program.DisplayMember = "p_name";
            cBox_program.ValueMember = "p_id";
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
    }
}
