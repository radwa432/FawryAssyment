using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    class NonExpiredProducts: products
    {
        public NonExpiredProducts(string name, float price, int quntity)
            : base(name, price, quntity)
        { }
        public override bool isExpired()
        {
            return false; 
        }
        public override float getshippingCost()
        {
            return 2.0f; 
        }
    }
}
