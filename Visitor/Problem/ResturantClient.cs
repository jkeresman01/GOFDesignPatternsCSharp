namespace Visitor;

public class ResturantClient : Client
{
    public ResturantClient(string name, string email) : base(name, email)
    {
    }

    public override void SendEmail() => Console.WriteLine($"Sending restaurant marketing tips email to {Email}.");
}