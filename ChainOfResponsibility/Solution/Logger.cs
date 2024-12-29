using ChainOfResponsibility.Problem;

namespace ChainOfResponsibility.Solution;

public class Logger : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine($"Username: {request.Username}");
        Console.WriteLine($"Password: {request.Password}");
        
        return false;
    }
}