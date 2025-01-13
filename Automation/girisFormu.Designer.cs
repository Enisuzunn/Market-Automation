namespace Automation
{
    partial class girisFormu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisFormu));
            this.password_box = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lgn_btn = new System.Windows.Forms.Button();
            this.username_box = new System.Windows.Forms.TextBox();
            this.lgn_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.signup_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // password_box
            // 
            this.password_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_box.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_box.Location = new System.Drawing.Point(57, 255);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(216, 22);
            this.password_box.TabIndex = 1;
            this.password_box.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(156, 297);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 25);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Parolayı Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lgn_btn
            // 
            this.lgn_btn.BackColor = System.Drawing.Color.Chocolate;
            this.lgn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lgn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lgn_btn.ForeColor = System.Drawing.Color.White;
            this.lgn_btn.Location = new System.Drawing.Point(29, 364);
            this.lgn_btn.Name = "lgn_btn";
            this.lgn_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lgn_btn.Size = new System.Drawing.Size(142, 42);
            this.lgn_btn.TabIndex = 2;
            this.lgn_btn.Text = "GİRİŞ";
            this.lgn_btn.UseVisualStyleBackColor = false;
            this.lgn_btn.Click += new System.EventHandler(this.lgn_btn_Click);
            this.lgn_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lgn_btn_KeyDown);
            // 
            // username_box
            // 
            this.username_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_box.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_box.Location = new System.Drawing.Point(57, 183);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(217, 22);
            this.username_box.TabIndex = 0;
            // 
            // lgn_lbl
            // 
            this.lgn_lbl.BackColor = System.Drawing.Color.White;
            this.lgn_lbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lgn_lbl.ForeColor = System.Drawing.Color.Chocolate;
            this.lgn_lbl.Location = new System.Drawing.Point(63, 38);
            this.lgn_lbl.Name = "lgn_lbl";
            this.lgn_lbl.Size = new System.Drawing.Size(196, 75);
            this.lgn_lbl.TabIndex = 11;
            this.lgn_lbl.Text = "Hesap Girişi";
            this.lgn_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 535);
            this.panel1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(69, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hesabınızı kaydedin";
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.Chocolate;
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signup_btn.ForeColor = System.Drawing.Color.White;
            this.signup_btn.Location = new System.Drawing.Point(0, 493);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.signup_btn.Size = new System.Drawing.Size(306, 42);
            this.signup_btn.TabIndex = 14;
            this.signup_btn.Text = "KAYIT OL";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(44, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Market Otomasyonu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lgn_btn);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.lgn_lbl);
            this.panel2.Controls.Add(this.password_box);
            this.panel2.Controls.Add(this.username_box);
            this.panel2.Location = new System.Drawing.Point(301, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 535);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(29, 252);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(29, 279);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 1);
            this.panel3.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(29, 207);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 1);
            this.panel4.TabIndex = 19;
            // 
            // girisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "girisFormu";
            this.Text = "Giriş Ekranı";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button lgn_btn;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label lgn_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
    }
}

