namespace State.Solution;

public class DraftState : State
{
    private Document _document;

    public DraftState(Document document)
    {
        _document = document;
    }
    
    public override string ToString() => "Draft";
    public void Publish()
    {
        _document.State = new ModerationState(_document);
    }
}