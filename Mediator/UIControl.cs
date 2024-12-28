namespace Mediator;

public abstract class UIControl
{
    protected DialogBox _owner;

    public UIControl(DialogBox owner)
    {
        _owner = owner;
    }
}