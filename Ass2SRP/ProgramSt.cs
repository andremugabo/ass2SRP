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
    public partial class ProgramSt : Form
    {
        public ProgramSt()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS01;Initial Catalog=studentRequestDB;Integrated Security=True");
        int indexRow;

        public void DisplayProgram()
        {
            // create a tunnel to the the db
            String query = "SELECT * FROM programs";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            //Create a data to store 
            DataSet ds = new DataSet();
            da.Fill(ds, "programs");
            //display the data
            cBox_department.DataSource = ds.Tables["programs"];
            cBox_department.DisplayMember = "p_name";
            cBox_department.ValueMember = "p_id";

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
        private void ProgramSt_Load(object sender, EventArgs e)
        {
            DisplayProgram();
            getLoggedUser();
            fetchStudentInfo();
        }

        private void ProgramSt_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_StudentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_StudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_StudentInfo.Rows[indexRow];
            txtB_id.Text = row.Cells[2].Value.ToString();
            cBox_department.Text = row.Cells[4].Value.ToString();
        }

        private void btn_editProgram_Click(object sender, EventArgs e)
        {
            String st_reg = txtB_id.Text;
            int p_id = Convert.ToInt32(cBox_department.SelectedValue);
            if (st_reg != "")
            {
                String query = "UPDATE students set p_id = " + p_id + " where st_reg = '" + st_reg + "'";
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
    }
}
