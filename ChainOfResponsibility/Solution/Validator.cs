using ChainOfResponsibility.Problem;

namespace ChainOfResponsibility.Solution;

public class Validator : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine($"Validating request {request}");
        
        var username = request.Username;
        var password = request.Password;
        
        request.ValidatedUsername = username.Trim();
        request.ValidatedPassword = password.Trim();
        
        bool isUsernameInValid = string.IsNullOrEmpty(request.ValidatedUsername);
        bool isPasswordInValid = string.IsNullOrEmpty(request.Password);
        
        return isPasswordInValid || isUsernameInValid;
    }
 }