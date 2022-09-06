using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingWebbl5.Models
{
    public class Edit
    {
        private int id;
        private string productName;
        private string image;
        private int quantity;
        private decimal price;
        private string category;
        private string brand;
        private string original;
        private string description;

        public Edit(int id, string productName, string image, int quantity, decimal price, string category, string brand, string original, string description)
        {
            this.Id = id;
            this.ProductName = productName;
            this.Image = image;
            this.Quantity = quantity;
            this.Price = price;
            this.Category = category;
            this.Brand = brand;
            this.Original = original;
            this.Description = description;
        }

        public int Id { get => id; set => id = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Image { get => image; set => image = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal Price { get => price; set => price = value; }
        public string Category { get => category; set => category = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Original { get => original; set => original = value; }
        public string Description { get => description; set => description = value; }
    }
}
