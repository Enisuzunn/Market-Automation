namespace Automation
{
    partial class düzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(düzenle));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.kptdzn_txtbox = new System.Windows.Forms.Button();
            this.kydtdzn_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ktgrdzn_cmbbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fytdzn_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ısmdzn_txtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.kptdzn_txtbox);
            this.groupControl1.Controls.Add(this.kydtdzn_btn);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.ktgrdzn_cmbbox);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.fytdzn_txtbox);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.ısmdzn_txtbox);
            this.groupControl1.Location = new System.Drawing.Point(0, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(427, 345);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Ürün Düzenle";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // kptdzn_txtbox
            // 
            this.kptdzn_txtbox.Location = new System.Drawing.Point(126, 280);
            this.kptdzn_txtbox.Name = "kptdzn_txtbox";
            this.kptdzn_txtbox.Size = new System.Drawing.Size(75, 27);
            this.kptdzn_txtbox.TabIndex = 7;
            this.kptdzn_txtbox.Text = "Kapat";
            this.kptdzn_txtbox.UseVisualStyleBackColor = true;
            this.kptdzn_txtbox.Click += new System.EventHandler(this.kptdzn_txtbox_Click);
            // 
            // kydtdzn_btn
            // 
            this.kydtdzn_btn.Location = new System.Drawing.Point(25, 280);
            this.kydtdzn_btn.Name = "kydtdzn_btn";
            this.kydtdzn_btn.Size = new System.Drawing.Size(75, 27);
            this.kydtdzn_btn.TabIndex = 6;
            this.kydtdzn_btn.Text = "Kaydet";
            this.kydtdzn_btn.UseVisualStyleBackColor = true;
            this.kydtdzn_btn.Click += new System.EventHandler(this.kydtdzn_btn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategori";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ktgrdzn_cmbbox
            // 
            this.ktgrdzn_cmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ktgrdzn_cmbbox.FormattingEnabled = true;
            this.ktgrdzn_cmbbox.Items.AddRange(new object[] {
            "Gıda Ürünleri",
            "Kişisel Bakım ve Kozmetik",
            "Temizlik Ürünleri",
            "Bebek Ürünleri",
            "Dondurulmuş Ürünler",
            "Evcil Hayvan Ürünleri",
            "Sağlık ve Vitaminler",
            "Kırtasiye ve Elektronik"});
            this.ktgrdzn_cmbbox.Location = new System.Drawing.Point(25, 214);
            this.ktgrdzn_cmbbox.Name = "ktgrdzn_cmbbox";
            this.ktgrdzn_cmbbox.Size = new System.Drawing.Size(121, 21);
            this.ktgrdzn_cmbbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fiyat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // fytdzn_txtbox
            // 
            this.fytdzn_txtbox.Location = new System.Drawing.Point(24, 140);
            this.fytdzn_txtbox.Name = "fytdzn_txtbox";
            this.fytdzn_txtbox.Size = new System.Drawing.Size(122, 21);
            this.fytdzn_txtbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ısmdzn_txtbox
            // 
            this.ısmdzn_txtbox.Location = new System.Drawing.Point(24, 72);
            this.ısmdzn_txtbox.Name = "ısmdzn_txtbox";
            this.ısmdzn_txtbox.Size = new System.Drawing.Size(210, 21);
            this.ısmdzn_txtbox.TabIndex = 0;
            // 
            // düzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 342);
            this.Controls.Add(this.groupControl1);
            this.Name = "düzenle";
            this.Text = "düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button kptdzn_txtbox;
        private System.Windows.Forms.Button kydtdzn_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ktgrdzn_cmbbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fytdzn_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ısmdzn_txtbox;
    }
}