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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void User_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            this.Hide();
            frm.Show();
        }
        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login frm = new Login();
            frm.Show();
        }
    }
}
