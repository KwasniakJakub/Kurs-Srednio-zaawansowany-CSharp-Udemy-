using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders; 

        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
            :this()//Przed wykonaniem tej linii zostanie wywołany konstrukro wyżej
        {
            this.Id = id;
        }
        public Customer(int id , string name) : this(id)
        {
            this.Id = id;
            this.Name = name;        
        }
    }
}
