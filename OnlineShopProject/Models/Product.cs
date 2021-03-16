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

        public string ProductPrice { get; set; }
    }
}
}
