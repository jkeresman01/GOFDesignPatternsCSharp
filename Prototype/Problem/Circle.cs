namespace Prototype;

public class Circle : IShape
{
    public int Radius { get; set; } = 5;

    public Circle()
    {
    }
    
    public Circle(int radius)
    {
        Radius = radius;
    }

    public override string ToString() => $"Circle => radius:{Radius}";

    public void Draw() => Console.WriteLine("Drawing circle!");
}