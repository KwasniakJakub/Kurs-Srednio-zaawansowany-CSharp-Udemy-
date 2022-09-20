using System;
using System.Drawing;
using System.Security.Cryptography;

//Interfejsy nie mają nic wspólnego z dziedziczeniem, ponieważ
//Nie można wykorzystać napisanego w nich kodu

namespace Interfaces_are_NOT_for_Multiple_Inheritance
{
    public class Position
    {

    }
    public class Size
    { 
    
    }
    public interface IDraggable
    {
        void Drag();
    }
    public interface IDroppable
    {
        void Drop();
    }
    public class TextBox : UiControll, IDraggable, IDroppable
    {
        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }
    public class UiControll
    {
        public string Id { get; set; }
        public Size size { get; set; }
        public Position TopLeft { get; set; }
        
        public virtual void Draw()
        {

        }
        public void Focus()
        {
            Console.WriteLine("Received focus.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
