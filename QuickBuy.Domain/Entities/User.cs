using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Users can have multiple orders
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (string.IsNullOrEmpty(Email))
                AddValidationMessage("User must have an email");

            if (string.IsNullOrEmpty(Password))
                AddValidationMessage("User must have an password");

            if (string.IsNullOrEmpty(FirstName))
                AddValidationMessage("User must have an first name");

            if (string.IsNullOrEmpty(LastName))
                AddValidationMessage("User must have an last name");
        }
    }
}
