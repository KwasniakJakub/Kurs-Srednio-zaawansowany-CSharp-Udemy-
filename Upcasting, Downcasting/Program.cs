using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Upcasting__Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Text text = new Text();
            ////Upcasting
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;
            //Console.WriteLine(text.Width);

            //StreamReader reader = new StreamReader(new MemoryStream());

            var list = new ArrayList();
            list.Add(1);
            list.Add("abc");
            list.Add(new Text());

            //List może zawierać elementy 1 typu
            //Do ArrayList możemy dodawać elementy downolnego typu 

            var anotherList = new List<Shape>();


            //Downcasting


            Shape shape = new Text();
            Text text = (Text)shape;

        }
    }
}
