using System;

namespace Constructors__Inheritnce__Konstruktory__Dziedziczenie_
{
    public class Vehicle
    {
        public readonly string _registrationNumber;
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized.");
        //}
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initialized. {0} ",registrationNumber);
        }
    }
}
