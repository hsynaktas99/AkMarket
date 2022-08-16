using AkMarket.DataAccessLayer.Context;
using AkMarket.DataAccessLayer.Entity;
using AkMarket.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AkMarket.DataAccessLayer
{
    class ProductDAL
    {


        public void urunleriGetir(DataGridView dataGridView)
        {
            using (var context = new AkMarketContext())
            {

                var liste = from p in context.Products
                            join
                            c in context.Categories on p.UrunKategori equals c.KategoriId
                            join
                            pt in context.ProductTypes on p.UrunTipi equals pt.UrunTipiId
                            join
                            m in context.TradeMarks on p.Marka equals m.MarkaId
                            select new
                            {
                                p.UrunId,
                                c.KategoriAdi,
                                pt.UrunTipiAdi,
                                m.MarkaAdi,
                                p.UrunAdi,
                                p.GramAgirlik,
                                p.UrunFiyati,
                                p.StokAdedi,
                                p.KayitTarihi
                            };

                dataGridView.DataSource = liste.ToList();

            }
        }

        public void urunArama(DataGridView dataGridView, string aranacakKelime)
        {
            using (var context = new AkMarketContext())
            {
                var liste = from p in context.Products
                            join
                            c in context.Categories on p.UrunKategori equals c.KategoriId
                            join
                            pt in context.ProductTypes on p.UrunTipi equals pt.UrunTipiId
                            join
                            m in context.TradeMarks on p.Marka equals m.MarkaId
                            where p.UrunAdi.Contains(aranacakKelime)
                            select new
                            {
                                p.UrunId,
                                c.KategoriAdi,
                                pt.UrunTipiAdi,
                                m.MarkaAdi,
                                p.UrunAdi,
                                p.GramAgirlik,
                                p.UrunFiyati,
                                p.StokAdedi,
                                p.KayitTarihi
                            };

                dataGridView.DataSource = liste.ToList();

            }

        }

        public void urunAdiniKucuktenBuyuge(DataGridView dataGridView)
        {
            using (var context = new AkMarketContext())
            {
                var liste = from p in context.Products
                            join
                            c in context.Categories on p.UrunKategori equals c.KategoriId
                            join
                            pt in context.ProductTypes on p.UrunTipi equals pt.UrunTipiId
                            join
                            m in context.TradeMarks on p.Marka equals m.MarkaId
                            orderby p.UrunAdi ascending
                            select new
                            {
                                p.UrunId,
                                c.KategoriAdi,
                                pt.UrunTipiAdi,
                                m.MarkaAdi,
                                p.UrunAdi,
                                p.GramAgirlik,
                                p.UrunFiyati,
                                p.StokAdedi,
                                p.KayitTarihi
                            };

                dataGridView.DataSource = liste.ToList();

            }
        }

        public void urunAdiniBuyuktenKucuge(DataGridView dataGridView)
        {
            using (var context = new AkMarketContext())
            {

                var liste = from p in context.Products
                            join
                            c in context.Categories on p.UrunKategori equals c.KategoriId
                            join
                            pt in context.ProductTypes on p.UrunTipi equals pt.UrunTipiId
                            join
                            m in context.TradeMarks on p.Marka equals m.MarkaId
                            orderby p.UrunAdi descending
                            select new
                            {
                                p.UrunId,
                                c.KategoriAdi,
                                pt.UrunTipiAdi,
                                m.MarkaAdi,
                                p.UrunAdi,
                                p.GramAgirlik,
                                p.UrunFiyati,
                                p.StokAdedi,
                                p.KayitTarihi
                            };

                dataGridView.DataSource = liste.ToList();


            }
        }
        public void urunleriArtanAgirliga(DataGridView dataGridView)
        {
            using (var context = new AkMarketContext())
            {

                var liste = from p in context.Products
                            join
                            c in context.Categories on p.UrunKategori equals c.KategoriId
                            join
                            pt in context.ProductTypes on p.UrunTipi equals pt.UrunTipiId
                            join
                            m in context.TradeMarks on p.Marka equals m.MarkaId
                            orderby p.GramAgirlik ascending
                            select new
                            {
                                p.UrunId,
                                c.KategoriAdi,
                                pt.UrunTipiAdi,
                                m.MarkaAdi,
                                p.UrunAdi,
                                p.GramAgirlik,
                                p.UrunFiyati,
                                p.StokAdedi,
                                p.KayitTarihi
                            };

                dataGridView.DataSource = liste.ToList();

            }
        }

        public void urunleriAzalanAgirliga(DataGridView dataGridView)
        {
            using (var context = new AkMarketContext())
            {

                var liste = from p in context.Products
                            join
                            c in context.Categories on p.UrunKategori equals c.KategoriId
                            join
                            pt in context.ProductTypes on p.UrunTipi equals pt.UrunTipiId
                            join
                            m in context.TradeMarks on p.Marka equals m.MarkaId
                            orderby p.GramAgirlik descending
                            select new
                            {
                                p.UrunId,
                                c.KategoriAdi,
                                pt.UrunTipiAdi,
                                m.MarkaAdi,
                                p.UrunAdi,
                                p.GramAgirlik,
                                p.UrunFiyati,
                                p.StokAdedi,
                                p.KayitTarihi
                            };

                dataGridView.DataSource = liste.ToList();

            }
        }

        public void urunleriArtanFiyata(DataGridView dataGridView)
        {
            using (var context = new AkMarketContext())
            {

                var liste = from p in context.Products
                            join
                            c in context.Categories on p.UrunKategori equals c.KategoriId
                            join
                            pt in context.ProductTypes on p.UrunTipi equals pt.UrunTipiId
                            join
                            m in context.TradeMarks on p.Marka equals m.MarkaId
                            orderby p.UrunFiyati ascending
                            select new
                            {
                                p.UrunId,
                                c.KategoriAdi,
                                pt.UrunTipiAdi,
                                m.MarkaAdi,
                                p.UrunAdi,
                                p.GramAgirlik,
                                p.UrunFiyati,
                                p.StokAdedi,
                                p.KayitTarihi
                            };

                dataGridView.DataSource = liste.ToList();

            }
        }

        public void urunleriAzalanFiyata(DataGridView dataGridView)
        {
            using (var context = new AkMarketContext())
            {

                var liste = from p in context.Products
                            join
                            c in context.Categories on p.UrunKategori equals c.KategoriId
                            join
                            pt in context.ProductTypes on p.UrunTipi equals pt.UrunTipiId
                            join
                            m in context.TradeMarks on p.Marka equals m.MarkaId
                            orderby p.UrunFiyati descending
                            select new
                            {
                                p.UrunId,
                                c.KategoriAdi,
                                pt.UrunTipiAdi,
                                m.MarkaAdi,
                                p.UrunAdi,
                                p.GramAgirlik,
                                p.UrunFiyati,
                                p.StokAdedi,
                                p.KayitTarihi
                            };

                dataGridView.DataSource = liste.ToList();

            }
        }

        public void urunleriArtanStoga(DataGridView dataGridView)
        {
            using (var context = new AkMarketContext())
            {

                var liste = from p in context.Products
                            join
                            c in context.Categories on p.UrunKategori equals c.KategoriId
                            join
                            pt in context.ProductTypes on p.UrunTipi equals pt.UrunTipiId
                            join
                            m in context.TradeMarks on p.Marka equals m.MarkaId
                            orderby p.StokAdedi ascending
                            select new
                            {
                                p.UrunId,
                                c.KategoriAdi,
                                pt.UrunTipiAdi,
                                m.MarkaAdi,
                                p.UrunAdi,
                                p.GramAgirlik,
                                p.UrunFiyati,
                                p.StokAdedi,
                                p.KayitTarihi
                            };

                dataGridView.DataSource = liste.ToList();

            }
        }

        public void urunleriAzalanStoga(DataGridView dataGridView)
        {
            using (var context = new AkMarketContext())
            {

                var liste = from p in context.Products
                            join
                            c in context.Categories on p.UrunKategori equals c.KategoriId
                            join
                            pt in context.ProductTypes on p.UrunTipi equals pt.UrunTipiId
                            join
                            m in context.TradeMarks on p.Marka equals m.MarkaId
                            orderby p.StokAdedi descending
                            select new
                            {
                                p.UrunId,
                                c.KategoriAdi,
                                pt.UrunTipiAdi,
                                m.MarkaAdi,
                                p.UrunAdi,
                                p.GramAgirlik,
                                p.UrunFiyati,
                                p.StokAdedi,
                                p.KayitTarihi
                            };

                dataGridView.DataSource = liste.ToList();

            }
        }

        public void urunleriEnYeni(DataGridView dataGridView)
        {
            using (var context = new AkMarketContext())
            {

                var liste = from p in context.Products
                            join
                            c in context.Categories on p.UrunKategori equals c.KategoriId
                            join
                            pt in context.ProductTypes on p.UrunTipi equals pt.UrunTipiId
                            join
                            m in context.TradeMarks on p.Marka equals m.MarkaId
                            orderby p.KayitTarihi descending
                            select new
                            {
                                p.UrunId,
                                c.KategoriAdi,
                                pt.UrunTipiAdi,
                                m.MarkaAdi,
                                p.UrunAdi,
                                p.GramAgirlik,
                                p.UrunFiyati,
                                p.StokAdedi,
                                p.KayitTarihi
                            };

                dataGridView.DataSource = liste.ToList();

            }
        }

        public void urunleriEnEski(DataGridView dataGridView)
        {
            using (var context = new AkMarketContext())
            {

                var liste = from p in context.Products
                            join
                            c in context.Categories on p.UrunKategori equals c.KategoriId
                            join
                            pt in context.ProductTypes on p.UrunTipi equals pt.UrunTipiId
                            join
                            m in context.TradeMarks on p.Marka equals m.MarkaId
                            orderby p.KayitTarihi ascending
                            select new
                            {
                                p.UrunId,
                                c.KategoriAdi,
                                pt.UrunTipiAdi,
                                m.MarkaAdi,
                                p.UrunAdi,
                                p.GramAgirlik,
                                p.UrunFiyati,
                                p.StokAdedi,
                                p.KayitTarihi
                            };

                dataGridView.DataSource = liste.ToList();

            }
        }

        public void urunEkle(byte kategori, byte tip, byte marka, string ad, int agirlik, decimal fiyat, int adet, DateTime tarih)
        {

            using (var context = new AkMarketContext())
            {
                Product urun = new Product
                {
                    UrunKategori = kategori,
                    UrunTipi = tip,
                    Marka = marka,
                    UrunAdi = ad,
                    GramAgirlik = agirlik,
                    UrunFiyati = fiyat,
                    StokAdedi = adet,
                    KayitTarihi = tarih
                };

                context.Products.Add(urun);
                context.SaveChanges();

            }
        }

        public void comboboxDoldur(ComboBox kategori, ComboBox urunTipi, ComboBox marka)
        {
            using (var context = new AkMarketContext())
            {

                var kategoriler = (from k in context.Categories
                                   select k).ToList();

                kategori.DisplayMember = "KategoriAdi";
                kategori.ValueMember = "KategoriId";
                kategori.DataSource = kategoriler;

                var urunTipleri = (from u in context.ProductTypes
                                   select u).ToList();

                urunTipi.DisplayMember = "UrunTipiAdi";
                urunTipi.ValueMember = "UrunTipiId";
                urunTipi.DataSource = urunTipleri;

                var markalar = (from m in context.TradeMarks
                                select m).ToList();
                marka.DisplayMember = "MarkaAdi";
                marka.ValueMember = "MarkaId";
                marka.DataSource = markalar;

            }
        }

        public void urunGuncelle(int id, byte kategori, byte tip, byte marka, string ad, int agirlik, decimal fiyat, int adet, DateTime tarih)
        {
            using (var context = new AkMarketContext())
            {
                Product product = context.Products.Find(id);

                product.UrunKategori = kategori;
                product.UrunTipi = tip;
                product.Marka = marka;
                product.UrunAdi = ad;
                product.GramAgirlik = agirlik;
                product.UrunFiyati = fiyat;
                product.StokAdedi = adet;
                product.KayitTarihi = tarih;

                context.SaveChanges();
            }
        }

        public void urunGuncelleDoldur(DataGridView dataGridView, ComboBox kategori, ComboBox urunTipi, ComboBox marka)
        {
            using (var context = new AkMarketContext())
            {

                var liste = from p in context.Products
                            join
                            c in context.Categories on p.UrunKategori equals c.KategoriId
                            join
                            pt in context.ProductTypes on p.UrunTipi equals pt.UrunTipiId
                            join
                            m in context.TradeMarks on p.Marka equals m.MarkaId
                            select new
                            {
                                p.UrunId,
                                c.KategoriAdi,
                                pt.UrunTipiAdi,
                                m.MarkaAdi,
                                p.UrunAdi,
                                p.GramAgirlik,
                                p.UrunFiyati,
                                p.StokAdedi,
                                p.KayitTarihi
                            };

                dataGridView.DataSource = liste.ToList();

                var kategoriler = from c in context.Categories
                                  select c;
                kategori.DisplayMember = "KategoriAdi";
                kategori.ValueMember = "KategoriId";
                kategori.DataSource = kategoriler.ToList();

                var urunTipleri = from u in context.ProductTypes
                                  select u;
                urunTipi.DisplayMember = "UrunTipiAdi";
                urunTipi.ValueMember = "UrunTipiId";
                urunTipi.DataSource = urunTipleri.ToList();

                var markalar = from m in context.TradeMarks
                               select m;
                marka.DisplayMember = "MarkaAdi";
                marka.ValueMember = "MarkaId";
                marka.DataSource = markalar.ToList();


            }
        }

        public void urunSil(int id)
        {
            using (var context = new AkMarketContext())
            {
                Product product = context.Products.Find(id);
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public void kategorilereGoreStokAdetleri(Chart chart)
        {
            using (var context = new AkMarketContext())
            {

                var liste = from p in context.Products
                            join
                            c in context.Categories on
                            p.UrunKategori equals c.KategoriId
                            group p by c.KategoriAdi
                            into g
                            select new
                            {
                                Kategori = g.Key,
                                UrunAdedi = g.Sum(p=> p.StokAdedi)
                            };
                foreach(var temp in liste.ToList())
                {
                    chart.Series["Kategoriler"].Points.AddXY(temp.Kategori+" ("+temp.UrunAdedi+"  adet)", temp.UrunAdedi);
                }

            }
   
        }

        public void kategorilereGoreStokDegerleri(Chart chart)
        {
            using (var context = new AkMarketContext())
            {

                var liste = from p in context.Products
                            join
                            c in context.Categories on
                            p.UrunKategori equals c.KategoriId
                            group p by c.KategoriAdi
                            into g
                            select new
                            {
                                Kategori = g.Key,
                                StokDegeri = g.Sum(p => (p.StokAdedi*p.UrunFiyati))
                            };
                foreach (var temp in liste.ToList())
                {
                    chart.Series["Kategoriler"].Points.AddXY(temp.Kategori+"- "+temp.StokDegeri+"  TL", temp.StokDegeri);
                }

            }

        }

        public void urunTiplerineGoreStokAdetleri(Chart chart)
        {
            using(var context = new AkMarketContext())
            {
                var liste = from p in context.Products
                            join
                            pt in context.ProductTypes on
                            p.UrunTipi equals pt.UrunTipiId
                            group p by pt.UrunTipiAdi
                            into g
                            select new
                            {
                                UrunTipi = g.Key,
                                UrunAdedi = g.Sum(p => p.StokAdedi)
                            };
                foreach(var temp in liste.ToList())
                {
                    chart.Series["Kategoriler"].Points.AddXY(temp.UrunTipi+" ("+temp.UrunAdedi+"  adet)",temp.UrunAdedi);
                }

            }
        }

        public void urunTiplerineGoreStokDegerleri(Chart chart)
        {
            using (var context = new AkMarketContext())
            {
                var liste = from p in context.Products
                            join
                            pt in context.ProductTypes on
                            p.UrunTipi equals pt.UrunTipiId
                            group p by pt.UrunTipiAdi
                            into g
                            select new
                            {
                                UrunTipi = g.Key,
                                StokDegeri = g.Sum(p => (p.StokAdedi * p.UrunFiyati))
                            };

                foreach (var temp in liste.ToList())
                {
                    chart.Series["Kategoriler"].Points.AddXY(temp.UrunTipi+"- "+temp.StokDegeri+"  TL", temp.StokDegeri);
                }

            }

                
        }

        public void MarkalaraGoreStokAdetleri(Chart chart)
        {
            using (var context = new AkMarketContext())
            {
                var liste = from p in context.Products
                            join
                            m in context.TradeMarks on
                            p.Marka equals m.MarkaId
                            group p by m.MarkaAdi
                            into g
                            select new
                            {
                                MarkaAdi = g.Key,
                                UrunAdedi = g.Sum(p => p.StokAdedi)
                            };
                foreach (var temp in liste.ToList())
                {
                    chart.Series["Kategoriler"].Points.AddXY(temp.MarkaAdi+" ("+temp.UrunAdedi+"  adet)", temp.UrunAdedi);
                }

            }
        }

        public void MarkalaraGoreStokDegerleri(Chart chart)
        {
            using (var context = new AkMarketContext())
            {
                var liste = from p in context.Products
                            join
                            m in context.TradeMarks on
                            p.Marka equals m.MarkaId
                            group p by m.MarkaAdi
                            into g
                            select new
                            {
                                MarkaAdi = g.Key,
                                StokDegeri = g.Sum(p => (p.StokAdedi*p.UrunFiyati))
                            };
                foreach (var temp in liste.ToList())
                {
                    chart.Series["Kategoriler"].Points.AddXY(temp.MarkaAdi+"- "+temp.StokDegeri+"  TL", temp.StokDegeri);
                }

            }
        }   

        public void toplamSatirGoster(Label label, DataGridView dataGridView)
        {
            int toplam = dataGridView.RowCount;
            label.Text = toplam + " adet sonuç gösteriliyor.";
        }

    }
}


 