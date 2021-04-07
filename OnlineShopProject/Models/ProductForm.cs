using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopProject.Models
{
    public class ProductForm
    {

        [Key]
        public int Id{ get; set; }

        [Required(ErrorMessage = "Don't make us guess.  What product are we talking about?")]
        public string ProductName { get; set; }      

        public string PrDescription { get; set; }

        public string Image { get; set; }

        public int PrSize { get; set; }

        public string PrColor { get; set; }

        public int PrPrice { get; set; }

        public int PrPriceSale { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; }
    }
}
