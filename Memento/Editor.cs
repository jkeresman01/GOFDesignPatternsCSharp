namespace Memento;

//Originator in GOF - Design patterns
public class Editor
{
    public required string Title { get; set; }
    public required string Content { get; set; }

    public override string ToString() => $"Title: {Title}, Content: {Content}";
    
    public EditorState CreateState() => new(Title, Content);

    public void RestoreState(EditorState editorState)
    {
        Title = editorState.Title;
        Content = editorState.Content;
    }
}