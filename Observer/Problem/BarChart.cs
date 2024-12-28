namespace Observer;

public class BarChart
{
    public void Render(List<int> values) 
        => Console.WriteLine($"Rendering pie chart: {values.Sum()}");
}