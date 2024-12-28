using ChainOfResponsibility.UIFramework;

namespace ChainOfResponsibility;

public class PostsDialogBox
{
    public ListBox PostsListBox { get; set; }
    public Button SaveButton { get; set; }
    public TextBox TitleTextBox { get; set; }
    
    public PostsDialogBox()
    {
        PostsListBox = new ListBox();
        SaveButton = new Button();
        TitleTextBox = new TextBox();
        
        PostsListBox.AddEventHandler(PostSelected);
        TitleTextBox.AddEventHandler(TitleChanged);
    }

    private void PostSelected()
    {
        TitleTextBox.Text = PostsListBox.Selection;
        SaveButton.IsEnabled = true;
    }

    private void TitleChanged()
    {
        bool isTitleEmpty = string.IsNullOrEmpty(TitleTextBox.Text);
        SaveButton.IsEnabled = !isTitleEmpty;
    }
    
    
    public void SimulateUserIteraction()
    {
        PostsListBox.Selection = "Post 2";
        
        PrintResults();
    }
    public void SimulateUserIteraction2()
    {
        PostsListBox.Selection = "Post 2";
        TitleTextBox.Text = "";
        
        PrintResults();
    }

    private void PrintResults()
    {
        Console.WriteLine($"Title text box: {TitleTextBox.Text}");
        Console.WriteLine($"Button enabled: {SaveButton.IsEnabled}");
    }
}