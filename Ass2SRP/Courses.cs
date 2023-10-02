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
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS01;Initial Catalog=studentRequestDB;Integrated Security=True");
        public void fetchCourses()
        {
            // create a tunnel to the db
            String query = "SELECT * FROM  course";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //create dataset to store your data
            DataSet ds = new DataSet();
            sda.Fill(ds, "course");            
            // display data
            cB_courses .DataSource = ds.Tables["course"];
            cB_courses.DisplayMember = "cr_name";
            cB_courses.ValueMember = "cr_id";


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


        public void fetchCourse_Order_StudentInfo()
        {
            // create a tunnel to the db
            String query = "SELECT students.*,course_order.*,course.* FROM course_order join students on students.st_id = course_order.st_id join course on course.cr_id = course_order.cr_id WHERE students.st_id ='" + LogInfo.logId + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //create dataset to store your data
            DataSet ds = new DataSet();
            sda.Fill(ds, "course_order");
            // display data
            dgv_stCourse.AutoGenerateColumns = false;
            dgv_stCourse.DataSource = ds.Tables["course_order"];

        }
        private void Courses_Load(object sender, EventArgs e)
        {
            fetchCourses();
            getLoggedUser();
            fetchCourse_Order_StudentInfo();
        }

        private void btn_enrolment_Click(object sender, EventArgs e)
        {
            String semester = cB_semester.Text;
            int cr_id = Convert.ToInt32(cB_courses.SelectedValue);
            if(semester != "")
            {
                con.Open();
                String query = "insert into course_order(cr_id,st_id,cr_semester,cro_status) values("+cr_id+",'"+LogInfo.logId+"','"+semester+"',1)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Enroled successfully !!!");
                fetchCourse_Order_StudentInfo();
                con.Close();

            }
        }
    }
}
