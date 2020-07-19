using QuickBuy.Domain.ObjectValue;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public class Order : BaseEntity
    {

        public DateTime OrderDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }

        /// <summary>
        /// Relationships
        /// </summary>
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public int PaymentMethodId { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Orders must have one or multiple items
        /// </summary>
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (!OrderItems.Any())
                AddValidationMessage("Order must have items");

            if (UserId == 0)
                AddValidationMessage("Order must have a user referenced");

            if(AddressId == 0)
                AddValidationMessage("Order must have a address referenced");
        }
    }
}
