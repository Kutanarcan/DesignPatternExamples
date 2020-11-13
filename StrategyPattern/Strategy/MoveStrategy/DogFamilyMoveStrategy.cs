using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategy.MoveStrategy
{
    class DogFamilyMoveStrategy : IAnimalMoveStrategy
    {
        public void DoMove()
        {
            Console.WriteLine("Dog Family Movement");
        }
    }
}
