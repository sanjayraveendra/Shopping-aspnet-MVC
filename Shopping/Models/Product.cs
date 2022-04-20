using Shopping.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public String ProductDescription { get; set; }
        public int ProductRating { get; set; }
        public int ProductPrice { get; set; }
        public int ProductDiscount { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public int SellerId { get; set; }

        [ForeignKey("SellerId")]
        public Seller Seller { get; set; }
    }
}
