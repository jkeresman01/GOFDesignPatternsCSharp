namespace TemplateMethod.SolutionStrategy;

public class Camomile : IBevarage
{
    public void Prepare()
    {
        Brew();
    }

    private void Brew()
    {
        Console.WriteLine("Brewing for 3 minutes");
    }
}