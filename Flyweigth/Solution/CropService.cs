namespace Flyweigth.Solution;

public class CropService
{
    private CropIconFactory _iconFactory;

    public CropService(CropIconFactory iconFactory)
    {
        _iconFactory = iconFactory;
    }

    public List<Crop> GetCrops()
    {
        var crops = new List<Crop>();

        var cropIcon = _iconFactory.GetCropIcon(CropType.Carrot);
        
        crops.Add(new Crop(1, 4,  cropIcon));
        crops.Add(new Crop(1, 5,  cropIcon));
        crops.Add(new Crop(1, 6,  cropIcon));
        
        return crops;
    }
}