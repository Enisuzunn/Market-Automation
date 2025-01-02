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
    public partial class PasswordForm : Form
    {
        public bool IsAuthenticated { get; private set; } = false;
        string path = @"Data source = ..\..\Database\database.db; Version = 3;";
        
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string yöneticiadi = textBoxUsername.Text; // Kullanıcı adı TextBox
            string sifre = textBoxPassword.Text;       // Şifre TextBox

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
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Geçersiz kullanıcı adı veya şifre. Lütfen tekrar deneyin.");
                            textBoxUsername.Clear();
                            textBoxPassword.Clear();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
