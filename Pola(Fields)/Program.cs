using System;

namespace Pola_Fields_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
            //Wypisuje ilość zamówień przypisanych do konkretnego klienta
        }
    }
}
