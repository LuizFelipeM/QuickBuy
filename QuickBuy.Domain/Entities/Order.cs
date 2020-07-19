using QuickBuy.Domain.ObjectValue;
using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Orders must have one or multiple items
        /// </summary>
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
