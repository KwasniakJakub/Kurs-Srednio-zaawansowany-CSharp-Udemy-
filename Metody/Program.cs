using System;

namespace Metody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse("abc");

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number); ;
            }
            else
            {
                Console.WriteLine("Błąd konwersji");
            }
        }
        static void useParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
        }
        static void usePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Punkt ma współrzędne {0} {1}", point.X, point.Y);

                point.Move(200, 200);
                Console.WriteLine("Punkt ma współrzędne {0} {1}", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("Wystąpił nieoczekiwany błąd");
            }
        }
    }
}
