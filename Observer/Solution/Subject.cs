namespace Observer.Solution;

public abstract class Subject
{
    private IList<IObserver> _observers = new List<IObserver>();
    
    public void AddObserver(IObserver observer) => _observers.Add(observer);
    public void RemoveObserver(IObserver observer) => _observers.Remove(observer);
    public void Notify() => _observers.ForEach(observer => observer.Update());
}