namespace Command.Solution;

public class RemoteController
{
    public ICommand Command { get; set; }

    public RemoteController(ICommand command)
    {
        Command = command;
    }

    public void PressButton() => Command.Execute();
}