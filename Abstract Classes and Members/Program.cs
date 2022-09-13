using Microsoft.VisualBasic;

namespace Abstract_Classes_and_Members
{
    //Klas abstrakcyjnych używamy, m.in. gdy metoda jest zbyt abstrakcyjna
    //np. Metoda Draw przy klasie Shape(kształt) nie miałaby sensu,
    //ponieważ nie wiem jak narysować niewiadomy kształt
    //Dlatego też zapisujemy klasę Shape jako abstrakcyjną(bez implementacji metody Draw)
    //i zaimplementujemy metody w klasach pochodnych
    //Należy również pamiętać, że jeżeli metody są zadeklarowane jako abstrakcyjne
    //to sama klasa również musi być zadeklarowana jako abstrakcyjna
    //Nie można tworzyć instancji klas abstrakcyjnych
    internal class Program
    {
        static void Main(string[] args)
        {
            //var shape = new Shape(); Nie można utworzyć, ponieważ Shape jest abstrakcyjny 

            var circle = new Circle();
            circle.Draw();
            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
