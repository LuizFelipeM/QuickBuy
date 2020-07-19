using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (string.IsNullOrEmpty(CEP))
                AddValidationMessage("Address must have a CEP");
            
            if (Number == 0)
                AddValidationMessage("Must have a address number defined");
        }
    }
}
