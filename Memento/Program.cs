//Memento

//The Memento Pattern is used to restore and object to previous state

using Memento;
using Memento.obj;

var editor = new Editor()
{
    Title = "Test",
    Content = "Test content"
}; 

var history = new History(editor);
history.Backup();

editor.Title = "Test 2";
history.Backup();

editor.Content = "Test content 2";
history.Backup();

editor.Title = "Memento";
history.Backup();

Console.WriteLine($"Last editor state: {editor}");

history.Undo();
Console.WriteLine($"After undo: {editor}");

Console.WriteLine(history);