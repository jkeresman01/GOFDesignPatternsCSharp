namespace FactoryMethod;

public class BladeViewEngine : IViewEngine
{
    public string Render(string filename, Dictionary<string, object> data)
        => $"View rendered from {filename} by Blade!";
}