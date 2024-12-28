namespace Mediator;

public class Button : UIControl
{
    private bool _isEnabled;
        
    public Button(DialogBox owner) : base(owner)
    {
    }

    public bool IsEnabled
    {
        get => _isEnabled;
        set
        {
            _isEnabled = value;
            _owner.Changed(this);
        }
    }
}