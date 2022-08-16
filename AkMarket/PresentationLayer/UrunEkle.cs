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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        ProductOperations operations = new ProductOperations();

        public void urunEklemeHatasi(Exception ex)
        {
            MessageBox.Show("Hata:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_urunKaydet_Click(object sender, EventArgs e)
        {
            if ((textBox_urunAdi.Text.Trim().Equals("")||textBox_urunAgirligi.Text.Trim().Equals("")||textBox_urunFiyati.Text.Trim().Equals("")||textBox_stokAdedi.Text.Trim().Equals("")))
            {
                MessageBox.Show("Alanların boş olmadığından emin olun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    byte kategori = Convert.ToByte(comboBox_kategori.SelectedValue);
                    byte urunTipi = Convert.ToByte(comboBox_urunTipi.SelectedValue);
                    byte marka = Convert.ToByte(comboBox_urunMarkasi.SelectedValue);
                    string ad = textBox_urunAdi.Text;
                    int agirlik = Convert.ToInt32(textBox_urunAgirligi.Text);
                    decimal fiyat = Convert.ToDecimal(textBox_urunFiyati.Text);
                    int adet = Convert.ToInt32(textBox_stokAdedi.Text);
                    DateTime tarih = dateTimePicker_tarih.Value;

                    operations.urunEkle(kategori, urunTipi, marka, ad, agirlik, fiyat, adet, tarih);
                    eklendiBilgisi();
                }
                catch(Exception hata)
                {
                    urunEklemeHatasi(hata);
                }
                
                
            }
        }
        public void eklendiBilgisi()
        {
            temizle();
            MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void temizle()
        {
            textBox_urunAdi.Clear();
            textBox_urunAgirligi.Clear();
            textBox_urunFiyati.Clear();
            textBox_stokAdedi.Clear();
            textBox_urunAdi.Focus();
            comboBox_kategori.SelectedIndex = 0;
            comboBox_urunTipi.SelectedIndex = 0;
            comboBox_urunMarkasi.SelectedIndex = 0;
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            try
            {
                operations.comboboxDoldur(comboBox_kategori, comboBox_urunTipi, comboBox_urunMarkasi);
            }
            catch(Exception hata)
            {
                urunEklemeHatasi(hata);
            }
            
        }

        private void button_urunKaydet_MouseHover(object sender, EventArgs e)
        {
            button_urunKaydet.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_urunKaydet_MouseLeave(object sender, EventArgs e)
        {
            button_urunKaydet.BackColor = Color.GreenYellow;
            Cursor = Cursors.Default;
        }
    }
}
