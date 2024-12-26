namespace Memento;

//Memento - GOF Design patterns
public class EditorState
{
    private readonly string _title;
    private readonly string _content;
    private readonly DateTime _createdAt;

    public EditorState(string title, string content)
    {
        _title = title;
        _content = content;
        _createdAt = DateTime.Now;
    }

    public override string ToString() 
        => $"Title: {_title}, Content: {_content}, Created at: {_createdAt}";
    
    public string Title => _title;
    public string Content => _content;
    public DateTime CreatedAt => _createdAt;
}