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
    public partial class AdminDashoard : Form
    {
        public AdminDashoard()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS01;Initial Catalog=studentRequestDB;Integrated Security=True");

        public void getLoggedUser()
        {
            con.Open();
            String query = "Select stf_names, stf_email from staffs where  stf_id ='" + LogInfo.logId + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            String stf_email = read["stf_email"].ToString();
            String stf_name = read["stf_names"].ToString();
            lbl_logged.Text = stf_email + " " + stf_name;
            con.Close();
        }

        public void fetchStudentInfo()
        {
            // create a tunnel to the db
            String query = "SELECT students.*,department.*,programs.* FROM students join department on students.d_id = department.d_id join programs on students.p_id = programs.p_id ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //create dataset to store your data
            DataSet ds = new DataSet();
            sda.Fill(ds, "students");
            // display data
            dgv_StudentInfo.AutoGenerateColumns = false;
            dgv_StudentInfo.DataSource = ds.Tables["students"];

        }

        private void dgv_particularStudentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminDashoard_Load(object sender, EventArgs e)
        {
            getLoggedUser();
            fetchStudentInfo();
        }

        private void btn_department_Click(object sender, EventArgs e)
        {
            Dapartment dp = new Dapartment();
            dp.Show();


        }

        private void lkl_department_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dapartment dp = new Dapartment();
            dp.Show();
        }

        private void btn_programST_Click(object sender, EventArgs e)
        {
            ProgramSt pst = new ProgramSt();
            pst.Show();
        }

        private void lbl_programSt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProgramSt pst = new ProgramSt();
            pst.Show();
        }
    }
}
