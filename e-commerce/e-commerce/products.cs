using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    class products
    {
        public string name { get; set; }
        public float price { get; set; }
        public int quntity { get; set; }

        public products(string name, float price, int quntity)
        {
            this.name = name;
            this.price = price;
            this.quntity = quntity;
        }

        public void ReduceQuantity(int amount)
        {
            if (amount > quntity)
            {
                Console.WriteLine("Insufficient quantity available.");
            }
            else
            {
                quntity -= amount;
                Console.WriteLine($"Reduced quantity by {amount}. New quantity: {quntity}");
            }
        }
        public virtual bool isExpired()
        {
            return false;
        }
        public virtual float getshippingCost()
        {
            return 0.0f;
        }


    }
}
