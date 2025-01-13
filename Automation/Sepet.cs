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
  
    public partial class Sepet : Form
    {
        string path = @"Data source = database.db; Version = 3;";
        string cmd = "SELECT adet, id, isim, fiyat, kategori FROM ürünbilgileri";
        public List<(int adet, string isim, string fiyat)> sepetListesi = new List<(int adet, string isim, string fiyat)>();
        public Sepet(List<(int adet, string isim, string fiyat)> sepetListesi)
        {
            this.sepetListesi = sepetListesi;
            InitializeComponent();

        }
        public bool sepet(string adet, string isim, string fiyat)
        {

            // Sepette aynı isimde bir ürün var mı kontrol et
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["isim"].Value != null && row.Cells["isim"].Value.ToString() == isim)
                {
                    // Eğer ürün zaten varsa, kullanıcıya sor
                    DialogResult result = MessageBox.Show(
                        "Bu ürün sepetinizde zaten var. Tekrar eklemek ister misiniz?",
                        "Ürün Zaten Var",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Eğer kullanıcı hayır derse, metodu sonlandır ve false döndür
                    if (result == DialogResult.No)
                    {
                        return false;
                    }

                    // Eğer kullanıcı evet derse, döngüden çık ve ürünü eklemeye devam et
                    break;
                }
            }

            // Ürün sepette yoksa veya kullanıcı evet dediyse ürünü ekle
            dataGridView1.Rows.Add(adet, isim, fiyat);
            UpdateToplamFiyat();
            return true;
        }

        public void LoadSepet(List<(int adet, string isim, string fiyat)> sepetListesi)
        {
            // Sepet listesinde yer alan ürünleri DataGridView'e ekle
            foreach (var urun in sepetListesi)
            {
                dataGridView1.Rows.Add(urun.adet, urun.isim, urun.fiyat);
            }
            UpdateToplamFiyat();
        }
        private void SepetForm_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("adet", "Ürün Adedi");
                dataGridView1.Columns.Add("isim", "Ürün İsmi");
                dataGridView1.Columns.Add("fiyat", "Fiyat");

            }
            if (dataGridView1.Columns["sil"] == null)
            {
                DataGridViewButtonColumn silButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "sil",
                    HeaderText = "Sil",
                    Text = "Sil",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(silButtonColumn);
            }

            UpdateToplamFiyat();
        }
        public void UpdateToplamFiyat()
        {
            double toplamFiyat = 0;

            // DataGridView'deki fiyat sütununu topla
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["adet"].Value != null && row.Cells["fiyat"].Value != null)
                {
                    if (int.TryParse(row.Cells["adet"].Value.ToString(), out int adet) &&
                        double.TryParse(row.Cells["fiyat"].Value.ToString(), out double fiyat))
                    {
                        toplamFiyat += adet * fiyat;
                    }
                }
            }

            // Label'ı güncelle
            labelToplamFiyat.Text = $"Toplam Fiyat: {toplamFiyat:C}";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["sil"].Index & e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                sepetListesi.RemoveRange(e.RowIndex, 1);
                mainView main = (mainView)Application.OpenForms["mainview"];
                main.s_Upload();
                UpdateToplamFiyat();

            }
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(path))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = conn;

                    foreach (var item in sepetListesi) // sepetListesi, sepetteki ürünlerin listesi
                    {
                        cmd.CommandText = "UPDATE ürünbilgileri SET adet = adet - @adet WHERE isim = @isim";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@adet", item.adet);
                        cmd.Parameters.AddWithValue("@isim", item.isim);

                        cmd.ExecuteNonQuery(); // SQL sorgusunu çalıştır

                    }
                }
                dataGridView1.Rows.RemoveAt(0);
                sepetListesi.RemoveRange(0, sepetListesi.Count);
                

                // Kullanıcıya satın alma işleminin başarılı olduğunu bildir
                MessageBox.Show("Satın alma işlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // DataGridView'deki satırları temizle
                dataGridView1.Rows.Clear();

                // Toplam fiyatı sıfırla
                labelToplamFiyat.Text = "Toplam Fiyat: 0";
           
                dataGridView1.Rows.Clear();
                this.Hide();

            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya mesaj göster
                MessageBox.Show("Satın alma işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnIptal_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıya iptal olup olmayacağını sor
                DialogResult result = MessageBox.Show(
                "Satın alma işlemini iptal etmek istiyor musunuz ? ","Uyarı",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {
                    sepetListesi.RemoveRange(0, sepetListesi.Count);
                    MessageBox.Show("Satın alma işlemi iptal edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainView main = (mainView)Application.OpenForms["mainview"];
                    main.s_Upload();
                    this.Hide();
                    // DataGridView'deki satırları temizle
                    dataGridView1.Rows.Clear();
                    // Toplam fiyatı sıfırla
                    labelToplamFiyat.Text = "Toplam Fiyat: 0";
                }
               
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya mesaj göster
                MessageBox.Show("Satın alma işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }          
    }

}
