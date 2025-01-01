namespace Flyweigth.Solution;

public class CropIcon
{
    private readonly byte[] _icon;
    public CropType Type { get; }

    public CropIcon(CropType type, byte[] icon)
    {
        Type = type;
        _icon = icon;
    }

    public override string ToString() => $"CropIcon: {Type}: {_icon}";
}