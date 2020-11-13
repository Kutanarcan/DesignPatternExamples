using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Rectangle : Shape
    {
        public void DrawShape()
        {
            Console.WriteLine("You Drawed a Rectangle");
        }
    }
}
