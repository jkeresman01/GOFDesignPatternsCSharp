namespace Prototype;

public class ShapeActions
{
    //!!!! violates SOLID => Open closed principle
    //!!!! coupled to concrete shape classes
    public static void Duplicate(IShape shape)
    {
        if (shape is Circle circle)
        {
            var newShape = new Circle(circle.Radius);
            newShape.Draw();
        }

        if (shape is Rectangle rectangle)
        {
            var newShape = new Rectangle(rectangle.Width, rectangle.Height);
            newShape.Draw();
        }
    }
}