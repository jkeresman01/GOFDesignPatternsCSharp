namespace Decorator.Solution;

public abstract class DataDecorator : IData
{
    protected IData _data;

    public DataDecorator(IData data)
    {
        _data = data;
    }

    public abstract void Save(string data);
}