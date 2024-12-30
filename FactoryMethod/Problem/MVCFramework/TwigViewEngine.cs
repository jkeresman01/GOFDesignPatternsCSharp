namespace FactoryMethod;

public class TwigViewEngine : IViewEngine
{
    public string Render(string filename, Dictionary<string, object> data) 
        => $"View rendered from {filename} by Twig!";
}