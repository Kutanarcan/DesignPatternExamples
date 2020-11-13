using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Bird : Animal
    {
        public override AnimalType AnimalType => AnimalType.Bird;

        public override void MakeSound()
        {
            Console.WriteLine("I Sound Like a BIRD.");
        }
    }
}
