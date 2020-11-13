using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class Animal
    {
        public abstract AnimalType AnimalType { get; }
        public abstract void MakeSound();
       
    }

    public enum AnimalType
    {
        NoAnimal,
        Dog,
        Cat,
        Bird
    }
}
