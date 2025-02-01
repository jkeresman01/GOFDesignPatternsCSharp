namespace Observer;

public class DataSource
{
    private IList<int> _values = new List<int>();
    public IList<Object> Observers { get; set; }  = new List<Object>();
    
    public IList<int> Values
    {
        get => _values;
        set
        {
            _values = value;
            
            foreach (var observer in Observers)
            {
                if (observer is Sheet2 sheet)
                {
                    sheet.Calculate(_values);
                }

                if (observer is BarChart barChart)
                {
                    barChart.Render(_values);
                }
            }
        }
    }
}