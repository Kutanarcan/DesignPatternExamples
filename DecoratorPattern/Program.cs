using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle();
            Shape rectangle = new Rectangle();

            RedShapeDecorator redCircle= new RedShapeDecorator(circle);
            RedShapeDecorator redRectangle= new RedShapeDecorator(rectangle);

            FillShapeDecorator fillRedCircle = new FillShapeDecorator(redCircle);
            FillShapeDecorator fillRedRectangle= new FillShapeDecorator(redRectangle);

            circle.DrawShape();
            rectangle.DrawShape();

            Console.WriteLine();

            redCircle.DrawShape();

            Console.WriteLine();

            redRectangle.DrawShape();

            Console.WriteLine();

            fillRedCircle.DrawShape();

            Console.WriteLine();

            fillRedRectangle.DrawShape();

            Console.ReadKey();
        }
    }
}
