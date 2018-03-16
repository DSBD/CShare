using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartExample.Payment
{
    public interface IPay
    {
        bool Charge();
    }
}
