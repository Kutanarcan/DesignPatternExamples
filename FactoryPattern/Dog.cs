using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Dog : Animal
    {
        public override AnimalType AnimalType => AnimalType.Dog;

        public override void MakeSound()
        {
            Console.WriteLine("I Sound Like a DOG.");
        }
    }
}
