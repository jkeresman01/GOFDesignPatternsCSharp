namespace ChainOfResponsibility.Solution;

public class HttpRequest
{
    private string _username;
    private string _password;
    
    public string ValidatedUsername { get; set; }
    public string ValidatedPassword { get; set; }
    
    public HttpRequest(string username, string password)
    {
        _username = username;
        _password = password;
    }

    public override string ToString() => $"{_username} : {_password}";
    
    public string Username => _username;
    public string Password => _password;
}