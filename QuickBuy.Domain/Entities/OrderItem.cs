using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
