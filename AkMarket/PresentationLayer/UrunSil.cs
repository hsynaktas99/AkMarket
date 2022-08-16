using AkMarket.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkMarket.PresentationLayer
{
    public partial class UrunSil : Form
    {
        public UrunSil()
        {
            InitializeComponent();
        }

        ProductOperations operations = new ProductOperations();

       

        private void UrunSil_Load(object sender, EventArgs e)
        {
            operations.urunleriYukle(dataGridView_tumUrunler);
            operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
        }
        public void urunSilmeHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView_tumUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_urunId.Text = dataGridView_tumUrunler.CurrentRow.Cells[0].Value.ToString();
                textBox_urunAdi.Text = dataGridView_tumUrunler.CurrentRow.Cells[4].Value.ToString();
            }
            catch(Exception hata)
            {
                urunSilmeHatasi(hata);
            }
           
        }

        private void textBox_urunArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                operations.urunArama(dataGridView_tumUrunler, textBox_urunArama.Text);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
            catch(Exception hata)
            {
                urunSilmeHatasi(hata);
            }
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            if (textBox_urunId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Geçerli bir ürün seçtiğinizden emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_urunId.Text);
                    operations.urunSil(id);
                    silindiBilgisi();
                    operations.urunleriYukle(dataGridView_tumUrunler);
                    operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
                }
                catch(Exception hata)
                {
                    urunSilmeHatasi(hata);
                }
            }
        }
        public void silindiBilgisi()
        {
            textBox_urunId.Clear();
            textBox_urunAdi.Clear();
            textBox_urunArama.Clear();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_sil_MouseHover(object sender, EventArgs e)
        {
            button_sil.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_sil_MouseLeave(object sender, EventArgs e)
        {
            button_sil.BackColor = Color.GreenYellow;
            Cursor = Cursors.Default;
        }
    }
}
