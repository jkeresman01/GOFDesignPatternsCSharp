namespace ChainOfResponsibility.Problem;

public class Authenticator
{
    public bool Authenticate(HttpRequest request)
    {
        var username = request.Username;
        var password = request.Password;
        
        bool isUsernameValid = username.Trim().Length > 5;
        bool isPasswordValid = password.Trim().Length > 5;
        
        return isUsernameValid && isPasswordValid;
    }
}