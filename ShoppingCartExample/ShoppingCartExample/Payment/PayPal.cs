using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartExample.Payment
{
    class PayPal : IPay
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public bool Charge()
        {
            return false;
        }
    }
}
