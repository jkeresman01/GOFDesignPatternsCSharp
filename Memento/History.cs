using System.Text;

namespace Memento.obj;

public class History
{
    private IList<EditorState> _states;
    private Editor _editor;

    public History(Editor editor)
    {
        _states = new List<EditorState>();
        _editor = editor;
    }

    public override string ToString()
    {
        var sb = new StringBuilder("\r\nHistory: Here's the list of mementos:\r\n");
        _states.ForEach(state => sb.Append($"{state}\r\n"));
        return sb.ToString();
    }

    public void Backup()
    {
        _states.Add(_editor.CreateState());
    }

    public void Undo()
    {
        if (_states.Count <= 0)
        {
            throw new Exception("No states have been restored");
        }

        _states.Remove(_states.Last());
        _editor.RestoreState(_states.Last());
    }
}