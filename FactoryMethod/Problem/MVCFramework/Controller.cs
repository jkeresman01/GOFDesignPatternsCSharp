namespace FactoryMethod;

public class Controller
{
    public void Render(string filename, IDictionary<string, object> data)
    {
        IViewEngine viewEngine = new BladeViewEngine();
        var html = viewEngine.Render(filename, data);
        Console.WriteLine(html);
    }
}