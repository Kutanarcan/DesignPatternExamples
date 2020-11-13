using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Animal
    {
        IAnimalMakeSoundStrategy makeSoundStrategy;
        IAnimalMoveStrategy moveStrategy;
        IAnimalFlyStrategy flyStrategy;

        public Animal(IAnimalMakeSoundStrategy makeSoundStrategy,
        IAnimalMoveStrategy moveStrategy,
        IAnimalFlyStrategy flyStrategy)
        {
            this.makeSoundStrategy = makeSoundStrategy;
            this.moveStrategy = moveStrategy;
            this.flyStrategy = flyStrategy;
        }

        public void MakeSound()
        {
            makeSoundStrategy.MakeSound();
        }

        public void Move()
        {
            moveStrategy.DoMove();
        }
        
        public void Fly()
        {
            flyStrategy.Fly();
        }
    }
}
