using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class RandomGenerateAnimalFactory : AnimalFactory
    {

        public RandomGenerateAnimalFactory()
            : base()
        {
        }

        public override Animal GetAnimal(AnimalType animalType = AnimalType.NoAnimal)
        {
            Animal animal = null;

            Random random = new Random();
            int randomNumber = random.Next(0, 101);

            if (randomNumber <= 33)
                return new Dog();

            if (randomNumber > 33 && randomNumber < 66)
                return new Cat();

            if (randomNumber >= 66)
                return new Bird();

            return animal;
        }
    }
}
