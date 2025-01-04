namespace Prototype.Solution;

public class Circle : IShape
{
    public double Radius { get; set; };

    public Circle() => Radius = 5.0;
    public Circle(double radius) => Radius = radius;
    public override string ToString() => $"Circle({Radius})";
    public IShape Duplicate() => new Circle(Radius);
    public void Draw() => Console.WriteLine($"Drawing {ToString()}");
}