using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (string.IsNullOrEmpty(Name))
                AddValidationMessage("Product must have a name");

            if (string.IsNullOrEmpty(Description))
                AddValidationMessage("Product must have a description");

            if (Price == 0)
                AddValidationMessage("Product must have a price");
        }
    }
}
