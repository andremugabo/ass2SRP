using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass2SRP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lklb_to_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 sg = new Form1();
            sg.Show();
            this.Hide();
        }
    }
}
