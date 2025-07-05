using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    class ExpiredProducts: products
    {
        public DateTime ExpiryDate { get; set; }
        public ExpiredProducts(string name, float price, int quntity, DateTime expiryDate)
            : base(name, price, quntity)
        {
            ExpiryDate = expiryDate;
        }
        public void CheckExpiry()
        {
            if (ExpiryDate < DateTime.Now)
            {
                Console.WriteLine($"{name} has expired.");
            }
            else
            {
                Console.WriteLine($"{name} is still valid until {ExpiryDate.ToShortDateString()}.");
            }
        }
        public override bool isExpired()
        {
            return ExpiryDate < DateTime.Now;
        }
        public override float getshippingCost()
        {
          
            return 5.0f; 
        }
    }

    
   
    }
