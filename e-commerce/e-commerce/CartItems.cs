using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    class CartItems
    {
        public products Product { get; set; }
        public int Quantity { get; set; }
        public CartItems(products product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
     
        public float GetTotalPrice()
        {
            return Product.price * Quantity;
        }
        public float GetShippingCost()
        {
            return Product.getshippingCost() * Quantity;
        }
    }
}
