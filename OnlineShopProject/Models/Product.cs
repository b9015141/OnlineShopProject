using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopProject.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string ProductName { get; set; }
        public string PrDescription { get; set; }

        public string Image { get; set; }
        public int PrSize { get; set; }

        public string PrColor { get; set; }

        public int PrPrice { get; set; }

        public int PrPriceSale { get; set; }

        public DateTime DateTime { get; set; }
    }
}

