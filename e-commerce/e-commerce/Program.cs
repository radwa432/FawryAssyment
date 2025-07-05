
// See https://aka.ms/new-console-template for more information

using e_commerce;
using System;


Customer customer = new Customer("John Doe", 100.0f);
Cart cart = new Cart();
customer.Cart = cart;
NonExpiredProducts product1 = new NonExpiredProducts("Laptop", 800.0f, 1);
ExpiredProducts product2 = new ExpiredProducts("Milk", 2.0f, 1, DateTime.Now.AddDays(-1));
NonExpiredProducts product3 = new NonExpiredProducts("Book", 15.0f, 2);
NonExpiredProducts product4 = new NonExpiredProducts("Headphones", 50.0f, 1);
NonExpiredProducts product5 = new NonExpiredProducts("Mouse", 20.0f, 1);
cart.AddItem(new CartItems(product1, 1));
cart.AddItem(new CartItems(product2, 1));
cart.AddItem(new CartItems(product3, 2));
cart.AddItem(new CartItems(product4, 1));
cart.AddItem(new CartItems(product5, 1));
Console.WriteLine($"Subtotal: {cart.subtotal()}");
Console.WriteLine($"Total Shipping Cost: {cart.totalShippingCost()}");
Console.WriteLine($"Total: {cart.total()}");
customer.checkout();
Console.WriteLine($"Remaining Balance: {customer.Balance}");
Console.WriteLine("Checking expiry of products:");
product1.isExpired();
if(product2.isExpired())
{
    Console.WriteLine($"{product2.name} is expired and cannot be purchased.");
}
else
{
    Console.WriteLine($"{product2.name} is valid for purchase.");
}
product3.isExpired();
product4.isExpired();
product5.isExpired();
Console.WriteLine("Checking expiry dates:");
product2.CheckExpiry();


