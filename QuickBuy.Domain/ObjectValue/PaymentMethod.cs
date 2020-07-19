using QuickBuy.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.ObjectValue
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsUndefined { get => Id == (int)PaymentMethodEnum.Undefined; }
        public bool IsBankSlip { get => Id == (int)PaymentMethodEnum.BankSlip; }
        public bool IsBankDeposit { get => Id == (int)PaymentMethodEnum.BankDeposit; }
        public bool IsCreditCard { get => Id == (int)PaymentMethodEnum.CreditCard; }
    }
}
