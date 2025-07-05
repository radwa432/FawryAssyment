using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    class Customer
    {

   
        public string Name { get; set; }
        public float Balance { get; set; }
        public Cart Cart { get; set; }
        public Customer( string name, float balance)
        {
            
            Name = name;
            Balance = balance;
         
        }
        public void checkout()
        {
            if (Cart.isEmpty())
            {
                Console.WriteLine("Your cart is empty. Please add items before checking out.");
                return;
            }
            float totalCost = Cart.total();
            if (totalCost > Balance)
            {
                Console.WriteLine("Insufficient balance for checkout.");
            }
            else
            {
                Balance -= totalCost;
                Console.WriteLine($"Checkout successful! Remaining balance: {Balance}");
                Cart.Items.Clear(); 
            }
        }
    }
}
