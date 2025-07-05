using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    class ShippableProducts: products
    {

        public float weight { get; set; }
        public ShippableProducts(string name, float price, int quntity,float weight)
            : base(name, price, quntity)
        {
            this.weight = weight;   

        }
        public override bool isExpired()
        {
            return false; 
        }
        public override float getshippingCost()
        {
            return weight*10;
        }
    }
   
}
