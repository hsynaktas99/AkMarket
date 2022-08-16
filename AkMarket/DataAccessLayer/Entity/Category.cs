using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkMarket.DataAccessLayer.Entity
{
    class Category
    {
        [Key]
        public byte KategoriId { get; set; }
        
        public string KategoriAdi { get; set; }
    }
}
