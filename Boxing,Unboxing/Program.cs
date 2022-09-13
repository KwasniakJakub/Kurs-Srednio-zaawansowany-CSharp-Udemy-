using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1); //Dzieje się boks
            list.Add("Mosh");
            list.Add(DateTime.Today);  //Dzieje się boks
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //var number = (int)list[1]; 
            var anotherList = new List<int>();
            //anotherList.Add(1);
            var names = new List<string>();
            names.Add("Jakub");
        }
    }
}
