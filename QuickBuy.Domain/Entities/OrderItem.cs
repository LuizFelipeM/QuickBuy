using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public int Quantity { get; set; }

        /// <summary>
        /// Relationships
        /// </summary>
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (Quantity <= 0)
                AddValidationMessage("Must have at least one product");
        }
    }
}
