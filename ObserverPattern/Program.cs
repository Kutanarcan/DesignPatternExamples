using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBM ibm = new IBM("IBM", 120.0);

            Investor investor1 = new Investor("John");
            Investor investor2 = new Investor("Jack");
            Investor investor3 = new Investor("Emily");
            Investor investor4 = new Investor("Scarlett");

            ibm.AddAllListeners(investor1, investor2, investor3, investor4);

            ibm.CalculatePriceChange(130.0);

            Console.ReadKey();
        }
    }
}
