using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkMarket.DataAccessLayer.Entity
{
    class Product
    {
        [Key]
        public int UrunId { get; set; }

        public byte UrunKategori { get; set; }
        public byte UrunTipi { get; set; }
        public byte Marka { get; set; }
        public string UrunAdi { get; set; }
        public int GramAgirlik { get; set; }
        public decimal UrunFiyati { get; set; }
        public int StokAdedi { get; set; }
        public DateTime KayitTarihi { get; set; }

    }
}
