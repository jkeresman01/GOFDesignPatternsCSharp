using System.Net.Mime;

namespace Flyweigth.Solution;

public class CropIconFactory
{
    private IDictionary<CropType, CropIcon> _icons = new Dictionary<CropType, CropIcon>();

    public CropIcon GetCropIcon(CropType cropType)
    {
        if(!_icons.ContainsKey(cropType))
        {
            var icon = new CropIcon(cropType, null);
            _icons.Add(cropType, icon);
        }
        
        return _icons[cropType];
    }
}