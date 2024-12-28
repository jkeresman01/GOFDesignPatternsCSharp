using System.Resources;

namespace Mediator;

//Concrete mediator class
public class PostsDialogBox : DialogBox
{
    public ListBox PostsListsBox { get; set; }
    public TextBox TitleTextBox { get; set; }
    public Button SaveButton { get; set; }

    public PostsDialogBox()
    {
        PostsListsBox = new ListBox(this);
        TitleTextBox = new TextBox(this);
        SaveButton = new Button(this);
    }

    public void SimulateUserIteraction()
    {
        PostsListsBox.Selection = "Post 2";
        
        PrintResults();
    }
    public void SimulateUserIteraction2()
    {
        PostsListsBox.Selection = "Post 2";
        TitleTextBox.Text = "";
        
        PrintResults();
    }

    private void PrintResults()
    {
        Console.WriteLine($"Title text box: {TitleTextBox.Text}");
        Console.WriteLine($"Button enabled: {SaveButton.IsEnabled}");
    }

    public override void Changed(UIControl uiControl)
    {
        if (uiControl.Equals(PostsListsBox))
        {
            HandlePostChanged();
        }

        if (uiControl.Equals(TitleTextBox))
        {
            HandleTitleChanged();
        }
    }

    private void HandlePostChanged()
    {
        TitleTextBox.Text = PostsListsBox.Selection;
        SaveButton.IsEnabled = true;
    }

    private void HandleTitleChanged()
    {
        bool isTitleEmpty = string.IsNullOrEmpty(TitleTextBox.Text);
        SaveButton.IsEnabled = !isTitleEmpty;
    }
}