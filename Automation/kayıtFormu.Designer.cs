namespace Automation
{
    partial class kayıtFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayıtFormu));
            this.signup_btnview = new System.Windows.Forms.Button();
            this.show_password = new System.Windows.Forms.CheckBox();
            this.password_signup = new System.Windows.Forms.TextBox();
            this.username_signup = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.againpassword_signup = new System.Windows.Forms.TextBox();
            this.show_againpassword = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_btnview
            // 
            this.signup_btnview.BackColor = System.Drawing.Color.Chocolate;
            this.signup_btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signup_btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signup_btnview.ForeColor = System.Drawing.Color.White;
            this.signup_btnview.Location = new System.Drawing.Point(233, 426);
            this.signup_btnview.Name = "signup_btnview";
            this.signup_btnview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.signup_btnview.Size = new System.Drawing.Size(142, 42);
            this.signup_btnview.TabIndex = 19;
            this.signup_btnview.Text = "KAYIT OL";
            this.signup_btnview.UseVisualStyleBackColor = false;
            this.signup_btnview.Click += new System.EventHandler(this.signup_btnview_Click);
            this.signup_btnview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.signup_btnview_KeyDown);
            // 
            // show_password
            // 
            this.show_password.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.show_password.Location = new System.Drawing.Point(302, 286);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(120, 25);
            this.show_password.TabIndex = 20;
            this.show_password.Text = "Parolayı Göster";
            this.show_password.UseVisualStyleBackColor = true;
            this.show_password.CheckedChanged += new System.EventHandler(this.show_password_CheckedChanged);
            // 
            // password_signup
            // 
            this.password_signup.BackColor = System.Drawing.Color.SandyBrown;
            this.password_signup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_signup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_signup.Location = new System.Drawing.Point(204, 251);
            this.password_signup.Name = "password_signup";
            this.password_signup.Size = new System.Drawing.Size(218, 22);
            this.password_signup.TabIndex = 1;
            this.password_signup.UseSystemPasswordChar = true;
            // 
            // username_signup
            // 
            this.username_signup.BackColor = System.Drawing.Color.SandyBrown;
            this.username_signup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_signup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_signup.Location = new System.Drawing.Point(204, 200);
            this.username_signup.Name = "username_signup";
            this.username_signup.Size = new System.Drawing.Size(217, 22);
            this.username_signup.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(209, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // againpassword_signup
            // 
            this.againpassword_signup.BackColor = System.Drawing.Color.SandyBrown;
            this.againpassword_signup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.againpassword_signup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.againpassword_signup.Location = new System.Drawing.Point(204, 315);
            this.againpassword_signup.Name = "againpassword_signup";
            this.againpassword_signup.Size = new System.Drawing.Size(218, 22);
            this.againpassword_signup.TabIndex = 2;
            this.againpassword_signup.UseSystemPasswordChar = true;
            // 
            // show_againpassword
            // 
            this.show_againpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.show_againpassword.Location = new System.Drawing.Point(302, 350);
            this.show_againpassword.Name = "show_againpassword";
            this.show_againpassword.Size = new System.Drawing.Size(120, 25);
            this.show_againpassword.TabIndex = 27;
            this.show_againpassword.Text = "Parolayı Göster";
            this.show_againpassword.UseVisualStyleBackColor = true;
            this.show_againpassword.CheckedChanged += new System.EventHandler(this.show_againpassword_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(166, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 1);
            this.panel1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(167, 248);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(166, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 1);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(167, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 1);
            this.panel3.TabIndex = 32;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(167, 312);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // kayıtFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(619, 536);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.show_againpassword);
            this.Controls.Add(this.againpassword_signup);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.signup_btnview);
            this.Controls.Add(this.show_password);
            this.Controls.Add(this.password_signup);
            this.Controls.Add(this.username_signup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "kayıtFormu";
            this.Text = "Kayıt Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signup_btnview;
        private System.Windows.Forms.CheckBox show_password;
        private System.Windows.Forms.TextBox password_signup;
        private System.Windows.Forms.TextBox username_signup;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox againpassword_signup;
        private System.Windows.Forms.CheckBox show_againpassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}