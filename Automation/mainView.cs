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
        string path = @"Data source = ..\..\Database\database.db; Version = 3;";
        string cmd = "SELECT id, isim, fiyat, kategori FROM ürünbilgileri";


        int id = 0;
        
        public mainView(string username)
        {
            InitializeComponent();
            lblwelcome.Text = "WELCOME: " + username;
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            sqlDataSource1.FillAsync();      
        }
        //Ev Butonu
        private void home_btn_Click(object sender, EventArgs e)
        {
            groupBox0.Show();
            groupBox1.Hide();
            groupBox2.Hide();
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
                    LoadData(); // Düzenleme sonrası verileri yenile
                }
            }
        }
        //Data Gridin üzerinde silme butonunun metodu
        private void DeleteProduct(int id)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?",
                                                      "Onay",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SQLiteConnection connection = new SQLiteConnection(path))
                    {
                        connection.Open();
                        string query = "DELETE FROM ürünbilgileri WHERE id = @id";

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", id);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Ürün başarıyla silindi!");
                        }
                    }
                    LoadData(); // Silme sonrası verileri yenile
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
        private void LoadFilteredProducts(string filter)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();

                    // Filtreye uygun SQL sorgusu
                    string query = "SELECT id, isim, fiyat, kategori FROM ürünbilgileri WHERE isim LIKE @filter";

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
            using (SQLiteConnection connection = new SQLiteConnection(path))
            {
                
                try
                {
                    connection.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable; // DataGridView'e veriyi bağlayın.
                    
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

                    string query = "SELECT id, isim, fiyat, kategori FROM ürünbilgileri WHERE kategori = @kategori";
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
        //Kategorileri yüklemesi
        private void LoadCategories()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();

                    // Tablodan kategori isimlerini getir
                    string query = "SELECT DISTINCT kategori FROM ürünbilgileri";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        SQLiteDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            ctgr_combobox.Items.Add(reader["kategori"].ToString()); // Kategorileri ekle
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void mainView_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
        //Arama butonu
        private void textBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {

        }

        private void satimAlim_Click(object sender, EventArgs e)
        {
            groupBox0.Hide();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Show();
        }
    }
}
