using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
