using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartExample.Payment;

namespace ShoppingCartExample
{
    public class ShoppingCart
    {
        private List<Item> _items;

        public ShoppingCart()
        {
            _items = new List<Item>();
        }

        public int ItemsCount
        {
            get { return _items.Count; }
        }

        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            _items.Remove(item);
        }

        public int CalculateTotal()
        {
            int runningTotal = 0;

            foreach (Item curItem in _items)
            {
                runningTotal += curItem.Price;
            }

            return runningTotal;
        }

        public bool Pay(IPay cr)
        {
            return cr.Charge();
        }
    }
}
