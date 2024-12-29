namespace ChainOfResponsibility.Problem;

public class Validator
{
    public void Validate(HttpRequest request)
    {
        var username = request.Username;
        var password = request.Password;
        
        request.ValidatedUsername = username.Trim();
        request.ValidatedPassword = password.Trim();
    }
}