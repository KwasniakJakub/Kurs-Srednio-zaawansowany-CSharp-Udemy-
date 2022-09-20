using System;

namespace Interface_and_Testability
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; internal set; }
        public float TotalPrice { get; set; }
      
        public bool IsShipped 
        { 
            get { return Shipment != null; }
        }
    }
}
