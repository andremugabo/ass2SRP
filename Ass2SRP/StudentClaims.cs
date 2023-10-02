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
    public partial class StudentClaims : Form
    {
        public StudentClaims()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS01;Initial Catalog=studentRequestDB;Integrated Security=True");
        public void getLoggedUser()
        {
            con.Open();
            String query = "Select st_names, st_reg from students where  st_id ='" + LogInfo.logId + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            String st_reg = read["st_reg"].ToString();
            String st_name = read["st_names"].ToString();
            lbl_logged_info.Text = st_reg + " " + st_name;
            con.Close();
        }

        public void fetchParticularClaims()
        {
            //con.Open();
            // create a tunnel to the db
            String query = "SELECT students.*,claims.* FROM claims join students on students.st_id = claims.st_id  WHERE students.st_id =" + LogInfo.logId + " ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //create dataset to store your data
            DataSet ds = new DataSet();
            sda.Fill(ds, "claims");
            // display data
            dgv_claims.AutoGenerateColumns = false;
            dgv_claims.DataSource = ds.Tables["claims"];

            //con.Close();

        }



        private void StudentClaims_Load(object sender, EventArgs e)
        {
            getLoggedUser();
            fetchParticularClaims();
        }

        private void btn_claim_Click(object sender, EventArgs e)
        {
            String claims = txt_claim.Text;
            DateTime currentDateTime = DateTime.Now;
            string cl_date = currentDateTime.ToString("yyyy MMMM dd");

            if (claims != "")
            {
                String query = "INSERT INTO claims(st_id,cl_name,cl_status,cl_date) values('"+LogInfo.logId+"','"+claims+ "','Pedding','"+cl_date+"')";
                SqlCommand cmd = new SqlCommand(query,con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Claim sent successfully");
                fetchParticularClaims();
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill out your Claim");
            }
        }
    }
}
