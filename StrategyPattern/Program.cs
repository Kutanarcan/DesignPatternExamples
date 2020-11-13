using System;
using StrategyPattern.Strategy.MakeSoundStrategy;
using StrategyPattern.Strategy.FlyStrategy;
using StrategyPattern.Strategy.MoveStrategy;
using System.Text;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal sparrow = new Animal(new BirdFamilyMakeSoundStrategy(), new NoMoveStrategy(), new BirdFamilyFlyStrategy());
            Animal cat = new Animal(new CatFamilyMakeSoundStrategy(), new CatFamilyMoveStrategy(), new NoFlyStrategy());
            Animal dog = new Animal(new DogFamilyMakeSoundStrategy(), new DogFamilyMoveStrategy(), new NoFlyStrategy());

            Console.WriteLine("-----Sparrow-----");
            sparrow.MakeSound();
            sparrow.Move();
            sparrow.Fly();

            Console.WriteLine("\n-----Cat-----");
            cat.MakeSound();
            cat.Move();
            cat.Fly();

            Console.WriteLine("\n-----Dog-----");
            dog.MakeSound();
            dog.Move();
            dog.Fly();

            Console.ReadKey();
        }
    }
}
