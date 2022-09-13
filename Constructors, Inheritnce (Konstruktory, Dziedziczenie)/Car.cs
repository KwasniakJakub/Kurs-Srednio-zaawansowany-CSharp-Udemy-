using System;

namespace Constructors__Inheritnce__Konstruktory__Dziedziczenie_
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0} ", registrationNumber);
        }
    }
}
