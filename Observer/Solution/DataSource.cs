namespace Observer.Solution;

public class DataSource : Subject
{
    private List<int> _data = new List<int>();

    public List<int> Data
    {
        get => _data;
        set
        {
            _data = value;
            Notify();
        }
    }
}