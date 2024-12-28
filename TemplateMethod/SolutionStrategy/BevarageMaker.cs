namespace TemplateMethod.SolutionStrategy;

public class BevarageMaker
{
    public IBevarage Bevarage() { get; set};

    public BevarageMaker(IBevarage bevarage)
    {
        _bevarage = bevarage;
    }

    public void Make()
    {
        BoilWater();
        PourWaterInCup();
        Bevarage.Prepare();
    }
    
    private void BoilWater() => Console.WriteLine("Boiling water");
    
    private void PourWaterInCup() => Console.WriteLine("Pouring water in cup!");
    
}