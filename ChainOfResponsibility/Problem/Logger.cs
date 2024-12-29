namespace ChainOfResponsibility.Problem;

public class Logger
{
    public void Log(HttpRequest request)
    {
        Console.WriteLine($"Username: {request.Username}");
        Console.WriteLine($"Password: {request.Password}");
    }
}