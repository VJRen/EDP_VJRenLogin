using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelanLaurenJamesBsit2D
{
    public partial class Form1 : Form
    {
        public Form1()
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
                MessageBox.Show("Welcome "+ tbusername.Text);
            }

        }
    }
}
