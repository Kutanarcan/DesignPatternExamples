using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class SelectedGenerateAnimalFactory : AnimalFactory
    {
        public SelectedGenerateAnimalFactory()
            : base()
        {
        }

        public override Animal GetAnimal(AnimalType animalType)
        {
            Animal animal = null;

            if (animalByType.ContainsKey(animalType))
            {
                Type type = animalByType[animalType];
                animal = Activator.CreateInstance(type) as Animal;
            }
                

            return animal;
        }
    }
}
