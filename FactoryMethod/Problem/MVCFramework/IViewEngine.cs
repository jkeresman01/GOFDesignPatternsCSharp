namespace FactoryMethod;

public interface IViewEngine
{
    string Render(string filename, IDictionary<string, object> data);
}