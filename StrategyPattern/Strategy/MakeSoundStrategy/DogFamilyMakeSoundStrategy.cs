using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategy.MakeSoundStrategy
{
    class DogFamilyMakeSoundStrategy : IAnimalMakeSoundStrategy
    {
        public void MakeSound()
        {
            Console.WriteLine("Making Sound Like a Dog Family");
        }
    }
}
