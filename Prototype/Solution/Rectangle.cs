namespace Prototype.Solution;

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle()
    {
    }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override string ToString() => $"Rectangle => {Width}, {Height}";

    public IShape Duplicate() => new Rectangle(Width, Height);

    public void Draw() => Console.WriteLine($"Drawing {ToString()}");
}