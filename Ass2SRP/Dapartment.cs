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
    public partial class Dapartment : Form
    {
        public Dapartment()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS01;Initial Catalog=studentRequestDB;Integrated Security=True");
        int indexRow;

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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_StudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_StudentInfo.Rows[indexRow];
            txtB_id.Text = row.Cells[2].Value.ToString();
            cBox_department.Text = row.Cells[3].Value.ToString();
        }

        private void Dapartment_Load(object sender, EventArgs e)
        {
            DisplayDepartment();
            fetchStudentInfo();
            getLoggedUser();
        }

        public void getLoggedUser()
        {
            con.Open();
            String query = "Select stf_names, stf_email from staffs where  stf_id ='" + LogInfo.logId + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            String stf_email = read["stf_email"].ToString();
            String stf_name = read["stf_names"].ToString();
            lbl_logged_info.Text = stf_email + " " + stf_name;
            con.Close();
        }
        private void btn_editDepartment_Click(object sender, EventArgs e)
        {
            String st_reg = txtB_id.Text;
            int d_id = Convert.ToInt32(cBox_department.SelectedValue);
            if(st_reg != "")
            {
                String query = "UPDATE students set d_id = "+d_id+" where st_reg = '"+st_reg+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated succesfully");
                con.Close();
                fetchStudentInfo();

            }
            else
            {
                lbl_error.Text = "Fill out all text field !!!!";
            }
        }

        private void lbl_logged_info_Click(object sender, EventArgs e)
        {

        }
    }
}
