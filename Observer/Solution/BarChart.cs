namespace Observer.Solution;

public class BarChart : IObserver
{
    private readonly DataSource _dataSource;

    public BarChart(DataSource dataSource)
    {
        _dataSource = dataSource;
    }
    
    public void Update() => Console.WriteLine($"Updating bar chart {_dataSource.Data.Sum()}");
}