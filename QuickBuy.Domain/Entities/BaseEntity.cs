using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        private List<string> _validationMessage { get; set; }
        private List<string> validationMessage { get => _validationMessage ?? (_validationMessage = new List<string>()); }

        protected void AddValidationMessage(string message) => validationMessage.Add($"Error: {message}");
        protected void ClearValidationMessage() => validationMessage.Clear();

        public abstract void Validate();
        protected bool Isvalid { get => !validationMessage.Any(); }
    }
}
