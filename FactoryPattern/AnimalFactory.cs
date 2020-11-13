using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FactoryPattern
{
    public abstract class AnimalFactory
    {
        protected Dictionary<AnimalType, Type> animalByType;

        public AnimalFactory()
        {
            InitializeAnimalDictionary();
        }

        void InitializeAnimalDictionary()
        {
            var animalTypes = Assembly.GetAssembly(typeof(Animal)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract &&  myType.IsSubclassOf(typeof(Animal)));

            animalByType = new Dictionary<AnimalType, Type>();

            foreach (var type in animalTypes)
            {
                var tmpAnimal = Activator.CreateInstance(type) as Animal;
                animalByType.Add(tmpAnimal.AnimalType, type);
            }
        }

        public abstract Animal GetAnimal(AnimalType animalType);
    }
}
