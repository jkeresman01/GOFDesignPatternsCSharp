namespace Flyweigth;

public class Crop
{
    private int _x;
    private int _y;
    private CropType _type;
    private byte[] _icon;

    public Crop(int x, int y, CropType type, byte[] icon)
    {
        _x = x;
        _y = y;
        _type = type;
        _icon = icon;
    }

    public override string ToString() => $"Crop({_x}, {_y}, {_type})";
    
    public void Render() => Console.WriteLine($"Drawing crop: {ToString()}");
}