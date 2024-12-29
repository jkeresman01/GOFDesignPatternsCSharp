namespace Visitor;

public abstract class Client
{
    public string Name { get; set; }
    public string Email { get; set; }

    public Client(string name, string email)
    {
        Name = name;
        Email = email;
    }
    
    public abstract void SendEmail();
}