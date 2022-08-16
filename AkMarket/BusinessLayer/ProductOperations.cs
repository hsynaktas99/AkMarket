using AkMarket.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AkMarket.BusinessLayer
{
    class ProductOperations
    {
        ProductDAL dal = new ProductDAL();

        public void urunleriYukle(DataGridView dataGridView)
        {
            dal.urunleriGetir(dataGridView);
        }


        public string kelimeFiltreleme(string kelime)
        {
            // ç ğ ı ö ş ü
            string yeniKelime = kelime.Trim();
            yeniKelime = yeniKelime.ToLower();
            yeniKelime = yeniKelime.Replace('ç', 'c');
            yeniKelime = yeniKelime.Replace('ğ', 'g');
            yeniKelime = yeniKelime.Replace('ı', 'i');
            yeniKelime = yeniKelime.Replace('ö', 'o');
            yeniKelime = yeniKelime.Replace('ş', 's');
            yeniKelime = yeniKelime.Replace('ü', 'u');
            return yeniKelime;
        }


        public void urunArama(DataGridView dataGridView, string kelime)
        {
            
            dal.urunArama(dataGridView,kelimeFiltreleme(kelime));

        }

        public void urunAdiniKucuktenBuyuge(DataGridView dataGridView)
        {
            dal.urunAdiniKucuktenBuyuge(dataGridView);
        }

        public void urunAdiniBuyuktenKucuge(DataGridView dataGridView)
        {
            dal.urunAdiniBuyuktenKucuge(dataGridView);
        }

        public void urunleriArtanAgirliga(DataGridView dataGridView)
        {
            dal.urunleriArtanAgirliga(dataGridView);
        }

        public void urunleriAzalanAgirliga(DataGridView dataGridView)
        {
            dal.urunleriAzalanAgirliga(dataGridView);
        }

        public void urunleriArtanFiyata(DataGridView dataGridView)
        {
            dal.urunleriArtanFiyata(dataGridView);
        }

        public void urunleriAzalanFiyata(DataGridView dataGridView)
        {
            dal.urunleriAzalanFiyata(dataGridView);
        }

        public void urunleriArtanStoga(DataGridView dataGridView)
        {
            dal.urunleriArtanStoga(dataGridView);
        }

        public void urunleriAzalanStoga(DataGridView dataGridView)
        {
            dal.urunleriAzalanStoga(dataGridView);
        }

        public void urunleriEnYeni(DataGridView dataGridView)
        {
            dal.urunleriEnYeni(dataGridView);

        }

        public void urunleriEnEski(DataGridView dataGridView)
        {
            dal.urunleriEnEski(dataGridView);
        }

        public void urunEkle(byte kategori, byte tip, byte marka, string ad, int agirlik, decimal fiyat, int adet, DateTime tarih)
        {
            dal.urunEkle(kategori, tip, marka, kelimeFiltreleme(ad), agirlik, fiyat, adet, tarih);

        }

        public void comboboxDoldur(ComboBox kategori, ComboBox urunTipi, ComboBox marka)
        {
            dal.comboboxDoldur(kategori, urunTipi, marka);
        }

        public void urunGuncelle(int id, byte kategori, byte tip, byte marka, string ad, int agirlik, decimal fiyat, int adet, DateTime tarih)
        {
            dal.urunGuncelle(id,kategori,tip,marka,kelimeFiltreleme(ad),agirlik,fiyat,adet,tarih);
        }
        public void urunGuncelleDoldur(DataGridView dataGridView, ComboBox kategori, ComboBox urunTipi, ComboBox marka)
        {
            dal.urunGuncelleDoldur(dataGridView, kategori, urunTipi, marka);
        }

        public void urunSil(int id)
        {
            dal.urunSil(id);

        }

        public void kategorilereGoreStokAdetleri(Chart chart)
        {
            dal.kategorilereGoreStokAdetleri( chart);
        }

        public void kategorilereGoreStokDegerleri(Chart chart)
        {
            dal.kategorilereGoreStokDegerleri(chart);
        }

        public void urunTiplerineGoreStokAdetleri(Chart chart)
        {
            dal.urunTiplerineGoreStokAdetleri(chart);
        }

        public void urunTiplerineGoreStokDegerleri(Chart chart)
        {
            dal.urunTiplerineGoreStokDegerleri(chart);
        }

        public void MarkalaraGoreStokAdetleri(Chart chart)
        {
            dal.MarkalaraGoreStokAdetleri(chart);
        }

        public void MarkalaraGoreStokDegerleri(Chart chart)
        {
            dal.MarkalaraGoreStokDegerleri(chart);
        }

        public void toplamSatirGoster(Label label, DataGridView dataGridView)
        {
            dal.toplamSatirGoster(label, dataGridView);
        }

    }
}
