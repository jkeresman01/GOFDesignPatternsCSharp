namespace Observer;

public class BarChart
{
    public void Render(IList<int> values) 
        => Console.WriteLine($"Rendering pie chart: {values.Sum()}");
}