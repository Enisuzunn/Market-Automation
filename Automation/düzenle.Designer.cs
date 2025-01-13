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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kptdzn_txtbox = new DevExpress.XtraEditors.SimpleButton();
            this.kydtdzn_btn = new DevExpress.XtraEditors.SimpleButton();
            this.ktgrdzn_cmbbox = new System.Windows.Forms.ComboBox();
            this.fytdzn_txtbox = new System.Windows.Forms.TextBox();
            this.ısmdzn_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adtbox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.adtbox2);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.kptdzn_txtbox);
            this.groupControl1.Controls.Add(this.kydtdzn_btn);
            this.groupControl1.Controls.Add(this.ktgrdzn_cmbbox);
            this.groupControl1.Controls.Add(this.fytdzn_txtbox);
            this.groupControl1.Controls.Add(this.ısmdzn_txtbox);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(-1, -3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(427, 345);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Ürün Düzenle";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kategori";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(35, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fiyat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(35, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ürün Adı";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // kptdzn_txtbox
            // 
            this.kptdzn_txtbox.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kptdzn_txtbox.Appearance.Options.UseFont = true;
            this.kptdzn_txtbox.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kptdzn_txtbox.ImageOptions.Image")));
            this.kptdzn_txtbox.Location = new System.Drawing.Point(186, 259);
            this.kptdzn_txtbox.Name = "kptdzn_txtbox";
            this.kptdzn_txtbox.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.kptdzn_txtbox.Size = new System.Drawing.Size(98, 42);
            this.kptdzn_txtbox.TabIndex = 11;
            this.kptdzn_txtbox.Text = "İptal";
            this.kptdzn_txtbox.Click += new System.EventHandler(this.kptdzn_txtbox_Click);
            // 
            // kydtdzn_btn
            // 
            this.kydtdzn_btn.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kydtdzn_btn.Appearance.Options.UseFont = true;
            this.kydtdzn_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kydtdzn_btn.ImageOptions.Image")));
            this.kydtdzn_btn.Location = new System.Drawing.Point(39, 259);
            this.kydtdzn_btn.Name = "kydtdzn_btn";
            this.kydtdzn_btn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.kydtdzn_btn.Size = new System.Drawing.Size(99, 42);
            this.kydtdzn_btn.TabIndex = 10;
            this.kydtdzn_btn.Text = "Düzenle";
            this.kydtdzn_btn.Click += new System.EventHandler(this.kydtdzn_btn_Click);
            // 
            // ktgrdzn_cmbbox
            // 
            this.ktgrdzn_cmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ktgrdzn_cmbbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ktgrdzn_cmbbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.ktgrdzn_cmbbox.Location = new System.Drawing.Point(37, 204);
            this.ktgrdzn_cmbbox.Name = "ktgrdzn_cmbbox";
            this.ktgrdzn_cmbbox.Size = new System.Drawing.Size(172, 25);
            this.ktgrdzn_cmbbox.TabIndex = 4;
            // 
            // fytdzn_txtbox
            // 
            this.fytdzn_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fytdzn_txtbox.Location = new System.Drawing.Point(37, 130);
            this.fytdzn_txtbox.Name = "fytdzn_txtbox";
            this.fytdzn_txtbox.Size = new System.Drawing.Size(129, 25);
            this.fytdzn_txtbox.TabIndex = 2;
            // 
            // ısmdzn_txtbox
            // 
            this.ısmdzn_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ısmdzn_txtbox.Location = new System.Drawing.Point(39, 63);
            this.ısmdzn_txtbox.Name = "ısmdzn_txtbox";
            this.ısmdzn_txtbox.Size = new System.Drawing.Size(210, 25);
            this.ısmdzn_txtbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(254, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Adet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // adtbox2
            // 
            this.adtbox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adtbox2.Location = new System.Drawing.Point(252, 130);
            this.adtbox2.Name = "adtbox2";
            this.adtbox2.Size = new System.Drawing.Size(63, 25);
            this.adtbox2.TabIndex = 15;
            // 
            // düzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 342);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "düzenle";
            this.Text = "Ürün Düzenleme";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox ktgrdzn_cmbbox;
        private System.Windows.Forms.TextBox fytdzn_txtbox;
        private System.Windows.Forms.TextBox ısmdzn_txtbox;
        private DevExpress.XtraEditors.SimpleButton kptdzn_txtbox;
        private DevExpress.XtraEditors.SimpleButton kydtdzn_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adtbox2;
    }
}