namespace Automation
{
    partial class mainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainView));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery4 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cks_btn = new DevExpress.XtraEditors.SimpleButton();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.satimAlim = new DevExpress.XtraEditors.SimpleButton();
            this.ctgr_button = new DevExpress.XtraEditors.SimpleButton();
            this.prdctbtn = new DevExpress.XtraEditors.SimpleButton();
            this.home_btn = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox0 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctgr_combobox = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.satinAlim_combobox = new System.Windows.Forms.ComboBox();
            this.sptEkle_btn = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add_btn = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cks_btn);
            this.panel1.Controls.Add(this.lblwelcome);
            this.panel1.Controls.Add(this.satimAlim);
            this.panel1.Controls.Add(this.ctgr_button);
            this.panel1.Controls.Add(this.prdctbtn);
            this.panel1.Controls.Add(this.home_btn);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 627);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(42, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cks_btn
            // 
            this.cks_btn.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cks_btn.Appearance.ForeColor = System.Drawing.Color.White;
            this.cks_btn.Appearance.Options.UseFont = true;
            this.cks_btn.Appearance.Options.UseForeColor = true;
            this.cks_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cks_btn.ImageOptions.Image")));
            this.cks_btn.Location = new System.Drawing.Point(70, 454);
            this.cks_btn.Name = "cks_btn";
            this.cks_btn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.cks_btn.Size = new System.Drawing.Size(122, 40);
            this.cks_btn.TabIndex = 4;
            this.cks_btn.Text = "Çıkış";
            this.cks_btn.Click += new System.EventHandler(this.cks_btn_Click);
            // 
            // lblwelcome
            // 
            this.lblwelcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblwelcome.ForeColor = System.Drawing.Color.White;
            this.lblwelcome.Location = new System.Drawing.Point(57, 36);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(155, 31);
            this.lblwelcome.TabIndex = 2;
            this.lblwelcome.Text = "HOŞGELDİNİZ:";
            this.lblwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // satimAlim
            // 
            this.satimAlim.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satimAlim.Appearance.ForeColor = System.Drawing.Color.White;
            this.satimAlim.Appearance.Options.UseFont = true;
            this.satimAlim.Appearance.Options.UseForeColor = true;
            this.satimAlim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("satimAlim.ImageOptions.Image")));
            this.satimAlim.Location = new System.Drawing.Point(70, 371);
            this.satimAlim.Name = "satimAlim";
            this.satimAlim.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.satimAlim.Size = new System.Drawing.Size(122, 40);
            this.satimAlim.TabIndex = 3;
            this.satimAlim.Text = "Satın Alım ";
            this.satimAlim.Click += new System.EventHandler(this.satimAlim_Click);
            // 
            // ctgr_button
            // 
            this.ctgr_button.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ctgr_button.Appearance.ForeColor = System.Drawing.Color.White;
            this.ctgr_button.Appearance.Options.UseFont = true;
            this.ctgr_button.Appearance.Options.UseForeColor = true;
            this.ctgr_button.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ctgr_button.ImageOptions.Image")));
            this.ctgr_button.Location = new System.Drawing.Point(70, 292);
            this.ctgr_button.Name = "ctgr_button";
            this.ctgr_button.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ctgr_button.Size = new System.Drawing.Size(122, 40);
            this.ctgr_button.TabIndex = 2;
            this.ctgr_button.Text = "Kategori";
            this.ctgr_button.Click += new System.EventHandler(this.ctgr_button_Click);
            // 
            // prdctbtn
            // 
            this.prdctbtn.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.prdctbtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.prdctbtn.Appearance.Options.UseFont = true;
            this.prdctbtn.Appearance.Options.UseForeColor = true;
            this.prdctbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("prdctbtn.ImageOptions.Image")));
            this.prdctbtn.Location = new System.Drawing.Point(70, 210);
            this.prdctbtn.Name = "prdctbtn";
            this.prdctbtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.prdctbtn.Size = new System.Drawing.Size(122, 40);
            this.prdctbtn.TabIndex = 1;
            this.prdctbtn.Text = "Ürünler";
            this.prdctbtn.Click += new System.EventHandler(this.prdctbtn_Click);
            // 
            // home_btn
            // 
            this.home_btn.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.home_btn.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.home_btn.Appearance.ForeColor = System.Drawing.Color.White;
            this.home_btn.Appearance.Options.UseBackColor = true;
            this.home_btn.Appearance.Options.UseBorderColor = true;
            this.home_btn.Appearance.Options.UseFont = true;
            this.home_btn.Appearance.Options.UseForeColor = true;
            this.home_btn.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.home_btn.AppearanceDisabled.ForeColor = System.Drawing.Color.Transparent;
            this.home_btn.AppearanceDisabled.Options.UseBackColor = true;
            this.home_btn.AppearanceDisabled.Options.UseBorderColor = true;
            this.home_btn.AppearanceDisabled.Options.UseForeColor = true;
            this.home_btn.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent;
            this.home_btn.AppearanceHovered.ForeColor = System.Drawing.Color.Transparent;
            this.home_btn.AppearanceHovered.Options.UseBackColor = true;
            this.home_btn.AppearanceHovered.Options.UseBorderColor = true;
            this.home_btn.AppearanceHovered.Options.UseForeColor = true;
            this.home_btn.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.AppearancePressed.BorderColor = System.Drawing.Color.Transparent;
            this.home_btn.AppearancePressed.ForeColor = System.Drawing.Color.Transparent;
            this.home_btn.AppearancePressed.Options.UseBackColor = true;
            this.home_btn.AppearancePressed.Options.UseBorderColor = true;
            this.home_btn.AppearancePressed.Options.UseForeColor = true;
            this.home_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.ImageOptions.Image")));
            this.home_btn.Location = new System.Drawing.Point(70, 130);
            this.home_btn.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.home_btn.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.home_btn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.home_btn.Name = "home_btn";
            this.home_btn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.home_btn.Size = new System.Drawing.Size(122, 40);
            this.home_btn.TabIndex = 0;
            this.home_btn.Text = "Ana Sayfa";
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox0);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(257, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 627);
            this.panel2.TabIndex = 2;
            // 
            // groupBox0
            // 
            this.groupBox0.Controls.Add(this.pictureBox2);
            this.groupBox0.Controls.Add(this.pictureBox1);
            this.groupBox0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox0.Location = new System.Drawing.Point(0, 0);
            this.groupBox0.Name = "groupBox0";
            this.groupBox0.Size = new System.Drawing.Size(641, 627);
            this.groupBox0.TabIndex = 4;
            this.groupBox0.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(641, 621);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Wheat;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ctgr_combobox);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 627);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(243, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctgr_combobox
            // 
            this.ctgr_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ctgr_combobox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ctgr_combobox.FormattingEnabled = true;
            this.ctgr_combobox.Items.AddRange(new object[] {
            "Gıda Ürünleri",
            "Kişisel Bakım ve Kozmetik",
            "Temizlik Ürünleri",
            "Bebek Ürünleri",
            "Dondurulmuş Ürünler",
            "Evcil Hayvan Ürünleri",
            "Sağlık ve Vitaminler",
            "Kırtasiye ve Elektronik",
            "İçecekler"});
            this.ctgr_combobox.Location = new System.Drawing.Point(229, 117);
            this.ctgr_combobox.Name = "ctgr_combobox";
            this.ctgr_combobox.Size = new System.Drawing.Size(171, 25);
            this.ctgr_combobox.TabIndex = 2;
            this.ctgr_combobox.SelectedIndexChanged += new System.EventHandler(this.ctgr_combobox_SelectedIndexChanged);
            this.ctgr_combobox.Enter += new System.EventHandler(this.Ctgr_ComboBox_Enter);
            this.ctgr_combobox.Leave += new System.EventHandler(this.Ctgr_ComboBox_Leave);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 159);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(641, 465);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Wheat;
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.satinAlim_combobox);
            this.groupBox3.Controls.Add(this.sptEkle_btn);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(641, 627);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(116, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 25);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Ara...";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // satinAlim_combobox
            // 
            this.satinAlim_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.satinAlim_combobox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satinAlim_combobox.FormattingEnabled = true;
            this.satinAlim_combobox.Items.AddRange(new object[] {
            "Gıda Ürünleri",
            "Kişisel Bakım ve Kozmetik",
            "Temizlik Ürünleri",
            "Bebek Ürünleri",
            "Dondurulmuş Ürünler",
            "Evcil Hayvan Ürünleri",
            "Sağlık ve Vitaminler",
            "Kırtasiye ve Elektronik",
            "İçecekler"});
            this.satinAlim_combobox.Location = new System.Drawing.Point(18, 117);
            this.satinAlim_combobox.Name = "satinAlim_combobox";
            this.satinAlim_combobox.Size = new System.Drawing.Size(171, 25);
            this.satinAlim_combobox.TabIndex = 2;
            this.satinAlim_combobox.SelectedIndexChanged += new System.EventHandler(this.satinAlim_combobox_SelectedIndexChanged);
            this.satinAlim_combobox.Enter += new System.EventHandler(this.SatinAlim_ComboBox_Enter);
            this.satinAlim_combobox.Leave += new System.EventHandler(this.SatinAlim_ComboBox_Leave);
            // 
            // sptEkle_btn
            // 
            this.sptEkle_btn.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sptEkle_btn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sptEkle_btn.Appearance.Options.UseFont = true;
            this.sptEkle_btn.Appearance.Options.UseForeColor = true;
            this.sptEkle_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sptEkle_btn.ImageOptions.Image")));
            this.sptEkle_btn.Location = new System.Drawing.Point(511, 80);
            this.sptEkle_btn.Name = "sptEkle_btn";
            this.sptEkle_btn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sptEkle_btn.Size = new System.Drawing.Size(115, 44);
            this.sptEkle_btn.TabIndex = 1;
            this.sptEkle_btn.Text = "Sepet";
            this.sptEkle_btn.Click += new System.EventHandler(this.sptEkle_btn_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 159);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(641, 465);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 627);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(243, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ürünler";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_btn
            // 
            this.add_btn.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_btn.Appearance.Options.UseFont = true;
            this.add_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("add_btn.ImageOptions.Image")));
            this.add_btn.Location = new System.Drawing.Point(479, 66);
            this.add_btn.Name = "add_btn";
            this.add_btn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.add_btn.Size = new System.Drawing.Size(124, 58);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Ürün Ekle";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(18, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 18);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Ara...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(641, 465);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "database 1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression13.ColumnName = "id";
            table4.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"143\" />";
            table4.Name = "ürünbilgileri";
            columnExpression13.Table = table4;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "isim";
            columnExpression14.Table = table4;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "fiyat";
            columnExpression15.Table = table4;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "kategori";
            columnExpression16.Table = table4;
            column16.Expression = columnExpression16;
            selectQuery4.Columns.Add(column13);
            selectQuery4.Columns.Add(column14);
            selectQuery4.Columns.Add(column15);
            selectQuery4.Columns.Add(column16);
            selectQuery4.Name = "Query";
            selectQuery4.Tables.Add(table4);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery4});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // mainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainView";
            this.Text = "Market Otomasyonu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton satimAlim;
        private DevExpress.XtraEditors.SimpleButton ctgr_button;
        private DevExpress.XtraEditors.SimpleButton prdctbtn;
        private DevExpress.XtraEditors.SimpleButton home_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblwelcome;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox0;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private DevExpress.XtraEditors.SimpleButton sptEkle_btn;
        private System.Windows.Forms.ComboBox satinAlim_combobox;
        private System.Windows.Forms.TextBox textBox2;
        private DevExpress.XtraEditors.SimpleButton cks_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ctgr_combobox;
        private DevExpress.XtraEditors.SimpleButton add_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}