using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        public int ID { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int Viewcount { set; get; }
        public DateTime DateCreated { set; get; }
        public string SeoAlias { set; get; }
        public List<OrderDetail> OrderDetails { set; get;}
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<Cart> Carts { get; set; }
        public List<ProductTranslation>ProductTranslation { get; set; } 
    }
}
