namespace State.Solution;

public class PublishedState : State
{
    private Document _document;
    
    public PublishedState(Document document)
    {
        _document = document;
    }

    public override string ToString() => "Published";
    
    public void Publish()
    {
        Console.WriteLine($"Publishing... {_document}");
    }
}