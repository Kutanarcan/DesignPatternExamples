using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategy.FlyStrategy
{
    public class BirdFamilyFlyStrategy : IAnimalFlyStrategy
    {
        public void Fly()
        {
            Console.WriteLine("I Flying Like a Bird");
        }
    }
}
