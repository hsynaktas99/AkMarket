using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkMarket.DataAccessLayer.Entity
{
    class ProductType
    {
        [Key]
        public byte UrunTipiId { get; set; }

        public string UrunTipiAdi { get; set; }
    }
}
