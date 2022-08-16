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
using System.Windows.Forms.DataVisualization.Charting;

namespace AkMarket.PresentationLayer
{
    public partial class Istatistik : Form
    {
        public Istatistik()
        {
            InitializeComponent();
        }

        ProductOperations operations = new ProductOperations();

        private void Istatistik_Load(object sender, EventArgs e)
        {
            try
            {
                kategorilereGoreStokAdetleriYukle(chart_istatistik);
            }
            catch(Exception hata)
            {
                IstatistikHatasi(hata);
            }
            
        }

        private void grafikTemizle()
        {
            chart_istatistik.Series["Kategoriler"].Points.Clear();
        }



        private void kategorilereGoreStokAdetleriYukle(Chart chart)
        {
            grafikTemizle();
            textBox_aciklama.Text = "Kategorilere Göre Stok Adetleri";
            operations.kategorilereGoreStokAdetleri(chart);
        }

        private void kategorilereGoreStokDegerleriYukle(Chart chart)
        {
            grafikTemizle();
            textBox_aciklama.Text = "Kategorilere Göre Stok Değerleri";
            operations.kategorilereGoreStokDegerleri(chart);
        }

        private void urunTiplerineGoreStokAdetleriYukle(Chart chart)
        {
            grafikTemizle();
            textBox_aciklama.Text = "Ürün Tiplerine Göre Stok Adetleri";
            operations.urunTiplerineGoreStokAdetleri(chart);
        }

        private void urunTiplerineGoreStokDegerleri(Chart chart)
        {
            grafikTemizle();
            textBox_aciklama.Text = "Ürün Tiplerine Göre Stok Değerleri";
            operations.urunTiplerineGoreStokDegerleri(chart);
        }

        private void markalaraGoreStokAdetleriYukle(Chart chart) {
            grafikTemizle();
            textBox_aciklama.Text = "Markalara Göre Stok Adetleri";
            operations.MarkalaraGoreStokAdetleri(chart);
        }

        private void markalaraGoreStokDegerleriYukle(Chart chart)
        {
            grafikTemizle();
            textBox_aciklama.Text = "Markalara Göre Stok Değerleri";
            operations.MarkalaraGoreStokDegerleri(chart);
        }

        private void button_stokAdetleriKategori_Click(object sender, EventArgs e)
        {
            try
            {
                kategorilereGoreStokAdetleriYukle(chart_istatistik);
            }
            catch(Exception hata)
            {
                IstatistikHatasi(hata);
            }
        }

        private void button_stokDegerleriKategori_Click(object sender, EventArgs e)
        {
            try
            {
                kategorilereGoreStokDegerleriYukle(chart_istatistik);
            }
            catch(Exception hata)
            {
                IstatistikHatasi(hata);
            }
           
        }

        private void button_stokAdetleriUrun_Click(object sender, EventArgs e)
        {
            try
            {
                urunTiplerineGoreStokAdetleriYukle(chart_istatistik);
            }
            catch(Exception hata)
            {
                IstatistikHatasi(hata);
            }
            
        }

        private void button_stokDegerleriUrun_Click(object sender, EventArgs e)
        {
            try
            {
                urunTiplerineGoreStokDegerleri(chart_istatistik);
            }
            catch(Exception hata)
            {
                IstatistikHatasi(hata);
            }
            
        }

        private void button_stokAdetleriMarka_Click(object sender, EventArgs e)
        {
            try
            {
                markalaraGoreStokAdetleriYukle(chart_istatistik);
            }
            catch(Exception hata)
            {
                IstatistikHatasi(hata);
            }
           
        }

        private void button_stokDegerleriMarka_Click(object sender, EventArgs e)
        {
            try
            {
                markalaraGoreStokDegerleriYukle(chart_istatistik);
            }
            catch(Exception hata)
            {
                IstatistikHatasi(hata);
            }
            
        }   

        private void IstatistikHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_stokAdetleriKategori_MouseHover(object sender, EventArgs e)
        {
            button_stokAdetleriKategori.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_stokAdetleriKategori_MouseLeave(object sender, EventArgs e)
        {
            button_stokAdetleriKategori.BackColor = Color.Bisque;
            Cursor = Cursors.Default;
        }

        private void button_stokDegerleriKategori_MouseHover(object sender, EventArgs e)
        {
            button_stokDegerleriKategori.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_stokDegerleriKategori_MouseLeave(object sender, EventArgs e)
        {
            button_stokDegerleriKategori.BackColor = Color.Bisque;
            Cursor = Cursors.Default;
        }

        private void button_stokAdetleriUrun_MouseHover(object sender, EventArgs e)
        {
            button_stokAdetleriUrun.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_stokAdetleriUrun_MouseLeave(object sender, EventArgs e)
        {
            button_stokAdetleriUrun.BackColor = Color.Bisque;
            Cursor = Cursors.Default;
        }

        private void button_stokDegerleriUrun_MouseHover(object sender, EventArgs e)
        {
            button_stokDegerleriUrun.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_stokDegerleriUrun_MouseLeave(object sender, EventArgs e)
        {
            button_stokDegerleriUrun.BackColor = Color.Bisque;
            Cursor = Cursors.Default;
        }

        private void button_stokAdetleriMarka_MouseHover(object sender, EventArgs e)
        {
            button_stokAdetleriMarka.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_stokAdetleriMarka_MouseLeave(object sender, EventArgs e)
        {
            button_stokAdetleriMarka.BackColor = Color.Bisque;
            Cursor = Cursors.Default;
        }

        private void button_stokDegerleriMarka_MouseHover(object sender, EventArgs e)
        {
            button_stokDegerleriMarka.BackColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void button_stokDegerleriMarka_MouseLeave(object sender, EventArgs e)
        {
            button_stokDegerleriMarka.BackColor = Color.Bisque;
            Cursor = Cursors.Default;
        }
    }
}
