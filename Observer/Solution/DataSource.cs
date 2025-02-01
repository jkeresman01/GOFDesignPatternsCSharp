namespace Observer.Solution;

public class DataSource : Subject
{
    private IList<int> _data = new List<int>();

    public IList<int> Data
    {
        get => _data;
        set
        {
            _data = value;
            Notify();
        }
    }
}