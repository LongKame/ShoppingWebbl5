using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingWebbl5.Models
{
    public partial class Account
    {
        public Account()
        {
            Carts = new HashSet<Cart>();
            CheckOuts = new HashSet<CheckOut>();
            Comments = new HashSet<Comment>();
            Information = new HashSet<Information>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int IdRole { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreate { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<CheckOut> CheckOuts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Information> Information { get; set; }
    }
}
