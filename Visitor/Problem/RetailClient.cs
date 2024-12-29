namespace Visitor;

public class RetailClient : Client
{
    public RetailClient(string name, string email) : base(name, email)
    {
    }

    public override void SendEmail() => Console.WriteLine($"Sending retail marketing tips email to {Email}.");
}