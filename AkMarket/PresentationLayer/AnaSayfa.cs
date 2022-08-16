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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        ProductOperations operations = new ProductOperations();


        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            try
            {
                operations.urunleriYukle(dataGridView_tumUrunler);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
            catch(Exception ex)
            {
                anaSayfaHatasi(ex);
            }
            
        }

        public void anaSayfaHatasi(Exception ex)
        {
            MessageBox.Show("Hata:" + ex.Message, "Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox_aranacakKelime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                operations.urunArama(dataGridView_tumUrunler, textBox_aranacakKelime.Text);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
            catch(Exception ex)
            {
                anaSayfaHatasi(ex);
            }
           
        }

        private void button_urunAdlariniKucuktenBuyuge_Click(object sender, EventArgs e)
        {
            try
            {
                operations.urunAdiniKucuktenBuyuge(dataGridView_tumUrunler);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
            catch(Exception hata)
            {
                anaSayfaHatasi(hata);
            }
            
        }

        private void button_urunAdlariniKucuktenBuyuge_MouseHover(object sender, EventArgs e)
        {
            button_urunAdlariniKucuktenBuyuge.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_urunAdlariniKucuktenBuyuge_MouseLeave(object sender, EventArgs e)
        {
            button_urunAdlariniKucuktenBuyuge.BackColor = Color.PeachPuff;
            Cursor = Cursors.Default;
        }

        private void button_urunAdlariniBuyuktenKucuge_Click(object sender, EventArgs e)
        {
            try
            {
                operations.urunAdiniBuyuktenKucuge(dataGridView_tumUrunler);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
            catch(Exception hata)
            {
                anaSayfaHatasi(hata);
            }
            
        }

        private void button_urunAdlariniBuyuktenKucuge_MouseHover(object sender, EventArgs e)
        {
            button_urunAdlariniBuyuktenKucuge.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_urunAdlariniBuyuktenKucuge_MouseLeave(object sender, EventArgs e)
        {
            button_urunAdlariniBuyuktenKucuge.BackColor = Color.PeachPuff;
            Cursor = Cursors.Default;
        }

        private void button_artanAgirligaGoreSirala_MouseHover(object sender, EventArgs e)
        {
            button_artanAgirligaGoreSirala.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_artanAgirligaGoreSirala_MouseLeave(object sender, EventArgs e)
        {
            button_artanAgirligaGoreSirala.BackColor = Color.PeachPuff;
            Cursor = Cursors.Default;
        }

        private void button_artanAgirligaGoreSirala_Click(object sender, EventArgs e)
        {
            try
            {
                operations.urunleriArtanAgirliga(dataGridView_tumUrunler);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
           catch(Exception hata)
            {
                anaSayfaHatasi(hata);
            }
        }

        private void button_azalanAgirligaGoreSirala_MouseHover(object sender, EventArgs e)
        {
            button_azalanAgirligaGoreSirala.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_azalanAgirligaGoreSirala_MouseLeave(object sender, EventArgs e)
        {
            button_azalanAgirligaGoreSirala.BackColor = Color.PeachPuff;
            Cursor = Cursors.Default;
        }

        private void button_azalanAgirligaGoreSirala_Click(object sender, EventArgs e)
        {
            try
            {
                operations.urunleriAzalanAgirliga(dataGridView_tumUrunler);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
            catch(Exception hata)
            {
                anaSayfaHatasi(hata);
            }
            
        }

        private void button_artanFiyataGoreSirala_MouseHover(object sender, EventArgs e)
        {
            button_artanFiyataGoreSirala.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_artanFiyataGoreSirala_MouseLeave(object sender, EventArgs e)
        {
            button_artanFiyataGoreSirala.BackColor = Color.PeachPuff;
            Cursor = Cursors.Default;
        }

        private void button_artanFiyataGoreSirala_Click(object sender, EventArgs e)
        {
            try
            {
                operations.urunleriArtanFiyata(dataGridView_tumUrunler);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
           catch(Exception hata)
            {
                anaSayfaHatasi(hata);
            }
        }

        private void button_azalanFiyataGoreSirala_MouseHover(object sender, EventArgs e)
        {
            button_azalanFiyataGoreSirala.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_azalanFiyataGoreSirala_MouseLeave(object sender, EventArgs e)
        {
            button_azalanFiyataGoreSirala.BackColor = Color.PeachPuff;
            Cursor = Cursors.Default;
        }

        private void button_azalanFiyataGoreSirala_Click(object sender, EventArgs e)
        {
            try
            {
                operations.urunleriAzalanFiyata(dataGridView_tumUrunler);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
            catch(Exception hata)
            {
                anaSayfaHatasi(hata);
            }
            
        }

        private void button_artanStogaGoreSirala_MouseHover(object sender, EventArgs e)
        {
            button_artanStogaGoreSirala.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_artanStogaGoreSirala_MouseLeave(object sender, EventArgs e)
        {
            button_artanStogaGoreSirala.BackColor = Color.PeachPuff;
            Cursor = Cursors.Default;
        }

        private void button_artanStogaGoreSirala_Click(object sender, EventArgs e)
        {
            try
            {
                operations.urunleriArtanStoga(dataGridView_tumUrunler);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
            catch(Exception hata)
            {
                anaSayfaHatasi(hata);
            }
            
        }

        private void button_azalanStogaGoreSirala_MouseHover(object sender, EventArgs e)
        {
            button_azalanStogaGoreSirala.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_azalanStogaGoreSirala_MouseLeave(object sender, EventArgs e)
        {
            button_azalanStogaGoreSirala.BackColor = Color.PeachPuff;
            Cursor = Cursors.Default;
        }

        private void button_azalanStogaGoreSirala_Click(object sender, EventArgs e)
        {
            try
            {
                operations.urunleriAzalanStoga(dataGridView_tumUrunler);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
            catch(Exception hata)
            {
                anaSayfaHatasi(hata);
            }
        }

        private void button_urunleriEnYeniKayitTarihineGore_MouseHover(object sender, EventArgs e)
        {
            button_urunleriEnYeniKayitTarihineGore.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_urunleriEnYeniKayitTarihineGore_MouseLeave(object sender, EventArgs e)
        {
            button_urunleriEnYeniKayitTarihineGore.BackColor = Color.PeachPuff;
            Cursor = Cursors.Default;
        }

        private void button_urunleriEnYeniKayitTarihineGore_Click(object sender, EventArgs e)
        {
            try
            {
                operations.urunleriEnYeni(dataGridView_tumUrunler);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
            catch(Exception hata)
            {
                anaSayfaHatasi(hata);
            }
            
        }

        private void button_urunleriEnEskiKayitTarihineGore_MouseHover(object sender, EventArgs e)
        {
            button_urunleriEnEskiKayitTarihineGore.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_urunleriEnEskiKayitTarihineGore_MouseLeave(object sender, EventArgs e)
        {
            button_urunleriEnEskiKayitTarihineGore.BackColor = Color.PeachPuff;
            Cursor = Cursors.Default;
        }

        private void button_urunleriEnEskiKayitTarihineGore_Click(object sender, EventArgs e)
        {
            try
            {
                operations.urunleriEnEski(dataGridView_tumUrunler);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
            catch(Exception hata)
            {
                anaSayfaHatasi(hata);
            }
           
        }
    }
}
