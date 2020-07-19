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
    }
}
