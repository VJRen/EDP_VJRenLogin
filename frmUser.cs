using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        MyDatabase db = new MyDatabase();
        bool updated = false;
        int UserInfoId = 0;
        int LoginId = 0;

        private void frmUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            updated = false;
            string query = "SELECT tbluserinfo.userID, tbllogin.LoginID, tbluserinfo.firstname, " +
                "tbluserinfo.middlename, tbluserinfo.lastname, tbluserinfo.emailAddress," +
                " tbluserinfo.homeAddress, tbluserinfo.birthDate, tbllogin.user_username as 'Username'," +
                " tbllogin.user_password as 'Password' FROM tbllogin INNER JOIN tbluserinfo" +
                " ON tbllogin.userID = tbluserinfo.userID;";

            dgvuserinfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvuserinfo.DataSource = db.ExecuteReturnQuery(query);
            dgvuserinfo.Columns[0].Visible = false;
            dgvuserinfo.Columns[1].Visible = false;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (!updated)
            {
                if (firstname.Text == "" || midname.Text == "" || lastname.Text == "") //if text box isempty wip
                {
                    MessageBox.Show("Boxes must not be empty");
                }
                else
                { 
                    string query =
                        "INSERT INTO tbluserinfo (firstname, middlename, lastname, emailAddress, homeAddress, birthDate) " +
                        "VALUES (@fname, @mname, @lname, @email, @hadd, @bDate); " +
                        "INSERT INTO tbllogin (userID, user_username, user_password) VALUES (LAST_INSERT_ID(), @username, @password);";

                    int affectedRowCount = db.ExecuteNoReturnQuery(query,
                        new MySqlParameter("@fname", firstname.Text),
                        new MySqlParameter("@mname", midname.Text),
                        new MySqlParameter("@lname", lastname.Text),
                        new MySqlParameter("@email", eadd.Text),
                        new MySqlParameter("@hadd", hadd.Text),
                        new MySqlParameter("@bDate", bdate.Value),
                        new MySqlParameter("@username", uname.Text),
                        new MySqlParameter("@password", pword.Text)
                    );

                    if (affectedRowCount > 0)
                    {
                        MessageBox.Show("Data Inserted!");
                        frmUser_Load(null, null);
                    }
                }
            }
            else //WORKING UPDATE SYSTEM
            {

                string updateUser =
                    "UPDATE tbluserinfo SET firstname = @fname, middlename = @mname, lastname = @lname, " +
                    "emailAddress = @email, homeAddress = @hadd, birthDate = @bDate " +
                    "WHERE userID = @userID;";

                string updateLogin =
                    "UPDATE tbllogin SET user_username = @username, user_password = @password " +
                    "WHERE LoginID = @loginID;";

                int affectedRowCount = db.ExecuteNoReturnQuery(updateUser + updateLogin,
                    new MySqlParameter("@fname", firstname.Text),
                    new MySqlParameter("@mname", midname.Text),
                    new MySqlParameter("@lname", lastname.Text),
                    new MySqlParameter("@email", eadd.Text),
                    new MySqlParameter("@hadd", hadd.Text),
                    new MySqlParameter("@bDate", bdate.Value),
                    new MySqlParameter("@username", uname.Text),
                    new MySqlParameter("@password", pword.Text),
                    new MySqlParameter("@userID", UserInfoId),
                    new MySqlParameter("@loginID", LoginId)
                );

                if (affectedRowCount > 0)
                {
                    MessageBox.Show("Data Updated!");
                    frmUser_Load(null, null);
                }

                dUserInfoId = 0;
                LoginId = 0;
                firstname.Text = "";
                midname.Text = "";
                lastname.Text = "";
                eadd.Text = "";
                hadd.Text = "";
                bdate.Value = DateTime.Now;
                uname.Text = "";
                pword.Text = "";
                updated = false;
            }
        }

        private void Deactivate_Click(object sender, EventArgs e)
        {
            if (dgvuserinfo.SelectedRows.Count > 0)
            {

                DialogResult result = MessageBox.Show("Are you sure you want to deactivate this account?", "Account Deactivation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    int id = Convert.ToInt32(dgvuserinfo.SelectedRows[0].Cells[1].Value);
                    string query = "UPDATE tbllogin SET is_active = 0 where LoginID = @id";

                    int affectedRows = db.ExecuteNoReturnQuery(query,
                        new MySqlParameter("@id", id));
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Account is deactivated!");
                    }

                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (dgvuserinfo.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update this account?", "Update Account", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    updated = true;
                    UserInfoId = Convert.ToInt32(dgvuserinfo.SelectedRows[0].Cells[0].Value);
                    LoginId = Convert.ToInt32(dgvuserinfo.SelectedRows[0].Cells[1].Value);
                    firstname.Text = dgvuserinfo.SelectedRows[0].Cells[2].Value.ToString();
                    midname.Text = dgvuserinfo.SelectedRows[0].Cells[3].Value.ToString();
                    lastname.Text = dgvuserinfo.SelectedRows[0].Cells[4].Value.ToString();
                    eadd.Text = dgvuserinfo.SelectedRows[0].Cells[5].Value.ToString();
                    hadd.Text = dgvuserinfo.SelectedRows[0].Cells[6].Value.ToString();
                    bdate.Value = Convert.ToDateTime(dgvuserinfo.SelectedRows[0].Cells[7].Value);
                    uname.Text = dgvuserinfo.SelectedRows[0].Cells[8].Value.ToString();
                    pword.Text = dgvuserinfo.SelectedRows[0].Cells[9].Value.ToString();
                }
                else
                {
                    updated = false;
                    firstname.Text = "";
                    midname.Text = "";
                    lastname.Text = "";
                    eadd.Text = "";
                    hadd.Text = "";
                    bdate.Value = DateTime.Now;
                    uname.Text = "";
                    pword.Text = "";
                }
            }
        }

        private void dgvuserinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool Updated;
    }
}
