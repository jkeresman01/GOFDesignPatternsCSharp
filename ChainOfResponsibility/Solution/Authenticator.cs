using ChainOfResponsibility.Problem;

namespace ChainOfResponsibility.Solution;

public class Authenticator : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine($"Authenticating request {request}");
        
        var username = request.Username;
        var password = request.Password;
        
        bool isUsernameValid = username.Trim().Length > 5;
        bool isPasswordValid = password.Trim().Length > 5;
        
        return !(isUsernameValid && isPasswordValid);
    }
}