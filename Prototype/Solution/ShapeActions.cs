namespace Prototype.Solution;

public class ShapeActions
{
    public static IShape Duplicate(IShape shape)
    {
        Console.WriteLine($"Duplicate shape: {shape}");
        return shape.Duplicate();
    }
}