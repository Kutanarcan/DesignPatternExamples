using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategy.FlyStrategy
{
    class NoFlyStrategy : IAnimalFlyStrategy
    {
        public void Fly()
        {
            Console.WriteLine("I Cannot Fly");
        }
    }
}
