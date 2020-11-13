namespace DecoratorPattern
{
    abstract class ShapeDecorator : Shape
    {
        protected Shape decoratedShape;

        public ShapeDecorator(Shape shape)
        {
            decoratedShape = shape;
        }

        public abstract void DrawShape();
    }
}
