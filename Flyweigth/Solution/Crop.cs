namespace Flyweigth.Solution;

public class Crop
{
    
    private int _x;
    private int _y;
    private CropIcon _icon;

    public Crop(int x, int y, CropIcon icon)
    {
        _x = x;
        _y = y;
        _icon = icon;
    }

    public override string ToString() => $"Crop({_x}, {_y})";
    
    public void Render() => Console.WriteLine($"Drawing crop: {ToString()}");}