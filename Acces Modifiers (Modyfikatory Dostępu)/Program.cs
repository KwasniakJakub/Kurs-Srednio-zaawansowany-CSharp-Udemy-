using Amazon;

namespace Acces_Modifiers__Modyfikatory_Dostępu_
{
    //public class GoldCustomer : Customer
    //{
    //    public void OfferVoucher()
    //    {
    //        var rating = this.CalculateRating(excludeOrders: true)
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            Amazon.RateCalculator = new RateCalculator();
        }
    }
}
