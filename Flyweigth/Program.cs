using Flyweigth.Solution;

var cropIconFactory = new CropIconFactory();
var cropService = new CropService(cropIconFactory);

List<Crop> crops = cropService.GetCrops();
crops.ForEach(crop => crop.Render());