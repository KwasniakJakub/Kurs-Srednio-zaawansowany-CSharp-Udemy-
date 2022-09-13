using System;

namespace Wprowadzenie_do_Klas
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hej {0}, nazywam się {1}", to, Name);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            //person.Name = "John";
            var person = Person.Parse("John");
            person.Introduce("Mosh");
        }
    }
}
