﻿using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Users can have multiple orders
        /// </summary>
        public ICollection<Order> Orders { get; set; }
    }
}
