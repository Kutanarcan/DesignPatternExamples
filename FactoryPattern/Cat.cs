using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Cat :Animal
    {
        public override AnimalType AnimalType => AnimalType.Cat;

        public override void MakeSound()
        {
            Console.WriteLine("I Sound Like a CAT.");
        }
    }
}
