namespace State.Solution;

public class ModerationState : IState
{
    private Document _document;

    public ModerationState(Document document)
    {
        _document = document;
    }

    public override string ToString() => "Moderated";
    
    public void Publish()
    {
        if (_document.UserRole == UserRoles.Admin)
        {
            _document.State = new PublishedState(_document);
        }
    }
}