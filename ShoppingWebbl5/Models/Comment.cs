using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingWebbl5.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdAccount { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public virtual Account IdAccountNavigation { get; set; }
        public virtual Product IdProductNavigation { get; set; }
    }
}
