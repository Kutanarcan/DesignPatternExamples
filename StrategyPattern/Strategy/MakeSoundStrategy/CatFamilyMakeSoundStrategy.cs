using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategy.MakeSoundStrategy
{
    class CatFamilyMakeSoundStrategy : IAnimalMakeSoundStrategy
    {
        public void MakeSound()
        {
            Console.WriteLine("Making Sound Like a Cat Family");
        }
    }
}
