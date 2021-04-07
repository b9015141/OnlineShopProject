using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopProject.Models
{
    public class OurWork
    {

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public string ContactEmail { get; set; }

        public string ContactNo { get; set; }
        public int Price { get; set; }

        public DateTime date{ get; set; }

    }
}
