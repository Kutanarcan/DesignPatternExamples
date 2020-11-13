using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Investor:IInvestor
    {
        private string investorName;
        private Stock stock;

        public Investor(string name)
        {
            investorName = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"{investorName} Notified : {stock.Symbol} Price is changed to: {stock.Price}");
        }
    }
}
