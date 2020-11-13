using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class NoAnimal : Animal
    {
        public NoAnimal() 
            :base()
        {
        }

        public override AnimalType AnimalType => AnimalType.NoAnimal;

        public override void MakeSound()
        {
            Console.WriteLine(" {{NoAnimal Type}} is Selected : Animal does not Created, This is a null class.");
        }
    }
}
