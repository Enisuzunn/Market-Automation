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
    public partial class düzenle : Form
    {

        PasswordForm passwordForm = new PasswordForm();
        string path = @"Data source = ..\..\Database\database.db; Version = 3;";
        string updateText = @" UPDATE ürünbilgileri SET isim = @isim,  fiyat = @fiyat,  kategori = @kategori WHERE id = @id";
        int id = 0;
        public düzenle(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kydtdzn_btn_Click(object sender, EventArgs e)
        {
            string isim = ısmdzn_txtbox.Text;          // Name TextBox
            string kategori = ktgrdzn_cmbbox.Text;    // Category ComboBox
            decimal fiyat;
            if (string.IsNullOrWhiteSpace(ısmdzn_txtbox.Text) || string.IsNullOrWhiteSpace(fytdzn_txtbox.Text) || string.IsNullOrWhiteSpace(ktgrdzn_cmbbox.Text))
            {
                MessageBox.Show("Kullanıcı adı , şifre ve kategoriler boş olmamalı");
                return;
            }
            // Fiyatın geçerliliğini kontrol et
            if (!decimal.TryParse(fytdzn_txtbox.Text, out fiyat))
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
                        using (SQLiteCommand cmd = new SQLiteCommand(updateText, conn))
                        {
                            // Sorgu parametrelerini ayarla
                            cmd.Parameters.AddWithValue("@isim", isim);
                            cmd.Parameters.AddWithValue("@fiyat", fiyat);
                            cmd.Parameters.AddWithValue("@kategori", kategori);
                            cmd.Parameters.AddWithValue("@id", id);

                            // Veritabanına ekleme işlemini gerçekleştir
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Ürün başarıyla değiştirildi!");
                                ısmdzn_txtbox.Text = "";
                                fytdzn_txtbox.Text = "";
                                ktgrdzn_cmbbox.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Ürün değiştirilirken bir hata oluştu.");
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

        private void kptdzn_txtbox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
