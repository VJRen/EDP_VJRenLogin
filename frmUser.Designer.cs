namespace TelanLaurenJamesBsit2D
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Deacbtn = new System.Windows.Forms.Button();
            this.Upbtn = new System.Windows.Forms.Button();
            this.dgvuserinfo = new System.Windows.Forms.DataGridView();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.midname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eadd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hadd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bdate = new System.Windows.Forms.DateTimePicker();
            this.uname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // Deacbtn
            // 
            this.Deacbtn.Location = new System.Drawing.Point(790, 534);
            this.Deacbtn.Name = "Deacbtn";
            this.Deacbtn.Size = new System.Drawing.Size(130, 34);
            this.Deacbtn.TabIndex = 0;
            this.Deacbtn.Text = "Deactivate";
            this.Deacbtn.UseVisualStyleBackColor = true;
            this.Deacbtn.Click += new System.EventHandler(this.Deactivate_Click);
            // 
            // Upbtn
            // 
            this.Upbtn.Location = new System.Drawing.Point(654, 534);
            this.Upbtn.Name = "Upbtn";
            this.Upbtn.Size = new System.Drawing.Size(130, 34);
            this.Upbtn.TabIndex = 0;
            this.Upbtn.Text = "Update";
            this.Upbtn.UseVisualStyleBackColor = true;
            this.Upbtn.Click += new System.EventHandler(this.Update_Click);
            // 
            // dgvuserinfo
            // 
            this.dgvuserinfo.AllowUserToAddRows = false;
            this.dgvuserinfo.AllowUserToDeleteRows = false;
            this.dgvuserinfo.AllowUserToResizeColumns = false;
            this.dgvuserinfo.AllowUserToResizeRows = false;
            this.dgvuserinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuserinfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvuserinfo.Location = new System.Drawing.Point(305, 12);
            this.dgvuserinfo.Name = "dgvuserinfo";
            this.dgvuserinfo.Size = new System.Drawing.Size(615, 516);
            this.dgvuserinfo.TabIndex = 1;
            this.dgvuserinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvuserinfo_CellContentClick);
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(12, 28);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(287, 20);
            this.firstname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            // 
            // midname
            // 
            this.midname.Location = new System.Drawing.Point(12, 67);
            this.midname.Name = "midname";
            this.midname.Size = new System.Drawing.Size(287, 20);
            this.midname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Middle Name:";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(12, 106);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(287, 20);
            this.lastname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // eadd
            // 
            this.eadd.Location = new System.Drawing.Point(12, 145);
            this.eadd.Name = "eadd";
            this.eadd.Size = new System.Drawing.Size(287, 20);
            this.eadd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email Address:";
            // 
            // hadd
            // 
            this.hadd.Location = new System.Drawing.Point(12, 184);
            this.hadd.Name = "hadd";
            this.hadd.Size = new System.Drawing.Size(287, 20);
            this.hadd.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Home Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Birth Date:";
            // 
            // bdate
            // 
            this.bdate.Location = new System.Drawing.Point(12, 223);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(200, 20);
            this.bdate.TabIndex = 4;
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(12, 262);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(287, 20);
            this.uname.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Username:";
            // 
            // pword
            // 
            this.pword.Location = new System.Drawing.Point(12, 301);
            this.pword.Name = "pword";
            this.pword.Size = new System.Drawing.Size(287, 20);
            this.pword.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Password:";
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(169, 327);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(130, 34);
            this.Savebtn.TabIndex = 0;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Save_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 580);
            this.Controls.Add(this.bdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.hadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.midname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.dgvuserinfo);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Upbtn);
            this.Controls.Add(this.Deacbtn);
            this.Name = "frmUser";
            this.Text = "User Maintenance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsers_FormClosing);
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Button Deacbtn;
        private System.Windows.Forms.Button Upbtn;
        private System.Windows.Forms.DataGridView dgvuserinfo;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox midname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hadd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker bdate;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Savebtn;
    }
}