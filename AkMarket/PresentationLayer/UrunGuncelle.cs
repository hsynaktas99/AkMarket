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


    public partial class UrunGuncelle : Form
    {
        public UrunGuncelle()
        {
            InitializeComponent();
        }

        ProductOperations operations = new ProductOperations();

        private void UrunGuncelle_Load(object sender, EventArgs e)
        {
            try
            {
                operations.urunGuncelleDoldur(dataGridView_tumUrunler, comboBox_kategori, comboBox_urunTipi, comboBox_urunMarkasi);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
            catch(Exception ex)
            {
                urunGullemeHatasi(ex);
            }
        }

        public void urunGullemeHatasi(Exception ex)
        {
            MessageBox.Show("Hata:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView_tumUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                textBox_urunId.Text = dataGridView_tumUrunler.CurrentRow.Cells[0].Value.ToString();
                textBox_urunAdi.Text = dataGridView_tumUrunler.CurrentRow.Cells[4].Value.ToString();
                textBox_urunAgirligi.Text = dataGridView_tumUrunler.CurrentRow.Cells[5].Value.ToString();
                textBox_urunFiyati.Text = dataGridView_tumUrunler.CurrentRow.Cells[6].Value.ToString();
                textBox_stokAdedi.Text = dataGridView_tumUrunler.CurrentRow.Cells[7].Value.ToString();
                dateTimePicker_tarih.Value = (DateTime)dataGridView_tumUrunler.CurrentRow.Cells[8].Value;
            }
            catch(Exception hata)
            {
                urunGullemeHatasi(hata);
            }
            
        }

        private void button_urunGuncelle_Click(object sender, EventArgs e)
        {
            if ((textBox_urunAdi.Text.Trim().Equals("") || textBox_urunAgirligi.Text.Trim().Equals("") || textBox_urunFiyati.Text.Trim().Equals("") || textBox_stokAdedi.Text.Trim().Equals("")))
            {
                MessageBox.Show("Alanların boş olmadığından emin olun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_urunId.Text);
                    byte kategori = Convert.ToByte(comboBox_kategori.SelectedValue);
                    byte urunTipi = Convert.ToByte(comboBox_urunTipi.SelectedValue);
                    byte marka = Convert.ToByte(comboBox_urunMarkasi.SelectedValue);
                    string ad = textBox_urunAdi.Text;
                    int agirlik = Convert.ToInt32(textBox_urunAgirligi.Text);
                    decimal fiyat = Convert.ToDecimal(textBox_urunFiyati.Text);
                    int adet = Convert.ToInt32(textBox_stokAdedi.Text);
                    DateTime tarih = dateTimePicker_tarih.Value;

                    operations.urunGuncelle(id,kategori, urunTipi, marka, ad, agirlik, fiyat, adet, tarih);
                    guncellendiBilgisi();
                    operations.urunleriYukle(dataGridView_tumUrunler);
                    operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
                }
                catch (Exception hata)
                {
                    urunGullemeHatasi(hata);
                }
            }
        }
        public void guncellendiBilgisi()
        {
            temizle();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void temizle()
        {
            textBox_urunId.Clear();
            textBox_urunAdi.Clear();
            textBox_urunAgirligi.Clear();
            textBox_urunFiyati.Clear();
            textBox_stokAdedi.Clear();
            comboBox_kategori.SelectedIndex = 0;
            comboBox_urunTipi.SelectedIndex = 0;
            comboBox_urunMarkasi.SelectedIndex = 0;
        }

        private void textBox_aranacakKelime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                operations.urunArama(dataGridView_tumUrunler, textBox_aranacakKelime.Text);
                operations.toplamSatirGoster(label_toplam, dataGridView_tumUrunler);
            }
            catch(Exception hata)
            {
                urunGullemeHatasi(hata);
            }
        }

        private void button_urunGuncelle_MouseHover(object sender, EventArgs e)
        {
            button_urunGuncelle.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_urunGuncelle_MouseLeave(object sender, EventArgs e)
        {
            button_urunGuncelle.BackColor = Color.GreenYellow;
            Cursor = Cursors.Default;
        }
    }
}
