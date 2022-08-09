using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingWebbl5.Models
{
    public partial class Information
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Dob { get; set; }
        public string Phone { get; set; }
        public int IdAccount { get; set; }
        public string Address { get; set; }

        public virtual Account IdAccountNavigation { get; set; }
    }
}
