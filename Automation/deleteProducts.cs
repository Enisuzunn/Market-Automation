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
    public partial class deleteProducts : Form
    {
        public bool IsAuthenticated { get; private set; } = false;
        

        string path = @"Data source = database.db; Version = 3;";
        public deleteProducts()
        {
            InitializeComponent();
        }

        private void btnConfirm2_Click(object sender, EventArgs e)
        {
            string yöneticiadi = textBoxUsername2.Text; // Kullanıcı adı TextBox
            string sifre = textBoxPassword2.Text;       // Şifre TextBox

            using (SQLiteConnection conn = new SQLiteConnection(path))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM yoneticiler WHERE yöneticiadi = @yöneticiadi AND sifre = @sifre";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@yöneticiadi", yöneticiadi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        int userExists = Convert.ToInt32(cmd.ExecuteScalar());
                        if (userExists > 0)
                        {
                            IsAuthenticated = true;
                            this.DialogResult = DialogResult.OK; // Doğrulama başarılı, form kapatılır
                        }
                        else
                        {
                            MessageBox.Show("Geçersiz kullanıcı adı veya şifre. Lütfen tekrar deneyin.");
                            textBoxUsername2.Clear();
                            textBoxPassword2.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            IsAuthenticated = false; // Doğrulama başarısız
            this.DialogResult = DialogResult.Cancel; // Formu iptal olarak kapat
            this.Close(); // Formu kapat
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                textBoxPassword2.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPassword2.UseSystemPasswordChar = false;
            }
        }
    }
    
}
