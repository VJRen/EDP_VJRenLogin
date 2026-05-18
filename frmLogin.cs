using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TelanLaurenJamesBsit2D
{
    public partial class Login : Form
    {
        MyDatabase db = new MyDatabase();
        public Login()
        {
            InitializeComponent();
        }

        private void tblogin_Click(object sender, EventArgs e)
        {
            if (tbusername.Text == "" || tbpassword.Text == "")
            {
                if (tbusername.Text == "")
                {
                    MessageBox.Show("Please enter Username");
                    tbusername.Focus();
                }
                else if (tbpassword.Text == "")
                {
                    MessageBox.Show("Please enter Password");
                    tbpassword.Focus();
                }
            }
            else
            {
                
                DataTable dt = db.ExecuteReturnQuery("SELECT  * from tbllogin WHERE user_username = @uname and user_password = @pword and is_active = 1;",
                new MySqlParameter("@uname", tbusername.Text),
                new MySqlParameter("@pword", tbpassword.Text));

                if(dt.Rows.Count == 1)
                {
                    MessageBox.Show("Welcome " + tbusername.Text);
                    frmHome frm = new frmHome();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

            if (db.TestConnection() == true)
            {
                MessageBox.Show("Connected");
            }
            else
            {
                MessageBox.Show("Not Connected");
            }
        }
    }
}
