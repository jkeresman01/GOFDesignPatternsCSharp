namespace Visitor.Solution;

public abstract class Client
{
    public string Name { get; set; }
    public string Email { get; set; }

    public override string ToString() => $"Name: {Name}, Email: {Email}";

    protected Client(string name, string email)
    {
        Name = name;
        Email = email;
    }
    
    public abstract void Accept(Visitor visitor);
}