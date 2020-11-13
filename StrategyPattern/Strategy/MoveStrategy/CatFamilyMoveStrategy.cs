using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategy.MoveStrategy
{
    class CatFamilyMoveStrategy : IAnimalMoveStrategy
    {
        public void DoMove()
        {
            Console.WriteLine("Cat Family Movement");
        }
    }
}
