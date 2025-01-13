using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace Automation
{
   
    public partial class mainView : Form
    {
        string path = @"Data source = database.db; Version = 3;";
        string cmd = "SELECT adet, id, isim, fiyat, kategori FROM ürünbilgileri";


        int id = 0;
        
        public mainView(string username)
        {
            InitializeComponent();      
            label1.Text = username;
            label1.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            label1.ForeColor = Color.White;
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            sqlDataSource1.FillAsync();
            satinAlim_combobox.Text = "Lütfen seçim yapın...";
            satinAlim_combobox.ForeColor = System.Drawing.Color.Black;
            ctgr_combobox.Text += "Lütfen seçim yapın...";
            ctgr_combobox.ForeColor = System.Drawing.Color.Black;
            // Olayları bağlayın
            satinAlim_combobox.Enter += SatinAlim_ComboBox_Enter;
            satinAlim_combobox.Leave += SatinAlim_ComboBox_Leave;
            ctgr_combobox.Enter += Ctgr_ComboBox_Enter;
            ctgr_combobox.Leave += Ctgr_ComboBox_Leave;
            
        }
        //Ev Butonu
        private void home_btn_Click(object sender, EventArgs e)
        {
            groupBox0.Show();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }
        //Ekleme Butonu
        private void add_btn_Click(object sender, EventArgs e)
        {
            using (addProducts addForm = new addProducts(id)) // Yeni ürün eklemek için form açılır
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); // Ekleme sonrası verileri yenile
                    
                }
            }
            Upload();
        }
        //DataGridde ürün değiştirme ve ürün silme butonlarını ekleme metodu
        private void AddEditAndDeleteButtons()
        {
            if (dataGridView1.Columns["Edit"] == null && dataGridView1.Columns["Delete"] == null)
            {
                // Düzenleme butonu
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    Text = "Düzenle",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(editButtonColumn);

                // Silme butonu
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    Text = "Sil",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
        }
        //Ürünler Butonu
        private void prdctbtn_Click(object sender, EventArgs e)
        {
            groupBox0.Hide();
            groupBox1.Show();
            groupBox2.Hide();
            groupBox3.Hide();
           

            using (SQLiteConnection connection = new SQLiteConnection(path))
            {
                try
                {
                    connection.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; // DataGridView'e veriyi bağlayın.
                    dataGridView1.Columns["id"].Visible = false;
                    AddEditAndDeleteButtons();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }             
            }
        }
        //Data gridin üzerinde düzenleme butonunun metodu
        private void EditProduct(int id)
        {
            using (düzenle editForm = new düzenle(id)) // ID ile form açılıyor
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                    
                    // Düzenleme sonrası verileri yenile
                }
            }
        }

        //Data Gridin üzerinde silme butonunun metodu
        private void DeleteProduct(int id)
        {   
                try
                {
                // Yönetici doğrulama formunu aç
                using (deleteProducts delete = new deleteProducts())
                {
                    if (delete.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("Yönetici doğrulaması başarısız. İşlem iptal edildi.");
                        return; // Yönetici doğrulaması yapılmazsa işlemden çık
                    }
                }

                // Kullanıcıya onay penceresi göster
                DialogResult result = MessageBox.Show(
                        "Bu ürünü silmek istediğinize emin misiniz?",
                        "Onay",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        // SQLite bağlantısını ve işlemlerini yönet
                        using (SQLiteConnection connection = new SQLiteConnection(path))
                        {
                            connection.Open();
                            string query = "DELETE FROM ürünbilgileri WHERE id = @id";

                            using (SQLiteCommand command = new SQLiteCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@id", id);
                                command.ExecuteNonQuery();
                            }
                        }
                        // Başarı mesajı ve veri yenileme
                        MessageBox.Show("Ürün başarıyla silindi!");
                        LoadData(); // Verileri bir kez yenile
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
        }

        //Datagrid1 in sütun kontrolü
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Geçersiz sütunlara tıklamaları kontrol et
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (columnName == "Edit") // Düzenleme butonuna tıklanmışsa
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                EditProduct(id);
                Upload();
                return; // İşlem tamamlandıktan sonra metodu sonlandır
            }
            else if (columnName == "Delete") // Silme butonuna tıklanmışsa
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                // Çift tıklama veya başka hataları önlemek için kontrol
                if (id > 0)
                {
                    DeleteProduct(id);
                  
                }

                return; // İşlem tamamlandıktan sonra metodu sonlandır
            }
        }
        //Ürün Arama textboxu
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBox1.Text; // TextBox'taki metni al
            LoadFilteredProducts(filterText); // Filtreli ürünleri yükle
        }
        public void Upload()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();

                    // Filtreye uygun SQL sorgusu
                    string query = "SELECT adet, id, isim, fiyat, kategori FROM ürünbilgileri";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable; // DataGridView'e bağla
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void LoadFilteredProducts(string filter)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();

                    // Filtreye uygun SQL sorgusu
                    string query = "SELECT adet, id, isim, fiyat, kategori FROM ürünbilgileri WHERE isim LIKE @filter";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@filter", $"%{filter}%"); // Filtre parametresi

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable; // DataGridView'e bağla
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        //Textboxun üzerinde ara... yazısının olup tıklayınca onun gitmesi

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "Ara...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black; // Placeholder yerine metin yazarken siyah yap
            }
        }
        //Textboxun üzerinden etkileşimi bıraktıktan sonra ara... butonunun geri gelmesi

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Ara...";
                textBox1.ForeColor = Color.Gray; // Placeholder için gri renk
            }
        }
        //Verileri güncellemesi

        private void LoadData()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        //Kategori butonunun tıklanması
        private void ctgr_button_Click(object sender, EventArgs e)
        {
            groupBox0.Hide();
            groupBox1.Hide();
            groupBox2.Show();
            groupBox3.Hide();
            ctgr_combobox.Text = "Lütfen seçim yapın...";

            using (SQLiteConnection connection = new SQLiteConnection(path))
            {
                
                try
                {
                    connection.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable; // DataGridView'e veriyi bağlayın.
                    dataGridView2.Columns["id"].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        //Kategori butonundaki comboboxın eventi
        private void ctgr_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = ctgr_combobox.SelectedItem.ToString();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();

                    string query = "SELECT adet, id, isim, fiyat, kategori FROM ürünbilgileri WHERE kategori = @kategori";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kategori", selectedCategory);

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        

                        if (dataTable.Rows.Count > 0)
                        {

                            dataGridView2.Columns.Clear();
                            dataGridView2.DataSource = null;
                            dataGridView2.DataSource = dataTable;
                            dataGridView2.Columns["id"].Visible = false;

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string kategori = row["kategori"].ToString();
                                if (!ctgr_combobox.Items.Contains(kategori))
                                {
                                    ctgr_combobox.Items.Add(kategori);
                                }
                            }
                            MessageBox.Show("Bulunan ürün sayısı: " + dataTable.Rows.Count);
                            
                        }
                        else
                        {
                            MessageBox.Show("Bu kategoriye ait ürün bulunamadı.");

                        }

                        dataGridView2.DataSource = dataTable; // DataGridView'e bağla
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Ctgr_ComboBox_Enter(object sender, EventArgs e)
        {
            // Kullanıcı ComboBox'a tıkladığında metni temizle
            if (ctgr_combobox.Text == "Lütfen seçim yapın...")
            {
                ctgr_combobox.Text = "";
                ctgr_combobox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void Ctgr_ComboBox_Leave(object sender, EventArgs e)
        {
            // Kullanıcı ComboBox'dan çıkınca metin boşsa varsayılan yazıyı geri getir
            if (string.IsNullOrWhiteSpace(ctgr_combobox.Text))
            {
              
                ctgr_combobox.Text = "Lütfen seçim yapın...";
                ctgr_combobox.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void AddCartButtonToPurchase()
        {
            if (dataGridView3.Columns["sepet"] == null)
            {
                // Sepete ekle butonu
                DataGridViewButtonColumn cartButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "sepet",
                    Text = "Sepete Ekle",
                    UseColumnTextForButtonValue = true
                };
                dataGridView3.Columns.Add(cartButtonColumn);
            }
        }

        private void satimAlim_Click(object sender, EventArgs e)
        {
            groupBox0.Hide();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Show();
            satinAlim_combobox.Text = "Lütfen seçim yapın...";
            //DataGride veri bağlama
            using (SQLiteConnection connection = new SQLiteConnection(path))
            {
                try
                {
                    connection.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView3.DataSource = dataTable; // DataGridView'e veriyi bağlayın.
                    dataGridView3.Columns["id"].Visible = false;

                    AddCartButtonToPurchase(); // Sepete ekle butonunu ekle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        // Sepet için ürün listesi
        public List<(int adet, string isim, string fiyat)> sepetListesi = new List<(int, string, string)>();
        //private string adet;

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView3.Columns["sepet"].Index && e.RowIndex >= 0)
            {
                // Seçili satırın bilgilerini al
                DataGridViewRow selectedRow = dataGridView3.Rows[e.RowIndex];
                int mevcutAdet = Convert.ToInt32(selectedRow.Cells["adet"].Value);
                string isim = selectedRow.Cells["isim"].Value.ToString();
                string fiyat = selectedRow.Cells["fiyat"].Value.ToString();

                adetForm adet = new adetForm(isim, mevcutAdet);
                if (adet.ShowDialog() == DialogResult.OK)
                {
                    int secilenAdet = adet.SecilenAdet;

                    if (secilenAdet <= mevcutAdet)
                    {
                        // Ürünü sepete ekle
                        sepetListesi.Add((secilenAdet, isim, fiyat));

                        // Stok güncellemesi
                        selectedRow.Cells["adet"].Value = mevcutAdet - secilenAdet;

                        // Bilgilendirme mesajı göster
                        MessageBox.Show($"{isim} sepete eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else
                    {
                        MessageBox.Show("Yeterli adet yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
      

        private void sptEkle_btn_Click(object sender, EventArgs e)
        {
            Sepet sepetForm = new Sepet(sepetListesi);
            
            // Sepetteki ürünleri formda göster
            sepetForm.LoadSepet(sepetListesi);

            // Sepet formunu aç
            sepetForm.ShowDialog();
            
           
        }

        private void satinAlim_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = satinAlim_combobox.SelectedItem.ToString();


            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();

                    string query = "SELECT adet, id, isim, fiyat, kategori FROM ürünbilgileri WHERE kategori = @kategori";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kategori", selectedCategory);

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {

                            dataGridView3.Columns.Clear();
                            dataGridView3.DataSource = null;
                            dataGridView3.DataSource = dataTable;
                            dataGridView3.Columns["id"].Visible = false;
                            AddCartButtonToPurchase();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string kategori = row["kategori"].ToString();
                                if (!satinAlim_combobox.Items.Contains(kategori))
                                {
                                    satinAlim_combobox.Items.Add(kategori);
                                }
                            }
                            MessageBox.Show("Bulunan ürün sayısı: " + dataTable.Rows.Count);

                        }
                        else
                        {
                            MessageBox.Show("Bu kategoriye ait ürün bulunamadı.");

                        }

                        dataGridView3.DataSource = dataTable; // DataGridView'e bağla
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        public void s_Upload()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();

                    // Filtreye uygun SQL sorgusu
                    string query = "SELECT adet, id, isim, fiyat, kategori FROM ürünbilgileri";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView3.DataSource = dataTable; // DataGridView'e bağla
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void SatinAlim_ComboBox_Enter(object sender, EventArgs e)
        {
            // Kullanıcı ComboBox'a tıkladığında metni temizle
            if (satinAlim_combobox.Text == "Lütfen seçim yapın...")
            {
                satinAlim_combobox.Text = "";
                satinAlim_combobox.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void SatinAlim_ComboBox_Leave(object sender, EventArgs e)
        {
            // Kullanıcı ComboBox'dan çıkınca metin boşsa varsayılan yazıyı geri getir
            if (string.IsNullOrWhiteSpace(satinAlim_combobox.Text))
            {
                satinAlim_combobox.Text = "Lütfen seçim yapın...";
                satinAlim_combobox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            string filterText = textBox2.Text; // TextBox'taki metni al
            LoadFilteredProducts2(filterText); // Filtreli ürünleri yükle
        }
        private void LoadFilteredProducts2(string filter)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();

                    // Filtreye uygun SQL sorgusu
                    string query = "SELECT adet, id, isim, fiyat, kategori FROM ürünbilgileri WHERE isim LIKE @filter";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@filter", $"%{filter}%"); // Filtre parametresi

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView3.DataSource = dataTable; // DataGridView'e bağla
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {

            if (textBox2.Text == "Ara...")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black; // Placeholder yerine metin yazarken siyah yap
            }
        }
        //Textboxun üzerinden etkileşimi bıraktıktan sonra ara... butonunun geri gelmesi
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Ara...";
                textBox2.ForeColor = Color.Gray; // Placeholder için gri renk
            }
        }

        private void cks_btn_Click(object sender, EventArgs e)
        {
            DialogResult cıkıs = MessageBox.Show(
                      "Uygulamadan çıkmak istediğinize emin misiniz?","Çıkış",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question
                   );
            if(cıkıs == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }
    }
}
