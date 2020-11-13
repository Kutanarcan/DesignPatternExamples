using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategy.MoveStrategy
{
    class NoMoveStrategy : IAnimalMoveStrategy
    {
        public void DoMove()
        {
            Console.WriteLine("No Movement On This Animal.");
        }
    }
}
