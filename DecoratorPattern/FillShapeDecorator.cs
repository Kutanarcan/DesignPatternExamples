using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class FillShapeDecorator : ShapeDecorator
    {
        public FillShapeDecorator(Shape shape) 
            : base(shape)
        {
        }

        public override void DrawShape()
        {
            decoratedShape.DrawShape();
            Console.WriteLine("Decorated : Filled Inside With Green");
        }
    }
}
