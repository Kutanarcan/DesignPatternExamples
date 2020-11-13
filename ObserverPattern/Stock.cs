using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public abstract class Stock
    {
        private string symbol;
        private double price;
        private List<IInvestor> investors = new List<IInvestor>();

        public string Symbol => symbol;
        public double Price => price;

        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void AddListener(IInvestor investor)
        {
            investors.Add(investor);
        }

        public void AddAllListeners(params IInvestor[] listeners)
        {
            investors.AddRange(listeners);
        }

        public void RemoveListener(IInvestor investor)
        {
            investors.Remove(investor);
        }

        public void NotifyListeners()
        {
            for (int i = 0; i < investors.Count; i++)
            {
                investors[i].Update(this);
            }
        }

        public void CalculatePriceChange(double price)
        {
            //Do some Calculation

            this.price = price;
            NotifyListeners();
        }
    }
}
