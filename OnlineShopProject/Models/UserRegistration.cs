using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopProject.Models
{
    public class UserRegistration
    {

        [Key]
        public int UserID { get; set; }

    
        public string UserName { get; set; }

        
        public string Email { get; set; }

        public int Number { get; set; }

    
        public int HouseNo{ get; set; }


        public string Street { get; set; }

        public string City { get; set; }
        public string Country { get; set; }

        public int Password { get; set; }

        public DateTime UserRegistered { get; set; }
    }
}
