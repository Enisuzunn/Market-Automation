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
    

    public partial class adetForm : Form
    {
        public int SecilenAdet { get; private set; }
        private int mevcutAdet;
        private string urunIsmi;
        

        public adetForm(string urunIsmi, int mevcutAdet)
        {
            InitializeComponent();
            this.urunIsmi = urunIsmi;
            this.mevcutAdet = mevcutAdet;
            this.Text = $"{urunIsmi} - Adet Seçimi";
            label1.Text = "Kaç adet eklemek istiyorsunuz?";
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 1000;
        }
        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                numericUpDown1.Select(0, numericUpDown1.Text.Length);
            }
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                numericUpDown1.Select(0, numericUpDown1.Text.Length);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Lütfen sıfırdan büyük bir değer girin.", "Geçersiz Değer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SecilenAdet = (int)numericUpDown1.Value;      
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
