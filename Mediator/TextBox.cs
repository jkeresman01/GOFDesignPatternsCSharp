namespace Mediator;

public class TextBox : UIControl
{
    private string _text;
    
    public TextBox(DialogBox owner) : base(owner)
    {
    }

    public string Text
    {
       get => _text;
       set
       {
           _text = value;
           _owner.Changed(this);
       }
    }
}