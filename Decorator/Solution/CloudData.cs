namespace Decorator.Solution;

public class CloudData : IData
{
    protected string _url;

    public CloudData(string url)
    {
        _url = url;
    }
    
    public void Save(string data)
        => Console.WriteLine($"Saving data {data} to cloud at URL location: {_url}");
}