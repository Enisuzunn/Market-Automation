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
    public partial class addProducts : Form
    {
        PasswordForm passwordForm = new PasswordForm();
        string path = @"Data source = database.db; Version = 3;";
        string insertText = "INSERT INTO ürünbilgileri (adet, isim, fiyat, kategori) VALUES (@adet, @isim, @fiyat, @kategori)";
        

        public addProducts(int id)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal adet;
            string isim = textBox1.Text;          // Name TextBox
            string kategori = comboBox1.Text;    // Category ComboBox
            decimal fiyat;
            if (string.IsNullOrWhiteSpace(adtbox.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Kullanıcı adı , şifre , ürün adedi ve kategoriler boş olmamalı");
                return;
            }
            if (!decimal.TryParse(adtbox.Text, out adet))
            {
                MessageBox.Show("Lütfen geçerli bir adet giriniz.");
                return;
            }
            // Fiyatın geçerliliğini kontrol et
            if (!decimal.TryParse(textBox2.Text, out fiyat))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat giriniz.");
                return;
            }
            if (passwordForm.ShowDialog() == DialogResult.OK && passwordForm.IsAuthenticated)
            {
                // SQLite bağlantısı ile veritabanına veri ekle
                using (SQLiteConnection conn = new SQLiteConnection(path))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(insertText, conn))
                    {
                            // Sorgu parametrelerini ayarla
                        cmd.Parameters.AddWithValue("@adet", adet);
                        cmd.Parameters.AddWithValue("@isim", isim);
                        cmd.Parameters.AddWithValue("@fiyat", fiyat);
                        cmd.Parameters.AddWithValue("@kategori", kategori);

                        // Veritabanına ekleme işlemini gerçekleştir
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ürün başarıyla eklendi!");
                                adtbox.Text = "";
                                textBox1.Text = "";
                                textBox2.Text = "";
                                comboBox1.SelectedIndex = -1;
                                comboBox1.SelectedItem = null;
                            }
                        else
                        {
                            MessageBox.Show("Ürün eklenirken bir hata oluştu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
             }
            }
            else
            {
                MessageBox.Show("Kimlik doğrulama başarısız. Ürün ekleme iptal edildi.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }   
    }
}

