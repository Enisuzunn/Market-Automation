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
    public partial class girisFormu : Form
    {
        string path = @"Data source = ..\..\Database\database.db; Version = 3;";
        string query = "SELECT COUNT(*) FROM kayitbilgileri WHERE username = @username AND password = @password";

        public girisFormu()
        {
            InitializeComponent();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                password_box.UseSystemPasswordChar = true;
            }
            else
            {
                password_box.UseSystemPasswordChar = false;
            }
        }

        private void lgn_btn_Click(object sender, EventArgs e)
        {
            string username = username_box.Text;
            mainView mainForm = new mainView(username);
            string password = password_box.Text;
            if(string.IsNullOrWhiteSpace(username_box.Text) || string.IsNullOrWhiteSpace(password_box.Text))
            {
                MessageBox.Show("Kullanıcı adı ya da şifre boş olmamalı");
                return;
            }
            using (SQLiteConnection connection = new SQLiteConnection(path))
            {
                connection.Open();

                
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                  
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show($" Hoşgeldiniz {username}", "Giriş başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainView gecis = new mainView(username);
                        gecis.Show();
                        this.Hide();
                    }
                    else
                    {                 
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                        username_box.Text = "";
                        password_box.Text = "";
                        checkBox1.Checked = false;
                    }
                }
            }

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            kayıtFormu kayıt = new kayıtFormu();
            kayıt.ShowDialog();
        }
    }
}
