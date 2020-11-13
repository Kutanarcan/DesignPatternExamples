using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape shape)
            : base(shape)
        {
        }

        public override void DrawShape()
        {
            decoratedShape.DrawShape();
            Console.WriteLine($"Decorated : Red Color");
        }
    }
}
