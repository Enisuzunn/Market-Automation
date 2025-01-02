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
            this.label2 = new System.Windows.Forms.Label();
            this.password_signup = new System.Windows.Forms.TextBox();
            this.username_signup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.againpassword_signup = new System.Windows.Forms.TextBox();
            this.show_againpassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_btnview
            // 
            this.signup_btnview.BackColor = System.Drawing.Color.Chocolate;
            this.signup_btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signup_btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signup_btnview.ForeColor = System.Drawing.Color.White;
            this.signup_btnview.Location = new System.Drawing.Point(224, 441);
            this.signup_btnview.Name = "signup_btnview";
            this.signup_btnview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.signup_btnview.Size = new System.Drawing.Size(142, 42);
            this.signup_btnview.TabIndex = 19;
            this.signup_btnview.Text = "SIGNUP";
            this.signup_btnview.UseVisualStyleBackColor = false;
            this.signup_btnview.Click += new System.EventHandler(this.signup_btnview_Click);
            // 
            // show_password
            // 
            this.show_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.show_password.Location = new System.Drawing.Point(273, 308);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(139, 25);
            this.show_password.TabIndex = 20;
            this.show_password.Text = "Show Password";
            this.show_password.UseVisualStyleBackColor = true;
            this.show_password.CheckedChanged += new System.EventHandler(this.show_password_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(162, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password:";
            // 
            // password_signup
            // 
            this.password_signup.Location = new System.Drawing.Point(165, 282);
            this.password_signup.Name = "password_signup";
            this.password_signup.Size = new System.Drawing.Size(247, 20);
            this.password_signup.TabIndex = 23;
            this.password_signup.UseSystemPasswordChar = true;
            // 
            // username_signup
            // 
            this.username_signup.Location = new System.Drawing.Point(165, 219);
            this.username_signup.Name = "username_signup";
            this.username_signup.Size = new System.Drawing.Size(247, 20);
            this.username_signup.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(165, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Username:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(224, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(162, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password again:";
            // 
            // againpassword_signup
            // 
            this.againpassword_signup.Location = new System.Drawing.Point(165, 362);
            this.againpassword_signup.Name = "againpassword_signup";
            this.againpassword_signup.Size = new System.Drawing.Size(247, 20);
            this.againpassword_signup.TabIndex = 26;
            this.againpassword_signup.UseSystemPasswordChar = true;
            // 
            // show_againpassword
            // 
            this.show_againpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.show_againpassword.Location = new System.Drawing.Point(273, 388);
            this.show_againpassword.Name = "show_againpassword";
            this.show_againpassword.Size = new System.Drawing.Size(139, 25);
            this.show_againpassword.TabIndex = 27;
            this.show_againpassword.Text = "Show Password";
            this.show_againpassword.UseVisualStyleBackColor = true;
            this.show_againpassword.CheckedChanged += new System.EventHandler(this.show_againpassword_CheckedChanged);
            // 
            // kayıtFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(619, 536);
            this.Controls.Add(this.show_againpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.againpassword_signup);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.signup_btnview);
            this.Controls.Add(this.show_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_signup);
            this.Controls.Add(this.username_signup);
            this.Controls.Add(this.label1);
            this.Name = "kayıtFormu";
            this.Text = "kayıtFormu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signup_btnview;
        private System.Windows.Forms.CheckBox show_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_signup;
        private System.Windows.Forms.TextBox username_signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox againpassword_signup;
        private System.Windows.Forms.CheckBox show_againpassword;
    }
}