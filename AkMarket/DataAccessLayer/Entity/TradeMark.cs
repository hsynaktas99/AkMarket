using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkMarket.DataAccessLayer.Entity
{
    class TradeMark
    {
        [Key]
        public byte MarkaId { get; set; }

        public string MarkaAdi { get; set; }
    }
}
