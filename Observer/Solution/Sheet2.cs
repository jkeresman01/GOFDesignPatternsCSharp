namespace Observer.Solution;

public class Sheet2 : IObserver
{
    private readonly DataSource _dataSource;
    private int _total;

    public Sheet2(DataSource dataSource) => _dataSource = dataSource;

    public int Calculate() => _total;
    
    public void Update()
    {
        _total = _dataSource.Data.Sum();
        Console.WriteLine($"Sheet2: Total: {_total}");
    }
}