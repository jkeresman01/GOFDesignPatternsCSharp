namespace FactoryMethod;

public class BladeViewEngine : IViewEngine
{
    public string Render(string filename, IDictionary<string, object> data)
        => $"View rendered from {filename} by Blade!";
}