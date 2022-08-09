using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingWebbl5.Models
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
            CheckOuts = new HashSet<CheckOut>();
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int IdCategory { get; set; }
        public int IdBrand { get; set; }
        public string Original { get; set; }
        public string Description { get; set; }
        public int View { get; set; }

        public virtual Brand IdBrandNavigation { get; set; }
        public virtual Category IdCategoryNavigation { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<CheckOut> CheckOuts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
