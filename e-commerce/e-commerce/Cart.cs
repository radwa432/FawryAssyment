using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    class Cart
    {
        public List<CartItems> Items { get; set; } = new List<CartItems>();

        public void AddItem(CartItems item)
        {
            Items.Add(item);
        }
        public bool isEmpty()
        {
            return Items.Count == 0;
        }
        public float subtotal()
        {
            float total = 0;
            foreach (var item in Items)
            {
                total += item.GetTotalPrice();
            }
            return total;
        }
        public float totalShippingCost()
        {
            float totalShipping = 0;
            foreach (var item in Items)
            {
                totalShipping += item.GetShippingCost();
            }
            return totalShipping;
        }
        public float total ()
        {
            return subtotal() + totalShippingCost();
        }

    }
}
