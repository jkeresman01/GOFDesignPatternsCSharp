namespace Observer;

public class DataSource
{
    private List<int> _values = new List<int>();
    public List<Object> Observers { get; set; }  = new List<Object>();
    
    public List<int> Values
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