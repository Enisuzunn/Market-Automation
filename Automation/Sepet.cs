using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automation
{

    public partial class Sepet : Form
    {
       
  
        public Sepet()
        {
            InitializeComponent();
          
        }
        public bool AddToCart(string isim, string fiyat)
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
            dataGridView1.Rows.Add(isim, fiyat);
            return true;
        }

        public void LoadSepet(List<(string isim, string fiyat)> sepetListesi)
        {
            // DataGridView'i temizle
            dataGridView1.Rows.Clear();

            // Sepet listesinde yer alan ürünleri DataGridView'e ekle
            foreach (var urun in sepetListesi)
            {
                dataGridView1.Rows.Add(urun.isim, urun.fiyat);
            }
        }
        private void SepetForm_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("isim", "Ürün İsmi");
                dataGridView1.Columns.Add("fiyat", "Fiyat");

            }
        }
    }

}
