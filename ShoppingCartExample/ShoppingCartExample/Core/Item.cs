using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartExample
{
    public class Item
    {
        private int _price;
        private String _upcCode;

        public String UpcCode
        {
            get
            {
                return _upcCode;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("UPC Code Must Contain Data");
                }

                _upcCode = value;
            }
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price Must Be Positive");
                }

                _price = value;
            }
        }
    }
}
