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
    public partial class StudentDashoard : Form
    {
        public StudentDashoard()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS01;Initial Catalog=studentRequestDB;Integrated Security=True");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentClaims stc = new StudentClaims();
            stc.Show();

        }

        public void getLoggedUser()
        {
            con.Open();
            String query = "Select st_names, st_reg from students where  st_id ='" + LogInfo.logId + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            String st_reg = read["st_reg"].ToString();
            String st_name = read["st_names"].ToString();
            lbl_logged.Text = st_reg + " " + st_name;
            con.Close();
        }

        public void fetchParticularStudentInfo()
        {
            // create a tunnel to the db
            String query = "SELECT students.*,department.*,programs.* FROM students join department on students.d_id = department.d_id join programs on students.p_id = programs.p_id WHERE st_id ='"+LogInfo.logId+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            //create dataset to store your data
            DataSet ds = new DataSet();
            sda.Fill(ds, "students");
            // display data
            dgv_particularStudentInfo.AutoGenerateColumns = false;
            dgv_particularStudentInfo.DataSource = ds.Tables["students"];

         }
        private void StudentDashoard_Load(object sender, EventArgs e)
        {

            getLoggedUser();
            fetchParticularStudentInfo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentClaims stc = new StudentClaims();
            stc.Show();
        }
    }
}
