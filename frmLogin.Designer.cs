namespace TelanLaurenJamesBsit2D
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tblogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // tbusername
            // 
            resources.ApplyResources(this.tbusername, "tbusername");
            this.tbusername.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbusername.Name = "tbusername";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // tbpassword
            // 
            resources.ApplyResources(this.tbpassword, "tbpassword");
            this.tbpassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbpassword.Name = "tbpassword";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Name = "label3";
            // 
            // tblogin
            // 
            resources.ApplyResources(this.tblogin, "tblogin");
            this.tblogin.ForeColor = System.Drawing.Color.Maroon;
            this.tblogin.Name = "tblogin";
            this.tblogin.UseVisualStyleBackColor = true;
            this.tblogin.Click += new System.EventHandler(this.tblogin_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkSalmon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tblogin;
    }
}

