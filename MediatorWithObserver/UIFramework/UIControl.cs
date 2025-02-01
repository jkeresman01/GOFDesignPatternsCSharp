namespace ChainOfResponsibility.UIFramework;

public class UIControl
{
    private IList<EventHandler> _handlers = new List<EventHandler>();
    
    public void AddEventHandler(EventHandler handler) => _handlers.Add(handler);
    public void RemoveEventHandler(EventHandler handler) => _handlers.Remove(handler);
    public void Notify() => _handlers.ForEach(handler => handler.Invoke());
}