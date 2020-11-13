using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory randomFactory = new RandomGenerateAnimalFactory();
            AnimalFactory selectedFactory = new SelectedGenerateAnimalFactory();

            Animal randomAnimal = randomFactory.GetAnimal(AnimalType.NoAnimal);
            Animal randomAnimal2 = randomFactory.GetAnimal(AnimalType.NoAnimal);
            Animal randomAnimal3 = randomFactory.GetAnimal(AnimalType.NoAnimal);

            Animal dog = selectedFactory.GetAnimal(AnimalType.Dog);
            Animal cat = selectedFactory.GetAnimal(AnimalType.Cat);
            Animal bird= selectedFactory.GetAnimal(AnimalType.Bird);
            Animal noAnimal = selectedFactory.GetAnimal(AnimalType.NoAnimal);

            randomAnimal.MakeSound();
            randomAnimal2.MakeSound();
            randomAnimal3.MakeSound();

            Console.WriteLine();

            noAnimal.MakeSound();
            Console.WriteLine();

            dog.MakeSound();
            cat.MakeSound();
            bird.MakeSound();

            Console.ReadKey();
        }
    }
}
