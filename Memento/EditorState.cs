namespace Memento;

//Memento - GOF Design patterns
public class EditorState
{
    private readonly string _title;
    private readonly string _content;
    private readonly DateTime _stateCreatedAt;

    public EditorState(string title, string content)
    {
        _title = title;
        _content = content;
        _stateCreatedAt = DateTime.Now;
    }

    public override string ToString() 
        => $"Title: {_title}, Content: {_content}, Created at: {_stateCreatedAt}";
    
    public string Title => _title;
    public string Content => _content;
    public DateTime CreatedAt => _stateCreatedAt;
}