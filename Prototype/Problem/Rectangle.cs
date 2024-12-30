namespace Prototype;

public class Rectangle : IShape
{
    public double Width { get; set; } = 10;
    public double Height { get; set; } = 5;

    public Rectangle() { }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override string ToString() => $"Rectangle => {Width}x{Height}";

    public void Draw() => Console.WriteLine("Drawing rectangle!");
}