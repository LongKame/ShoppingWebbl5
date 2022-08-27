using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingWebbl5.Models
{
    public class TwoLists
    {
        private List<Brand> brands;
        private List<Category> categories;

        public List<Brand> Brands { get => brands; set => brands = value; }
        public List<Category> Categories { get => categories; set => categories = value; }

        public TwoLists(List<Brand> brands, List<Category> categories)
        {
            Brands = brands;
            Categories = categories;
        }
    }
}
