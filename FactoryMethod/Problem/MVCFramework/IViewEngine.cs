namespace FactoryMethod;

public interface IViewEngine
{
    string Render(string filename, Dictionary<string, object> data);
}