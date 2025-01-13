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
    public partial class kayıtFormu : Form
    {
        string path = @"Data source = database.db; Version = 3;";
        string insertText = "INSERT INTO kayitbilgileri (username, password) VALUES (@username, @password)";
        
        public kayıtFormu()
        {
            InitializeComponent();
        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {

            if (show_password.Checked == false)
            {
                password_signup.UseSystemPasswordChar = true;
            }
            else
            {
                password_signup.UseSystemPasswordChar = false;
            }
        }

        private void show_againpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (show_againpassword.Checked == false)
            {
                againpassword_signup.UseSystemPasswordChar = true;
            }
            else
            {
                againpassword_signup.UseSystemPasswordChar = false;
            }
        }

        private void signup_btnview_Click(object sender, EventArgs e)
        {
            string username = username_signup.Text.Trim();
            string password = password_signup.Text.Trim();
            string confirmPassword = againpassword_signup.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Kullanıcı adı veya şifre alanları boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (username.Length <= 2)
            {
                MessageBox.Show("Kullanıcı adı 3 karakterden az olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password.Length <= 4)
            {
                MessageBox.Show("Parola 5 karakterden az olamaz!","Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Parolalar eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
            {
                connection.Open();

                    string checkUserQuery = "SELECT COUNT(*) FROM kayitbilgileri WHERE username = @username";
                    using (SQLiteCommand checkCommand = new SQLiteCommand(checkUserQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@username", username);

                        int userExists = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (userExists > 0)
                        {
                            MessageBox.Show("Bu kullanıcı adı zaten kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    using (SQLiteCommand command = new SQLiteCommand(insertText, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {                 
                                MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                        }
                        else
                        {        
                                MessageBox.Show("Kayıt başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);      
                        }       

                 }
            }
    }
        }

        private void signup_btnview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}