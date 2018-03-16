using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartExample.Payment
{
    class CreditCard : IPay
    {
        public long Number { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int CVV { get; set; }

        public bool Charge()
        {
            return false;
        }
    }
}
