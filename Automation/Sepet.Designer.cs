namespace Automation
{
    partial class Sepet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sepet));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelToplamFiyat = new System.Windows.Forms.Label();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnSatinAl = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.labelToplamFiyat);
            this.groupControl1.Controls.Add(this.btnIptal);
            this.groupControl1.Controls.Add(this.btnSatinAl);
            this.groupControl1.Controls.Add(this.dataGridView1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(-3, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(534, 511);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Sepetim";
            // 
            // labelToplamFiyat
            // 
            this.labelToplamFiyat.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamFiyat.Location = new System.Drawing.Point(15, 251);
            this.labelToplamFiyat.Name = "labelToplamFiyat";
            this.labelToplamFiyat.Size = new System.Drawing.Size(310, 28);
            this.labelToplamFiyat.TabIndex = 4;
            this.labelToplamFiyat.Text = "Toplam Fiyat: 0";
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.ImageOptions.Image")));
            this.btnIptal.Location = new System.Drawing.Point(309, 388);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnIptal.Size = new System.Drawing.Size(106, 54);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAl.Appearance.Options.UseFont = true;
            this.btnSatinAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSatinAl.ImageOptions.Image")));
            this.btnSatinAl.Location = new System.Drawing.Point(93, 388);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSatinAl.Size = new System.Drawing.Size(125, 54);
            this.btnSatinAl.TabIndex = 2;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adet,
            this.isim,
            this.fiyat});
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(534, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adet
            // 
            this.adet.HeaderText = "adet";
            this.adet.Name = "adet";
            this.adet.ReadOnly = true;
            // 
            // isim
            // 
            this.isim.HeaderText = "isim";
            this.isim.Name = "isim";
            this.isim.ReadOnly = true;
            // 
            // fiyat
            // 
            this.fiyat.HeaderText = "fiyat";
            this.fiyat.Name = "fiyat";
            this.fiyat.ReadOnly = true;
            // 
            // Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 511);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sepet";
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.SepetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.SimpleButton btnSatinAl;
        private System.Windows.Forms.Label labelToplamFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
    }
}