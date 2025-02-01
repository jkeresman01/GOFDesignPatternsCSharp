namespace FactoryMethod;

public class TwigViewEngine : IViewEngine
{
    public string Render(string filename, IDictionary<string, object> data) 
        => $"View rendered from {filename} by Twig!";
}