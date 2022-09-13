using System;

namespace Ineksatory_Indexers_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Jakub";
            Console.WriteLine(cookie["name"]);
        }
    }
}
