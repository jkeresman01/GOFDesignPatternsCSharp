namespace Flyweigth;

public class CropService
{
    public IList<Crop> GetCrops()
    {
        var crops = new List<Crop>();
        
        crops.Add(new Crop(1, 4, CropType.Carrot, null));
        crops.Add(new Crop(1, 5, CropType.Carrot, null));
        crops.Add(new Crop(1, 6, CropType.Carrot, null));
        
        return crops;
    }
}