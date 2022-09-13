using System;
using System.Collections.Generic;

namespace Konstruktory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";

            var order = new Order();
            //customer.Orders = new List<Order>(); Zły sposób
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
