using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class Seller
    {
        public String SellerName { get; set; }
        public int SellerId { get; set; }

        //Relationships
        public List<Product> Products { get; set; }
    }
}
