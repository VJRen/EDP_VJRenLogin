namespace TelanLaurenJamesBsit2D
{
    partial class frmHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Reg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reg
            // 
            this.Reg.Location = new System.Drawing.Point(38, 26);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(75, 50);
            this.Reg.TabIndex = 0;
            this.Reg.Text = "Register";
            this.Reg.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(119, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "Store Status";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(200, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 50);
            this.button3.TabIndex = 0;
            this.button3.Text = "Price Book";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(200, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 50);
            this.button4.TabIndex = 0;
            this.button4.Text = "Time Clock";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.User.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.User.Location = new System.Drawing.Point(119, 82);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(75, 50);
            this.User.TabIndex = 0;
            this.User.Text = "Users";
            this.User.UseVisualStyleBackColor = true;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(38, 82);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 50);
            this.button6.TabIndex = 0;
            this.button6.Text = "Vendors";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TelanLaurenJamesBsit2D.Properties.Resources.Piggy;
            this.ClientSize = new System.Drawing.Size(314, 158);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.User);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Reg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button User;
        private System.Windows.Forms.Button button6;
    }
}